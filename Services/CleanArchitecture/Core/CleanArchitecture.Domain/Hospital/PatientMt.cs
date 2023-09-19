using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientMt
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public DateTime? DateOfInoculation { get; set; }
        public string ReadingTime { get; set; }
        public string Result { get; set; }
        public string NormalRange { get; set; }
    }
}
