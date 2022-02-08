using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BarcodeGenerator
{
    public partial class FormReport : Form
    {
        private AppData.BarcodeDataTable _barcode;
        public FormReport(AppData.BarcodeDataTable barcode)
        {
            InitializeComponent();
            this._barcode = barcode;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            var reportDataSource = new ReportDataSource
            {
                Name = "DataSet1",
                Value = _barcode
            };

            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
