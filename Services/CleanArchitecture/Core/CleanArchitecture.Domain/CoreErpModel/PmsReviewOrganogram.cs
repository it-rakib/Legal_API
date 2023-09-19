using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PmsReviewOrganogram
    {
        public long EmpId { get; set; }
        public long ReviewerEmpId { get; set; }
        public DateTime EffectDate { get; set; }
        public int? SuperiorOrder { get; set; }
        public bool? IsActive { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? InActiveDate { get; set; }
        public long? InActiveBy { get; set; }
        public int? MonthDuration { get; set; }
        public bool? IsApproved { get; set; }
        public long? ApprovedBy { get; set; }
        public string ReviewerType { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
