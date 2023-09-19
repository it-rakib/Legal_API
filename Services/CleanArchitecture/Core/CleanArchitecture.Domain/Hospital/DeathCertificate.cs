using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DeathCertificate
    {
        public int DeathCertificateId { get; set; }
        public string PatientId { get; set; }
        public string RegNo { get; set; }
        public DateTime? DeathTime { get; set; }
        public string UnderlyingCod { get; set; }
        public string ContributoryCod { get; set; }
        public string ImmediateCod { get; set; }
        public string LegalCategorization { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? Created { get; set; }
        public string DeathSummary { get; set; }
        public string ConsultantId { get; set; }
    }
}
