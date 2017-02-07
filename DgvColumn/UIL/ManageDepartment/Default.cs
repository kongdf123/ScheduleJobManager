using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BudStudio.DgvColumn.BLL;
using BudStudio.DgvColumn.COL;
using BudStudio.DgvColumn.SFL;

namespace BudStudio.DgvColumn.UIL.ManageDepartment
{
    /// <summary>
    /// 对象名称：“部门管理模块”列表界面控件（用户界面层）
    /// 对象说明：该界面显示所有“部门信息”的信息列表，可以通过该界面导航到相应的添加、修改、删除界面。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012/02/29 16:07:34
    /// </summary>
    public partial class Default : UserControl
    {
        private static Default instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Default Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Default();
                }
                BindDataGrid(); // 每次返回该控件的实例前，都将对DataGridView控件的数据源进行重新绑定。
                return instance;
            }
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private Default()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 用户单击“添加”按钮时的事件处理方法。
        /// </summary>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FormMain.LoadNewControl(Create.Instance); // 载入该模块的添加信息界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击DataGridView时的事件处理方法。
        /// </summary>
        private void DgvGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //用户单击DataGridView“操作”列中的“修改”按钮。
            if (DataGridViewActionButtonCell.IsModifyButtonClick(sender, e))
            {
                string objectId = DgvGrid["ColAction", e.RowIndex].Value.ToString(); // 获取所要修改关联对象的主键。
                Modify.LoadDataById(objectId);                                       // 根据关联对象的主键，从数据库中获取信息。
                FormMain.LoadNewControl(Modify.Instance);                            // 载入该模块的修改信息界面至主窗体显示。
            }

            //用户单击DataGridView“操作”列中的“删除”按钮。
            if (DataGridViewActionButtonCell.IsDeleteButtonClick(sender, e))
            {
                string objectId = DgvGrid["ColAction", e.RowIndex].Value.ToString(); // 获取所要删除关联对象的主键。
                Delete.LoadDataById(objectId);                                       // 根据关联对象的主键，从数据库中获取信息。
                FormMain.LoadNewControl(Delete.Instance);                            // 载入该模块的删除信息界面至主窗体显示。
            }
        }

        /// <summary>
        /// PageBar控件的当前页码发生变更时的事件处理方法。
        /// </summary>
        private void PageBar_PageChanged(object sender, EventArgs e)
        {
            BindDataGrid(); //重新对DataGridView控件的数据源进行绑定。
        }

        /// <summary>
        /// 对DataGridView控件的数据源进行绑定。
        /// </summary>
        public static void BindDataGrid()
        {
            instance.PageBar.DataControl = instance.DgvGrid;
            instance.PageBar.DataSource = DepartmentBLL.GetPageList(instance.PageBar.PageSize, instance.PageBar.CurPage);
            instance.PageBar.DataBind();
        }

        /// <summary>
        /// 显示最后一页的数据，该方法为静态方法，供外界控制信息列表页数调用。
        /// </summary>
        public static void GotoLastPage()
        {
            instance.PageBar.CurPage = int.MaxValue;
        }

        private void LinkBtnUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.budeasycode.com");
        }


    }
}
