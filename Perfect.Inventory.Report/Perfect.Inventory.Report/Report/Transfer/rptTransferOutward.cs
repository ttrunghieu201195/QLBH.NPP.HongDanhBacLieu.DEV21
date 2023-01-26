using System;
using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.INVENTORY.San_Xuat
{
    public partial class rptTransferOutward : XtraReport
    {
        private int counter;
        public rptTransferOutward(string ID,string comment, string stock, string stockName, DateTime fromDate, DateTime toDate, string productId)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 

            report_TongHopXuatLuanChuyenTableAdapter.Connection.ConnectionString =
                Data.Helper.SqlHelper.ConnectString;
            report_TongHopXuatLuanChuyenTableAdapter.Fill(dsTongHopXuatLuanChuyen1.Report_TongHopXuatLuanChuyen,
                                                          fromDate,toDate,stock,productId);

            var report = new REPORT();
            report.Get(ID, SysOption.Language);
            Parameters["Title"].Value = report.Title;
            Parameters["Comment"].Value = comment;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;

            Parameters["Stock"].Value = stockName;
            RequestParameters = false;


            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

        }

        private void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            counter++;
            ((XRLabel) sender).Text = counter.ToString();
        }

    }
}
