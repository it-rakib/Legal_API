using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonDivision
    {
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
