using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HrDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SpecialCategory { get; set; }
    }
}
