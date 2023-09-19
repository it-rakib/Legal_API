using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaSalaryAdjustment
    {
        public long AppraisalMasterId { get; set; }
        public long EmpId { get; set; }
        public string SalaryAdjustmentType { get; set; }
        public decimal? Amount { get; set; }
    }
}
