using DataAccess.BLL;
using DataAccess.Entity;
using JobHost.Common;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;

namespace JobHost.Controllers
{
    public class ScheduleHostController : Controller
    {
        [HttpPost]
        public JsonResult AddJob(int jobId, string jobName)
        {
            CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

            IScheduler scheduler = QuartzNetHelper.GetScheduler();
            IJobDetail job = JobBuilder.Create<HttpJobDetail>()
                    .WithIdentity(customJob.JobName, customJob.JobGroup)
                    .Build();
            ICronTrigger trigger = (ICronTrigger)TriggerBuilder.Create()
                    .StartAt(customJob.StartDate)
                    .EndAt(customJob.EndDate)
                    .WithIdentity(customJob.JobName, customJob.JobGroup)
                    .WithCronSchedule(customJob.CronExpression)
                    .WithDescription(customJob.Description)
                    .Build();
            scheduler.ScheduleJob(job, trigger);

            return Json(new { });
        }

        [HttpPost]
        public JsonResult StartJob(string jobId, string jobName)
        {
            //TODO
            return Json(new { });
        }

        [HttpPost]
        public JsonResult StopJob(string jobId, string jobName)
        {
            //TODO
            return Json(new { });
        }

        [HttpPost]
        public JsonResult DeleteJob(string jobId, string jobName)
        {
            //TODO
            return Json(new { });
        }

    }
}
