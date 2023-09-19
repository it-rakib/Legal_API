using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class CmnDocument
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string ModuleName { get; set; }
        public int? ModuleMasterId { get; set; }
        public int? FileSize { get; set; }
        public string FileExtension { get; set; }
        public string FileUniqueName { get; set; }
    }
}
