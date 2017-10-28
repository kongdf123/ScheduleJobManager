using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.BLL;
using DataAccess.Entity;
using JobMonitor.Utility;
using Quartz;

namespace JobMonitor.Desktop.Biz
{
    public class SqlServerSyncJob : IJob
    {
        public void Execute(IJobExecutionContext context) {
            string jobName = context.JobDetail.Key.Name;
            Task.Factory.StartNew(() => {
                try {
                    new SqlServerSyncService().SyncMsSqlData(jobName);
                }
                catch ( Exception ex ) {
                    Log4NetHelper.WriteExcepetion(ex);
                }
            });
        }
    }
}
