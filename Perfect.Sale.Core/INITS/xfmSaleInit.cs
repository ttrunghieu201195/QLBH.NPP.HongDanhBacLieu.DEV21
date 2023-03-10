using System;
using System.IO;
using System.Windows.Forms;
using Perfect.Common;
using Perfect.Dictionary;
using Perfect.Dictionary.Customer;
using Perfect.Inventory.Core.Inventory.Import;
using Perfect.Inventory.Core.Inventory.Init;
using Perfect.Inventory.Core.Inventory.Init.Standard;
using Perfect.Sale.Core.INITS.Customer.UI;
using Perfect.Sale.Core.INITS.Provider.UI;

namespace Perfect.Sale.Core.INITS
{
    public partial class XfmSaleInit : DevExpress.XtraEditors.XtraForm
    {
        public XfmSaleInit()
        {
            InitializeComponent();
            ReadLayout();

            //ICustomerInit_LinkClicked(this, null);
            IInventory_LinkClicked(this, null);

            niImportExcel.Visible = false;
        }

        private XucInitInwardA _xucInitInwardA;
        private void IInventory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucInitInwardA == null)
            {
                _xucInitInwardA = new XucInitInwardA(EnumRefType.StockInit);
                _xucInitInwardA.Add();
            }
            _xucInitInwardA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucInitInwardA);
            plMain.Text = @"Nhập Kho Đầu Kỳ"; 
          
        }

        // Công Nợ Khách Hàng
        private XucCustomerDebtInit _customerDebt;
        private void ICustomerInit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            plMain.Text = @"Công Nợ Khách Hàng";
            if (_customerDebt == null)
            {
                _customerDebt = new XucCustomerDebtInit {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_customerDebt);
        }

        // Công Nợ Đầu Kỳ Nhà Phân Phối
        private XucProviderDebtInit _providerDebt;
        private void IProviderInit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            plMain.Text = @"Công Nợ Nhà Cung Cấp";
            if (_providerDebt == null)
            {
                _providerDebt = new XucProviderDebtInit {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_providerDebt);
        }

        private void IProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var xfmItemAdd = new xfmItemAdd(Actions.Add);
            xfmItemAdd.Added+=XfmItemAddAdded;
            xfmItemAdd.Show(this);
        }

        void XfmItemAddAdded(object sender, ERP.PRODUCT item)
        {
        }

        private void ICustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var xfmCustomerAdd=new xfmCustomerAdd(Actions.Add);
            xfmCustomerAdd.Added += XfmCustomerAddAdded;
            xfmCustomerAdd.Show(this);
        }

        void XfmCustomerAddAdded(object sender, ERP.CUSTOMER item)
        {
            if (_customerDebt != null) _customerDebt.Add(item);
        }

        private void IProvider_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var xfmProviderAdd=new xfmProviderAdd(Actions.Add);
            xfmProviderAdd.Added += XfmProviderAddAdded;
            xfmProviderAdd.Show(this);
        }

        void XfmProviderAddAdded(object sender, ERP.PROVIDER item)
        {
            if (_providerDebt != null) _providerDebt.Add(item);
        }

        private void GcInitLayout(object sender, LayoutEventArgs e)
        {

        }

        private void NavBarControl1Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                navBarInit.SaveToXml(Application.StartupPath + "\\Layout\\navBarInit.xml");
            }
            catch (Exception)
            {
                
            }
            
        }

        private void ReadLayout()
        {
            var fileInfo = new FileInfo(Application.StartupPath + "\\Layout\\navBarInit.xml");
            if (fileInfo.Exists)
            {
                try
                {
                    navBarInit.RestoreFromXml(fileInfo.FullName);
                    if (File.Exists(Application.StartupPath + "\\Layout\\dmInit.xml"))
                    {
                        dm.RestoreFromXml(Application.StartupPath + "\\Layout\\dmInit.xml");
                    }
                    if (File.Exists(Application.StartupPath + "\\Layout\\dmLayoutInit.xml"))
                    {
                        dm.RestoreLayoutFromXml(Application.StartupPath + "\\Layout\\dmLayoutInit.xml");
                    }
                }
                catch (Exception exception)
                {

                }
            }
        }

        private void DpInitLayout(object sender, LayoutEventArgs e)
        {
            dm.SaveToXml(Application.StartupPath + "\\Layout\\dmInit.xml");
            dm.SaveLayoutToXml(Application.StartupPath + "\\Layout\\dmLayoutInit.xml");  
        }

        private void DockPanel1ContainerLayout(object sender, LayoutEventArgs e)
        {
            dm.SaveToXml(Application.StartupPath + "\\Layout\\dmInit.xml");
            dm.SaveLayoutToXml(Application.StartupPath + "\\Layout\\dmLayoutInit.xml");
        }

        private void NiImportExcelLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new XfmInventoryImports();
            frm.ShowDialog();
        }

        private XucInitInwardListA _xucInitListA;
        private void NiListLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucInitListA == null)
            {
                _xucInitListA = new XucInitInwardListA(ListType.Detail) { ListStyle = ListType.Detail };
                _xucInitListA.AddNewClick += XucInitDetailListAAddNewClick;
                _xucInitListA.Changed += XucInitDetailListAChanged;
                _xucInitListA.Reload();
            }
            _xucInitListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucInitListA);
            plMain.Text = @"Bảng Kê Tổng Hợp";
        }

        void XucInitDetailListAChanged(object sender, string id, int refType)
        {
            switch (refType)
            {
                case 0:
                    IInventory_LinkClicked(this, null);
                    if (_xucInitInwardA != null) _xucInitInwardA.SetData(id);
                    break;

            }
        }

        void XucInitDetailListAAddNewClick(object sender)
        {
            IInventory_LinkClicked(this, null);
            _xucInitInwardA.Add();
            _xucInitInwardA.Clear();
        }

        private XucInitDetailListA _xucInitDetailListA;
        private void NiListProductLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucInitDetailListA == null)
            {
                _xucInitDetailListA = new XucInitDetailListA(ListType.General) { ListStyle = ListType.General };
                _xucInitDetailListA.AddNewClick += XucInwardListAAddNewClick;
                _xucInitDetailListA.Changed += XucInwardListAChanged;
                _xucInitDetailListA.Reload();
            }
            _xucInitDetailListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucInitDetailListA);
            plMain.Text = @"Bảng Kê Chi Tiết";
        }
        void XucInwardListAAddNewClick(object sender)
        {
            IInventory_LinkClicked(this, null);
            _xucInitInwardA.Add();
            _xucInitInwardA.Clear();
        }
        void XucInwardListAChanged(object sender, string id, int refType)
        {
            switch (refType)
            {
                case 0:
                    IInventory_LinkClicked(this, null);
                    if (_xucInitInwardA != null) _xucInitInwardA.SetData(id);
                    break;

            }
        }

        private void NiExcelFileLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var f = new XfrmExcel();
            f.ShowDialog();
        }
    }
}