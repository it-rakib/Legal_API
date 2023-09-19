using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeeWiseAllowanceMX
    {
        public int AllowanceId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? EffectiveDate { get; set; }
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
