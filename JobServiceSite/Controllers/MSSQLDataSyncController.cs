using DataAccess.BLL;
using DataAccess.DAL;
using DataAccess.Entity;
using Service.BLL;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
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
                Log4NetHelper.WriteInfo("=============同步服务开始==============");


                string storedPath = ConfigurationManager.AppSettings["StoredEventLogFile"];
                if (!System.IO.Directory.Exists(storedPath))
                {
                    System.IO.Directory.CreateDirectory(storedPath);
                }

                List<SqlServerConfigInfo> listSqlServerConfig = SqlServerConfigInfoBLL.CreateInstance().GetAll();

                CustomJobDetail jobDetail = CustomJobDetailBLL.CreateInstance().Get(jobName);
                DateTime startDate = CustomJobDetailBLL.CreateInstance().GetFetchingStartDate(jobDetail.IntervalType, jobDetail.Interval);
                Parallel.ForEach(listSqlServerConfig, (sqlServerConfig) =>
                {
                    List<EventLogDetail> listEventLogDetail = EventLogDetailBLL.CreateInstance().GetAll(sqlServerConfig.ConnString, startDate);

                    ExportCVSFile(sqlServerConfig.StoredType, sqlServerConfig.PageSize, sqlServerConfig.MaxCapacity);
                });
                Log4NetHelper.WriteInfo("MsSqlDataSync-SyncMsSqlData 执行成功!");

                Log4NetHelper.WriteInfo("=============同步服务结束==============");

                return Json(new { Code = 1, Message = "执行成功!" });
            }
            catch (Exception ex)
            {
                Log4NetHelper.WriteExcepetion(ex);
                return Json(new { Code = 0, Message = "执行失败!" });
            }
        }

        public void ExportCVSFile(byte storedType, int pageSize, int maxCapacity)
        {
            int cvsFilePageSize = 1000;
            int cvsFileMaxCapacity = 10000;
            if (storedType == (byte)StoredTypeEnum.PageSize)
            {
                cvsFilePageSize = pageSize;
            }
            else if (storedType == (byte)StoredTypeEnum.MaxCapacity)
            {
                cvsFileMaxCapacity = maxCapacity;
            }

            //TODO

        }
    }
}
