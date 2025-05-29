

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;

namespace EF_Project.Entities
{
    public class InventoryItem
    {
        public int InventoryId { get; set; }
        public int ItemId { get; set; }

        public int Quantity { get; set; }
        public DateTime LastUse { get; set; }
        // Navigation Properties
        public virtual Inventory Inventory { get; set; }
        public virtual Item Item { get; set; }
         
    }
}