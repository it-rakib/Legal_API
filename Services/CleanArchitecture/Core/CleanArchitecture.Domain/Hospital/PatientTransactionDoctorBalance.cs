using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientTransactionDoctorBalance
    {
        public long Id { get; set; }
        public int DoctorId { get; set; }
        public decimal Balance { get; set; }
    }
}
