using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TreatmentSheetMedicineUsed
    {
        public long Id { get; set; }
        public long IndentNo { get; set; }
        public int? ServiceId { get; set; }
        public int? Slno { get; set; }
        public decimal? Quantity { get; set; }
        public string Dose { get; set; }
        public string Used { get; set; }
        public string UsedBy { get; set; }
        public DateTime? UsedDt { get; set; }
        public string CheckedBy { get; set; }
        public DateTime? CheckedDate { get; set; }
    }
}
