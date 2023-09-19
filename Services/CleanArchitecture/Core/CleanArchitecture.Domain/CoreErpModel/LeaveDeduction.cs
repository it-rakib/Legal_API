using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class LeaveDeduction
    {
        public long DedId { get; set; }
        public int? LeaveId { get; set; }
        public long? EmpId { get; set; }
        public int? Dmonth { get; set; }
        public int? Dyear { get; set; }
        public int? LateDays { get; set; }
        public decimal? Dleave { get; set; }
        public bool? IsElPaid { get; set; }
        public int? DtypeId { get; set; }
        public string Remarks { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
