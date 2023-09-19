using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AltPatientTransactionDoctor
    {
        public long Id { get; set; }
        public long AltPatientTransactionId { get; set; }
        public int DoctorId { get; set; }
        public DateTime TransDate { get; set; }
    }
}
