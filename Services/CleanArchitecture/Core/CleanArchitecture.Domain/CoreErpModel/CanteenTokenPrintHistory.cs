using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CanteenTokenPrintHistory
    {
        public long EmpId { get; set; }
        public string TokenNo { get; set; }
        public DateTime TokenPrintDate { get; set; }
        public string DeviceNo { get; set; }
        public bool? IsCancel { get; set; }
        public bool? IsActive { get; set; }
        public bool IsPrint { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
