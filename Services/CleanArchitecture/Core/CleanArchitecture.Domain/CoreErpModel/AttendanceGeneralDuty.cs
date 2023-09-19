using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceGeneralDuty
    {
        public long EmpId { get; set; }
        public DateTime WorkDay { get; set; }
        public bool Owo { get; set; }
        public bool Omood { get; set; }
        public bool Cwo { get; set; }
        public bool Cmood { get; set; }
        public bool Two { get; set; }
        public bool Tmood { get; set; }
        public string Remarks { get; set; }
        public DateTime? EntryDate { get; set; }
        public long? EntryUserId { get; set; }
    }
}
