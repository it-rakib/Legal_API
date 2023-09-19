using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineIssue
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int DeptId { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
