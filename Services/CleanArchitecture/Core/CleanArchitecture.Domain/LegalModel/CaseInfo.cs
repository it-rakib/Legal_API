using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class CaseInfo
    {
        public CaseInfo()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
        }

        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public string CaseNo { get; set; }
        public DateTime? CaseDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
    }
}
