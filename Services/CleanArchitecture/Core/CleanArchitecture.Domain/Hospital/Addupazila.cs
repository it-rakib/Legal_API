using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Addupazila
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
