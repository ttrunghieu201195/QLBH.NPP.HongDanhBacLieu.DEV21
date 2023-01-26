using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using Perfect.ERP;
using Perfect.Data.Helper;

namespace Perfect.Common
{
    public partial class xucBasicListLS : xucBase
    {
        #region Delegates

        public delegate void SendIdEventHander(object sender, string id);

        #endregion

        private ListType _ListStyle = ListType.General;

        protected RowClickEventArgs RowClick = new RowClickEventArgs();
        protected RowClickEventArgs DetailRowClick = new RowClickEventArgs();


        public xucBasicListLS()
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Bar.Bar.bm.SetPopupContextMenu(gcDetail, Bar.Bar.pmDetail);
        }

        public DateTime From
        {
            get { return Bar.From; }
            private set { Bar.From = value; }
        }

        public DateTime To
        {
            get { return Bar.To; }
            private set { Bar.To = value; }
        }

        public ListType ListStyle
        {
            get { return _ListStyle; }
            set { _ListStyle = value; }
        }

        public void Stock_Init()
        {
            sTOCKTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
            DataRow dr = dsSTOCK.STOCK.NewSTOCKRow();
            dr["Stock_ID"] = "All";
            dr["Stock_Name"] = "(Mặc định)";
            dsSTOCK.STOCK.Rows.InsertAt(dr, 0);
        }

        public void Product_Init()
        {
            pRODUCTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCTTableAdapter.Fill(dsPRODUCT.PRODUCT);
        }

        public void Unit_Init()
        {
            uNITTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            uNITTableAdapter.Fill(dsUNIT.UNIT);
        }

        public void Init()
        {
            //CreateWaitDialog();

            SetWaitDialogCaption("Nạp danh sách khách hàng...");
            Stock_Init();
            SetWaitDialogCaption("Nạp danh sách hàng hoá...");
            Product_Init();
            SetWaitDialogCaption("Nạp danh sách đơn vị...");
            Unit_Init();

            FormatColumns(rpgProduct, "Product_ID", 0, 100, "Mã Hàng");
            FormatColumns(rpgProduct, "Product_Name", 1, 200, "Mã Hàng");

            FormatColumns(rpUnit, "Unit_ID", 1, 100, "Mã");
            FormatColumns(rpUnit, "Unit_Name", 0, 200, "Đơn Vị");

            FormatColumns(rpProductName, "Product_ID", 1, 100, "Mã Hàng");
            FormatColumns(rpProductName, "Product_Name", 0, 200, "Hàng Hoá");

            //FormatColumns(rpToStock, "Stock_ID", 1, 100, "Mã");
            //FormatColumns(rpToStock, "Stock_Name", 0, 200, "Kho Hàng");

            FormatColumns(rpgStock, "Stock_ID", 1, 100, "Mã");
            FormatColumns(rpgStock, "Stock_Name", 0, 200, "Kho Hàng");

            Bar.ViewClick += ucToolBar_ViewClick;
            Bar.ExportClick += ucToolBar_ExportClick;
            Bar.PrintClick += ucToolBar_PrintClick;
            Bar.EditClick += ucToolBar_EditClick;
            Bar.DeleteClick += ucToolBar_DeleteClick;
            Bar.AddClick += ucToolBar_AddClick;
            Bar.DetailClick += ucToolBar_DetailClick;
            Bar.DetailViewClick += ucToolBar_DetailViewClick;
            Bar.HelpClick += ucToolBar_HelpClick;
            Bar.CloseClick += ucToolBar_CloseClick;
            Bar.ViewChangedClick += ucToolBar_ViewChangedClick;
            Bar.ProductDetailClick += ucToolBar_ProductDetailClick;
            Bar.HistoryClick += ucToolBar_HistoryClick;
            Bar.InventoryClick += ucToolBar_InventoryClick;
            Bar.DetailHistoryClick += new ButtonClickEventHander(ucToolBar_DetailHistoryClick);
            Bar.DetailInventoryClick += new ButtonClickEventHander(ucToolBar_DetailInventoryClick);
            Bar.DetailProductClick += new ButtonClickEventHander(ucToolBar_DetailProductClick);
            Bar.CopyClick += new ButtonClickEventHander(ucToolBar_CopyClick);
            Bar.MirrorClick += new ButtonClickEventHander(ucToolBar_MirrorClick);
            DisableMenu(true);
            From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            To = From.AddMonths(1).AddDays(-1);

            Bar.Merrial.Enabled = false;

            DoHide();
        }

        public virtual void Mirror()
        {
        }

        void ucToolBar_MirrorClick(object sender)
        {
            Mirror();
        }

        void ucToolBar_CopyClick(object sender)
        {
            gbList.CopyToClipboard();
        }

        void ucToolBar_DetailProductClick(object sender)
        {
            DetailProduct();
        }

        void ucToolBar_DetailInventoryClick(object sender)
        {
            DetailInventory();
        }

        public virtual void DetailProduct()
        {
        }

        public virtual void DetailInventory()
        {
        }

        public virtual void DetailHistory()
        {
        }

        void ucToolBar_DetailHistoryClick(object sender)
        {
            DetailHistory();
        }

        public virtual void Inventory()
        {
        }

        private void ucToolBar_InventoryClick(object sender)
        {
            Inventory();
        }

        private void ucToolBar_HistoryClick(object sender)
        {
            History();
        }

        public virtual void ProductDetail()
        {
        }

        public virtual void History()
        {
        }

        private void ucToolBar_ProductDetailClick(object sender)
        {
            ProductDetail();
        }

        private void ucToolBar_ViewChangedClick(object sender)
        {
            Bar.Detail.Enabled = false;

            if (Bar.IsMerrial)
            {
                //_ListStyle = _ListStyle.Detail;
                Bar.Merrial.Text = "Vật Tư";
                if (Bar.Checked)
                {
                    Bar.Merrial.Enabled = true;
                    _ListStyle = ListType.Detail;
                    Bar.Detail.Text = "Tổng Hợp";
                    lcgDetail.Visibility = LayoutVisibility.Never;

                }
                else
                {
                    Bar.Merrial.Enabled = false;
                    _ListStyle = ListType.General;
                    Bar.Detail.Text = "Chi Tiết";
                    lcgDetail.Visibility = LayoutVisibility.Always;
                }
            }
            else
            {
                Bar.Merrial.Text = "Thành Phẩm";
                
                if (Bar.Checked)
                {
                    Bar.Merrial.Enabled = true;
                    _ListStyle = ListType.Detail;
                    Bar.Detail.Text = "Tổng Hợp";
                    lcgDetail.Visibility = LayoutVisibility.Never;
                }
                else
                {
                    Bar.Merrial.Enabled = false;
                    _ListStyle = ListType.General;
                    Bar.Detail.Text = "Chi Tiết";
                    lcgDetail.Visibility = LayoutVisibility.Always;
                }
            }
            Reload();
            Bar.Detail.Enabled = true;
        }

        private void ucToolBar_CloseClick(object sender)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        private void ucToolBar_HelpClick(object sender)
        {
        }
        
        private void ucToolBar_DetailViewClick(object sender)
        {
            _ListStyle = ListType.Detail;
            Bar.Detail.Text = "Tổng Hợp";
            lcgDetail.Visibility = LayoutVisibility.Never;
            Reload();
        }

        public virtual void Detail()
        {
        }

        private void ucToolBar_DetailClick(object sender)
        {
            Detail();
        }

        private void ucToolBar_AddClick(object sender)
        {
            RaiseAddNewClickEventHander();
        }

        private void ucToolBar_DeleteClick(object sender)
        {
            Delete();
        }

        private void ucToolBar_EditClick(object sender)
        {
            Edit();
        }

        private void ucToolBar_PrintClick(object sender)
        {
            Print();
        }

        private void ucToolBar_ExportClick(object sender)
        {
            if (!ExportPermision()) return;
            _exportView = gbList;
            Export();
        }

        private void ucToolBar_ViewClick(object sender)
        {
            _ListStyle = ListType.General;
            Bar.Detail.Text = "Chi Tiết";
            Bar.Detail.Checked = false;
            lcgDetail.Visibility = LayoutVisibility.Always;
            Reload();
        }

        protected virtual void gbList_Click(object sender, EventArgs e)
        {
            var view = (AdvBandedGridView) sender;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            RowClick = ex;
        }

        protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        {
            Detail();
        }

        protected virtual void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Detail();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
        }

        protected virtual void List_Init(AdvBandedGridView dt)
        {
        }

        protected virtual void List_Init_Detail(AdvBandedGridView dt)
        {
        }

        protected virtual void List_Init_General(AdvBandedGridView dt)
        {
        }

        protected virtual void Print()
        {
            XtraMessageBox.Show("Don't support.");
        }

        public virtual void Reload()
        {
        }

        public virtual void Delete()
        {
        }

        public virtual void Edit()
        {
        }

        public object GetCellValue(RowClickEventArgs e)
        {
            object Result = null;
            AdvBandedGridView view = gbList;
            var Col = new GridColumn();

            if (e.ColumnIndex != -1)
            {
                Col = view.Columns[e.ColumnIndex];
            }
            else
            {
                Col = view.Columns[e.FieldName];
            }
            Result = view.GetRowCellValue(e.RowIndex, Col);
            // if (Result == null | e.RowIndex > gbList.RowCount) VnMessageBox.Error("Không thể lấy thông tin.", "Thông báo");
            return Result;
        }

        public object GetCellValue(int rowIndex, int columIndex)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(rowIndex, columIndex));
            return Result;
        }

        public object GetCellValue(int rowIndex, string fieldName)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(rowIndex, fieldName));
            return Result;
        }

        protected void Total()
        {
            //double qty = 0.0;
            //double amt = 0.0;

            // if (chxDetail.Checked)
            // {

            //     for (int i = 0; i < gbList.RowCount; i++)
            //     {
            //         qty += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity")==DBNull.Value?0:gbList.GetRowCellValue(i, "Quantity"));
            //         amt += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
            //     }
            //     txtQuantity.Value = Convert.ToDecimal(qty);
            //     txtAmount.Value = Convert.ToDecimal(amt);

            //     return;
            // }

            // for (int i = 0; i < dgvDetail.Rows.Count; i++)
            //{
            //    qty += Convert.ToDouble(dgvDetail["Quantity", i].Value);
            //    amt += Convert.ToDouble(dgvDetail["Amount", i].Value);
            //}
            //txtQuantity.Value = Convert.ToDecimal(qty);
            //txtAmount.Value = Convert.ToDecimal(amt);
        }

        protected virtual void gbList_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //gbList_Click(gbList, e);
            RowClick.ColumnIndex = e.Column.ColumnHandle;
            RowClick.FieldName = e.Column.FieldName;
            RowClick.RowIndex = e.RowHandle;
        }

        protected virtual void gbList_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            //gbList_Click(gbList, e);
        }

        protected virtual void gbList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                RowClick.ColumnIndex = e.HitInfo.Column.ColumnHandle;
                RowClick.FieldName = e.HitInfo.Column.FieldName;
                RowClick.RowIndex = e.RowHandle;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected virtual void gbList_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
            }
        }

        public void DisableMenu(bool disable)
        {
            Bar.Bar.bbiCopy.Enabled = !disable;
            Bar.Bar.bbiEdit.Enabled = !disable;
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiDelete.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
            Bar.Bar.bbiDetail.Enabled = !disable;
            Bar.Bar.bbiDetails.Enabled = !disable;
            Bar.Bar.bbiEdit.Enabled = !disable;
            Bar.Bar.bbiDelete.Enabled = !disable;
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiCopy.Enabled = !disable;
            Bar.Bar.bbiMirror.Enabled = !disable;
            Bar.Bar.bbiDetailProduct.Enabled = !disable;
            Bar.Bar.bbiDetail.Enabled = !disable;
            
            
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            RowClick = ex;
            DisableMenu(false);
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            // bbiDetail.Enabled = !chxDetail.Checked;

            object Arg;
            Arg = GetCellValue(ex.RowIndex, "Product_ID");
            Bar.Bar.bbiProduct.Enabled = false;
            if (Arg != null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
            }
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

        private void gbDetail_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        #region User function

        protected virtual void MakerInterface()
        {
            //CONTROL_FORMAT cf = new CONTROL_FORMAT();
            //for (int i = 0; i < plTop.Controls.Count; i++)
            //{
            //    if (plTop.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "xucBasicListX", plTop.Controls[i].Name, "EN", plTop.Controls[i].Text, "", true);
            //    }
            //}

            //for (int i = 0; i < plButtom.Controls.Count; i++)
            //{
            //    if (plButtom.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "xucBasicListX", plButtom.Controls[i].Name, "EN", plButtom.Controls[i].Text, "", true);
            //    }
            //}
        }

        protected virtual void SaveInterface()
        {
            CONTROL_FORMAT.Save("xucBasicListX", "EN");
        }

        protected virtual void SetInterface()
        {
            // DataTable dt = CONTROL_FORMAT.Load("xucBasicListX");

            // CONTROL_FORMAT.ContainerChangeLanguage(plTop, ref dt);
            // CONTROL_FORMAT.ContainerChangeLanguage(plButtom, ref dt);
        }

        public event SendIdEventHander SendId;

        public event ButtonClickEventHander AddNewClick;

        public event ButtonClickEventHander CloseClick;

        protected void RaiseSendIdEventHander(string id)
        {
            if (SendId != null)
            {
                SendId(this, id);
            }
        }

        protected void RaiseAddNewClickEventHander()
        {
            if (AddNewClick != null)
            {
                AddNewClick(this);
            }
        }

        private void RaiseCloseClickEventHander()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }

        protected virtual bool ExportPermision()
        {
            return true;
        }

        #endregion

        private void gbDetail_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            DetailRowClick.ColumnIndex = e.Column.ColumnHandle;
            DetailRowClick.FieldName = e.Column.FieldName;
            DetailRowClick.RowIndex = e.RowHandle;
        }

        private void gbDetail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DetailRowClick.ColumnIndex = e.HitInfo.Column.ColumnHandle;
                DetailRowClick.FieldName = e.HitInfo.Column.FieldName;
                DetailRowClick.RowIndex = e.RowHandle;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void gbDetail_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView view = gbDetail;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            DetailRowClick = ex;

            DisableMenu(false);
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            // bbiDetail.Enabled = !chxDetail.Checked;

            object Arg;
            Arg = GetCellValue(ex.RowIndex, "Product_ID",gbDetail);
            Bar.Bar.bbiDetails.Enabled = false;
            if (Arg != null)
            {
                Bar.Bar.bbiDetails.Enabled = true;
            }
        }
    }
}