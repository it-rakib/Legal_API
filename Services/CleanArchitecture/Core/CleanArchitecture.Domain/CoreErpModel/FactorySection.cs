using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class FactorySection
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int UnitId { get; set; }
        public int CompanyId { get; set; }
    }
}
