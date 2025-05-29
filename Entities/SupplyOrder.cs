using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Project.Entities
{
    public class SupplyOrder
    {
        [Key]
        public int SupplyOrderID { get; set; }
        public DateTime Date { get; set; }
        public int SupplierId { get; set; }
        public int InventoryId { get; set; }
        public Supplier supplier { get; set; }
        public Inventory Inventory { get; set; }
        public ICollection<SupplyOrederDetails> supplyOrederDetails { get; set; } = new HashSet<SupplyOrederDetails>();
        public virtual ICollection<Audit_Tracking> AuditTrackers { get; set; } = new HashSet<Audit_Tracking>();

    }
}
