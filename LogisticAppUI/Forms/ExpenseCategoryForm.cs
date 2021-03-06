﻿using LogisticAppDAL.Entities;
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
    public partial class ExpenseCategoryForm : Form
    {
        public ExpenseCategoryForm()
        {
            InitializeComponent();
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }
        LogisticAppDAL.LogisticDbContext dbContext;

        private void ExpenseCategoryForm_Load(object sender, EventArgs e)
        {

            dbContext = new LogisticAppDAL.LogisticDbContext();
            Refresh();
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            Utility.FormSetting(this,  groupBox1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Utility.GetIdFromGrid((DataGridView)sender, e.ColumnIndex, e.RowIndex);
            if (id > 0)
            {
                var data = dbContext.Expense_Category.Where(x => x.Exp_Cat_ID == id).FirstOrDefault();
                dbContext.Remove(data);
                dbContext.SaveChanges();
                Refresh();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Utility.Update(dataGridView1);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Expense_Category Expense_Category = new Expense_Category();
            Expense_Category.Exp_Cat_Name = Name_txt.Text;

            dbContext.Expense_Category.Add(Expense_Category);
            dbContext.SaveChanges();
            Refresh();
            ClearTextBox();
        }

        public void ClearTextBox()
        {
            Name_txt.Clear();
        }


        public void Refresh()
        {
            expenseCategoryBindingSource.DataSource = dbContext.Expense_Category.ToList<Expense_Category>();
        }

      
    }
}
