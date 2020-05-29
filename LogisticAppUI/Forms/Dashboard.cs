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
            this.Hide();

            ItemForm itemForm= new ItemForm();
            itemForm.ShowDialog();
            this.Close();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ItemCategoryForm itemCategoryForm  =new ItemCategoryForm();
            itemCategoryForm.ShowDialog();

            this.Close();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            CompanyForm itemCategoryForm = new CompanyForm();
            itemCategoryForm.ShowDialog();

            this.Close();
        }

        private void quotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showQuotationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            QuotationDetail quotationForm = new QuotationDetail();
            quotationForm.ShowDialog();

            this.Close();
        }

        private void addQuotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            QuotationForm quotationForm = new QuotationForm();
            quotationForm.ShowDialog();

            this.Close();
        }
    }
}
