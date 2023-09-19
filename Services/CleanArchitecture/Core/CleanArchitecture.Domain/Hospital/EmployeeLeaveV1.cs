using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class EmployeeLeaveV1
    {
        public long Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime LeaveDate { get; set; }
        public int LeaveTypeId { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
