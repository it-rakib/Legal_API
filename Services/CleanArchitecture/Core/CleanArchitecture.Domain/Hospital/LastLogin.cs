using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LastLogin
    {
        public int Id { get; set; }
        public string Logdate { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
        public string PersonId { get; set; }
    }
}
