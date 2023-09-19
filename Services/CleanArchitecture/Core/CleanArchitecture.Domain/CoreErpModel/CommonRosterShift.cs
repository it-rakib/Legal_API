using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonRosterShift
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public string ShiftShort { get; set; }
        public DateTime? ShiftIn { get; set; }
        public DateTime? ShiftLate { get; set; }
        public DateTime? ShiftAbsent { get; set; }
        public DateTime? ShiftEarly { get; set; }
        public DateTime? ShiftOut { get; set; }
        public DateTime? ShiftLastPunch { get; set; }
        public DateTime? ShiftLunchFrom { get; set; }
        public DateTime? ShiftLunchTill { get; set; }
        public bool IsLunchPaid { get; set; }
        public DateTime? ShiftIfterFrom { get; set; }
        public DateTime? ShiftIfterTill { get; set; }
        public bool IsIfterPaid { get; set; }
        public DateTime? NightBreakFrom { get; set; }
        public DateTime? NightBreakTill { get; set; }
        public bool IsNightPaid { get; set; }
        public DateTime? SheriBreakFrom { get; set; }
        public DateTime? SheriBreakTill { get; set; }
        public bool IsSheriPaid { get; set; }
        public bool? IsLunch { get; set; }
        public bool? IsTiffin { get; set; }
        public DateTime? TiffinTime { get; set; }
        public bool? IsIfter { get; set; }
        public DateTime? IfterTime { get; set; }
        public bool? IsNight { get; set; }
        public DateTime? NightTime { get; set; }
        public int? ShiftType { get; set; }
        public int? ParentShiftId { get; set; }
        public int? RamadanShiftId { get; set; }
        public int? ChangeOverShiftId { get; set; }
        public bool IsRamadanShift { get; set; }
        public bool Exl { get; set; }
        public bool Nop { get; set; }
        public bool Ee { get; set; }
        public DateTime? Workday { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
    }
}
