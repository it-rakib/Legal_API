using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeBasicSalaryDetail
    {
        public long EmpId { get; set; }
        public DateTime EffectDate { get; set; }
        public int SalaryHeadId { get; set; }
        public decimal? Amount { get; set; }
    }
}
