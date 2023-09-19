using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaBehaviorFactor
    {
        public int FactorId { get; set; }
        public string FactorDescription { get; set; }
        public bool? IsActive { get; set; }
        public int? SerialNo { get; set; }
        public string SubDescription { get; set; }
    }
}
