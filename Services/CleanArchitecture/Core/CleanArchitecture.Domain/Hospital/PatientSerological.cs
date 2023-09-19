using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientSerological
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public int HeadSerologicalId { get; set; }
        public string Result { get; set; }
    }
}
