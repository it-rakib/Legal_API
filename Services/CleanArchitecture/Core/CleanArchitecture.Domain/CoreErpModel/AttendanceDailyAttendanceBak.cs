using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceDailyAttendanceBak
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int DesignationId { get; set; }
        public int? PositionId { get; set; }
        public DateTime WorkDay { get; set; }
        public int ShiftId { get; set; }
        public DateTime? InTime { get; set; }
        public string InDeviceId { get; set; }
        public int LateInMinute { get; set; }
        public DateTime? LunchOutTime { get; set; }
        public DateTime? OutTime { get; set; }
        public string OutDeviceId { get; set; }
        public int EarlyExitMinute { get; set; }
        public DateTime? LunchInTime { get; set; }
        public string AttStatus { get; set; }
        public int WorkDuration { get; set; }
        public decimal OtHours { get; set; }
        public bool IsTiffin { get; set; }
        public bool IsIftar { get; set; }
        public bool IsNight { get; set; }
        public bool IsHoliday { get; set; }
        public bool IsWeekOff { get; set; }
        public bool IsLunch { get; set; }
        public string InRemarks { get; set; }
        public string OutRemarks { get; set; }
    }
}
