using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollMonthlyArearThird
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int DesignationId { get; set; }
        public int SalaryYear { get; set; }
        public int SalaryMonth { get; set; }
        public int PaymentModeId { get; set; }
        public int? BankId { get; set; }
        public string BancAccount { get; set; }
        public int? PayrollCompanyId { get; set; }
        public int Mod { get; set; }
        public int GrossDays { get; set; }
        public int BasicDays { get; set; }
        public int AllowanceDays { get; set; }
        public int Lodays { get; set; }
        public decimal PrevGross { get; set; }
        public decimal IncrementAmount { get; set; }
        public decimal CurrentGross { get; set; }
        public decimal Bonus { get; set; }
        public decimal GrossPayAmt { get; set; }
        public decimal BasicPayAmt { get; set; }
        public decimal AllowancePayAmt { get; set; }
        public decimal LayOffPayAmt { get; set; }
        public decimal Otrate { get; set; }
        public int Othour { get; set; }
        public decimal Otamount { get; set; }
        public decimal StampFee { get; set; }
        public decimal NetPayment { get; set; }
        public DateTime ActionTime { get; set; }
        public bool UnPaid { get; set; }
        public DateTime EffectDate { get; set; }
        public int? ProcessBy { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
