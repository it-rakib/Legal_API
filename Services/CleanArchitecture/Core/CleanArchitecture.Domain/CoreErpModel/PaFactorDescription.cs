using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaFactorDescription
    {
        public int FactorDescriptionId { get; set; }
        public int? BehaviorFactorId { get; set; }
        public string Description { get; set; }
        public int? FactorPoint { get; set; }
    }
}
