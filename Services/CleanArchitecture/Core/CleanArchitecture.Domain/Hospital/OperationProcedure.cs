using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OperationProcedure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ServiceCategoryId { get; set; }
        public decimal? Rate { get; set; }
    }
}
