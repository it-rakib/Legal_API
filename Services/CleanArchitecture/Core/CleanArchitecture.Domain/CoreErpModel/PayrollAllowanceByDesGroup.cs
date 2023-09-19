using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollAllowanceByDesGroup
    {
        public int AllowanceByDesGroupId { get; set; }
        public int DesGroupId { get; set; }
        public decimal LunchPayRate { get; set; }
        public decimal TiffinPayRate { get; set; }
        public decimal IftarPayRate { get; set; }
        public decimal NightPayRate { get; set; }
        public decimal HolidayPayRate { get; set; }
        public DateTime EffectDate { get; set; }
    }
}
