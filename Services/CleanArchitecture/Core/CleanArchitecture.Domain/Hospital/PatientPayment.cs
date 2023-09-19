using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientPayment
    {
        public long Id { get; set; }
        public long MrId { get; set; }
        public string RegNo { get; set; }
        public decimal Amount { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public bool IsHospitalPayment { get; set; }
    }
}
