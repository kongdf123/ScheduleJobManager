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

namespace JobHostSite.Controllers
{
    public class ScheduleHostServiceController : Controller
    {
        /// <summary>
        /// 添加任务计划
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult AddJob()
        {
            try
            {
                int jobId = Convert.ToInt32(Request["jobId"]);
                string jobName = Request["jobName"];
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                IJobDetail job = JobBuilder.Create<CustomHttpJob>()
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

                return Json(new { Code = 1, Message = "执行成功！" });
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
                return Json(new { Code = 0, Message = "执行失败！" });
            }
        }

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ModifyJob()
        {
            try
            {
                int jobId = Convert.ToInt32(Request["jobId"]);
                string jobName = Request["jobName"];
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if (scheduler.CheckExists(jobKey))
                {
                    scheduler.DeleteJob(jobKey);
                }

                IJobDetail job = JobBuilder.Create<CustomHttpJob>()
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

                return Json(new { Code = 1, Message = "执行成功！" });
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
                return Json(new { Code = 0, Message = "执行失败！" });
            }
        }


        /// <summary>
        /// 启动任务计划
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult StartJob()
        {
            try
            {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if (!scheduler.IsStarted)
                {
                    scheduler.Start();
                }
                int jobId = Convert.ToInt32(Request["jobId"]);
                string jobName = Request["jobName"];
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);
                //scheduler.ResumeTrigger(new TriggerKey(jobName, jobGroup));   
                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if (scheduler.CheckExists(jobKey))
                {
                    scheduler.ResumeJob(jobKey);
                }
                else
                {
                    IJobDetail job = JobBuilder.Create<CustomHttpJob>()
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
                    scheduler.ResumeJob(jobKey);
                }

                customJob.State = (byte)JobState.Running;
                CustomJobDetailBLL.CreateInstance().Update(customJob);

                return Json(new { Code = 1, Message = "执行成功！" });
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
                return Json(new { Code = 0, Message = "执行失败！" });
            }
        }

        /// <summary>
        /// 停止执行任务计划
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult StopJob()
        {
            try
            {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if (!scheduler.IsStarted)
                {
                    scheduler.Start();
                }
                int jobId = Convert.ToInt32(Request["jobId"]);
                string jobName = Request["jobName"];
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if (scheduler.CheckExists(jobKey))
                {
                    scheduler.PauseJob(jobKey);
                }
                else
                {
                    IJobDetail job = JobBuilder.Create<CustomHttpJob>()
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
                    scheduler.Start();
                    scheduler.PauseJob(jobKey);
                }


                customJob.State = (byte)JobState.Stopping;
                CustomJobDetailBLL.CreateInstance().Update(customJob);

                return Json(new { Code = 1, Message = "执行成功！" });
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
                return Json(new { Code = 0, Message = "执行失败！" });
            }
        }

        /// <summary>
        /// 删除任务计划
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteJob()
        {
            try
            {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if (!scheduler.IsStarted)
                {
                    scheduler.Start();
                }
                int jobId = Convert.ToInt32(Request["jobId"]);
                string jobName = Request["jobName"];
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);
                scheduler.PauseTrigger(new TriggerKey(customJob.JobName, customJob.JobGroup));
                scheduler.UnscheduleJob(new TriggerKey(customJob.JobName, customJob.JobGroup));

                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if (scheduler.CheckExists(jobKey))
                {
                    var result = scheduler.DeleteJob(jobKey);

                    if (result)
                    {
                        CustomJobDetailBLL.CreateInstance().Delete(customJob.JobId, customJob.JobName);
                    }

                    if (result)
                    {
                        return Json(new { Code = 1, Message = "执行成功！" });
                    }
                    else
                    {
                        return Json(new { Code = 0, Message = "执行失败！" });
                    }
                }
                return Json(new { Code = 1, Message = "执行成功！" });
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
                return Json(new { Code = 0, Message = "执行失败！" });
            }
        }

    }
}
