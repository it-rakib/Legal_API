using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class LeaveAllocation
    {
        public long LeaveAllocationDtlId { get; set; }
        public int EmpId { get; set; }
        public int? LeaveId { get; set; }
        public int? LeaveYear { get; set; }
        public double? LeaveEarned { get; set; }
        public double? LeaveAllocated { get; set; }
        public double? LeaveUsed { get; set; }
        public bool? IsCarriedOn { get; set; }
        public double? CarriedDays { get; set; }
        public double? OthersDeduction { get; set; }
        public double? PaidDays { get; set; }
        public string Remarks { get; set; }
    }
}
