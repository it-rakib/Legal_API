using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class CourtInfo
    {
        public CourtInfo()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
            DistrictWiseJurisdictions = new HashSet<DistrictWiseJurisdiction>();
        }

        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CourtNo { get; set; }
        public string CourtAddress { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int? DistrictId { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
        public virtual ICollection<DistrictWiseJurisdiction> DistrictWiseJurisdictions { get; set; }
    }
}
