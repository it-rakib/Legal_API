using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceOtadjustment
    {
        public string EmpCode { get; set; }
        public long? EmpId { get; set; }
        public DateTime? WorkDate { get; set; }
        public DateTime? AdjustmentTo { get; set; }
        public int? Othour { get; set; }
        public string Remarks { get; set; }
    }
}
