using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class GenericGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
