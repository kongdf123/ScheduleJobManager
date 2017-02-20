using DataAccess.DAL;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Service.DAL
{
    public class EventLogDetailDAL
    {
        public static EventLogDetailDAL CreateInstance()
        {
            return new EventLogDetailDAL();
        }

        public PageData GetPageList(string connString, int pageSize, int curPage, DateTime startDate)
        {
            string sqlWhere = "";
            List<SqlParameter> listParms = new List<SqlParameter>();
            sqlWhere = " AND EventDate>@EventDate ";
            listParms.Add(new SqlParameter("@EventDate", SqlDbType.DateTime) { Value = startDate.ToString("yyyy-MM-dd HH:mm:ss") });

            int recordsTotal = SqlServerDbHelper.ExecuteScalar<int>(connString,"SELECT COUNT(*) FROM mc_event_log WHERE Operator<>'' " + sqlWhere, listParms.ToArray());

            string sqlWhere2 = "";
            List<SqlParameter> listParms2 = new List<SqlParameter>();
            sqlWhere2 = " AND EventDate>@EventDate ";
            listParms2.Add(new SqlParameter("@EventDate", SqlDbType.DateTime) { Value = startDate.ToString("yyyy-MM-dd HH:mm:ss") });
            string sqlText = " SELECT TOP " + pageSize + @" EventId,
                                EventDate,
                                Operator,
                                ProductName,
                                UnitStatusID
                            FROM mc_event_log 
                            WHERE Operator<>''
                            " + sqlWhere2 + " AND EventId NOT IN( SELECT TOP " + (curPage - 1) * pageSize + @" EventId FROM mc_event_log WHERE Operator<>'' " + sqlWhere2 + @" ORDER BY EventDate ASC) 
                            ORDER BY EventDate ASC ";
            List<EventLogDetail> list = new List<EventLogDetail>();
            SqlDataReader sqlDataReader = SqlServerDbHelper.ExecuteReader(connString, sqlText, listParms2.ToArray());

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = Math.Max(1, recordsTotal);
            if (pageData.RecordCount > 0)
            {
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));
            }

            while (sqlDataReader.Read())
            {
                EventLogDetail eventLogDetail = new EventLogDetail();
                ReadRecordData(sqlDataReader, eventLogDetail);
                list.Add(eventLogDetail);
            }
            sqlDataReader.Close();
            pageData.PageList = list;
            return pageData;
        }

        void ReadRecordData(IDataReader dataReader, EventLogDetail eventLogDetail)
        {
            if (dataReader["EventId"] != DBNull.Value)
            {
                eventLogDetail.EventId = Convert.ToString(Convert.ToInt32(dataReader["EventId"]), 16).PadLeft(7, '0');
            }

            if (dataReader["EventDate"] != DBNull.Value)
            {
                eventLogDetail.EventDate = Convert.ToDateTime(dataReader["EventDate"]);
            }

            if (dataReader["Operator"] != DBNull.Value)
            {
                eventLogDetail.Operator = Convert.ToString(dataReader["Operator"]);
            }

            if (dataReader["ProductName"] != DBNull.Value)
            {
                eventLogDetail.ProductName = Convert.ToString(dataReader["ProductName"]);
            }

            if (dataReader["UnitStatusID"] != DBNull.Value)
            {
                eventLogDetail.UnitStatusID = Convert.ToByte(dataReader["UnitStatusID"]);
            }
        }
    }
}
