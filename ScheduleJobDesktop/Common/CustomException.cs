using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleJobDesktop.Common
{
    /// <summary>
    /// 自定义异常类
    /// </summary>
    public class CustomException : ApplicationException
    {
        /// <summary>
        /// 异常类型
        /// </summary>
        public ExceptionType Type {
            get;
            set;
        }

        /// <summary>
        /// 异常详细信息
        /// </summary>
        public string DetailMessage {
            get;
            set;
        }

        /// <summary>
        /// 系统自定义异常类，默认实例化方法，异常类型为警告。
        /// </summary>
        /// <param name="message">异常信息</param>
        public CustomException(string message)
                : base(message)
        {
            Type = ExceptionType.Warn;
        }

        /// <summary>
        /// 系统自定义异常类，扩展实例化方法，可以指定异常类型。
        /// </summary>
        /// <param name="message">异常信息</param>
        /// <param name="type">异常类型</param>
        public CustomException(string message, ExceptionType type)
                : base(message)
        {
            Type = type;
        }

        /// <summary>
        /// 系统自定义异常类，扩展实例化方法，可以指定异常类型及异常详细信息。
        /// </summary>
        /// <param name="message">异常信息</param>
        /// <param name="type">异常类型</param>
        /// <param name="detailMessage">异常详细信息</param>
        public CustomException(string message, ExceptionType type, string detailMessage)
                : base(message)
        {
            Type = type;
            DetailMessage = detailMessage;
        }
    }

    /// <summary>
    /// 异常类型枚举，分别为提示、警告、错误。
    /// </summary>
    public enum ExceptionType
    {
        Info, Warn, Error
    }
}
