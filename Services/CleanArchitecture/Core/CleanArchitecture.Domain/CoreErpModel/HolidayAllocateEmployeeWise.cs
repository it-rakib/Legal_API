using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HolidayAllocateEmployeeWise
    {
        public int HolidayId { get; set; }
        public int EmpId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
    }
}
