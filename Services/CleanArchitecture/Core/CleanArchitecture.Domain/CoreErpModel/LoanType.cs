using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class LoanType
    {
        public int LoanTypeId { get; set; }
        public string TypeName { get; set; }
        public decimal? MaxAmount { get; set; }
        public int? Percent { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
