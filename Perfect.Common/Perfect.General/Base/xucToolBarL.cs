using System;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Common
{
    public partial class xucToolBarL : xucBase
    {
        public xucToolBarL()
        {
            InitializeComponent();
            //DateEdit from = (DateEdit)dtFrom.Edit;
           // from = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //DateTime to = (DateTime)dtTo.EditValue;
             //to= from.AddMonths(1).AddDays(-1);
        }

        #region Property
        [DefaultValue(false)]
        [Description("Button Add")]
        //   [DefaultEvent("AddClick")]
        [Category("Design")]
        public BarItemVisibility ButtonAdd
        {
            get { return bbiAdd.Visibility; }
            set
            {
                bbiAdd.Visibility = value;
                Update();
            }
        }

        [DefaultValue(false)]
        [Description("Button Edit")]
        [Category("Design")]
        public BarItemVisibility ButtonEdit
        {
            get { return bbiEdit.Visibility; }
            set
            {
                bbiEdit.Visibility = value;
                Update();
            }
        }

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

        [DefaultValue(false)]
        [Description("Button Change")]
        [Category("Design")]
        public BarItemVisibility ButtonChange
        {
            get { return bbiChange.Visibility; }
            set
            {
                bbiChange.Visibility = value;
                Update();
            }
        }

        [DefaultValue(false)]
        [Description("Button Delete")]
        [Category("Design")]
        public BarItemVisibility ButtonDelete
        {
            get { return bbiDelete.Visibility; }
            set
            {
                bbiDelete.Visibility = value;
                Update();
            }
        }

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

        [DefaultValue(false)]
        [Description("Button Save")]
        [Category("Design")]
        public BarItemVisibility ButtonSave
        {
            get { return bbiSave.Visibility; }
            set
            {
                bbiSave.Visibility = value;
                Show();
                BarM.Reset();
            }
        }

        [DefaultValue(false)]
        [Description("Button SaveNew")]
        [Category("Design")]
        public BarItemVisibility ButtonSaveNew
        {
            get { return bbiSaveNew.Visibility; }
            set
            {
                bbiSaveNew.Visibility = value;
                Show();
                BarM.Reset();
            }
        }

        [DefaultValue(false)]
        [Description("Button Cancel")]
        [Category("Design")]
        public BarItemVisibility ButtonCancel
        {
            get { return bbiCancel.Visibility; }
            set
            {
                bbiCancel.Visibility = value;
                Show();
                BarM.Reset();
            }
        } 
        #endregion

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

         protected void RaiseDetailClickEventHander()
        {
            if (DetailClick != null)
            {
                DetailClick(this);
            }
        }

         protected void RaiseDetailViewClickEventHander()
        {
            if (DetailViewClick != null)
            {
                DetailViewClick(this);
            }
        }

         protected void RaiseViewClickEventHander()
        {
            if (ViewClick != null)
            {
                ViewClick(this);
            }
        }

         protected void RaiseSaveDataByIdClickEventHander()
        {
            if (SaveDataByIdClick != null)
            {
                SaveDataByIdClick(this);
            }
        }

         protected void RaiseReadDataByIdClickEventHander()
        {
            if (ReadDataByIdClick != null)
            {
                ReadDataByIdClick(this);
            }
        }

         protected void RaiseSelectAllClickEventHander()
        {
            if (SelectAllClick != null)
            {
                SelectAllClick(this);
            }
        }

         protected void RaiseReadLayoutClickEventHander()
        {
            if (ReadLayoutClick != null)
            {
                ReadLayoutClick(this);
            }
        }

         protected void RaiseSaveLayoutClickEventHander()
        {
            if (SaveLayoutClick != null)
            {
                SaveLayoutClick(this);
            }
        }

         protected void RaiseReadFromFileClickEventHander()
        {
            if (ReadDataFromFileClick != null)
            {
                ReadDataFromFileClick(this);
            }
        }

         protected void RaiseSaveToFileClickEventHander()
        {
            if (SaveDataToFileClick != null)
            {
                SaveDataToFileClick(this);
            }
        }

         protected void RaiseRestoreTempClickEventHander()
        {
            if (RestoreDataTempClick != null)
            {
                RestoreDataTempClick(this);
            }
        }

         protected void RaiseSaveTempClickEventHander()
        {
            if (SaveDataTempClick != null)
            {
                SaveDataTempClick(this);
            }
        }

         protected void RaiseInventoryClickEventHander()
        {
            if (InventoryClick != null)
            {
                InventoryClick(this);
            }
        }

         protected void RaiseHistoryClickEventHander()
        {
            if (HistoryClick != null)
            {
                HistoryClick(this);
            }
        }

         protected void RaiseProductDetailClickEventHander()
        {
            if (ProductDetailClick != null)
            {
                ProductDetailClick(this);
            }
        }

         protected void RaiseClearClickEventHander()
        {
            if (ClearClick != null)
            {
                ClearClick(this);
            }
        }

         protected void RaiseMirrorClickEventHander()
        {
            if (MirrorClick != null)
            {
                MirrorClick(this);
            }
        }

         protected void RaiseCopyClickEventHander()
        {
            if (CopyClick != null)
            {
                CopyClick(this);
            }
        }

         protected void RaiseConstructClickEventHander()
        {
            if (ConstructClick != null)
            {
                ConstructClick(this);
            }
        }

         protected void RaisePermisionClickEventHander()
        {
            if (PermisionClick != null)
            {
                PermisionClick(this);
            }
        }

         protected void RaiseImportClickEventHander()
        {
            if (ImportClick != null)
            {
                ImportClick(this);
            }
        }

         protected void RaiseHelpClickEventHander()
        {
            if (HelpClick != null)
            {
                HelpClick(this);
            }
        }

         protected void RaiseAddClickEventHander()
        {
            if (AddClick != null)
            {
                AddClick(this);
            }
        }

         protected void RaiseSearchClickEventHander()
        {
            if (SearchClick != null)
            {
                SearchClick(this);
            }
        }

         protected void RaiseSaveClickEventHander()
        {
            if (SaveClick != null)
            {
                SaveClick(this);
            }
        }

         protected void RaiseSaveNewClickEventHander()
        {
            if (SaveNewClick != null)
            {
                SaveNewClick(this);
            }
        }

         protected void RaiseCancleClickEventHander()
        {
            if (CancleClick != null)
            {
                CancleClick(this);
            }
        }

         protected void RaiseOptionClickEventHander()
        {
            if (OptionClick != null)
            {
                OptionClick(this);
            }
        }

         protected void RaiseEditClickEventHander()
        {
            if (EditClick != null)
            {
                EditClick(this);
            }
        }

         protected void RaiseChangeClickEventHander()
        {
            if (ChangeClick != null)
            {
                ChangeClick(this);
            }
        }

         protected void RaiseDeleteClickEventHander()
        {
            if (DeleteClick != null)
            {
                DeleteClick(this);
            }
        }

         protected void RaiseRefreshClickEventHander()
        {
            if (RefreshClick != null)
            {
                RefreshClick(this);
            }
        }

         protected void RaisePrintClickEventHander()
        {
            if (PrintClick != null)
            {
                PrintClick(this);
            }
        }

         protected void RaiseCloseClickEventHander()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }

         protected void RaiseExportEventHander()
        {
            if (ExportClick != null)
            {
                ExportClick(this);
            }
        } 
        #endregion

         protected void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseAddClickEventHander();
        }

         protected void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseEditClickEventHander();
        }

         protected void bbiChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseChangeClickEventHander();
        }

         protected void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseDeleteClickEventHander();
        }

         protected void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseRefreshClickEventHander();
        }

         protected void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaisePrintClickEventHander();
        }

         protected void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseCloseClickEventHander();
        }
        
         protected void bbiOption_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseOptionClickEventHander();
        }

         protected void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSaveClickEventHander();
        }

         protected void bbiCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseCancleClickEventHander();
        }

         protected void bbiSaveNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSaveNewClickEventHander();
        }

         protected void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseExportEventHander();
        }

         protected void bbiSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSearchClickEventHander();
        }

         protected void bbiHelp_ItemClick(object sender, ItemClickEventArgs e)
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

         protected void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseImportClickEventHander();
        }

         protected void bbiPermision_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaisePermisionClickEventHander();
        }

         protected void bbiConstruct_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseConstructClickEventHander();
        }

         protected void bbiCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseCopyClickEventHander();
        }

         protected void bbiDouble_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseMirrorClickEventHander();
        }

         protected void bbiClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseClearClickEventHander();
        }

         protected void bbiProductDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseProductDetailClickEventHander();
        }

         protected void bbiHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseHistoryClickEventHander();
        }

         protected void bbiInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseInventoryClickEventHander();
        }

         protected void bbiTempSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSaveTempClickEventHander();
        }

         protected void bbiRestoreTemp_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseRestoreTempClickEventHander();
        }

         protected void bbiSaveToFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSaveToFileClickEventHander();
        }

         protected void bbiReadFromFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseReadFromFileClickEventHander();
        }

         protected void bbiSaveLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSaveLayoutClickEventHander();
        }

         protected void bbiReadLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseReadLayoutClickEventHander();
        }

         protected void bbiSelectAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSelectAllClickEventHander();
        }

         protected void bbiSaveDataByID_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseSaveDataByIdClickEventHander();
        }

         protected void bbiReadDataByID_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseReadDataByIdClickEventHander();
        }

         protected void bbiview_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseViewClickEventHander();
        }

         protected void bbiDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseDetailClickEventHander();
        }

         protected void bbiDetailView_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseDetailViewClickEventHander();
        }

         protected void bbiCheck_EditValueChanged(object sender, EventArgs e)
        {

        }

         private void bbiDetailProduct_ItemClick(object sender, ItemClickEventArgs e)
         {
             RaiseDetailProductClickClickEventHander();
         }

         private void bbiDetailHistory_ItemClick(object sender, ItemClickEventArgs e)
         {
             RaiseDetailHistoryClickEventHander();
         }

         private void bbiDetailInventory_ItemClick(object sender, ItemClickEventArgs e)
         {
             RaiseDetailInventoryClickEventHander();
         }

         

         private void bbiCustomColumn_ItemClick(object sender, ItemClickEventArgs e)
         {
             RaiseCustomColumnClick();
         }

         private void bbiPrintOption_ItemClick(object sender, ItemClickEventArgs e)
         {

         }

         private void bbiReplication_ItemClick(object sender, ItemClickEventArgs e)
         {

         }

        //public bool Checked
        //{
        //    set { bbiCheck.EditValue = value; }
        //    get { return (bool)bbiCheck.EditValue; }
        //}

    }
}

