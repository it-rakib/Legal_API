using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenSale
    {
        public long Id { get; set; }
        public string CustomerName { get; set; }
        public string Contact { get; set; }
        public string CustomerType { get; set; }
        public decimal? Total { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Paid { get; set; }
        public string TokenNo { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public decimal? Vat { get; set; }
        public decimal? NetPayable { get; set; }
    }
}
