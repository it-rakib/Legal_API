using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeHistoryLogTaxation
    {
        public int LogId { get; set; }
        public long? EmpId { get; set; }
        public DateTime? LogDate { get; set; }
        public int? TaxId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UserId { get; set; }
    }
}
