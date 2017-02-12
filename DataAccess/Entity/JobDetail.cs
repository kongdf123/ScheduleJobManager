using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entity
{
    public class JobDetail
    {
        public int JobId { get; set; }

        public string JobName { get; set; }

        public string JobChineseName { get; set; }

        public string JobServiceURL { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Description { get; set; }

        public int PageSize { get; set; }

        public int Interval { get; set; }

        public byte State { get; set; }

    }

    public enum JobState:byte
    {
        Waiting = 0,

        Running = 1,

        Stopping = 2
    }
}
