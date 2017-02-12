using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.BLL;
using ServiceHost.Common;
using ScheduleJobDesktop.Common;

namespace ScheduleJobDesktop.UI.ManageScheduleJob
{
    /// <summary>
    /// 任务管理添加界面
    /// </summary>
    public partial class Create : UserControl
    {
        JobDetail jobDetail;
        static Create instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Create Instance {
            get {
                if ( instance == null ) {
                    instance = new Create();
                }
                instance.jobDetail = new JobDetail(); // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
                return instance;
            }
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private Create() {
            InitializeComponent();
             
            //DrpSex.DisplayMember = "Name";
            //DrpSex.ValueMember = "Id";
            //DrpSex.DataSource = Sex.AllList;

            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 用户单击“保存”按钮时的事件处理方法。
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e) {
            BindFormlToObject(); // 进行数据绑定
            JobDetailBLL.CreateInstance().Insert(jobDetail); // 调用“业务逻辑层”的方法，检查有效性后插入至数据库。
            FormSysMessage.ShowSuccessMsg("添加成功，单击“确定”按钮返回。");
            //Default.GotoLastPage();                    // 将该模块的信息列表的页码转至最后一页。
            FormMain.LoadNewControl(Default.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e) {
            FormMain.LoadNewControl(Default.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }


        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormlToObject() {
            jobDetail.JobChineseName = DataValid.GetNullOrString(TxtScheduleChineseName.Text);
            jobDetail.JobName = DataValid.GetNullOrString(TxtJobIdentity.Text);
            jobDetail.JobServiceURL = DataValid.GetNullOrString(TxtServiceAddress.Text);
            jobDetail.State = GetJobState();
            

            //department.DepartmentName = DataValid.GetNullOrString(TxtDepartmentName.Text);  // 部门名称
            //department.ManagerName = DataValid.GetNullOrString(TxtManagerName.Text);  // 经理姓名
            //department.ContactPhone = DataValid.GetNullOrString(TxtContactPhone.Text);  // 联系电话
            //department.NoteDescription = DataValid.GetNullOrString(TxtNoteDescription.Text);  // 备注说明
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

        /// <summary>
        /// 将关联对象中的值，绑定至界面控件进行显示。
        /// </summary>
        private void BindObjectToForm() {
            //TxtDepartmentName.Text = department.DepartmentName;  // 部门名称
            //TxtManagerName.Text = department.ManagerName;  // 经理姓名
            //TxtContactPhone.Text = department.ContactPhone;  // 联系电话
            //TxtNoteDescription.Text = department.NoteDescription;  // 备注说明
        }

        #endregion 界面控件与关联对象之间的绑定方法
    }
}
