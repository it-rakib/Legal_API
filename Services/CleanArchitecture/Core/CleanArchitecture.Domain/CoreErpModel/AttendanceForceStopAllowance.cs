using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceForceStopAllowance
    {
        public long EmpId { get; set; }
        public DateTime WorkDate { get; set; }
        public bool StopHoliday { get; set; }
        public bool StopWo { get; set; }
        public bool StopTiffin { get; set; }
        public bool StopNight { get; set; }
    }
}
