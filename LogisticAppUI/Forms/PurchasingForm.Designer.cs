namespace LogisticAppUI.Forms
{
    partial class PurchasingForm
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
            this.Date_txt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Balance_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Pay_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PONo_txt = new System.Windows.Forms.ComboBox();
            this.pOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Save_btn = new System.Windows.Forms.Button();
            this.Vender_txt = new System.Windows.Forms.ComboBox();
            this.venderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBillItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBillItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Date_txt
            // 
            this.Date_txt.Location = new System.Drawing.Point(140, 64);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(200, 20);
            this.Date_txt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PO #";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Balance_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Pay_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Total_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PONo_txt);
            this.groupBox1.Controls.Add(this.Date_txt);
            this.groupBox1.Controls.Add(this.Save_btn);
            this.groupBox1.Controls.Add(this.Vender_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(158, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 187);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchasing";
            // 
            // Balance_txt
            // 
            this.Balance_txt.Enabled = false;
            this.Balance_txt.Location = new System.Drawing.Point(473, 94);
            this.Balance_txt.Name = "Balance_txt";
            this.Balance_txt.Size = new System.Drawing.Size(100, 20);
            this.Balance_txt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 97);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Balance:";
            // 
            // Pay_txt
            // 
            this.Pay_txt.Location = new System.Drawing.Point(473, 67);
            this.Pay_txt.Name = "Pay_txt";
            this.Pay_txt.Size = new System.Drawing.Size(100, 20);
            this.Pay_txt.TabIndex = 26;
            this.Pay_txt.TextChanged += new System.EventHandler(this.Pay_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 70);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Paid:";
            // 
            // Total_txt
            // 
            this.Total_txt.Enabled = false;
            this.Total_txt.Location = new System.Drawing.Point(473, 40);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Size = new System.Drawing.Size(100, 20);
            this.Total_txt.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 43);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total:";
            // 
            // PONo_txt
            // 
            this.PONo_txt.DataSource = this.pOBindingSource;
            this.PONo_txt.DisplayMember = "PO_No";
            this.PONo_txt.FormattingEnabled = true;
            this.PONo_txt.Location = new System.Drawing.Point(140, 29);
            this.PONo_txt.Name = "PONo_txt";
            this.PONo_txt.Size = new System.Drawing.Size(100, 21);
            this.PONo_txt.TabIndex = 21;
            this.PONo_txt.ValueMember = "PO_ID";
            this.PONo_txt.SelectedIndexChanged += new System.EventHandler(this.PONo_txt_SelectedIndexChanged);
            // 
            // pOBindingSource
            // 
            this.pOBindingSource.DataSource = typeof(LogisticAppDAL.Entities.PO);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(165, 139);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 14;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Vender_txt
            // 
            this.Vender_txt.DataSource = this.venderBindingSource;
            this.Vender_txt.DisplayMember = "Name";
            this.Vender_txt.FormattingEnabled = true;
            this.Vender_txt.Location = new System.Drawing.Point(140, 98);
            this.Vender_txt.Name = "Vender_txt";
            this.Vender_txt.Size = new System.Drawing.Size(100, 21);
            this.Vender_txt.TabIndex = 13;
            this.Vender_txt.ValueMember = "V_ID";
            // 
            // venderBindingSource
            // 
            this.venderBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Vender);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 101);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vender";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Item);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.item,
            this.Unit,
            this.Description,
            this.Rate,
            this.quantityDataGridViewTextBoxColumn,
            this.Total});
            this.dataGridView1.DataSource = this.purchaseBillItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 233);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            // 
            // Item_ID
            // 
            this.Item_ID.DataPropertyName = "I_ID";
            this.Item_ID.HeaderText = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.Visible = false;
            // 
            // item
            // 
            this.item.DataPropertyName = "Name";
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Quoted_Amount";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // purchaseBillItemBindingSource
            // 
            this.purchaseBillItemBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Purchase_Bill_Item);
            // 
            // PurchasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PurchasingForm";
            this.Text = "PurchasingForm";
            this.Load += new System.EventHandler(this.PurcashingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBillItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.ComboBox Vender_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource venderBindingSource;
        private System.Windows.Forms.ComboBox PONo_txt;
        private System.Windows.Forms.BindingSource pOBindingSource;
        private System.Windows.Forms.TextBox Balance_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Pay_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource purchaseBillItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}