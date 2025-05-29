using System.Collections.Generic;

namespace EF_Project.Entities
{
    public class Inventory
    {
        public int ID { get; set; }
        public string InvName { get; set; }
        public string Address { get; set; }
        public string MangerName { get; set; }
        public virtual ICollection<InventoryItem> Items { get; set; } = new HashSet<InventoryItem>();

        public virtual ICollection<From_Inv_to_Inv_Tracker> FromTransfers { get; set; } = new HashSet<From_Inv_to_Inv_Tracker>();
        public virtual ICollection<From_Inv_to_Inv_Tracker> ToTransfers { get; set; } = new HashSet<From_Inv_to_Inv_Tracker>();
    }
}
