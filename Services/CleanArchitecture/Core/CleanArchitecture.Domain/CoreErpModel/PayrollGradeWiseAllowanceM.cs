using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollGradeWiseAllowanceM
    {
        public int AllowanceId { get; set; }
        public int? GradeId { get; set; }
        public int? EmpTypeId { get; set; }
        public int? EmpCategoryId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
