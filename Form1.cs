using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (GauBongContext context = new GauBongContext())
            {
                List<tGau> gau = context.tGaus.ToList();
                List<GauBongReport> listReport = new List<GauBongReport>();

                foreach (tGau g in gau)
                {
                    GauBongReport report = new GauBongReport();
                    report.MaGau = g.MaGau;
                    report.TenGau = g.TenGau;
                    report.DonGiaBan = g.DonGiaBan;
                    report.MoTa = g.MoTa;
                    report.TenLoai = g.tTheLoai.TenLoai;
                    listReport.Add(report);
                }

                // Cấu hình report viewer
                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                var source = new ReportDataSource("GauBongDataSet", listReport);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(source);

                // Làm mới report viewer
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
