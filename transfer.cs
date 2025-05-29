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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EF_Project
{
    
    public partial class transfer : Form
    {
        ConnectorDBContext connector = new ConnectorDBContext();
        public transfer()
        {
            InitializeComponent();
        }

        private void transfer_btn_Click(object sender, EventArgs e)
        {

            
            var invtrack = new From_Inv_to_Inv_Tracker()
            {
                from = int.Parse(source.Text) ,
                to = int.Parse(dest.Text),
                item = int.Parse(it_Id.Text),
                quantity = int.Parse(quant.Text),
                Production_Date = production_date.Value,
                Expire_Limit = int.Parse(expire.Text),
                Trs_Date = DateTime.Now
            };
            connector.InvToInvAudit.Add(invtrack);
            connector.SaveChanges();




            InventoryItem source_obj = connector.InventoryItems.First(i => i.InventoryId == invtrack.from && i.ItemId == invtrack.item);

            var track1 = new Audit_Tracking() { Taregt_Inv = invtrack.from, Item = invtrack.item, AddOrPull = 0, Quantity = invtrack.quantity, QuantityAfter = source_obj.Quantity - invtrack.quantity,  Transaction_Date = DateTime.Now , From_Inv_To_Inv_ID = invtrack.Trs_ID };
            connector.AuditTable.Add(track1);
            source_obj.Quantity = track1.QuantityAfter;

            InventoryItem destination = connector.InventoryItems.First(i => i.InventoryId == invtrack.to && i.ItemId == invtrack.item);

            var track2 = new Audit_Tracking() { Taregt_Inv = invtrack.to, Item = invtrack.item, AddOrPull = 1, Quantity = invtrack.quantity, QuantityAfter = destination.Quantity + invtrack.quantity, From_Inv_To_Inv_ID = invtrack.Trs_ID ,  Transaction_Date = DateTime.Now };
            connector.AuditTable.Add(track2);
            destination.Quantity = track2.QuantityAfter;

            connector.SaveChanges();
            MessageBox.Show("Sucessfully Transfered");





        }
    }
}
