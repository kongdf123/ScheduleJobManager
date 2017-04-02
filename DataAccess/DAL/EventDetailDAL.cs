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
	}
}
