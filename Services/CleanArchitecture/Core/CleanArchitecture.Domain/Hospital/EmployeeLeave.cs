using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class EmployeeLeave
    {
        public long Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime LeaveDate { get; set; }
        public string LeaveType { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
