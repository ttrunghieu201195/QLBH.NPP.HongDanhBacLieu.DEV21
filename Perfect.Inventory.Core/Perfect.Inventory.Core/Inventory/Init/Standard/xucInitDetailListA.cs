using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Report.Report;
using Perfect.Data.Helper;
using Strings = Microsoft.VisualBasic.Strings;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Init.Standard
{
    public partial class XucInitDetailListA : xucBasicListL3
    {
        public XucInitDetailListA(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Init();

            gbList.ShownEditor += gbListShownEditor;
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

        private void Init()
        {
            // SetInterface();
            base.Init();

            dsREFTYPE.REFTYPE.AddREFTYPERow(0, "Đầu Kỳ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(1, "Nhập Kho");
            dsREFTYPE.REFTYPE.AddREFTYPERow(2, "Xuất Kho");
            dsREFTYPE.REFTYPE.AddREFTYPERow(3, "Lắp Ráp");
            dsREFTYPE.REFTYPE.AddREFTYPERow(4, "Tháo Gỡ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(5, "Kiểm Kê");
            dsREFTYPE.REFTYPE.AddREFTYPERow(6, "Xuất và Đóng Gói");
            dsREFTYPE.REFTYPE.AddREFTYPERow(7, "Đóng Gói Bán Thành Phẩm");
            dsREFTYPE.REFTYPE.AddREFTYPERow(8, "Đóng Gói Thành Phẩm");
            dsREFTYPE.REFTYPE.AddREFTYPERow(9, "Chuyển Kho");
            dsREFTYPE.REFTYPE.AddREFTYPERow(44, "Nhập Thay Bao Bì");
            dsREFTYPE.REFTYPE.AddREFTYPERow(45, "Nhập Tái Chế");
            dsREFTYPE.REFTYPE.AddREFTYPERow(46, "Xuất Thay Bao Bì");
            dsREFTYPE.REFTYPE.AddREFTYPERow(47, "Xuất Tái Chế");
        }

        public override void Reload()
        {
            Options.SetWaitDialogCaption("Đang kiểm tra quyền sử dụng...");
            if (!MyRule.IsAccess("bbiInward"))
            {
                Options.CloseDialog();
                return;
            }

            Options.SetWaitDialogCaption("Đang ghi nhật ký đăng nhập...");
            SysLog.Insert("Bảng Kê Nhập Kho", "Xem");

            Options.SetWaitDialogCaption("Đang nạp dữ liệu...");
            sTOCK_INWARD_DETAIL_GetByDateTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCK_INWARD_DETAIL_GetByDateTableAdapter.ClearBeforeFill = true;                
            sTOCK_INWARD_DETAIL_GetByDateTableAdapter.Fill(dsInit02.STOCK_INWARD_DETAIL_GetByDate, Bar.From, Bar.To);
            Options.SetWaitDialogCaption("Hoàn Thành...");
            Options.CloseDialog();

            //Total();
        }

        public override void Add()
        {
            RaiseAddNewClickEventHander();
        }
        
        public override void Detail()
        {
            var arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData(arg.ToString());
        }

        private void SetData(string id)
        {
            //Options.SetWaitDialogCaption("Đang nạp dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            Edit();
            Cursor.Current = Cursors.Default;
            // Options.SetWaitDialogCaption("Hoàn Tất");
            // Options.CloseDialog();
        }

        public override void Edit()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiInward") != "OK") 
            //{
            //    MyRule.Notify();
            //    return; 
            //}
            //if (!MyRule.AllowEdit)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            var arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SysLog.Insert("Bảng Kê Nhập Kho", "Cập Nhật", arg.ToString());
            var type = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
            if (type == null) return;
            RaiseSendIdEventHander(arg.ToString());
            RaiseChangedEventHander(arg.ToString(), (int)type);
        }
        
        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiInward")) return;
           
            //Get Object 
            int[] selectedRows = gbList.GetSelectedRows();
            if (selectedRows.Length == 0) return;

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            for (int i = 0; i < selectedRows.Length; i++)
            {
                var arg = gbList.GetRowCellValue(selectedRows[i], "ID");
                if (arg == null) return;

                SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", arg.ToString());


                var mysql = new SqlHelper();
                var result = mysql.Start();
                if (result != "OK")
                {
                    mysql.RollBack();
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var stockInward = new STOCK_INWARD();

                if (!stockInward.Delete(mysql.Transaction, arg.ToString()))
                {
                    result = mysql.Result;
                    mysql.RollBack();
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                result = mysql.Commit();
            }
            Reload();
        }

        protected override void Print()
        {
           
            if (!MyRule.IsPrint("bbiInward")) return;
           
            if (gbList.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var from = SysOption.Language == "VN" ? "Từ " : "From ";
            var to = SysOption.Language == "VN" ? " đến " : " to ";


            var rpt = new rptInwardListDetail(dsInit02.STOCK_INWARD_DETAIL_GetByDate, "RD0000016", "Bảng Kê Nhập Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            rpt.ShowPreview();
           
        }

        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiInward")) return false;
            
            SysLog.Insert("Bảng Kê Nhập Kho", "Xuất");
            _exportView = gbList;
            return true;
        }

        public override void History()
        {
            var arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public override void ProductDetail()
        {
            var arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);
            if (arg == null) return;

            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void Inventory()
        {
            //Get Object 
            var arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(product.Product_ID, "");
            xfmInventoryDetail.ShowDialog(this);
        }

        public override void DetailHistory()
        {
            var arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public override void DetailProduct()
        {
            var arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);
            if (arg == null) return;

            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }

        public override void DetailInventory()
        {
            //Get Object 
            var arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

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

            var arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Product_ID");
            Bar.Bar.bbiProduct.Enabled = false;
            if (arg != null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
            }
        }

        protected override void CustomColumn()
        {
            gbList.ShowCustomization();
        }
    }
}