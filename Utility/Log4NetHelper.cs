using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class Log4NetHelper
    {
        public static void WriteInfo(string message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("InfoLog");
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }

        public static void WriteExcepetion(Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("ExceptionLog");
            if (log.IsErrorEnabled)
            {
                log.Error(ex.ToString());
            }
        }
    }
}
