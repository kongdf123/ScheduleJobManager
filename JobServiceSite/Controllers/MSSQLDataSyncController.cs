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

        public JsonResult SyncTargetTableRecords() {
            //TODO
            return Json(new { code = 1 });
        }
    }
}