using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess.DAL;
using MySql.Data.MySqlClient;
using Service.Model;

namespace Service.DAL
{
	public class EventDetailDAL
	{
		public static EventDetailDAL CreateInstance() {
			return new EventDetailDAL();
		}

		public int Insert(List<EventDetail> entityList) {

			if ( entityList == null || entityList.Count == 0 ) {
				return 0;
			}

			int flag = 0;
			StringBuilder insertSQLs = new StringBuilder();
			List<MySqlParameter> paramList = new List<MySqlParameter>();
			entityList.ForEach((entity) => {
				insertSQLs.AppendFormat(
						@"INSERT INTO `custom_event_details`
							(`Id`,
							`EventDate`,
							`EventName`,
							`EventId`)
                        VALUES
                        SELECT 
							@Id_{0},
							@EventDate_{0},
							@EventName_{0},
							@EventId_{0})
						FROM DUAL
						WHERE NOT EXISTS (SELECT * FROM custom_event_details WHERE EventId = @EventId_{0});", flag);
				paramList.AddRange(new List<MySqlParameter> {
				new MySqlParameter("@Id_"+flag, MySqlDbType.Int32 ){ Value = entity.Id },
				new MySqlParameter("@EventDate_"+flag, MySqlDbType.DateTime ){ Value = entity.EventDate },
				new MySqlParameter("@EventName_"+flag, MySqlDbType.VarChar , 45 ){ Value = entity.EventName },
				new MySqlParameter("@EventId_"+flag, MySqlDbType.VarChar , 10){ Value = entity.EventId},
				}); 
				flag++;
			});
			return MySqlDbHelper.ExecuteScalar<int>(insertSQLs.ToString(), paramList.ToArray());
		}

		public PageData GetPageList(int pageSize, int curPage) {

			int recordsTotal = MySqlDbHelper.ExecuteScalar<int>("SELECT COUNT(*) FROM custom_event_details",null);

			string sqlText = @" SELECT `Id`,
                                    `EventDate`,
                                    `EventName`,
                                    `EventId`
                                FROM `custom_event_details` "  
								+ " ORDER BY Id DESC LIMIT " + (curPage - 1) * pageSize + "," + pageSize;
			List<EventDetail> list = new List<EventDetail>();
			MySqlDataReader sqlDataReader = MySqlDbHelper.ExecuteReader(sqlText, null);

			PageData pageData = new PageData();
			pageData.PageSize = pageSize;
			pageData.CurPage = curPage;
			pageData.RecordCount = Math.Max(1, recordsTotal);
			if ( pageData.RecordCount > 0 ) {
				pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));
			}

			while ( sqlDataReader.Read() ) {
				EventDetail entity = new EventDetail();
				ReadRecordData(sqlDataReader, entity);
				list.Add(entity);
			}
			sqlDataReader.Close();
			pageData.PageList = list;
			return pageData;
		}

		void ReadRecordData(IDataReader dataReader, EventDetail entity) {
			if ( dataReader["Id"] != DBNull.Value ) {
				entity.Id = Convert.ToInt32(dataReader["Id"]);
			}
			if ( dataReader["EventId"] != DBNull.Value ) {
				entity.EventId = Convert.ToString(dataReader["EventId"]);
			}
			if ( dataReader["EventName"] != DBNull.Value ) {
				entity.EventName = Convert.ToString(dataReader["EventName"]);
			}

			if ( dataReader["EventDate"] != DBNull.Value ) {
				entity.EventDate = Convert.ToDateTime(dataReader["EventDate"]);
			}
		}
	}
}
