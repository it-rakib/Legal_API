using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonThana
    {
        public int ThanaId { get; set; }
        public int DistrictId { get; set; }
        public string ThanaName { get; set; }
        public string ThanaNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
