using LogisticAppDAL.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogisticAppUI.Forms
{
    public partial class PaymentInnForm : Form
    {
        public PaymentInnForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }
        LogisticAppDAL.LogisticDbContext dbContext = new LogisticAppDAL.LogisticDbContext();
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

        private void Save_btn_Click(object sender, EventArgs e)
        {
            PaymentInn payment = new PaymentInn();

            payment.Invoice_ID = (int)Invoice_txt.SelectedValue;
            payment.Amount = Convert.ToDecimal(Amount_txt.Text);
            payment.Date = Date_txt.Value;
            payment.Tax = Convert.ToDecimal(Tax_txt.Text);
            payment.Method = Method_txt.Text;

            payment.Cheque_No = Cheque_txt.Text;
            payment.Cheque_Date = ChequeDate_txt.Value;

            payment.Deposit_Person = DepositPerson_txt.Text;
            payment.Deposit_Date = DepositDate_txt.Value;
            payment.Deposit_Slip_No = DepositSlip_txt.Text;

            dbContext.PaymentInns.Add(payment);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }
        public void Refresh()
        {
            dataGridView1.DataSource = dbContext.PaymentInns.ToList<PaymentInn>();
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
        public void ClearTextBox()
        {
            Amount_txt.Clear();
            ChequeDate_txt.Value = DateTime.Now;
            Cheque_txt.Clear();
            Date_txt.Value = DateTime.Now;
            DepositDate_txt.Value = DateTime.Now;
            DepositPerson_txt.Clear();
            DepositSlip_txt.Clear();
            Invoice_txt.Text = "";
            Method_txt.Text = "";
            Tax_txt.Clear();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
        private void Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void PaymentInnForm_Load(object sender, EventArgs e)
        {
            Utility.FormSetting(this, groupBox1);
            invoiceBindingSource.DataSource = dbContext.Invoices.ToList<Invoice>();
            paymentInnBindingSource.DataSource = dbContext.PaymentInns.ToList();
            //var ddata = (from a in dbContext.PaymentInns
            //                                      select new PaymentInn()
            //                                      {
            //                                          Invoice_ID = a.Invoice_ID,
            //                                          Amount = a.Amount,
            //                                          Date = a.Date,
            //                                          Tax = a.Tax,
            //                                          Method = a.Method,
            //                                          Cheque_No = a.Cheque_No,
            //                                          Cheque_Date = a.Cheque_Date,
            //                                          Deposit_Person = a.Deposit_Person,
            //                                          Deposit_Slip_No = a.Deposit_Slip_No,
            //                                          Deposit_Date = a.Deposit_Date
            //                                      }).ToList();
        }

        private void Invoice_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)Invoice_txt.SelectedValue;
            var total = dbContext.Invoice_Items.Where(x => x.Invoice_ID == id).Sum(x => x.Quantity * x.Amount);
            Amount_txt.Text = total.ToString();
        }
    }
}
