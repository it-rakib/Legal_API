using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineIssueSub
    {
        public int Id { get; set; }
        public int IssueNo { get; set; }
        public int ServiceId { get; set; }
        public int Slno { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? BuyRate { get; set; }
        public decimal? SaleRate { get; set; }
        public string BatchNo { get; set; }
        public string ExpireDate { get; set; }
    }
}
