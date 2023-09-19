using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HeadHaematologySub
    {
        public int Id { get; set; }
        public int? HeadId { get; set; }
        public string Name { get; set; }
    }
}
