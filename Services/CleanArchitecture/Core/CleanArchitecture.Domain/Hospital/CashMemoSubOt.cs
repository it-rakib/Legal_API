using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoSubOt
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public int Slno { get; set; }
        public int ServiceId { get; set; }
        public decimal Rate { get; set; }
        public int Quantity { get; set; }
        public int? DoctorId { get; set; }
    }
}
