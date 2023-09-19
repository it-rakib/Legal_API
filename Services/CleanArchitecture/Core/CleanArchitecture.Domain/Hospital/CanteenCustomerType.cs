using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenCustomerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? ServiceCharge { get; set; }
    }
}
