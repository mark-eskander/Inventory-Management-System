using EF_Project.Context;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_Project
{
    public partial class reports : Form
    {
        public ConnectorDBContext connector = new();
        public reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = connector.InventoryItems.Where(i => i.InventoryId == int.Parse(inv_Id.Text)).ToList();
            dataGridView1.DataSource = connector.InventoryItems.Include(i => i.Inventory).Select(i => new { i.InventoryId, i.ItemId ,  i.Quantity, i.LastUse, InventoryName = i.Inventory.InvName }).Where(i => checkedListBox1.CheckedItems.Contains(i.InventoryName) && i.ItemId == int.Parse(ItemComboBox.ValueMember) ).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = connector.InventoryItems.Where(i => ((DateTime.Now.Year - i.LastUse.Year) * 12) + (DateTime.Now.Month - i.LastUse.Month) > int.Parse(Period.Text)).ToList();

        }

        private void inv_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemsPerInventories_Click(object sender, EventArgs e)
        {

            ItemComboBox.DataSource = connector.Items.ToList();
            ItemComboBox.DisplayMember = "Name";
            ItemComboBox.ValueMember = "Code";


            checkedListBox1.DataSource = connector.Inventories.Select(inv => inv.InvName).ToList();


        }

        private void reports_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
