using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DoseTime
    {
        public int Id { get; set; }
        public string DoseTime1 { get; set; }
        public decimal? Interval { get; set; }
        public decimal? Qty { get; set; }
    }
}
