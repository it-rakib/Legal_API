using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientXrayImage
    {
        public int Id { get; set; }
        public long? MemoId { get; set; }
        public long? XrayId { get; set; }
        public byte[] DocImage { get; set; }
    }
}
