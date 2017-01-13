using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHost
{
    partial class QuartzService : ServiceBase
    {
        ISchedulerFactory factory;
        IScheduler scheduler;

        public QuartzService() {
            InitializeComponent();
            NameValueCollection config = (NameValueCollection)ConfigurationManager.GetSection("quartz");
            factory = new StdSchedulerFactory(config);
            scheduler = factory.GetScheduler();

        }

        protected override void OnStart(string[] args) {
            if ( !scheduler.IsStarted ) {
                scheduler.Start();
            }
            //TODO



        }

        protected override void OnStop() {
            scheduler.Shutdown();
        }

        protected override void OnPause() {
            scheduler.PauseAll();
        }

        protected override void OnContinue() {
            scheduler.ResumeAll();
        }
    }
}
