using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQuartzService
{
    class Program
    {
        static void Main(string[] args) {
            try {
                NameValueCollection config = (NameValueCollection)ConfigurationManager.GetSection("quartz");
                ISchedulerFactory factory = new StdSchedulerFactory(config);
                IScheduler scheduler = factory.GetScheduler();

                try {

                    scheduler.Clear();

                    /* schedule some jobs through code */
                    if ( !scheduler.CheckExists(JobKey.Create("job1")) ) {

                        IJobDetail jobDetail = JobBuilder.Create<HelloJob>().WithIdentity("job1", "group1").Build();

                        ITrigger trigger = TriggerBuilder.Create()
                            .WithIdentity("trigger1", "group1")
                            .StartNow()
                            .WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever())
                            .Build();

                        scheduler.ScheduleJob(jobDetail, trigger);

                    }
                    scheduler.Start();

                    Thread.Sleep(TimeSpan.FromSeconds(1));

                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Press ENTER to Continue to Shut Down");
                    Console.WriteLine(string.Empty);
                    Console.ReadLine();

                }
                finally {
                    scheduler.Shutdown(false);
                }


                Console.Write("");

            }
            catch ( Exception ex ) {

                Exception exc = ex;
                while ( null != exc ) {
                    Console.WriteLine(exc.Message);
                    exc = exc.InnerException;
                }
            }
            finally {
                Console.WriteLine(string.Empty);
                Console.WriteLine(string.Empty);
                Console.WriteLine("Press ENTER to Exit");
                Console.ReadLine();
            }
        }
    }
}
