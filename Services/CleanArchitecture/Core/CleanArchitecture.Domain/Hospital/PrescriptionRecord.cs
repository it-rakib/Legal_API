using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PrescriptionRecord
    {
        public int DocId { get; set; }
        public long? PrescriptionId { get; set; }
        public byte[] DocImage { get; set; }
        public string PatientId { get; set; }
    }
}
