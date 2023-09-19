using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabImage
    {
        public int Id { get; set; }
        public long? MemoId { get; set; }
        public byte[] LabImage1 { get; set; }
        public string ImageType { get; set; }
    }
}
