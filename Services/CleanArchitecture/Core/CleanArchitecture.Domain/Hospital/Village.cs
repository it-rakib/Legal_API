using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Village
    {
        public int Villid { get; set; }
        public string Villname { get; set; }
        public int? Upzillaid { get; set; }
        public int? UnionId { get; set; }
    }
}
