using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineRequisitionSub
    {
        public long Id { get; set; }
        public long ReqNo { get; set; }
        public int? ServiceId { get; set; }
        public int? Slno { get; set; }
        public decimal? ReqQuantity { get; set; }
        public decimal? DelQuantity { get; set; }
    }
}
