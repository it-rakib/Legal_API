using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class InventoryItemMappning
    {
        public int InventoryItemMappnigId { get; set; }
        public int? ReceivedDetailId { get; set; }
        public int? ItemId { get; set; }

        public virtual Item Item { get; set; }
        public virtual InventoryReceiveDetail ReceivedDetail { get; set; }
    }
}
