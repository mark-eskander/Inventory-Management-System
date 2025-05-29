using EF_Project.Context;
using EF_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EF_Project
{
    public partial class Pull_Order : Form
    {
        PullOrder p_ord;
        ConnectorDBContext connector = new ConnectorDBContext();
        public Pull_Order()
        {
            InitializeComponent();
        }

        private void Pull_Order_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p_ord = new PullOrder() { InventoryId = int.Parse(Inv_Id.Text), ClientId = int.Parse(Cli_Id.Text), Date = DateOnly.FromDateTime(DateTime.Now) };
            connector.PullOrders.Add(p_ord);

            connector.SaveChanges();
            save_item_per_order.Enabled = true;
        }

        private void save_item_per_order_Click(object sender, EventArgs e)
        {
            PullOrederDetails ord_det = new PullOrederDetails()
            {
                PullOrederId = p_ord.PullOrderId,
                Quantity = int.Parse(Quant.Text),
                ItemId = int.Parse(Item_Id.Text),
                SupplierId = connector.Items.FirstOrDefault(i => i.Code == int.Parse(Item_Id.Text)).SupplierID
            };

            var update = connector.InventoryItems.FirstOrDefault(i => i.InventoryId == p_ord.InventoryId && i.ItemId == int.Parse(Item_Id.Text));
            if (update != null && update.Quantity > int.Parse(Quant.Text))
            { // in case has the quantity and exists in the specific inv

                connector.pullOrederDetails.Add(ord_det);
               var track = new Audit_Tracking() { Taregt_Inv = p_ord.InventoryId, Item = ord_det.ItemId, AddOrPull = 0, Quantity = ord_det.Quantity, QuantityAfter = update.Quantity - ord_det.Quantity , Pull_Order_Id = p_ord.PullOrderId, Transaction_Date = DateTime.Now };
                connector.AuditTable.Add(track);
                update.Quantity -= int.Parse(Quant.Text);
                update.LastUse = DateTime.Now ;
                connector.SaveChanges();
            }
            else
            {
                // in case of no amount or this item not exist in the specific inventory
                MessageBox.Show("Sorry, this item may not exist in this inventory or maybe the quantity is less than wanted");

            }
            
        }
    }
}
