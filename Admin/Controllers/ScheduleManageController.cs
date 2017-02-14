using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class ScheduleManageController : Controller
    {
        [HttpPost]
        public JsonResult AddJob()
        {
            //TODO

            return Json(new { });
        }

        [HttpPost]
        public JsonResult StartJob()
        {
            //TODO
            return Json(new { });
        }

        [HttpPost]
        public JsonResult StopJob()
        {
            //TODO
            return Json(new { });
        }

        [HttpPost]
        public JsonResult DeleteJob()
        {
            //TODO
            return Json(new { });
        }

    }
}