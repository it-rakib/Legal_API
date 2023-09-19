using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientImmunulogyDetail
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public int TestName { get; set; }
        public string SampleOd { get; set; }
        public string CutOffValue { get; set; }
        public string Opinion { get; set; }
    }
}
