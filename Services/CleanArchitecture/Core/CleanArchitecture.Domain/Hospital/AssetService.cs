using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AssetService
    {
        public int Id { get; set; }
        public string AssetId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int? Category { get; set; }
        public int? Supplier { get; set; }
        public int? DepRate { get; set; }
        public decimal CostAccumulate { get; set; }
        public decimal DepAccumulate { get; set; }
        public decimal? CostPrice { get; set; }
        public byte[] Photo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
    }
}
