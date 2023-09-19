using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class SystemSubHead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CoyId { get; set; }
        public int? SystemHeadId { get; set; }
        public int? NoteSlno { get; set; }
        public int? Slno { get; set; }
    }
}
