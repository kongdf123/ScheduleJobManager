using DataAccess.BLL;
using DataAccess.Entity;
using Quartz;
using ServiceHost.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Utility;

namespace JobHost.Common
{
    public class DataSyncHttpJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            string jobName = context.JobDetail.Key.Name;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobName);
                    HttpHelper.SendPost(customJob.JobServiceURL + "?jobName=" + customJob.JobName, "");
                }
                catch (Exception ex)
                {
                    Log4NetHelper.WriteExcepetion(ex);
                }
            });
        }
    }
}