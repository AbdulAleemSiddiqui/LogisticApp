using LogisticAppDAL;
using LogisticAppDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class QuotationDetail : Form
    {
        public QuotationDetail()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            dataGridView2.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
        }
        LogisticDbContext dbContext = new LogisticDbContext();

        private void QuotationDetail_Load(object sender, EventArgs e)
        {
            quotationBindingSource.DataSource = dbContext.Quotations.ToList<Quotation>();
            companyBindingSource.DataSource = dbContext.Companies.ToList<Company>();

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

                ReportForm reportForm = new ReportForm();
                reportForm.ShowDialog();
            }
            else
            {
                var id = ((Quotation)dataGridView1.CurrentRow.DataBoundItem).Q_ID;
                var data = dbContext.Quotation_Items.Where(x => x.Q_ID == id).Include(x=>x.item)
                    .Select(x=>new {
                        Item_Name= x.item.Name,
                        x.item.Unit,
                        x.item.Description,
                        x.Quantity,
                        x.Quoted_Amount
                    }).ToList();
                dataGridView2.DataSource = data;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
