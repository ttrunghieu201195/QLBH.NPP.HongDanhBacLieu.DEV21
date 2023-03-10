using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Inventory.Inward.dsSTOCK_INWARD_DETAILTableAdapters;
using Perfect.Data.Helper;
using Perfect.Inventory.Report.Report.InwardList;
using Perfect.Inventory.Core.Common.Forms;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inward.SALE
{
    public partial class XucInwardListA : xucBasicListL3
    {
        public XucInwardListA(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style==ListType.Detail)
            {
                DetailView();
            }
            Init();
        }

        public void Init()
        {
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

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        public override void Add()
        {
            RaiseAddNewClickEventHander();
        }

        public override void Reload()
        {
            Options.SetWaitDialogCaption("Đang kiểm tra quyền sử dụng...");
            if (!MyRule.IsAccess("bbiPurchase"))
            {
                Options.CloseDialog();
                return;
            }
            Options.SetWaitDialogCaption("Đang ghi nhật ký đăng nhập...");
            SysLog.Insert("Bảng Kê Nhập Kho", "Xem");
            Options.SetWaitDialogCaption("Đang nạp dữ liệu...");
            var adapter=new STOCK_INWARD_ByDateTableAdapter
                            {
                                Connection = {ConnectionString = SqlHelper.ConnectString}
                            };
            adapter.Fill(dsSTOCK_INWARD_DETAIL.STOCK_INWARD_ByDate ,Bar.From, Bar.To);

            var adapterDetail = new STOCK_INWARD_DETAIL_ByDateTableAdapter();
            adapterDetail.Connection.ConnectionString = SqlHelper.ConnectString;
            adapterDetail.ClearBeforeFill = true;
            adapterDetail.Fill(dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL_ByDate, Bar.From, Bar.To);
            Options.SetWaitDialogCaption("Hoàn Thành...");
            Options.CloseDialog();
        }
        
        public override void Detail()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData(arg.ToString());
        }

        public void SetData(string id)
        {
            Cursor.Current = Cursors.WaitCursor;
            Edit();
            Cursor.Current = Cursors.Default;
        }

        public override void Edit()
        {
            //if (!MyRule.IsEdit("bbiPurchase")) return;

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
            if (!MyRule.IsDelete("bbiPurchase")) return;
            int[] selectedRows = gbList.GetSelectedRows();
            if (selectedRows.Length == 0) return;
            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            for (int i = 0; i < selectedRows.Length; i++)
            {
                object arg = gbList.GetRowCellValue(selectedRows[i], "ID");
                if (arg == null) return;

                var cls = new STOCK_INWARD();
                if (!cls.Get(arg.ToString()))
                {
                    XtraMessageBox.Show("Không tìm thấy thông tin phiếu này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cls.RefStatus == 1)
                {
                    XtraMessageBox.Show("Không thể xóa phiếu Mua Hàng này.\n\n Phiếu này đã được chi tiền trong phần Công Nợ Mua Hàng.", "Thông Báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", arg.ToString());
                Delete(arg.ToString());
            }
            Reload();
        }


        public string Delete(string id)
        {
            var mysql = new SqlHelper();
            string result = mysql.Start();
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
            if (!MyRule.IsPrint("bbiPurchase")) return;
           
            if (gbList.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";


            var rpt = new rptInwardList(dsSTOCK_INWARD_DETAIL.STOCK_INWARD_ByDate, "RD0000016", "Bảng Kê Nhập Hàng", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            rpt.ShowPreview();
           
        }
     
        protected void BtnDetailPrintClick(object sender, EventArgs e)
        {


            if (MyRule.Get(MyLogin.RoleId, "bbiPurchase") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }

            SysLog.Insert("Bảng Kê Nhập Kho", "In");
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("StockName", typeof(string));
            dt.Columns.Add("Unit", typeof(string));
            dt.Columns.Add("Quantity", typeof(decimal));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Batch", typeof(string));
       
        }

        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiPurchase")) return false;
            int option = -1;
            xfmExportGridviewOptions frm = new xfmExportGridviewOptions();
            frm.OptionsSelected += (opt) =>
            {
                option = opt;
            };
            frm.ShowDialog();
            if (option == -1) return false;
            gbList.OptionsPrint.PrintDetails = option == 1;
            gbList.OptionsPrint.ExpandAllDetails = option == 1;

            _exportView = gbList;
            SysLog.Insert("Bảng Kê Nhập Kho", "Xuất");
            return true;
        }

        public override void History()
        {
            object arg;
            arg = GetCellValue(RowClick.RowIndex, "Product_ID", (GridView) ((AdvBandedGridView) gbList));

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public override void ProductDetail()
        {
            object Arg;
            Arg = GetCellValue(RowClick.RowIndex, "Product_ID", (GridView) ((AdvBandedGridView) gbList));
            if (Arg == null) return;

            var product = new PRODUCT();
            product.Get(Arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }

        public override void Inventory()
        {
            //Get Object 
            object arg;
            arg = GetCellValue(RowClick.RowIndex, "Product_ID", (GridView) ((AdvBandedGridView) gbList));

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

        private void gbList_Click(object sender, EventArgs e)
        {
            Detail();
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

        private void gbList_MouseDown(object sender, MouseEventArgs e)
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

        private void rpLink_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                string link = Convert.ToString(gbList.GetRowCellValue(gbList.FocusedRowHandle, "Reason"));
                if (link == "") return;
                SetWaitDialogCaption("Đang mở chứng từ ...");
                Process.Start(link);
                DoHide();               
                
            }
            catch (Exception ex)
            {
                DoHide();
                XtraMessageBox.Show("Không thể mở chứng từ " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}