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

namespace BudStudio.DgvColumn.UIL.ManageEmployee
{
    /// <summary>
    /// 对象名称：“员工信息管理模块”删除界面控件（用户界面层）
    /// 对象说明：该界面用于删除“员工信息”对象并提交至数据库，删除操作成功后返回列表界面。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012/02/29 16:07:34
    /// </summary>
    public partial class Delete : UserControl
    {
        private Employee employee;
        private static Delete instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Delete Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Delete();
                }

                if (instance.employee == null)
                    throw new CustomException("在调用本模块删除界面的实例前，必须调用Delete.LoadDataById方法，装载所要删除的关联对象。", ExceptionType.Error);

                return instance;
            }
        }

        /// <summary>
        /// 根据关联对象的主键，从数据库中获取关联对象信息，以备进行删除操作。
        /// </summary>
        public static void LoadDataById(string employeeId)
        {
            if (instance == null)
            {
                instance = new Delete();
            }
            instance.employee = EmployeeBLL.GetDataById(employeeId);
            if (instance.employee == null)
                throw new CustomException("对不起，所要删除的信息不存在或已删除。");
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        public Delete()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 用户单击“删除”按钮时的事件处理方法。
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EmployeeBLL.Delete(employee.Id.Value); // 调用“业务逻辑层”的方法，删除关联对象并更新至数据库。
            FormSysMessage.ShowSuccessMsg("“员工信息”删除成功，单击“确定”按钮返回信息列表。");
            FormMain.LoadNewControl(Default.Instance); // 删除完成后，载入该模块的信息列表界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Detail.LoadDataById(employee.Id.ToString()); // 根据关联对象的主键，从数据库中获取信息。
            FormMain.LoadNewControl(Detail.Instance);  // 载入该模块的查看信息界面至主窗体显示。
        }
    }
}

