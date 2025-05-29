using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Project.Entities
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int SupplierID { get; set; }
        public virtual ICollection<InventoryItem> Inventories { get; set; } = new HashSet<InventoryItem>();
        public virtual ICollection<PullOrederDetails> PullOrderDetails { get; set; } = new HashSet<PullOrederDetails>();
        public virtual ICollection<SupplyOrederDetails> SupplyOrederDetails { get; set; } = new HashSet<SupplyOrederDetails>();

        public virtual ICollection<Audit_Tracking> AuditTrackers { get; set; } = new HashSet<Audit_Tracking>();
        public virtual ICollection<From_Inv_to_Inv_Tracker> From_Inv_To_Inv_Tracker_nav { get; set; } = new List<From_Inv_to_Inv_Tracker>();

    }
}
