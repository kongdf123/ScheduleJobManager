using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobMonitor.Core.Model;

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

        /*
            Seconds (秒)         ：可以用数字0－59 表示，
            Minutes(分)          ：可以用数字0－59 表示，
            Hours(时)            ：可以用数字0-23表示,
            Day-of-Month(天)  　 ：可以用数字1-31 中的任一一个值，但要注意一些特别的月份
            Month(月)            ：可以用0-11 或用字符串  “JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV and DEC” 表示
            Day-of-Week(每周)　　 :可以用数字1-7表示（1 ＝ 星期日）或用字符口串“SUN, MON, TUE, WED, THU, FRI and SAT”表示
            Year                 :(可选字段)          empty, 1970-2099
        */
        public string CronExpression {
            get {
                string[] cronArr = new string[] { "0", "0", "*", "*", "*", "?", "?" };//示例 0 10 18 15 3 ?        note:每年三月的第15天，下午6点10分都会被触发
                DateTime start = StartDate;
                switch ( IntervalType )
                {
                    case (byte)JobMonitor.Core.Model.IntervalType.Day:
                        cronArr[3] = "0/" + Interval;
                        start = start.AddDays(Interval);
                        break;
                    case (byte)JobMonitor.Core.Model.IntervalType.Hour:
                        cronArr[2] = "0/" + Interval;
                        start = start.AddHours(Interval);
                        break;
                    case (byte)JobMonitor.Core.Model.IntervalType.Minute:
                        cronArr[1] = "0/" + Interval;
                        start = start.AddMinutes(Interval);
                        break;
                    //default:
                    //    throw new Exception("没有指定任务计划执行方式。");
                }
                if ((ExecutedFreq)ExecutedFreq == JobMonitor.Core.Model.ExecutedFreq.OnlyOneTime)
                {
                    return string.Format("{0} {1} {2} {3} {4} ? {5}",
                                start.Second,
                                start.Minute,
                                start.Hour,
                                start.Day,
                                start.Month,
                                start.Year);
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
}
