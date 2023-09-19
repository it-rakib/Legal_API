using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class BedCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Rate { get; set; }
        public string Specification { get; set; }
        public int? IpdDeptId { get; set; }
        public decimal? AdmissionFee { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? Food { get; set; }
        public int? BedCabinCategoryNameId { get; set; }
    }
}
