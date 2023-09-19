using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AltPatientTransaction
    {
        public long Id { get; set; }
        public long BillNo { get; set; }
        public int Slno { get; set; }
        public int ServiceId { get; set; }
        public decimal ServiceRate { get; set; }
        public decimal Quantity { get; set; }
    }
}
