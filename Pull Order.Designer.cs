namespace EF_Project
{
    partial class Pull_Order
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
            button3 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            save_item_per_order = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Cli_Id = new System.Windows.Forms.TextBox();
            Quant = new System.Windows.Forms.TextBox();
            Item_Id = new System.Windows.Forms.TextBox();
            Inv_Id = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(669, 49);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(202, 29);
            button3.TabIndex = 31;
            button3.Text = "Save Pull Order Headings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(381, 180);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(0, 20);
            label8.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.SystemColors.Info;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(64, 128);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(264, 20);
            label6.TabIndex = 29;
            label6.Text = "add Items in the Same Supply Order";
            // 
            // save_item_per_order
            // 
            save_item_per_order.Enabled = false;
            save_item_per_order.Location = new System.Drawing.Point(534, 188);
            save_item_per_order.Name = "save_item_per_order";
            save_item_per_order.Size = new System.Drawing.Size(215, 56);
            save_item_per_order.TabIndex = 28;
            save_item_per_order.Text = "Save Item Per Order";
            save_item_per_order.UseVisualStyleBackColor = true;
            save_item_per_order.Click += save_item_per_order_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(366, 55);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 20);
            label5.TabIndex = 27;
            label5.Text = "Client ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(94, 217);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 25;
            label4.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(94, 163);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 20);
            label2.TabIndex = 24;
            label2.Text = "Item ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 20);
            label1.TabIndex = 23;
            label1.Text = "Inventory ID";
            // 
            // Cli_Id
            // 
            Cli_Id.Location = new System.Drawing.Point(456, 51);
            Cli_Id.Name = "Cli_Id";
            Cli_Id.Size = new System.Drawing.Size(125, 27);
            Cli_Id.TabIndex = 21;
            // 
            // Quant
            // 
            Quant.Location = new System.Drawing.Point(217, 217);
            Quant.Name = "Quant";
            Quant.Size = new System.Drawing.Size(125, 27);
            Quant.TabIndex = 20;
            // 
            // Item_Id
            // 
            Item_Id.Location = new System.Drawing.Point(217, 163);
            Item_Id.Name = "Item_Id";
            Item_Id.Size = new System.Drawing.Size(125, 27);
            Item_Id.TabIndex = 19;
            // 
            // Inv_Id
            // 
            Inv_Id.Location = new System.Drawing.Point(165, 55);
            Inv_Id.Name = "Inv_Id";
            Inv_Id.Size = new System.Drawing.Size(125, 27);
            Inv_Id.TabIndex = 17;
            // 
            // Pull_Order
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(982, 450);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(save_item_per_order);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cli_Id);
            Controls.Add(Quant);
            Controls.Add(Item_Id);
            Controls.Add(Inv_Id);
            Name = "Pull_Order";
            Text = "Pull_Order";
            Load += Pull_Order_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_item_per_order;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cli_Id;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.TextBox Item_Id;
        private System.Windows.Forms.TextBox Inv_Id;
    }
}