using LogisticAppDAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
            dbContext = new LogisticAppDAL.LogisticDbContext();
            Refresh();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "Contact";

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
            Company company = new Company();
            company.C_Name = C_Name_txt.Text;
            company.C_Address = C_Address_txt.Text;
            company.C_Contact = C_Contact_txt.Text;

            dbContext.Companies.Add(company);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }
        public void Refresh()
        {
            dataGridView1.DataSource = dbContext.Companies.ToList<Company>();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
      
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = senderGrid.Rows[rowIndex];
                var id =(int) row.Cells[1].Value;
                var data = dbContext.Companies.Where(x => x.C_ID ==id).FirstOrDefault();
                dbContext.Remove(data);
                dbContext.SaveChanges();
                Refresh();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Company company = (Company)dataGridView1.CurrentRow.DataBoundItem;
            dbContext.Update<Company>(company);
            dbContext.SaveChanges();
        }
        public void ClearTextBox()
        {
            C_Name_txt.Clear();
            C_Address_txt.Clear();
            C_Contact_txt.Clear();
        }
    }
}
