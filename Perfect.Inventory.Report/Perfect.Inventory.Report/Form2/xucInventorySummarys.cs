using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using Perfect.ERP;
using Perfect.Common.Report;

namespace Perfect.Inventory.Report
{
    public partial class xucInventorySummarys : xucBaseReportControls
    {
        private int _action = 0;
        public xucInventorySummarys()
        {
            InitializeComponent();
        }
        public int Part
        {
            get { return _action; }
            set { _action = value; }
        }
        public override void PrintPreview(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Tổng Hợp Xuất Nhập Tồn", "Xem", "");

            INVENTORY_DETAIL cls = new INVENTORY_DETAIL();
            DataTable dt = new DataTable();
            if (Part == 1)
            {
                dt = cls.Report_InventorySummary(_from, _to, stock, product);
            }
            else
            {
                dt = cls.Report_InventorySummaryNoTransfer(_from, _to, stock, product);
            }
            //if (dt.Rows.Count == 0)
            //{
            //   // XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
            //    return;
            //}
                

            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";

            

            Report.rptInventorySummary rpt = new Report.rptInventorySummary(dt, "RD0000004", from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"),stock,stockname);

            fReport = rpt;
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        public override void Print(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Tổng Hợp Xuất Nhập Tồn", "In", "");

            if (fReport != null)
            {
                fReport.PrintDialog();
                return;
            }

            INVENTORY_DETAIL cls = new INVENTORY_DETAIL();
            DataTable dt = new DataTable();
             if (Part != 0)
            {
                dt = cls.Report_InventorySummary(_from, _to, stock, product);
            }
            else
            {
                dt = cls.Report_InventorySummaryNoTransfer(_from, _to, stock, product);
            }
            if (dt.Rows.Count == 0)
            {
               // XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
                return;
            }

            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";

            

            Report.rptInventorySummary rpt = new Report.rptInventorySummary(dt, "RD0000004", from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"),stock,stockname);

            fReport = rpt;
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
            rpt.PrintDialog();
        }

        protected override DevExpress.XtraReports.UI.XtraReport CreateReport()
        {
            return fReport;
        }

        public override void Action(DateTime _from, DateTime _to, string stock, string stockname, string product, bool previewer)
        {
            if (previewer)
            {
                PrintPreview(_from, _to, stock,stockname, product);
                return;
            }
            Print(_from, _to, stock,stockname, product);
        }
    }
}
