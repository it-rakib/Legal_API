using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineReceivingChallanSub
    {
        public long Id { get; set; }
        public long ChallanNo { get; set; }
        public int ServiceId { get; set; }
        public int Slno { get; set; }
        public decimal Total { get; set; }
        public decimal BuyRate { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string BatchNo { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? DiscountRate { get; set; }
        public int? MedicinePurchaseRequisitionId { get; set; }
    }
}
