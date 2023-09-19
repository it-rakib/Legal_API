using System;

namespace CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands
{
    public class DocumentVM
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string ModuleName { get; set; }
        public int ModuleMasterId { get; set; }
        public int? FileSize { get; set; }
        public string FileExtension { get; set; }
        public string FileUniqueName { get; set; }
        public string ActionType { get; set; }
    }
    public class FilesVm
    {
        public int docId { get; set; }
        public string name { get; set; }
        public int size { get; set; }
        public string extension { get; set; }
        public string fileUniq { get; set; }
    }
}
