using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void itemCatgoeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new ItemForm());
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Open(new ItemCategoryForm());
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new CompanyForm());
        }

        private void quotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void showQuotationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new QuotationDetail());
        }

        private void addQuotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new QuotationForm());
        }

        private void addPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new POForm());
        }

        private void showPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new PODetail());
        }

        private void purchaseBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new PurchasingForm());
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new PurchasingDetailForm());
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new VendorForm());
        }

        private void deliveryChallanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Open(new DeliveryChallanForm());

        }

        private void showDeliveryChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new DeliveryChallanDetailForm());

        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new InvoiceForm());

        }

        private void showInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new InvoiceDetailForm());

        }

        private void paymentInnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new PaymentInnForm());

        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Open(new ExpenseForm());
            
            //this.Close();
        }

        private void expenseCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new ExpenseCategoryForm());
        }

        private void paymentOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(new PaymentOutForm());

        }

        public void Open(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form);
            form.Show();
        }
    }
    
}
