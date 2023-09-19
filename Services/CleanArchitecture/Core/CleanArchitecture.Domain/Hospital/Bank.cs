using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Balance { get; set; }
        public decimal? OBalance { get; set; }
        public int? HeadId { get; set; }
    }
}
