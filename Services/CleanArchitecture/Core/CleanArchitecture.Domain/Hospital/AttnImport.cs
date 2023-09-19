using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AttnImport
    {
        public int Id { get; set; }
        public DateTime AttnDate { get; set; }
        public DateTime TransDate { get; set; }
        public int EnteredBy { get; set; }
    }
}
