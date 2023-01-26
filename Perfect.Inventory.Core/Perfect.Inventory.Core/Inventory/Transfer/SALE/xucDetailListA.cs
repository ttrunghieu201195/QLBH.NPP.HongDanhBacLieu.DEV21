using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Data.Helper;
using Strings = Microsoft.VisualBasic.Strings;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    public partial class XucDetailListA : xucBasicListL3
    {
        public XucDetailListA(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style==ListType.Detail)
            {
                DetailView();
            }
            Init();
        }

        private new void Init()
        {
            base.Init();
            //dsREFTYPE.REFTYPE.AddREFTYPERow(0, "Đầu Kỳ");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(1, "Nhập Kho");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(2, "Xuất Kho");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(3, "Lắp Ráp");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(4, "Tháo Gỡ");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(5, "Kiểm Kê");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(6, "Xuất và Đóng Gói");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(7, "Đóng Gói Bán Thành Phẩm");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(8, "Đóng Gói Thành Phẩm");
            //dsREFTYPE.REFTYPE.AddREFTYPERow(9, "Chuyển Kho");
            StockInit();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
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
            Options.SetWaitDialogCaption("Đang kiểm tra quyền sử dụng...");
            if (!MyRule.IsAccess("bbiTransfer"))
            {
                Options.CloseDialog();
                return;
            }
            SysLog.Insert("Bảng Kê Nhập Kho", "Xem");
            Options.SetWaitDialogCaption("Đang nạp dữ liệu...");

            var adapter = new TRANSFER_DETAIL_ByDateTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            adapter.ClearBeforeFill = true;
            adapter.Fill(dsTRANSFER_DETAIL.TRANSFER_DETAIL_ByDate, Bar.From, Bar.To);

            //Options.SetWaitDialogCaption("Hoàn Thành...");
            Options.CloseDialog();
        }
        
        public override void Detail()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
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
            //if (!MyRule.IsEdit("bbiTransfer")) 
            //{
            //    MyRule.Notify();
            //    return; 
            //}

            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Transfer_ID");
            if (arg == null) return;

            SysLog.Insert("Bảng Kê Chuyển Kho", "Cập Nhật", arg.ToString());

            RaiseSendIdEventHander(arg.ToString());
        }

        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiTransfer")) return;
            
            //Get Object 
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Transfer_ID");
            if (arg == null) return;

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SysLog.Insert("Bảng Kê Chuyển Kho", "Xoá",arg.ToString());


            var mysql = new SqlHelper();
            string result = mysql.Start();
            if (result != "OK")
            {
                mysql.RollBack();
                XtraMessageBox.Show( result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            var stockTransfer = new STOCK_TRANSFER();

            if (!stockTransfer.Delete(mysql.Transaction, arg.ToString()))
            {
                result = mysql.Result;
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            result = mysql.Commit();
            if (result == "OK")
            {
                gbList.DeleteRow(RowClick.RowIndex);
                Reload();
            }
            
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


            var rpt = new rptTransferListDetail(dsTRANSFER_DETAIL.TRANSFER_DETAIL_ByDate, "RD0000025", "Bảng Kê Chuyển Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            rpt.ShowPreview();
           
        }

        public override void Add()
        {
            RaiseAddNewClickEventHander();
        }
      
        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiTransfer")) return false;
            

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

        private void GbListCustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
