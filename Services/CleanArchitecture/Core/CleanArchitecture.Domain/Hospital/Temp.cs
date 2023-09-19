using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Temp
    {
        public int Id { get; set; }
        public int? MechineId { get; set; }
        public int? Desig { get; set; }
        public DateTime? JoiningDate { get; set; }
        public int? DeptId { get; set; }
    }
}
