namespace EF_Project
{
    partial class ItemsDuringInterval
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
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            DateFrom = new System.Windows.Forms.DateTimePicker();
            DateTo = new System.Windows.Forms.DateTimePicker();
            ItemComboBox = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new System.Drawing.Point(12, 54);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(162, 356);
            checkedListBox1.TabIndex = 0;
            // 
            // DateFrom
            // 
            DateFrom.Location = new System.Drawing.Point(216, 132);
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new System.Drawing.Size(250, 27);
            DateFrom.TabIndex = 2;
            DateFrom.ValueChanged += DateFrom_ValueChanged;
            // 
            // DateTo
            // 
            DateTo.Location = new System.Drawing.Point(216, 285);
            DateTo.Name = "DateTo";
            DateTo.Size = new System.Drawing.Size(250, 27);
            DateTo.TabIndex = 3;
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new System.Drawing.Point(216, 54);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new System.Drawing.Size(151, 28);
            ItemComboBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(530, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(675, 424);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(361, 426);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 46);
            button1.TabIndex = 6;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(225, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 20);
            label1.TabIndex = 7;
            label1.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 20);
            label2.TabIndex = 8;
            label2.Text = "Inventories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label3.Location = new System.Drawing.Point(216, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label4.Location = new System.Drawing.Point(216, 249);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "Start Date";
            // 
            // ItemsDuringInterval
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1218, 519);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(ItemComboBox);
            Controls.Add(DateTo);
            Controls.Add(DateFrom);
            Controls.Add(checkedListBox1);
            Name = "ItemsDuringInterval";
            Text = "ItemsDuringInterval";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}