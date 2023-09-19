using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeePayrollAdjustmentTemp
    {
        public int AdjustmentId { get; set; }
        public string EmpCode { get; set; }
        public int? EmpId { get; set; }
        public int SalaryMonth { get; set; }
        public int SalaryYear { get; set; }
        public int? AdjustmentTypeId { get; set; }
        public int? PayrollTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public bool IsLocked { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
