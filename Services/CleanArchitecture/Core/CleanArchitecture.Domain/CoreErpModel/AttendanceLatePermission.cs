using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceLatePermission
    {
        public long EmpId { get; set; }
        public DateTime WorkDay { get; set; }
        public string Remarks { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
