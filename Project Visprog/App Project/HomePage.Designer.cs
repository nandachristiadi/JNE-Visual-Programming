namespace ProjectUASVisprog
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactioToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem2});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem2
            // 
            this.orderToolStripMenuItem2.Name = "orderToolStripMenuItem2";
            this.orderToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.orderToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.orderToolStripMenuItem2.Text = "Shipment";
            this.orderToolStripMenuItem2.Click += new System.EventHandler(this.orderToolStripMenuItem2_Click);
            // 
            // transactioToolStripMenuItem
            // 
            this.transactioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem1});
            this.transactioToolStripMenuItem.Name = "transactioToolStripMenuItem";
            this.transactioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.transactioToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactioToolStripMenuItem.Text = "Transaction";
            // 
            // createOrderToolStripMenuItem1
            // 
            this.createOrderToolStripMenuItem1.Name = "createOrderToolStripMenuItem1";
            this.createOrderToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.createOrderToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.createOrderToolStripMenuItem1.Text = "CreateOrder";
            this.createOrderToolStripMenuItem1.Click += new System.EventHandler(this.createOrderToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportItemToolStripMenuItem,
            this.reportCustomerToolStripMenuItem,
            this.reportStaffToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // reportItemToolStripMenuItem
            // 
            this.reportItemToolStripMenuItem.Name = "reportItemToolStripMenuItem";
            this.reportItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.reportItemToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.reportItemToolStripMenuItem.Text = "Report Item";
            this.reportItemToolStripMenuItem.Click += new System.EventHandler(this.reportItemToolStripMenuItem_Click);
            // 
            // reportCustomerToolStripMenuItem
            // 
            this.reportCustomerToolStripMenuItem.Name = "reportCustomerToolStripMenuItem";
            this.reportCustomerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.reportCustomerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.reportCustomerToolStripMenuItem.Text = "Report Customer";
            this.reportCustomerToolStripMenuItem.Click += new System.EventHandler(this.reportCustomerToolStripMenuItem_Click);
            // 
            // reportStaffToolStripMenuItem
            // 
            this.reportStaffToolStripMenuItem.Name = "reportStaffToolStripMenuItem";
            this.reportStaffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.reportStaffToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.reportStaffToolStripMenuItem.Text = "Report Staff";
            this.reportStaffToolStripMenuItem.Click += new System.EventHandler(this.reportStaffToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 501);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}