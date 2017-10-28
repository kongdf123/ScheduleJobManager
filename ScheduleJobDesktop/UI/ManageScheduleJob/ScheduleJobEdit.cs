using DataAccess.BLL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JobMonitor.Utility;
using JobMonitor.Core.Model;
using JobMonitor.Desktop.Biz;
using System.Threading;

namespace JobMonitor.Desktop.UI.ManageScheduleJob
{
    /// <summary>
    /// 任务管理添加界面
    /// </summary>
    public partial class ScheduleJobEdit : UserControl
    {
        CustomJobDetail jobDetail;
        static ScheduleJobEdit instance;
        JobState preJobState = JobState.Waiting;
        string preCronExpression = "";

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static ScheduleJobEdit Instance {
            get {
                if ( instance == null ) {
                    instance = new ScheduleJobEdit();
                }
                instance.jobDetail = new CustomJobDetail(); // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
                return instance;
            }
        }

        public static ScheduleJobEdit BindJobDetail(CustomJobDetail job) {
            if ( instance == null ) {
                instance = new ScheduleJobEdit();
            }
            instance.jobDetail = job; // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
            instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
            return instance;
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private ScheduleJobEdit() {
            InitializeComponent();
            List<KeyValuePair<string, string>> listFreq = new List<KeyValuePair<string, string>>();
            listFreq.Add(new KeyValuePair<string, string>("循环执行", "1"));
            listFreq.Add(new KeyValuePair<string, string>("只执行一次", "2"));
            ComBoxFreq.DisplayMember = "Key";
            ComBoxFreq.ValueMember = "Value";
            ComBoxFreq.DataSource = listFreq;

            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 用户单击“保存”按钮时的事件处理方法。
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e) {
            BindFormlToObject(); // 进行数据绑定
            Thread thread = new Thread(SaveScheduleJob);
            thread.Start();
        }

        void SaveScheduleJob() {
            var formSysMessage = FormSysMessage.ShowLoading();

            try {
                var jobDetailBLL = CustomJobDetailBLL.GetInstance();
                var effected = 0;
                if ( jobDetail.JobId > 0 ) {
                    effected = jobDetailBLL.Update(jobDetail);
                }
                else {
                    effected = jobDetailBLL.Insert(jobDetail);
                }
                if ( effected == 0 ) {
                    formSysMessage.Close();
                    FormSysMessage.ShowMessage("数据保存失败!");
                    return;
                }

                var jobSettingResult = SqlServerSyncJobHost.GetInstance().StoreJob(jobDetail.JobId, jobDetail.JobName);
                formSysMessage.Close();
                if ( jobSettingResult.State == ResultState.Success ) {
                    FormSysMessage.ShowMessage("保存成功。");
                }
                else {
                    jobDetail.State = (byte)JobState.Waiting;
                    jobDetailBLL.Update(jobDetail);
                    FormSysMessage.ShowMessage("任务计划状态设置失败！");
                }
            }
            catch ( Exception ex ) {
                formSysMessage.Close();
                FormSysMessage.ShowMessage($"保存出错!异常信息：{ex.Message}");
                Log4NetHelper.WriteExcepetion(ex);
            }
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e) {
            FormMain.LoadNewControl(ScheduleJobList.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormlToObject() {
            jobDetail.JobChineseName = DataValid.GetNullOrString(TxtScheduleChineseName.Text);
            jobDetail.JobName = DataValid.GetNullOrString(TxtJobIdentity.Text);
            jobDetail.JobGroup = jobDetail.JobName + "_Group";
            jobDetail.JobServiceURL = DataValid.GetNullOrString(TxtServiceAddress.Text);
            jobDetail.State = GetJobState();

            if ( ComBoxFreq.SelectedValue == null || string.IsNullOrEmpty(ComBoxFreq.SelectedValue.ToString()) ) {
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
        internal void BindObjectToForm() {
            TxtScheduleChineseName.Text = jobDetail.JobChineseName;
            TxtJobIdentity.Text = jobDetail.JobName;
            if ( jobDetail.JobId > 0 ) {
                TxtJobIdentity.Enabled = false;
                //TxtJobIdentity.BoxBackColor = System.Drawing.Color.Gray;
            }
            else {
                TxtJobIdentity.Enabled = true;
            }

            TxtServiceAddress.Text = jobDetail.JobServiceURL;
            SetJobState(jobDetail.State);
            preJobState = (JobState)jobDetail.State;
            ComBoxFreq.SelectedValue = jobDetail.ExecutedFreq.ToString();
            if ( jobDetail.StartDate > DateTime.MinValue ) {
                DateTimePickerStart.Value = jobDetail.StartDate;
            }
            if ( jobDetail.EndDate > DateTime.MinValue ) {
                DateTimePickerEnd.Value = jobDetail.EndDate;
            }
            SetInterval(jobDetail.IntervalType, jobDetail.Interval);
            preCronExpression = jobDetail.CronExpression;

            TxtNoteDescription.Text = jobDetail.Description;  // 备注说明
        }

        Tuple<byte, int> GetInterval() {
            var radioButtons = PnlInterval.Controls.OfType<RadioButton>();
            if ( radioButtons.Any(t => t.Checked) ) {
                var selected = radioButtons.First(t => t.Checked);
                switch ( selected.Name ) {
                    case "RadioBtnDay":
                        if ( string.IsNullOrEmpty(TxtDay.Text) ) {
                            break;
                        }
                        if ( DataValid.GetNullOrInt(TxtDay.Text).Value > 30 ) {
                            throw new CustomException("天数间隔不能大于30！", ExceptionType.Warn);
                        }
                        return Tuple.Create<byte, int>((byte)IntervalType.Day, DataValid.GetNullOrInt(TxtDay.Text).Value);
                    case "RadioBtnHour":
                        if ( string.IsNullOrEmpty(TxtHour.Text) ) {
                            break;
                        }
                        if ( DataValid.GetNullOrInt(TxtHour.Text).Value > 60 ) {
                            throw new CustomException("小时间隔不能大于60！", ExceptionType.Warn);
                        }
                        return Tuple.Create<byte, int>((byte)IntervalType.Hour, DataValid.GetNullOrInt(TxtHour.Text).Value);
                    case "RadioBtnMinute":
                        if ( string.IsNullOrEmpty(TxtMinute.Text) ) {
                            break;
                        }
                        if ( DataValid.GetNullOrInt(TxtMinute.Text).Value > 60 ) {
                            throw new CustomException("分钟间隔不能大于60！", ExceptionType.Warn);
                        }
                        return Tuple.Create<byte, int>((byte)IntervalType.Minute, DataValid.GetNullOrInt(TxtMinute.Text).Value);
                    default:
                        break;
                }
            }
            throw new CustomException("请选择一个任务间隔类型并填写执行间隔！", ExceptionType.Warn);
        }

        byte GetJobState() {
            var radioButtons = PnlJobState.Controls.OfType<RadioButton>();
            if ( radioButtons.Any(t => t.Checked) ) {
                var selected = radioButtons.First(t => t.Checked);
                switch ( selected.Name ) {
                    case "RadioBtnWaiting": return (byte)JobState.Waiting;
                    case "RadioBtnRunning": return (byte)JobState.Running;
                    case "RadioBtnStopping": return (byte)JobState.Stopping;
                    default:
                        break;
                }
            }
            throw new CustomException("请选择一个任务状态！", ExceptionType.Warn);
        }

        void SetInterval(byte intervalType, int interval) {
            switch ( (IntervalType)intervalType ) {
                case IntervalType.Day:
                    RadioBtnDay.Checked = true;
                    TxtDay.Text = interval.ToString();
                    break;
                case IntervalType.Hour:
                    RadioBtnHour.Checked = true;
                    TxtHour.Text = interval.ToString();
                    break;
                case IntervalType.Minute:
                    RadioBtnMinute.Checked = true;
                    TxtMinute.Text = interval.ToString();
                    break;
                default:
                    break;
            }
        }

        void SetJobState(byte jobState) {
            switch ( (JobState)jobState ) {
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
