using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common.Report;

namespace Perfect.Inventory.Report
{
    public partial class xucInventoryDetail_OrverLimits : xucBaseReportControls
    {
        public xucInventoryDetail_OrverLimits()
        {
            InitializeComponent();
        }

        public override void PrintPreview(DateTime _from, DateTime _to, string stock,string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Tồn Kho Quá Hạn Sử Dụng", "Xem", "");

            INVENTORYS INV = new INVENTORYS();
            DataTable dt = INV.DetailOverLimit(stock, product, MyLogin.LoginDate);
            //if (dt.Rows.Count == 0)
            //{
            //    //XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
            //    return;
            //}

            

            rptInventoryDetail rpt = new rptInventoryDetail(0, m_ID, dt);

            fReport = rpt;
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        public override void Print(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Tồn Kho Quá Hạn Sử Dụng", "In", "");

            if (fReport != null)
            {
                fReport.PrintDialog();
                return;
            }

            INVENTORYS INV = new INVENTORYS();
            DataTable dt = INV.DetailOverLimit(stock, product, MyLogin.LoginDate);
            if (dt.Rows.Count == 0)
            {
               // XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
                return;
            }

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
