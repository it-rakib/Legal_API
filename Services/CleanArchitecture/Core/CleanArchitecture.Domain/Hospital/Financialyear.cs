using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Financialyear
    {
        public int FnYearId { get; set; }
        public DateTime? FnStartdate { get; set; }
        public DateTime? FnEnddate { get; set; }
        public string Financialyear1 { get; set; }
        public bool? Isactive { get; set; }
    }
}
