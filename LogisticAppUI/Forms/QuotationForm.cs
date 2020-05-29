using LogisticAppDAL;
using LogisticAppDAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class QuotationForm : Form
    {
        public QuotationForm()
        {
            InitializeComponent();
        }
        LogisticDbContext dbContext = new LogisticDbContext();
        Quotation quotation = new Quotation() ;
        List<Quotation_Item> Quotation_Items = new List<Quotation_Item>();
        private void QuotationForm_Load(object sender, EventArgs e)
        {
            QDate_txt.Text = DateTime.Now.ToShortDateString();
            Qno_txt.Text =( "QNo#"+(dbContext.Quotations.Count()+ 1).ToString());

            itemBindingSource.DataSource = dbContext.Items.ToList<Item>();
            companyBindingSource.DataSource = dbContext.Companies.ToList<Company>();

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
                int rowIndex =e. RowIndex;
                DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];
                var id = (int)row.Cells[0].Value;
                Quotation_Items.Remove(Quotation_Items.Where(x => x.Item_ID == id).FirstOrDefault());
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }

        }



        private void Save_btn_Click(object sender, EventArgs e)
        {
            Quotation quotation = new Quotation();
            quotation.Q_No = Qno_txt.Text;
            quotation.Q_Date = QDate_txt.Value;
            quotation.Company_ID = (int)Company_txt.SelectedValue;

            dbContext.Quotations.Add(quotation);
            dbContext.SaveChanges();

            var id = quotation.Q_ID;

            Quotation_Items.ForEach(x => x.Q_ID = id);
            dbContext.Quotation_Items.AddRange(Quotation_Items);
            dbContext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quotation_Item item = new Quotation_Item();
            item.Item_ID = (int)Item_txt.SelectedValue;
            item.Quantity = int.Parse(Quantity_txt.Text);
            item.Quoted_Amount = int.Parse(Rate_txt.Text);
            item.item =(Item) Item_txt.SelectedItem;
            Quotation_Items.Add(item);

            Item _item = dbContext.Items.Where(x => x.I_ID == item.Item_ID).FirstOrDefault();
            dataGridView1.Rows.Add(item.Item_ID,_item.Name,_item.Unit,_item.Description,item.Quantity,item.Quoted_Amount);
        }

        private void Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void Item_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
