using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.EF
{
    public class JobDetailBLL
    {
        public JobDetail Get(string jobName) {
            using ( var context = new QuartzDbContext() ) {
                try {
                    return context.JobDetails.FirstOrDefault(x => x.JobName == jobName&&x.State);
                }
                catch ( Exception ex ) {
                    //TODO
                }
            }
            return null;
        }

        public List<JobDetail> GetPageList(int jobId, string jobName, int pageIndex, int pageSize, out int pageTotal) {
            //TODO
            pageTotal = 0;

            using ( var context = new QuartzDbContext() ) {
                Expression<Func<JobDetail, bool>> criteria = x => (x.JobId == jobId || x.JobId == 0) && (x.JobName.Contains(jobName));
                pageTotal = context.JobDetails.Count(criteria);
                return context.JobDetails.Where(criteria).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public void Save(JobDetail model) {
            using ( var context = new QuartzDbContext() ) {
                try {
                    context.JobDetails.AddOrUpdate(model);
                    context.SaveChanges();
                }
                catch ( Exception ex ) {
                    //TODO
                }
            }
        }

        public bool Delete(JobDetail model) {
            using ( var context = new QuartzDbContext() ) {
                try {
                    var jobDetail = context.JobDetails.FirstOrDefault(x => x.JobId == model.JobId);
                    if ( jobDetail != null ) {
                        jobDetail.State = false;
                    }
                    context.SaveChanges();
                }
                catch ( Exception ex ) {
                    //TODO
                }
            }
            return false;
        }
    }
}
