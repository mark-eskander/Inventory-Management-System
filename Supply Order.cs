using EF_Project.Context;
using EF_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class Supply_Order : Form
    {
        ConnectorDBContext connector = new ConnectorDBContext();
        SupplyOrder s_ord;


        public Supply_Order()
        {
            InitializeComponent();
            comboBox1.DataSource = connector.Inventories.ToList();
            comboBox1.DisplayMember = "InvName";
            comboBox1.ValueMember = "ID";

            SupplierComboBox.DataSource = connector.Suppliers.ToList();
            SupplierComboBox.DisplayMember = "SupplierName";
            SupplierComboBox.ValueMember = "IdSupplier";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            s_ord = new SupplyOrder() { InventoryId = (int)comboBox1.SelectedValue, SupplierId = (int)(SupplierComboBox.SelectedValue), Date = DateTime.Now };
            connector.SupplyOrders.Add(s_ord);

            connector.SaveChanges();
            save_item_per_order.Enabled = true;
            button3.Enabled = false;

        }

        private void save_item_per_order_Click(object sender, EventArgs e)
        {
            SupplyOrederDetails ord_det = new SupplyOrederDetails()
            {
                SupplyOrderId = s_ord.SupplyOrderID,
                Quantity = int.Parse(Quant.Text),
                ItemId = int.Parse(Item_Id.Text),
                ProdunctionDate = dateTimePicker1.Value,
                ExperationInMonths = int.Parse(Expire.Text)
            };
            connector.supplyOrederDetails.Add(ord_det);

            Audit_Tracking track;

            var update = connector.InventoryItems.FirstOrDefault(i => i.InventoryId == s_ord.InventoryId && i.ItemId == int.Parse(Item_Id.Text));
            if (update != null)
            { // in case already it inserted so need to edit the quantity

                track = new Audit_Tracking() { Taregt_Inv = s_ord.InventoryId, Item = ord_det.ItemId, AddOrPull = 1, Quantity = ord_det.Quantity, QuantityAfter = update.Quantity + ord_det.Quantity, Supply_Order_Id = s_ord.SupplyOrderID, Transaction_Date = DateTime.Now };
                connector.AuditTable.Add(track);

                update.Quantity += int.Parse(Quant.Text);


            }
            else
            {
                // in case of it's the first time
                connector.InventoryItems.Add(new InventoryItem { InventoryId = s_ord.InventoryId, ItemId = int.Parse(Item_Id.Text), Quantity = int.Parse(Quant.Text), LastUse = DateTime.Now });

                track = new Audit_Tracking() { Taregt_Inv = s_ord.InventoryId, Item = ord_det.ItemId, AddOrPull = 1, Quantity = ord_det.Quantity, QuantityAfter = ord_det.Quantity, Supply_Order_Id = s_ord.SupplyOrderID, Transaction_Date = DateTime.Now };
                connector.AuditTable.Add(track);
                MessageBox.Show("First Time This Item Inserted in this Inventory");

            }


            Item_Id.Text = "";
            Quant.Text = "";
            Expire.Text = "";

            if (Finish.Enabled = false)
            {
                Finish.BackColor = Color.Green;
                Finish.Enabled = true;
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connector.SaveChanges();
            MessageBox.Show("Saved Successfully");
            comboBox1.Text = "";
            SupplierComboBox.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
