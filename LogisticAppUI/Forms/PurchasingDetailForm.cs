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
    public partial class PurchasingDetailForm : Form
    {
        public PurchasingDetailForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            dataGridView2.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
        }
        LogisticDbContext dbContext = new LogisticDbContext();

        private void PurchasingDetailForm_Load(object sender, EventArgs e)
        {
            purchaseBillBindingSource.DataSource = dbContext.Purchase_Bills
                .Include(x=>x.po)
                .ToList<Purchase_Bill>()
                .Select(x=>new {
                    PB_ID=x.PB_ID,
                   V_ID= x.V_ID,
                    PO_ID= x.po==null ? "Empty":x.po.PO_No,
                    x.Date,
                    Paid=x.Total-x.Balance,
                    x.Balance,
                    x.Total
                });
            itemBindingSource.DataSource = dbContext.Items.ToList<Item>();
            venderBindingSource.DataSource = dbContext.Venders.ToList<Vender>();
            pOBindingSource.DataSource = dbContext.POs.ToList<PO>();

            //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //col.UseColumnTextForButtonValue = true;
            //col.Text = "Report";
            //col.Name = "Report";
            //dataGridView1.Columns.Add(col);
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
                var id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                var data = dbContext.Purchase_Bill_Items.Where(x => x.PB_ID == id).Include(x => x.item)
                    .Select(x => new {
                        Item= x.item.Name,
                        x.item.Unit,
                        x.item.Description,
                        x.Quantity,
                        Rate=x.Purchase_Amount,
                        Total=x.Quantity*x.Purchase_Amount
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
