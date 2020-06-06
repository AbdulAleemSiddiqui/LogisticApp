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
    public partial class DeliveryChallanForm : Form
    {
        public DeliveryChallanForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }

        LogisticDbContext dbContext = new LogisticDbContext();
        List<ItemViewModel> data = new List<ItemViewModel>();
        private void DeliveryChallanForm_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            Date_txt.Text = DateTime.Now.ToShortDateString();
            DCno_txt.Text = ("DCNo#" + (dbContext.Delivery_Chalans.Count() + 1).ToString());

            itemBindingSource.DataSource = dbContext.Items.ToList<Item>();
            companyBindingSource.DataSource = dbContext.Companies.ToList<Company>();
            pOBindingSource.DataSource = dbContext.POs.ToList<PO>();

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
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
                data.Remove(data.Where(x => x.I_ID == id).FirstOrDefault());
                //dataGridView1.Rows.RemoveAt(e.RowIndex);
                dataGridView1.DataSource = data.ToList();

            }

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Delivery_Chalan Delivery_Chalan = new Delivery_Chalan();
            Delivery_Chalan.DC_No= DCno_txt.Text;
            Delivery_Chalan.Date = Date_txt.Value;
            Delivery_Chalan.Company_ID = (int)Company_txt.SelectedValue;
            Delivery_Chalan.PO_ID = (int)PO_txt.SelectedValue;

            Delivery_Chalan.items= ((List<ItemViewModel>)dataGridView1.DataSource)
            .Select(x => new Delivery_Chalan_Item()
            {
                Item_ID = x.I_ID,
                item = dbContext.Items.Where(y => y.I_ID == x.I_ID).FirstOrDefault(),
                Quantity = x.Quantity,
                Amount = x.Quoted_Amount
            }).ToList();

            dbContext.Delivery_Chalans.Add(Delivery_Chalan);
            dbContext.SaveChanges();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void Company_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = (int)Company_txt.SelectedValue;
                pOBindingSource.DataSource = dbContext.POs
                    .Include(x => x.quotation)
                    .ToList<PO>()
                    .Where(x => x.quotation.Company_ID == id);
            }
            catch
            {

            }

        }

        private void PO_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (int)PO_txt.SelectedValue;
            data = dbContext.PO_Items
                      .Where(x => x.PO_ID == id).
                      Include(x => x.item).
                      Select(x => new ItemViewModel()
                      {
                          I_ID = x.Item_ID,
                          Name = x.item.Name,
                          Unit = x.item.Unit,
                          Description = x.item.Description,
                          Quantity = x.Quantity,
                          Quoted_Amount = x.PO_Amount,

                      })
                      .ToList();

            dataGridView1.DataSource = data;


        }
    }
}
