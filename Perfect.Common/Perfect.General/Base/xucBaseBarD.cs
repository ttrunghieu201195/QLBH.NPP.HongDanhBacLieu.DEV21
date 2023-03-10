using System;
using System.Data;
using System.Windows.Forms;
using Perfect.Data.Helper;

namespace Perfect.Common
{
    public partial class xucBaseBarD : xucBase
    {
        #region Deletegate & Event

        public event ButtonClickEventHander ExportClick;
        public event ButtonClickEventHander AddClick;
        public event ButtonClickEventHander EditClick;
        public event ButtonClickEventHander ChangeClick;
        public event ButtonClickEventHander DeleteClick;
        public event ButtonClickEventHander RefreshClick;
        public event ButtonClickEventHander PrintClick;
        public event ButtonClickEventHander CloseClick;
        public event ButtonClickEventHander OptionClick;
        public event ButtonClickEventHander SaveClick;
        public event ButtonClickEventHander CancleClick;
        public event ButtonClickEventHander SaveNewClick;
        public event ButtonClickEventHander SearchClick;
        public event ButtonClickEventHander HelpClick;
        public event ButtonClickEventHander ImportClick;
        public event ButtonClickEventHander PermisionClick;
        public event ButtonClickEventHander ConstructClick;
        public event ButtonClickEventHander CopyClick;
        public event ButtonClickEventHander MirrorClick;
        public event ButtonClickEventHander ClearClick;
        public event ButtonClickEventHander ProductDetailClick;
        public event ButtonClickEventHander HistoryClick;
        public event ButtonClickEventHander InventoryClick;
        public event ButtonClickEventHander SaveDataTempClick;
        public event ButtonClickEventHander RestoreDataTempClick;
        public event ButtonClickEventHander SaveDataToFileClick;
        public event ButtonClickEventHander ReadDataFromFileClick;
        public event ButtonClickEventHander SaveLayoutClick;
        public event ButtonClickEventHander ReadLayoutClick;
        public event ButtonClickEventHander SelectAllClick;
        public event ButtonClickEventHander SaveDataByIdClick;
        public event ButtonClickEventHander ReadDataByIdClick;
        public event ButtonClickEventHander ViewClick;
        public event ButtonClickEventHander DetailViewClick;
        public event ButtonClickEventHander DetailClick;
        public event ButtonClickEventHander ViewChangedClick;
        public event ButtonClickEventHander DetailProductClick;
        public event ButtonClickEventHander DetailHistoryClick;
        public event ButtonClickEventHander DetailInventoryClick;
        public delegate void StockChangedEventHander(object sender,object value);
        public event StockChangedEventHander StockChanged;

        private void RaiseStockChanged(object value)
        {
            StockChangedEventHander changed = StockChanged;
            if (changed != null) changed(this, value);
        }


        protected void RaiseDetailHistoryClickEventHander()
        {
            if (DetailHistoryClick != null)
            {
                DetailHistoryClick(this);
            }
        }

        protected void RaiseDetailInventoryClickEventHander()
        {
            if (DetailInventoryClick != null)
            {
                DetailInventoryClick(this);
            }
        }

        protected void RaiseDetailProductClickClickEventHander()
        {
            if (DetailProductClick != null)
            {
                DetailProductClick(this);
            }
        }

        private void RaiseViewChangedClickEventHander()
        {
            if (ViewChangedClick != null)
            {
                ViewChangedClick(this);
            }
        }

        private void RaiseDetailClickEventHander()
        {
            if (DetailClick != null)
            {
                DetailClick(this);
            }
        }

        private void RaiseDetailViewClickEventHander()
        {
            if (DetailViewClick != null)
            {
                DetailViewClick(this);
            }
        }

        private void RaiseViewClickEventHander()
        {
            if (ViewClick != null)
            {
                ViewClick(this);
            }
        }

        private void RaiseSaveDataByIdClickEventHander()
        {
            if (SaveDataByIdClick != null)
            {
                SaveDataByIdClick(this);
            }
        }

        private void RaiseReadDataByIdClickEventHander()
        {
            if (ReadDataByIdClick != null)
            {
                ReadDataByIdClick(this);
            }
        }

        private void RaiseSelectAllClickEventHander()
        {
            if (SelectAllClick != null)
            {
                SelectAllClick(this);
            }
        }

        private void RaiseReadLayoutClickEventHander()
        {
            if (ReadLayoutClick != null)
            {
                ReadLayoutClick(this);
            }
        }

        private void RaiseSaveLayoutClickEventHander()
        {
            if (SaveLayoutClick != null)
            {
                SaveLayoutClick(this);
            }
        }

        private void RaiseReadFromFileClickEventHander()
        {
            if (ReadDataFromFileClick != null)
            {
                ReadDataFromFileClick(this);
            }
        }

        private void RaiseSaveToFileClickEventHander()
        {
            if (SaveDataToFileClick != null)
            {
                SaveDataToFileClick(this);
            }
        }

        private void RaiseRestoreTempClickEventHander()
        {
            if (RestoreDataTempClick != null)
            {
                RestoreDataTempClick(this);
            }
        }

        private void RaiseSaveTempClickEventHander()
        {
            if (SaveDataTempClick != null)
            {
                SaveDataTempClick(this);
            }
        }

        private void RaiseInventoryClickEventHander()
        {
            if (InventoryClick != null)
            {
                InventoryClick(this);
            }
        }

        private void RaiseHistoryClickEventHander()
        {
            if (HistoryClick != null)
            {
                HistoryClick(this);
            }
        }

        private void RaiseProductDetailClickEventHander()
        {
            if (ProductDetailClick != null)
            {
                ProductDetailClick(this);
            }
        }

        private void RaiseClearClickEventHander()
        {
            if (ClearClick != null)
            {
                ClearClick(this);
            }
        }

        private void RaiseMirrorClickEventHander()
        {
            if (MirrorClick != null)
            {
                MirrorClick(this);
            }
        }

        private void RaiseCopyClickEventHander()
        {
            if (CopyClick != null)
            {
                CopyClick(this);
            }
        }

        private void RaiseConstructClickEventHander()
        {
            if (ConstructClick != null)
            {
                ConstructClick(this);
            }
        }

        private void RaisePermisionClickEventHander()
        {
            if (PermisionClick != null)
            {
                PermisionClick(this);
            }
        }

        private void RaiseImportClickEventHander()
        {
            if (ImportClick != null)
            {
                ImportClick(this);
            }
        }

        private void RaiseHelpClickEventHander()
        {
            if (HelpClick != null)
            {
                HelpClick(this);
            }
        }

        private void RaiseAddClickEventHander()
        {
            if (AddClick != null)
            {
                AddClick(this);
            }
        }

        private void RaiseSearchClickEventHander()
        {
            if (SearchClick != null)
            {
                SearchClick(this);
            }
        }

        private void RaiseSaveClickEventHander()
        {
            if (SaveClick != null)
            {
                SaveClick(this);
            }
        }

        private void RaiseSaveNewClickEventHander()
        {
            if (SaveNewClick != null)
            {
                SaveNewClick(this);
            }
        }

        private void RaiseCancleClickEventHander()
        {
            if (CancleClick != null)
            {
                CancleClick(this);
            }
        }

        private void RaiseOptionClickEventHander()
        {
            if (OptionClick != null)
            {
                OptionClick(this);
            }
        }

        private void RaiseEditClickEventHander()
        {
            if (EditClick != null)
            {
                EditClick(this);
            }
        }

        private void RaiseChangeClickEventHander()
        {
            if (ChangeClick != null)
            {
                ChangeClick(this);
            }
        }

        private void RaiseDeleteClickEventHander()
        {
            if (DeleteClick != null)
            {
                DeleteClick(this);
            }
        }

        private void RaiseRefreshClickEventHander()
        {
            if (RefreshClick != null)
            {
                RefreshClick(this);
            }
        }

        private void RaisePrintClickEventHander()
        {
            if (PrintClick != null)
            {
                PrintClick(this);
            }
        }

        private void RaiseCloseClickEventHander()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }

        private void RaiseExportEventHander()
        {
            if (ExportClick != null)
            {
                ExportClick(this);
            }
        }

        #endregion

        #region Property

        private bool _isfrom;
        private bool _isto;

        public DateTime From
        {
            get { return dtFrom.DateTime; }
            set { dtFrom.DateTime = value; }
        }

        public DateTime To
        {
            get { return dtTo.DateTime; }
            set { dtTo.DateTime = value; }
        }

        public string Stock
        {
           // set { txtStock.EditValue = value; }
            get { return txtStock.EditValue == null ? "" : txtStock.EditValue.ToString(); }
        }

        public string StockText
        {
            // set { txtStock.EditValue = value; }
            get { return txtStock.Text; }
        }

        public new string Id
        {
            get { return txtProduct_ID.Text; }
            set { txtProduct_ID.Text = value; }
        }

        public new string Text
        {
            get { return txtProduct_Name.Text; }
            set { txtProduct_Name.Text = value; }
        }

        public bool IsFrom
        {
            set
            {
                _isfrom = value;
                plFrom.Visible = _isfrom;
                IsTo = value;
            }
        }

        public bool IsTo
        {
            set
            {
                _isto = value;
                plTo.Visible = _isto;
                lblTo.Visible = _isto;
            }
        }


        public bool All
        {
            get { return _all; }
            set { _all = value; }
        }

        public bool IsStock
        {
            set
            {
                plStock.Visible = value;
            }
        }

        public bool IsProductId
        {
            set
            {
                plProduct_ID.Visible = value;
            }
        }

        public bool IsProductName
        {
            set
            {
                plProduct_Name.Visible = value;
            }
           
        }

        #endregion

        private bool _all;

        public xucBaseBarD()
        {
            InitializeComponent();
            Init();
        }

        public void Stock_Init()
        {
            sTOCKTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
            if (_all)
            {
                DataRow dr = dsSTOCK.STOCK.NewSTOCKRow();
                dr["Stock_ID"] = "All";
                dr["Stock_Name"] = "(Tất Cả)";
                dr["ActiveInt"] = 1;
                dsSTOCK.STOCK.Rows.InsertAt(dr, 0);
            }

            if (dsSTOCK.STOCK.Rows.Count > 0) txtStock.EditValue = dsSTOCK.STOCK.Rows[0]["Stock_ID"].ToString();

            txtStock.Properties.View.ActiveFilterString = "ActiveInt = 1";
        }

        public void Init()
        {
            ucBar.ViewClick += ucToolBar_ViewClick;
            ucBar.ExportClick += ucToolBar_ExportClick;
            ucBar.PrintClick += ucToolBar_PrintClick;
            ucBar.EditClick += ucToolBar_EditClick;
            ucBar.DeleteClick += ucToolBar_DeleteClick;
            ucBar.AddClick += ucToolBar_AddClick;
            ucBar.HelpClick += ucToolBar_HelpClick;
            ucBar.CloseClick += ucToolBar_CloseClick;
            ucBar.CopyClick += ucToolBar_CopyClick;
            ucBar.MirrorClick += ucToolBar_MirrorClick;
            ucBar.ProductDetailClick += ucToolBar_ProductDetailClick;
            ucBar.OptionClick += ucToolBar_OptionClick;
            ucBar.InventoryClick += ucToolBar_InventoryClick;
            ucBar.HistoryClick += ucToolBar_HistoryClick;
            ucBar.SaveLayoutClick += ucToolBar_SaveLayoutClick;
            ucBar.ReadLayoutClick += ucToolBar_ReadLayoutClick;
            dtFrom.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtTo.DateTime = dtFrom.DateTime.AddMonths(1).AddDays(-1);
            //Stock_Init();
        }


        private void ucToolBar_ReadLayoutClick(object sender)
        {
            RaiseReadLayoutClickEventHander();
        }

        private void ucToolBar_SaveLayoutClick(object sender)
        {
            RaiseSaveLayoutClickEventHander();
        }

        private void ucToolBar_HistoryClick(object sender)
        {
            RaiseHistoryClickEventHander();
        }

        private void ucToolBar_InventoryClick(object sender)
        {
            RaiseInventoryClickEventHander();
        }

        private void ucToolBar_OptionClick(object sender)
        {
            RaiseOptionClickEventHander();
        }

        private void ucToolBar_ProductDetailClick(object sender)
        {
            RaiseProductDetailClickEventHander();
        }

        private void ucToolBar_MirrorClick(object sender)
        {
            RaiseMirrorClickEventHander();
        }

        private void ucToolBar_CopyClick(object sender)
        {
            RaiseCopyClickEventHander();
        }

        private void ucToolBar_CloseClick(object sender)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        private void ucToolBar_HelpClick(object sender)
        {
            RaiseHelpClickEventHander();
        }


        private void ucToolBar_AddClick(object sender)
        {
            RaiseAddClickEventHander();
        }

        private void ucToolBar_DeleteClick(object sender)
        {
            RaiseDeleteClickEventHander();
        }

        private void ucToolBar_EditClick(object sender)
        {
            RaiseEditClickEventHander();
        }

        private void ucToolBar_PrintClick(object sender)
        {
            RaisePrintClickEventHander();
        }

        private void ucToolBar_ExportClick(object sender)
        {
            RaiseExportEventHander();
        }

        private void ucToolBar_ViewClick(object sender)
        {
            RaiseViewClickEventHander();
        }

        private void txtProduct_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RaiseViewChangedClickEventHander();
            }
        }

        private void txtSelectDate_DataTimeChanged(object sender, DateTime Begin, DateTime To)
        {
            dtFrom.DateTime = Begin;
            dtTo.DateTime = To;
        }

        private void txtStock_EditValueChanged(object sender, EventArgs e)
        {
            RaiseStockChanged(txtStock.EditValue);
        }

        public void ShowProduct()
        {
            plProduct_ID.Visible = true;
            plProduct_Name.Visible = true;
            txtProduct_ID.Visible = true;
            txtProduct_Name.Visible = true;
        }
    }
}