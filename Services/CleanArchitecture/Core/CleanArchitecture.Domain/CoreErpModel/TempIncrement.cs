using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TempIncrement
    {
        public DateTime? EffectDate { get; set; }
        public string Empcode { get; set; }
        public long? Prevgross { get; set; }
        public long? Increment { get; set; }
        public long? Currentgross { get; set; }
        public bool Done { get; set; }
    }
}
