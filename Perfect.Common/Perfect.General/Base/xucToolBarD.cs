using System.ComponentModel;
using System.Data;
using DevExpress.XtraBars;
using Perfect.ERP;

namespace Perfect.Common
{
    public partial class xucToolBarD : xucBase
    {
        public xucToolBarD()
        {
            InitializeComponent();
        }

        #region Property
        #region MyRegion
        //[DefaultValue(false)]
        //[Description("Button Add")]
        ////   [DefaultEvent("AddClick")]
        //[Category("Design")]
        //public BarItemVisibility ButtonAdd
        //{
        //    get { return bbiAdd.Visibility; }
        //    set
        //    {
        //        bbiAdd.Visibility = value;
        //        Update();
        //    }
        //} 
        #endregion

        #region MyRegion
        //[DefaultValue(false)]
        //[Description("Button Edit")]
        //[Category("Design")]
        //public BarItemVisibility ButtonEdit
        //{
        //    get { return bbiEdit.Visibility; }
        //    set
        //    {
        //        bbiEdit.Visibility = value;
        //        Update();
        //    }
        //} 
        #endregion

        [DefaultValue(false)]
        [Description("Button Print")]
        [Category("Design")]
        public BarItemVisibility ButtonPrint
        {
            get { return bbiPrint.Visibility; }
            set
            {
                bbiPrint.Visibility = value;
                Update();
            }
        }

        #region MyRegion
        //[DefaultValue(false)]
        //[Description("Button Change")]
        //[Category("Design")]
        //public BarItemVisibility ButtonChange
        //{
        //    get { return bbiChange.Visibility; }
        //    set
        //    {
        //        bbiChange.Visibility = value;
        //        Update();
        //    }
        //}

        //[DefaultValue(false)]
        //[Description("Button Delete")]
        //[Category("Design")]
        //public BarItemVisibility ButtonDelete
        //{
        //    get { return bbiDelete.Visibility; }
        //    set
        //    {
        //        bbiDelete.Visibility = value;
        //        Update();
        //    }
        //} 
        #endregion

        [DefaultValue(false)]
        [Description("Button Delete")]
        [Category("Design")]
        public BarItemVisibility ButtonOption
        {
            get { return bbiOption.Visibility; }
            set
            {
                bbiOption.Visibility = value;
                Update();
            }
        }

        [DefaultValue(false)]
        [Description("Button Delete")]
        [Category("Design")]
        public BarItemVisibility ButtonExport
        {
            get { return bbiExport.Visibility; }
            set
            {
                bbiExport.Visibility = value;
                Update();
            }
        }

        //[DefaultValue(false)]
        //[Description("Button Save")]
        //[Category("Design")]
        //public BarItemVisibility ButtonSave
        //{
        //    get { return bbiSave.Visibility; }
        //    set
        //    {
        //        bbiSave.Visibility = value;
        //        Show();
        //        BarM.Reset();
        //    }
        //}

        //[DefaultValue(false)]
        //[Description("Button SaveNew")]
        //[Category("Design")]
        //public BarItemVisibility ButtonSaveNew
        //{
        //    get { return bbiSaveNew.Visibility; }
        //    set
        //    {
        //        bbiSaveNew.Visibility = value;
        //        Show();
        //        BarM.Reset();
        //    }
        //}

        //[DefaultValue(false)]
        //[Description("Button Cancel")]
        //[Category("Design")]
        //public BarItemVisibility ButtonCancel
        //{
        //    get { return bbiCancel.Visibility; }
        //    set
        //    {
        //        bbiCancel.Visibility = value;
        //        Show();
        //        BarM.Reset();
        //    }
        //} 
        #endregion

        #region Delegate
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

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiPrint.Enabled = false;
            RaisePrintClickEventHander();
            bbiPrint.Enabled = true;
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseCloseClickEventHander();
        }
        
        private void bbiOption_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseOptionClickEventHander();
        }


        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiExport.Enabled = false;
            RaiseExportEventHander();
            bbiExport.Enabled = true;
        }

        private void bbiHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseHelpClickEventHander();
        }

        public virtual void MakerInterface()
        {
            //CONTROL_FORMAT cf = new CONTROL_FORMAT();
            //for (int i = 0; i < barMAccount.Items.Count; i++)
            //{
            //    if (barMAccount.Items[i].Caption != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "xucToolBar", barMAccount.Items[i].Name, "VN", barMAccount.Items[i].Caption, "", true);
            //    }
            //}
            //CONTROL_FORMAT.Save("xucToolBar");
        }

        public virtual void SetInterface()
        {
            //DataTable dt = CONTROL_FORMAT.Load("xucToolBar");
            //if (dt == null) return;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < bm.Items.Count; j++)
            //    {
            //        if (bm.Items[j].Name == dt.Rows[i]["Control_Id"].ToString())
            //        {
            //            //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //            bm.Items[j].Caption = dt.Rows[i]["Caption"].ToString();
            //            break;
            //        }
            //    }
            //}
        }

        private void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseImportClickEventHander();
        }
        
        private void bbiCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseCopyClickEventHander();
        }

        private void bbiProductDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseProductDetailClickEventHander();
        }

        private void bbiHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseHistoryClickEventHander();
        }

        private void bbiInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseInventoryClickEventHander();
        }

        private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiView.Enabled = false;
            RaiseViewClickEventHander();
            bbiView.Enabled = true;
        }


    }
}
