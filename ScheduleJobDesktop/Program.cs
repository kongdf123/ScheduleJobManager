using log4net.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobMonitor.Utility;
using JobMonitor.Desktop.UI;
using System.Collections.Specialized;
using Quartz;

namespace JobMonitor.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();

            //// 全局异常注册
            //ApplicationEventHandlerClass AppEvents = new ApplicationEventHandlerClass();
            //Application.ThreadException += new ThreadExceptionEventHandler(AppEvents.OnThreadException);

            //int wakeupInterval =Convert.ToInt32(ConfigurationManager.AppSettings["WakeupInterval"]);
            //System.Timers.Timer timer = new System.Timers.Timer(wakeupInterval);   //实例化Timer类，设置间隔时间为10000毫秒； 20*60*1000
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(ExcutedFunc); //到达时间的时候执行事件；   
            //timer.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)；   
            //timer.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件； 

            //初始化quart.net 
            NameValueCollection config = (NameValueCollection)ConfigurationManager.GetSection("quartz");
            IScheduler scheduler = QuartzNetHelper.Initialize(config);
            scheduler.Start();

            Log4NetHelper.WriteInfo("JobMonitor Application is started.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(FormMain.Instance);
        }

        public static void ExcutedFunc(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["JobHostSite"]);
                HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
            }
        }
    }
}
