using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceOfficialInOut
    {
        public long Ioid { get; set; }
        public long EmpId { get; set; }
        public int TypeId { get; set; }
        public DateTime? InOutDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Duration { get; set; }
        public string Reason { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int Status { get; set; }
        public string FilePath { get; set; }
        public bool IsAcknowledged { get; set; }
        public long? AcknowledgedBy { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public bool? IsManual { get; set; }
        public bool? IsDeleted { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DeleteReason { get; set; }
        public bool? IsOutOfPolicy { get; set; }
        public string TerminalId { get; set; }
        public string UserId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
