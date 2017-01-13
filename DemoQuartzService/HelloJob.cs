using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQuartzService
{
    public class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context) {
            Console.WriteLine("Hell, this is the first job schedule with Quartz.NET.");

        }
    }
}
