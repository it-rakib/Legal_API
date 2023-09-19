using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CovidreportCategory
    {
        public int Id { get; set; }
        public string Report { get; set; }
        public string Notes { get; set; }
    }
}
