using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeHistoryLogJobLocation
    {
        public int LogId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? JobLocationId { get; set; }
        public int? PrevJobLocationId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
    }
}
