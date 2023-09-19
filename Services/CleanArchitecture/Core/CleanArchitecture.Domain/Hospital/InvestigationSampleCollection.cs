using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class InvestigationSampleCollection
    {
        public int Id { get; set; }
        public long CashMemoSubInvestigationId { get; set; }
        public bool SampleCollected { get; set; }
        public DateTime? SampleCollectionDate { get; set; }
        public int? SampleCollectedBy { get; set; }
        public bool? IsUrgent { get; set; }
        public string Remarks { get; set; }
        public DateTime TransDate { get; set; }
        public int? TestId { get; set; }
        public bool? IsReportDone { get; set; }
        public bool? IsReportDelivery { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryUser { get; set; }
        public byte[] BarCodeImage { get; set; }
        public bool? IsPrint { get; set; }
    }
}
