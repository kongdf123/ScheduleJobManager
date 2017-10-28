using log4net.Config;
using System;
using System.Configuration;
using System.Threading;
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
        static void Main() {
            XmlConfigurator.Configure();

            //// 全局异常注册
            ApplicationEventHandlerClass AppEvents = new ApplicationEventHandlerClass();
            Application.ThreadException += new ThreadExceptionEventHandler(AppEvents.OnThreadException);
            
            //初始化quart.net 
            var properties = new NameValueCollection();
            properties["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX, Quartz";
            properties["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.MySQLDelegate, Quartz";
            properties["quartz.jobStore.dataSource"] = "myDS";
            properties["quartz.dataSource.myDS.provider"] = "MySql-695";
            properties["quartz.dataSource.myDS.connectionString"] = ConfigurationManager.AppSettings["MySQLServerConnString"];
            properties["quartz.jobStore.tablePrefix"] = "QRTZ_";
            properties["quartz.jobStore.clustered"] = "true";
            properties["quartz.scheduler.instanceName"] = "TestScheduler";
            properties["quartz.scheduler.instanceId"] = "instance_one";
            properties["quartz.threadPool.threadCount"] = "5";
            properties["quartz.threadPool.threadPriority"] = "Normal";
            properties["quartz.jobStore.misfireThreshold"] = "60000";
            properties["quartz.jobStore.useProperties"] = "false";
            IScheduler scheduler = QuartzNetHelper.Initialize(properties);
            scheduler.Start();

            Log4NetHelper.WriteInfo("JobMonitor Application is started.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(FormMain.Instance);
        }
    }
}
