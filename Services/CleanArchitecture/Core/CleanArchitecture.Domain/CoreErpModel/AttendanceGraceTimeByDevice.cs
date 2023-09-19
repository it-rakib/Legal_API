using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceGraceTimeByDevice
    {
        public string ControllerId { get; set; }
        public int UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        /// <summary>
        /// 0=In,1=Out
        /// </summary>
        public bool DoorMode { get; set; }
        public int GraceMin { get; set; }
        public DateTime StartDate { get; set; }
        public long Sl { get; set; }
    }
}
