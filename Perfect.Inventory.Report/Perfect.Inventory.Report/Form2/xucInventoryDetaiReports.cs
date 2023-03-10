using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using Perfect.ERP;
using Perfect.Common.Report;
using Perfect.Inventory;
using Perfect.Inventory.Report.Report;

namespace Perfect.Inventory.Report
{
    public partial class xucInventoryDetaiReports : xucBaseReportControls
    {
        public xucInventoryDetaiReports()
        {
            InitializeComponent();
        }

        public override void PrintPreview(DateTime _from, DateTime _to, string stock,string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Chi Tiết Tồn Kho", "Xem", "");

            INVENTORYS INV = new INVENTORYS();
            DataTable dt = INV.InwardReportDate(_from,_to, stock, product);
            //if (dt.Rows.Count == 0)
            //{
            //    //XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
            //    return;
            //}
            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";

            

            //rptInwardListDetail rpt = new rptInwardListDetail(dt, ID, from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"),stock,stockname);
            rptInventoryDetail rpt = new rptInventoryDetail(0, m_ID, dt);
            fReport = rpt;
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        public override void Print(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Chi Tiết Tồn Kho", "In", "");

            if (fReport != null)
            {
                fReport.PrintDialog();
                return;
            }

            INVENTORYS INV = new INVENTORYS();
            DataTable dt = INV.InwardReportDate(_from, _to, stock, product);
            //if (dt.Rows.Count == 0)
            //{
            //    //XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
            //    return;
            //}

            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";
           

            //rptInwardListDetail rpt = new rptInwardListDetail(dt, ID, from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"),stock,stockname);
            rptInventoryDetail rpt = new rptInventoryDetail(0, m_ID, dt);
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
