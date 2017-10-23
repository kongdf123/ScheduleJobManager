using DataAccess.DAL;
using Service.DAL;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobMonitor.Utility;

namespace Service.BLL
{
	public class EventDetailBLL
	{
		EventDetailDAL _dal;
		public EventDetailBLL() {
			_dal = EventDetailDAL.CreateInstance();
		}

		public static EventDetailBLL CreateInstance() {
			return new EventDetailBLL();
		}
		public void CheckValid(EventDetail entity) {
			//TODO 
		}

		public int Insert(List<EventDetail> entityList) {
			if ( entityList != null ) {
				entityList.ForEach((entity) => {
					CheckValid(entity);
				});
			}
			return _dal.Insert(entityList);
		}

		public PageData GetPageList(int pageSize, int curPage) {
			return _dal.GetPageList(pageSize, curPage);
		}

		public EventDetail Get(string eventId) {
			EventDetail entity = CacheHelper.CreateInstance().GetCache<EventDetail>(eventId);
			if ( entity == null ) {
				entity = _dal.Get(eventId);
				if ( entity != null ) {
					CacheHelper.CreateInstance().SetCache(entity, eventId, DateTime.Now.AddHours(12));
				}
			}
			return entity;
		}
	}
}
