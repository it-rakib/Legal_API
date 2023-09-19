using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonInOut
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string ShortName { get; set; }
        public bool IsActive { get; set; }
    }
}
