using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceEmployeeRosterDetail
    {
        public int RosterId { get; set; }
        public int EmpId { get; set; }
        public DateTime? WorkDay { get; set; }
        public int? ShiftId { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string TerminalId { get; set; }
    }
}
