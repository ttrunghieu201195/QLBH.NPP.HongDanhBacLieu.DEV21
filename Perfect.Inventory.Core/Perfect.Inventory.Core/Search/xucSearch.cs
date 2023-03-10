using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;

namespace Perfect.Inventory
{
    public partial class xucSearch : xucBase
    {
        BaseView exportView;

        public event ButtonClickEventHander CloseClick;

        public delegate void ViewClick(string Id, string status);

        public event ViewClick View;

        public void RaiseViewClickEventHandle(string Id, string status)
        {
            if (View != null) View(Id, status);
        }

        public void RaiseCloseClickEventHandle()
        {
            if (CloseClick != null) CloseClick(this);
        }

        public xucSearch()
        {
            InitializeComponent();
            dtFrom.DateTime = DateTime.Today;
            dtTo.DateTime = DateTime.Today;
            dtFrom1.DateTime = DateTime.Today;
            dtTo1.DateTime = DateTime.Today;
            bm.SetPopupContextMenu(gcList,pm);
        }

        public void Init()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Nạp danh sách khách hàng...");
            Customer_Init();
            SetWaitDialogCaption("Nạp danh sách Nhà Phân Phối...");
            Provider_Init();
            SetWaitDialogCaption("Nạp danh sách Kho Hàng...");
            Stock_Init();
            SetWaitDialogCaption("Hoàn Tất.");
            DoHide();

        }

        public void Customer_Init()
        {
            cUSTOMERTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            cUSTOMERTableAdapter.Fill(dsCUSTOMERS.CUSTOMER);
            DataRow dr = dsCUSTOMERS.CUSTOMER.NewCUSTOMERRow();
            dr["Customer_ID"] = "All";
            dr["CustomerName"] = "(Tất Cả)";
            dsCUSTOMERS.CUSTOMER.Rows.InsertAt(dr, 0);
        }

        public void Provider_Init()
        {
            pROVIDERTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            pROVIDERTableAdapter.Fill(dsPROVIDER.PROVIDER);
            DataRow dr = dsPROVIDER.PROVIDER.NewPROVIDERRow();
            dr["Customer_ID"] = "All";
            dr["CustomerName"] = "(Tất Cả)";
            dsPROVIDER.PROVIDER.Rows.InsertAt(dr, 0);
        }



        public void Stock_Init()
        {
            var adapter = new STOCKTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            adapter.ClearBeforeFill = true;
            adapter.Fill(dsSTOCK.STOCK);

            DataRow dr = dsSTOCK.STOCK.NewSTOCKRow();
            dr["Stock_ID"] = "All";
            dr["Stock_Name"] = "(Mặc định)";
            dsSTOCK.STOCK.Rows.InsertAt(dr, 0);
            if (dsSTOCK.STOCK.Rows.Count > 0)
            {
                txtInStock.EditValue = dsSTOCK.STOCK.Rows[0]["Stock_ID"];
            }
        }



        private void btView_Click(object sender, EventArgs e)
        {
            INVENTORYS inventorys = new INVENTORYS();
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if (rgAll.SelectedIndex == 0)
            {
                gcList.DataSource = inventorys.GetListDateAll(dtFrom.DateTime, dtTo.DateTime,
                                                           txtCustomer.EditValue.ToString(),
                                                           txtProvider.EditValue.ToString(),
                                                           txtOutStock.EditValue.ToString(),
                                                           txtInStock.EditValue.ToString(),
                                                           txtProductID.Text,
                                                           txtProductName.Text,
                                                           txtID.Text);
            }

            else
            {

                gcList.DataSource = inventorys.GetListDate(dtFrom.DateTime, dtTo.DateTime,
                                                           txtCustomer.EditValue.ToString(),
                                                           txtProvider.EditValue.ToString(),
                                                           txtOutStock.EditValue.ToString(),
                                                           txtInStock.EditValue.ToString(),
                                                           txtProductID.Text,
                                                           txtProductName.Text,
                                                           txtID.Text);

            }
            SetWaitDialogCaption("Đang định dạng lại dữ liệu...");
            List_Init(gbList);
            SetWaitDialogCaption("Hoàn Tất.");
            DoHide();
        }

        public void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Chứng từ";
                        dt.Columns[i].Width = 100;
                        break;
                    case "Date":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;
                        dt.Columns[i].Caption = "Ngày";
                        dt.Columns[i].ColumnEdit = rpDate;
                        dt.Columns[i].Width = 100;
                        break;
                    case "Type":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Loại chứng từ";
                        dt.Columns[i].Width = 100;
                        break;
                    case "Loai":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Loại chứng từ";
                        dt.Columns[i].Visible = false;
                        dt.Columns[i].Width = 100;
                        break;
                    case "Name1":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Kho xuất/Nhà PP";
                        dt.Columns[i].Width = 200;
                        break;
                    case "Name2":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "K.Hàng/Kho nhập";
                        dt.Columns[i].Width = 200;
                        break;
                    case "Product_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Mã Hàng";
                        dt.Columns[i].Width = 100;
                        break;
                    case "Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Hàng Hoá";
                        dt.Columns[i].Width = 200;
                        break;
                    case "Quantity":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        dt.Columns[i].SummaryItem.DisplayFormat = "{0:##,##0.###}";
                        dt.Columns[i].Caption = "Số Lượng";
                        dt.Columns[i].Width = 80;
                        break;
                    case "UnitPrice":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Đơn giá";
                        dt.Columns[i].Width = 100;
                        break;
                    case "Amount":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        dt.Columns[i].SummaryItem.DisplayFormat = "{0:##,##0.###}";
                        dt.Columns[i].Caption = "Thành tiền";
                        dt.Columns[i].Width = 100;
                        break;
                    case "GhiChu":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Ghi chú";
                        dt.Columns[i].Width = 250;
                        break;

                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            RaiseCloseClickEventHandle();
        }

        private void gbList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gcList_Click(object sender, EventArgs e)
        {



        }

        public object GetCellValue(int RowIndex, string FieldName)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName));
            return Result;
        }

        public object GetCellValue(int RowIndex, int ColumIndex)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex));
            return Result;
        }

        public object GetCellValue(RowClickEventArgs e)
        {
            object Result = null;
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            DevExpress.XtraGrid.Columns.GridColumn Col = new DevExpress.XtraGrid.Columns.GridColumn();

            if (e.ColumnIndex != -1)
            {
                Col = view.Columns[e.ColumnIndex];

            }
            else
            {
                Col = view.Columns[e.FieldName];
            }
            Result = view.GetRowCellValue(e.RowIndex, Col);
            // if (Result == null | e.RowIndex > gbList.RowCount) VnMessageBox.Error("Không thể lấy thông tin.", "Thông báo");
            return Result;
        }
        
        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {

        }
        

        private void rgAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtTo.Enabled = false;
            dtFrom.Enabled = false;
            if (rgAll.SelectedIndex == 1)
            {
                dtTo.Enabled = true;
                dtFrom.Enabled = true;
            }

        }

        
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btView_Click(btView,e);
        }

        private void bbiViewAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rgAll.SelectedIndex = 0;
            btView_Click(btView, e);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close();
        }

        private void bbiProductDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());
            xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        private void bbiHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID");

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());

            xfmHistory xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        private void bbiInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID");

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());

            Perfect.Inventory.xfmInventoryDetail xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(product.Product_ID, "");
            xfmInventoryDetail.ShowDialog(this);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export(gbList);
        }

        public void DisableMenu(bool disable)
        {
            bbiPrint.Enabled = !disable;
            bbiExport.Enabled = !disable;
            bbiProduct.Enabled = !disable;
            bbiEdit.Enabled = !disable;
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID");

            bbiProduct.Enabled = true;
            if (Arg == null)
            {
                bbiProduct.Enabled = false;
                return;
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            object Arg = null;
            string status;
            Arg = GetCellValue(ex.RowIndex, "ID");
            status = GetCellValue(ex.RowIndex, "Loai").ToString();
            if (Arg == null) return;

            RaiseViewClickEventHandle(Arg.ToString(), status);
        }

        private void txtID1_EditValueChanged(object sender, EventArgs e)
        {
            txtID.Text = txtID1.Text;
        }

        private void txtCustomerID1_EditValueChanged(object sender, EventArgs e)
        {
            txtCustomer.EditValue = txtCustomerID1.EditValue;
        }

        private void txtProvider1_EditValueChanged(object sender, EventArgs e)
        {
            txtProvider.EditValue = txtProvider1.EditValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            rgAll.SelectedIndex = 1;
            btView_Click(sender,e);
            pcc.HidePopup();
        }

        private void txtInStock1_EditValueChanged(object sender, EventArgs e)
        {
            txtInStock.EditValue = txtInStock1.EditValue;
        }

        private void txtOutStock1_EditValueChanged(object sender, EventArgs e)
        {
            txtOutStock.EditValue = txtOutStock1.EditValue;
        }

        private void txtProductID1_EditValueChanged(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID1.Text;
        }

        private void txtProductName1_EditValueChanged(object sender, EventArgs e)
        {
            txtProductName.Text = txtProductName1.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pcc.HidePopup();
        }

        private void dtFrom1_EditValueChanged(object sender, EventArgs e)
        {
            dtFrom.DateTime = dtFrom1.DateTime;
        }

        private void dtTo1_EditValueChanged(object sender, EventArgs e)
        {
            dtTo.DateTime = dtTo1.DateTime;
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void rgAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btView_Click(sender,e);
            }
        }
    }
}
