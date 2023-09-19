using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabInventorySub
    {
        public int Id { get; set; }
        public int LabInventoryId { get; set; }
        public int ProductId { get; set; }
        public int Slno { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal? PackSize { get; set; }
        public int? NoOfTest { get; set; }
        public decimal? Rate { get; set; }
        public int? SupplierId { get; set; }
    }
}
