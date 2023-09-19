using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TempService
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Rate { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? DisAmount { get; set; }
        public string TestId { get; set; }
    }
}
