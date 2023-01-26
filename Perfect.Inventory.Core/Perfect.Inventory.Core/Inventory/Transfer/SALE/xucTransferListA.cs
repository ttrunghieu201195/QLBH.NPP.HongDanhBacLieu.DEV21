using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Data.Helper;
using Strings=Microsoft.VisualBasic.Strings;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    public partial class XucTransferListA : xucBasicListL3
    {
        public XucTransferListA(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style==ListType.Detail)
            {
                DetailView();
            }
            Init();

            gbList.ShownEditor += gbListShownEditor;
        }

        public override void Add()
        {
            RaiseAddNewClickEventHander();
        }

        private void gbListShownEditor(object sender, EventArgs e)
        {

            var view = sender as GridView;
            view.ActiveEditor.DoubleClick += ActiveEditorDoubleClick;
        
        }

        private void ActiveEditorDoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private new void Init()
        {
            base.Init();
            StockInit();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            //Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
        }


        private void StockInit()
        {
            var adapter=new STOCKTableAdapter
                            {
                                Connection = {ConnectionString = SqlHelper.ConnectString}
                            };
            adapter.Fill(dsSTOCK.STOCK);
        }

        public override void Reload()
        {
            if (!MyRule.IsAccess("bbiTransfer"))
            {
                MyRule.Notify();
                return;
            }
            SysLog.Insert("Bảng Kê Nhập Kho", "Xem");
            Options.SetWaitDialogCaption("Đang nạp dữ liệu...");

            tRANSFER_ByDateTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            tRANSFER_ByDateTableAdapter.ClearBeforeFill = true;
            tRANSFER_ByDateTableAdapter.Fill(dsTRANSFER_DETAIL.TRANSFER_ByDate,Bar.From, Bar.To);

            var adapterDetail = new Transfer.DS.dsTRANSFER_DETAILTableAdapters.TRANSFER_DETAIL_ByDateTableAdapter();
            adapterDetail.Connection.ConnectionString = SqlHelper.ConnectString;
            adapterDetail.ClearBeforeFill = true;
            adapterDetail.Fill(dsTRANSFER_DETAIL.TRANSFER_DETAIL_ByDate, Bar.From, Bar.To);

            Options.CloseDialog();
        }
        
        public override void Detail()
        {
            var arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData(arg.ToString());
        }

        private void SetData(string id)
        {
            Cursor.Current = Cursors.WaitCursor;
            Edit();
            Cursor.Current = Cursors.Default;
        }

        public override void Edit()
        {
            if (!MyRule.IsEdit("bbiTransfer")) 
            {
                MyRule.Notify();
                return; 
            }

            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SysLog.Insert("Bảng Kê Chuyển Kho", "Cập Nhật", arg.ToString());
            RaiseSendIdEventHander(arg.ToString());
        }

        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiTransfer")) return;
            int[] selectedRows = gbList.GetSelectedRows();
            if (selectedRows.Length == 0) return;
            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            for (int i = 0; i < selectedRows.Length; i++)
            {
                object arg = gbList.GetRowCellValue(selectedRows[i], "ID");
                if (arg == null) return;
                var mysql = new SqlHelper();
                string result = mysql.Start();
                if (result != "OK")
                {
                    mysql.RollBack();
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SysLog.Insert("Bảng Kê Chuyển Kho", "Xoá", arg.ToString());
                var stockTransfer = new STOCK_TRANSFER();
                if (!stockTransfer.Delete(mysql.Transaction, arg.ToString()))
                {
                    mysql.RollBack();
                    XtraMessageBox.Show(mysql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                mysql.Commit();
            }
            Reload();
            
        }
        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiTransfer")) return;
           
            SysLog.Insert("Bảng Kê Chuyển Kho", "In");

            if (gbList.RowCount == 0)
            {
                XtraMessageBox.Show("No data to print.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";


            var rpt = new rptTransferList(dsTRANSFER_DETAIL.TRANSFER_ByDate, "RD0000025", "Bảng Kê Chuyển Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            rpt.ShowPreview();
           
        }
  

        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiTransfer")) 
            {
                MyRule.Notify();
                return false; 
            }
            
            SysLog.Insert("Bảng Kê Chuyển Kho", "Xuất");

            _exportView = gbList;

            return base.ExportPermision();
        }

        public override void History()
        {
            object arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public override void ProductDetail()
        {
            object arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);
            if (arg == null) return;

            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }

        public override void Inventory()
        {
            //Get Object 
            object arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(product.Product_ID, "");
            xfmInventoryDetail.ShowDialog(this);
        }

       
        private void GbListClick(object sender, EventArgs e)
        {
            Detail();
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

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Product_ID");
            Bar.Bar.bbiProduct.Enabled = false;
            if (arg != null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
            }
        }
    }
}