using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceRamadanUnitWiseShift
    {
        public int UnitId { get; set; }
        public int ShiftId { get; set; }
        public int RamadanShiftId { get; set; }
        public DateTime FromDate { get; set; }
        public long Sl { get; set; }
        public int? Iobreak { get; set; }
        public int? Lhbreak { get; set; }
        public int? Ifbreak { get; set; }
        public int? Ntbreak { get; set; }
        public int? Shbreak { get; set; }
        public int? JobLocationId { get; set; }
    }
}
