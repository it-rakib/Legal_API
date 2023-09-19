using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineReceivingChallan
    {
        public long Id { get; set; }
        public int Supplier { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool IsPosted { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public int? StoreId { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string TransType { get; set; }
        public bool? IsPaid { get; set; }
    }
}
