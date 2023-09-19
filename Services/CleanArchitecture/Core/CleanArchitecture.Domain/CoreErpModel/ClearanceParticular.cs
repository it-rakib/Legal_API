using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ClearanceParticular
    {
        public int ParticularId { get; set; }
        public string ParticularName { get; set; }
        public string ClearingAuthority { get; set; }
        public bool? IsActive { get; set; }
    }
}
