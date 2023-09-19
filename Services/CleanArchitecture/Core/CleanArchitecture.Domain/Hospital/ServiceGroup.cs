using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ServiceGroup
    {
        public int Id { get; set; }
        public int ParentServiceId { get; set; }
        public int Slno { get; set; }
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
    }
}
