using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class InventoryReceiveDetail
    {
        public InventoryReceiveDetail()
        {
            InventoryItemMappnings = new HashSet<InventoryItemMappning>();
        }

        public int ReceivedDetailId { get; set; }
        public int? ReceiveId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<InventoryItemMappning> InventoryItemMappnings { get; set; }
    }
}
