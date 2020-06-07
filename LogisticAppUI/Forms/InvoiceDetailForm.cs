using LogisticAppDAL;
using LogisticAppDAL.Entities;
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
    public partial class InvoiceDetailForm : Form
    {
        public InvoiceDetailForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            dataGridView2.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
        LogisticDbContext dbContext = new LogisticDbContext();
        private void InvoiceDetailForm_Load(object sender, EventArgs e)
        {
            var data = from t1 in dbContext.Invoices
                       join t2 in dbContext.Delivery_Chalans on t1.DC_ID equals t2.DC_ID
                       join t3 in dbContext.POs on t2.PO_ID equals t3.PO_ID
                       join t4 in dbContext.Quotations on t3.Q_ID equals t4.Q_ID
                       join t5 in dbContext.Companies on t4.Company_ID equals t5.C_ID

                       select new { t1.Invoice_ID, t1.I_No, t1.Date, t2.DC_No,t3.PO_No,t4.Q_No, t5.C_Name };

            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Invoice #";
            dataGridView1.Columns[2].HeaderText = "Invoice Date";
            dataGridView1.Columns[3].HeaderText = "Challan #";
            dataGridView1.Columns[4].HeaderText = "PO #";
            dataGridView1.Columns[5].HeaderText = "Quotation #";
            dataGridView1.Columns[6].HeaderText = "Company";
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Report";
            col.Name = "Report";
            dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];
                var id = (int)row.Cells[0].Value;

                ReportForm reportForm = new ReportForm(id);
                reportForm.ShowDialog();
            }
            else
            {
                var id = ((int)dataGridView1.CurrentRow.Cells[1].Value);
                var data = dbContext.Invoice_Items.Where(x => x.Invoice_ID== id).Include(x => x.Item)
                    .Select(x => new
                    {
                        Item_Name = x.Item.Name,
                        x.Item.Unit,
                        x.Item.Description,
                        x.Quantity,
                        x.Amount,
                        Total=x.Amount*x.Quantity
                    }).ToList();
                dataGridView2.DataSource = data;
            }
        }

    }
}
