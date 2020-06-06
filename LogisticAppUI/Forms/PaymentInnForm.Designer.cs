namespace LogisticAppUI.Forms
{
    partial class PaymentInnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Invoice_txt = new System.Windows.Forms.ComboBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DepositDate_txt = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DepositSlip_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChequeDate_txt = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cheque_txt = new System.Windows.Forms.TextBox();
            this.DepositPerson_txt = new System.Windows.Forms.TextBox();
            this.Method_txt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tax_txt = new System.Windows.Forms.TextBox();
            this.Date_txt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositSlipNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentInnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(197, 169);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 14;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Invoice_txt
            // 
            this.Invoice_txt.DataSource = this.invoiceBindingSource;
            this.Invoice_txt.DisplayMember = "I_No";
            this.Invoice_txt.FormattingEnabled = true;
            this.Invoice_txt.Location = new System.Drawing.Point(115, 28);
            this.Invoice_txt.Name = "Invoice_txt";
            this.Invoice_txt.Size = new System.Drawing.Size(100, 21);
            this.Invoice_txt.TabIndex = 7;
            this.Invoice_txt.ValueMember = "Invoice_ID";
            this.Invoice_txt.SelectedIndexChanged += new System.EventHandler(this.Invoice_txt_SelectedIndexChanged);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Invoice);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepositDate_txt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DepositSlip_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.DepositPerson_txt);
            this.groupBox1.Controls.Add(this.Method_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Tax_txt);
            this.groupBox1.Controls.Add(this.Date_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Save_btn);
            this.groupBox1.Controls.Add(this.Invoice_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Amount_txt);
            this.groupBox1.Location = new System.Drawing.Point(151, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Inn";
            // 
            // DepositDate_txt
            // 
            this.DepositDate_txt.Location = new System.Drawing.Point(344, 139);
            this.DepositDate_txt.Name = "DepositDate_txt";
            this.DepositDate_txt.Size = new System.Drawing.Size(100, 20);
            this.DepositDate_txt.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Deposit Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Deposit Slip #";
            // 
            // DepositSlip_txt
            // 
            this.DepositSlip_txt.Location = new System.Drawing.Point(344, 114);
            this.DepositSlip_txt.Name = "DepositSlip_txt";
            this.DepositSlip_txt.Size = new System.Drawing.Size(100, 20);
            this.DepositSlip_txt.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Deposit Person";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChequeDate_txt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cheque_txt);
            this.groupBox2.Location = new System.Drawing.Point(230, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 69);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cheque";
            this.groupBox2.Visible = false;
            // 
            // ChequeDate_txt
            // 
            this.ChequeDate_txt.Location = new System.Drawing.Point(114, 44);
            this.ChequeDate_txt.Name = "ChequeDate_txt";
            this.ChequeDate_txt.Size = new System.Drawing.Size(100, 20);
            this.ChequeDate_txt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Cheque Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cheque #";
            // 
            // Cheque_txt
            // 
            this.Cheque_txt.Location = new System.Drawing.Point(114, 18);
            this.Cheque_txt.Name = "Cheque_txt";
            this.Cheque_txt.Size = new System.Drawing.Size(100, 20);
            this.Cheque_txt.TabIndex = 25;
            // 
            // DepositPerson_txt
            // 
            this.DepositPerson_txt.Location = new System.Drawing.Point(344, 88);
            this.DepositPerson_txt.Name = "DepositPerson_txt";
            this.DepositPerson_txt.Size = new System.Drawing.Size(100, 20);
            this.DepositPerson_txt.TabIndex = 29;
            // 
            // Method_txt
            // 
            this.Method_txt.FormattingEnabled = true;
            this.Method_txt.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.Method_txt.Location = new System.Drawing.Point(115, 139);
            this.Method_txt.Name = "Method_txt";
            this.Method_txt.Size = new System.Drawing.Size(100, 21);
            this.Method_txt.TabIndex = 20;
            this.Method_txt.SelectedIndexChanged += new System.EventHandler(this.Method_txt_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tax";
            // 
            // Tax_txt
            // 
            this.Tax_txt.Location = new System.Drawing.Point(115, 110);
            this.Tax_txt.Name = "Tax_txt";
            this.Tax_txt.Size = new System.Drawing.Size(100, 20);
            this.Tax_txt.TabIndex = 18;
            this.Tax_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_txt_KeyPress);
            // 
            // Date_txt
            // 
            this.Date_txt.Location = new System.Drawing.Point(115, 84);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(100, 20);
            this.Date_txt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Invoice #";
            // 
            // Amount_txt
            // 
            this.Amount_txt.Location = new System.Drawing.Point(115, 55);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.Size = new System.Drawing.Size(100, 20);
            this.Amount_txt.TabIndex = 2;
            this.Amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_txt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.Invoice_ID,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.methodDataGridViewTextBoxColumn,
            this.chequeNoDataGridViewTextBoxColumn,
            this.chequeDateDataGridViewTextBoxColumn,
            this.depositPersonDataGridViewTextBoxColumn,
            this.depositSlipNoDataGridViewTextBoxColumn,
            this.depositDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentInnBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Invoice_ID
            // 
            this.Invoice_ID.DataPropertyName = "Invoice_ID";
            this.Invoice_ID.DataSource = this.invoiceBindingSource;
            this.Invoice_ID.DisplayMember = "I_No";
            this.Invoice_ID.HeaderText = "Invoice #";
            this.Invoice_ID.Name = "Invoice_ID";
            this.Invoice_ID.ReadOnly = true;
            this.Invoice_ID.ValueMember = "Invoice_ID";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // methodDataGridViewTextBoxColumn
            // 
            this.methodDataGridViewTextBoxColumn.DataPropertyName = "Method";
            this.methodDataGridViewTextBoxColumn.HeaderText = "Method";
            this.methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "Cheque_No";
            this.chequeNoDataGridViewTextBoxColumn.HeaderText = "Cheque #";
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            // 
            // chequeDateDataGridViewTextBoxColumn
            // 
            this.chequeDateDataGridViewTextBoxColumn.DataPropertyName = "Cheque_Date";
            this.chequeDateDataGridViewTextBoxColumn.HeaderText = "Cheque Date";
            this.chequeDateDataGridViewTextBoxColumn.Name = "chequeDateDataGridViewTextBoxColumn";
            // 
            // depositPersonDataGridViewTextBoxColumn
            // 
            this.depositPersonDataGridViewTextBoxColumn.DataPropertyName = "Deposit_Person";
            this.depositPersonDataGridViewTextBoxColumn.HeaderText = "Deposit Person";
            this.depositPersonDataGridViewTextBoxColumn.Name = "depositPersonDataGridViewTextBoxColumn";
            // 
            // depositSlipNoDataGridViewTextBoxColumn
            // 
            this.depositSlipNoDataGridViewTextBoxColumn.DataPropertyName = "Deposit_Slip_No";
            this.depositSlipNoDataGridViewTextBoxColumn.HeaderText = "Deposit Slip #";
            this.depositSlipNoDataGridViewTextBoxColumn.Name = "depositSlipNoDataGridViewTextBoxColumn";
            // 
            // depositDateDataGridViewTextBoxColumn
            // 
            this.depositDateDataGridViewTextBoxColumn.DataPropertyName = "Deposit_Date";
            this.depositDateDataGridViewTextBoxColumn.HeaderText = "Deposit Date";
            this.depositDateDataGridViewTextBoxColumn.Name = "depositDateDataGridViewTextBoxColumn";
            // 
            // paymentInnBindingSource
            // 
            this.paymentInnBindingSource.DataSource = typeof(LogisticAppDAL.Entities.PaymentInn);
            // 
            // PaymentInnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaymentInnForm";
            this.Text = "PaymentInnForm";
            this.Load += new System.EventHandler(this.PaymentInnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.ComboBox Invoice_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tax_txt;
        private System.Windows.Forms.DateTimePicker Date_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Method_txt;
        private System.Windows.Forms.DateTimePicker DepositDate_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DepositSlip_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker ChequeDate_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cheque_txt;
        private System.Windows.Forms.TextBox DepositPerson_txt;
        private System.Windows.Forms.BindingSource paymentInnBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Invoice_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositSlipNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDateDataGridViewTextBoxColumn;
    }
}