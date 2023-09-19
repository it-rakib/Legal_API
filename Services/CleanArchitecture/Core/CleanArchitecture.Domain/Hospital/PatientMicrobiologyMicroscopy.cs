using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientMicrobiologyMicroscopy
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string GramsStain { get; set; }
        public string Albart { get; set; }
        public string Afb { get; set; }
        public string Other { get; set; }
        public string Remarks { get; set; }
    }
}
