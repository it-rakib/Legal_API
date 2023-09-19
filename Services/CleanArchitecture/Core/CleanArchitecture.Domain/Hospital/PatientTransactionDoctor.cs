using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientTransactionDoctor
    {
        public long Id { get; set; }
        public long PatientTransactionId { get; set; }
        public int DoctorId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Payment { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? TransDate { get; set; }
        public string Particulars { get; set; }
    }
}
