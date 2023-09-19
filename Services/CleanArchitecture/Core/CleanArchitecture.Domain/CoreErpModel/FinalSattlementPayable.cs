using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class FinalSattlementPayable
    {
        public long? Empid { get; set; }
        public string SalaryPaidCompany { get; set; }
        public int? GrossDays { get; set; }
        public int? AllowanceDays { get; set; }
        public double? GrossSalary { get; set; }
        public double? BasicSalary { get; set; }
        public decimal? Otrate { get; set; }
        public decimal? UnpaidSalary { get; set; }
        public int? CompanyId { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int? DesignationId { get; set; }
        public int? EmpTypeId { get; set; }
        public int? BankId { get; set; }
        public string BankAccount { get; set; }
        public int? LengthYear { get; set; }
        public int? LengthMonth { get; set; }
        public int? LengthDays { get; set; }
        public decimal? Elbalance { get; set; }
        public double? Elamount { get; set; }
        public double? GratuityAmount { get; set; }
        public double? ServiceBenefitAmount { get; set; }
        public double? TerminationBenefit { get; set; }
        public double? RetirmentBenefitAmount { get; set; }
        public double? ExpirationBenefitAmount { get; set; }
        public double? BonusAmount { get; set; }
        public double? OtherAllowance { get; set; }
        public decimal? ProvidentFundAmount { get; set; }
        public double? TiffinAllowance { get; set; }
        public double? HolidayAllowance { get; set; }
        public double? NightAllowance { get; set; }
        public double? MobileAllowance { get; set; }
        public int? NoticePeriodPayableDays { get; set; }
        public double? NoticePeriodPayableAmount { get; set; }
        public int? SuspensionPayday { get; set; }
        public decimal? SuspensionPayAmount { get; set; }
        public double? LoanDeduction { get; set; }
        public int? NoticePeriodDeductionDay { get; set; }
        public double? NoticePeriodDeductionAmount { get; set; }
        public double? OtherDeduction { get; set; }
        public decimal? TaxAmt { get; set; }
        public double? StampFee { get; set; }
        public double? NetPayableAmount { get; set; }
        public string Remarks { get; set; }
        public int? PrintQty { get; set; }
    }
}
