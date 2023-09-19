using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EldeductionDate
    {
        public int HolidayId { get; set; }
        public int WeekOffDay { get; set; }
        public DateTime DeductionDate { get; set; }
        public int? Dmonth { get; set; }
        public int? Dyear { get; set; }
        public string Reason { get; set; }
        public int? UnitId { get; set; }
    }
}
