using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobMonitor.Core.Model
{
    /// <summary>
    /// 执行频率
    /// </summary>
    public enum ExecutedFreq : byte
    {
        /// <summary>
        /// 只执行一次
        /// </summary>
        OnlyOneTime = 2,

        /// <summary>
        /// 循环执行
        /// </summary>
        Forever = 1
    }

    /// <summary>
    /// 任务计划执行间隔类型
    /// </summary>
    public enum IntervalType : byte
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

    public enum DBType
    {
        SqlServer = 1,
        MySQL = 2,
        Oracle = 3
    }

    /// <summary>
    /// 数据库服务器状态
    /// </summary>
    public enum Status
    {
        Enabled = 1,
        Disabled = 2
    }

    /// <summary>
    /// 数据库登陆验证方式
    /// </summary>
    public enum AuthenticatedType
    {
        /// <summary>
        /// Sql Server账户
        /// </summary>
        SqlServer = 0,

        /// <summary>
        /// Windows系统集成
        /// </summary>
        Windows = 1
    }

    /// <summary>
    /// 存储方式，1：按每页，2：按数据总量
    /// </summary>
    public enum StoredType
    {
        PageSize = 1,
        MaxCapacity = 2
    }
}
