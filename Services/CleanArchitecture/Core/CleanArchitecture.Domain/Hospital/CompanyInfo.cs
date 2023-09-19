using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CompanyInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Others { get; set; }
        public byte[] Logo { get; set; }
        public string Remarks { get; set; }
    }
}
