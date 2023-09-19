using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeHistoryLogCategoryChange
    {
        public long LogId { get; set; }
        public DateTime? LogDate { get; set; }
        public long EmpId { get; set; }
        public decimal? PreviousSalary { get; set; }
        public long? CategoryChangeId { get; set; }
        public int? PrevCategoryId { get; set; }
        public DateTime? EntryDate { get; set; }
        public long? UserId { get; set; }
        public string TerminalId { get; set; }
    }
}
