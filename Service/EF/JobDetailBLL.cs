using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EF
{
    public class JobDetailBLL
    {
        public JobDetail Query(int jobId, string jobName) {
            using ( var context = new QuartzDbContext() ) {
                try {
                    return context.JobDetails.FirstOrDefault(x => x.JobId == jobId && x.JobName == jobName);
                }
                catch ( Exception ex ) {
                    //TODO
                }
            }
            return null;
        }

        public List<JobDetail> GetPageList(int jobId, string jobName, int pageSize, out int pageTotal) {
            //TODO
            pageTotal = 0;

            using ( var context = new QuartzDbContext() ) {
                if ( jobId>0 ) {

                }

            }

            return null;
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
