using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? TransDate { get; set; }
        public string Typ { get; set; }
    }
}
