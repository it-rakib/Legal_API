using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class BedCabinTransection
    {
        public long Id { get; set; }
        public int BedCabinId { get; set; }
        public string RegNo { get; set; }
        public string PatientId { get; set; }
        public decimal? Rate { get; set; }
        public long? PatientTransactionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
