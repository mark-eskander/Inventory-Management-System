namespace EF_Project
{
    partial class transfer
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
            transfer_btn = new System.Windows.Forms.Button();
            source = new System.Windows.Forms.TextBox();
            it_Id = new System.Windows.Forms.TextBox();
            dest = new System.Windows.Forms.TextBox();
            expire = new System.Windows.Forms.TextBox();
            quant = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            production_date = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // transfer_btn
            // 
            transfer_btn.BackColor = System.Drawing.Color.Khaki;
            transfer_btn.Location = new System.Drawing.Point(328, 340);
            transfer_btn.Name = "transfer_btn";
            transfer_btn.Size = new System.Drawing.Size(159, 50);
            transfer_btn.TabIndex = 0;
            transfer_btn.Text = "Transfer";
            transfer_btn.UseVisualStyleBackColor = false;
            transfer_btn.Click += transfer_btn_Click;
            // 
            // source
            // 
            source.Location = new System.Drawing.Point(180, 31);
            source.Name = "source";
            source.Size = new System.Drawing.Size(125, 27);
            source.TabIndex = 1;
            // 
            // it_Id
            // 
            it_Id.Location = new System.Drawing.Point(180, 127);
            it_Id.Name = "it_Id";
            it_Id.Size = new System.Drawing.Size(125, 27);
            it_Id.TabIndex = 2;
            // 
            // dest
            // 
            dest.Location = new System.Drawing.Point(517, 31);
            dest.Name = "dest";
            dest.Size = new System.Drawing.Size(125, 27);
            dest.TabIndex = 3;
            // 
            // expire
            // 
            expire.Location = new System.Drawing.Point(180, 204);
            expire.Name = "expire";
            expire.Size = new System.Drawing.Size(125, 27);
            expire.TabIndex = 4;
            // 
            // quant
            // 
            quant.Location = new System.Drawing.Point(517, 127);
            quant.Name = "quant";
            quant.Size = new System.Drawing.Size(125, 27);
            quant.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(57, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 20);
            label1.TabIndex = 8;
            label1.Text = "Source Inv ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(370, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 20);
            label2.TabIndex = 9;
            label2.Text = "Destination Inv Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(84, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 20);
            label3.TabIndex = 10;
            label3.Text = "Item ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(43, 207);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 20);
            label4.TabIndex = 11;
            label4.Text = "Expire in Months";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(416, 130);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 20);
            label5.TabIndex = 12;
            label5.Text = "Quantity";
            // 
            // production_date
            // 
            production_date.Location = new System.Drawing.Point(517, 207);
            production_date.Name = "production_date";
            production_date.Size = new System.Drawing.Size(250, 27);
            production_date.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(370, 212);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 20);
            label6.TabIndex = 14;
            label6.Text = "Production Date";
            // 
            // transfer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(873, 450);
            Controls.Add(label6);
            Controls.Add(production_date);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quant);
            Controls.Add(expire);
            Controls.Add(dest);
            Controls.Add(it_Id);
            Controls.Add(source);
            Controls.Add(transfer_btn);
            Name = "transfer";
            Text = "transfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button transfer_btn;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.TextBox it_Id;
        private System.Windows.Forms.TextBox dest;
        private System.Windows.Forms.TextBox expire;
        private System.Windows.Forms.TextBox quant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker production_date;
        private System.Windows.Forms.Label label6;
    }
}