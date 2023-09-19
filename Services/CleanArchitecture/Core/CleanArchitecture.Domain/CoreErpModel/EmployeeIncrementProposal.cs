using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeIncrementProposal
    {
        public long EmpId { get; set; }
        public DateTime ProposedDate { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public DateTime? EffectDate { get; set; }
        public int? ProposedMonth { get; set; }
        public int? ProposedYear { get; set; }
        public decimal? CurrentGrossSalary { get; set; }
        public decimal? CurrentBasicSalary { get; set; }
        public decimal? PbasicSalary { get; set; }
        public decimal? PhouseRent { get; set; }
        public decimal? PincrementAmount { get; set; }
        public decimal? NewGrossSalary { get; set; }
        public int? IncrementOn { get; set; }
        public decimal? IncrementPercent { get; set; }
        public bool? IsActive { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? InActiveDate { get; set; }
        public int? InActiveBy { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? IsLocked { get; set; }
        public DateTime? LockedDate { get; set; }
        public DateTime? PrevIncrementEffectDate { get; set; }
        public decimal? PrevIncrementAmt { get; set; }
        public DateTime? PrevSpecialIncrementEffectDate { get; set; }
        public decimal? PrevSpecialIncrementAmt { get; set; }
        public string Remarks { get; set; }
    }
}
