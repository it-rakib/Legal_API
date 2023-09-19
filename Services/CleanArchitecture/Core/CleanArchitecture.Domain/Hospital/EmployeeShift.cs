using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class EmployeeShift
    {
        public long Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime AppliedFrom { get; set; }
        public DateTime? AppliedTo { get; set; }
        public int? WorkingShiftId { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public bool? Offday { get; set; }
    }
}
