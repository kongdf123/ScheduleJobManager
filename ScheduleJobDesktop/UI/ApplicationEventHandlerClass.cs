using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using JobMonitor.Utility;

namespace JobMonitor.Desktop.UI
{
    /// <summary>
    /// 全局异常处理
    /// </summary>
    public class ApplicationEventHandlerClass
    {
        public void OnThreadException(object sender, ThreadExceptionEventArgs e) {
            FormSysMessage.ShowException(e.Exception); // 调用FormSysMessage窗体，显示异常信息。
            Log4NetHelper.WriteExcepetion(e.Exception);
        }
    }
}
