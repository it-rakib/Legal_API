using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollFestivalBonu
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int DesignationId { get; set; }
        public int PaymentModeId { get; set; }
        public int? BankId { get; set; }
        public int? BranchId { get; set; }
        public string BankAccount { get; set; }
        public int? PayrollCompanyId { get; set; }
        public DateTime? BonusDate { get; set; }
        public int? HolidayId { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal BasicSalary { get; set; }
        public bool BonusLen { get; set; }
        public decimal BonusAmount { get; set; }
        public decimal Adjustment { get; set; }
        public decimal StampFee { get; set; }
        public decimal NetPayment { get; set; }
        public DateTime ActionTime { get; set; }
        public bool Unpaid { get; set; }
        public int? ProcessBy { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
