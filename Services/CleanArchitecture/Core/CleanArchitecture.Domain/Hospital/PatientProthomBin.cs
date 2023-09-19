using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientProthomBin
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string Pt { get; set; }
        public string Control { get; set; }
        public string Ratio { get; set; }
        public string PIndex { get; set; }
        public string Inr { get; set; }
    }
}
