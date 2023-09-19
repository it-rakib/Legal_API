using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PrintHistory
    {
        public int Id { get; set; }
        public int PrintedBy { get; set; }
        public DateTime PrintDate { get; set; }
    }
}
