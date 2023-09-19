using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreProductNew
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public int Category { get; set; }
        public string ManufacturBy { get; set; }
        public string Vendor { get; set; }
        public int Department { get; set; }
        public int Class { get; set; }
        public int? StockType { get; set; }
        public string Description { get; set; }
        public string MatrixDescription { get; set; }
        public decimal WholeSale { get; set; }
        public decimal BuyRate { get; set; }
        public decimal SaleRate { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string RackNo { get; set; }
        public string Note { get; set; }
        public byte[] Image { get; set; }
    }
}
