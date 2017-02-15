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
    public class ScheduleHostServiceController : Controller
    {
        [HttpPost]
        public JsonResult AddJob(int jobId, string jobName)
        {
            try
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

                if (customJob.State == (byte)JobState.Running)
                {
                    scheduler.Start();
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return Json(new { });
        }

        [HttpPost]
        public JsonResult StartJob(int jobId, string jobName)
        {
            try
            {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if (!scheduler.IsStarted)
                {
                    scheduler.Start();
                }
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);
                //scheduler.ResumeTrigger(new TriggerKey(jobName, jobGroup));              
                scheduler.ResumeJob(JobKey.Create(customJob.JobName, customJob.JobGroup));
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(new { });
        }

        [HttpPost]
        public JsonResult StopJob(int jobId, string jobName)
        {
            try
            {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if (!scheduler.IsStarted)
                {
                    scheduler.Start();
                }
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);
                //scheduler.ResumeTrigger(new TriggerKey(jobName, jobGroup));              
                scheduler.PauseJob(JobKey.Create(customJob.JobName, customJob.JobGroup));
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(new { });
        }

        [HttpPost]
        public JsonResult DeleteJob(int jobId, string jobName)
        {
            try
            {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if (!scheduler.IsStarted)
                {
                    scheduler.Start();
                }
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);
                scheduler.PauseTrigger(new TriggerKey(customJob.JobName, customJob.JobGroup));
                scheduler.UnscheduleJob(new TriggerKey(customJob.JobName, customJob.JobGroup));

                var result = scheduler.DeleteJob(JobKey.Create(customJob.JobName, customJob.JobGroup));
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(new { });
        }

    }
}
