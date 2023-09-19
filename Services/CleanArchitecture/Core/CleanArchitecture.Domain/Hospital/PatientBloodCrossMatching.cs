using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientBloodCrossMatching
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string PatientBloodGroup { get; set; }
        public string PatientRhFactor { get; set; }
        public string DonorName { get; set; }
        public string DonorAge { get; set; }
        public string DonorSex { get; set; }
        public string DonorBloodGroup { get; set; }
        public string DonorRhFactor { get; set; }
    }
}
