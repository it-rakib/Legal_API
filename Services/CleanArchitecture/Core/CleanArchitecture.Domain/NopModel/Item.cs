using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class Item
    {
        public Item()
        {
            InventoryItemMappnings = new HashSet<InventoryItemMappning>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<InventoryItemMappning> InventoryItemMappnings { get; set; }
    }
}
