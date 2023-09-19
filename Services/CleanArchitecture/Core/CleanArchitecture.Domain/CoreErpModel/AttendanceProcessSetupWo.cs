using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceProcessSetupWo
    {
        public int UnitId { get; set; }
        public DateTime WorkDay { get; set; }
        public bool? IsWeekOff { get; set; }
        public int? Wothour { get; set; }
    }
}
