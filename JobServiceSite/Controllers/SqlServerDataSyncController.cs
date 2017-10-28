using DataAccess.BLL;
using DataAccess.DAL;
using DataAccess.Entity;
using Service.BLL;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using JobMonitor.Utility;
using JobMonitor.Core.Model;

namespace JobServiceSite.Controllers
{
    public class SqlServerDataSyncController : Controller
    {
        object lockedObj = new object();

        /// <summary>
        /// 执行同步任务，定期下载Sql Server 7.0上的数据记录，并以CVS文件格式保存到指定存储地址
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult SyncMsSqlData()
        {
            try
            {
                Log4NetHelper.WriteInfo("=============同步服务开始==============");

                List<SqlServerConfigInfo> listSqlServerConfig = SqlServerConfigInfoBLL.CreateInstance().GetAll();

                string jobName = Request["jobName"];
                CustomJobDetail jobDetail = CustomJobDetailBLL.GetInstance().Get(jobName);
                DateTime startDate = CustomJobDetailBLL.GetInstance().GetFetchingStartDate(jobDetail.IntervalType, jobDetail.Interval);
                Parallel.ForEach(listSqlServerConfig, new ParallelOptions { MaxDegreeOfParallelism = 5 }, (sqlServerConfig) =>
                   {
                       Monitor.Enter(lockedObj);
                       try
                       {
                           List<EventLogDetail> listEventLogDetail = EventLogDetailBLL.CreateInstance().GetAll(sqlServerConfig.ConnString, startDate);

                           if (listEventLogDetail != null && listEventLogDetail.Count > 0)
                           {
                               int cvsFileCapacity = 1000;
                               if (sqlServerConfig.StoredType == (byte)StoredType.PageSize)
                               {
                                   cvsFileCapacity = sqlServerConfig.PageSize;
                               }
                               else if (sqlServerConfig.StoredType == (byte)StoredType.MaxCapacity)
                               {
                                   cvsFileCapacity = sqlServerConfig.MaxCapacity;
                               }

                               ExportCVSFile(listEventLogDetail, sqlServerConfig.EquipmentNum, cvsFileCapacity);
                           }
                       }
                       catch (Exception ex)
                       {
                           Log4NetHelper.WriteExcepetion(ex);
                       }
                       finally
                       {
                           Monitor.Exit(lockedObj);
                       }
                       System.Threading.Thread.Sleep(1000);
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

        /// <summary>
        /// 导出数据到CSV文件
        /// </summary>
        /// <param name="listEventLogDetail"></param>
        /// <param name="equipmentNum"></param>
        /// <param name="storedType"></param>
        /// <param name="pageSize"></param>
        /// <param name="maxCapacity"></param>
        void ExportCVSFile(List<EventLogDetail> listEventLogDetail, string equipmentNum, int cvsFileCapacity)
        {
            string storedFolder = string.Format("{0}/{1}/{2}/{3}/{4}/",
                                            ConfigurationManager.AppSettings["StoredEventLogFile"],
                                            DateTime.Now.Year,
                                            DateTime.Now.Month,
                                            DateTime.Now.Day,
                                            equipmentNum);
            if (!System.IO.Directory.Exists(storedFolder))
            {
                System.IO.Directory.CreateDirectory(storedFolder);
            }

            int cvsFileCount = Convert.ToInt32(Math.Ceiling((double)listEventLogDetail.Count / (double)cvsFileCapacity));

            List<EventLogDetail> filePartial = new List<EventLogDetail>();
            for (int i = 1; i <= cvsFileCount; i++)
            {
                #region 写入CVS文件

                filePartial = listEventLogDetail.Skip((i - 1) * cvsFileCapacity).Take(cvsFileCapacity).ToList();
                /* 例：WB0G05-20161220-055321-20161220-225003.csv
                    1、WB0G:固定项
                    2、05：机台号05号机
                    3、-20161220-055321：文本内履历开始日期、时间
                    4、-20161220-225003：文本内履历结束日期、时间
                    5、.csv：文本格式
                */
                DateTime start = filePartial.First().EventDate;
                DateTime end = filePartial.Last().EventDate;
                string fileName = string.Format("{0}-{1}-{2}-{3}-{4}.csv",
                                                    equipmentNum,
                                                    start.ToString("yyyyMMdd"),
                                                    start.ToString("HHmmss"),
                                                    end.ToString("yyyyMMdd"),
                                                    end.ToString("HHmmss"));

                using (FileStream fileStream = new FileStream(storedFolder + "/" + fileName, FileMode.Create, FileAccess.Write))
                using (StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.UTF8))
                {
                    //列头
                    streamWriter.WriteLine("EventDate,EventName,EventId,Operator,ProductName,UnitStatusID");

                    //各行数据
                    foreach (EventLogDetail eventLog in filePartial)
                    {
                        streamWriter.WriteLine("{0},{1},{2},{3},{4},{5}",
                                                eventLog.EventDate.ToString(),
                                                eventLog.EventName,
                                                eventLog.EventId,
                                                CvsCellFilter(eventLog.Operator),
                                                CvsCellFilter(eventLog.ProductName),
                                                eventLog.UnitStatusDescription);
                    }
                    streamWriter.Close();
                    fileStream.Close();
                }

                #endregion
            }//for
        }

        /// <summary>
        /// 过滤特殊字符
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        string CvsCellFilter(string record)
        {
            record = record.Replace("\"", "\"\"");//替换英文冒号 英文冒号需要换成两个冒号
            if (record.Contains(',') || record.Contains('"')
                || record.Contains('\r') || record.Contains('\n')) //含逗号 冒号 换行符的需要放到引号中
            {
                record = string.Format("\"{0}\"", record);
            }
            return record;
        }
    }
}
