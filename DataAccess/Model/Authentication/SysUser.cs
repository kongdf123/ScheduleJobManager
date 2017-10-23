using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobMonitor.Core.Model
{
    public class SysUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
    }
}
