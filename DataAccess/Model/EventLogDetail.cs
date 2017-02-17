using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Model
{
    public class EventLogDetail
    {
        public DateTime EventDate { get; set; }

        public string EventName { get; set; }

        public string EventId { get; set; }

        public string Operator { get; set; }

        public string ProductName { get; set; }

        public byte UnitStatusID { get; set; }

        public string UnitStatusDescription {
            get {
                switch ((UnitStatusEnum)UnitStatusID)
                {
                    case UnitStatusEnum.STOP:
                        return "STOP";
                    case UnitStatusEnum.RUNING:
                        return "RUNING";
                    case UnitStatusEnum.ERROR:
                        return "ERROR";
                    case UnitStatusEnum.WAIT:
                        return "WAIT";
                    case UnitStatusEnum.MachineAdjust:
                        return "Machine Adjust";
                    case UnitStatusEnum.UNKNOWN:
                        return "UNKNOWN";
                    case UnitStatusEnum.OperatorCall:
                        return "Operator Call";
                    default:
                        break;
                }
                return "";
            }
        }
    }

    public enum UnitStatusEnum : byte
    {
        STOP = 2,
        RUNING = 4,
        ERROR = 8,
        WAIT = 16,
        MachineAdjust = 32,
        UNKNOWN = 64,
        OperatorCall = 128
    }
}
