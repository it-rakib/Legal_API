using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicinePurchaseRequisition
    {
        public int Id { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public int? SupplierId { get; set; }
    }
}
