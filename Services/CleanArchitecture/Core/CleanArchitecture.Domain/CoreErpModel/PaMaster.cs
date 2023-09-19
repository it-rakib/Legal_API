using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaMaster
    {
        public long AppraisalMasterId { get; set; }
        public long EmpId { get; set; }
        public int DesignationId { get; set; }
        public DateTime ReviewDate { get; set; }
        public int? ReviewMonth { get; set; }
        public int? ReviewYear { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReviewPeriodFrom { get; set; }
        public DateTime ReviewPeriodTo { get; set; }
        public int? OvarallRating { get; set; }
        public bool? IsFinal { get; set; }
    }
}
