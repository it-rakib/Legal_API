using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HrHoliday
    {
        public int HrHolidayId { get; set; }
        public DateTime? Holiday { get; set; }
        public string CauseofHoliday { get; set; }
    }
}
