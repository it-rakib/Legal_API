using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DoctorRickSchedule
    {
        public int DoctorRickScheduleId { get; set; }
        public int? DoctorId { get; set; }
        public string DayName { get; set; }
    }
}
