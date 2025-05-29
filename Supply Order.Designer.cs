namespace EF_Project
{
    partial class Supply_Order
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
            Expire = new System.Windows.Forms.TextBox();
            Item_Id = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            save_item_per_order = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            Finish = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            SupplierComboBox = new System.Windows.Forms.ComboBox();
            Quant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Quant).BeginInit();
            SuspendLayout();
            // 
            // Expire
            // 
            Expire.Location = new System.Drawing.Point(171, 281);
            Expire.Name = "Expire";
            Expire.Size = new System.Drawing.Size(125, 27);
            Expire.TabIndex = 1;
            // 
            // Item_Id
            // 
            Item_Id.BackColor = System.Drawing.SystemColors.HighlightText;
            Item_Id.Location = new System.Drawing.Point(171, 182);
            Item_Id.Name = "Item_Id";
            Item_Id.Size = new System.Drawing.Size(125, 27);
            Item_Id.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(458, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "Inventory ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 182);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 20);
            label2.TabIndex = 8;
            label2.Text = "Item ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 288);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 20);
            label3.TabIndex = 9;
            label3.Text = "Expire Limit in Months";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(48, 236);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(321, 73);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 20);
            label5.TabIndex = 10;
            label5.Text = "Supplier ID";
            // 
            // save_item_per_order
            // 
            save_item_per_order.BackColor = System.Drawing.SystemColors.InactiveBorder;
            save_item_per_order.Enabled = false;
            save_item_per_order.Location = new System.Drawing.Point(624, 274);
            save_item_per_order.Name = "save_item_per_order";
            save_item_per_order.Size = new System.Drawing.Size(170, 41);
            save_item_per_order.TabIndex = 11;
            save_item_per_order.Text = "Save Item Per Order";
            save_item_per_order.UseVisualStyleBackColor = false;
            save_item_per_order.Click += save_item_per_order_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.SystemColors.Info;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(9, 145);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(264, 20);
            label6.TabIndex = 13;
            label6.Text = "add Items in the Same Supply Order";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(335, 185);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(117, 20);
            label8.TabIndex = 15;
            label8.Text = "Production Date";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(624, 67);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(202, 29);
            button3.TabIndex = 16;
            button3.Text = "Save Order Headings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.SystemColors.Info;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Location = new System.Drawing.Point(10, 28);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(151, 20);
            label7.TabIndex = 17;
            label7.Text = "add Order Headings";
            // 
            // Finish
            // 
            Finish.BackColor = System.Drawing.Color.AntiqueWhite;
            Finish.Enabled = false;
            Finish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Finish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Finish.Location = new System.Drawing.Point(321, 384);
            Finish.Name = "Finish";
            Finish.Size = new System.Drawing.Size(215, 45);
            Finish.TabIndex = 18;
            Finish.Text = "Finish The Order";
            Finish.UseVisualStyleBackColor = false;
            Finish.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(105, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            SupplierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new System.Drawing.Point(410, 70);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new System.Drawing.Size(151, 28);
            SupplierComboBox.TabIndex = 20;
            SupplierComboBox.SelectedIndexChanged += SupplierComboBox_SelectedIndexChanged;
            // 
            // Quant
            // 
            Quant.Location = new System.Drawing.Point(171, 236);
            Quant.Name = "Quant";
            Quant.Size = new System.Drawing.Size(150, 27);
            Quant.TabIndex = 21;
            // 
            // Supply_Order
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(891, 450);
            Controls.Add(Quant);
            Controls.Add(SupplierComboBox);
            Controls.Add(comboBox1);
            Controls.Add(Finish);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(save_item_per_order);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Item_Id);
            Controls.Add(Expire);
            Name = "Supply_Order";
            Text = "Supply_Order";
            ((System.ComponentModel.ISupportInitialize)Quant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox Expire;
        private System.Windows.Forms.TextBox Item_Id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_item_per_order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.NumericUpDown Quant;
    }
}