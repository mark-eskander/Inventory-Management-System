using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Project.Entities
{
    public class Supplier
    {
        [Key]
        public int IdSupplier { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNumer { get; set; }
        public string MobileNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Website { get; set; }
        // Navigation to Items supplied
        public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();
        public virtual ICollection<PullOrederDetails> PullOrderDetails { get; set; } = new HashSet<PullOrederDetails>();

    }
}
