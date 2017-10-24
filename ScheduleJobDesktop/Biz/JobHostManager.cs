using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.BLL;
using DataAccess.Entity;
using JobMonitor.Core.Model;
using JobMonitor.Utility;
using Quartz;

namespace JobMonitor.Desktop.Biz
{
    public class JobHostManager
    {
        public static JobHostManager GetInstance() {
            return new JobHostManager();
        }

        /// <summary>
        /// 添加任务计划
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName"></param>
        /// <returns></returns>
        public ResultModel AddJob(int jobId, string jobName) {
            try {
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                IJobDetail job = JobBuilder.Create<SqlServerSyncJob>()
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

                if ( customJob.State == (byte)JobState.Running ) {
                    scheduler.TriggerJob(job.Key);
                }

                return ResultModel.Create(ResultState.Success, "执行成功！");
            }
            catch ( Exception ex ) {
                Log4NetHelper.WriteExcepetion(ex);
                return ResultModel.Create(ResultState.Failure, "执行失败！");
            }
        }

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <returns></returns>
        public ResultModel ModifyJob(int jobId, string jobName) {
            try {
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( scheduler.CheckExists(jobKey) ) {
                    scheduler.DeleteJob(jobKey);
                }

                IJobDetail job = JobBuilder.Create<SqlServerSyncJob>()
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

                return ResultModel.Create(ResultState.Success, "执行成功！");
            }
            catch ( Exception ex ) {
                Log4NetHelper.WriteExcepetion(ex);
                return ResultModel.Create(ResultState.Failure, "执行失败！");
            }
        }


        /// <summary>
        /// 启动任务计划
        /// </summary>
        /// <returns></returns>
        public ResultModel StartJob(int jobId, string jobName) {
            try {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if ( !scheduler.IsStarted ) {
                    scheduler.Start();
                }

                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);
                //scheduler.ResumeTrigger(new TriggerKey(jobName, jobGroup));   
                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( scheduler.CheckExists(jobKey) ) {
                    scheduler.TriggerJob(jobKey);
                    scheduler.ResumeJob(jobKey);
                }
                else {
                    IJobDetail job = JobBuilder.Create<SqlServerSyncJob>()
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

                return ResultModel.Create(ResultState.Success, "执行成功！");
            }
            catch ( Exception ex ) {
                Log4NetHelper.WriteExcepetion(ex);
                return ResultModel.Create(ResultState.Failure, "执行失败！");
            }
        }

        /// <summary>
        /// 停止执行任务计划
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName"></param>
        /// <returns></returns>
        public ResultModel StopJob(int jobId, string jobName) {
            try {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if ( !scheduler.IsStarted ) {
                    scheduler.Start();
                }

                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( scheduler.CheckExists(jobKey) ) {
                    scheduler.PauseJob(jobKey);
                }
                else {
                    IJobDetail job = JobBuilder.Create<SqlServerSyncJob>()
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

                return ResultModel.Create(ResultState.Success, "执行成功！");
            }
            catch ( Exception ex ) {
                Log4NetHelper.WriteExcepetion(ex);
                return ResultModel.Create(ResultState.Failure, "执行失败！");
            }
        }

        /// <summary>
        /// 删除任务计划
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName"></param>
        /// <returns></returns>
        public ResultModel DeleteJob(int jobId, string jobName) {
            try {
                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if ( !scheduler.IsStarted ) {
                    scheduler.Start();
                }
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);
                scheduler.PauseTrigger(new TriggerKey(customJob.JobName, customJob.JobGroup));
                scheduler.UnscheduleJob(new TriggerKey(customJob.JobName, customJob.JobGroup));

                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( scheduler.CheckExists(jobKey) ) {
                    var result = scheduler.DeleteJob(jobKey);

                    if ( result ) {
                        CustomJobDetailBLL.CreateInstance().Delete(customJob.JobId, customJob.JobName);
                    }

                    if ( result ) {
                        return ResultModel.Create(ResultState.Success, "执行成功！");
                    }
                    else {
                        return ResultModel.Create(ResultState.Failure, "执行失败！");
                    }
                }
                return ResultModel.Create(ResultState.Success, "执行成功！");
            }
            catch ( Exception ex ) {
                Log4NetHelper.WriteExcepetion(ex);
                return ResultModel.Create(ResultState.Failure, "执行失败！");
            }
        }
    }
}
