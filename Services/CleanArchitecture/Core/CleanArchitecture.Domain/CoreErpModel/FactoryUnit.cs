using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class FactoryUnit
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int? CompanyId { get; set; }
    }
}
