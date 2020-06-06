using LogisticAppDAL;
using LogisticAppDAL.Entities;
using LogisticAppUI.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class PurchasingForm : Form
    {
        public PurchasingForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }
        LogisticDbContext dbContext = new LogisticDbContext();
        List<ItemViewModel> data = new List<ItemViewModel>();
        decimal Total_Amount = 0, Balance_Amount = 0;
        private void PurcashingForm_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            Date_txt.Text = DateTime.Now.ToShortDateString();

            venderBindingSource.DataSource = dbContext.Venders.ToList<Vender>();
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
                //dataGridView1.Rows.RemoveAt(e.RowIndex);
                var item = data.Where(x => x.I_ID == id).FirstOrDefault();

                this.Total_Amount -= (decimal)row.Cells[6].Value;
                this.Total_txt.Text = Total_Amount.ToString();

                data.Remove(item);
                dataGridView1.DataSource = data.ToList();

            }
           
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Purchase_Bill Purchase_Bill = new Purchase_Bill();
            Purchase_Bill.PO_ID = (int)PONo_txt.SelectedValue;
            Purchase_Bill.Date = Date_txt.Value;
            Purchase_Bill.V_ID = (int)Vender_txt.SelectedValue;
            Purchase_Bill.Total = this.Total_Amount;
            Purchase_Bill.Balance = this.Balance_Amount;
            Purchase_Bill.items = ((List<ItemViewModel>)dataGridView1.DataSource)
           .Select(x => new Purchase_Bill_Item()
           {
               Item_ID = x.I_ID,
               item = dbContext.Items.Where(y => y.I_ID == x.I_ID).FirstOrDefault(),
               Quantity = x.Quantity,
               Purchase_Amount = x.Quoted_Amount
           }).ToList();

            dbContext.Purchase_Bills.Add(Purchase_Bill);
            dbContext.SaveChanges();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Purchase_Bill_Item item = new Purchase_Bill_Item();
        //    item.Item_ID = (int)Item_txt.SelectedValue;
        //    item.Quantity = int.Parse(Quantity_txt.Text);
        //    item.Purchase_Amount = int.Parse(Rate_txt.Text);
        //    item.item = (Item)Item_txt.SelectedItem;
        //    Purchase_Bill_Items.Add(item);

        //    Item _item = dbContext.Items.Where(x => x.I_ID == item.Item_ID).FirstOrDefault();
        //    var rowTotal = item.Quantity * item.Purchase_Amount;
        //    this.Purchase_Bill.Total += rowTotal;
        //    this.Total_txt.Text = this.Purchase_Bill.Total.ToString();
        //    dataGridView1.Rows.Add(item.Item_ID, _item.Name, _item.Unit, _item.Description, item.Quantity, item.Purchase_Amount, rowTotal);
        //}

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void Pay_txt_TextChanged(object sender, EventArgs e)
        {
            this.Balance_Amount = (this.Total_Amount - Convert.ToDecimal(Pay_txt.Text));
            Balance_txt.Text = Balance_Amount.ToString();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4|| e.ColumnIndex ==5)
            {
                var row = ((DataGridView)sender).Rows[e.RowIndex];
                row.Cells[6].Value = (decimal)row.Cells[4].Value * (int)row.Cells[5].Value;
                Total_Amount = dataGridView1.Rows
                              .OfType<DataGridViewRow>()
                              .Sum(r => (decimal)r.Cells[6].Value);
                Total_txt.Text = Total_Amount.ToString();
            }
        }

        private void PONo_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = (int)PONo_txt.SelectedValue;
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
                              Total = x.Quantity * x.PO_Amount
                          })
                          .ToList();
                Total_Amount = data.Sum(x => x.Quantity * x.Quoted_Amount);
                Total_txt.Text = Total_Amount.ToString();
                dataGridView1.DataSource = data;
            }
            catch  
            {

            }
        }
    }
}
