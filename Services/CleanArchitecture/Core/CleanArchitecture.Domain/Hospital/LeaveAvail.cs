using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LeaveAvail
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public int Year { get; set; }
        public decimal El { get; set; }
        public decimal Cl { get; set; }
        public decimal Ml { get; set; }
        public decimal Fl { get; set; }
        public decimal MatL { get; set; }
    }
}
