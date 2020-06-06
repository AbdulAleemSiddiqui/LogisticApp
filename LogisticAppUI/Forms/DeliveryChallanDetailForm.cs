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
    public partial class DeliveryChallanDetailForm : Form
    {
        public DeliveryChallanDetailForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left  );
            dataGridView2.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
        }
        LogisticDbContext dbContext = new LogisticDbContext();

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
                var id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                var data = dbContext.Delivery_Chalan_Items
                    .Where(x => x.DC_ID == id)
                    .Include(x => x.item)
                    .Select(x => new {
                        Item = x.item.Name,
                        x.item.Unit,
                        x.item.Description,
                        x.Quantity,
                        Rate = x.Amount,
                        Total = x.Quantity * x.Amount
                    }).ToList();
                dataGridView2.DataSource = data;
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void DeliveryChallanDetailForm_Load(object sender, EventArgs e)
        {

            deliveryChalanBindingSource.DataSource = dbContext.Delivery_Chalans
             .Include(x => x.po)
             .ToList<Delivery_Chalan>()
             .Select(x => new {
                 DC_ID = x.DC_ID,
                 DC_No = x.DC_No,
                 Company_ID = x.Company_ID,
                 x.PO_ID,
                 x.Date

             });
            itemBindingSource.DataSource = dbContext.Items.ToList<Item>();
            companyBindingSource.DataSource = dbContext.Companies.ToList<Company>();
            pOBindingSource.DataSource = dbContext.POs.ToList<PO>();

            //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //col.UseColumnTextForButtonValue = true;
            //col.Text = "Report";
            //col.Name = "Report";
            //dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

        }
    }
}
