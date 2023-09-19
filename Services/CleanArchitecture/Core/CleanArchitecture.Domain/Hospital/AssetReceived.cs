using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AssetReceived
    {
        public long Id { get; set; }
        public int? AssetId { get; set; }
        public int? Quantity { get; set; }
        public decimal? CostPrice { get; set; }
        public int? Supplier { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool? IsPosted { get; set; }
        public decimal? Total { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? DiscountRate { get; set; }
        public int? GrnNo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
        public string Remarks { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public string Pono { get; set; }
        public DateTime? Podate { get; set; }
        public string LotNo { get; set; }
    }
}
