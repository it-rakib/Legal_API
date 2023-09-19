using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OperationImage
    {
        public long Id { get; set; }
        public long OperationId { get; set; }
        public byte[] Photo { get; set; }
        public string Remarks { get; set; }
    }
}
