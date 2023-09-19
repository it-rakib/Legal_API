using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientMicrobiology
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public int HeadMicrobiologyId { get; set; }
        public string ResultA { get; set; }
        public string ResultB { get; set; }
        public string ResultC { get; set; }
        public int? TestId { get; set; }
        public string OrganismIsolated { get; set; }
        public string OrganismIsolatedB { get; set; }
        public string ColonyCount { get; set; }
        public string ColonyCountB { get; set; }
        public string UrineCulture1 { get; set; }
    }
}
