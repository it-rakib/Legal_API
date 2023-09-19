using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientSemenAnalysisV1
    {
        public long Id { get; set; }
        public long? MemoId { get; set; }
        public int? HeadSemenAlalysisId { get; set; }
        public string Result { get; set; }
        public string HeadName { get; set; }
    }
}
