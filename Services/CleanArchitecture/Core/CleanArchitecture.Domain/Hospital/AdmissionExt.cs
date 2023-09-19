using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AdmissionExt
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? Food { get; set; }
    }
}
