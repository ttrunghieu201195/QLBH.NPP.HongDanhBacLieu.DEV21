using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Perfect.Common;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Inventory.Core.Inventory.Import;
using Perfect.Inventory.Core.Inventory.Init.Debt.Customers;
using Perfect.Inventory.Core.Inventory.Init.Standard;

namespace Perfect.Inventory.Core.Inventory.Init
{
    public partial class XfmInventoryInit : XtraForm
    {
        public XfmInventoryInit()
        {
            InitializeComponent();
            ReadLayout();

            IInventory_LinkClicked(this,null);
        }

        private XucInitInwardA _xucInitInwardA;

        private void IInventory_LinkClicked(object sender, NavBarLinkEventArgs e)
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

        

        private void IProduct_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var xfmItemAdd = new xfmItemAdd(Actions.Add);
            xfmItemAdd.Added += XfmItemAddAdded;
            xfmItemAdd.Show(this);

        }

        void XfmItemAddAdded(object sender, PRODUCT item)
        {
            if (_xucInitInwardA != null)
            {
                _xucInitInwardA.Product_Init();
                _xucInitInwardA.ProductAdd(item);
            }
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
            catch (Exception ex)
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
                catch (Exception)
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

        private void NiStockLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var xfmStockAdd = new xfmStockAdd(Actions.Add);
            xfmStockAdd.Added += XfmStockAddAdded;
            xfmStockAdd.Show(this);

        }

        void XfmStockAddAdded(object sender, STOCK item)
        {
            if (_xucInitInwardA != null)
            {
                _xucInitInwardA.Stock_Init();
                _xucInitInwardA.SetStock(item);
            }
        }


        private void NiTempFileLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var f = new XfrmExcel();
            f.ShowDialog();
        }

        private void IInventoryExcel_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new XfmInventoryImports();
            frm.ShowDialog();
        }

        private XucInitDetailListA _xucInitDetailListA;
        private void IListId_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_xucInitInwardListA == null)
            {
                _xucInitInwardListA = new XucInitInwardListA(ListType.Detail) { ListStyle = ListType.Detail };
                _xucInitInwardListA.AddNewClick += XucInwardListAAddNewClick;
                _xucInitInwardListA.Changed += XucInwardListAChanged;
                _xucInitInwardListA.Reload();
            }
            _xucInitInwardListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucInitInwardListA);
            plMain.Text = @"Bảng Kê Chi Tiết";
        }
        void XucInwardListAAddNewClick(object sender)
        {
            IInventory_LinkClicked(this, null);
            _xucInitInwardA.Add();
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

        private XucInitInwardListA _xucInitInwardListA;
        private void IListProduct_LinkClicked(object sender, NavBarLinkEventArgs e)
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
            plMain.Text = @"Bảng Kê Tổng Hợp";
        }

        private void XfmInventoryInit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_xucInitInwardA != null)
            {
                if (_xucInitInwardA.NotSave)
                {
                    DialogResult result = XtraMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có muốn lưu lại không?", "Thông Báo",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _xucInitInwardA.Save();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

                }
                if (File.Exists(Application.StartupPath + "\\Data\\STOCK_INWARD" + _xucInitInwardA.Part + ".xml"))
                {
                    File.Delete(Application.StartupPath + "\\Data\\STOCK_INWARD" + _xucInitInwardA.Part + ".xml");
                }
            }
        }

        //private XucCustomerDebtInit _xucCustomerDebtInit;
        private void NiCustomerDebtInitLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //plMain.Controls.Clear();
            //if (_xucCustomerDebtInit == null)
            //{
            //    _xucCustomerDebtInit = new XucCustomerDebtInit() ;
            //    //_xucCustomerDebtInit.AddNewClick += XucInwardListAAddNewClick;
            //    //_xucCustomerDebtInit.Changed += XucInwardListAChanged;
            //    //_xucCustomerDebtInit.Reload();
            //}
            //_xucCustomerDebtInit.Dock = DockStyle.Fill;
            //plMain.Controls.Add(_xucCustomerDebtInit);
            //plMain.Text = @"Công Nợ Đầu Kỳ - Khách Hàng";
        }

        private void NiProviderDebtInitLinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }
    }
}