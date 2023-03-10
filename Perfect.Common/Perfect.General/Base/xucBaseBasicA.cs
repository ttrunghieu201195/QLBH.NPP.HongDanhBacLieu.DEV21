using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;

namespace Perfect.Common
{
    public partial class xucBaseBasicA : xucBase
    {
        protected bool _search;
        protected RowClickEventArgs m_RowClickEventArgs = new RowClickEventArgs();
        protected Actions m_Status = new Actions();

        public xucBaseBasicA()
        {
            InitializeComponent();
            _search = false;
            DisableMenu(true);
        }

        public bool IsSearch
        {
            get { return _search; }
            set { _search = value; }
        }

        public event RowClickEventHander RowClick;
        public event RowClickEventHander RowDoubleClick;
        public event ListKeyDownEventHander ListKeyDown;
        public event ButtonClickEventHander CloseClick;

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Alt | Keys.D:
                    MessageBox.Show("You are stupid");
                    return true;

                    // some more cases...  

                case Keys.F1:
                    ucToolBar_HelpClick(ucToolBar);
                    return true;

                case Keys.Control | Keys.N:
                    ucToolBar_AddClick(ucToolBar);
                    return true;
                case Keys.Control | Keys.T:
                    ucToolBar_AddClick(ucToolBar);
                    return true;

                case Keys.Control | Keys.F:
                    ucToolBar_SearchClick(ucToolBar);
                    return true;

                case Keys.Control | Keys.P:
                    ucToolBar_PrintClick(ucToolBar);
                    return true;

                case Keys.Control | Keys.O:
                    ucToolBar_OptionClick(ucToolBar);
                    return true;

                case Keys.Control | Keys.E:
                    ucToolBar_Export(ucToolBar);
                    return true;


                case Keys.Escape:
                    RaiseCloseClickEventHander();
                    return true;

                case Keys.Alt | Keys.X:
                    RaiseCloseClickEventHander();
                    return true;

                case Keys.F5:
                    ReLoad();
                    return true;
            }
            return false;
        }

        private void RaiseListKeyDownEventHander(KeyEventArgs key, RowClickEventArgs e)
        {
            if (ListKeyDown != null)
            {
                ListKeyDown(this, key, e);
            }
        }

        private void RaiseRowClickEventHander(RowClickEventArgs e)
        {
            if (RowClick != null)
            {
                RowClick(this, e);
            }
        }

        private void RaiseRowDoubleClickEventHander(RowClickEventArgs e)
        {
            if (RowDoubleClick != null)
            {
                RowDoubleClick(this, e);
            }
        }

        private void RaiseCloseClickEventHander()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }

        //protected override void OnFirstLoad()
        //{
        //    //Init();
        //    base.OnFirstLoad();
        //}

        protected override void OnLoad(EventArgs e)
        {
            Init();
            base.OnLoad(e);
        }

        private void Init()
        {
            ucToolBar.AddClick += new ButtonClickEventHander(ucToolBar_AddClick);
            ucToolBar.EditClick += new ButtonClickEventHander(ucToolBar_EditClick);
            ucToolBar.DeleteClick += new ButtonClickEventHander(ucToolBar_DeleteClick);
            ucToolBar.SearchClick += new ButtonClickEventHander(ucToolBar_SearchClick);
            ucToolBar.PrintClick += new ButtonClickEventHander(ucToolBar_PrintClick);
            ucToolBar.RefreshClick += new ButtonClickEventHander(ucToolBar_RefreshClick);
            ucToolBar.OptionClick += new ButtonClickEventHander(ucToolBar_OptionClick);
            ucToolBar.ExportClick += new ButtonClickEventHander(ucToolBar_Export);
            ucToolBar.HelpClick += new ButtonClickEventHander(ucToolBar_HelpClick);
            ucToolBar.CloseClick += new ButtonClickEventHander(ucToolBar_CloseClick);
            ucToolBar.ImportClick += new ButtonClickEventHander(ucToolBar_ImportClick);
            ucToolBar.PermisionClick += new ButtonClickEventHander(ucToolBar_PermisionClick);
            ucToolBar.ConstructClick += new ButtonClickEventHander(ucToolBar_ConstructClick);
            ucToolBar.CopyClick += new ButtonClickEventHander(ucToolBar_CopyClick);
            ucToolBar.MirrorClick += new ButtonClickEventHander(ucToolBar_MirrorClick);
            ucToolBar.ClearClick += new ButtonClickEventHander(ucToolBar_ClearClick);
            ReLoad();
            //List_Init(gbList);
            m_Status = Actions.None;
            ucToolBar.bm.SetPopupContextMenu(gcList, ucToolBar.pm);
        }

        private void ucToolBar_ClearClick(object sender)
        {
            if (gbList.RowCount == 0) return;
            gbList.SelectAll();
            Delete();
            SetMenu(m_RowClickEventArgs);
        }

        private void ucToolBar_MirrorClick(object sender)
        {
            Mirror();
        }

        public virtual void Mirror()
        {
        }

        private void ucToolBar_CopyClick(object sender)
        {
            gbList.CopyToClipboard();
        }

        public virtual void Construct()
        {
        }

        private void ucToolBar_ConstructClick(object sender)
        {
            Construct();
        }

        public virtual void Permision()
        {
        }

        private void ucToolBar_PermisionClick(object sender)
        {
            Permision();
        }

        public virtual void Import()
        {
        }

        private void ucToolBar_ImportClick(object sender)
        {
            Import();
        }

        private void ucToolBar_CloseClick(object sender)
        {
            RaiseCloseClickEventHander();
        }

        private void ucToolBar_HelpClick(object sender)
        {
            XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        private void ucToolBar_Export(object sender)
        {
            Export(gbList);
        }

        private void ucToolBar_OptionClick(object sender)
        {
            XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        private void ucToolBar_RefreshClick(object sender)
        {
            ReLoad();
        }

        private void ucToolBar_PrintClick(object sender)
        {
            Print();
        }

        private void ucToolBar_SearchClick(object sender)
        {
            Search();
        }

        private void ucToolBar_DeleteClick(object sender)
        {
            if (gbList.RowCount == 0) return;
            Delete();
            SetMenu(m_RowClickEventArgs);
        }

        private void ucToolBar_EditClick(object sender)
        {
            if (gbList.RowCount == 0) return;
            Change();
        }

        private void ucToolBar_AddClick(object sender)
        {
            Add();
        }

        public virtual void Delete()
        {
        }

        protected virtual void Add()
        {
        }

        public virtual void Change()
        {
        }

        protected virtual void Search()
        {
            XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        protected virtual void Print()
        {
            // XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
            //gcList.pre
            gcList.ShowPrintPreview();
        }

        public virtual void ReLoad()
        {
        }

        protected virtual void List_Init(AdvBandedGridView dt)
        {
            //XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        protected virtual void AddRow(object Item)
        {
            //XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        protected virtual void UpdateRow(object Item, RowClickEventArgs e)
        {
            // XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
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

        public object GetCellValue(int RowIndex, int ColumIndex)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex));
            return Result;
        }

        public object GetCellValue(int RowIndex, string FieldName)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName));
            return Result;
        }

        protected virtual void gbList_Click(object sender, EventArgs e)
        {
            if (sender is AdvBandedGridView)
            {
                var view = (AdvBandedGridView) sender;
                var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;
                RaiseRowClickEventHander(ex);
                ItemSelectd(ex);
            }
            else
            {
                //VnMessageBox.Error("Lưới đang sử đụng không đúng.");
                XtraMessageBox.Show("Object is not AdvBandedGridView");
            }
        }

        protected virtual void ItemSelectd(RowClickEventArgs ex)
        {
        }

        protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        {
            if (sender is AdvBandedGridView)
            {
                var view =
                    (AdvBandedGridView) sender;
                var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                               view.FocusedColumn == null
                                                   ? -1
                                                   : view.FocusedColumn.ColumnHandle,
                                               view.FocusedColumn == null
                                                   ? ""
                                                   : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;

                if (!_search)
                {
                    if (gbList.RowCount == 0) return;
                    RaiseRowDoubleClickEventHander(ex);
                    Change();
                }
                else
                {
                    SetSearch(ex);
                }
            }
            else
            {
                XtraMessageBox.Show("Object is not AdvBandedGridView");
            }
        }


        public virtual void SetSearch(RowClickEventArgs e)
        {
        }

        private void ucList_ListKeyDown(object sender, KeyEventArgs key)
        {
            //if (key.KeyCode == Keys.Delete)
            //{
            //    m_RowEventArgs = e;
            //    ucToolBar_DeleteClick(ucBar);
            //    return;
            //}
            //else 
            if (key.KeyCode == Keys.F2)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.E)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            else if (key.KeyCode == Keys.Enter)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            else if (key.KeyCode == Keys.F5)
            {
                ReLoad();
                return;
            }
            else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.N)
            {
                Add();
                return;
            }
            else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.T)
            {
                Add();
                return;
            }
        }

        protected virtual void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is AdvBandedGridView)
            {
                var view = (AdvBandedGridView) sender;
                var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                RaiseRowClickEventHander(ex);
                RaiseListKeyDownEventHander(e, ex);
                ucList_ListKeyDown(sender, e);
                m_RowClickEventArgs = ex;
                if (e.KeyCode == Keys.Delete)
                {
                    if (gbList.RowCount == 0) return;
                    Delete();
                    SetMenu(m_RowClickEventArgs);
                }
            }
            else
            {
                XtraMessageBox.Show("Object is not AdvBandedGridView");
            }
        }

       
       
        protected virtual void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }

        protected virtual void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gbList.RowCount == 0) return;
            Change();
        }

        protected virtual void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gbList.RowCount==0) return;
            Delete();
            SetMenu(m_RowClickEventArgs);
        }

        protected virtual void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print();
        }

        protected virtual void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReLoad();
        }

        protected virtual void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Export(gbList);
        }

        protected virtual void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseCloseClickEventHander();
        }

        protected virtual void bbiDeleteAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gbList.RowCount == 0) return;
            gbList.SelectAll();
            Delete();
            SetMenu(m_RowClickEventArgs);
        }

        protected virtual void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));

            var view = (AdvBandedGridView) sender;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClickEventArgs = ex;
            SetMenu(ex);
            RaiseRowClickEventHander(ex);
        }

        protected virtual void SetMenu(RowClickEventArgs e)
        {
        }

        protected void DoShowMenu(GridHitInfo hi)
        {
            GridViewMenu menu;
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }

        public void DisableMenu(bool disable)
        {
            ucToolBar.bbiEdit.Enabled = !disable;
            ucToolBar.bbiDelete.Enabled = !disable;
            ucToolBar.bbiDeleteAll.Enabled = !disable;
            ucToolBar.bbiPermision.Enabled = !disable;
            ucToolBar.bbiCopy.Enabled = !disable;
            ucToolBar.bbiPrint.Enabled = !disable;
            ucToolBar.bbiExport.Enabled = !disable;
        }

        public void DisableMenuNoData(bool disable)
        {
            DisableMenu(disable);
            ucToolBar.bbiPrint.Enabled = !disable;
            ucToolBar.bbiExport.Enabled = !disable;
            ucToolBar.bbiCopy.Enabled = !disable;
            ucToolBar.bbiEdit.Enabled = !disable;
            ucToolBar.bbiDelete.Enabled = !disable;
            ucToolBar.bbiDeleteAll.Enabled = !disable;
        }

        protected virtual void bbiPermision_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle == GridControl.InvalidRowHandle)
            {
                e.Handled = true;
                e.Painter.DrawObject(e.Info);

                Rectangle r = e.Bounds;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 165, 165, 0)), r);
                r.Height--;
                r.Width--;
                e.Graphics.DrawRectangle(Pens.Blue, r);
            }

            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }


        public virtual void SaveLayout(string name)
        {
            //if (!Directory.Exists(Application.StartupPath + "\\Layout"))
            //{
            //    Directory.CreateDirectory(Application.StartupPath + "\\Layout");
            //}
            //try
            //{
            //    gbList.SaveLayoutToXml(Application.StartupPath + "\\Layout\\" + name + ".xml");
            //}
            //catch (Exception ex)
            //{
                
            //    XtraMessageBox.Show("Lỗi:\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK,
            //                        MessageBoxIcon.Warning);
            //}
        }

        public virtual void SaveLayout()
        {
            SaveLayout(Name);
        }

        public virtual void ReadLayout(string name)
        {
            var fileInfo = new FileInfo(Application.StartupPath + "\\Layout\\" + name + ".xml");
            if (fileInfo.Exists)
            {
                try
                {
                    gbList.RestoreLayoutFromXml(fileInfo.FullName);
                }
                catch
                {
                }
            }
        }

        public virtual void ReadLayout()
        {
            ReadLayout(Name);
        }

        protected virtual void gbList_Layout(object sender, EventArgs e)
        {
            SaveLayout();
        }

        protected virtual void gbList_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var ex = new RowClickEventArgs(e.RowHandle, e.Column.ColumnHandle);
            m_RowClickEventArgs = ex;
            RaiseRowClickEventHander(ex);
            ItemSelectd(ex);
            SetMenu(ex);
            SetSearch(ex);
        }
    }
}