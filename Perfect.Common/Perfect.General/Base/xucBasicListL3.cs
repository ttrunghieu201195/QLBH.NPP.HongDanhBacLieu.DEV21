using System;
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
    public partial class xucBasicListL3 : xucBase
    {
        #region Delegates

        public delegate void SendIdEventHander(object sender, string id);
        public delegate void ChangedEventHander(object sender, string id, int refType);

        public delegate void AddedEventHander(object sender, string id);
 
        public event ChangedEventHander Changed;

        protected void RaiseChangedEventHander(string id, int refType)
        {
            ChangedEventHander changed = Changed;
            if (changed != null) changed(this, id, refType);
        }

        #endregion

        private ListType _listType = ListType.General;

        protected RowClickEventArgs RowClick = new RowClickEventArgs();
        protected RowClickEventArgs DetailRowClick = new RowClickEventArgs();

        public xucBasicListL3()
        {
            InitializeComponent();
           // Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
           // Bar.Bar.bm.SetPopupContextMenu(gcDetail, Bar.Bar.pmDetail);
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
            get { return _listType; }
            set { _listType = value; }
        }

        public void Stock_Init()
        {
            sTOCKTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
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

            //FormatColumns(rpgProduct, "Product_ID", 0, 100, "Mã Hàng");
            //FormatColumns(rpgProduct, "Product_Name", 1, 200, "Mã Hàng");

            //FormatColumns(rpUnit, "Unit_ID", 1, 100, "Mã");
            //FormatColumns(rpUnit, "Unit_Name", 0, 200, "Đơn Vị");

            //FormatColumns(rpProductName, "Product_ID", 1, 100, "Mã Hàng");
            //FormatColumns(rpProductName, "Product_Name", 0, 200, "Hàng Hoá");

            ////FormatColumns(rpToStock, "Stock_ID", 1, 100, "Mã");
            ////FormatColumns(rpToStock, "Stock_Name", 0, 200, "Kho Hàng");

            //FormatColumns(rpgStock, "Stock_ID", 1, 100, "Mã");
            //FormatColumns(rpgStock, "Stock_Name", 0, 200, "Kho Hàng");

            Bar.ViewClick += ucToolBar_ViewClick;
            Bar.ExportClick += ucToolBar_ExportClick;
            Bar.PrintClick += ucToolBar_PrintClick;
            Bar.EditClick += ucToolBar_EditClick;
            Bar.DeleteClick += ucToolBar_DeleteClick;
            Bar.AddClick += ucToolBar_AddClick;
            
            Bar.DetailClick += ucToolBar_DetailClick;
            Bar.HelpClick += ucToolBar_HelpClick;
            Bar.CloseClick += ucToolBar_CloseClick;
            Bar.ProductDetailClick += ucToolBar_ProductDetailClick;
            Bar.HistoryClick += ucToolBar_HistoryClick;
            Bar.InventoryClick += ucToolBar_InventoryClick;
            Bar.DetailHistoryClick += new ButtonClickEventHander(ucToolBar_DetailHistoryClick);
            Bar.DetailInventoryClick += new ButtonClickEventHander(ucToolBar_DetailInventoryClick);
            Bar.DetailProductClick += new ButtonClickEventHander(ucToolBar_DetailProductClick);
            Bar.CopyClick += new ButtonClickEventHander(ucToolBar_CopyClick);
            Bar.MirrorClick += new ButtonClickEventHander(ucToolBar_MirrorClick);
            Bar.CustomColumnClick += new ButtonClickEventHander(Bar_CustomColumnClick);
            DisableMenu(true);
            From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            To = From.AddMonths(1).AddDays(-1);

            DoHide();
        }

        void Bar_CustomColumnClick(object sender)
        {
            CustomColumn();
        }

        protected virtual void CustomColumn()
        { }

        public virtual void Mirror()
        {
        }

        void ucToolBar_MirrorClick(object sender)
        {
            Mirror();
        }

        void ucToolBar_CopyClick(object sender)
        {
            Copy();
        }

        protected virtual void  Copy()
        {
            
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

        

        private void ucToolBar_CloseClick(object sender)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        private void ucToolBar_HelpClick(object sender)
        {
        }
        
        protected void DetailView()
        {
            _listType = ListType.Detail;
            lgDetail.Visibility = LayoutVisibility.Never;
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
            Add();
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
           // if (!ExportPermision()) return;
            Export();
        }

        private void ucToolBar_ViewClick(object sender)
        {
            //_ListStyle = Perfect.Common._ListStyle.General;
            //Bar.Detail.Text = "Chi Tiết";
            //Bar.Detail.Checked = false;
            //lcgDetail.Visibility = LayoutVisibility.Always;
            Reload();
        }

        
        

        //protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        //{
        //    Detail();
        //}

        //protected virtual void gbList_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        Detail();
        //    }
        //    else if (e.KeyCode == Keys.Delete)
        //    {
        //        Delete();
        //    }
        //}

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

        public virtual void Add()
        {
            
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
        
        #region User function

        protected virtual void MakerInterface()
        {
            
        }

        protected virtual void SaveInterface()
        {
            //CONTROL_FORMAT.Save("xucBasicListX", "EN");
        }

        protected virtual void SetInterface()
        {
          
        }

        public event SendIdEventHander SendId;

        public event ButtonClickEventHander AddNewClick;

        public delegate void ButtonClick2EventHander(string id);

        public event ButtonClick2EventHander AddNewClick2;
        public void InvokeAddNewClick2(string id)
        {
            var click2 = AddNewClick2;
            if (click2 != null) click2(id);
        }

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
            //AdvBandedGridView view = gbDetail;
            //var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
            //                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
            //                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //DetailRowClick = ex;

            //DisableMenu(false);
            //if (gbList.RowCount == 0)
            //{
            //    DisableMenu(true);
            //    return;
            //}

            //// bbiDetail.Enabled = !chxDetail.Checked;

            //object Arg;
            //Arg = GetCellValue(ex.RowIndex, "Product_ID",gbDetail);
            //Bar.Bar.bbiDetails.Enabled = false;
            //if (Arg != null)
            //{
            //    Bar.Bar.bbiDetails.Enabled = true;
            //}
        }
    }
}