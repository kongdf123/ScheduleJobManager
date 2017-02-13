using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entity
{
    public class DBConfiguration
    {
        public int Id { get; set; }

        public string ServerIP { get; set; }

        public string DBName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
