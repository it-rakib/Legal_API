using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class District
    {
        public int Id { get; set; }
        public string District1 { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? DivisionId { get; set; }
    }
}
