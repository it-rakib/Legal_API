using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TempElpay
    {
        public string Empcode { get; set; }
        public decimal? DeductDay { get; set; }
        public int? LateDay { get; set; }
        public int? Elyear { get; set; }
        public DateTime? ActionDate { get; set; }
        public bool? DataProcessed { get; set; }
    }
}
