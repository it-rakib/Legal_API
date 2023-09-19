using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class FileType
    {
        public FileType()
        {
            CaseFileMasters = new HashSet<CaseFileMaster>();
        }

        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string FileTypeNo { get; set; }

        public virtual ICollection<CaseFileMaster> CaseFileMasters { get; set; }
    }
}
