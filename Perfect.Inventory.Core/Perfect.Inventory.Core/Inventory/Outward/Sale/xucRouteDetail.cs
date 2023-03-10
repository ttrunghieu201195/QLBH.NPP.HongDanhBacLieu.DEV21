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

namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    public partial class xucRouteDetail : xucBasicListL3
    {
        public xucRouteDetail()
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);

            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDeleteAll.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;

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

            sanLuongTuyenTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sanLuongTuyenTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.SanLuongTuyen, Bar.From, Bar.To);

         
            Options.SetWaitDialogCaption("Hoàn Thành...");
            Options.CloseDialog();
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
    }
}
