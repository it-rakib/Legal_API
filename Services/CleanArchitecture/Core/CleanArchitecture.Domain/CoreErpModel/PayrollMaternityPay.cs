using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollMaternityPay
    {
        public long MtltrackId { get; set; }
        public long Lrid { get; set; }
        public long? EmpId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TotalPresentDays { get; set; }
        public DateTime? Last3SalaryDate { get; set; }
        public DateTime? LastSalaryDate { get; set; }
        public DateTime? FirstInstdate { get; set; }
        public decimal? InstallmentPay { get; set; }
        public DateTime? MtlreturnDate { get; set; }
        public DateTime? FinalInstDate { get; set; }
        public decimal? Last3SalaryPay { get; set; }
        public decimal? Last3BillPay { get; set; }
        public decimal? Last3SupplePay { get; set; }
        public decimal? Last3ArearPay { get; set; }
        public decimal? Last3AdvancePay { get; set; }
        public decimal? Last3BonusPay { get; set; }
        public decimal? LastPayGross { get; set; }
        public decimal? LastPayBasic { get; set; }
        public decimal? Total3MonthPay { get; set; }
        public decimal? PerDayPay { get; set; }
        public decimal? Total112DaysPay { get; set; }
        public decimal? Stamp { get; set; }
        public decimal? NetPayPerInst { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? BasicSalary { get; set; }
    }
}
