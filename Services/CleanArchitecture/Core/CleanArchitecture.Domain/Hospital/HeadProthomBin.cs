using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HeadProthomBin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string NormalRange { get; set; }
        public int? ServiceId { get; set; }
        public int? GroupId { get; set; }
        public int? Slno { get; set; }
    }
}
