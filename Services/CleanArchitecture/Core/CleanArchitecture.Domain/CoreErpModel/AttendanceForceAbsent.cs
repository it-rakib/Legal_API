using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceForceAbsent
    {
        public long EmpId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime TillDate { get; set; }
        public bool? IsActive { get; set; }
        public string Remarks { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
