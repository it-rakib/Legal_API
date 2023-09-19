using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeLoanInstallment
    {
        public int InstallmentId { get; set; }
        public int LoanId { get; set; }
        public int? InstallmentNo { get; set; }
        public DateTime? InstallmentDate { get; set; }
        public decimal InstallmentAmount { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? InterestAmount { get; set; }
        public decimal? PrincipalAmount { get; set; }
        public bool? IsPaid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? IsHold { get; set; }
        public bool? IsLocked { get; set; }
    }
}
