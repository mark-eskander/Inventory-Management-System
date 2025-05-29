using System;

namespace EF_Project.Entities
{
    public class SupplyOrederDetails
    {
        public int SupplyOrderId { get; set; }  // FK
        public int ItemId { get; set; }         // FK
        public int Quantity { get; set; }
        public DateTime ProdunctionDate { get; set; }
        public int ExperationInMonths { get; set; }
        // Navigation Properties
        public SupplyOrder SupplyOrder { get; set; }
        public Item Item { get; set; }
    }
}
