using System;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Sale.Core.DEBT.CUSTOMER;
using Perfect.Sale.Core.REICEIPT;
using Perfect.Sale.Core.Report.SaleQuantity;
using Perfect.Sale.Core.Report.control;

namespace Perfect.Sale.Core.Report
{
    public partial class XfmSaleAmountReport : xfmBase
    {
        private XucPurchaseAmountByCustomer _byCustomer;
        private XucPurchaseAmountByDay _byDay;
        private XucSaleAmountByProvince _byProvince;
        private xucDebtTime _detail;
        private XucSaleQuantityByEmp _saleQuantityByEmp;
        private xucSummary _summary;
        private XucSaleAmountByCustomer _ucByCustomer;
        private XucSaleAmountByDay _ucByDay;
        private XucSaleAmountByWeek _ucByweek;
        private xucReiceipt _ucOutwardB;
        private XucSaleAmountByCustomer _xucDebtNote;
        private xucSaleQuantityByPro _saleQuantityByPro;
        public XfmSaleAmountReport()
        {
            InitializeComponent();
            Init();
            nvgRevenue.Visible = true;
        }

        private void Init()
        {
            Text = SysOption.Language == "VN" ? Text : "Outward";
        }


        private void NiOutwardLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucOutwardB == null)
            {
                _ucOutwardB = new xucReiceipt();
                _ucOutwardB.Add();
            }
            _ucOutwardB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucOutwardB);
            plMain.Text = @"Thu Tiền Khách Hàng";
        }

        private void NiOutwardListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_saleQuantityByEmp == null)
            {
                _saleQuantityByEmp = new XucSaleQuantityByEmp(ListType.General) {ListStyle = ListType.General};
                _saleQuantityByEmp.Reload();
            }
            _saleQuantityByEmp.Dock = DockStyle.Fill;
            plMain.Controls.Add(_saleQuantityByEmp);
            plMain.Text = @"Báo cáo bán hàng theo nhân viên";
        }

        private void SaleQuantityByEmpChanged(object sender, string id, int refType)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.SetData(id);
        }

        private void SaleQuantityByEmpAddNewClick(object sender)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.Add();
        }

        private void XfmOutwardActivated(object sender, EventArgs e)
        {
            if (_ucOutwardB != null) _ucOutwardB.Updated();
        }

        private void NiDebitListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_detail == null)
            {
                _detail = new xucDebtTime(ListType.General) {ListStyle = ListType.Detail};
                _detail.Reload();
            }
            _detail.Dock = DockStyle.Fill;
            plMain.Controls.Add(_detail);
            plMain.Text = @"Chi Tiết Công Nợ Phải Thu";
        }

        private void NiSummaryLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_summary == null)
            {
                _summary = new xucSummary();
                _summary.Reload();
            }
            _summary.Dock = DockStyle.Fill;
            plMain.Controls.Add(_summary);
            plMain.Text = @"Tổng Hợp Công Nợ Phải Thu";
        }

        private void NiNotOutwardListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucDebtNote == null)
            {
                _xucDebtNote = new XucSaleAmountByCustomer(ListType.General) {ListStyle = ListType.General};
                _xucDebtNote.Changed += SaleQuantityByEmpChanged;
                _xucDebtNote.AddNewClick += SaleQuantityByEmpAddNewClick;
                _xucDebtNote.Reload();
            }
            _xucDebtNote.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucDebtNote);
            plMain.Text = @"Bảng Kê Công Nợ Chưa Thu";
        }


        private void NiSaleAmountByWeekLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucByweek == null)
            {
                _ucByweek = new XucSaleAmountByWeek();
                _ucByweek.Reload();
            }
            _ucByweek.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucByweek);
            plMain.Text = @"Báo Cáo Doanh Số Theo Tuần";
        }

        private void NiSaleAmountByDayLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucByDay == null)
            {
                _ucByDay = new XucSaleAmountByDay(ListType.General) {ListStyle = ListType.General};
                _ucByDay.Reload();
            }
            _ucByDay.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucByDay);
            plMain.Text = @"Báo Cáo Doanh Số Theo Ngày";
        }

        private void NiSaleAmountByCustomerLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucByCustomer == null)
            {
                _ucByCustomer = new XucSaleAmountByCustomer(ListType.General) {ListStyle = ListType.General};
                _ucByCustomer.Reload();
            }
            _ucByCustomer.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucByCustomer);
            plMain.Text = @"Báo Cáo Doanh Số Theo Khách Hàng";
        }

        private void NiSaleAmountByProvinceLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_byProvince == null)
            {
                _byProvince = new XucSaleAmountByProvince(ListType.General) {ListStyle = ListType.General};
                _byProvince.Reload();
            }
            _byProvince.Dock = DockStyle.Fill;
            plMain.Controls.Add(_byProvince);
            plMain.Text = @"Báo Cáo Doanh Số Theo Khu Vực";
        }

        private void NiPurchaseByDayLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_byDay == null)
            {
                _byDay = new XucPurchaseAmountByDay(ListType.General) {ListStyle = ListType.General};
                _byDay.Reload();
            }
            _byDay.Dock = DockStyle.Fill;
            plMain.Controls.Add(_byDay);
            plMain.Text = @"Báo Cáo Chi Phí Mua Hàng Theo Ngày";
        }

        private void NiPurchaseByProviderLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_byCustomer == null)
            {
                _byCustomer = new XucPurchaseAmountByCustomer(ListType.General) {ListStyle = ListType.General};
                _byCustomer.Reload();
            }
            _byCustomer.Dock = DockStyle.Fill;
            plMain.Controls.Add(_byCustomer);
            plMain.Text = @"Báo Cáo Chi Phí Mua Hàng Theo Nhà Cung Cấp";
        }

        private void niSumByProduct_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_saleQuantityByPro == null)
            {
                _saleQuantityByPro = new xucSaleQuantityByPro(ListType.General) { ListStyle = ListType.General };
                _saleQuantityByPro.Reload();
            }
            _saleQuantityByPro.Dock = DockStyle.Fill;
            plMain.Controls.Add(_saleQuantityByPro);
            plMain.Text = @"Báo Cáo Lợi Nhuận";
        }
    }
}