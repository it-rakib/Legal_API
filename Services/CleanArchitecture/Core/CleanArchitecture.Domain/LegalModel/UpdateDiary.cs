using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class UpdateDiary
    {
        public int DiaryId { get; set; }
        public int? FileMasterId { get; set; }
        public DateTime? PreviousDate { get; set; }
        public string PreviousDateFor { get; set; }
        public DateTime? NextDate { get; set; }
        public string NextDateFor { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? StatusDate { get; set; }

        public virtual CaseFileMaster FileMaster { get; set; }
        public virtual StatusInfo Status { get; set; }
    }
}
