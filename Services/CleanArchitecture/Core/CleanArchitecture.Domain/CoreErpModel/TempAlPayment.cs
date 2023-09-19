using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TempAlPayment
    {
        public long EmpId { get; set; }
        public int LeaveYear { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? PayableDays { get; set; }
        public decimal? PayableAmount { get; set; }
    }
}
