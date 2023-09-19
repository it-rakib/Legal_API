using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TblAddTime
    {
        public int Id { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public string Latetime { get; set; }
    }
}
