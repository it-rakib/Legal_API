using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollGradeWiseAllowanceD
    {
        public int AllowanceId { get; set; }
        public int CostHeadId { get; set; }
        public decimal? AllowanceRate { get; set; }
    }
}
