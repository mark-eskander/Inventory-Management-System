namespace EF_Project
{
    partial class MasterReports
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
            panel1 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ReportTitle = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ReportTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ReportTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(220, 668);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            button2.Dock = System.Windows.Forms.DockStyle.Top;
            button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.SystemColors.Highlight;
            button2.Location = new System.Drawing.Point(0, 131);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(220, 64);
            button2.TabIndex = 2;
            button2.Text = "Track Items During Interval";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.Continue;
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.SystemColors.Highlight;
            button1.Location = new System.Drawing.Point(0, 70);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(220, 61);
            button1.TabIndex = 1;
            button1.Text = "Items Per Inventories";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReportTitle
            // 
            ReportTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            ReportTitle.Controls.Add(label1);
            ReportTitle.Dock = System.Windows.Forms.DockStyle.Top;
            ReportTitle.Location = new System.Drawing.Point(0, 0);
            ReportTitle.Name = "ReportTitle";
            ReportTitle.Size = new System.Drawing.Size(220, 70);
            ReportTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Maroon;
            label1.Location = new System.Drawing.Point(37, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 31);
            label1.TabIndex = 0;
            label1.Text = "DashBoard";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            panel2.Location = new System.Drawing.Point(218, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1191, 668);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // MasterReports
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1410, 668);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MasterReports";
            Text = "MasterReports";
            panel1.ResumeLayout(false);
            ReportTitle.ResumeLayout(false);
            ReportTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ReportTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}