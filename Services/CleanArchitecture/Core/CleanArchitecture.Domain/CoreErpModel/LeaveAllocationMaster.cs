using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class LeaveAllocationMaster
    {
        public int? LeaveId { get; set; }
        public int? EmpCategoryId { get; set; }
        public int? EmpTypeId { get; set; }
        public int AllocationAfterDays { get; set; }
        public decimal YearlyAllocation { get; set; }
        public decimal WorkingDaysForPerLeave { get; set; }
        public bool IsCarryforward { get; set; }
        public bool IsHalfDayAllow { get; set; }
        public int GenderId { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
