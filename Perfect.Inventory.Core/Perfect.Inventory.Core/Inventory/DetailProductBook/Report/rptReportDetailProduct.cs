using System;
using System.Data;
using Perfect.Data.Helper;
using Perfect.ERP;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Inventory.Core.Inventory.DetailProductBook.Report
{
    public partial class rptReportDetailProduct : XtraReport
    {
        public rptReportDetailProduct(DataTable dt, string id, string title, string comment)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;

            //iNVENTORY_DETAILTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;

            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    
                    //dsDetailProduct1.INVENTORY_DETAIL.Merge(dt);
                    dsDetailProduct1.Detail_Product_By_Date.Merge(dt);
                }
            }
            SetInfo(id, title, comment);

        }

        void SetInfo(string id, string title, string comment)
        {
            if (title == "")
            {
                REPORT report = new REPORT();
                report.Get(id, SysOption.ReportLanguage);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }

            Parameters["Comment"].Value = comment;

            //Parameters["TotalVatAmount"].Value = totalvatamount;
            //Parameters["TotalDiscount"].Value = totaldiscount;
            //Parameters["TotalAmount"].Value = totalamount;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";


            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        int _counter;
        private void xrTableCell5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

        private double totalQuantityByGroup = 0;
        private double amountByGroup = 0;
        private double endQuantity = 0; 
        private double endAmount = 0;


        private void xrTableCell53_SummaryCalculated(object sender, TextFormatEventArgs e)
        {

        }

        private void xrTableCell53_SummaryRowChanged(object sender, EventArgs e)
        {
            totalQuantityByGroup += Convert.ToDouble(GetCurrentColumnValue("SoLuongTonDau") == DBNull.Value ? 0 : Convert.ToDouble(GetCurrentColumnValue("SoLuongTonDau")))
                + Convert.ToDouble(GetCurrentColumnValue("SoLuongNhapHang") == DBNull.Value ? 0 : Convert.ToDouble(GetCurrentColumnValue("SoLuongNhapHang")))
                - Convert.ToDouble(GetCurrentColumnValue("SoLuongXuatHang") == DBNull.Value ? 0 : Convert.ToDouble(GetCurrentColumnValue("SoLuongXuatHang")));
        }

        private void xrTableCell53_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            endQuantity += totalQuantityByGroup;
            e.Result = totalQuantityByGroup;
            e.Handled = true;
        }

        private void xrTableCell53_SummaryReset(object sender, EventArgs e)
        {
            totalQuantityByGroup = 0;
        }

        

        private void xrTableCell50_SummaryReset(object sender, EventArgs e)
        {
            amountByGroup = 0;
        }

        private void xrTableCell50_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            endAmount += amountByGroup;
            e.Result = amountByGroup;
            e.Handled = true;
        }

        private void xrTableCell50_SummaryRowChanged(object sender, EventArgs e)
        {
            amountByGroup += Convert.ToDouble(GetCurrentColumnValue("ThanhTienTonDau") == DBNull.Value ? 0 : Convert.ToDouble(GetCurrentColumnValue("ThanhTienTonDau")))
                + Convert.ToDouble(GetCurrentColumnValue("ThanhTienNhapHang") == DBNull.Value ? 0 : Convert.ToDouble(GetCurrentColumnValue("ThanhTienNhapHang")))
                - Convert.ToDouble(GetCurrentColumnValue("ThanhTienXuatHang") == DBNull.Value ? 0 : Convert.ToDouble(GetCurrentColumnValue("ThanhTienXuatHang")));
        }

        private void xrTableCell25_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = endQuantity;
            e.Handled = true;
        }

        private void xrTableCell16_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = endAmount;
            e.Handled = true;
        }

    }
}