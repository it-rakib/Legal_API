using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicinePurchaseRequisitionSupplier
    {
        public int Id { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public int? SupplierId { get; set; }
        public int? SalesConsiderDays { get; set; }
        public int? SaleConsiderQuantity { get; set; }
        public int? AvgSalesConsiderDays { get; set; }
        public int? AvgSaleConsiderQuantity { get; set; }
        public int? StockConsiderDays { get; set; }
        public int? StockConsiderQuantity { get; set; }
        public string RequsitionBy { get; set; }
        public string DeliveredBy { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
