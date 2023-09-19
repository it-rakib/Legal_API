using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ParticularsHead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Balance { get; set; }
        public decimal? OBalance { get; set; }
        public decimal? Opwdv { get; set; }
        public int? HeadType { get; set; }
        public int? SystemHeadType { get; set; }
        public int? FaDeptId { get; set; }
        public bool? IsActive { get; set; }
        public int? CoyId { get; set; }
        public int? Type { get; set; }
    }
}
