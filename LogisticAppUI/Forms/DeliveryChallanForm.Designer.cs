namespace LogisticAppUI.Forms
{
    partial class DeliveryChallanForm
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
            this.DCno_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PO_txt = new System.Windows.Forms.ComboBox();
            this.pOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Company_txt = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryChalanItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quoted_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryChalanItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Date_txt
            // 
            this.Date_txt.Location = new System.Drawing.Point(140, 55);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(200, 20);
            this.Date_txt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 58);
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
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Challan #";
            // 
            // DCno_txt
            // 
            this.DCno_txt.Location = new System.Drawing.Point(140, 29);
            this.DCno_txt.Name = "DCno_txt";
            this.DCno_txt.Size = new System.Drawing.Size(100, 20);
            this.DCno_txt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PO_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Date_txt);
            this.groupBox1.Controls.Add(this.Save_btn);
            this.groupBox1.Controls.Add(this.Company_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DCno_txt);
            this.groupBox1.Location = new System.Drawing.Point(158, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 187);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Challan";
            // 
            // PO_txt
            // 
            this.PO_txt.DataSource = this.pOBindingSource;
            this.PO_txt.DisplayMember = "PO_No";
            this.PO_txt.FormattingEnabled = true;
            this.PO_txt.Location = new System.Drawing.Point(140, 108);
            this.PO_txt.Name = "PO_txt";
            this.PO_txt.Size = new System.Drawing.Size(100, 21);
            this.PO_txt.TabIndex = 22;
            this.PO_txt.ValueMember = "PO_ID";
            this.PO_txt.SelectedIndexChanged += new System.EventHandler(this.PO_txt_SelectedIndexChanged);
            // 
            // pOBindingSource
            // 
            this.pOBindingSource.DataSource = typeof(LogisticAppDAL.Entities.PO);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 111);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "PO No";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(152, 144);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 14;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Company_txt
            // 
            this.Company_txt.DataSource = this.companyBindingSource;
            this.Company_txt.DisplayMember = "C_Name";
            this.Company_txt.FormattingEnabled = true;
            this.Company_txt.Location = new System.Drawing.Point(140, 81);
            this.Company_txt.Name = "Company_txt";
            this.Company_txt.Size = new System.Drawing.Size(100, 21);
            this.Company_txt.TabIndex = 13;
            this.Company_txt.ValueMember = "C_ID";
            this.Company_txt.SelectedIndexChanged += new System.EventHandler(this.Company_txt_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Company);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 84);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Company";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Item);
            // 
            // deliveryChalanItemBindingSource
            // 
            this.deliveryChalanItemBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Delivery_Chalan_Item);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.item,
            this.Unit,
            this.Description,
            this.quantityDataGridViewTextBoxColumn,
            this.Quoted_Amount});
            this.dataGridView1.DataSource = this.deliveryChalanItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 233);
            this.dataGridView1.TabIndex = 19;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "I_ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // item
            // 
            this.item.DataPropertyName = "Name";
            this.item.HeaderText = "item";
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Quoted_Amount
            // 
            this.Quoted_Amount.DataPropertyName = "Quoted_Amount";
            this.Quoted_Amount.HeaderText = "Amount";
            this.Quoted_Amount.Name = "Quoted_Amount";
            this.Quoted_Amount.ReadOnly = true;
            this.Quoted_Amount.Visible = false;
            // 
            // DeliveryChallanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeliveryChallanForm";
            this.Text = "DeliveryChallanForm";
            this.Load += new System.EventHandler(this.DeliveryChallanForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryChalanItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DCno_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.ComboBox Company_txt;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.ComboBox PO_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource pOBindingSource;
        private System.Windows.Forms.BindingSource deliveryChalanItemBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quoted_Amount;
    }
}