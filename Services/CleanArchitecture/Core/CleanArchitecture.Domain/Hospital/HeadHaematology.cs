using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HeadHaematology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string NormalRange { get; set; }
        public int? ServiceId { get; set; }
        public bool? Iscalculate { get; set; }
        public string Alias { get; set; }
        public int? GroupId { get; set; }
    }
}
