using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OpeningBalance
    {
        public int Id { get; set; }
        public decimal? CashOpening { get; set; }
        public decimal? BankOpening { get; set; }
        public DateTime? OpeningDate { get; set; }
    }
}
