using DataAccess.BLL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;

namespace JobServiceSite.Controllers
{
    public class MsSqlDataSyncController : Controller
    {
        [HttpPost]
        public JsonResult SyncMsSqlData(string jobName)
        {
            try
            {
                //TODO
                CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobName);


                //scheduler.ResumeTrigger(new TriggerKey(jobName, jobGroup));  

                Log4NetHelper.WriteInfo("MsSqlDataSync-SyncMsSqlData 执行成功!");  
                return Json(new { Code = 1, Message = "执行成功!" });
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
                return Json(new { Code = 1, Message = "执行失败!" });
            }
        }

    }
}
