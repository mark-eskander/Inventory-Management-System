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

namespace EF_Project
{
    public partial class ItemsDuringInterval : Form
    {
        ConnectorDBContext connector = new();
        public ItemsDuringInterval()
        {
            InitializeComponent();

            ItemComboBox.DataSource = connector.Items.ToList();
            ItemComboBox.DisplayMember = "Name";
            ItemComboBox.ValueMember = "Code";


            checkedListBox1.DataSource = connector.Inventories.Select(inv => inv.InvName).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                connector.AuditTable.
                Where(i => i.Transaction_Date >= DateTime.Parse(DateFrom.Text) && i.Transaction_Date <= DateTime.Parse(DateTo.Text)
                && i.item.Code == int.Parse(ItemComboBox.ValueMember)).OrderBy(i => i.Transaction_Date);

        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
