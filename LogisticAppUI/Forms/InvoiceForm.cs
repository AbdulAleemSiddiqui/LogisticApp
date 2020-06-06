using LogisticAppDAL;
using LogisticAppDAL.Entities;
using LogisticAppUI.Helper;
using Microsoft.EntityFrameworkCore;
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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }
        LogisticDbContext dbContext = new LogisticDbContext();

        private void DC_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DC_txt.SelectedValue != null)
            {
                var id = (int)DC_txt.SelectedValue;
                var data = dbContext.Delivery_Chalan_Items
                          .Where(x => x.DC_ID == id)
                          .Include(x => x.item)
                          .Select(x => new ItemViewModel()
                          {
                              I_ID = x.Item_ID,
                              Name = x.item.Name,
                              Unit = x.item.Unit,
                              Description = x.item.Description,
                              Quantity = x.Quantity,
                              Quoted_Amount = x.Amount,
                              Total = x.Amount * x.Quantity
                          })
                          .ToList();

                dataGridView1.DataSource = data;
            }
        }

        private void Company_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (int)Company_txt.SelectedValue;
            var data = dbContext.POs
                .Include(x => x.quotation)
                .ToList<PO>()
                .Where(x => x.quotation.Company_ID == id);
            if (data.Count() > 0)
            {
                pOBindingSource.DataSource = data;
            }
            else
            {
                pOBindingSource.DataSource = null;
                MessageBox.Show("Purchase Order for this Company not exsist");
            }
        }

        private void PO_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PO_txt.SelectedValue != null)
            {
                var id = (int)PO_txt.SelectedValue;
                var data = dbContext.Delivery_Chalans
                    .Include(x => x.po)
                    .ToList<Delivery_Chalan>()
                    .Where(x => x.po.PO_ID == id);
                if (data.Count() > 0)
                {
                    deliveryChalanBindingSource.DataSource = data;
                }
                else
                {
                    deliveryChalanBindingSource.DataSource = null;
                    MessageBox.Show("Delivery Challan for this Purchase Order not exsist");
                }
            }
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            Date_txt.Text = DateTime.Now.ToShortDateString();
            Ino_txt.Text = ("INo#" + (dbContext.Invoices.Count() + 1).ToString());

            itemBindingSource.DataSource = dbContext.Items.ToList<Item>();
            companyBindingSource.DataSource = dbContext.Companies.ToList<Company>();
           //pOBindingSource.DataSource = dbContext.POs.ToList<PO>();
           //deliveryChalanBindingSource.DataSource = dbContext.Delivery_Chalans.ToList();

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
           invoice.I_No= Ino_txt.Text;
           invoice.PO_ID = (int)PO_txt.SelectedValue;
           invoice.DC_ID = (int)DC_txt.SelectedValue;
            invoice.Date = Date_txt.Value;


            dbContext.Invoices.Add(invoice);
            dbContext.SaveChanges();

            var data = ((List<ItemViewModel>)dataGridView1.DataSource)
            .Select(x => new Invoice_Item()
            {
                Item_ID = x.I_ID,
                Invoice_ID= invoice.Invoice_ID,
                Invoice= invoice,
                Item= dbContext.Items.Where(y => y.I_ID == x.I_ID).FirstOrDefault(),
                Quantity = x.Quantity,
                Amount = x.Quoted_Amount
            }).ToList();
            dbContext.Invoice_Items.AddRange(data);
            dbContext.SaveChanges();
        }
    }
}
