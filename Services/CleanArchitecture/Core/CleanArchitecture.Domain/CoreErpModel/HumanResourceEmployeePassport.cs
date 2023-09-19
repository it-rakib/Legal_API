using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeePassport
    {
        public long EmpId { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PissueDate { get; set; }
        public DateTime? PexpireDate { get; set; }
        public int? PauthorityCountryId { get; set; }
    }
}
