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
        CustomJobDetailDAL _dal;
        public CustomJobDetailBLL() {
            _dal = CustomJobDetailDAL.CreateInstance();
        }

        public static CustomJobDetailBLL CreateInstance()
        {
            return new CustomJobDetailBLL();
        }

        public void CheckValid(CustomJobDetail jobDetail)
        {
            //TODO
        }

        public int Insert(CustomJobDetail jobDetail)
        {
            CheckValid(jobDetail);
            return _dal.Insert(jobDetail);
        }

        public int Update(CustomJobDetail jobDetail)
        {
            CheckValid(jobDetail);
            return _dal.Update(jobDetail);
        }

        public int Delete(int jobId, string jobName)
        {
            return _dal.Delete(jobId, jobName);
        }

        public CustomJobDetail Get(int jobId, string jobName)
        {
            return _dal.Get(jobId, jobName);
        }

        public CustomJobDetail Get(string jobName)
        {
            return _dal.Get(jobName);
        }

        public PageData GetPageList(int pageSize, int curPage, string jobName = "")
        {
            return _dal.GetPageList(pageSize, curPage, jobName);
        }

        public bool Exists(string jobName)
        {
            return _dal.Exists(jobName);
        }
    }
}
