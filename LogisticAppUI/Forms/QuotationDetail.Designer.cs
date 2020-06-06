namespace LogisticAppUI.Forms
{
    partial class QuotationDetail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.qIItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotationItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIDDataGridViewTextBoxColumn,
            this.qNoDataGridViewTextBoxColumn,
            this.qDateDataGridViewTextBoxColumn,
            this.companyIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quotationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // qIDDataGridViewTextBoxColumn
            // 
            this.qIDDataGridViewTextBoxColumn.DataPropertyName = "Q_ID";
            this.qIDDataGridViewTextBoxColumn.HeaderText = "Q_ID";
            this.qIDDataGridViewTextBoxColumn.Name = "qIDDataGridViewTextBoxColumn";
            this.qIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.qIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qNoDataGridViewTextBoxColumn
            // 
            this.qNoDataGridViewTextBoxColumn.DataPropertyName = "Q_No";
            this.qNoDataGridViewTextBoxColumn.HeaderText = "Q No";
            this.qNoDataGridViewTextBoxColumn.Name = "qNoDataGridViewTextBoxColumn";
            this.qNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qDateDataGridViewTextBoxColumn
            // 
            this.qDateDataGridViewTextBoxColumn.DataPropertyName = "Q_Date";
            this.qDateDataGridViewTextBoxColumn.HeaderText = "Q Date";
            this.qDateDataGridViewTextBoxColumn.Name = "qDateDataGridViewTextBoxColumn";
            this.qDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "Company_ID";
            this.companyIDDataGridViewTextBoxColumn.DataSource = this.companyBindingSource;
            this.companyIDDataGridViewTextBoxColumn.DisplayMember = "C_Name";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            this.companyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.companyIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.companyIDDataGridViewTextBoxColumn.ValueMember = "C_ID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Company);
            // 
            // quotationBindingSource
            // 
            this.quotationBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Quotation);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIItemIDDataGridViewTextBoxColumn,
            this.qIDDataGridViewTextBoxColumn1,
            this.Item_Name,
            this.Unit,
            this.Description,
            this.quotedAmountDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.quotationItemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // qIItemIDDataGridViewTextBoxColumn
            // 
            this.qIItemIDDataGridViewTextBoxColumn.DataPropertyName = "QI_Item_ID";
            this.qIItemIDDataGridViewTextBoxColumn.HeaderText = "QI_Item_ID";
            this.qIItemIDDataGridViewTextBoxColumn.Name = "qIItemIDDataGridViewTextBoxColumn";
            this.qIItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.qIItemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qIDDataGridViewTextBoxColumn1
            // 
            this.qIDDataGridViewTextBoxColumn1.DataPropertyName = "Q_ID";
            this.qIDDataGridViewTextBoxColumn1.HeaderText = "Q_ID";
            this.qIDDataGridViewTextBoxColumn1.Name = "qIDDataGridViewTextBoxColumn1";
            this.qIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Item_Name
            // 
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
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
            // quotedAmountDataGridViewTextBoxColumn
            // 
            this.quotedAmountDataGridViewTextBoxColumn.DataPropertyName = "Quoted_Amount";
            this.quotedAmountDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.quotedAmountDataGridViewTextBoxColumn.Name = "quotedAmountDataGridViewTextBoxColumn";
            this.quotedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quotationItemBindingSource
            // 
            this.quotationItemBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Quotation_Item);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(LogisticAppDAL.Entities.Item);
            // 
            // QuotationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuotationDetail";
            this.Text = "QuotationDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuotationDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource quotationBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource quotationItemBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}