using LogisticAppDAL;
using LogisticAppUI.Helper;
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
    public partial class ReportForm : Form
    {
        int id = 0;
        public ReportForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LogisticDbContext dbContext = new LogisticDbContext();
            var data = from t1 in dbContext.Quotations
                       join t2 in dbContext.Quotation_Items on t1.Q_ID equals t2.Q_ID
                       join t3 in dbContext.Companies on t1.Company_ID equals t3.C_ID
                       join t4 in dbContext.Items on t2.Item_ID equals t4.I_ID
                       where t1.Q_ID==id
                       select new ItemViewModel
                       {
                           Name = t4.Name,
                           Unit = t4.Unit,
                           Description = t4.Description,
                           Code = t4.Code,
                           Category = t1.Q_No,
                           Quantity = t2.Quantity,
                           Quoted_Amount = t2.Quoted_Amount,

                           Total = t2.Quantity * t2.Quoted_Amount,
                           Company = t3.C_Name
                       }
                      ;
            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = data.ToList();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            var reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = dbContext.Quotations.ToList();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\Zakir Awan\Source\Repos\LogisticApp\LogisticAppUI\Report\QuotationReport.rdlc";

            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuotationReport.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
