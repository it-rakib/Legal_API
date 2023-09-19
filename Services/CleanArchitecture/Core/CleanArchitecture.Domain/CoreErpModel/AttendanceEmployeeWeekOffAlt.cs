using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceEmployeeWeekOffAlt
    {
        public int? DayId { get; set; }
        public int? UnitId { get; set; }
        public int? JobLocationId { get; set; }
        public DateTime? Wodate { get; set; }
    }
}
