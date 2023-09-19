using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabConsultTran
    {
        public long Id { get; set; }
        public long? MemoId { get; set; }
        public int? ConsultentId { get; set; }
        public int? CheckedBy { get; set; }
        public int? ModuleFlag { get; set; }
        public string Specimen { get; set; }
        public DateTime? TransDate { get; set; }
        public int? EnteredBy { get; set; }
        public string Comments { get; set; }
        public string TestMethod { get; set; }
        public string CommentsHead { get; set; }

        public virtual LabConsultent Consultent { get; set; }
    }
}
