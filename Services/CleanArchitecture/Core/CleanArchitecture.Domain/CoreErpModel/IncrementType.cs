using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class IncrementType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
