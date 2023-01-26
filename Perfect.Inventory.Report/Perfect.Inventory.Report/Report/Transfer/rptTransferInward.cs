using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.INVENTORY.San_Xuat
{
    public partial class rptTransferInward : XtraReport
    {
        private int counter;
        public rptTransferInward(string ID,string comment, string stock, string stockName, DateTime fromDate, DateTime toDate, string productId)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 

            report_TongHopNhapLuanChuyenTableAdapter.Connection.ConnectionString =
                Perfect.Data.Helper.SqlHelper.ConnectString;
            report_TongHopNhapLuanChuyenTableAdapter.Fill(dsTongHopNhapLuanChuyen1.Report_TongHopNhapLuanChuyen,
                                                          fromDate,toDate,stock,productId);


            var report = new REPORT();
            report.Get(ID, SysOption.Language);
            Parameters["Title"].Value = report.Title;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;

            Parameters["Comment"].Value = comment;
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
