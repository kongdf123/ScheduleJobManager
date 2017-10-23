using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;

namespace JobMonitor.Utility
{
    public class QuartzNetHelper
    {
        static IScheduler scheduler;

        public static IScheduler Initialize(NameValueCollection config)
        {
            ISchedulerFactory factory = new StdSchedulerFactory(config);
            scheduler = factory.GetScheduler();
            return scheduler;
        }

        public static IScheduler GetScheduler() {
            return scheduler;
        }
    }
}
