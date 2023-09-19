using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonDistrict
    {
        public int DistrictId { get; set; }
        public int DivisionId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
