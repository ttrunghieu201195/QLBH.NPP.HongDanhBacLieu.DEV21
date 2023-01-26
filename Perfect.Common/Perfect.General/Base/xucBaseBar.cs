using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Perfect.Common
{
    public partial class xucBaseBar : xucBase
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
        public event ButtonClickEventHander DetailProductClick;
        public event ButtonClickEventHander DetailHistoryClick;
        public event ButtonClickEventHander DetailInventoryClick;
        public event ButtonClickEventHander CustomColumnClick;

        protected void RaiseCustomColumnClick()
        {
            ButtonClickEventHander custom = CustomColumnClick;
            if (custom != null) custom(this);
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

        public DateTime From { get { return dtFrom.DateTime; }
            set { dtFrom.DateTime=value; }
        }

        public DateTime To
        {
            get { return dtTo.DateTime; }
            set { dtTo.DateTime = value; }
        }

        //public bool Checked
        //{
        //    get { return bbiListType.Checked; }
        //    set { bbiListType.Checked = value; }
        //}

        //public CheckButton Detail
        //{
        //    get { return bbiListType; }
        //    set { bbiListType = value; }
        //}

        

        #endregion

        public xucBaseBar()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            ucBar.ViewClick += new ButtonClickEventHander(ucToolBar_ViewClick);
            ucBar.ExportClick += new ButtonClickEventHander(ucToolBar_ExportClick);
            ucBar.PrintClick += new ButtonClickEventHander(ucToolBar_PrintClick);
            ucBar.EditClick += new ButtonClickEventHander(ucToolBar_EditClick);
            ucBar.DeleteClick += new ButtonClickEventHander(ucToolBar_DeleteClick);
            ucBar.AddClick += new ButtonClickEventHander(ucToolBar_AddClick);
            ucBar.DetailClick += new ButtonClickEventHander(ucToolBar_DetailClick);
            ucBar.DetailViewClick += new ButtonClickEventHander(ucToolBar_DetailViewClick);
            ucBar.HelpClick += new ButtonClickEventHander(ucToolBar_HelpClick);
            ucBar.CloseClick += new ButtonClickEventHander(ucToolBar_CloseClick);
            ucBar.CopyClick += new ButtonClickEventHander(ucToolBar_CopyClick);
            ucBar.MirrorClick += new ButtonClickEventHander(ucToolBar_MirrorClick);
            ucBar.ProductDetailClick += new ButtonClickEventHander(ucToolBar_ProductDetailClick);
            ucBar.OptionClick += new ButtonClickEventHander(ucToolBar_OptionClick);
            ucBar.InventoryClick += new ButtonClickEventHander(ucToolBar_InventoryClick);
            ucBar.HistoryClick += new ButtonClickEventHander(ucToolBar_HistoryClick);
            ucBar.SaveLayoutClick += new ButtonClickEventHander(ucToolBar_SaveLayoutClick);
            ucBar.ReadLayoutClick += new ButtonClickEventHander(ucToolBar_ReadLayoutClick);
            ucBar.DetailProductClick += new ButtonClickEventHander(ucBar_DetailProductClick);
            ucBar.DetailHistoryClick += new ButtonClickEventHander(ucBar_DetailHistoryClick);
            ucBar.DetailInventoryClick += new ButtonClickEventHander(ucBar_DetailInventoryClick);
            ucBar.CustomColumnClick += new ButtonClickEventHander(ucBar_CustomColumnClick);
            

        }

        void ucBar_CustomColumnClick(object sender)
        {
            RaiseCustomColumnClick();
        }

        void ucBar_DetailInventoryClick(object sender)
        {
            RaiseDetailInventoryClickEventHander();
        }

        void ucBar_DetailHistoryClick(object sender)
        {
            RaiseDetailHistoryClickEventHander();
        }

        void ucBar_DetailProductClick(object sender)
        {
            RaiseDetailProductClickClickEventHander();
        }

        void ucToolBar_ReadLayoutClick(object sender)
        {
            RaiseReadLayoutClickEventHander();
        }

        void ucToolBar_SaveLayoutClick(object sender)
        {
            RaiseSaveLayoutClickEventHander();
        }

        void ucToolBar_HistoryClick(object sender)
        {
            RaiseHistoryClickEventHander();
        }

        void ucToolBar_InventoryClick(object sender)
        {
            RaiseInventoryClickEventHander();
        }

        void ucToolBar_OptionClick(object sender)
        {
            RaiseOptionClickEventHander();
        }

        void ucToolBar_ProductDetailClick(object sender)
        {
            RaiseProductDetailClickEventHander();
        }

        void ucToolBar_MirrorClick(object sender)
        {
            RaiseMirrorClickEventHander();
        }

        void ucToolBar_CopyClick(object sender)
        {
            RaiseCopyClickEventHander();
        }

        void ucToolBar_CloseClick(object sender)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        void ucToolBar_HelpClick(object sender)
        {
            RaiseHelpClickEventHander();
        }

        void ucToolBar_DetailViewClick(object sender)
        {
           RaiseDetailViewClickEventHander();
        }
        
        void ucToolBar_DetailClick(object sender)
        {
            RaiseDetailClickEventHander();
        }

        void ucToolBar_AddClick(object sender)
        {
            RaiseAddClickEventHander();
        }

        void ucToolBar_DeleteClick(object sender)
        {
            RaiseDeleteClickEventHander();
        }

        void ucToolBar_EditClick(object sender)
        {
           RaiseEditClickEventHander();
        }

        void ucToolBar_PrintClick(object sender)
        {
            RaisePrintClickEventHander();
        }

        void ucToolBar_ExportClick(object sender)
        {
           RaiseExportEventHander();
        }

        void ucToolBar_ViewClick(object sender)
        {
           RaiseViewClickEventHander();
        }

        private void ucDateTimeSelect_DataTimeChanged(object sender, DateTime Begin, DateTime To)
        {
            dtFrom.DateTime = Begin;
            dtTo.DateTime = To;
        }

    }
}
