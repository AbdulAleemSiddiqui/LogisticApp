using LogisticAppDAL;
using LogisticAppDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class PODetail : Form
    {
        public PODetail()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            dataGridView2.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
        }
        LogisticDbContext dbContext = new LogisticDbContext();

        private void PODetail_Load(object sender, EventArgs e)
        {
            var data = from t1 in dbContext.POs
            join t2 in dbContext.Quotations on t1.Q_ID equals t2.Q_ID
            join t3 in dbContext.Companies on t2.Company_ID equals t3.C_ID
            select new { t1.PO_ID, t1.PO_No, t1.PO_Date, t2.Q_No, t3.C_Name };

            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "PO #";
            dataGridView1.Columns[2].HeaderText = "PO Date";
            dataGridView1.Columns[3].HeaderText = "Quotation #";
            dataGridView1.Columns[4].HeaderText = "Company";
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
                var id = ((int)dataGridView1.CurrentRow.Cells[0].Value);
                var data = dbContext.PO_Items.Where(x => x.PO_ID == id).Include(x => x.item)
                    .Select(x => new
                    {
                        Item_Name = x.item.Name,
                        x.item.Unit,
                        x.item.Description,
                        x.Quantity,
                        x.PO_Amount
                    }).ToList();
                dataGridView2.DataSource = data;
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
