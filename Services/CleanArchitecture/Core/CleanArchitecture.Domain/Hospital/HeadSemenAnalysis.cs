using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HeadSemenAnalysis
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string DefaultResult { get; set; }
        public string NormalRange { get; set; }
        public int? GroupHeadId { get; set; }
        public string GroupSubHeadName { get; set; }
        public int? ServiceId { get; set; }
    }
}
