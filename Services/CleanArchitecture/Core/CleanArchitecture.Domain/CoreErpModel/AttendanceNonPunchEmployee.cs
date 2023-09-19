using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceNonPunchEmployee
    {
        public long EmpId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
