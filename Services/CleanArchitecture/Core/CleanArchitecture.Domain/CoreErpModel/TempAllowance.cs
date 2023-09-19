using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TempAllowance
    {
        public string EmpCode { get; set; }
        public int CostHeadId { get; set; }
        public decimal? AllowanceAmt { get; set; }
        public DateTime EffectDate { get; set; }
        public bool? IsProcessed { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
