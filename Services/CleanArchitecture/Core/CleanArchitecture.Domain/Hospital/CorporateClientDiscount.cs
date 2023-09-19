using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CorporateClientDiscount
    {
        public int Id { get; set; }
        public int CorporateClientId { get; set; }
        public int Module { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}
