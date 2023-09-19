using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeClearanceD
    {
        public int ClearanceId { get; set; }
        public int ParticularId { get; set; }
        public string Remarks { get; set; }
        public int? ClearStatus { get; set; }
    }
}
