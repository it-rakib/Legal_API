using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Addunion
    {
        public int Id { get; set; }
        public int UpazillaId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
