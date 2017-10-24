using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobMonitor.Core.Model
{
    public class ResultModel
    {
        public static ResultModel Create(ResultState state, string message) {
            return new ResultModel { State = state, Message = message };
        }

        public ResultState State { get; set; }

        public string Message { get; set; }
    }

    public enum ResultState
    {
        Success = 1,
        Failure = 2
    }
}
