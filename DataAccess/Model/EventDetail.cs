using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Model
{
	public class EventDetail
	{
		public int Id { get; set; }

		public DateTime EventDate { get; set; }

		public string EventName { get; set; }

		public string EventId { get; set; }
	}
}
