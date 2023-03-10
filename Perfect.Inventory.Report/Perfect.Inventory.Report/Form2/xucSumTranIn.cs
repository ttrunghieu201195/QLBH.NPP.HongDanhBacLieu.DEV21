using System;
using System.Data;
using Microsoft.VisualBasic;
using Perfect.ERP;
using Perfect.Common.Report;
using Perfect.INVENTORY.San_Xuat;
using Perfect.Security;


namespace Perfect.Inventory.Report
{
    public partial class xucSumTranIn : xucBaseReportControls
    {
        private string stockname;
        public string StockName
        {
            set { stockname=value; }
        }

        public xucSumTranIn()
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

            SYS_LOG.Insert("Báo Cáo Nhập Luân Chuyển", "Xem", "");

            INVENTORY_DETAIL cls = new INVENTORY_DETAIL();
            DataTable dt = cls.SummaryTranIn(_from, _to, stock, product);
            //if (dt.Rows.Count == 0)
            //{
            //    //XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
            //    return;
            //}
            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";

            

            rptTransferInward rpt = new rptTransferInward("RD0000028", from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"), stock, stockname,_from,_to, product);

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

            SYS_LOG.Insert("Báo Cáo Nhập Luân Chuyển", "In", "");

            if (fReport!=null)
            {
                fReport.PrintDialog();
                return;
            }

            INVENTORY_DETAIL cls = new INVENTORY_DETAIL();
            DataTable dt = cls.SummaryTranIn(_from, _to, stock, product);
            if (dt.Rows.Count == 0)
            {
               // XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
                return;
            }
            string from = SYS_OPTION.ReportLanguage == "VN" ? "Từ " : "From ";
            string to = SYS_OPTION.ReportLanguage == "VN" ? " đến " : " to ";

           

            rptTransferInward rpt = new rptTransferInward("RD0000028", from + Strings.Format(_from, "dd/MM/yyyy") + to + Strings.Format(_to, "dd/MM/yyyy"), stock, stockname, _from, _to, product);

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
