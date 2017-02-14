using DataAccess.DAL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.BLL
{
    public class CustomJobDetailBLL
    {
        public static CustomJobDetailBLL CreateInstance() {
            return new CustomJobDetailBLL();
        }

        public void CheckValid(CustomJobDetail jobDetail) {
            //TODO
        }

        public int Insert(CustomJobDetail jobDetail) {
            CheckValid(jobDetail);
            return CustomJobDetailDAL.CreateInstance().Insert(jobDetail);
        }

        public int Update(CustomJobDetail jobDetail) {
            CheckValid(jobDetail);
            return CustomJobDetailDAL.CreateInstance().Update(jobDetail);
        }

        public int Delete(int jobId, string jobName) {
            return CustomJobDetailDAL.CreateInstance().Delete(jobId, jobName);
        }

        public CustomJobDetail Get(int jobId, string jobName) {
            return CustomJobDetailDAL.CreateInstance().Get(jobId, jobName);
        }

        public PageData GetPageList(int pageSize, int curPage, string jobName = "") {
            return CustomJobDetailDAL.CreateInstance().GetPageList(pageSize, curPage, jobName);
        }
    }
}
