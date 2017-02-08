using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleJobDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 全局异常注册
            ApplicationEventHandlerClass AppEvents = new ApplicationEventHandlerClass();
            Application.ThreadException += new ThreadExceptionEventHandler(AppEvents.OnThreadException);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain formMain = FormMain.Instance;
            Application.Run(formMain);
        }

        /// <summary>
        /// 全局异常处理
        /// </summary>
        public class ApplicationEventHandlerClass
        {
            public void OnThreadException(object sender, ThreadExceptionEventArgs e)
            {
                FormSysMessage.ShowException(e.Exception); // 调用FormSysMessage窗体，显示异常信息。
            }
        }
    }
}
