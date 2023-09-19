using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HouskeepReceive
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? TransDate { get; set; }
        public int? IssueDepartment { get; set; }
        public string EnteredBy { get; set; }
    }
}
