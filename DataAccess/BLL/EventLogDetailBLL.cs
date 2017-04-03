using DataAccess.DAL;
using Service.DAL;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.BLL
{
	public class EventLogDetailBLL
	{
		EventLogDetailDAL _dal;
		EventDetailDAL _eventDetailDAL;
		public EventLogDetailBLL() {
			_dal = EventLogDetailDAL.CreateInstance();
			_eventDetailDAL = EventDetailDAL.CreateInstance();
		}

		public static EventLogDetailBLL CreateInstance() {
			return new EventLogDetailBLL();
		}

		public List<EventLogDetail> GetAll(string connString, DateTime startDate) {
			List<EventLogDetail> listEventLogDetail = new List<EventLogDetail>();
			PageData pageData = GetPageList(connString, 200, 1, startDate);
			if ( pageData.PageList != null ) {
				listEventLogDetail.AddRange(pageData.PageList.Cast<EventLogDetail>());
			}
			if ( pageData.PageCount > 0 ) {
				for ( int i = 2; i <= pageData.PageCount; i++ ) {
					listEventLogDetail.AddRange(GetPageList(connString, 200, i, startDate).PageList.Cast<EventLogDetail>());
				}
			}
			if ( listEventLogDetail != null ) {
				listEventLogDetail.ForEach((entity) => {
					entity.EventName = _eventDetailDAL.Get(entity.EventId)?.EventName;
				});
			}
			return listEventLogDetail;
		}

		public PageData GetPageList(string connString, int pageSize, int curPage, DateTime startDate) {
			return _dal.GetPageList(connString, pageSize, curPage, startDate);
		}
	}
}
