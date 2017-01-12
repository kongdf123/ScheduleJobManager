using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
//using Topshelf;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args) {
            var services = new ServiceBase[] {
                new QuartzService()
            };
            ServiceBase.Run(services);

            //HostFactory.Run(config => {
            //    config.Service<QuartzBaseService>();
            //    config.RunAsLocalSystem();

            //    config.SetDescription("Host all quartz services.");
            //    config.SetDisplayName("Schedule Job Services With Quartz.NET");
            //    config.SetServiceName("ScheduleJobWinService");
            //});
        }
    }
}
