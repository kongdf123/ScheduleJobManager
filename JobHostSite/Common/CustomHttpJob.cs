using DataAccess.BLL;
using DataAccess.Entity;
using Quartz;
using System;
using System.Threading.Tasks;
using JobMonitor.Utility;

namespace JobHost.Common
{
    public class CustomHttpJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            string jobName = context.JobDetail.Key.Name;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    CustomJobDetail customJob = CustomJobDetailBLL.GetInstance().Get(jobName);
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