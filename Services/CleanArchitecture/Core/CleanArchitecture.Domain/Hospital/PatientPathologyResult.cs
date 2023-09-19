using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientPathologyResult
    {
        public long Id { get; set; }
        public long? MemoId { get; set; }
        public int? PathologyHeadId { get; set; }
        public string Result { get; set; }
        public string HeadName { get; set; }
        public int ModuleId { get; set; }
    }
}
