using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ReportDailyOperationCost
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int DesignationId { get; set; }
        public int GradeId { get; set; }
        public int EmpTypeId { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal Stuff { get; set; }
        public decimal Salary { get; set; }
        public decimal Worker { get; set; }
        public decimal Wages { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal HouseRent { get; set; }
        public decimal Medical { get; set; }
        public decimal Conveyance { get; set; }
        public decimal Food { get; set; }
        public decimal Other { get; set; }
        public DateTime WorkDay { get; set; }
        public decimal DayPay { get; set; }
        public decimal Otrate { get; set; }
        public decimal TiffinAllow { get; set; }
        public decimal IftarAllow { get; set; }
        public decimal NightAllow { get; set; }
        public decimal WeekOffAllowance { get; set; }
        public decimal HolidayAllow { get; set; }
        public decimal LunchAllow { get; set; }
        public string AttStatus { get; set; }
        public int? ActiveStuff { get; set; }
        public int? ActiveWorker { get; set; }
        public int Active { get; set; }
        public int? IdleStuff { get; set; }
        public int? IdleWorker { get; set; }
        public int Idle { get; set; }
        public decimal? WorkDurationStuff { get; set; }
        public decimal? WorkDurationWorker { get; set; }
        public decimal? WorkDurationTotal { get; set; }
        public decimal? ComOthours { get; set; }
        public decimal? Exothours { get; set; }
        public decimal? TotalOthours { get; set; }
        public int? ComOtemp { get; set; }
        public int? Exotemp { get; set; }
        public int? TotalOtemp { get; set; }
        public int IsTiffin { get; set; }
        public int TiffeenEmp { get; set; }
        public int IsIftar { get; set; }
        public int IfterEmp { get; set; }
        public int IsNight { get; set; }
        public int NightEmp { get; set; }
        public int IsWeekOff { get; set; }
        public int WeekOffEmp { get; set; }
        public int IsHoliday { get; set; }
        public int HolidayEmp { get; set; }
        public int IsLunch { get; set; }
        public int LunchEmp { get; set; }
        public decimal? ComOtamount { get; set; }
        public decimal? Exotamount { get; set; }
        public decimal? TotalOtamount { get; set; }
        public decimal TiffinAmount { get; set; }
        public decimal IfterAmount { get; set; }
        public decimal NightAmount { get; set; }
        public decimal WeekOffAmount { get; set; }
        public decimal HoliDayAmount { get; set; }
        public decimal LunchAmount { get; set; }
        public int ShiftId { get; set; }
        public decimal? NightIncentive { get; set; }
        public int? IsNightIncentive { get; set; }
        public int? NightIncentiveEmp { get; set; }
        public decimal? NightincentiveAmount { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
