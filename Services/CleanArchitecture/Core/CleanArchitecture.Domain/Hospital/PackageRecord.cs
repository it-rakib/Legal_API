using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PackageRecord
    {
        public string RegNo { get; set; }
        public string PatientType { get; set; }
        public DateTime TransDate { get; set; }
    }
}
