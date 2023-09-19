using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoSubInvestigation
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public int Slno { get; set; }
        public int TestId { get; set; }
        public decimal? Rate { get; set; }
        public int? Quantity { get; set; }
        public DateTime? ReportDeliveryDate { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Drate { get; set; }
        public decimal? Damount { get; set; }
        public int? Discountcategory { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? DisRate { get; set; }
        public decimal? DisAmount { get; set; }
        public string TestStatus { get; set; }
    }
}
