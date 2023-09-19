using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceLeaveRegister
    {
        public long Lrid { get; set; }
        public long Lrpid { get; set; }
        public long EmpId { get; set; }
        public int LeaveId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? NoOfDays { get; set; }
        public int? HalfDayPeriod { get; set; }
        public string Reason { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int Status { get; set; }
        public byte[] Attachment { get; set; }
        public string FilePath { get; set; }
        public bool IsOutOfPolicy { get; set; }
        public bool IsAcknowledged { get; set; }
        public long? AcknowledgedBy { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public bool? IsManual { get; set; }
        public bool? IsDeleted { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DeleteReason { get; set; }
        public string TerminalId { get; set; }
        public string UserId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
