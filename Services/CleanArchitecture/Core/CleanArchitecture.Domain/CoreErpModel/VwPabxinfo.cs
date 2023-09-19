using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class VwPabxinfo
    {
        public long EmpId { get; set; }
        public string EmpCode { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentShortName { get; set; }
        public int? SectionId { get; set; }
        public string SectionName { get; set; }
        public int? WingId { get; set; }
        public string WingName { get; set; }
        public int? TeamId { get; set; }
        public string TeamName { get; set; }
        public int? DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string EmailOffice { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Pabx { get; set; }
        public string JobLocationName { get; set; }
        public int? JobLocationId { get; set; }
    }
}
