using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entity
{
    /// <summary>
    /// 自定义任务计划-数据表，有别于Quartz.NET里的任务表
    /// </summary>
    public class CustomJobDetail
    {
        public int JobId { get; set; }

        public string JobName { get; set; }

        public string JobGroup { get; set; }

        public string JobChineseName { get; set; }

        public string JobServiceURL { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public byte ExecutedFreq { get; set; }

        public string Description { get; set; }

        public int PageSize { get; set; }

        public int Interval { get; set; }

        public byte IntervalType { get; set; }

        public byte State { get; set; }

        public string CronExpression {
            get {
                string[] cronArr = new string[] { "*", "*", "*", "*", "*", "*" };//示例 0 10 18 15 3 ?        note:每年三月的第15天，下午6点10分都会被触发
                switch (IntervalType)
                {
                    case (byte)IntervalTypeEnum.Day:
                        cronArr[3] = "0/" + Interval;
                        break;
                    case (byte)IntervalTypeEnum.Hour:
                        cronArr[2] = "0/" + Interval;
                        break;
                    case (byte)IntervalTypeEnum.Minute:
                        cronArr[1] = "0/" + Interval;
                        break;
                    default:
                        throw new Exception("没有指定任务计划执行方式。");
                }
                return string.Join(" ", cronArr);
            }
        }

        public string StateDescription {
            get {
                switch ((JobState)State)
                {
                    case JobState.Waiting:
                        return "等待中";
                    case JobState.Running:
                        return "运行中";
                    case JobState.Stopping:
                        return "已停止";
                    default:
                        break;
                }
                return "";
            }
        }
    }

    /// <summary>
    /// 执行频率
    /// </summary>
    public enum ExecutedFreq : byte
    {
        /// <summary>
        /// 只执行一次
        /// </summary>
        OnlyOneTime = 0,

        /// <summary>
        /// 循环执行
        /// </summary>
        Forever = 1
    }

    /// <summary>
    /// 任务计划执行间隔类型
    /// </summary>
    public enum IntervalTypeEnum : byte
    {
        /// <summary>
        /// 天
        /// </summary>
        Day = 1,

        /// <summary>
        /// 小时
        /// </summary>
        Hour = 2,

        /// <summary>
        /// 分钟
        /// </summary>
        Minute = 3
    }

    /// <summary>
    /// 任务计划执行情况
    /// </summary>
    public enum JobState : byte
    {
        /// <summary>
        /// 等待
        /// </summary>
        Waiting = 0,

        /// <summary>
        /// 执行中
        /// </summary>
        Running = 1,

        /// <summary>
        /// 停止
        /// </summary>
        Stopping = 2
    }
}
