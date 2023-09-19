using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ParticularsSubHead
    {
        public int Id { get; set; }
        public string SubHead { get; set; }
        public int? ParticularsHeadId { get; set; }
    }
}
