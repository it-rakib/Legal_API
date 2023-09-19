using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Tmptrial
    {
        public int? Id { get; set; }
        public string MasterHead { get; set; }
        public string SubHead { get; set; }
        public int? NoteSlno { get; set; }
        public int? Slno { get; set; }
        public int? BsHeadId { get; set; }
        public string BsHeadName { get; set; }
        public decimal? DebitTotal { get; set; }
        public decimal? CreditTotal { get; set; }
        public decimal? BalanceTotal { get; set; }
    }
}
