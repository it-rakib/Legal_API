using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineAdjustChallan
    {
        public long Id { get; set; }
        public string RefNo { get; set; }
        public DateTime RefDate { get; set; }
        public decimal Total { get; set; }
        public int? StoreId { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string ReceAdjust { get; set; }
    }
}
