using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeeSeparation
    {
        public long EmpId { get; set; }
        public int EmpStatusId { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime EffectDate { get; set; }
        public DateTime? AcceptDate { get; set; }
        public int NoticePeriod { get; set; }
        public bool IsWaive { get; set; }
        public string Remarks { get; set; }
        public string RefNo { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
    }
}
