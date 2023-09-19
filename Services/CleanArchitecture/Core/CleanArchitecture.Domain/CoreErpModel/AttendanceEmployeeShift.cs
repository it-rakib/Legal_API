using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceEmployeeShift
    {
        public long EmpId { get; set; }
        public int ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsDelete { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
