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
    public partial class MasterReports : Form
    {
        public MasterReports()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports reports = new reports();

            reports.dataGridView1.DataSource = reports.connector.InventoryItems.Include(i => i.Inventory).Select(i => new { i.InventoryId, i.ItemId, i.Quantity, i.LastUse, InventoryName = i.Inventory.InvName }).Where(i => reports.checkedListBox1.CheckedItems.Contains(i.InventoryName) && i.ItemId == int.Parse(reports.ItemComboBox.ValueMember)).ToList();
            reports.ItemComboBox.DataSource = reports.connector.Items.ToList();
            reports.ItemComboBox.DisplayMember = "Name";
            reports.ItemComboBox.ValueMember = "Code";

            reports.checkedListBox1.DataSource = reports.connector.Inventories.Select(inv => inv.InvName).ToList();
            reports.TopLevel = false;
            panel2.Controls.Add(reports);
            reports.FormBorderStyle = FormBorderStyle.None;
            reports.BringToFront();
            reports.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemsDuringInterval frm = new ();

            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.BringToFront(); 
            frm.Show();
        }
    }
}
