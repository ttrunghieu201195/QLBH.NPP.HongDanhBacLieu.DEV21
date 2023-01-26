using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Common
{
    public partial class xucBarB : xucBase
    {
        #region Delegate & Events
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

        public xucBarB()
        {
            InitializeComponent();

            ucBar.AddClick += new ButtonClickEventHander(ucToolBar_AddClick);
            ucBar.SaveClick += new ButtonClickEventHander(ucToolBar_SaveClick);
            ucBar.SaveNewClick += new ButtonClickEventHander(ucToolBar_SaveNewClick);
            ucBar.CancleClick += new ButtonClickEventHander(ucToolBar_CancleClick);
            ucBar.PrintClick += new ButtonClickEventHander(ucToolBar_PrintClick);
            ucBar.CloseClick += new ButtonClickEventHander(ucToolBar_CloseClick);
            ucBar.DeleteClick += new ButtonClickEventHander(ucToolBar_DeleteClick);
            ucBar.ClearClick += new ButtonClickEventHander(ucToolBar_ClearClick);
            ucBar.ProductDetailClick += new ButtonClickEventHander(ucToolBar_ProductDetailClick);
            ucBar.HistoryClick += new ButtonClickEventHander(ucToolBar_HistoryClick);
            ucBar.SearchClick += new ButtonClickEventHander(ucToolBar_SearchClick);
            ucBar.InventoryClick += new ButtonClickEventHander(ucToolBar_InventoryClick);
            ucBar.SaveDataTempClick += new ButtonClickEventHander(ucToolBar_SaveTempClick);
            ucBar.RestoreDataTempClick += new ButtonClickEventHander(ucToolBar_RestoreTempClick);
            ucBar.SaveDataToFileClick += new ButtonClickEventHander(ucToolBar_SaveToFileClick);
            ucBar.ReadDataFromFileClick += new ButtonClickEventHander(ucToolBar_ReadFromFileClick);
            ucBar.SaveLayoutClick += new ButtonClickEventHander(ucToolBar_SaveLayoutClick);
            ucBar.ReadLayoutClick += new ButtonClickEventHander(ucToolBar_ReadLayoutClick);
            ucBar.SelectAllClick += new ButtonClickEventHander(ucToolBar_SelectAllClick);
            ucBar.ExportClick += new ButtonClickEventHander(ucToolBar_ExportClick);
            ucBar.SaveDataByIdClick += new ButtonClickEventHander(ucToolBar_SaveDataByIDClick);
            ucBar.ReadDataByIdClick += new ButtonClickEventHander(ucToolBar_ReadDataByIDClick);
            ucBar.CopyClick += new ButtonClickEventHander(ucBar_CopyClick);
            ucBar.RefreshClick += new ButtonClickEventHander(ucBar_RefreshClick);
            ucBar.HelpClick += new ButtonClickEventHander(ucBar_HelpClick);
            ucBar.CustomColumnClick += new ButtonClickEventHander(ucBar_CustomColumnClick);
            ucBar.FaceDefaultClick += new ButtonClickEventHander(ucBar_FaceDefaultClick);
        }

        public virtual void FaceDefault()
        {}

        void ucBar_FaceDefaultClick(object sender)
        {
            //throw new NotImplementedException();
            FaceDefault();
        }

        protected virtual void CustomColumn(){}

        void ucBar_CustomColumnClick(object sender)
        {
            //throw new NotImplementedException();
            CustomColumn();
        }

        void ucBar_HelpClick(object sender)
        {
            //throw new NotImplementedException();
            RaiseHelpClickEventHander();
        }

        void ucBar_RefreshClick(object sender)
        {
            RaiseRefreshClickEventHander(); 
        }

        void ucBar_CopyClick(object sender)
        {
            RaiseCopyClickEventHander();
        }

        public xucToolBarB Bar { get{ return ucBar;} }

        #region Event
        void ucToolBar_ReadDataByIDClick(object sender)
        {
            RaiseReadDataByIdClickEventHander();
        }

        void ucToolBar_SaveDataByIDClick(object sender)
        {
            RaiseSaveDataByIdClickEventHander();
        }

        void ucToolBar_ExportClick(object sender)
        {
            RaiseExportEventHander();
        }

        void ucToolBar_SelectAllClick(object sender)
        {
            RaiseSelectAllClickEventHander();
        }

        void ucToolBar_ReadLayoutClick(object sender)
        {
            RaiseReadLayoutClickEventHander();
        }

        void ucToolBar_SaveLayoutClick(object sender)
        {
            RaiseSaveLayoutClickEventHander();
        }

        void ucToolBar_ReadFromFileClick(object sender)
        {
            RaiseReadFromFileClickEventHander();
        }

        void ucToolBar_SaveToFileClick(object sender)
        {
            RaiseSaveToFileClickEventHander();
        }

        void ucToolBar_RestoreTempClick(object sender)
        {
            RaiseRestoreTempClickEventHander();
        }

        void ucToolBar_SaveTempClick(object sender)
        {
            RaiseSaveTempClickEventHander();
        }

        void ucToolBar_InventoryClick(object sender)
        {
            RaiseInventoryClickEventHander();
        }

        void ucToolBar_SearchClick(object sender)
        {
            RaiseSearchClickEventHander();
        }

        void ucToolBar_HistoryClick(object sender)
        {
            RaiseHistoryClickEventHander();
        }

        void ucToolBar_ProductDetailClick(object sender)
        {
            RaiseProductDetailClickEventHander();
        }

        void ucToolBar_ClearClick(object sender)
        {
            RaiseClearClickEventHander();
        }

        void ucToolBar_DeleteClick(object sender)
        {
            RaiseDeleteClickEventHander();
        }

        void ucToolBar_CloseClick(object sender)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        void ucToolBar_PrintClick(object sender)
        {
            RaisePrintClickEventHander();
        }

        void ucToolBar_CancleClick(object sender)
        {
            RaiseCancleClickEventHander();
        }

        void ucToolBar_SaveNewClick(object sender)
        {
            RaiseSaveNewClickEventHander();
        }

        void ucToolBar_SaveClick(object sender)
        {
            RaiseSaveClickEventHander();
        }

        void ucToolBar_AddClick(object sender)
        {
            RaiseAddClickEventHander();
        } 
        #endregion
    }
}
