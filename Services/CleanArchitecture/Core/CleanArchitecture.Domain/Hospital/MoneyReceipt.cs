using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MoneyReceipt
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public string Against { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransDate { get; set; }
        public int EnteredBy { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? Bkashamount { get; set; }
        public decimal? Chequeamount { get; set; }
        public decimal? Cashamount { get; set; }
        public string Chequeno { get; set; }
        public string Note { get; set; }
        public string Cardname { get; set; }
    }
}
