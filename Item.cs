using EF_Project.Context;
using EF_Project.Entities;
using Microsoft.EntityFrameworkCore;
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

    public partial class Item_Form : Form
    {
        ConnectorDBContext connector = new ConnectorDBContext();

        public Item_Form()
        {
            InitializeComponent();

            connector.Items.Load();

            dataGridView1.DataSource = connector.Items.Local.ToBindingList();
        }

        private void Delete_item_Click(object sender, EventArgs e)
        {
            Item removed_item = connector.Items.Find(int.Parse(Item_id.Text));

            if (removed_item != null)
            {

                connector.Items.Remove(removed_item);

                Save_Changes.BackColor = Color.Red;

            }
            else { MessageBox.Show("the id isn't in the database"); }
        }

        private void Insert_item_Click(object sender, EventArgs e)
        {


            Item new_item = new Item() { Name = Item_Name.Text, Unit = Item_Unit.Text, SupplierID = int.Parse(Item_Supplier_Id.Text) };
            connector.Items.Add(new_item);
            
            Save_Changes.BackColor = Color.Red;

        }

        private void Save_Changes_Click(object sender, EventArgs e)
        {
            connector.SaveChangesAsync();
            Save_Changes.BackColor = Color.White;
            MessageBox.Show("Saved Succefully");
            //dataGridView1.DataSource = connector.Items.ToList();

        }

        private void show_items_Click(object sender, EventArgs e)
        {
            connector.Items.Load();

            var x = connector.Items.ToList();

            foreach(var p in x) {
                if (p.Supplier == null)
                {
                    connector.Entry(p).Reference(p => p.Supplier).Load();
                }
                else { MessageBox.Show($"the product {p.Code} with supplier id {p.SupplierID} exists before"); }               
            }

            MessageBox.Show(connector.Suppliers.Local.Count+"");
            var y = connector.Items.ToList();
            MessageBox.Show(y[0].Supplier.SupplierName + "");


        }
    }
}
