using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeeNominee
    {
        public long NomineeId { get; set; }
        public long EmpId { get; set; }
        public string NomineeName { get; set; }
        public int? RelationshipId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nid { get; set; }
        public string BirthRegNo { get; set; }
        public string PhotoPath { get; set; }
        public bool? IsActive { get; set; }
        public bool IsNominee { get; set; }
    }
}
