using LogisticAppDAL;
using LogisticAppDAL.Entities;
using LogisticAppUI.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class POForm : Form
    {
        public POForm()
        {
            InitializeComponent();

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }
        LogisticDbContext dbContext = new LogisticDbContext();
        List<ItemViewModel> data = new List<ItemViewModel>();
        private void QNo_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (int)QNo_txt.SelectedValue;
              data = dbContext.Quotation_Items
                        .Where(x => x.Q_ID == id).
                        Include(x => x.item).
                        Select(x => new ItemViewModel()
                        {
                            I_ID = x.Item_ID,
                            Name = x.item.Name,
                            Unit = x.item.Unit,
                            Description = x.item.Description,
                            Quantity = x.Quantity,
                            Quoted_Amount = x.Quoted_Amount,

                        })
                        .ToList();

            dataGridView1.DataSource = data;

       
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int rowIndex =e. RowIndex;
                DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];
                var id = (int)row.Cells[0].Value;
                data.Remove(data.Where(x => x.I_ID == id).FirstOrDefault());
                dataGridView1.DataSource = data.ToList();
            }

        }

        private void POForm_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            quotationBindingSource.DataSource = dbContext.Quotations.ToList();
            PO_txt.Text = ("PO#" + (dbContext.POs.Count() + 1).ToString());
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            PO pO = new PO();
            pO.PO_No = PO_txt.Text;
            pO.PO_Date = QDate_txt.Value;
            pO.Q_ID = (int)QNo_txt.SelectedValue;

            pO.PO_Items=((List<ItemViewModel>)dataGridView1.DataSource)
            .Select(x => new PO_Item()
            {
                Item_ID = x.I_ID,
                item = dbContext.Items.Where(y=>y.I_ID==x.I_ID).FirstOrDefault(),
                Quantity = x.Quantity,
                PO_Amount = x.Quoted_Amount
            }).ToList();

            dbContext.POs.Add(pO);
            dbContext.SaveChanges();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
