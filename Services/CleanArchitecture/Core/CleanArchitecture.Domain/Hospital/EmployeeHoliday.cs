using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class EmployeeHoliday
    {
        public long Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string HolidayType { get; set; }
    }
}
