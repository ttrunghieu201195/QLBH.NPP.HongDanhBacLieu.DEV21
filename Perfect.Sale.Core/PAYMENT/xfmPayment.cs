using System;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Inventory.Core.Inventory.Outward;
using Perfect.Inventory.Core.Inventory.Outward.Sale;
using Perfect.Sale.Core.DEBT.PROVIDER;

namespace Perfect.Sale.Core.PAYMENT
{
    public partial class XfmPayment : xfmBase
    {
        private XucSummaryDetails _detail;
        private xucPayment _ucOutwardB;
        private XucList _xucOutwardListA;
        private XucDetailListA _xucOutwardListB;
        private xucDebt_CashP ucDebt_CashP;

        public XfmPayment()
        {
            InitializeComponent();
            Init();
            NiTablesLinkClicked(this, null);
        }

        public void SetData(string id)
        {
            _ucOutwardB.SetData(id);
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
                _ucOutwardB = new xucPayment();
                _ucOutwardB.Add();
            }
            _ucOutwardB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucOutwardB);
            plMain.Text = @"Phiếu Chi";
        }

        private void NiOutwardListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucOutwardListA == null)
            {
                _xucOutwardListA = new XucList(ListType.General) {ListStyle = ListType.General};
                _xucOutwardListA.Changed += XucOutwardListAChanged;
                _xucOutwardListA.AddNewClick += XucOutwardListAAddNewClick;
                _xucOutwardListA.Reload();
            }
            _xucOutwardListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucOutwardListA);
            plMain.Text = @"Danh Sách Phiếu Chi";
        }

        private void XucOutwardListAChanged(object sender, string id, int refType)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.SetData(id);
        }

        private void XucOutwardListAAddNewClick(object sender)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.Add();
        }

        private void NiOutwardDetailListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucOutwardListB == null)
            {
                _xucOutwardListB = new XucDetailListA() {ListStyle = ListType.Detail};
                _xucOutwardListB.AddNewClick += XucOutwardListAAddNewClick;
                _xucOutwardListB.Changed += XucOutwardListAChanged;
                _xucOutwardListB.Reload();
            }
            _xucOutwardListB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucOutwardListB);
            plMain.Text = @"Bảng Kê Chi Tiết Công Nợ";
        }

        private void XfmOutwardActivated(object sender, EventArgs e)
        {
            if (_ucOutwardB != null) _ucOutwardB.Updated();
        }

        private void NiTablesLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_detail == null)
            {
                _detail = new XucSummaryDetails(ListType.Detail) {ListStyle = ListType.Detail};

                _detail.AddNewClick += XucOutwardListAAddNewClick;
                _detail.AddNewClick2 += DetailAddNewClick2;
                _detail.SendId += DetailSendId;
                _detail.Reload();
            }
            _detail.Dock = DockStyle.Fill;
            plMain.Controls.Add(_detail);
            plMain.Text = @"Danh Sách Công Nợ Phải Chi";
        }

        private void DetailAddNewClick2(string id)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.SetData1(id);
        }

        private void DetailSendId(object sender, string id)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.SetData1(id);
        }

        private void niPayList_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (ucDebt_CashP == null)
            {
                ucDebt_CashP = new xucDebt_CashP();
                ucDebt_CashP.AddNewClick += XucOutwardListAAddNewClick;
            }
            ucDebt_CashP.Dock = DockStyle.Fill;
            plMain.Controls.Add(ucDebt_CashP);
            plMain.Text = @"Bảng Kê Phiếu Thanh Toán Ngay";
        }
    }
}