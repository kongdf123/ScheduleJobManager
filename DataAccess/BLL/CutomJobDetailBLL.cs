using DataAccess.DAL;
using DataAccess.Entity;
using System;
using System.Threading.Tasks;
using JobMonitor.Utility;
using JobMonitor.Core.Model;

namespace DataAccess.BLL
{
    public class CustomJobDetailBLL
    {
        CustomJobDetailDAL _dal;
        public CustomJobDetailBLL()
        {
            _dal = CustomJobDetailDAL.CreateInstance();
        }

        public static CustomJobDetailBLL GetInstance()
        {
            return new CustomJobDetailBLL();
        }

        public void CheckValid(CustomJobDetail jobDetail)
        {
            if (string.IsNullOrEmpty(jobDetail.JobChineseName))
            {
                throw new CustomException("请输入任务名称。", ExceptionType.Warn);
            }

            if (string.IsNullOrEmpty(jobDetail.JobName))
            {
                throw new CustomException("请输入任务代号。", ExceptionType.Warn);
            }

            if (Exists(jobDetail.JobId, jobDetail.JobName))
            {
                throw new CustomException("任务代号已存在，请重新输入。", ExceptionType.Warn);
            }
        }

        /// <summary>
        /// 获取数据取值范围的开始时间
        /// </summary>
        /// <param name="intervalType"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public DateTime GetFetchingStartDate(byte intervalType, int interval)
        {
            DateTime startDate = DateTime.Now;
            switch ((IntervalType)intervalType)
            {
                case IntervalType.Day:
                    startDate = startDate.AddDays(-interval);
                    break;
                case IntervalType.Hour:
                    startDate = startDate.AddHours(-interval);
                    break;
                case IntervalType.Minute:
                    startDate = startDate.AddMinutes(-interval);
                    break;
                default:
                    break;
            }
            return startDate;
        }

        public int Insert(CustomJobDetail jobDetail)
        {
            CheckValid(jobDetail);
            var newId = _dal.Insert(jobDetail);
            jobDetail.JobId = newId;
            return newId;
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

        public bool Exists(int jobId, string jobName)
        {
            return _dal.Exists(jobId, jobName);
        }
    }
}
