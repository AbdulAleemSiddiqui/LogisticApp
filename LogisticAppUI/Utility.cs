﻿using LogisticAppDAL;
using LogisticAppUI.Forms;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace LogisticAppUI
{
    public class Utility
    {
        public static void BackButton(Form form)
        {
            Dashboard b = new Dashboard();
            form.Hide();
            b.ShowDialog();
            form.Close();
        }
        public static void Update(DataGridView dataGridView1)
        {
            using (LogisticDbContext dbContext = new LogisticDbContext())
            {
                object obj = dataGridView1.CurrentRow.DataBoundItem;
                dbContext.Entry(obj).State = EntityState.Modified;
                dbContext.Update(obj);
                dbContext.SaveChanges();
            }
        }
        public static int GetIdFromGrid(DataGridView senderGrid,int ColumnIndex,int RowIndex)
        {

            if (senderGrid.Columns[ ColumnIndex] is DataGridViewButtonColumn &&  RowIndex >= 0)
            {
                int rowIndex =  RowIndex;
                DataGridViewRow row = senderGrid.Rows[rowIndex];
                var id = (int)row.Cells[0].Value;
                return id;
            }
            return 0;
        }
    }
}
