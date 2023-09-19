using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LeaveAvailV1
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public int Year { get; set; }
        public int LeaveTypeId { get; set; }
        public int Day { get; set; }
    }
}
