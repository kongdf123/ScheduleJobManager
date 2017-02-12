using DataAccess.DAL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.BLL
{
    public class JobDetailBLL
    {
        public static JobDetailBLL CreateInstance() {
            return new JobDetailBLL();
        }

        public void CheckValid(JobDetail jobDetail) {
            //TODO
        }

        public int Insert(JobDetail jobDetail) {
            CheckValid(jobDetail);
            return JobDetailDAL.CreateInstance().Insert(jobDetail);
        }

        public int Update(JobDetail jobDetail) {
            CheckValid(jobDetail);
            return JobDetailDAL.CreateInstance().Update(jobDetail);
        }

        public int Delete(int jobId, string jobName) {
            return JobDetailDAL.CreateInstance().Delete(jobId, jobName);
        }

        public JobDetail Get(int jobId, string jobName) {
            return JobDetailDAL.CreateInstance().Get(jobId, jobName);
        }

        public PageData GetPageList(int pageSize, int curPage, string jobName = "") {
            return JobDetailDAL.CreateInstance().GetPageList(pageSize, curPage, jobName);
        }
    }
}
