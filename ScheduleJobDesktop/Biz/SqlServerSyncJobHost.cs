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
    public class SqlServerSyncJobHost
    {
        public static SqlServerSyncJobHost GetInstance() {
            return new SqlServerSyncJobHost();
        }

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <returns></returns>
        public ResultModel StoreJob(int jobId, string jobName) {
            try {
                var customJob = CustomJobDetailBLL.GetInstance().Get(jobId, jobName);

                IScheduler scheduler = QuartzNetHelper.GetScheduler();
                if ( !scheduler.IsStarted ) {
                    scheduler.Start();
                }
                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( !scheduler.CheckExists(jobKey) ) {
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
                }
                if ( customJob.State == (byte)JobState.Running ) {
                    scheduler.TriggerJob(jobKey);
                    scheduler.ResumeJob(jobKey);
                }
                Log4NetHelper.WriteInfo("保存成功！");
                return ResultModel.Create(ResultState.Success, "保存成功！");
            }
            catch ( Exception ex ) {
                Log4NetHelper.WriteExcepetion(ex);
                return ResultModel.Create(ResultState.Failure, "保存失败！");
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

                CustomJobDetail customJob = CustomJobDetailBLL.GetInstance().Get(jobId, jobName);
                //scheduler.ResumeTrigger(new TriggerKey(jobName, jobGroup));   
                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( scheduler.CheckExists(jobKey) ) {
                    scheduler.TriggerJob(jobKey);
                    scheduler.ResumeJob(jobKey);
                }

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

                CustomJobDetail customJob = CustomJobDetailBLL.GetInstance().Get(jobId, jobName);

                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( scheduler.CheckExists(jobKey) ) {
                    scheduler.PauseJob(jobKey);
                }

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
                CustomJobDetail customJob = CustomJobDetailBLL.GetInstance().Get(jobId, jobName);
                scheduler.PauseTrigger(new TriggerKey(customJob.JobName, customJob.JobGroup));
                scheduler.UnscheduleJob(new TriggerKey(customJob.JobName, customJob.JobGroup));

                var jobKey = JobKey.Create(customJob.JobName, customJob.JobGroup);
                if ( scheduler.CheckExists(jobKey) ) {
                    scheduler.DeleteJob(jobKey);
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
