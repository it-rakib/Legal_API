using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeBasicSalaryDetailsNewB
    {
        public long EmpId { get; set; }
        public DateTime EffectFrom { get; set; }
        public int? EmpCategoryId { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? HouseRent { get; set; }
        public decimal? MedicalAllowance { get; set; }
        public decimal? ConveyanceAllowance { get; set; }
        public decimal? FoodAllowance { get; set; }
        public decimal? OthersAllowance { get; set; }
        public decimal? AttBonus { get; set; }
        public decimal? DayAllowance { get; set; }
        public decimal? DistanceAllowance { get; set; }
        public decimal? FestivalHoliday { get; set; }
        public decimal? KeyAllowance { get; set; }
        public decimal? LunchSubsidy { get; set; }
        public decimal? Miscellaneous { get; set; }
        public decimal? MobileAllowance { get; set; }
        public decimal? TiffinAllowance { get; set; }
        public decimal? IftarAllowance { get; set; }
        public decimal? NightAllowance { get; set; }
        public decimal? NightIncentiveAllowance { get; set; }
        public decimal? WeekOffAllowance { get; set; }
        public decimal? TransportCost { get; set; }
        public decimal? Otrate { get; set; }
    }
}
