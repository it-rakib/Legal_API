using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class FactoryDesignation
    {
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public int UnitId { get; set; }
        public int CompanyId { get; set; }
    }
}
