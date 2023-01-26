using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory;
using Perfect.Inventory.Core.Common.DS;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Inventory.Packet.DS.dsPACKETTableAdapters;
using Perfect.Inventory.Core.Inventory.Transfer.dsSTOCK_TRANSFER_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Inventory;
using Perfect.Data.Helper;

namespace Perfect.Inventory.Core.Inventory.Packet.UI
{
    public partial class xucDetailListA : Perfect.Common.xucBasicListL3
    {
        private int m_action = 0;

        public xucDetailListA(int action)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            m_action = action;
            Init();
        }

        public void Init()
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

            //StockInit();

            //FormatColumns(rpStock, "Stock_ID", 0,200, "Mã");
           // FormatColumns(rpStock, "Stock_Name", 1, 200, "Tên Kho");

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }


        public void StockInit()
        {
            Common.DS.dsSTOCKTableAdapters.STOCKTableAdapter adapter=new STOCKTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
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

            Options.SetWaitDialogCaption("Đang ghi nhật ký đăng nhập...");

            SysLog.Insert("Bảng Kê Nhập Kho", "Xem");
            Options.SetWaitDialogCaption("Đang nạp dữ liệu...");

            Core.Inventory.Packet.DS.dsPACKETTableAdapters.STOCK_TRANSFER_DETAILByDateTableAdapter adapter=new STOCK_TRANSFER_DETAILByDateTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            adapter.Fill(dsPACKET.STOCK_TRANSFER_DETAILByDate, m_action, Bar.From, Bar.To);
           
            Options.SetWaitDialogCaption("Hoàn Thành...");
            Options.CloseDialog();

            //Total();
        }
        
        public override void Detail()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData(arg.ToString());
        }

        public EnumRefType Part
        {
            get { return m_part; }
            set { m_part = value; }
        }

        private EnumRefType m_part;

        public void SetData(string ID)
        {
            //Options.SetWaitDialogCaption("Đang nạp dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
           // ucDetail.SetData(ID);
            //ProductDetail();
            
           // Options.SetWaitDialogCaption("Hoàn Tất");
           // Options.CloseDialog();
            //object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
            //if (arg == null) return;

            //if (Convert.ToInt32(arg) == 7)
            //{
            //    Part = EnumRefType.TransferPack1;
            //}
            //else
            //{
            //    Part = EnumRefType.TransferPack2;
            //}

            //RaiseSendIdEventHander(ID);
            Edit();

            Cursor.Current = Cursors.Default;
        }

        public override void Edit()
        {
            if (!MyRule.IsEdit("bbiTransfer")) return;

            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
            if (arg == null) return;

            if (Convert.ToInt32(arg) == 7)
            {
                Part = EnumRefType.TransferPack1;
            }
            else
            {
                Part = EnumRefType.TransferPack2;
            }

            arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Transfer_ID");
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

            
            SqlHelper mysql = new SqlHelper();
            string result = mysql.Start();
            if (result != "OK")
            {
                mysql.RollBack();
                XtraMessageBox.Show( result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            STOCK_TRANSFER stockTransfer = new STOCK_TRANSFER();

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


            //rptTransferListDetail rpt = new rptTransferListDetail(dsSTOCK_TRANSFER_DETAIL.STOCK_TRANSFER_DETAIL_ByDate, "RD0000025", "Bảng Kê Chuyển Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
           // rpt.ShowPreview();
           
        }
        protected void btnDetail_Print_Click(object sender, EventArgs e)
        {
            if (!MyRule.IsPrint("bbiTransfer")) return;
            
            SysLog.Insert("Bảng Kê Chuyển Kho", "In");

           
            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";

            //rptTransferListDetail rpt = new rptTransferListDetail(dt, "RD0000025", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"),"","");
            //rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiTransfer")) return false;
            

            SysLog.Insert("Bảng Kê Chuyển Kho", "Xuất");

            return base.ExportPermision();
        }

        public override void History()
        {
            object Arg;
            Arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());

            xfmHistory xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public override void ProductDetail()
        {
            object Arg;
            Arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);
            if (Arg == null) return;

            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());
            xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void Inventory()
        {
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(RowClick.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            var product = new PRODUCT();
            product.Get(Arg.ToString());

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

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

            object Arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Product_ID");
            Bar.Bar.bbiProduct.Enabled = false;
            if (Arg != null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
            }
        }
    }
}
