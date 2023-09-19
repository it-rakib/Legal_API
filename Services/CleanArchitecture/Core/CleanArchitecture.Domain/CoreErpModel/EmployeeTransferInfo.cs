using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeTransferInfo
    {
        public int TransferId { get; set; }
        public DateTime? EffectDate { get; set; }
        public int? EmpId { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int? JobLocationId { get; set; }
        public string Note { get; set; }
        public DateTime? EntryDate { get; set; }
        public string UserId { get; set; }
        public string TerminalId { get; set; }
        public bool? IsLocked { get; set; }
    }
}
