using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class InvestigationReturn
    {
        public int Id { get; set; }
        public long SubId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
