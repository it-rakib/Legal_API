using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoSubDinvestigation
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public int Slno { get; set; }
        public int TestId { get; set; }
        public decimal? Rate { get; set; }
        public int? Quantity { get; set; }
        public int? ServiceCategoryId { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Amount { get; set; }
    }
}
