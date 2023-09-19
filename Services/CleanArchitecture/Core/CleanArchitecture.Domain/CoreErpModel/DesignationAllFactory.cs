using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class DesignationAllFactory
    {
        public int? DesignationId { get; set; }
        public string DesignationName { get; set; }
        public int? SortOrder { get; set; }
        public string DesigGroup { get; set; }
        public int? DesigType { get; set; }
    }
}
