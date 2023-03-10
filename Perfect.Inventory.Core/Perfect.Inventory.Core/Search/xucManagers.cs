using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;

namespace Perfect.Inventory
{
    public partial class xucManagers : xucBase
    {
        BaseView exportView;

        public event ButtonClickEventHander CloseClick;

        public delegate void ViewClick(string id, string status);

        public delegate void ChangedkEventHander(object sender, int refType,string id);

        private event ChangedkEventHander Changed;

        private void RaiseChanged(int refType,string id)
        {
            ChangedkEventHander changed = Changed;
            if (changed != null) changed(this, refType,id);
        }


        public event ViewClick View;

        //public void RaiseViewClickEventHandle(string Id, string status)
        //{
        //    if (View != null) View(Id, status);
        //}

        public void RaiseCloseClickEventHandle()
        {
            if (CloseClick != null) CloseClick(this);
        }



        public xucManagers()
        {
            InitializeComponent();
            dtFrom.DateTime = DateTime.Today;
            dtTo.DateTime = DateTime.Today;
            dtFrom1.DateTime = DateTime.Today;
            dtTo1.DateTime = DateTime.Today;
            bm.SetPopupContextMenu(gcList,pm);
            Init();
            
        }

        public void Init()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Nạp danh sách khách hàng...");
            Customer_Init();
            SetWaitDialogCaption("Nạp danh sách Nhà Phân Phối...");
            Provider_Init();
            SetWaitDialogCaption("Nạp danh sách Kho Hàng...");
            Stock_Init();

            dsREFTYPE.REFTYPE.AddREFTYPERow(0, "Đầu Kỳ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(1, "Nhập Hàng");
            dsREFTYPE.REFTYPE.AddREFTYPERow(2, "Xuất Hàng");
            dsREFTYPE.REFTYPE.AddREFTYPERow(3, "Lắp Ráp");
            dsREFTYPE.REFTYPE.AddREFTYPERow(4, "Tháo Gỡ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(5, "Kiểm Kê");
            dsREFTYPE.REFTYPE.AddREFTYPERow(6, "Xuất và Đóng Gói");
            dsREFTYPE.REFTYPE.AddREFTYPERow(7, "Đóng Gói Bán Thành Phẩm");
            dsREFTYPE.REFTYPE.AddREFTYPERow(8, "Đóng Gói Thành Phẩm");
            dsREFTYPE.REFTYPE.AddREFTYPERow(9, "Chuyển Kho");
            dsREFTYPE.REFTYPE.AddREFTYPERow(10, "Quản Lý Kho");
            //
            dsREFTYPE.REFTYPE.AddREFTYPERow(20, "Quản Lý Bán Hàng");
            dsREFTYPE.REFTYPE.AddREFTYPERow(21, "Phiếu Bán Hàng");
            dsREFTYPE.REFTYPE.AddREFTYPERow(22, "Phiếu Bán Lẻ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(23, "Phiếu Mua Hàng");
            
            //
            dsREFTYPE.REFTYPE.AddREFTYPERow(30, "Quản Lý Công Nợ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(31, "Số Dư Công Nợ Khách Hàng");
            dsREFTYPE.REFTYPE.AddREFTYPERow(32, "Số Dư Công Nợ Nhà Phân Phối");
            dsREFTYPE.REFTYPE.AddREFTYPERow(33, "Số Dư Công Nợ Nhân Viên");
            dsREFTYPE.REFTYPE.AddREFTYPERow(34, "Số Dư Quỹ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(35, "Phiếu Thu Tiền Nợ Khách Hàng");
            dsREFTYPE.REFTYPE.AddREFTYPERow(36, "Phiếu Chi Tiền Nợ Nhà Phân Phối");
            //
            dsREFTYPE.REFTYPE.AddREFTYPERow(40, "Quản Lý Quỹ");
            dsREFTYPE.REFTYPE.AddREFTYPERow(41, "Phiếu Thu Tiền Bán Hàng");
            dsREFTYPE.REFTYPE.AddREFTYPERow(42, "Phiếu Chi Tiền Mua Hàng");
            


            DoHide();

        }

        public void Customer_Init()
        {
            //cUSTOMERTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //cUSTOMERTableAdapter.Fill(dsCUSTOMERS.CUSTOMER);
            //DataRow dr = dsCUSTOMERS.CUSTOMER.NewCUSTOMERRow();
            //dr["Customer_ID"] = "All";
            //dr["CustomerName"] = "(Tất Cả)";
            //dsCUSTOMERS.CUSTOMER.Rows.InsertAt(dr, 0);
        }

        public void Provider_Init()
        {
            //pROVIDERTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //pROVIDERTableAdapter.Fill(dsPROVIDER.PROVIDER);
            //DataRow dr = dsPROVIDER.PROVIDER.NewPROVIDERRow();
            //dr["Customer_ID"] = "All";
            //dr["CustomerName"] = "(Tất Cả)";
            //dsPROVIDER.PROVIDER.Rows.InsertAt(dr, 0);
        }


        public void Stock_Init()
        {
            //sTOCKTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
            //DataRow dr = dsSTOCK.STOCK.NewSTOCKRow();
            //dr["Stock_ID"] = "All";
            //dr["Stock_Name"] = "(Tất Cả)";
            //dsSTOCK.STOCK.Rows.InsertAt(dr, 0);
        }



        private void btView_Click(object sender, EventArgs e)
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var transaction = new TRANS_REF();
            dsTRANSACTION.TRANS_REF.Rows.Clear();
            if (rgAll.SelectedIndex == 0)
            {
                dsTRANSACTION.TRANS_REF.Merge(transaction.GetListByAll());
            }
            else
            {
                dsTRANSACTION.TRANS_REF.Merge(transaction.GetList(dtFrom.DateTime, dtTo.DateTime));    
            }
            SetWaitDialogCaption("Hoàn tất.");
            DoHide();
            
        }
      
        private void btClose_Click(object sender, EventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close();
        }

        private void gbList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gcList_Click(object sender, EventArgs e)
        {



        }

        public object GetCellValue(int rowIndex, string fieldName)
        {
            object result = GetCellValue(new RowClickEventArgs(rowIndex, fieldName));
            return result;
        }

        public object GetCellValue(int rowIndex, int columIndex)
        {
            object result = GetCellValue(new RowClickEventArgs(rowIndex, columIndex));
            return result;
        }

        public object GetCellValue(RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var Col = new GridColumn();

            Col = e.ColumnIndex != -1 ? view.Columns[e.ColumnIndex] : view.Columns[e.FieldName];
            object result = view.GetRowCellValue(e.RowIndex, Col);
            return result;
        }
        
        
        private void rgAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtTo.Enabled = false;
            dtFrom.Enabled = false;
            if (rgAll.SelectedIndex == 1)
            {
                dtTo.Enabled = true;
                dtFrom.Enabled = true;
            }

        }

        
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btView_Click(sender,e);
        }

        private void bbiViewAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rgAll.SelectedIndex = 0;
            btView_Click(sender, e);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close();
        }

        private void bbiProductDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }

        private void bbiHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID");

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        private void bbiInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string result = string.Empty;
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID");

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(product.Product_ID, "");
            xfmInventoryDetail.ShowDialog(this);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export(gbList);

        }

        public void DisableMenu(bool disable)
        {
            bbiPrint.Enabled = !disable;
            bbiExport.Enabled = !disable;
            bbiProduct.Enabled = !disable;
            bbiEdit.Enabled = !disable;
            bbiUp.Enabled = !disable;
            bbiDown.Enabled = !disable;
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            var view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID");

            bbiProduct.Enabled = true;
            if (arg == null)
            {
                bbiProduct.Enabled = false;
                return;
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            int status=-1;
            object arg = GetCellValue(ex.RowIndex, "ID");
            status = Convert.ToInt32(gbList.GetFocusedRowCellValue("RefType")??-1);
            if (arg == null) return;

            RaiseChanged(status,arg.ToString());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            rgAll.SelectedIndex = 1;
            btView_Click(sender,e);
            pcc.HidePopup();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pcc.HidePopup();
        }

        private void dtFrom1_EditValueChanged(object sender, EventArgs e)
        {
            dtFrom.DateTime = dtFrom1.DateTime;
        }

        private void dtTo1_EditValueChanged(object sender, EventArgs e)
        {
            dtTo.DateTime = dtTo1.DateTime;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (gbList.RowCount == 0) return;
            int rowindex = gbList.FocusedRowHandle;
            if (rowindex>0)
            {
                var dt = dsTRANSACTION.TRANS_REF;

        
                 object[] ob=new object[6];
                 ob[0] = dt.Rows[rowindex]["RefID"];
                 ob[1] = dt.Rows[rowindex]["RefDate"];
                 ob[2] = dt.Rows[rowindex]["RefType"];
                 ob[3] = dt.Rows[rowindex]["Description"];
                 ob[4] = dt.Rows[rowindex]["Active"];
                 ob[5] = dt.Rows[rowindex]["ID"];
                 

                dt.Rows[rowindex]["RefID"] = dt.Rows[rowindex-1]["RefID"];
                dt.Rows[rowindex]["RefDate"] = dt.Rows[rowindex-1]["RefDate"];
                dt.Rows[rowindex]["RefType"] = dt.Rows[rowindex-1]["RefType"];
                dt.Rows[rowindex]["Description"] = dt.Rows[rowindex-1]["Description"];
                dt.Rows[rowindex]["Active"] = dt.Rows[rowindex-1]["Active"];
                dt.Rows[rowindex]["ID"] = dt.Rows[rowindex-1]["ID"];


                dt.Rows[rowindex - 1]["RefID"] = ob[0];
                dt.Rows[rowindex - 1]["RefDate"] = ob[1];
                dt.Rows[rowindex - 1]["RefType"] = ob[2];
                dt.Rows[rowindex - 1]["Description"] = ob[3];
                dt.Rows[rowindex - 1]["Active"] = ob[4];
                dt.Rows[rowindex - 1]["ID"] = ob[5];

                dt.AcceptChanges();
                gbList.FocusedRowHandle = rowindex - 1;
               
            }
            
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (gbList.RowCount==0) return;
            int rowindex = gbList.FocusedRowHandle;

            if ((rowindex < gbList.RowCount - 1) & rowindex>0)
            {
                var dt = dsTRANSACTION.TRANS_REF;
               
                object[] ob = new object[6];
                ob[0] = dt.Rows[rowindex]["RefID"];
                ob[1] = dt.Rows[rowindex]["RefDate"];
                ob[2] = dt.Rows[rowindex]["RefType"];
                ob[3] = dt.Rows[rowindex]["Description"];
                ob[4] = dt.Rows[rowindex]["Active"];
                ob[5] = dt.Rows[rowindex]["ID"];


                dt.Rows[rowindex]["RefID"] = dt.Rows[rowindex + 1]["RefID"];
                dt.Rows[rowindex]["RefDate"] = dt.Rows[rowindex + 1]["RefDate"];
                dt.Rows[rowindex]["RefType"] = dt.Rows[rowindex + 1]["RefType"];
                dt.Rows[rowindex]["Description"] = dt.Rows[rowindex + 1]["Description"];
                dt.Rows[rowindex]["Active"] = dt.Rows[rowindex + 1]["Active"];
                dt.Rows[rowindex]["ID"] = dt.Rows[rowindex + 1]["ID"];


                dt.Rows[rowindex + 1]["RefID"] = ob[0];
                dt.Rows[rowindex + 1]["RefDate"] = ob[1];
                dt.Rows[rowindex + 1]["RefType"] = ob[2];
                dt.Rows[rowindex + 1]["Description"] = ob[3];
                dt.Rows[rowindex + 1]["Active"] = ob[4];
                dt.Rows[rowindex + 1]["ID"] = ob[5];

                dt.AcceptChanges();
                gbList.FocusedRowHandle = rowindex + 1;

            }
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu");

            var dt = dsTRANSACTION.TRANS_REF;

            Cursor.Current = Cursors.WaitCursor;

            var mySql = new SqlHelper();

            var result = mySql.Start();
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transaction = new TRANS_REF();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result = transaction.UpdateBySorted(mySql.Transaction, dt.Rows[i]["ID"].ToString(),
                                            Convert.ToInt64(dt.Rows[i]["Sorted"]));

                SetWaitDialogCaption("Đang cập nhật " + dt.Rows[i]["RefID"]);

                if (result != "OK")
                {
                    DoHide();
                    mySql.RollBack();
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (result=="OK")
            {
                mySql.Commit();
                SetWaitDialogCaption("Cập nhật thành công");
                DoHide();
                btView_Click(sender,e);
            }
                 
        }

        private void bbiUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUp_Click(sender,e);
        }

        private void bbiDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDown_Click(sender,e);
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSave_Click(sender,e);
        }
    }
}
