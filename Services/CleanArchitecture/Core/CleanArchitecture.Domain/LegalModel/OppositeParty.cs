using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class OppositeParty
    {
        public OppositeParty()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
        }

        public int PartyId { get; set; }
        public string PartyName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string PartyAddress { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
    }
}
