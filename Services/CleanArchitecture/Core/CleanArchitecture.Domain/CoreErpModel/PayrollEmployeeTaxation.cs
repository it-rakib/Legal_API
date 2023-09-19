using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeTaxation
    {
        public int TaxId { get; set; }
        public long? EmpId { get; set; }
        public decimal? TaxAmountComp { get; set; }
        public decimal? TaxAmountEmp { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsLocked { get; set; }
    }
}
