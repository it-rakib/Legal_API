using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeWiseAllowance
    {
        public long AllowanceId { get; set; }
        public int EmpId { get; set; }
        public int CostHeadId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal? AllowanceRate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? IsDeleted { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
