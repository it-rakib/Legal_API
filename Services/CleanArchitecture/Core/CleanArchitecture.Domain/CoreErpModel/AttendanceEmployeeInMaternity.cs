using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceEmployeeInMaternity
    {
        public long? EmpId { get; set; }
        public DateTime? FromDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
