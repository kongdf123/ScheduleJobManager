using Service.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobServiceSite.Controllers
{
    public class MSSQLDataSyncController : Controller
    {
        // GET: DataSyncSQLServer
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public JsonResult Download(string jobName) {
            //TODO
            JobDetailBLL jobDetailBLL = new JobDetailBLL();
            var jobDetail = jobDetailBLL.Get(jobName);

            if ( jobDetail == null ) {
                return Json(new { code = 0 });
            }


            return Json(new { code = 1 });
        }

        [HttpPost]
        public JsonResult Upload(string jobName) {
            //TODO
            return Json(new { code = 1 });
        }
    }
}