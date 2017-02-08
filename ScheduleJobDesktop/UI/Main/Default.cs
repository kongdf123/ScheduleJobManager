using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleJobDesktop.Main
{
    public partial class Default : UserControl
    {
        private static Default instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Default Instance {
            get {
                if (instance == null)
                {
                    instance = new Default();
                }
                return instance;
            }
        }

        public Default()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
    }
}
