
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Project.Entities
{
    public class PullOrederDetails
    {
        public int PullOrederId { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("item")]
        public int ItemId { get; set; }

        [ForeignKey("supplier")]

        public int SupplierId { get; set; }
        // Navigation Properties
        public virtual PullOrder PullOrder { get; set; } 
        public virtual Item item { get; set; }
        public virtual Supplier supplier { get; set; }
    }
}
