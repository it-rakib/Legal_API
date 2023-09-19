using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceGeneralDutyAll
    {
        public long UnitId { get; set; }
        public DateTime WorkDay { get; set; }
        public bool Owo { get; set; }
        public bool Omood { get; set; }
        public bool Cwo { get; set; }
        public bool Cmood { get; set; }
        public bool Two { get; set; }
        public bool Tmood { get; set; }
        public string Remarks { get; set; }
    }
}
