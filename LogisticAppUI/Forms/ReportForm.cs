using LogisticAppDAL;
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
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LogisticDbContext dbContext = new LogisticDbContext();
            var data = dbContext.Quotation_Items.Include(x=>x.item).
                Select(x=>new {
                    item=x.item.Name,
                    Quantity=x.Quantity,
                    Quoted_Amount=x.Quoted_Amount
                })
                .ToList();
            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = data;
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
