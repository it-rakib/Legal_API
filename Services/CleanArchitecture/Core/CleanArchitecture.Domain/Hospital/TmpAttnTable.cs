using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TmpAttnTable
    {
        public int? UserId { get; set; }
        public DateTime? AttnDate { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public string AttendanceStatus { get; set; }
        public TimeSpan? LateBy { get; set; }
        public TimeSpan? ShiftInTime { get; set; }
        public TimeSpan? WorkDuration { get; set; }
        public string SensorId { get; set; }
    }
}
