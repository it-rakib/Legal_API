using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabCheckedBy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Others { get; set; }
        public bool? Status { get; set; }
        public int? Module { get; set; }
    }
}
