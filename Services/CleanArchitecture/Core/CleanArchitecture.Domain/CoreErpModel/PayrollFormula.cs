using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollFormula
    {
        public int FormulaId { get; set; }
        public string FormulaName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
    }
}
