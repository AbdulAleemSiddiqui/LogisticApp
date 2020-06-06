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
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }
        LogisticAppDAL.LogisticDbContext dbContext;

       
        public void Refresh()
        {
            dataGridView1.DataSource = dbContext.Venders.ToList<Vender>();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Utility.GetIdFromGrid((DataGridView)sender, e.ColumnIndex, e.RowIndex);
            if (id > 0)
            {

                var data = dbContext.Venders.Where(x => x.V_ID== id).FirstOrDefault();
                dbContext.Remove(data);
                dbContext.SaveChanges();
                Refresh();
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Utility.Update(dataGridView1);
        }
        public void ClearTextBox()
        {
            Name_txt.Clear();
            Address_txt.Clear();
            Company_txt.Clear();
            Contact_txt.Clear();
            Email_txt.Clear();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            dbContext = new LogisticAppDAL.LogisticDbContext();
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            Refresh();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Vender vender = new Vender();
            vender.Name = Name_txt.Text;
            vender.Company= Company_txt.Text;
            vender.Address= Address_txt.Text;
            vender.Contact= Contact_txt.Text;
            vender.Email = Email_txt.Text;
            dbContext.Venders.Add(vender);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }

        private void Back_btn_Click_1(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
