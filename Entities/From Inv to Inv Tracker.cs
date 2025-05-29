using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Project.Entities
{
    public class From_Inv_to_Inv_Tracker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trs_ID { get; set; }


        [ForeignKey("from_inv_nav")]
        public int from { get; set; }


        [ForeignKey("to_inv_nav")]

        public int to { get; set; }


        [ForeignKey("item_nav")]

        public int item { get; set; }

        public int quantity { get; set; }

        public DateTime Production_Date { get; set; }

        public int Expire_Limit { get; set; }

        public DateTime Trs_Date { get; set; }

        public virtual Item item_nav { get; set; }

        public virtual Inventory from_inv_nav { get; set; }
        public virtual Inventory to_inv_nav { get; set; }


        public virtual ICollection<Audit_Tracking> AuditTrackers { get; set; } = new HashSet<Audit_Tracking>();


    }
}
