using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Report;
using Perfect.Net.Info;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;

namespace Perfect.Inventory.Core.Inventory.Inventory.Details.TS
{
    public partial class XucInventoryByGroup : xucDetailList
    {
        public XucInventoryByGroup()
        {
            InitializeComponent();
            Init();
        }

        private new void Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            StockInit();
            UnitInit();
            Bar.All = true;
            Bar.Stock_Init();
            Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            DoHide();
            Cursor.Current = Cursors.Default;
        }


        private void StockInit()
        {
            var adapter = new STOCKTableAdapter
                              {Connection = {ConnectionString = SqlHelper.ConnectString}};
            adapter.Fill(dsSTOCK.STOCK);
        }

        private void UnitInit()
        {
            var adapter = new UNITTableAdapter
                              {Connection = {ConnectionString = SqlHelper.ConnectString}};
            adapter.Fill(dsUnit.UNIT);
        }


        protected override void StockChanged(object value)
        {
            Reload();
        }

        public override void Reload()
        {
            Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData(Bar.Id, Bar.Text);
            DoHide();
            Cursor.Current = Cursors.Default;
            Enabled = true;
        }

        public void SetData(string productID, string productName)
        {
            //Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            SysLog.Insert("Tồn Kho", "Xem");

            if (!MyRule.IsAccess("bbiInventory")) return;

            if (Bar.Stock == "")
            {
                //  Enabled = true;
                return;
            }
            gbList.Columns[colStock_Name.FieldName].OptionsColumn.AllowGroup = Bar.Stock == "All"
                                                                                   ? DefaultBoolean.True
                                                                                   : DefaultBoolean.False;

            iNVENTORYTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            iNVENTORYTableAdapter.Fill(dsInventory.INVENTORY_GetFull, Bar.Stock, "%" + productID + "%",
                                       "%" + productName + "%", false);
            Cursor.Current = Cursors.Default;
        }

        public override void Print()
        {
            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) ||
                string.IsNullOrEmpty(MyInfo.Tel))
            {
                XtraMessageBox.Show(
                    "Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.",
                    "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if (!MyRule.IsPrint("bbiInventory")) return;

            SysLog.Insert("Tồn Kho", "In");

            if (dsInventory.INVENTORY_GetFull.Rows.Count == 0)
            {
                DoHide();
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rpt = new rptInventory(0, "RD0000006", dsInventory.INVENTORY_GetFull, "TỒN KHO", "",
                                       gbList.ActiveFilterString);
            rpt.ShowRibbonPreview();

            DoHide();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiInventory"))
            {
                return false;
            }


            SysLog.Insert("Tồn Kho", "Xuất");

            return base.ExportPermision();
        }


        public override void ProductDetail()
        {
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);


            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        private void DisableMenu(bool disable)
        {
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsInventory.INVENTORY_GetFull.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);
            Bar.Bar.bbiProduct.Enabled = true;
            if (arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
        }

        private void GbListCustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            //if (e.SummaryProcess == CustomSummaryProcess.Start)
            //{
            //    double amount = 0.0;
            //    double quantity = 0.0;
            //    for (int i = 0; i < gbList.RowCount; i++)
            //    {
            //        amount +=
            //            Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
            //                                 ? 0
            //                                 : gbList.GetRowCellValue(i, "Amount"));
            //        quantity +=
            //            Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
            //                                 ? 0
            //                                 : gbList.GetRowCellValue(i, "Quantity"));
            //    }

            //    e.TotalValue = amount/quantity;
            //}
        }

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }
    }
}