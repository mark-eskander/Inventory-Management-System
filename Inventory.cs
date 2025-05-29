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


    public partial class Inventory_Form : Form
    {
        ConnectorDBContext connector = new ConnectorDBContext();
        public Inventory_Form(ConnectorDBContext connector)
        {
            InitializeComponent();
        }

        private void Insert_Inventory_Click(object sender, EventArgs e)
        {
            Inventory inv = new() { InvName = Inv_Name.Text, Address = Inv_Address.Text, MangerName = Inv_Manager.Text };
            connector.Inventories.Add(inv);
            MessageBox.Show("Inserted Successfully Plesae Save Changes");
            Save_inv.BackColor = Color.Red;

        }

        private void Save_inv_Click(object sender, EventArgs e)
        {
            

             connector.SaveChangesAsync();
            MessageBox.Show("Saved Successfully");
            Save_inv.BackColor = Color.White;
            dataGridView1.DataSource = connector.Inventories.ToList();
        }
    }
}
