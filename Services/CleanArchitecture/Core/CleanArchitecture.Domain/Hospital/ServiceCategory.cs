using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ServiceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SubId { get; set; }
        public int? ModuleId { get; set; }
        public decimal? ServiceCharge { get; set; }
        public bool? IsPercentage { get; set; }
        public int? GroupSubId { get; set; }
        public int? InvestigationSlno { get; set; }
        public int? DiscountCategory { get; set; }
        public decimal? DoctorsPercentage { get; set; }
    }
}
