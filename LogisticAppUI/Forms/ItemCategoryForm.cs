using LogisticAppDAL;
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
        public ItemCategoryForm()
        {
            InitializeComponent();
            dbContext = new LogisticAppDAL.LogisticDbContext();
            Refresh();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Name";
         
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);

            dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

        }
        LogisticAppDAL.LogisticDbContext dbContext;

        private void button1_Click(object sender, EventArgs e)
        {
            Item_Category item_Category= new Item_Category();
            item_Category.Name = Name_txt.Text;

            dbContext.Item_Categories.Add(item_Category);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }
        public void Refresh()
        {
            dataGridView1.DataSource = dbContext.Item_Categories.ToList<Item_Category>();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = senderGrid.Rows[rowIndex];
                var id = (int)row.Cells[1].Value;
                var data = dbContext.Item_Categories.Where(x => x.IC_ID == id).FirstOrDefault();
                dbContext.Remove(data);
                dbContext.SaveChanges();
                Refresh();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Item_Category item_Category = (Item_Category)dataGridView1.CurrentRow.DataBoundItem;
            dbContext.Update<Item_Category>(item_Category);
            dbContext.SaveChanges();
        }
        public void ClearTextBox()
        {
            Name_txt.Clear();
        }
    }
}
