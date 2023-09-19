using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientMicrobiologyDetail
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string OrganismIsolated { get; set; }
        public string OrganismIsolatedB { get; set; }
        public string ColonyCount { get; set; }
        public string ColonyCountB { get; set; }
        public string UrineCulture1 { get; set; }
        public string UrineCulture2 { get; set; }
        public bool IsGrowth { get; set; }
        public string Remarks { get; set; }
        public int? TestId { get; set; }
        public string Specimen { get; set; }
        public string TestMethod { get; set; }
    }
}
