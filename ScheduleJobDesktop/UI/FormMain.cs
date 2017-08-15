using ScheduleJobDesktop.UI.ManageSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleJobDesktop.UI.ManageEventConfig;

namespace ScheduleJobDesktop
{
    /// <summary>
    /// 主窗口
    /// </summary>
    public partial class FormMain : Form
    {
        static FormMain instance;

        /// <summary>
        /// 返回该窗体的唯一实例。如果之前该窗体没有被创建，进行创建并返回该窗体的唯一实例。
        /// 此处采用单键模式对窗体的唯一实例进行控制，以便外界窗体或控件可以随时访问本窗体。
        /// </summary>
        public static FormMain Instance {
            get {
                if (instance == null)
                {
                    instance = new FormMain();
                }
                return instance;
            }
        }

        public FormMain()
        {
            InitializeComponent();

            Main.Default newControl = Main.Default.Instance;
            PnlContent.Controls.Add(newControl);
        }

        /// <summary>
        /// 载入一个新的功能模块控件，并将其显示在窗体中部模块区域。
        /// </summary>
        public static void LoadNewControl(Control control)
        {
            FormMain.Instance.PnlContent.Controls.Clear();
            FormMain.Instance.PnlContent.Controls.Add(control);
        }

        private void NavBar_QuitSystemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NavBar_ImageButtonClick(object sender, string targetModule)
        {
            switch (targetModule)
            {
                case "Main": // “欢迎使用”功能模块
                    FormMain.LoadNewControl(Main.Default.Instance);
                    break;

                case "ManageScheduleJob": // “任务信息管理”功能模块
                    FormMain.LoadNewControl(UI.ManageScheduleJob.ScheduleJobList.Instance);
                    break;
                case "ManageDbConfig":
                    LoadNewControl(SqlServerConfigList.Instance); break;
				case "ManageEventConfig":
					LoadNewControl(EventConfigList.Instance); break;
				default: break;
            }
        }
    }
}
