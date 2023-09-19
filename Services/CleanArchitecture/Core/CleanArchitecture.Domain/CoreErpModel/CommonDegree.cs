using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonDegree
    {
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public bool? IsActive { get; set; }
        public string DegreeFullName { get; set; }
        public int? SortOrder { get; set; }
    }
}
