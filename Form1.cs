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
    public partial class Form1 : Form
    {
        ConnectorDBContext connector;




        public Form1()
        {
            InitializeComponent();

            connector = new ConnectorDBContext();

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (ClientradioButton1.Checked)
            {
                Client client = new Client { ClientName = C_Name.Text, Email = C_Email.Text, MobileNumber = C_Mobile.Text, PhoneNumber = C_Phone.Text, Website = C_WebSite.Text };

                connector.Clients.Add(client);
                Save.BackColor = Color.Red;
                MessageBox.Show("Inserted Successfully, Please Save Changes");
            }
            else
            {

                Supplier Supplier = new Supplier { SupplierName = C_Name.Text, Email = C_Email.Text, MobileNumber = C_Mobile.Text, PhoneNumer = C_Phone.Text, Website = C_WebSite.Text };

                connector.Suppliers.Add(Supplier);
                Save.BackColor = Color.Red;
                MessageBox.Show("Inserted Successfully, Please Save Changes");

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (connector.Database.EnsureCreated())
            {
                MessageBox.Show("first Creation for DataBase");

            }
            else MessageBox.Show("DataBase already Exist");



            connector.SaveChangesAsync();
            Save.BackColor = Color.WhiteSmoke;
            MessageBox.Show("saved Successfully");

            dataGridView1.DataSource = null;

            if (ClientradioButton1.Checked) dataGridView1.DataSource = connector.Clients.ToList();
            else dataGridView1.DataSource = connector.Suppliers.ToList();
        }



        private void Insert_Inventory_Click(object sender, EventArgs e)
        {
        }

        private void Inventory_Menu_Click(object sender, EventArgs e)
        {
            Inventory_Form inv_form = new Inventory_Form(connector);
            inv_form.Show();



        }

        private void Delete_client_Click(object sender, EventArgs e)
        {

            if (ClientradioButton1.Checked)
            {

                if (User_ID.Text == "")
                {
                    MessageBox.Show("insert the client id to delete!");
                }
                else
                {
                    Client removed_Client = connector.Clients.Find(int.Parse(User_ID.Text));

                    if (removed_Client != null)
                    {
                        connector.Clients.Remove(removed_Client);
                        Save.BackColor = Color.Red;
                    }

                    else MessageBox.Show("not exist");

                }
            }
            else
            {

                if (User_ID.Text == "")
                {
                    MessageBox.Show("insert the supplier id to delete!");
                }
                else
                {
                    Supplier removed_Supplier = connector.Suppliers.Find(int.Parse(User_ID.Text));

                    if (removed_Supplier != null)
                    {
                        connector.Suppliers.Remove(removed_Supplier);
                        Save.BackColor = Color.Red;
                    }

                    else MessageBox.Show("not exist");

                }


            }

        }

        private void SiupplierradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (SiupplierradioButton2.Checked)
            {

                User_ID.PlaceholderText = "Supplier ID";

                C_Address.PlaceholderText = "Supplier Address";
                C_Email.PlaceholderText = "Supplier Email";
                C_Mobile.PlaceholderText = "Supplier Mobile";
                C_Name.PlaceholderText = "Supplier Name";
                C_WebSite.PlaceholderText = "Supplier Website";
                C_Phone.PlaceholderText = "Supplier Phone";
                Delete_client.Text = "Delete supplier";
                button1.Text = "Show Suppliers";
                Delete_client.Text = "Delete Supplier";
                User_ID.PlaceholderText = "Supplier ID";



            }
        }

        private void ClientradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ClientradioButton1.Checked)
            {

                User_ID.PlaceholderText = "Client ID";

                C_Address.PlaceholderText = "Client Address";
                C_Email.PlaceholderText = "Client Email";
                C_Mobile.PlaceholderText = "Client Mobile";
                C_Name.PlaceholderText = "Client Name";
                C_WebSite.PlaceholderText = "client Website";
                C_Phone.PlaceholderText = "Client Phone";
                Delete_client.Text = "Delete Client";
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Item_Form form = new Item_Form();
            form.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Supply_Order form = new Supply_Order();
            form.Show();
        }

        private void pullOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pull_Order().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(SiupplierradioButton2.Checked) dataGridView1.DataSource = connector.Suppliers.ToList();

            else dataGridView1.DataSource = connector.Clients.ToList();
        }

        private void transferFromInvToInvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new transfer().Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterReports().Show();
        }
    }
}
