using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonLeaveType
    {
        public int LeaveId { get; set; }
        public string LeaveName { get; set; }
        public string LeaveShortName { get; set; }
        public decimal? YearlyAllocations { get; set; }
        public decimal? MonthlyAllocations { get; set; }
        public bool IsCarryforward { get; set; }
        public bool IsHalfDayAllow { get; set; }
        public bool? IsActive { get; set; }
        public decimal? BasicPct { get; set; }
        public decimal? AllowPct { get; set; }
    }
}
