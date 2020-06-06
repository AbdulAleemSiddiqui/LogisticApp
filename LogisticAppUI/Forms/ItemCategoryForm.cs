using LogisticAppDAL;
using LogisticAppDAL.Entities;
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
    public partial class ItemCategoryForm : Form
    {
        LogisticAppDAL.LogisticDbContext dbContext;
        public ItemCategoryForm()
        {
            InitializeComponent();
            dbContext = new LogisticAppDAL.LogisticDbContext();
            Refresh();
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id=Utility.GetIdFromGrid((DataGridView)sender, e.ColumnIndex, e.RowIndex);
            if (id>0)
            {
                var data = dbContext.Item_Categories.Where(x => x.IC_ID == id).FirstOrDefault();
                dbContext.Remove(data);
                dbContext.SaveChanges();
                Refresh();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Utility.Update(dataGridView1);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Item_Category item_Category = new Item_Category();
            item_Category.Name = Name_txt.Text;

            dbContext.Item_Categories.Add(item_Category);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }

        public void ClearTextBox()
        {
            Name_txt.Clear();
        }


        public void Refresh()
        {
            itemCategoryBindingSource.DataSource = dbContext.Item_Categories.ToList<Item_Category>();
        }


        private void ItemCategoryForm_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            itemCategoryBindingSource.DataSource = dbContext.Item_Categories.ToList<Item_Category>();
        }
    }
}
