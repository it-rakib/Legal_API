using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollHourlySalary
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int DesignationId { get; set; }
        public int SalaryYear { get; set; }
        public int SalaryWeek { get; set; }
        public int PaymentModeId { get; set; }
        public int? BankId { get; set; }
        public int? BranchId { get; set; }
        public string BankAccount { get; set; }
        public int? PayrollCompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDays { get; set; }
        public decimal TotalWorkingHour { get; set; }
        public decimal DaySalary { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TotalHourPayAmt { get; set; }
        public decimal Adjustment { get; set; }
        public decimal AttBonus { get; set; }
        public decimal AdvanceDed { get; set; }
        public decimal AbsentDed { get; set; }
        public decimal TaxDed { get; set; }
        public decimal TaxDedCom { get; set; }
        public decimal LoanDed { get; set; }
        public decimal Pfded { get; set; }
        public decimal Penalti { get; set; }
        public decimal LateDed { get; set; }
        public decimal StampFee { get; set; }
        public decimal NetPayment { get; set; }
        public string SalaryMood { get; set; }
        public DateTime ActionTime { get; set; }
        public bool UnPaid { get; set; }
        public int? ProcessBy { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
