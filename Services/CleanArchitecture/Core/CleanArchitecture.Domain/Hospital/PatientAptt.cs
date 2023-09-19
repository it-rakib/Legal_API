using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientAptt
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string Control { get; set; }
        public string Patients { get; set; }
    }
}
