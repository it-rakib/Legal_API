using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class VServiceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SubId { get; set; }
        public string ParentCategoryName { get; set; }
        public int? ParentCategoryId { get; set; }
        public decimal? ServiceCharge { get; set; }
        public bool? IsPercentage { get; set; }
    }
}
