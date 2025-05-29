namespace EF_Project
{
    partial class Item_Form
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
            Item_Supplier_Id = new System.Windows.Forms.TextBox();
            Item_Unit = new System.Windows.Forms.TextBox();
            Item_Name = new System.Windows.Forms.TextBox();
            Insert_item = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Save_Changes = new System.Windows.Forms.Button();
            Delete_item = new System.Windows.Forms.Button();
            Item_id = new System.Windows.Forms.TextBox();
            show_items = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Item_Supplier_Id
            // 
            Item_Supplier_Id.Location = new System.Drawing.Point(507, 151);
            Item_Supplier_Id.Name = "Item_Supplier_Id";
            Item_Supplier_Id.PlaceholderText = "Item Supplier Id";
            Item_Supplier_Id.Size = new System.Drawing.Size(170, 27);
            Item_Supplier_Id.TabIndex = 12;
            // 
            // Item_Unit
            // 
            Item_Unit.Location = new System.Drawing.Point(507, 90);
            Item_Unit.Name = "Item_Unit";
            Item_Unit.PlaceholderText = "Item unit";
            Item_Unit.Size = new System.Drawing.Size(170, 27);
            Item_Unit.TabIndex = 11;
            // 
            // Item_Name
            // 
            Item_Name.Location = new System.Drawing.Point(507, 16);
            Item_Name.Name = "Item_Name";
            Item_Name.PlaceholderText = "Item Name";
            Item_Name.Size = new System.Drawing.Size(170, 27);
            Item_Name.TabIndex = 10;
            // 
            // Insert_item
            // 
            Insert_item.Location = new System.Drawing.Point(507, 216);
            Insert_item.Name = "Insert_item";
            Insert_item.Size = new System.Drawing.Size(94, 29);
            Insert_item.TabIndex = 9;
            Insert_item.Text = "Insert";
            Insert_item.UseVisualStyleBackColor = true;
            Insert_item.Click += Insert_item_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(439, 242);
            dataGridView1.TabIndex = 8;
            // 
            // Save_Changes
            // 
            Save_Changes.Location = new System.Drawing.Point(685, 352);
            Save_Changes.Name = "Save_Changes";
            Save_Changes.Size = new System.Drawing.Size(123, 58);
            Save_Changes.TabIndex = 13;
            Save_Changes.Text = "Save Changes";
            Save_Changes.UseVisualStyleBackColor = true;
            Save_Changes.Click += Save_Changes_Click;
            // 
            // Delete_item
            // 
            Delete_item.BackColor = System.Drawing.Color.IndianRed;
            Delete_item.Location = new System.Drawing.Point(12, 381);
            Delete_item.Name = "Delete_item";
            Delete_item.Size = new System.Drawing.Size(96, 29);
            Delete_item.TabIndex = 14;
            Delete_item.Text = "Delete item";
            Delete_item.UseVisualStyleBackColor = false;
            Delete_item.Click += Delete_item_Click;
            // 
            // Item_id
            // 
            Item_id.Location = new System.Drawing.Point(114, 382);
            Item_id.Name = "Item_id";
            Item_id.PlaceholderText = "Item ID";
            Item_id.Size = new System.Drawing.Size(170, 27);
            Item_id.TabIndex = 15;
            // 
            // show_items
            // 
            show_items.BackColor = System.Drawing.SystemColors.ActiveCaption;
            show_items.Location = new System.Drawing.Point(12, 280);
            show_items.Name = "show_items";
            show_items.Size = new System.Drawing.Size(133, 36);
            show_items.TabIndex = 16;
            show_items.Text = "Show Items";
            show_items.UseVisualStyleBackColor = false;
            show_items.Click += show_items_Click;
            // 
            // Item_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(947, 450);
            Controls.Add(show_items);
            Controls.Add(Item_id);
            Controls.Add(Delete_item);
            Controls.Add(Save_Changes);
            Controls.Add(Item_Supplier_Id);
            Controls.Add(Item_Unit);
            Controls.Add(Item_Name);
            Controls.Add(Insert_item);
            Controls.Add(dataGridView1);
            Name = "Item_Form";
            Text = "Item";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Item_Supplier_Id;
        private System.Windows.Forms.TextBox Item_Unit;
        private System.Windows.Forms.TextBox Item_Name;
        private System.Windows.Forms.Button Insert_item;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save_Changes;
        private System.Windows.Forms.Button Delete_item;
        private System.Windows.Forms.TextBox Item_id;
        private System.Windows.Forms.Button show_items;
    }
}