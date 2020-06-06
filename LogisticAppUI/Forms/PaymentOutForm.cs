using LogisticAppDAL.Entities;
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
    public partial class PaymentOutForm : Form
    {
        public PaymentOutForm()
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
        LogisticAppDAL.LogisticDbContext dbContext = new LogisticAppDAL.LogisticDbContext();
        private void PaymenyOutForm_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            Refresh();
            venderBindingSource.DataSource = dbContext.Venders.ToList();
            paymentOutBindingSource.DataSource = dbContext.PaymentInns.ToList();
        }
        private void Method_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Method_txt.Text.ToLower() == "cheque")
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Utility.GetIdFromGrid((DataGridView)sender, e.ColumnIndex, e.RowIndex);
            if (id > 0)
            {

                var data = dbContext.PaymentInns.Where(x => x.P_ID == id).FirstOrDefault();
                dbContext.Remove(data);
                dbContext.SaveChanges();
                Refresh();
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Utility.Update(dataGridView1);
            }
            catch
            {

            }
        }
        public void Refresh()
        {
            dataGridView1.DataSource = dbContext.PaymentOuts.ToList<PaymentOut>();
        }
        private void Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            PaymentOut payment = new PaymentOut();

            payment.Vendor_ID = (int)Vender_txt.SelectedValue;
            payment.Reason = Reason_txt.Text;
            payment.Amount = Convert.ToDecimal(Amount_txt.Text);
            payment.Date = Date_txt.Value;
            payment.Method = Method_txt.Text;

            payment.Cheque_No = Cheque_txt.Text;
            payment.Cheque_Date = ChequeDate_txt.Value;


            dbContext.PaymentOuts.Add(payment);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }
        public void ClearTextBox()
        {
            Amount_txt.Clear();
            ChequeDate_txt.Value = DateTime.Now;
            Cheque_txt.Clear();
            Date_txt.Value = DateTime.Now;
            Vender_txt.Text = "";
            Method_txt.Text = "";
            Reason_txt.Clear();
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
        private void Vender_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)Vender_txt.SelectedValue;
            var total = dbContext.Purchase_Bills
                .Where(x => x.V_ID== id)
                .Sum(x => x.Balance);
            Amount_txt.Text = total.ToString();
        }

    }
}
