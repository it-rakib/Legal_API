using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class Holiday
    {
        public int HolidayId { get; set; }
        public string HolidayYear { get; set; }
        public string HolidayName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? NoOfDays { get; set; }
        public bool? IsDoublePayment { get; set; }
        public bool? IsActive { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
