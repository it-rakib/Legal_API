using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class LawyerInfo
    {
        public LawyerInfo()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
        }

        public int LawyerId { get; set; }
        public string LawyerName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string LawyerAddress { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
    }
}
