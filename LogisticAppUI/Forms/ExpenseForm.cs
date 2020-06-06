using LogisticAppDAL.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();

            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

            var category = dbContext.Expense_Category.ToList<Expense_Category>();
            if (category.Count() != 0)
            {
                Category_txt.DataSource = category;
                Category_txt.ValueMember = "Exp_Cat_ID";
                Category_txt.DisplayMember = "Exp_Cat_Name";
            }
            else
            {
                MessageBox.Show("Please Fill Item Category First");
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
                var data = dbContext.Expense.Where(x => x.Exp_ID == id).FirstOrDefault();
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
        LogisticAppDAL.LogisticDbContext dbContext = new LogisticAppDAL.LogisticDbContext();
        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            Refresh();
            Utility.FormSetting(this , groupBox1);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Expense item = new Expense();
            item.Person = Name_txt.Text;
            item.Date = Date_txt.Value;
            item.Amount = Convert.ToDecimal(Amount_txt.Text);
            item.Description = Description_txt.Text;
            item.Exp_Cat_ID = Convert.ToInt32(Category_txt.SelectedValue);

            dbContext.Expense.Add(item);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }
        public void ClearTextBox()
        {
            Name_txt.Clear();
            Date_txt.Text = "";
            Amount_txt.Text = string.Empty;
            Description_txt.Clear();
            Category_txt.Text = "";
        }

        public void Refresh()
        {
            expenseBindingSource.DataSource = dbContext.Expense.ToList<Expense>();
            expenseCategoryBindingSource.DataSource = dbContext.Expense_Category.ToList<Expense_Category>();
        }
    }
}
