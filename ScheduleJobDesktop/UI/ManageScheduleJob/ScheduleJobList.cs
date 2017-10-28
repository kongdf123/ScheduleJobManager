using System;
using System.Drawing;
using System.Windows.Forms;
using JobMonitor.Desktop.UI.UserControls;
using DataAccess.Entity;
using DataAccess.BLL;
using JobMonitor.Desktop.UI.ManageSettings;
using JobMonitor.Desktop.Biz;
using System.Threading;
using JobMonitor.Core.Model;

namespace JobMonitor.Desktop.UI.ManageScheduleJob
{
    public partial class ScheduleJobList : UserControl
    {
        static ScheduleJobList instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static ScheduleJobList Instance {
            get {
                if ( instance == null ) {
                    instance = new ScheduleJobList();
                }
                BindDataGrid(); // 每次返回该控件的实例前，都将对DataGridView控件的数据源进行重新绑定。
                return instance;
            }
        }

        public ScheduleJobList() {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void BtnCreate_Click(object sender, EventArgs e) {
            FormMain.LoadNewControl(ScheduleJobEdit.Instance); // 载入该模块的添加信息界面至主窗体显示。
        }

        private void DgvGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if ( e.RowIndex < 0 ) {
                return;
            }

            int jobId = Convert.ToInt32(DgvGrid["ColAction", e.RowIndex].Value.ToString()); // 获取所要修改关联对象的主键。
            string jobIdentity = DgvGrid["ScheduleJobName", e.RowIndex].Value.ToString();
            CustomJobDetail jobDetail = CustomJobDetailBLL.GetInstance().Get(jobId, jobIdentity);

            //用户单击DataGridView“操作”列中的“修改”按钮。
            if ( JobDataGridViewActionButtonCell.IsModifyButtonClick(sender, e) ) {
                FormMain.LoadNewControl(ScheduleJobEdit.BindJobDetail(jobDetail));                            // 载入该模块的修改信息界面至主窗体显示。
            }

            //用户单击DataGridView“操作”列中的“删除”按钮。
            if ( JobDataGridViewActionButtonCell.IsDeleteButtonClick(sender, e) ) {
                DeleteJobRecord(jobId, jobIdentity);
            }

            //用户单击DataGridView“操作”列中的“启动”按钮。
            if ( JobDataGridViewActionButtonCell.IsStartButtonClick(sender, e) ) {
                var formSysMessage = FormSysMessage.ShowLoading();
                var result = SqlServerSyncJobHost.GetInstance().StartJob(jobId, jobIdentity);
                if ( result.State == ResultState.Success ) {
                    jobDetail.State = (byte)JobState.Running;
                    CustomJobDetailBLL.GetInstance().Update(jobDetail);
                }
                var message = result.State == Core.Model.ResultState.Success ? "启动任务计划成功。" : "启动任务计划失败。";
                formSysMessage.Close();
                FormSysMessage.ShowMessage(message);
            }

            //用户单击DataGridView“操作”列中的“停止”按钮。
            if ( JobDataGridViewActionButtonCell.IsStopButtonClick(sender, e) ) {
                var formSysMessage = FormSysMessage.ShowLoading();
                var result = SqlServerSyncJobHost.GetInstance().StopJob(jobId, jobIdentity);
                if ( result.State == ResultState.Success ) {
                    jobDetail.State = (byte)JobState.Stopping;
                    CustomJobDetailBLL.GetInstance().Update(jobDetail);
                }
                var message = result.State == Core.Model.ResultState.Success ? "停止任务计划成功。" : "停止任务计划失败。";
                formSysMessage.Close();
                FormSysMessage.ShowMessage(message);
            }

            BindDataGrid();
        }

        void DeleteJobRecord(int jobId, string jobIdentity) {
            DialogResult dialogResult = FormSysMessage.ShowMessage("确定要删除该任务计划吗？");
            if ( dialogResult == DialogResult.OK ) {
                var formSysMessage = FormSysMessage.ShowLoading();
                int effected = CustomJobDetailBLL.GetInstance().Delete(jobId, jobIdentity);
                if ( effected > 0 ) {
                    SqlServerSyncJobHost.GetInstance().DeleteJob(jobId, jobIdentity);
                }
                formSysMessage.Close();
                FormSysMessage.ShowMessage(effected > 0 ? "删除成功。" : "删除失败。");
            }
        }

        private void PageBar_PageChanged(object sender, EventArgs e) {
            BindDataGrid(); //重新对DataGridView控件的数据源进行绑定。
        }

        /// <summary>
        /// 对DataGridView控件的数据源进行绑定。
        /// </summary>
        public static void BindDataGrid() {
            instance.PageBar.DataControl = instance.DgvGrid;
            instance.PageBar.DataSource = CustomJobDetailBLL.GetInstance().GetPageList(instance.PageBar.PageSize, instance.PageBar.CurPage);
            instance.PageBar.DataBind();
        }

        /// <summary>
        /// 显示最后一页的数据，该方法为静态方法，供外界控制信息列表页数调用。
        /// </summary>
        public static void GotoLastPage() {
            instance.PageBar.CurPage = int.MaxValue;
        }

        private void DgvGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
            SolidBrush b = new SolidBrush(DgvGrid.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1 + instance.PageBar.PageSize * (instance.PageBar.CurPage - 1)).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.DgvGrid.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }

        private void BtnNavToSqlServerConfig_Click(object sender, EventArgs e) {
            FormMain.LoadNewControl(SqlServerConfigList.Instance); // 载入该模块的添加信息界面至主窗体显示。
        }
    }
}
