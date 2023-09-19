using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabInventoryBalance
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Balance { get; set; }
        public decimal? NoOfTestBalance { get; set; }
    }
}
