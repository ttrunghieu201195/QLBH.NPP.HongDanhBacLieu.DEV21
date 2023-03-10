using System;
using System.Windows.Forms;
using Perfect.Dictionary;
using Perfect.Dictionary.Employee;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    public partial class XfmTransfer : xfmBase
    {
        private XucTranferA _xucTranferB;
        public XfmTransfer()
        {
            InitializeComponent();
            Init();
            NiTransferLinkClicked(this, null);
        }

        public void SetData(string id)
        {
            _xucTranferB.SetData(id);
        }

        private void Init()
        {
            Text = SysOption.Language == "VN" ? Text : "Transfer";
        }

        private void NiTransferLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = true;
            plMain.Controls.Clear();
            if (_xucTranferB == null)
            {
                _xucTranferB = new XucTranferA();
                _xucTranferB.Add();
            }
            _xucTranferB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucTranferB);
            plMain.Text = @"Chuyển Kho";
        }

        private XucTransferListA _xucTransferListA;

        private void NiTransferListLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucTransferListA == null)
            {
                _xucTransferListA = new XucTransferListA(ListType.General) {ListStyle = ListType.General};
                _xucTransferListA.SendId += XucOutwardListASendId;
                _xucTransferListA.AddNewClick += XucOutwardListAAddNewClick;
                _xucTransferListA.Reload();
            }
            _xucTransferListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucTransferListA);
            plMain.Text = @"Bảng Kê Tổng Hợp";
        }

        void XucOutwardListAAddNewClick(object sender)
        {
            NiTransferLinkClicked(this, null);
            _xucTranferB.Add();
            _xucTranferB.Clear();
        }

        void XucOutwardListASendId(object sender, string id)
        {
            NiTransferLinkClicked(this, null);
            _xucTranferB.SetData(id);
        }

        private XucDetailListA _xucTransferListB;
        private void NiDetailListLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucTransferListB == null)
            {
                _xucTransferListB = new XucDetailListA(ListType.Detail) {ListStyle = ListType.Detail};
                _xucTransferListB.SendId += XucOutwardListASendId;
                _xucTransferListB.AddNewClick += XucOutwardListAAddNewClick;
                _xucTransferListB.Reload();
            }
            _xucTransferListB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucTransferListB);
            plMain.Text = @"Bảng Kê Chi Tiết";
        }

        private void NiProductLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var xfmItemAdd = new xfmItemAdd(Actions.Add);
            xfmItemAdd.Added += XfmItemAddAdded;
            xfmItemAdd.Show(this);
        }

        void XfmItemAddAdded(object sender, PRODUCT item)
        {
            _xucTranferB.Product_Init();
            _xucTranferB.ProductAdd(item);
        }

        private void NiStockLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var xfmStockAdd = new xfmStockAdd(Actions.Add);
            xfmStockAdd.Added += XfmStockAddAdded;
            xfmStockAdd.Show(this);

        }

        void XfmStockAddAdded(object sender, STOCK item)
        {
            _xucTranferB.Stock_Init();
            _xucTranferB.SetStock(item);
        }

        private void NiEmployeeLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var  xfmEmployeeAdd=new XfmEmployeeAdd(Actions.Add);
            xfmEmployeeAdd.Added += XfmEmployeeAddAdded;
            xfmEmployeeAdd.Show(this);
        }

        void XfmEmployeeAddAdded(object sender, EMPLOYEE item)
        {
            _xucTranferB.Employee_Init();
            _xucTranferB.SetEmployee(item);
        }

       
        private void XfmTransferActivated(object sender, EventArgs e)
        {
            if (_xucTranferB != null) _xucTranferB.Updated();
        }
    }
}