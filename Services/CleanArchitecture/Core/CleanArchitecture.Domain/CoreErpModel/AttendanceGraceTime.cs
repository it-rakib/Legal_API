using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceGraceTime
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool DoorMode { get; set; }
        public int GraceMin { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
