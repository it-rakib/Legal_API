using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PurchaseRequestDetail
    {
        public int StoreRequestDetailId { get; set; }
        public int? StoreRequestId { get; set; }
        public int? ProductId { get; set; }
        public int? Slno { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? IssuedQty { get; set; }
        public decimal? Balance { get; set; }
    }
}
