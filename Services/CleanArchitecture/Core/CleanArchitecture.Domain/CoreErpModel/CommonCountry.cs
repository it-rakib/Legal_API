using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonCountry
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryNameBan { get; set; }
        public int? TariffZone { get; set; }
        public bool? IsActive { get; set; }
    }
}
