using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class JurisdictionInfo
    {
        public JurisdictionInfo()
        {
            DistrictWiseJurisdictions = new HashSet<DistrictWiseJurisdiction>();
        }

        public int JurisdictionId { get; set; }
        public string JurisdictionName { get; set; }

        public virtual ICollection<DistrictWiseJurisdiction> DistrictWiseJurisdictions { get; set; }
    }
}
