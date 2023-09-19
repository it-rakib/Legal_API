using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? BuyRate { get; set; }
        public int? GenericId { get; set; }
        public int? SupplierId { get; set; }
        public int? TypeId { get; set; }
        public bool? IsActive { get; set; }
        public int? ReOrderLevel { get; set; }
        public bool? IsVatApp { get; set; }
        public int? CategoryId { get; set; }
        public int? InvestigationModuleId { get; set; }
        public string MedFor { get; set; }
        public string RackNo { get; set; }
        public decimal? Ipdrate { get; set; }
        public string Unit { get; set; }
        public decimal? DisRate { get; set; }
        public decimal? DisAmount { get; set; }
        public string Specimen { get; set; }
    }
}
