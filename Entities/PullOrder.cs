using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Project.Entities
{
    public class PullOrder
    {
        [Key]
        public int PullOrderId { get; set; }
        public int InventoryId { get; set; }
        public int ClientId { get; set; }
        public DateOnly Date { get; set; }
        // Navigation Properties
        public virtual Inventory inventory { get; set; }
        public virtual Client client { get; set; }
        // Relationship with PullOrderDetails
        public virtual ICollection<PullOrederDetails> PullOrderDetails { get; set; } = new HashSet<PullOrederDetails>();

        public virtual ICollection<Audit_Tracking> AuditTrackers { get; set; } = new HashSet<Audit_Tracking>();

    }
}
