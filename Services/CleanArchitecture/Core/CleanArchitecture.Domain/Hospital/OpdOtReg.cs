using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OpdOtReg
    {
        public long Id { get; set; }
        public long? RegNo { get; set; }
        public DateTime TransDate { get; set; }
        public decimal? Total { get; set; }
        public decimal? Paid { get; set; }
    }
}
