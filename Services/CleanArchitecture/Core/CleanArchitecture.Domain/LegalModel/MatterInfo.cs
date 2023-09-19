using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class MatterInfo
    {
        public MatterInfo()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
        }

        public int MatterId { get; set; }
        public string MatterName { get; set; }
        public string Discription { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
    }
}
