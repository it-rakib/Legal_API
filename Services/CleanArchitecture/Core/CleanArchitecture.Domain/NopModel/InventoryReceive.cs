using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class InventoryReceive
    {
        public int ReceiveId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int VendorId { get; set; }
    }
}
