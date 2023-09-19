using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollFormulaStructure
    {
        public int Fsid { get; set; }
        public int FormulaId { get; set; }
        public int SalaryHeadId { get; set; }
        public string FormulaStatement { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string TerminalId { get; set; }
    }
}
