using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientTuberculin
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string Detail { get; set; }
        public DateTime? ReadingDate { get; set; }
        public string Result { get; set; }
        public string Opinion { get; set; }
        public string Note { get; set; }
    }
}
