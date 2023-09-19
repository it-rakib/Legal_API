using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Card
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Name { get; set; }
        public decimal? Charge { get; set; }
        public bool? IsActive { get; set; }
    }
}
