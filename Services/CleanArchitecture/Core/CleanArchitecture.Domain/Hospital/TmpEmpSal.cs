using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TmpEmpSal
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public int? Department { get; set; }
        public int? Designation { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Basic { get; set; }
        public decimal? HouseRent { get; set; }
        public decimal? Medical { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Da { get; set; }
        public decimal? Special { get; set; }
        public decimal? Washing { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
    }
}
