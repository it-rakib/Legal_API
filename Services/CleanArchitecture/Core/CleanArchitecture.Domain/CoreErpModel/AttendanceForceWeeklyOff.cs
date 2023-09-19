using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceForceWeeklyOff
    {
        public long EmpId { get; set; }
        public DateTime CurrentHoliday { get; set; }
        public DateTime AlterHoliday { get; set; }
        public bool IsWo { get; set; }
        public bool? Omood { get; set; }
        public bool Cmood { get; set; }
        public bool Tmood { get; set; }
        public bool? IsActive { get; set; }
        public string Remarks { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public long Sl { get; set; }
    }
}
