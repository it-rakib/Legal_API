using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeeDrivingLicense
    {
        public long EmpId { get; set; }
        public string DrivingLicense { get; set; }
        public DateTime? DissueDate { get; set; }
        public DateTime? DexpireDate { get; set; }
        public int? DauthorityCountryId { get; set; }
    }
}
