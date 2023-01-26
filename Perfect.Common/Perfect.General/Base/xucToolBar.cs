using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Common
{
   
    


        public partial class xucToolBar : xucBase
        {

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
            public event ButtonClickEventHander HistoryClick;
            public event ButtonClickEventHander GroupChanged;
            public event ButtonClickEventHander StockChanged;
            public event ButtonClickEventHander MergeChanged;
            public event ButtonClickEventHander IdChanged;

            public event ButtonClickEventHander EditUnitConvert;

            private void RaiseEditUnitConvert()
            {
                ButtonClickEventHander convert = EditUnitConvert;
                if (convert != null) convert(this);
            }


            private void RaiseIdChanged()
            {
                ButtonClickEventHander changed = IdChanged;
                if (changed != null) changed(this);
            }

            private void RaiseMergeChanged()
            {
                ButtonClickEventHander changed = MergeChanged;
                if (changed != null) changed(this);
            }

            private void RaiseStockChanged()
            {
                ButtonClickEventHander changed = StockChanged;
                if (changed != null) changed(this);
            }

            private void RaiseGroupChanged()
            {
                ButtonClickEventHander changed = GroupChanged;
                if (changed != null) changed(this);
            }

            private void RaiseHistoryClick()
            {
                ButtonClickEventHander hander = HistoryClick;
                if (hander != null) hander(this);
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

            [DefaultValue(false)]
            [Description("Button Add")]
         //   [DefaultEvent("AddClick")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonAdd
            {
                get
                {
                    return bbiAdd.Visibility;
                }
                set
                {
                    bbiAdd.Visibility = value;
                    this.Update();
                }
            }
            [DefaultValue(false)]
            [Description("Button Edit")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonEdit
            {
                get
                {
                    return bbiEdit.Visibility;
                }
                set
                {
                    bbiEdit.Visibility = value;
                    this.Update();
                }
            }

            [DefaultValue(false)]
            [Description("Button Print")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonPrint
            {
                get
                {
                    return bbiPrint.Visibility;
                }
                set
                {
                    bbiPrint.Visibility = value;
                    this.Update();
                }
            }

            [DefaultValue(false)]
            [Description("Button Change")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonChange
            {
                get
                {
                    return bbiChange.Visibility;
                }
                set
                {
                    bbiChange.Visibility = value;
                    this.Update();
                }
            }
            [DefaultValue(false)]
            [Description("Button Delete")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonDelete
            {
                get
                {
                    return bbiDelete.Visibility;
                }
                set
                {
                    bbiDelete.Visibility = value;
                    this.Update();
                }
            }
            [DefaultValue(false)]
            [Description("Button Delete")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonOption
            {
                get
                {
                    return bbiOption.Visibility;
                }
                set
                {
                    bbiOption.Visibility = value;
                    this.Update();
                }
            }

            [DefaultValue(false)]
            [Description("Button Delete")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonExport
            {
                get
                {
                    return bbiExport.Visibility;
                }
                set
                {
                    bbiExport.Visibility = value;
                    this.Update();
                }
            }

            [DefaultValue(false)]
            [Description("Button Save")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonSave
            {
                get
                {
                    return bbiSave.Visibility;
                }
                set
                {
                    bbiSave.Visibility = value;
                    this.Show();
                    barAccount.Reset();
                }
            }

            [DefaultValue(false)]
            [Description("Button SaveNew")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonSaveNew
            {
                get
                {
                    return bbiSaveNew.Visibility;
                }
                set
                {
                    bbiSaveNew.Visibility = value;
                    this.Show();
                    barAccount.Reset();
                }
            }

            [DefaultValue(false)]
            [Description("Button Cancel")]
            [Category("Design")]
            public DevExpress.XtraBars.BarItemVisibility ButtonCancel
            {
                get
                {
                    return bbiCancel.Visibility;
                }
                set
                {
                    bbiCancel.Visibility = value;
                    this.Show();
                    barAccount.Reset();
                }
            }

            public xucToolBar()
            {
                InitializeComponent();
            }

            private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
               // bbiAdd.Enabled = false;
                this.RaiseAddClickEventHander();
               // bbiAdd.Enabled = true;
            }

            private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseEditClickEventHander();
            }

            private void bbiChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseChangeClickEventHander();
            }

            private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseDeleteClickEventHander();
            }

            private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseRefreshClickEventHander();
            }

            private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaisePrintClickEventHander();
            }

            private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseCloseClickEventHander();
            }

            private void bbiExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseExportEventHander();
            }

            private void bbiOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseOptionClickEventHander();
            }

            private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseSaveClickEventHander();
            }

            private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseCancleClickEventHander();
            }

            private void bbiSaveNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseSaveNewClickEventHander();
            }

            private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                this.RaiseExportEventHander();
            }

            private void bbiSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseSearchClickEventHander();
            }

            private void bbiHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
               // CONTROL_FORMAT.Save("xucToolBar");
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

            private void bbiImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseImportClickEventHander();
            }

            private void bbiPermision_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaisePermisionClickEventHander();
            }

            private void bbiConstruct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseConstructClickEventHander();
            }

            private void bbiCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseCopyClickEventHander();
            }

            private void bbiDouble_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseMirrorClickEventHander();
            }

            private void bbiClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseClearClickEventHander();
            }

            private void bbiHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseHistoryClick();
            }

            private void bbiGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseGroupChanged();
            }

            private void bbiStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseStockChanged();
            }

            private void bbiMerge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseMergeChanged();
            }

            private void bbiChangeId_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseIdChanged();
            }

            private void bbiEditUnitConvret_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                RaiseEditUnitConvert();
            }

        }
    
}
