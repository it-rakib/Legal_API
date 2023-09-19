using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TreatmentSheetMedicineSub
    {
        public long Id { get; set; }
        public long IndentNo { get; set; }
        public int? MedicineTypeId { get; set; }
        public int? ServiceId { get; set; }
        public int? Slno { get; set; }
        public int? DoseTimeId { get; set; }
        public int? DoseStartTimeId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Delivered { get; set; }
        public string DeliveryBy { get; set; }
        public DateTime? DeliveryDt { get; set; }
    }
}
