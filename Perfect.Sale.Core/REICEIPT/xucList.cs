using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory;
using Perfect.Data.Helper;
using DevExpress.XtraGrid.Views.Grid;

namespace Perfect.Sale.Core.REICEIPT
{
    public partial class XucList : xucBasicListL3
    {
        public XucList(ListType style)
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

        private void gbListShownEditor(object sender, EventArgs e)
        {

            var view = sender as GridView;

            view.ActiveEditor.DoubleClick += ActiveEditorDoubleClick;
        
        }

        private void ActiveEditorDoubleClick(object sender, EventArgs e)
        {
            Detail();
        }

        private new void Init()
        {
            base.Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            //Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveNew.Visibility = BarItemVisibility.Never;
            Bar.Bar.BbiSaveDataById.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveTemp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        public override void Reload()
        {

            if (!MyRule.IsAccess("bbiReciept"))
            
            SysLog.Insert("Bảng Kê Bán Hàng", "Xem");
            cUSTOMER_RECEIPTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMER_RECEIPTTableAdapter.Fill(dsDEBT.CUSTOMER_RECEIPT, Bar.From, Bar.To);
            gbList.ExpandAllGroups();
            //Total();
        }

        /*
         public override void Detail()
        {
            object phieu = gbList.GetFocusedRowCellValue("ChungTu");
            if (phieu == null) return;
            object soTien = gbList.GetFocusedRowCellValue("SoTien");
            if (soTien == null) return;
            object daTra = gbList.GetFocusedRowCellValue("DaTra");
            if (daTra == null) return;
            object conLai = gbList.GetFocusedRowCellValue("ConLai");
            if (conLai == null) return;
            object ngay = gbList.GetFocusedRowCellValue("Ngay");
            if (ngay == null) return;
            object customerID = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (customerID == null) return;
            object customerAddress = gbList.GetRowCellValue(gbList.FocusedRowHandle, "CustomerAddress");
            if (customerAddress == null) return;
            object debtID = gbList.GetFocusedRowCellValue("ID");
            if (debtID == null) return;
            object debtRefOrgNo = gbList.GetFocusedRowCellValue("RefOrgNo");
            if (debtRefOrgNo == null) return;


            var phieuThu = new XfmPhieuThu();
            phieuThu.Success += PhieuThuSuccess;
            phieuThu.SetData(customerAddress.ToString(), customerID.ToString(), phieu.ToString(),
                             Convert.ToDateTime(ngay), Convert.ToDecimal(soTien), Convert.ToDecimal(daTra),
                             Convert.ToDecimal(conLai), new Guid(debtID.ToString()), new Guid(debtRefOrgNo.ToString()));
            phieuThu.ShowDialog(this);
        }
         */

        public void Detail()
        {
            object arg = gbList.GetFocusedRowCellValue("ID");
            if (arg == null) return;

            var recepit = new CUSTOMER_RECEIPT();
            if (recepit.Get(arg.ToString()))
            {
                var phieuThu = new XfmPhieuThu();
                phieuThu.Success += PhieuThuSuccess;
                phieuThu.SetData(recepit);
                phieuThu.ShowDialog(this);
            }
        }

        private void PhieuThuSuccess()
        {
            Reload();
        }

        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiReciept")) return;
           
            //Get Object
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return; // receiptID
            object refid = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefID");
            if (refid == null) return;// phieuthuID
            object refOrgNo = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefOrgNo");
            if (refOrgNo == null) return;// phieu ban hang

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", refid.ToString());
            Delete(arg.ToString(), refOrgNo.ToString());

            //if (refid.ToString() != refOrgNo.ToString())
            //{
            //    SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", refid.ToString());
            //    Delete(arg.ToString(), refOrgNo.ToString());
            //}
            //else
            //{
            //    DeletePhieuTong(arg.ToString(), refid.ToString(), refOrgNo.ToString());
            //}
            Reload();
        }

        private void DeletePhieuTong(string ReceiptID, string PhieuThuID, string PhieuBanHang)
        {
            CUSTOMER_RECEIPT cr = new CUSTOMER_RECEIPT 
            { 
                ID = ReceiptID 
            };
            cr.Get();
            //cr.Delete();

            //Receipt detail
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;
            string[] myParam = { "@ReceiptID" };
            object[] myValues = { ReceiptID };
            string cmdText = @"SELECT * FROM CUSTOMER_RECEIPT_DETAIL crd WHERE crd.ReceiptID = @ReceiptID";
            System.Data.DataTable dtReceiptDetail = mySql.ExecuteDataTable(cmdText, myParam, myValues);
            //

            foreach (System.Data.DataRow dr in dtReceiptDetail.Rows)
            {
                string receiptDetailID = Convert.ToString(dr["ID"]).ToUpper();
                string debtID = Convert.ToString(dr["RefOrgNo"]).ToUpper();
                //decimal PaidMoney = Convert.ToDecimal(dr["Payment"]);

                CUSTOMER_RECEIPT_DETAIL crd = new CUSTOMER_RECEIPT_DETAIL();
                crd.Delete(receiptDetailID);

                var debt = new Perfect.ERP.DEBT();
                debt.Get(debtID);
                debt.IsChanged = debt.Amount != debt.Balance;
                // đã có trigger update debt khi xóa trong CUSTOMER_RECEIPT_DETAIL

                crd.UpdateSaleTable(debt.RefID, debt.Amount != debt.Balance);
            }

            cr.Delete();
        }

        public string Delete(string id, string refORg)
        {

            var cls = new CUSTOMER_RECEIPT();

            if (!cls.Delete(id,refORg))
            {
                 return "Không xóa được!";
            }
            return "OK";
        }

        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiReciept")) return;
           
            //if (gbList.RowCount == 0)
            //{
            //    XtraMessageBox.Show("Không có dữ liệu để in.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string from = SYS_OPTION.Language == "VN" ? "Từ " : "From ";
            //string to = SYS_OPTION.Language == "VN" ? " đến " : " to ";


            //var rpt = new rptInwardList(dsSTOCK_INWARD_DETAIL.STOCK_INWARD_ByDate, "RD0000016", "Bảng Kê Nhập Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            //rpt.ShowPreview();
           
        }

        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiReciept")) return false;
            _exportView = gbList;
            SysLog.Insert("Bảng Kê Nhập Kho", "Xuất");
            return true;
        }

        public override void History()
        {
            object arg =gbList.GetFocusedRowCellValue("Product_ID");

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public override void ProductDetail()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
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
            object arg = gbList.GetFocusedRowCellValue("Product_ID");

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(product.Product_ID, "");
            xfmInventoryDetail.ShowDialog(this);
        }

        

        private void GbListClick(object sender, EventArgs e)
        {
           // Detail();
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

            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            Bar.Bar.bbiProduct.Enabled = false;
            if (arg != null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
            }
        }
    }
}