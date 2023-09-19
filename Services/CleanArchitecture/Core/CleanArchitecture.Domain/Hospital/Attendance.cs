using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Attendance
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public DateTime AttnDate { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public int ImportId { get; set; }
        public string AttendanceStatus { get; set; }
        public TimeSpan? LateBy { get; set; }
        public TimeSpan? ShiftInTime { get; set; }
        public TimeSpan? WorkDuration { get; set; }
    }
}
