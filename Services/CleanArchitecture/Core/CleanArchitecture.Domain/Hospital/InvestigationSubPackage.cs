using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class InvestigationSubPackage
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int ServiceId { get; set; }
    }
}
