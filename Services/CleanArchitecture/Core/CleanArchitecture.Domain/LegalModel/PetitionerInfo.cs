using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class PetitionerInfo
    {
        public PetitionerInfo()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
        }

        public int PetitionerId { get; set; }
        public string PetitionerName { get; set; }
        public string Email { get; set; }
        public string PetitionerAddress { get; set; }
        public string ContactNo { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
    }
}
