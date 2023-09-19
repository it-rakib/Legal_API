using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollMonthlySalary
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int DesignationId { get; set; }
        public int? EmpTypeId { get; set; }
        public int? SalaryStructureId { get; set; }
        public int SalaryYear { get; set; }
        public int SalaryMonth { get; set; }
        public int PaymentModeId { get; set; }
        public int? BankId { get; set; }
        public int? BranchId { get; set; }
        public string BankAccount { get; set; }
        public int? PayrollCompanyId { get; set; }
        public int Mod { get; set; }
        public int TotalDays { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; }
        public int Late { get; set; }
        public int LateDedDay { get; set; }
        public int Exl { get; set; }
        public int Lwp { get; set; }
        public int Lwa { get; set; }
        public int El { get; set; }
        public int Cl { get; set; }
        public int Ml { get; set; }
        public int Wo { get; set; }
        public int H { get; set; }
        public int Spl { get; set; }
        public int Nop { get; set; }
        public int Ee { get; set; }
        public int Lo { get; set; }
        public int GrossDays { get; set; }
        public int BasicDays { get; set; }
        public int AllowanceDays { get; set; }
        public int LayoffDays { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal HouseRent { get; set; }
        public decimal MedicalAllowance { get; set; }
        public decimal ConveyanceAllowance { get; set; }
        public decimal FoodingAllowance { get; set; }
        public decimal OthersAllowance { get; set; }
        public decimal GrossPayAmt { get; set; }
        public decimal BasicPayAmt { get; set; }
        public decimal AllowancePayAmt { get; set; }
        public decimal LayOffPayAmt { get; set; }
        public decimal GrossPayable { get; set; }
        public decimal Adjustment { get; set; }
        public decimal AttBonus { get; set; }
        public decimal AdvanceDed { get; set; }
        public decimal AbsentDed { get; set; }
        public decimal Loded { get; set; }
        public decimal Lwaded { get; set; }
        public decimal TaxDed { get; set; }
        public decimal TaxDedCom { get; set; }
        public decimal LoanDed { get; set; }
        public decimal Pfded { get; set; }
        public decimal UnionSub { get; set; }
        public decimal Penalti { get; set; }
        public decimal LateDed { get; set; }
        public decimal StampFee { get; set; }
        public decimal NetPayment { get; set; }
        public decimal MiscAllowance { get; set; }
        public decimal KeyAllowance { get; set; }
        public decimal MobileAllowance { get; set; }
        public decimal TiffinRate { get; set; }
        public int TiffinDay { get; set; }
        public decimal TiffinAmount { get; set; }
        public decimal IftarRate { get; set; }
        public int IftarDay { get; set; }
        public decimal IftarAmount { get; set; }
        public decimal HolidayRate { get; set; }
        public int HolidayDay { get; set; }
        public decimal HolidayAmount { get; set; }
        public decimal FestivalHolidaysRate { get; set; }
        public int FestivalHolidaysDay { get; set; }
        public decimal FestivalHolidaysAmount { get; set; }
        public decimal NightRate { get; set; }
        public int NightDay { get; set; }
        public decimal NightAmount { get; set; }
        public decimal NightIncentiveRate { get; set; }
        public int NightIncentiveDay { get; set; }
        public decimal NightIncentiveAmount { get; set; }
        public decimal LunchRate { get; set; }
        public int LunchDay { get; set; }
        public decimal LunchAmount { get; set; }
        public decimal Otrate { get; set; }
        public decimal Othour { get; set; }
        public decimal Otamount { get; set; }
        public decimal TotalPayment { get; set; }
        public DateTime ActionTime { get; set; }
        /// <summary>
        /// &apos;R&apos; For Regular,&apos;N&apos; For New Join,&apos;M&apos; for Maternity 
        /// </summary>
        public string SalaryMood { get; set; }
        public bool UnPaid { get; set; }
        public int? ProcessBy { get; set; }
        public DateTime? ProcessDate { get; set; }
        public int Sl { get; set; }
    }
}
