using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Report;
using Perfect.Inventory;
using Perfect.Data.Helper;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inventory.Details
{
    public partial class xucDetailAllStock : xucDetailList
    {
        public xucDetailAllStock()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
           // Stock_Init();
           // Unit_Init();
            Bar.All = false;
            Bar.IsStock = false;
            //Bar.Stock_Init();
            Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            DoHide();
        }



        public void Stock_Init()
        {
            STOCKTableAdapter adapter = new STOCKTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsSTOCK.STOCK);
        }

        public void Unit_Init()
        {
            UNITTableAdapter adapter = new UNITTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsUnit.UNIT);
        }

        public override void Reload()
        {
            Enabled = false;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData(Bar.Id, Bar.Text);
            DoHide();
            Enabled = true;
        }

        public void SetColumns(int action)
        {
           
        }

        public void SetData(string product_id, string product_name)
        {
            //Enabled = false;

            SysLog.Insert("Tồn Kho", "Xem");

            if (!MyRule.IsAccess("bbiReport")) return;

            if (Bar.Stock == "")
            {
                //  Enabled = true;
                return;
            }

            iNVENTORY_GetAllStockTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            iNVENTORY_GetAllStockTableAdapter.Fill(dsInventory.INVENTORY_GetAllStock,"%" + product_id + "%","%" + product_name + "%");
            // Total();
            // Enabled = true;
            // DoHide();
        }

        private void Total()
        {
            double Amount = 0.0;
            double Quantity = 0.0;
            for (int i = 0; i < gbList.RowCount; i++)
            {
                Amount +=
                    Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                         ? 0
                                         : gbList.GetRowCellValue(i, "Amount"));
                Quantity +=
                    Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                         ? 0
                                         : gbList.GetRowCellValue(i, "Quantity"));
            }
        }

        public override void Print()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if (!MyRule.IsPrint("bbiReport")) return;
            
            SysLog.Insert("Tồn Kho", "In");

            if (dsInventory.INVENTORY_GetAllStock.Rows.Count == 0)
            {
                DoHide();
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //var rpt = new rptInventoryDetail(0, "RD0000006", dsInventory.INVENTORY_GetFull);
            var rpt = new rptInventory(0, "RD0000006", dsInventory.INVENTORY_GetAllStock, "TỒN KHO","",gbList.ActiveFilterString);
            rpt.ShowPreview();
            DoHide();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (MyRule.Get(MyLogin.RoleId, "bbiReport") != "OK")
            {
                MyRule.Notify();
                return false;
            }
            if (!MyRule.AllowExport)
            {
                MyRule.Notify();
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
            object Arg;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            var product = new PRODUCT();
            product.Get(Arg.ToString());
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


            object Arg;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            var product = new PRODUCT();
            product.Get(Arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public void DisableMenu(bool disable)
        {
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsInventory.INVENTORY_GetAllStock.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            Bar.Bar.bbiProduct.Enabled = true;
            if (Arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
        }

        private void gbList_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                //e.TotalValue = Convert.ToDouble(colQuantity.SummaryItem.SummaryValue) == 0 ? 0 : Convert.ToDouble(colAmount.SummaryItem.SummaryValue) /
                //            Convert.ToDouble(colQuantity.SummaryItem.SummaryValue);

                double Amount = 0.0;
                double Quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    Amount +=
                        Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                             ? 0
                                             : gbList.GetRowCellValue(i, "Amount"));
                    Quantity +=
                        Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                             ? 0
                                             : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = Amount / Quantity;
            }
        }

        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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