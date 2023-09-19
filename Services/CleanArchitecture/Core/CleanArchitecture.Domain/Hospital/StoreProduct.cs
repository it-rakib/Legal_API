using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Category { get; set; }
        public int Supplier { get; set; }
        public int ReOrderLevel { get; set; }
        public decimal Balance { get; set; }
        public decimal BuyRate { get; set; }
        public decimal SaleRate { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string RackNo { get; set; }
    }
}
