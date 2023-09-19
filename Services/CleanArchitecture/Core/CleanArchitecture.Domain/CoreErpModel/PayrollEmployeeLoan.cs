using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeLoan
    {
        public int LoanId { get; set; }
        public long? EmpId { get; set; }
        public int? LoanTypeId { get; set; }
        public DateTime? LoanDate { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? InterestRate { get; set; }
        public int? MonthDuration { get; set; }
        public DateTime? PaymentStartDate { get; set; }
        public string Remarks { get; set; }
        public bool? IsActive { get; set; }
        public long? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string TerminalId { get; set; }
    }
}
