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
using Perfect.Inventory.Report.Report;


namespace Perfect.Inventory.Report
{
    public partial class xucOutwardDetailList : xucBaseReportControls
    {
        private string stockname;
        public string StockName
        {
            set { stockname=value; }
        }

        public xucOutwardDetailList()
        {
            InitializeComponent();
        }

        public override void PrintPreview(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiStock_Card") != "OK") return;
            //if (!MyRule.AllowExport)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            SYS_LOG.Insert("Báo Cáo Chi Tiết Xuất Kho", "Xem", "");

            INVENTORYS cls = new INVENTORYS();
            DataTable dt = cls.OutwardReportDate(_from, _to, stock, product);
            //if (dt.Rows.Count == 0)
            //{
            //   // XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
            //    return;
            //}
            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";



            rptOutwardListDetail rpt = new rptOutwardListDetail(dt, "RD0000019", "Bảng Kê Xuất Kho", from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"));

            fReport = rpt;
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        public override void Print(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiStock_Card") != "OK") return;
            //if (!MyRule.AllowExport)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            SYS_LOG.Insert("Báo Cáo Chi Tiết Xuất Kho", "In", "");

            if (fReport!=null)
            {
                fReport.PrintDialog();
                return;
            }

            INVENTORYS cls = new INVENTORYS();
            DataTable dt = cls.OutwardReportDate(_from, _to, stock, product);
            if (dt.Rows.Count == 0)
            {
                //XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
                return;
            }
            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";

            

            rptOutwardListDetail rpt = new rptOutwardListDetail(dt, "RD0000019","Bảng Kê Xuất Kho",  from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"));

            fReport = rpt;
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
            rpt.PrintDialog();
        }

        protected override DevExpress.XtraReports.UI.XtraReport CreateReport()
        {
            return fReport;
        }
    }
}
