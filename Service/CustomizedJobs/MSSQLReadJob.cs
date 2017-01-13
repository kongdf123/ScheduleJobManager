using Quartz;
using Service.EF;
using ServiceHost.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Jobs
{
    public class MSSQLReadJob : IJob
    {
        public void Execute(IJobExecutionContext context) {
            JobDetailBLL jobDetailBLL = new JobDetailBLL();
            var jobDetail = jobDetailBLL.Get(context.JobDetail.Key.Name);

            if ( jobDetail==null ) {
                return;
            }

            HttpHelper.SendPost(jobDetail.JobServiceURL, "");

        }
    }
}
