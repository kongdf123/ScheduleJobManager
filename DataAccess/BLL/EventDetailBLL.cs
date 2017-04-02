using DataAccess.DAL;
using Service.DAL;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
	}
}
