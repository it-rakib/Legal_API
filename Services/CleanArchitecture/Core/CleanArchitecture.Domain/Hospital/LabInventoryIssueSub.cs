using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabInventoryIssueSub
    {
        public int Id { get; set; }
        public int InventoryIssueId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public int NoOfTest { get; set; }
        public int NoOfWastage { get; set; }
        public string Remarks { get; set; }
    }
}
