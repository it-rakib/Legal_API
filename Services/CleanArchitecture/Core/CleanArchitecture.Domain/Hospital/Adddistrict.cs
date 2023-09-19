using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Adddistrict
    {
        public int Id { get; set; }
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Url { get; set; }
    }
}
