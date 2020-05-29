using LogisticAppDAL;
using LogisticAppDAL.Entities;
using LogisticAppUI.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class ItemForm : Form
    {
        LogisticAppDAL.LogisticDbContext dbContext;

        public ItemForm()
        {
            InitializeComponent();
            dbContext = new LogisticAppDAL.LogisticDbContext();
            Refresh();
           // ConfigureGrid();

            var category = dbContext.Item_Categories.ToList<Item_Category>();
            if (category.Count() != 0)
            {
                Category_txt.DataSource = category;
                Category_txt.ValueMember = "IC_ID";
                Category_txt.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("Please Fill Item Category First");
                this.Close();
            }
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Utility.GetIdFromGrid((DataGridView)sender, e.ColumnIndex, e.RowIndex);
            if (id > 0)
            {
                var data = dbContext.Items.Where(x => x.I_ID == id).FirstOrDefault();
                dbContext.Remove(data);
                dbContext.SaveChanges();
                Refresh();
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Utility.Update(dataGridView1);
        }

        private void Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = dbContext.Items.ToList<Item>();
            itemCategoryBindingSource.DataSource = dbContext.Item_Categories.ToList<Item_Category>();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = Name_txt.Text;
            item.Code = Code_txt.Text;
            item.Unit = Unit_txt.Text;
            item.Description = Description_txt.Text;
            item.Quantity = Convert.ToInt32(Quantity_txt.Text);
            item.IC_ID = Convert.ToInt32(Category_txt.SelectedValue);

            dbContext.Items.Add(item);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }

        public void ClearTextBox()
        {
            Name_txt.Clear();
            Code_txt.Clear();
            Unit_txt.Text = string.Empty;
            Description_txt.Clear();
            Quantity_txt.Clear();
        }
        
        public void Refresh()
        {
            itemBindingSource.DataSource = dbContext.Items.ToList<Item>();
            itemCategoryBindingSource.DataSource = dbContext.Item_Categories.ToList<Item_Category>();
        }
    }
}
