namespace LogisticAppUI.Forms
{
    partial class Dashboard
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
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCatgoeryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showQuotationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.quotationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCatgoeryToolStripMenuItem,
            this.itemToolStripMenuItem1,
            this.companyToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.itemToolStripMenuItem.Text = "General";
            // 
            // itemCatgoeryToolStripMenuItem
            // 
            this.itemCatgoeryToolStripMenuItem.Name = "itemCatgoeryToolStripMenuItem";
            this.itemCatgoeryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.itemCatgoeryToolStripMenuItem.Text = "Item";
            this.itemCatgoeryToolStripMenuItem.Click += new System.EventHandler(this.itemCatgoeryToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem1
            // 
            this.itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            this.itemToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.itemToolStripMenuItem1.Text = "Item Catgoery";
            this.itemToolStripMenuItem1.Click += new System.EventHandler(this.itemToolStripMenuItem1_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // quotationToolStripMenuItem
            // 
            this.quotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuotationToolStripMenuItem,
            this.showQuotationsToolStripMenuItem});
            this.quotationToolStripMenuItem.Name = "quotationToolStripMenuItem";
            this.quotationToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.quotationToolStripMenuItem.Text = "Quotation";
            this.quotationToolStripMenuItem.Click += new System.EventHandler(this.quotationToolStripMenuItem_Click);
            // 
            // addQuotationToolStripMenuItem
            // 
            this.addQuotationToolStripMenuItem.Name = "addQuotationToolStripMenuItem";
            this.addQuotationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addQuotationToolStripMenuItem.Text = "Add Quotation ";
            this.addQuotationToolStripMenuItem.Click += new System.EventHandler(this.addQuotationToolStripMenuItem_Click);
            // 
            // showQuotationsToolStripMenuItem
            // 
            this.showQuotationsToolStripMenuItem.Name = "showQuotationsToolStripMenuItem";
            this.showQuotationsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showQuotationsToolStripMenuItem.Text = "Show Quotations";
            this.showQuotationsToolStripMenuItem.Click += new System.EventHandler(this.showQuotationsToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCatgoeryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showQuotationsToolStripMenuItem;
    }
}