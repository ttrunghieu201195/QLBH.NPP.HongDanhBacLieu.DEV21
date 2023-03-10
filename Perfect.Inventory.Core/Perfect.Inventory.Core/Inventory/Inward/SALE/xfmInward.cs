using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Perfect.Common;
using Perfect.Dictionary;
using Perfect.Dictionary.Customer;
using Perfect.ERP;

namespace Perfect.Inventory.Core.Inventory.Inward.SALE
{
    public partial class XfmInward : XtraForm
    {
        private XucInwardA _ucInward;
        private xfmCustomerAdd _xfmCustomerAdd;
        private xfmItemAdd _xfmItemAdd;
        private xfmStockAdd _xfmStockAdd;
        private XucInwardListA _xucInwardListA;
        private xucDetailListA _xucInwardListB;

        public XfmInward()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Text = SysOption.Language == "VN" ? Text : "Inward";
            NiInwardLinkClicked(this, null);
        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Alt | Keys.D:
                    //MessageBox.Show("You are stupid");
                    return true;
            }
            return false;
        }


        private void NiInwardLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = true;
            plMain.Controls.Clear();
            if (_ucInward == null)
            {
                _ucInward = new XucInwardA(EnumRefType.StockInward);
                _ucInward.Add();
                _ucInward.CheckBarcode += UcInwardCheckBarcode;
            }
            _ucInward.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucInward);
            plMain.Text = @"Phiếu Nhập Hàng";
        }

        void UcInwardCheckBarcode(object sender, bool chk)
        {
            dplInward.Visibility = chk ? DockVisibility.AutoHide : DockVisibility.Visible;
        }

        private void NiInwardListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucInwardListA == null)
            {
                _xucInwardListA = new XucInwardListA(ListType.General) {ListStyle = ListType.General};
                _xucInwardListA.AddNewClick += XucInwardListAAddNewClick;
                _xucInwardListA.Changed += XucInwardListAChanged;
                _xucInwardListA.Reload();
            }
            _xucInwardListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucInwardListA);
            plMain.Text = @"Bảng Kê Tổng Hợp";
        }

        private void XucInwardListAChanged(object sender, string id, int refType)
        {
            if (refType == 1)
            {
                NiInwardLinkClicked(this, null);
                if (_ucInward != null) _ucInward.SetData(id);
            }
        }

        private void XucInwardListAAddNewClick(object sender)
        {
            NiInwardLinkClicked(this, null);
            _ucInward.Add();
        }

        private void NiInwardDetailListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucInwardListB == null)
            {
                _xucInwardListB = new xucDetailListA(ListType.Detail) {ListStyle = ListType.Detail};
                _xucInwardListB.AddNewClick += XucInwardListAAddNewClick;
                _xucInwardListB.Changed += XucInwardListAChanged;
                _xucInwardListB.Reload();
            }
            _xucInwardListB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucInwardListB);
            plMain.Text = @"Bảng Kê Chi Tiết";
        }

        private void NiProductLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (_xfmItemAdd == null)
            {
                _xfmItemAdd = new xfmItemAdd(Actions.Add);
                _xfmItemAdd.Added += XfmItemAddAdded;
                _xfmItemAdd.FormClosing += XfmItemAddFormClosing;
            }
            _xfmItemAdd.ShowDialog();
        }

        private void XfmItemAddFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmItemAdd = null;
        }

        private void XfmItemAddAdded(object sender, PRODUCT item)
        {
            if (_ucInward != null)
            {
                _ucInward.ProductInit();
                _ucInward.ProductAdd(item);
            }
        }


        private void NiCustomerLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (_xfmCustomerAdd == null)
            {
                _xfmCustomerAdd = new xfmCustomerAdd(Actions.Add);
                _xfmCustomerAdd.Added += XfmCustomerAddAdded;
                _xfmCustomerAdd.FormClosing += XfmCustomerAddFormClosing;
            }
            _xfmCustomerAdd.Show(this);
        }

        private void XfmCustomerAddFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmCustomerAdd = null;
        }

        private void XfmCustomerAddAdded(object sender, CUSTOMER item)
        {
            if (_ucInward != null)
            {
                _ucInward.CustomerInit();
                _ucInward.SetCustomer(item);
            }
        }

        private void NiStockLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (_xfmStockAdd == null)
            {
                _xfmStockAdd = new xfmStockAdd(Actions.Add);
                _xfmStockAdd.Added += XfmStockAddAdded;
                _xfmStockAdd.FormClosing += XfmStockAddFormClosing;
            }
            _xfmStockAdd.ShowDialog();
        }

        private void XfmStockAddFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmStockAdd = null;
        }

        private void XfmStockAddAdded(object sender, STOCK item)
        {
            if (_ucInward != null)
            {
                _ucInward.StockInit();
                _ucInward.SetStock(item);
            }
        }

        private void XfmInwardActivated(object sender, EventArgs e)
        {
            if (_ucInward != null) _ucInward.Updated();
        }
    }
}