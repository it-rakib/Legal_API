using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceEmployeeTour
    {
        public long Sdid { get; set; }
        public long EmpId { get; set; }
        public int TourId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? NoOfDays { get; set; }
        public string Reason { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int Status { get; set; }
        public string FilePath { get; set; }
        public bool? IsDeleted { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsAcknowledged { get; set; }
        public long? AcknowledgedBy { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public bool? IsManual { get; set; }
        public bool? IsOutOfPolicy { get; set; }
        public string TerminalId { get; set; }
        public string UserId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
