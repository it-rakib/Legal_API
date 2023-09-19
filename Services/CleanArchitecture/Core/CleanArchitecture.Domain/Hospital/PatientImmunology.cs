using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientImmunology
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public int HeadImmunologyId { get; set; }
        public string Result { get; set; }
        public string SampleOd { get; set; }
        public string CutOffValue { get; set; }
        public string Opinion { get; set; }
    }
}
