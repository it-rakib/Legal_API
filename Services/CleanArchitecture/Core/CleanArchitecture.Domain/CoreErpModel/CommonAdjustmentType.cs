using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonAdjustmentType
    {
        public int AdjustmentTypeId { get; set; }
        public string AdjustmentTypeName { get; set; }
        public decimal? Flag { get; set; }
        public int? IsActive { get; set; }
    }
}
