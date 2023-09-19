using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeHistoryLogTransfer
    {
        public int LogId { get; set; }
        public int EmpId { get; set; }
        public DateTime LogDate { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int? JobLocationId { get; set; }
        public int? TransferId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UserId { get; set; }
    }
}
