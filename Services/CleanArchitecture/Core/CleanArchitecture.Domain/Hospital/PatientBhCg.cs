using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientBhCg
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string TotalBhCg { get; set; }
    }
}
