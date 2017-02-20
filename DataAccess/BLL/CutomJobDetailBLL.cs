using DataAccess.DAL;
using DataAccess.Entity;
using ServiceHost.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace DataAccess.BLL
{
    public class CustomJobDetailBLL
    {
        CustomJobDetailDAL _dal;
        public CustomJobDetailBLL()
        {
            _dal = CustomJobDetailDAL.CreateInstance();
        }

        public static CustomJobDetailBLL CreateInstance()
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

            if (string.IsNullOrEmpty(jobDetail.JobServiceURL))
            {
                throw new CustomException("请输入需要执行的服务地址。", ExceptionType.Warn);
            }

            if (Exists(jobDetail.JobId, jobDetail.JobName))
            {
                throw new CustomException("任务代号已存在，请重新输入。", ExceptionType.Warn);
            }
        }

        public void AddJob(string jobHostSite, int jobId, string jobName)
        {
            var respResult = HttpHelper.SendPost(jobHostSite + "ScheduleHostService/AddJob", "jobId=" + jobId + "&jobName=" + jobName);
            if (!string.IsNullOrEmpty(respResult))
            {
                ResponseJson respJson = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseJson>(respResult);
                if (respJson.Code == 1)
                {
                    return;
                }
            }
            throw new CustomException("任务添加失败", ExceptionType.Error);
        }

        public void StartJob(string jobHostSite, int jobId, string jobName)
        {
            var respResult = HttpHelper.SendPost(jobHostSite + "ScheduleHostService/StartJob", "jobId=" + jobId + "&jobName=" + jobName);
            if (!string.IsNullOrEmpty(respResult))
            {
                ResponseJson respJson = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseJson>(respResult);
                if (respJson.Code == 1)
                {
                    return;
                }
            }
            throw new CustomException("任务启动失败", ExceptionType.Error);
        }

        public void StopJob(string jobHostSite,int jobId,string jobName) {
            var respResult = HttpHelper.SendPost(jobHostSite + "ScheduleHostService/StopJob", "jobId=" + jobId + "&jobName=" + jobName);
            if (!string.IsNullOrEmpty(respResult))
            {
                ResponseJson respJson = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseJson>(respResult);
                if (respJson.Code == 1)
                {
                    return;
                }
            }
            throw new CustomException("任务关闭失败", ExceptionType.Error);
        }

        /// <summary>
        /// 获取数据取值范围的开始时间
        /// </summary>
        /// <param name="intervalType"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public DateTime GetFetchingStartDate(byte intervalType,int interval) {
            DateTime startDate = DateTime.Now;
            switch ((IntervalTypeEnum)intervalType)
            {
                case IntervalTypeEnum.Day:
                    startDate = startDate.AddDays(-interval);
                    break;
                case IntervalTypeEnum.Hour:
                    startDate = startDate.AddHours(-interval);
                    break;
                case IntervalTypeEnum.Minute:
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
