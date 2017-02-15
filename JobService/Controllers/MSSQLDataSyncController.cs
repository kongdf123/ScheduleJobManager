using DataAccess.BLL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(new { });
        }

    }
}
