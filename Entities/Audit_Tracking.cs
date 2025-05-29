using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Project.Entities
{
    public class Audit_Tracking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("inventory")]
        public int Taregt_Inv { get; set; }



        [ForeignKey("item")]

        public int Item { get; set; }
        public byte AddOrPull { get; set; }
        public int Quantity { get; set; }
        public int QuantityAfter { get; set; }

        [ForeignKey("pull_order_nav")]

        public int? Pull_Order_Id { get; set; }
        [ForeignKey("supply_order_nav")]

        public int? Supply_Order_Id { get; set; }
        public DateTime Transaction_Date { get; set; }

        [ForeignKey("From_Inv_To_Inv_Tracker_nav")]

        public int? From_Inv_To_Inv_ID { get; set; }

        public virtual Inventory inventory { get; set; }
        public virtual Item item { get; set; }
        public virtual SupplyOrder? supply_order_nav { get; set; }
        public virtual PullOrder? pull_order_nav { get; set; }

        public virtual From_Inv_to_Inv_Tracker? From_Inv_To_Inv_Tracker_nav { get; set; }





    }
}
