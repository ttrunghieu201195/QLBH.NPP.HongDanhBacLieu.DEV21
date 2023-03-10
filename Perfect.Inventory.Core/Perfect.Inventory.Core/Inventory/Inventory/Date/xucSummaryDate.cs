using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Inventory.Summary.DS.dsSummaryTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Inventory;
using Perfect.Net.Info;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inventory.Dates
{
    public partial class xucSummaryDate : Perfect.Common.xucDetailList
    {
        public xucSummaryDate()
        {
            InitializeComponent();
            Init();
            Bar.All = true;
            Bar.Stock_Init();


            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        private void Init()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetWaitDialogCaption("Đang nạp danh sách đơn vị tính...");
            Unit_Init();
            SetWaitDialogCaption("Đang nạp danh sách kho hàng...");
            Stock_Init();
            // iNVENTORY_DETAIL_SUMMARYTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
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
            //this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xem");
            SetData(Bar.Id,Bar.Text);
            DoHide();
            Cursor.Current = Cursors.Default;
            //this.Enabled = true;
        }

        public void SetData(string product_id,string product_name)
        {
           
            //if (MyRule.Get(MyLogin.RoleId, "bbiInventorySummary") != "OK") return;
            //if (!MyRule.AllowAccess)
            //{
            //    MyRule.Notify();
            //    return;
            //}


            if (Bar.Stock=="")
            {
               
                return;
            }

            //iNVENTORY_DETAIL_SUMMARYTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            // iNVENTORY_DETAIL_SUMMARYTableAdapter.Fill(dsInventoryDetailSummary.INVENTORY_DETAIL_SUMMARY, Bar.From, Bar.To,Bar.Stock, "%" + product_id + "%", "%" + product_name + "%");
            // Total();
            //Summary.DS.dsSummaryTableAdapters.INVENTORY_DETAIL_SUMMARYTableAdapter adapter=new INVENTORY_DETAIL_SUMMARYTableAdapter();
            //adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //adapter.Fill(dsSummary.INVENTORY_DETAIL_SUMMARY,Bar.From, Bar.To,Bar.Stock, "%" + product_id + "%", "%" + product_name + "%");
            INVENTORYS inventorys=new INVENTORYS();
            dsSummary.INVENTORY_DETAIL_SUMMARY_ByDate.Rows.Clear();
            dsSummary.INVENTORY_DETAIL_SUMMARY_ByDate.Merge(inventorys.QuantityDate(Bar.From, Bar.To, Bar.Stock, "%" + product_id + "%", "%" + product_name + "%"));

        }

        protected override void StockChanged(object value)
        {
            colStock_Name.Group();
            colStock_Name.GroupIndex = 0;
            if (value.ToString() != "All") colStock_Name.UnGroup();
            Reload();
            //base.StockChanged(value);
        }

        
        public override void Print()
        {
            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) || string.IsNullOrEmpty(MyInfo.Tel) || string.IsNullOrEmpty(MyInfo.Fax))
            {
                XtraMessageBox.Show("Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            if (!MyRule.IsPrint("bbiInventorySummary")) return;

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";
            SysLog.Insert("Tồn Kho (XNT)", "In");

            if (dsSummary.INVENTORY_DETAIL_SUMMARY_ByDate.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rpt = new rptInventoryQuantityDate(dsSummary.INVENTORY_DETAIL_SUMMARY_ByDate, "RD0000003", "Tổng Hợp Tồn Số Lượng", from + Strings.Format(Bar.From, "dd/MM/yyyy") + to + Strings.Format(Bar.To, "dd/MM/yyyy"),gbList.ActiveFilterString);

            rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiInventorySummary")) return false;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xuất");
            DoHide();
            return base.ExportPermision();

        }

        public override void ProductDetail()
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
          
            //Get Object 
            object Arg;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());
            xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
           
            //Get Object 
            object Arg ;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());

            xfmHistory xfmHistory = new xfmHistory();
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
            if (dsSummary.INVENTORY_DETAIL_SUMMARY_ByDate.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
   
            //Get Object 
            object Arg ;
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

        private void gbList_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                //e.TotalValue = Convert.ToDouble(colQuantity.SummaryItem.SummaryValue) == 0 ? 0 : Convert.ToDouble(colAmount.SummaryItem.SummaryValue) /
                //            Convert.ToDouble(colQuantity.SummaryItem.SummaryValue);

                double Amount = 0.0;
                double Quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    Amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                    Quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = Amount/Quantity;
            }
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

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }
    }
}