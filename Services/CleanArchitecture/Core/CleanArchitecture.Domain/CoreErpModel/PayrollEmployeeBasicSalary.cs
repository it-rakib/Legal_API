using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeBasicSalary
    {
        public long SalaryId { get; set; }
        public long EmpId { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal CurrentSalary { get; set; }
        public int PaymentModeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BankId { get; set; }
        public int? BranchId { get; set; }
        public string BankAccountNo { get; set; }
        public int? SalaryPaidCompany { get; set; }
        public int? CalculationFormulaId { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateBy { get; set; }
    }
}
