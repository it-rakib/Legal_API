using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeePf
    {
        public long EmpPfid { get; set; }
        public long EmpId { get; set; }
        public decimal? Pfpercentage { get; set; }
        public decimal? PffixedAmount { get; set; }
        public DateTime? PfmembershipDate { get; set; }
        public int? DeductionMonthStart { get; set; }
        public int? DeductionYearStart { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsLocked { get; set; }
    }
}
