using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollCostHead
    {
        public int CostHeadId { get; set; }
        public string CostHeadName { get; set; }
        public bool? IsActive { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
