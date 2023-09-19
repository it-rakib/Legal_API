using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class BedCabin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public bool IsAllocated { get; set; }
    }
}
