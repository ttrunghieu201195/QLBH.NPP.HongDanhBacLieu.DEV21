using System;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Sale.Core.DEBT.CUSTOMER;

namespace Perfect.Sale.Core.REICEIPT
{
    public partial class XfmReiceipt : xfmBase
    {
        /// <summary>
        /// Bảng kê công nợ Phải thu khách hàng
        /// </summary>
        private XucDebtDetails _detail;

        private xucDebtSummaryDetailC01 _summary;

        private xucReiceipt _ucOutwardB;
        private xucSaleAmountByDay _xucDebtNote;
        private XucList _xucOutwardListA;

        private xucDebt_CashC ucDebt_Cash;

        public XfmReiceipt()
        {
            InitializeComponent();
            Init();
            NiDebitListLinkClicked(this, null);
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
                _ucOutwardB = new xucReiceipt();
                _ucOutwardB.Add();
            }
            _ucOutwardB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucOutwardB);
            plMain.Text = @"Phiếu Thu Tiền";
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
            plMain.Text = @"Bảng Kê Phiếu Thu Tiền";
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

        private void XfmOutwardActivated(object sender, EventArgs e)
        {
            if (_ucOutwardB != null) _ucOutwardB.Updated();
        }


        private void NiDebitListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_detail == null)
            {
                _detail = new XucDebtDetails(ListType.General) {ListStyle = ListType.Detail};

                _detail.SendId += DetailSendId;
                _detail.AddNewClick += DetailAddNewClick;
                _detail.AddNewClick2 += DetailAddNewClick2;
                _detail.Reload();
            }
            _detail.Dock = DockStyle.Fill;
            plMain.Controls.Add(_detail);
            plMain.Text = @"Danh Sách Công Nợ Chi Tiết";
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

        private void DetailAddNewClick(object sender)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.Add();
        }


        private void NiSummaryLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_summary == null)
            {
                _summary = new xucDebtSummaryDetailC01(ListType.General) { ListStyle = ListType.Detail };
                //_summary.SendId += SummarySendId;
                //_summary.AddNewClick += SummaryAddNewClick;
                //_summary.AddNewClick2 += SummaryAddNewClick2;
                _summary.Reload();
            }
            _summary.Dock = DockStyle.Fill;
            plMain.Controls.Add(_summary);
            plMain.Text = @"Danh Sách Công Nợ Tổng Hợp";
        }

        private void SummaryAddNewClick2(string id)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.SetData1(id);
        }

        private void SummaryAddNewClick(object sender)
        {
            NiOutwardLinkClicked(this, null);

            //MessageBox.Show("ID ---- " + _newID);
        }


        private void SummarySendId(object sender, string id)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.SetData1(id);
        }

        private void NiNotOutwardListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucDebtNote == null)
            {
                _xucDebtNote = new xucSaleAmountByDay(ListType.General) {ListStyle = ListType.General};

                //_xucOutwardListA.SendId += new xucBasicListL3.SendIdEventHander(_xucOutwardListA_SendId);
                _xucDebtNote.Changed += XucOutwardListAChanged;
                _xucDebtNote.AddNewClick += XucOutwardListAAddNewClick;
                _xucDebtNote.Reload();
            }
            _xucDebtNote.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucDebtNote);
            plMain.Text = @"Bảng Kê Công Nợ Chưa Thu";
        }

        private void niPayList_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (ucDebt_Cash == null)
            {
                ucDebt_Cash = new xucDebt_CashC();
                ucDebt_Cash.AddNewClick += XucOutwardListAAddNewClick;
            }
            ucDebt_Cash.Dock = DockStyle.Fill;
            plMain.Controls.Add(ucDebt_Cash);
            plMain.Text = @"Bảng Kê Phiếu Thanh Toán Ngay";
        }
    }
}