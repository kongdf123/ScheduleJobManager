using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleJobDesktop.UI.UserControls;
using DataAccess.BLL;
using DataAccess.Entity;

namespace ScheduleJobDesktop.UI.ManageSettings
{
    public partial class SqlServerConfigList : UserControl
    {
        static SqlServerConfigList instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static SqlServerConfigList Instance {
            get {
                if ( instance == null ) {
                    instance = new SqlServerConfigList();
                }
                BindDataGrid(); // 每次返回该控件的实例前，都将对DataGridView控件的数据源进行重新绑定。
                return instance;
            }
        }

        public SqlServerConfigList() {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void BtnCreate_Click(object sender, EventArgs e) {
            FormMain.LoadNewControl(SqlServerConfigEdit.Instance); // 载入该模块的添加信息界面至主窗体显示。
        }

        private void DgvGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            int id = Convert.ToInt32(DgvGrid["ColAction", e.RowIndex].Value.ToString()); // 获取所要修改关联对象的主键。
            //用户单击DataGridView“操作”列中的“修改”按钮。
            if (DBConfigDataGridViewActionButtonCell.IsModifyButtonClick(sender, e))
            {
                SqlServerConfigInfo dbConfigInfo = SqlServerConfigInfoBLL.CreateInstance().Get(id);
                FormMain.LoadNewControl(SqlServerConfigEdit.BindJobDetail(dbConfigInfo));                            // 载入该模块的修改信息界面至主窗体显示。
            }

            //用户单击DataGridView“操作”列中的“删除”按钮。
            if (DBConfigDataGridViewActionButtonCell.IsDeleteButtonClick(sender, e))
            { 
                DialogResult dialogResult = FormSysMessage.ShowMessage("确定要删除该项吗？");
                if (dialogResult == DialogResult.OK)
                {
                    SqlServerConfigInfoBLL.CreateInstance().Delete(id);
                    BindDataGrid();
                }
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
            instance.PageBar.DataSource = SqlServerConfigInfoBLL.CreateInstance().GetPageList(instance.PageBar.PageSize, instance.PageBar.CurPage);
            instance.PageBar.DataBind();
        }

        /// <summary>
        /// 显示最后一页的数据，该方法为静态方法，供外界控制信息列表页数调用。
        /// </summary>
        public static void GotoLastPage() {
            instance.PageBar.CurPage = int.MaxValue;
        }

        private void DgvGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(DgvGrid.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1+ instance.PageBar.PageSize* (instance.PageBar.CurPage-1)).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.DgvGrid.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }
    }
}
