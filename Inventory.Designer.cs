namespace EF_Project
{
    partial class Inventory_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Insert_Inventory = new System.Windows.Forms.Button();
            Inv_Name = new System.Windows.Forms.TextBox();
            Inv_Manager = new System.Windows.Forms.TextBox();
            Inv_Address = new System.Windows.Forms.TextBox();
            Save_inv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(407, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Insert_Inventory
            // 
            Insert_Inventory.Location = new System.Drawing.Point(471, 102);
            Insert_Inventory.Name = "Insert_Inventory";
            Insert_Inventory.Size = new System.Drawing.Size(94, 29);
            Insert_Inventory.TabIndex = 1;
            Insert_Inventory.Text = "Insert Inv";
            Insert_Inventory.UseVisualStyleBackColor = true;
            Insert_Inventory.Click += Insert_Inventory_Click;
            // 
            // Inv_Name
            // 
            Inv_Name.Location = new System.Drawing.Point(471, 33);
            Inv_Name.Name = "Inv_Name";
            Inv_Name.PlaceholderText = "Inv_Name";
            Inv_Name.Size = new System.Drawing.Size(125, 27);
            Inv_Name.TabIndex = 2;
            // 
            // Inv_Manager
            // 
            Inv_Manager.Location = new System.Drawing.Point(797, 33);
            Inv_Manager.Name = "Inv_Manager";
            Inv_Manager.PlaceholderText = "Inv_Manager";
            Inv_Manager.Size = new System.Drawing.Size(125, 27);
            Inv_Manager.TabIndex = 3;
            // 
            // Inv_Address
            // 
            Inv_Address.Location = new System.Drawing.Point(631, 33);
            Inv_Address.Name = "Inv_Address";
            Inv_Address.PlaceholderText = "Inv_Address";
            Inv_Address.Size = new System.Drawing.Size(125, 27);
            Inv_Address.TabIndex = 4;
            // 
            // Save_inv
            // 
            Save_inv.Location = new System.Drawing.Point(817, 102);
            Save_inv.Name = "Save_inv";
            Save_inv.Size = new System.Drawing.Size(94, 29);
            Save_inv.TabIndex = 5;
            Save_inv.Text = "Save";
            Save_inv.UseVisualStyleBackColor = true;
            Save_inv.Click += Save_inv_Click;
            // 
            // Inventory_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1020, 450);
            Controls.Add(Save_inv);
            Controls.Add(Inv_Address);
            Controls.Add(Inv_Manager);
            Controls.Add(Inv_Name);
            Controls.Add(Insert_Inventory);
            Controls.Add(dataGridView1);
            Name = "Inventory_Form";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert_Inventory;
        private System.Windows.Forms.TextBox Inv_Name;
        private System.Windows.Forms.TextBox Inv_Manager;
        private System.Windows.Forms.TextBox Inv_Address;
        private System.Windows.Forms.Button Save_inv;
    }
}