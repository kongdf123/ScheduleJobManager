using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudStudio.DgvColumn.UIL
{
    /// <summary>
    /// 对象名称：应用程序主窗体（用户界面层）
    /// 对象说明：该窗体由上部的Header、左侧的导航栏及中部的模块区域（PnlContent）组成。
    ///           用户通过单击导航栏中的按钮，来切换窗体中部模块区域中的功能模块的显示。
    /// 作者姓名：爱英思躺
    /// 编写日期：2011/12/18 20:40:20
    /// </summary>
    public partial class FormMain : Form
    {
        private static FormMain instance;

        /// <summary>
        /// 返回该窗体的唯一实例。如果之前该窗体没有被创建，进行创建并返回该窗体的唯一实例。
        /// 此处采用单键模式对窗体的唯一实例进行控制，以便外界窗体或控件可以随时访问本窗体。
        /// </summary>
        public static FormMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMain();
                }
                return instance;
            }
        }

        /// <summary>
        /// 私有的窗体实例化方法，创建实例只能通过主窗体的Instance属性实现，以控制主窗体的唯一性。
        /// </summary>
        private FormMain()
        {
            // 初始化主窗体中的控件，载入默认模块到窗体的PnlContent控件中。
            InitializeComponent();                                  
            Main.Default newControl = Main.Default.Instance;    
            PnlContent.Controls.Add(newControl);
        }

        /// <summary>
        /// 用户单击窗体左侧“导航栏”中按钮时的事件处理方法。
        /// </summary>
        private void NavBar_ImageButtonClick(object sender, string targetModule)
        {
            switch (targetModule)
            {
                case "Main": // “欢迎使用”功能模块
                    FormMain.LoadNewControl(Main.Default.Instance);
                    break;

                case "ManageEmployee": // “员工信息管理”功能模块
                    FormMain.LoadNewControl(ManageEmployee.Default.Instance);
                    break;

                case "ManageDepartment": // “部门管理”功能模块
                    FormMain.LoadNewControl(ManageDepartment.Default.Instance);
                    break;

            }
        }

        /// <summary>
        /// 用户单击窗体左侧“导航栏”中“退出系统”导航条时的事件处理方法。
        /// </summary>
        private void NavBar_QuitSystemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 载入一个新的功能模块控件，并将其显示在窗体中部模块区域。
        /// </summary>
        public static void LoadNewControl(Control control)
        {
            FormMain.Instance.PnlContent.Controls.Clear();
            FormMain.Instance.PnlContent.Controls.Add(control);
        }
    }
}
