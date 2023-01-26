using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Inventory.Core.Common.Forms;
using Perfect.Dictionary.Product;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using Perfect.Net.Info;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    public partial class XucOutwardListA : xucBasicListL3
    {
        public XucOutwardListA(ListType style)
        {
            InitializeComponent();

            
            if (style == ListType.Detail)
            {
                DetailView();
            }
            Init();
        }

        private new void Init()
        {
            base.Init();


            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Bar.Bar.bbiMirror.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            Bar.Bar.bbiMirror.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiMirror_ItemClick);
            Bar.Bar.bbiPrintOption.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            Bar.Bar.bbiPrintOption.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiPrintOption_ItemClick);

            //Bar.Bar.bbiReplication.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            Bar.Bar.bbiReplication.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiReplication_ItemClick);
        }

        void bbiReplication_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID").ToString();
            if (arg == "") 
            {
                XtraMessageBox.Show("Chưa chợn đơn hàng để nhân bản","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            xfmReplicationSales xfm = new xfmReplicationSales();
            xfm.ReplicationSales += new xfmReplicationSales.ReplicationEventHander(xfm_ReplicationSales);
            xfm.ShowDialog();
        }

        void xfm_ReplicationSales(object sender, 
            string SaleID, DateTime RefDate, string Description, string CustomerID)
        {
            //SetWaitDialogCaption("Đang cập nhật ...");
            //int[] selectedRows = gbList.GetSelectedRows();
            //var cls = new STOCK_OUTWARD();
             
        }


        private string _printOptionInfo;

        void bbiPrintOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Tuỳ chọn In
            _printOptionInfo = String.Format("{0:yyMMddHHmmss}", DateTime.Now);
            //XtraMessageBox.Show(_printOptionInfo);

            SetWaitDialogCaption("Đang cập nhật ...");
            int[] selectedRows = gbList.GetSelectedRows();
            var cls = new STOCK_OUTWARD();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                SetWaitDialogCaption("Đang cập nhật ...");

                string id = Convert.ToString(gbList.GetRowCellValue(selectedRows[i - 1], "ID"));
                if (id == "") continue;

                string result = cls.PrintOptionInfoUpdate(id, _printOptionInfo);

                if (result == "OK")
                { 
                    continue;
                }

                DoHide();

            }
            DoHide();

            Process.Start("https://admin.dmshongdanh.com/1app/indon/donhang.php?dh=inchon&macode=" + _printOptionInfo);
            
        }


        void bbiMirror_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xfmChangeInfo xfm = new xfmChangeInfo();
            xfm.IdChanged += new xfmChangeInfo.IdChangedEventHander(xfm_IdChanged);
            xfm.ShowDialog();
        }

        void xfm_IdChanged(object sender, DateTime RefDate, string Description, string CarNumber)
        {
            SetWaitDialogCaption("Đang cập nhật ...");
            int[] selectedRows = gbList.GetSelectedRows();
            var cls = new STOCK_OUTWARD();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                SetWaitDialogCaption("Đang cập nhật ...");

                string id = Convert.ToString(gbList.GetRowCellValue(selectedRows[i - 1], "ID"));
                if (id == "") continue;
                string result = cls.ChangedInfo(id, RefDate, Description, CarNumber);

                if (result == "OK")
                {
                    SetWaitDialogCaption("Cập nhật thành công Đơn hàng số: " + id);
                    continue;
                }
                else
                {
                    DoHide();
                    MessageBox.Show(@"Không thể cập nhật Đơn hàng số: " + id, @"Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                DoHide();
            }
            DoHide();
            Reload();
        }
         

       
        public override void Add()
        {
            RaiseAddNewClickEventHander(); 
        }

        public override void Reload()
        {
            SetWaitDialogCaption("Đang kiểm tra quyền sử dụng...");
            if (!MyRule.IsAccess("bbiSale"))
            {
                DoHide();
                return;
            } 

            var adapter = new STOCK_OUTWARD_ByDateTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            adapter.Fill(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_ByDate, Bar.From, Bar.To);

            var adapterDetail = new STOCK_OUTWARD_DETAIL_ByDateTableAdapter();
            adapterDetail.Connection.ConnectionString = SqlHelper.ConnectString;
            adapterDetail.Fill(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL_ByDate, Bar.From, Bar.To);
             
            SetWaitDialogCaption("Hoàn Thành...");
            DoHide();
            OnGetDateTime(Bar.From, Bar.To); 
        }


        public delegate void GetDateTimeEvenhandler(object sender, DateTime fromDate, DateTime toDate);

        public event GetDateTimeEvenhandler GetDateTime;

        public void OnGetDateTime(DateTime fromDate, DateTime toDate)
        {
            GetDateTimeEvenhandler handler = GetDateTime;
            if (handler != null) handler(this, fromDate, toDate);
        }

        public override void Detail()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData();
        }

        private void SetData()
        {
            Edit();
        }

        public override void Edit()
        { 
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return; 
            object type = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
            if (type == null) return;
            RaiseSendIdEventHander(arg.ToString());
            RaiseChangedEventHander(arg.ToString(), (int) type);
        }

        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiSale")) return;
            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int[] selectedRows = gbList.GetSelectedRows();
            if (selectedRows.Length == 0) return;

            for (int i = 0; i < selectedRows.Length; i++)
            {
                object arg = gbList.GetRowCellValue(selectedRows[i], "ID");
                if (arg == null) return;

                var cls = new STOCK_OUTWARD();
                if (!cls.Get(arg.ToString()))
                {
                    XtraMessageBox.Show("Không tìm thấy thông tin phiếu này", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                }

                if (cls.RefStatus == 1)
                {
                    XtraMessageBox.Show("Không thể xóa phiếu " + arg.ToString() + ".\n\n Phiếu này đã được thu tiền.", "Thông Báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                SysLog.Insert("Bảng Kê Phiếu Xuất", "Xoá", arg.ToString());

                var mysql = new SqlHelper();
                string result = mysql.Start();
                if (result != "OK")
                {
                    mysql.RollBack();
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!cls.Delete(mysql.Transaction, arg.ToString()))
                {
                    mysql.RollBack();
                    return;
                }
                mysql.Commit();
            }
            Reload();
        }

        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiSale")) return; 
            if (gbList.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";
            var rpt = new rptOutwardList(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_ByDate, "RD0000019", "Bảng Kê Xuất Kho",
                                         from + Strings.Format(From, "dd/MM/yyyy") + to +
                                         Strings.Format(To, "dd/MM/yyyy"));
            rpt.ShowPreview();
        }


        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiSale")) return false;
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
            SysLog.Insert("Bảng Kê Phiếu Xuất", "Xuất");

            _exportView = gbList;

            return true;
        }
         

        private void GbListClick(object sender, EventArgs e)
        {

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

        private void gbList_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "Description")
            {                
                string colorName = Convert.ToString(currentView.GetRowCellValue(e.RowHandle, "ColorName"));               
                e.Appearance.BackColor = Color.FromName(colorName);
            }
             
             
        }

       

        private void gbList_DoubleClick(object sender, EventArgs e)
        {
            Detail();

        }
         

        private void rpHyperLinkEdit1_MouseEnter(object sender, EventArgs e)
        {
            SetWaitDialogCaption("Đang mở đơn hàng ...");
            string ID = Convert.ToString(gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID"));
            //Process.Start("https://admin.dmshongdanh.com/1app/indon/donhang.php?dh=" + ID);


            Process.Start(MyInfo.WebSite + ID);
            DoHide();
            
        }

        private void rpHyperLinkEdit1_MouseDown(object sender, MouseEventArgs e)
        {

        }

    }
}