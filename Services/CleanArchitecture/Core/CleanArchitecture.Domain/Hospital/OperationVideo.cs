using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OperationVideo
    {
        public long Id { get; set; }
        public long OperationId { get; set; }
        public byte[] Video { get; set; }
    }
}
