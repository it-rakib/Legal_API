using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class SupplierStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public decimal Amount { get; set; }
        public DateTime? TransDate { get; set; }
        public string Designation { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
    }
}
