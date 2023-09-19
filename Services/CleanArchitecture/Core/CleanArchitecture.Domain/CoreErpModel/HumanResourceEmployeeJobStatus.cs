using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeeJobStatus
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Position { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TotalDuration { get; set; }
        public string Responsibility { get; set; }
        public string CompanyAddress { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
