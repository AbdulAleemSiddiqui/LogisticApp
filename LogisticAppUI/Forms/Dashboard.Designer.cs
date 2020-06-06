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
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryChallanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryChallanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDeliveryChallanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentInnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.quotationToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.purchasingToolStripMenuItem,
            this.deliveryChallanToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.expenseToolStripMenuItem});
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
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPOToolStripMenuItem,
            this.showPOToolStripMenuItem});
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // addPOToolStripMenuItem
            // 
            this.addPOToolStripMenuItem.Name = "addPOToolStripMenuItem";
            this.addPOToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addPOToolStripMenuItem.Text = "Add PO";
            this.addPOToolStripMenuItem.Click += new System.EventHandler(this.addPOToolStripMenuItem_Click);
            // 
            // showPOToolStripMenuItem
            // 
            this.showPOToolStripMenuItem.Name = "showPOToolStripMenuItem";
            this.showPOToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.showPOToolStripMenuItem.Text = "Show PO";
            this.showPOToolStripMenuItem.Click += new System.EventHandler(this.showPOToolStripMenuItem_Click);
            // 
            // purchasingToolStripMenuItem
            // 
            this.purchasingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseBillToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.vendorsToolStripMenuItem});
            this.purchasingToolStripMenuItem.Name = "purchasingToolStripMenuItem";
            this.purchasingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.purchasingToolStripMenuItem.Text = "Purchasing";
            // 
            // purchaseBillToolStripMenuItem
            // 
            this.purchaseBillToolStripMenuItem.Name = "purchaseBillToolStripMenuItem";
            this.purchaseBillToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.purchaseBillToolStripMenuItem.Text = "Add Purchase Bill";
            this.purchaseBillToolStripMenuItem.Click += new System.EventHandler(this.purchaseBillToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.vendorToolStripMenuItem.Text = "Show Purchase Bill ";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            this.vendorsToolStripMenuItem.Click += new System.EventHandler(this.vendorsToolStripMenuItem_Click);
            // 
            // deliveryChallanToolStripMenuItem
            // 
            this.deliveryChallanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveryChallanToolStripMenuItem1,
            this.showDeliveryChallanToolStripMenuItem});
            this.deliveryChallanToolStripMenuItem.Name = "deliveryChallanToolStripMenuItem";
            this.deliveryChallanToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.deliveryChallanToolStripMenuItem.Text = "Delivery Challan";
            // 
            // deliveryChallanToolStripMenuItem1
            // 
            this.deliveryChallanToolStripMenuItem1.Name = "deliveryChallanToolStripMenuItem1";
            this.deliveryChallanToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.deliveryChallanToolStripMenuItem1.Text = "Add Delivery Challan";
            this.deliveryChallanToolStripMenuItem1.Click += new System.EventHandler(this.deliveryChallanToolStripMenuItem1_Click);
            // 
            // showDeliveryChallanToolStripMenuItem
            // 
            this.showDeliveryChallanToolStripMenuItem.Name = "showDeliveryChallanToolStripMenuItem";
            this.showDeliveryChallanToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showDeliveryChallanToolStripMenuItem.Text = "Show Delivery Challan";
            this.showDeliveryChallanToolStripMenuItem.Click += new System.EventHandler(this.showDeliveryChallanToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInvoiceToolStripMenuItem,
            this.showInvoicesToolStripMenuItem});
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // addInvoiceToolStripMenuItem
            // 
            this.addInvoiceToolStripMenuItem.Name = "addInvoiceToolStripMenuItem";
            this.addInvoiceToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addInvoiceToolStripMenuItem.Text = "Add Invoice";
            this.addInvoiceToolStripMenuItem.Click += new System.EventHandler(this.addInvoiceToolStripMenuItem_Click);
            // 
            // showInvoicesToolStripMenuItem
            // 
            this.showInvoicesToolStripMenuItem.Name = "showInvoicesToolStripMenuItem";
            this.showInvoicesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showInvoicesToolStripMenuItem.Text = "Show Invoices";
            this.showInvoicesToolStripMenuItem.Click += new System.EventHandler(this.showInvoicesToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentInnToolStripMenuItem,
            this.paymentOutToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // paymentInnToolStripMenuItem
            // 
            this.paymentInnToolStripMenuItem.Name = "paymentInnToolStripMenuItem";
            this.paymentInnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paymentInnToolStripMenuItem.Text = "Payment Inn";
            this.paymentInnToolStripMenuItem.Click += new System.EventHandler(this.paymentInnToolStripMenuItem_Click);
            // 
            // paymentOutToolStripMenuItem
            // 
            this.paymentOutToolStripMenuItem.Name = "paymentOutToolStripMenuItem";
            this.paymentOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paymentOutToolStripMenuItem.Text = "Payment Out";
            this.paymentOutToolStripMenuItem.Click += new System.EventHandler(this.paymentOutToolStripMenuItem_Click);
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenseToolStripMenuItem,
            this.expenseCategoryToolStripMenuItem});
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.expenseToolStripMenuItem.Text = "Expense";
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addExpenseToolStripMenuItem.Text = "Expense";
            this.addExpenseToolStripMenuItem.Click += new System.EventHandler(this.addExpenseToolStripMenuItem_Click);
            // 
            // expenseCategoryToolStripMenuItem
            // 
            this.expenseCategoryToolStripMenuItem.Name = "expenseCategoryToolStripMenuItem";
            this.expenseCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.expenseCategoryToolStripMenuItem.Text = "Expense Category";
            this.expenseCategoryToolStripMenuItem.Click += new System.EventHandler(this.expenseCategoryToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 411);
            this.panel1.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryChallanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryChallanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDeliveryChallanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentInnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseCategoryToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}