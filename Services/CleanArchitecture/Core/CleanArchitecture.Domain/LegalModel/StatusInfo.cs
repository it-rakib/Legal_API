using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class StatusInfo
    {
        public StatusInfo()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
            UpdateDiaries = new HashSet<UpdateDiary>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
        public virtual ICollection<UpdateDiary> UpdateDiaries { get; set; }
    }
}
