using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollAnnualLeavePayment
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int DesignationId { get; set; }
        public int? LeaveYear { get; set; }
        public int PayYear { get; set; }
        public int PayMonth { get; set; }
        public int PaymentModeId { get; set; }
        public int? BankId { get; set; }
        public int? BranchId { get; set; }
        public string BankAccount { get; set; }
        public int? PayrollCompanyId { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal BalanceDay { get; set; }
        public decimal PayableDay { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal StampFee { get; set; }
        public decimal NetPayment { get; set; }
        public bool UnPaid { get; set; }
        public int? ProcessBy { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
