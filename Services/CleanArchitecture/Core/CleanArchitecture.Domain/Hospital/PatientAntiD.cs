using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientAntiD
    {
        public long Id { get; set; }
        public long? MemoId { get; set; }
        public int? HeadServiceId { get; set; }
        public string Result { get; set; }
        public string Cov { get; set; }
        public string SampleOd { get; set; }
        public int? EnteredBy { get; set; }
        public string Note { get; set; }
    }
}
