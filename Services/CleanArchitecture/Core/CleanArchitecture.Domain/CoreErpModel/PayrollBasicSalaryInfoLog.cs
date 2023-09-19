using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollBasicSalaryInfoLog
    {
        public long? EmpId { get; set; }
        public int? PaymentModeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BankId { get; set; }
        public int? BranchId { get; set; }
        public string BankAccountNo { get; set; }
        public int? SalaryPaidCompany { get; set; }
        public int? CalculationFormulaId { get; set; }
        public int? SalaryId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
    }
}
