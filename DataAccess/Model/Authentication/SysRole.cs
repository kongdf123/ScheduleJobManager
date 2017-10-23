using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobMonitor.Core.Model
{
    public class SysRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}
