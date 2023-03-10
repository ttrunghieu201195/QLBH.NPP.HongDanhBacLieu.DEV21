using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Inventory.Report.Report.InwardList;
using Strings = Microsoft.VisualBasic.Strings;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Init.Standard
{
    public partial class XucInitInwardListA : xucBasicListL3
    {
        public XucInitInwardListA(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            //Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            if (style==ListType.Detail)
            {
                DetailView();
            }
            Init();
        }

        private new void Init()
        {
            // SetInterface();
            base.Init();
            //rEFTYPETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //rEFTYPETableAdapter.ClearBeforeFill = true;
            //rEFTYPETableAdapter.Fill(dsRefType.REFTYPE);

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);


            //this.colDescr.GroupIndex = -1;
            //this.colDescr.Visible = false;
            gbList.OptionsView.ShowGroupPanel = false;
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
            sTOCK_INWARD_GetByDateTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCK_INWARD_GetByDateTableAdapter.ClearBeforeFill = true;
            sTOCK_INWARD_GetByDateTableAdapter.Fill(dsInit02.STOCK_INWARD_GetByDate, Bar.From, Bar.To);
            Options.SetWaitDialogCaption("Hoàn Thành...");
            Options.CloseDialog();

            //Total();
        }
        
        public override void Detail()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData();
        }

        private void SetData()
        {
            //Options.SetWaitDialogCaption("Đang nạp dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            //ucDetail.SetData(ID);
            Edit();
            Cursor.Current = Cursors.Default;
            // Options.SetWaitDialogCaption("Hoàn Tất");
            // Options.CloseDialog();
        }

        public override void Edit()
        {
            //if (!MyRule.IsEdit("bbiInward")) 
            //{
            //    MyRule.Notify();
            //    return; 
            //}

            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SysLog.Insert("Bảng Kê Nhập Kho", "Cập Nhật", arg.ToString());
            
            object type = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
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
                object arg = gbList.GetRowCellValue(selectedRows[i], "ID");
                if (arg == null) return;

                SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", arg.ToString());
                Delete(arg.ToString());
            }
            Reload();
        }


        private string Delete(string id)
        {
            var mysql = new SqlHelper();
            var result = mysql.Start();
            if (result != "OK")
            {
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "Không xóa được!" ;
            }

            var stockInward = new STOCK_INWARD();

            if (!stockInward.Delete(mysql.Transaction, id))
            {
                mysql.RollBack();
               // XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "Không xóa được!";
            }

            result = mysql.Commit();
            if (result == "OK")
            {
                gbList.DeleteRow(RowClick.RowIndex);
            }

            return "OK";
        }

        protected override void Print()
        {
            
            if (!MyRule.IsPrint("bbiInward")) return;
           
            if (gbList.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";


            var rpt = new rptInwardList(dsInit02.STOCK_INWARD_GetByDate, "RD0000016", "Bảng Kê Nhập Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            rpt.ShowPreview();
           
        }

        public override void Add()
        {
            RaiseAddNewClickEventHander();
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
            //object Arg;
            //Arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbDetail);

            //if (Arg == null) return;
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());

            //xfmHistory xfmHistory = new xfmHistory();
            //xfmHistory.SetData(product.Product_ID, "");
            //xfmHistory.ShowDialog(this);
        }

        public override void DetailProduct()
        {
            //object Arg;
            //Arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbDetail);
            //if (Arg == null) return;

            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
            //xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            //// xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            //xfmItemAdd.ShowDialog();
        }

        public override void DetailInventory()
        {
            //string Result = string.Empty;
            ////Get Object 
            //object Arg = null;
            //Arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbDetail);

            //if (Arg == null) return;
            //var product = new PRODUCT();
            //product.Get(Arg.ToString());

            //var xfmInventoryDetail = new xfmInventoryDetail();
            //xfmInventoryDetail.SetData(product.Product_ID, "");
            //xfmInventoryDetail.ShowDialog(this);
        }

        private void GbListClick(object sender, EventArgs e)
        {
            Detail();
        }

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            var rowIndex = e.RowHandle;
            if (rowIndex < 0) return;
            rowIndex++;
            e.Info.DisplayText = rowIndex.ToString();
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
    }
}