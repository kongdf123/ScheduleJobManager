using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Utility
{
    public class QuartzNetHelper
    {
        static IScheduler scheduler;

        public static IScheduler GetScheduler() {
            if ( scheduler == null ) {
                NameValueCollection config = (NameValueCollection)ConfigurationManager.GetSection("quartz");
                ISchedulerFactory factory = new StdSchedulerFactory(config);
                scheduler = factory.GetScheduler();
            }
            return scheduler;
        }

        public void AddJob() {
            //TODO
        }


    }
}
