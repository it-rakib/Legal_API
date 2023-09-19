using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeeTraining
    {
        public int Id { get; set; }
        public long EmpId { get; set; }
        public string CourseName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Duration { get; set; }
        public string Result { get; set; }
        public string Institute { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
