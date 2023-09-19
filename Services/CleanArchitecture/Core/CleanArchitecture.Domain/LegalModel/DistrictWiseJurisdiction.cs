using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class DistrictWiseJurisdiction
    {
        public int? CourtId { get; set; }
        public int? DistrictId { get; set; }
        public int? JurisdictionId { get; set; }
        public int DistrictWiseJurisdictionId { get; set; }

        public virtual CourtInfo Court { get; set; }
        public virtual JurisdictionInfo Jurisdiction { get; set; }
    }
}
