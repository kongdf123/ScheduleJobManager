using DataAccess.BLL;
using DataAccess.Entity;
using ServiceHost.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace ScheduleJobDesktop.UI.ManageScheduleJob
{
    /// <summary>
    /// 任务管理添加界面
    /// </summary>
    public partial class ScheduleJobEdit : UserControl
    {
        CustomJobDetail jobDetail;
        static ScheduleJobEdit instance;
        string jobHostSite = System.Configuration.ConfigurationManager.AppSettings["JobHostSite"];
        JobState preJobState = JobState.Waiting;
        string preCronExpression = "";

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static ScheduleJobEdit Instance {
            get {
                if (instance == null)
                {
                    instance = new ScheduleJobEdit();
                }
                instance.jobDetail = new CustomJobDetail(); // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
                return instance;
            }
        }

        public static ScheduleJobEdit BindJobDetail(CustomJobDetail job)
        {
            if (instance == null)
            {
                instance = new ScheduleJobEdit();
            }
            instance.jobDetail = job; // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
            instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
            return instance;
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private ScheduleJobEdit()
        {
            InitializeComponent();
            List<KeyValuePair<string, string>> listFreq = new List<KeyValuePair<string, string>>();
            listFreq.Add(new KeyValuePair<string, string>("循环执行", "1"));
            listFreq.Add(new KeyValuePair<string, string>("只执行一次", "2"));
            ComBoxFreq.DisplayMember = "Key";
            ComBoxFreq.ValueMember = "Value";
            ComBoxFreq.DataSource = listFreq;

            this.Dock = DockStyle.Fill;
        }

        public delegate void CallBackDelegate(FormSysMessage formSysMessage, string message);
        public void CallBackFunc(FormSysMessage formSysMessage, string message)
        {
            formSysMessage.SetMessage(message);
            System.Threading.Thread.Sleep(2000);
            formSysMessage.Close();

            FormMain.LoadNewControl(ScheduleJobList.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“保存”按钮时的事件处理方法。
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var formSysMessage = FormSysMessage.ShowLoading();

            BindFormlToObject(); // 进行数据绑定
            try
            {
                if (jobDetail.JobId > 0)
                {
                    int effected = CustomJobDetailBLL.CreateInstance().Update(jobDetail); // 调用“业务逻辑层”的方法，检查有效性后更新至数据库。
                    if (effected == 0)
                    {
                        return;
                    }

                    // 根据新的配置，更新寄宿服务里的任务计划
                    CustomJobDetailBLL.CreateInstance().ModifyHostJob(jobHostSite, jobDetail.JobId, jobDetail.JobName);

                    #region 开启或关闭任务计划

                    if (jobDetail.State == (byte)JobState.Running)
                    {
                        CustomJobDetailBLL.CreateInstance().StartHostJob(jobHostSite, jobDetail.JobId, jobDetail.JobName,
                                       () => { this.Invoke(new CallBackDelegate(CallBackFunc), formSysMessage, "启动任务计划成功。"); },
                                       () => { this.Invoke(new CallBackDelegate(CallBackFunc), formSysMessage, "启动任务计划失败。"); });
                    }
                    else if (jobDetail.State == (byte)JobState.Stopping || jobDetail.State == (byte)JobState.Waiting)
                    {
                        CustomJobDetailBLL.CreateInstance().StopHostJob(jobHostSite, jobDetail.JobId, jobDetail.JobName,
                                          () => { this.Invoke(new CallBackDelegate(CallBackFunc), formSysMessage, "关闭任务计划成功。"); },
                                          () => { this.Invoke(new CallBackDelegate(CallBackFunc), formSysMessage, "关闭任务计划失败。"); });
                    }
                    #endregion
                }
                else
                {
                    #region 添加任务计划
                    int newId = CustomJobDetailBLL.CreateInstance().Insert(jobDetail); // 调用“业务逻辑层”的方法，检查有效性后插入至数据库。
                    if (newId == 0)
                    {
                        return;
                    }
                    CustomJobDetailBLL.CreateInstance().AddHostJob(jobHostSite, jobDetail.JobId, jobDetail.JobName,
                                          () => { this.Invoke(new CallBackDelegate(CallBackFunc), formSysMessage, "添加任务计划成功。"); },
                                          () => { this.Invoke(new CallBackDelegate(CallBackFunc), formSysMessage, "添加任务计划失败。"); });

                    #endregion
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new CallBackDelegate(CallBackFunc), formSysMessage, "保存失败。");
                Log4NetHelper.WriteExcepetion(ex);
            }
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormMain.LoadNewControl(ScheduleJobList.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormlToObject()
        {
            jobDetail.JobChineseName = DataValid.GetNullOrString(TxtScheduleChineseName.Text);
            jobDetail.JobName = DataValid.GetNullOrString(TxtJobIdentity.Text);
            jobDetail.JobGroup = jobDetail.JobName + "_Group";
            jobDetail.JobServiceURL = DataValid.GetNullOrString(TxtServiceAddress.Text);
            jobDetail.State = GetJobState();

            if (ComBoxFreq.SelectedValue == null || string.IsNullOrEmpty(ComBoxFreq.SelectedValue.ToString()))
            {
                throw new CustomException("请选择执行频率！", ExceptionType.Warn);
            }
            jobDetail.ExecutedFreq = Convert.ToByte(ComBoxFreq.SelectedValue);
            jobDetail.StartDate = DateTimePickerStart.Value;
            jobDetail.EndDate = DateTimePickerEnd.Value;
            jobDetail.IntervalType = GetInterval().Item1;
            jobDetail.Interval = GetInterval().Item2;

            jobDetail.Description = DataValid.GetNullOrString(TxtNoteDescription.Text);  // 备注说明
        }

        /// <summary>
        /// 将关联对象中的值，绑定至界面控件进行显示。
        /// </summary>
        internal void BindObjectToForm()
        {
            TxtScheduleChineseName.Text = jobDetail.JobChineseName;
            TxtJobIdentity.Text = jobDetail.JobName;
            if (jobDetail.JobId > 0)
            {
                TxtJobIdentity.Enabled = false;
                //TxtJobIdentity.BoxBackColor = System.Drawing.Color.Gray;
            }

            TxtServiceAddress.Text = jobDetail.JobServiceURL;
            SetJobState(jobDetail.State);
            preJobState = (JobState)jobDetail.State;
            ComBoxFreq.SelectedValue = jobDetail.ExecutedFreq.ToString();
            if (jobDetail.StartDate > DateTime.MinValue)
            {
                DateTimePickerStart.Value = jobDetail.StartDate;
            }
            if (jobDetail.EndDate > DateTime.MinValue)
            {
                DateTimePickerEnd.Value = jobDetail.EndDate;
            }
            SetInterval(jobDetail.IntervalType, jobDetail.Interval);
            preCronExpression = jobDetail.CronExpression;

            TxtNoteDescription.Text = jobDetail.Description;  // 备注说明
        }

        Tuple<byte, int> GetInterval()
        {
            var radioButtons = PnlInterval.Controls.OfType<RadioButton>();
            if (radioButtons.Any(t => t.Checked))
            {
                var selected = radioButtons.First(t => t.Checked);
                switch (selected.Name)
                {
                    case "RadioBtnDay":
                        if (string.IsNullOrEmpty(TxtDay.Text))
                        {
                            break;
                        }
                        if (DataValid.GetNullOrInt(TxtDay.Text).Value > 30)
                        {
                            throw new CustomException("天数间隔不能大于30！", ExceptionType.Warn);
                        }
                        return Tuple.Create<byte, int>((byte)IntervalTypeEnum.Day, DataValid.GetNullOrInt(TxtDay.Text).Value);
                    case "RadioBtnHour":
                        if (string.IsNullOrEmpty(TxtHour.Text))
                        {
                            break;
                        }
                        if (DataValid.GetNullOrInt(TxtHour.Text).Value > 60)
                        {
                            throw new CustomException("小时间隔不能大于60！", ExceptionType.Warn);
                        }
                        return Tuple.Create<byte, int>((byte)IntervalTypeEnum.Hour, DataValid.GetNullOrInt(TxtHour.Text).Value);
                    case "RadioBtnMinute":
                        if (string.IsNullOrEmpty(TxtMinute.Text))
                        {
                            break;
                        }
                        if (DataValid.GetNullOrInt(TxtMinute.Text).Value > 60)
                        {
                            throw new CustomException("分钟间隔不能大于60！", ExceptionType.Warn);
                        }
                        return Tuple.Create<byte, int>((byte)IntervalTypeEnum.Minute, DataValid.GetNullOrInt(TxtMinute.Text).Value);
                    default:
                        break;
                }
            }
            throw new CustomException("请选择一个任务间隔类型并填写执行间隔！", ExceptionType.Warn);
        }

        byte GetJobState()
        {
            var radioButtons = PnlJobState.Controls.OfType<RadioButton>();
            if (radioButtons.Any(t => t.Checked))
            {
                var selected = radioButtons.First(t => t.Checked);
                switch (selected.Name)
                {
                    case "RadioBtnWaiting": return (byte)JobState.Waiting;
                    case "RadioBtnRunning": return (byte)JobState.Running;
                    case "RadioBtnStopping": return (byte)JobState.Stopping;
                    default:
                        break;
                }
            }
            throw new CustomException("请选择一个任务状态！", ExceptionType.Warn);
        }

        void SetInterval(byte intervalType, int interval)
        {
            switch ((IntervalTypeEnum)intervalType)
            {
                case IntervalTypeEnum.Day:
                    RadioBtnDay.Checked = true;
                    TxtDay.Text = interval.ToString();
                    break;
                case IntervalTypeEnum.Hour:
                    RadioBtnHour.Checked = true;
                    TxtHour.Text = interval.ToString();
                    break;
                case IntervalTypeEnum.Minute:
                    RadioBtnMinute.Checked = true;
                    TxtMinute.Text = interval.ToString();
                    break;
                default:
                    break;
            }
        }

        void SetJobState(byte jobState)
        {
            switch ((JobState)jobState)
            {
                case JobState.Waiting:
                    RadioBtnWaiting.Checked = true;
                    break;
                case JobState.Running:
                    RadioBtnRunning.Checked = true;
                    break;
                case JobState.Stopping:
                    RadioBtnStopping.Checked = true;
                    break;
                default:
                    break;
            }
        }
        #endregion 界面控件与关联对象之间的绑定方法
    }
}
