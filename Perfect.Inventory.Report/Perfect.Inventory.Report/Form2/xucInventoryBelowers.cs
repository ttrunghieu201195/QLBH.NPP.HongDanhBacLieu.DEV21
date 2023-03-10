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
    public partial class xucInventoryBelowers : xucBaseReportControls
    {
        public xucInventoryBelowers()
        {
            InitializeComponent();
        }

        public override void PrintPreview(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Tồn Kho Dưới Định Mức", "Xem", "");

            INVENTORYS INV = new INVENTORYS();
            DataTable dt = INV.SummaryBelower(stock, product);
            //if (dt.Rows.Count == 0)
            //{
            //    XtraMessageBox.Show("Không có dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
            //    return;
            //}

            

            rptInventory rpt = new rptInventory(1, m_ID, dt,stock,stockname);
            fReport = rpt;
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        public override void Print(DateTime _from, DateTime _to, string stock, string stockname, string product)
        {
            SYS_LOG.Insert("Báo Cáo Tồn Kho Dưới Định Mức", "In", "");

            INVENTORYS INV = new INVENTORYS();
            DataTable dt = INV.SummaryBelower(stock, product);
            if (dt.Rows.Count == 0)
            {
                //XtraMessageBox.Show("Không có dữ liệu!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ac.Show(this.ParentForm, "Thông Báo", "Không Có Dữ Liệu");
                return;
            }

            rptInventory rpt = new rptInventory(1, m_ID, dt,stock,stockname);
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
