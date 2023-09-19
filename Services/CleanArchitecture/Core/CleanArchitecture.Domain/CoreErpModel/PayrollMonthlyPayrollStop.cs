using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollMonthlyPayrollStop
    {
        public int PayrollStopId { get; set; }
        public long EmpId { get; set; }
        public int? MonthFrom { get; set; }
        public int? YearFrom { get; set; }
        public int? MonthTo { get; set; }
        public int? YearTo { get; set; }
        public int? StopTypeId { get; set; }
        public int? StopPayrollTypeId { get; set; }
        public int? IsOpen { get; set; }
        public DateTime? StopDate { get; set; }
        public DateTime? OpenDate { get; set; }
        public long? OpenUserId { get; set; }
        public DateTime? EffectDate { get; set; }
        public string Remarks { get; set; }
        public long? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string TerminalId { get; set; }
    }
}
