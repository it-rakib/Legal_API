using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientCovid
    {
        public int PatientCovidId { get; set; }
        public int? MemoId { get; set; }
        public DateTime? DateReport { get; set; }
        public string MethodTest { get; set; }
        public string TestKitUsed { get; set; }
        public string Notes { get; set; }
        public string CovidResult { get; set; }
        public byte[] Qrcode { get; set; }
        public int? Covidcategory { get; set; }
    }
}
