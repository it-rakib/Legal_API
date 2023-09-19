using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabInventory
    {
        public int Id { get; set; }
        public DateTime InventoryDate { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public bool IsPosted { get; set; }
    }
}
