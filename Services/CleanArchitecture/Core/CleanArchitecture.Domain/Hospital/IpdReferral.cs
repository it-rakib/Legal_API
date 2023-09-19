using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class IpdReferral
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransDate { get; set; }
    }
}
