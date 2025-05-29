namespace EF_Project
{
    partial class Form1
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
            Insert = new System.Windows.Forms.Button();
            C_Name = new System.Windows.Forms.TextBox();
            C_Mobile = new System.Windows.Forms.TextBox();
            C_Phone = new System.Windows.Forms.TextBox();
            C_Address = new System.Windows.Forms.TextBox();
            C_WebSite = new System.Windows.Forms.TextBox();
            C_Email = new System.Windows.Forms.TextBox();
            Save = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            Inventory_Menu = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            pullOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            transferFromInvToInvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Delete_client = new System.Windows.Forms.Button();
            User_ID = new System.Windows.Forms.TextBox();
            ClientradioButton1 = new System.Windows.Forms.RadioButton();
            SiupplierradioButton2 = new System.Windows.Forms.RadioButton();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(614, 305);
            dataGridView1.TabIndex = 0;
            // 
            // Insert
            // 
            Insert.BackColor = System.Drawing.Color.SandyBrown;
            Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Insert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Insert.ForeColor = System.Drawing.SystemColors.ControlText;
            Insert.Location = new System.Drawing.Point(644, 306);
            Insert.Name = "Insert";
            Insert.Size = new System.Drawing.Size(120, 38);
            Insert.TabIndex = 1;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = false;
            Insert.Click += Insert_Click;
            // 
            // C_Name
            // 
            C_Name.Location = new System.Drawing.Point(644, 118);
            C_Name.Name = "C_Name";
            C_Name.PlaceholderText = "Client Name";
            C_Name.Size = new System.Drawing.Size(170, 27);
            C_Name.TabIndex = 2;
            // 
            // C_Mobile
            // 
            C_Mobile.Location = new System.Drawing.Point(887, 167);
            C_Mobile.Name = "C_Mobile";
            C_Mobile.PlaceholderText = "Client Mobile";
            C_Mobile.Size = new System.Drawing.Size(170, 27);
            C_Mobile.TabIndex = 3;
            // 
            // C_Phone
            // 
            C_Phone.Location = new System.Drawing.Point(644, 167);
            C_Phone.Name = "C_Phone";
            C_Phone.PlaceholderText = "Client Phone";
            C_Phone.Size = new System.Drawing.Size(170, 27);
            C_Phone.TabIndex = 4;
            // 
            // C_Address
            // 
            C_Address.Location = new System.Drawing.Point(887, 118);
            C_Address.Name = "C_Address";
            C_Address.PlaceholderText = "Client Address";
            C_Address.Size = new System.Drawing.Size(170, 27);
            C_Address.TabIndex = 5;
            // 
            // C_WebSite
            // 
            C_WebSite.Location = new System.Drawing.Point(887, 224);
            C_WebSite.Name = "C_WebSite";
            C_WebSite.PlaceholderText = "Client Website";
            C_WebSite.Size = new System.Drawing.Size(170, 27);
            C_WebSite.TabIndex = 6;
            // 
            // C_Email
            // 
            C_Email.Location = new System.Drawing.Point(644, 224);
            C_Email.Name = "C_Email";
            C_Email.PlaceholderText = "Client Email";
            C_Email.Size = new System.Drawing.Size(170, 27);
            C_Email.TabIndex = 7;
            // 
            // Save
            // 
            Save.Location = new System.Drawing.Point(930, 499);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(114, 50);
            Save.TabIndex = 8;
            Save.Text = "Save Changes";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Inventory_Menu, toolStripMenuItem2, toolStripMenuItem3, pullOrderToolStripMenuItem, transferFromInvToInvToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 7);
            menuStrip1.Size = new System.Drawing.Size(1084, 33);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // Inventory_Menu
            // 
            Inventory_Menu.Name = "Inventory_Menu";
            Inventory_Menu.Size = new System.Drawing.Size(92, 24);
            Inventory_Menu.Text = "Inventory";
            Inventory_Menu.Click += Inventory_Menu_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(56, 24);
            toolStripMenuItem2.Text = "Item";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(114, 24);
            toolStripMenuItem3.Text = "Supply Order";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // pullOrderToolStripMenuItem
            // 
            pullOrderToolStripMenuItem.Name = "pullOrderToolStripMenuItem";
            pullOrderToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            pullOrderToolStripMenuItem.Text = "Pull Order";
            pullOrderToolStripMenuItem.Click += pullOrderToolStripMenuItem_Click;
            // 
            // transferFromInvToInvToolStripMenuItem
            // 
            transferFromInvToInvToolStripMenuItem.Name = "transferFromInvToInvToolStripMenuItem";
            transferFromInvToInvToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            transferFromInvToInvToolStripMenuItem.Text = "Transfer From Inv To Inv";
            transferFromInvToInvToolStripMenuItem.Click += transferFromInvToInvToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // Delete_client
            // 
            Delete_client.BackColor = System.Drawing.Color.Firebrick;
            Delete_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Delete_client.Location = new System.Drawing.Point(12, 499);
            Delete_client.Name = "Delete_client";
            Delete_client.Size = new System.Drawing.Size(133, 50);
            Delete_client.TabIndex = 11;
            Delete_client.Text = "Delete Client";
            Delete_client.UseVisualStyleBackColor = false;
            Delete_client.Click += Delete_client_Click;
            // 
            // User_ID
            // 
            User_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            User_ID.Location = new System.Drawing.Point(160, 512);
            User_ID.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            User_ID.Name = "User_ID";
            User_ID.PlaceholderText = " Client ID";
            User_ID.Size = new System.Drawing.Size(125, 27);
            User_ID.TabIndex = 12;
            // 
            // ClientradioButton1
            // 
            ClientradioButton1.AutoSize = true;
            ClientradioButton1.Checked = true;
            ClientradioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ClientradioButton1.ForeColor = System.Drawing.Color.Firebrick;
            ClientradioButton1.Location = new System.Drawing.Point(678, 45);
            ClientradioButton1.Name = "ClientradioButton1";
            ClientradioButton1.Size = new System.Drawing.Size(70, 24);
            ClientradioButton1.TabIndex = 13;
            ClientradioButton1.TabStop = true;
            ClientradioButton1.Text = "Client";
            ClientradioButton1.UseVisualStyleBackColor = true;
            ClientradioButton1.CheckedChanged += ClientradioButton1_CheckedChanged;
            // 
            // SiupplierradioButton2
            // 
            SiupplierradioButton2.AutoSize = true;
            SiupplierradioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SiupplierradioButton2.ForeColor = System.Drawing.Color.Firebrick;
            SiupplierradioButton2.Location = new System.Drawing.Point(844, 45);
            SiupplierradioButton2.Name = "SiupplierradioButton2";
            SiupplierradioButton2.Size = new System.Drawing.Size(87, 24);
            SiupplierradioButton2.TabIndex = 14;
            SiupplierradioButton2.Text = "Supplier";
            SiupplierradioButton2.UseVisualStyleBackColor = true;
            SiupplierradioButton2.CheckedChanged += SiupplierradioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.Location = new System.Drawing.Point(12, 381);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(133, 36);
            button1.TabIndex = 15;
            button1.Text = "Show Clients";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1084, 585);
            Controls.Add(button1);
            Controls.Add(SiupplierradioButton2);
            Controls.Add(ClientradioButton1);
            Controls.Add(User_ID);
            Controls.Add(Delete_client);
            Controls.Add(Save);
            Controls.Add(C_Email);
            Controls.Add(C_WebSite);
            Controls.Add(C_Address);
            Controls.Add(C_Phone);
            Controls.Add(C_Mobile);
            Controls.Add(C_Name);
            Controls.Add(Insert);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox C_Name;
        private System.Windows.Forms.TextBox C_Mobile;
        private System.Windows.Forms.TextBox C_Phone;
        private System.Windows.Forms.TextBox C_Address;
        private System.Windows.Forms.TextBox C_WebSite;
        private System.Windows.Forms.TextBox C_Email;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Inventory_Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button Delete_client;
        private System.Windows.Forms.TextBox User_ID;
        private System.Windows.Forms.RadioButton ClientradioButton1;
        private System.Windows.Forms.RadioButton SiupplierradioButton2;
        private System.Windows.Forms.ToolStripMenuItem pullOrderToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem transferFromInvToInvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

