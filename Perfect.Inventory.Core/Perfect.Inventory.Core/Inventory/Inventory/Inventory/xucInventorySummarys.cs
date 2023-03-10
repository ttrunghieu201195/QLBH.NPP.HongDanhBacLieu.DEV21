using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Report;
using Perfect.Inventory;
using Perfect.Data.Helper;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory
{
    public partial class xucInventorySummarys : xucDetailList
    {
        public xucInventorySummarys()
        {
            InitializeComponent();
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang khởi tạo dữ liệu...");
            Unit_Init();
            //sTOCKTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
            Bar.Stock_Init();
            Bar.IsTo = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            DoHide();
        }

        public void Unit_Init()
        {
            UNITTableAdapter adapter = new UNITTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            adapter.Fill(dsUnit.UNIT);
        }

        public override void Reload()
        {
            Enabled = false;
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho", "Xem");
            SetData(Bar.Id, Bar.Text);
            DoHide();
            Enabled = true;
        }

        public void SetData(string product_id, string product_name)
        {

            if (MyRule.Get(MyLogin.RoleId, "bbiInventory") != "OK") return;
            if (!MyRule.AllowAccess)
            {
                MyRule.Notify();
                return;
            }


            if (Bar.Stock == "")
            {
                //Enabled = true;
                return;
            }


            iNVENTORY_SUMMARYTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            iNVENTORY_SUMMARYTableAdapter.Fill(dsInventorySummary.INVENTORY_SUMMARY, Bar.Stock,
                                               "%" + product_id + "%", "%" + product_name + "%");
            if (Bar.Stock == "All")
            {
                gbList.Columns[colStock_Name.FieldName].Visible = true;
            }
            else
            {
                gbList.Columns[colStock_Name.FieldName].Visible = false;
            }
            // Total();
            //Enabled = true;
        }

        public override void Print()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiInventory") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }

            SysLog.Insert("Tồn Kho", "In");

            //xfmReportManagers frm = new xfmReportManagers("RD0000006");
            //xfmReportManagers frm=new xfmReportManagers();
            //frm.SetData("RD0000006");
            //frm.Show();

            if (dsInventorySummary.INVENTORY_SUMMARY.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rpt = new rptInventory(0, "RD0000006", dsInventorySummary.INVENTORY_SUMMARY,Bar.Stock,Bar.StockText,gbList.ActiveFilterString);
            rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (MyRule.Get(MyLogin.RoleId, "bbiInventory") != "OK")
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

           // Export(gbList);
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

            //Get Object 
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
            Bar.Bar.bbiCopy.Enabled = !disable;

        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsInventorySummary.INVENTORY_SUMMARY.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }

            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            Bar.Bar.bbiProduct.Enabled = true;
            if (Arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
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