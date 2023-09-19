using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OpdOtRegCollection
    {
        public long Id { get; set; }
        public long? OpdOtRegNo { get; set; }
        public DateTime TransDate { get; set; }
        public string PatientId { get; set; }
        public string RegNo { get; set; }
        public int? ServiceId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Netpayable { get; set; }
        public decimal? Paid { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? Createddate { get; set; }
        public int? DoctorId { get; set; }
        public decimal? Discount { get; set; }
    }
}
