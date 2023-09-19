using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceUnitWiseShift
    {
        public int? UnitId { get; set; }
        public int? ShiftId { get; set; }
        public bool? Isactive { get; set; }
    }
}
