using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenDebtor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal? Balance { get; set; }
        public bool? IsActive { get; set; }
    }
}
