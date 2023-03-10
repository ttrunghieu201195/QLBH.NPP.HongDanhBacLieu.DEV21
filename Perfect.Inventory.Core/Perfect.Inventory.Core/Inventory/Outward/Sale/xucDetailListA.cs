using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Data.Helper;
using Strings = Microsoft.VisualBasic.Strings;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    public partial class XucDetailListA : xucBasicListL3
    {
        public XucDetailListA()
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Init();
        }

        private new void Init()
        {
            base.Init();
        }

        public override void Add()
        {
            RaiseAddNewClickEventHander();
        }

        public override void Reload()
        {
            Options.SetWaitDialogCaption("Đang ghi nhật ký đăng nhập...");
            Options.SetWaitDialogCaption("Đang nạp dữ liệu...");
            var adapter = new STOCK_OUTWARD_DETAIL_ByDateTableAdapter
                              {Connection = {ConnectionString = SqlHelper.ConnectString}};
             adapter.Fill(dsSTOCK_INWARD_DETAIL.STOCK_OUTWARD_DETAIL_ByDate ,Bar.From, Bar.To);
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
           Edit();
        }

        public override void Edit()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiOutward") != "OK") return;
            //if (!MyRule.AllowEdit)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SysLog.Insert("Bảng Kê Công Nợ", "Cập Nhật", arg.ToString());
            object type = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
            if (type == null) return;
            RaiseSendIdEventHander(arg.ToString());
            RaiseChangedEventHander(arg.ToString(), (int)type);
        }
        
        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiOutward")) return;
            var stockOutward = new STOCK_OUTWARD();
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;

            if (!stockOutward.Get(arg.ToString()))
            {
                XtraMessageBox.Show("Không tìm thấy thông tin phiếu này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stockOutward.RefStatus == 1)
            {
                XtraMessageBox.Show("Không thể xóa phiếu Mua Hàng này.\n\n Phiếu này đã được thu tiền.", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", arg.ToString());

            var mysql = new SqlHelper();
            string result = mysql.Start();
            if (result != "OK")
            {
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (!stockOutward.Delete(mysql.Transaction, arg.ToString()))
            {
                mysql.RollBack();
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
            if (!MyRule.IsPrint("bbiOutward")) return;
           
            if (gbList.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";


            var rpt = new rptOutwardListDetail(dsSTOCK_INWARD_DETAIL.STOCK_OUTWARD_DETAIL_ByDate,"RD0000019", "Bảng Kê Xuất Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            rpt.ShowPreview();
           
        }
     
   
        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiOutward")) return false;
            _exportView = gbList;
            SysLog.Insert("Bảng Kê Công Nợ", "Xuất");
            return true;
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

       

        protected override void CustomColumn()
        {
            gbList.ShowCustomization();
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

        private void gbList_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "SalesStatus")
            {
                string colorName = Convert.ToString(currentView.GetRowCellValue(e.RowHandle, "ColorName"));
                e.Appearance.BackColor = Color.FromName(colorName);
            }
        }
    }
}
