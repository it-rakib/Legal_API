using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class OnBehalfOf
    {
        public OnBehalfOf()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
        }

        public int OnBehalfOfId { get; set; }
        public string OnBehalfOfName { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
    }
}
