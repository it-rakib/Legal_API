using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeHistoryLogIncrementB
    {
        public long LogId { get; set; }
        public DateTime? LogDate { get; set; }
        public long EmpId { get; set; }
        public decimal? PreviousSalary { get; set; }
        public long? IncrementId { get; set; }
        public DateTime? EntryDate { get; set; }
        public long? UserId { get; set; }
        public string TerminalId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? OriginalIncrementId { get; set; }
    }
}
