using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraNavBar;
using Perfect.Common;
using Perfect.Dictionary;
using Perfect.Dictionary.Customer;
using Perfect.ERP;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using Perfect.Data.Helper;

namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    public partial class XfmOutward : xfmBase
    {
        private XucOutwardA _ucOutwardB;
        private XucOutwardListA _xucOutwardListA;
        private XucDetailListA _xucOutwardListB;
        private xucRouteDetail _xucRouteDetail;
        private DateTime _FromDate;
        private DateTime _ToDate;

        public XfmOutward()
        {
            InitializeComponent();           

            nvgOutward.Visible = true;
            niOutward.Visible = true;
            
            _FromDate = DateTime.Now;
            _ToDate = DateTime.Now;
            LoadData(_FromDate, _ToDate);

            NiOutwardListLinkClicked(this, null);
        }

        public void SetData(string id)
        {
            _ucOutwardB.SetData(id);
        }

        private void LoadData(DateTime fromDate, DateTime toDate)
        {
            iNVOICE_STATUSTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            iNVOICE_STATUSTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.INVOICE_STATUS,fromDate,toDate);
             
        }


        private void NiOutwardLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_ucOutwardB == null)
            {
                _ucOutwardB = new XucOutwardA(EnumRefType.StockOutward);
                _ucOutwardB.Add();
                _ucOutwardB.Successfull += UcOutwardBSuccessfull;
                _ucOutwardB.CheckBarcode += UcOutwardBCheckBarcode;
            }
            _ucOutwardB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucOutwardB);
            plMain.Text = @"Phiếu Xuất Hàng";
        }

        private void UcOutwardBCheckBarcode(object sender, bool chk)
        {
            dplOutward.Visibility = chk ? DockVisibility.AutoHide : DockVisibility.Visible;
        }

        private void UcOutwardBSuccessfull()
        {
            LoadData(_FromDate, _ToDate);
        }

        private void NiOutwardListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucOutwardListA == null)
            {
                _xucOutwardListA = new XucOutwardListA(ListType.General) {ListStyle = ListType.General};
                _xucOutwardListA.Changed += XucOutwardListAChanged;
                _xucOutwardListA.AddNewClick += XucOutwardListAAddNewClick;
                _xucOutwardListA.GetDateTime += new XucOutwardListA.GetDateTimeEvenhandler(_xucOutwardListA_GetDateTime);
                _xucOutwardListA.Reload();
            }
            _xucOutwardListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucOutwardListA);
            plMain.Text = @"Bảng Kê Tổng Hợp";
        }

         

        void _xucOutwardListA_GetDateTime(object sender, DateTime fromDate, DateTime toDate)
        {
            _FromDate = fromDate;
            _ToDate = toDate;


            LoadData(_FromDate, _ToDate);
        }

        private void XucOutwardListAChanged(object sender, string id, int refType)
        {
            if (refType == 2)
            {
                NiOutwardLinkClicked(this, null);
                _ucOutwardB.SetData(id);
            }
        }

        private void XucOutwardListAAddNewClick(object sender)
        {
            NiOutwardLinkClicked(this, null);
            _ucOutwardB.Add();
        }

        private void NiOutwardDetailListLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;

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
            plMain.Text = @"Bảng Kê Chi Tiết";
        }

        private void NiProductLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var xfmItemAdd = new xfmItemAdd(Actions.Add);
            xfmItemAdd.Added += XfmItemAddAdded;
            xfmItemAdd.Show(this);
        }

        private void XfmItemAddAdded(object sender, PRODUCT item)
        {
            if (_ucOutwardB != null)
            {
                _ucOutwardB.ProductInit();
                _ucOutwardB.ProductAdd(item);
            }
        }

        private void NiCustomerLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var xfmCustomerAdd = new xfmCustomerAdd(Actions.Add);
            xfmCustomerAdd.Added += XfmCustomerAddAdded;
            xfmCustomerAdd.Show(this);
        }

        private void XfmCustomerAddAdded(object sender, CUSTOMER item)
        {
            if (_ucOutwardB != null)
            {
                _ucOutwardB.CustomerInit();
                _ucOutwardB.SetCustomer(item);
            }
        }

        private void NiStockLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var xfmStockAdd = new xfmStockAdd(Actions.Add);
            xfmStockAdd.Added += XfmStockAddAdded;
            xfmStockAdd.Show(this);
        }

        private void XfmStockAddAdded(object sender, STOCK item)
        {
            if (_ucOutwardB != null)
            {
                _ucOutwardB.StockInit();
                _ucOutwardB.SetStock(item);
            }
        }

        private void XfmOutwardActivated(object sender, EventArgs e)
        {
            //if (_ucOutwardB != null) _ucOutwardB.Updated();
        }

        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            
            plMain.Controls.Clear();
            if (_xucRouteDetail == null)
            {
                _xucRouteDetail = new xucRouteDetail() { ListStyle = ListType.Detail };

                _xucRouteDetail.Reload();
            }
            _xucRouteDetail.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucRouteDetail);
            plMain.Text = navBarItem1.Caption;
        }

        private void nvOutward_Click(object sender, EventArgs e)
        {

        }

        private void dplOutward_Click(object sender, EventArgs e)
        {

        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcList_Click(object sender, EventArgs e)
        {

        }

        private void gvList_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "Name")
            {
                string colorName = Convert.ToString(gvList.GetRowCellValue(e.RowHandle, "ColorName"));
                e.Appearance.BackColor = Color.FromName(colorName);                 
                
            }
             
        }

        private void gvList_Click(object sender, EventArgs e)
        {
            LoadData(_FromDate, _ToDate);
        }

        private void XfmOutward_Load(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}