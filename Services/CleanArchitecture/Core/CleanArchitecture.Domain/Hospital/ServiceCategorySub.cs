using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ServiceCategorySub
    {
        public int Id { get; set; }
        public int ServiceCategoryId { get; set; }
        public int SubCategoryId { get; set; }
    }
}
