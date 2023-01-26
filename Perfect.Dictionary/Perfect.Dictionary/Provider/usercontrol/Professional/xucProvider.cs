using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.ERP;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Perfect.Dictionary.Provider.usercontrol.Professional
{
    public partial class XucProvider : xucBaseBasicB
    {

        private xfmProviderAdd _itemAdd;

        #region Delegate

        public event ItemSelectedEventHander ItemSelected;
        public delegate void ItemSelectedEventHander(object sender, PROVIDER item);

        private void RaiseItemSelectedEventHander(PROVIDER item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        #endregion

        #region Contructor
        public XucProvider()
        {
            InitializeComponent();
            
            Init();
            ucToolBar.bm.SetPopupContextMenu(gcList, ucToolBar.pm);


            gbList.ShownEditor += gbListShownEditor;
        }

        private void gbListShownEditor(object sender, EventArgs e)
        {
            var view = sender as GridView;

            view.ActiveEditor.DoubleClick += ActiveEditorDoubleClick;
        
        }

        private void ActiveEditorDoubleClick(object sender, EventArgs e)
        {
            Change();
        }

        void Init()
        {
            SetWaitDialogCaption("Đang nạp cấu hình...");
            SetWaitDialogCaption("Nạp quyền sử dụng...");
            ucToolBar.bbiImport.Visibility = BarItemVisibility.Always;
            ucToolBar.bbiHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            MyRule.Check("bbiProvider");

            //ucToolBar.bbiPrint.Visibility = MyRule.Printed;
            ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            ucToolBar.bbiExport.Visibility = MyRule.Exported;
            ucToolBar.bbiAdd.Visibility = MyRule.Added;
            ucToolBar.bbiDelete.Visibility = MyRule.Deleted;
            ucToolBar.bbiEdit.Visibility = MyRule.Edited;
            ucToolBar.bbiEditUnitConvret.Visibility = BarItemVisibility.Never;
            ucToolBar.bbiHistory.Visibility = BarItemVisibility.Never;

            RibbonBar.Add.Visibility = MyRule.Added;
            RibbonBar.Change.Visibility = MyRule.Edited;
            RibbonBar.Delete.Visibility = MyRule.Deleted;
            RibbonBar.Print.Visibility = MyRule.Printed;
            RibbonBar.Export.Visibility = MyRule.Exported;
            RibbonBar.Import.Visibility = MyRule.Imported;

            pROVIDERFULLTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROVIDERFULLTableAdapter.Fill(dsPROVIDER.PROVIDERFULL);
            DoHide();
        }

        #endregion

        #region User Function

        protected override void Add()
        {
            if (!MyRule.IsAdd("bbiProvider")) return;

            if (_itemAdd == null)
            {
                _itemAdd = new xfmProviderAdd();
                _itemAdd.Added += ItemAddAdded;
                _itemAdd.Updated += ItemAddUpdated;
                _itemAdd.FormClosing += ItemAddFormClosing;
            }
            _itemAdd.Add();
            // _itemAdd.SetGroup(type);
            if (!_itemAdd.Visible) _itemAdd.ShowDialog();
        }

        void ItemAddUpdated(object sender, PROVIDER item)
        {
            ReLoad();
        }
        void ItemAddAdded(object sender, PROVIDER item)
        {
            ReLoad();
        }

        void ItemAddFormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            _itemAdd = null;
        }


        private void AddRow(PROVIDER item)
        {
            gbList.AddNewRow();
            int currentRow = gbList.FocusedRowHandle;

            gbList.SetRowCellValue(currentRow, "Active", item.Active);
            gbList.SetRowCellValue(currentRow, "Customer_ID", item.Customer_ID);
            gbList.SetRowCellValue(currentRow, "CustomerName", item.CustomerName);
            gbList.SetRowCellValue(currentRow, "Description", item.Description);
            gbList.SetRowCellValue(currentRow, "CustomerAddress", item.CustomerAddress);
            gbList.SetRowCellValue(currentRow, "Tax", item.Tax);
            gbList.SetRowCellValue(currentRow, "Fax", item.Fax);
            gbList.SetRowCellValue(currentRow, "Tel", item.Tel);
            gbList.UpdateCurrentRow();

        }

        public override void Change()
        {

            if (!MyRule.IsAdd("bbiProvider")) return;

            var provider = new PROVIDER();
            object arg = gbList.GetFocusedRowCellValue("Customer_ID");
            if (arg == null) return;

            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            if (provider.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DoHide();

          
            if (_itemAdd == null)
            {
                _itemAdd = new xfmProviderAdd();
                _itemAdd.Added += ItemAddAdded;
                _itemAdd.Updated += ItemAddUpdated;
                _itemAdd.FormClosing += ItemAddFormClosing;
            }
            _itemAdd.Change(provider);
            if (!_itemAdd.Visible) _itemAdd.Show(this);
        }

        public override void Delete()
        {

            if (!MyRule.IsDelete("bbiProvider")) return;
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            SetWaitDialogCaption("Đang xóa...");

            string result;
            bool deleted = false;

            //Delete many rows
            int[] selectedRows = gbList.GetSelectedRows();
            var cls = new PROVIDER();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
                object arg = gbList.GetRowCellValue(selectedRows[i - 1], "Customer_ID");
                if (arg == null) continue;
                SysLog.Insert("Quản Lý Nhà Phân Phối", "Xoá", arg.ToString());
                result = cls.Delete(arg.ToString());
                if (result == "OK")
                {
                    gbList.DeleteRow(selectedRows[i - 1]);
                }
                else
                {
                    if (result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa" + result, @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

            DoHide();

            //Delete one row
            if (!deleted)
            {
                if (dsPROVIDER.PROVIDERFULL.Rows.Count==0) return;
        object arg = gbList.GetFocusedRowCellValue("Customer_ID");
                if (arg == null) return;
                SysLog.Insert("Quản Lý Nhà Phân Phối", "Xoá", arg.ToString());
                //CreateWaitDialog();
                SetWaitDialogCaption("Đang xóa...");

                result = cls.Delete(arg.ToString());

                if (result == "OK")
                {
                    gbList.DeleteRow(gbList.FocusedRowHandle);
                }
                else
                {
                    if (result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa" + result, @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                DoHide();
            }
        }

       
        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiProvider")) return false;
            SysLog.Insert("Quản Lý Nhà Phân Phối", "Xuất");

            return base.ExportPermision();
        }

        protected override void Print()
        {

            if (!MyRule.IsPrint("bbiProvider")) return;

            SysLog.Insert("Quản Lý Nhà Phân Phối", "In");

            base.Print();
        }

        public override void ReLoad()
        {
            //CreateWaitDialog();
            //SetWaitDialogCaption("Đang nạp dữ liệu...");
            //PROVIDER cls = new PROVIDER();
            //gcList.DataSource = cls.GetList();

            //ReadLayout("xucProvider");
            //gbList.ClearColumnsFilter();
            //SetWaitDialogCaption("Đã xong...");
            //DoHide();

            pROVIDERFULLTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROVIDERFULLTableAdapter.Fill(dsPROVIDER.PROVIDERFULL);
        }

        public override void SetSearch(Perfect.Common.RowClickEventArgs e)
        {
            if (!_search) return;

            var provider = new PROVIDER();

            object arg = gbList.GetFocusedRowCellValue("Customer_ID");
            if (arg == null) return;

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (provider.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            DoHide();

            RaiseItemSelectedEventHander(provider);
        }

        public void UpdateRow(PROVIDER item, Perfect.Common.RowClickEventArgs e)
        {
            int currentRow = gbList.FocusedRowHandle;
            gbList.SetRowCellValue(currentRow, "Active", item.Active);
            gbList.SetRowCellValue(currentRow, "Customer_ID", item.Customer_ID);
            gbList.SetRowCellValue(currentRow, "CustomerName", item.CustomerName);
            gbList.SetRowCellValue(currentRow, "Description", item.Description);
            gbList.SetRowCellValue(currentRow, "CustomerAddress", item.CustomerAddress);
            gbList.SetRowCellValue(currentRow, "Tax", item.Tax);
            gbList.SetRowCellValue(currentRow, "Fax", item.Fax);
            gbList.SetRowCellValue(currentRow, "Tel", item.Tel);
            gbList.UpdateCurrentRow();
        }
        #endregion

        #region Event

        void frm_Added(object sender, PROVIDER e)
        {
            AddRow(e);
        }

        void frm_Updated(object sender, PROVIDER Item)
        {
            UpdateRow(Item, m_RowClickEventArgs);
        }


        protected override void SetMenu(Perfect.Common.RowClickEventArgs e)
        {
            object Arg = gbList.GetFocusedRowCellValue("Customer_ID");

            DisableMenu(false);
            if (Arg == null)
            {
                DisableMenu(true);
                return;
            }

            base.SetMenu(e);
        }

        #endregion

        private void SaveLayout()
        {
            SaveLayout("xucProvider");
        }

        public override void Import()
        {
            if (!MyRule.IsImport("bbiProvider")) return;
            var frm = new xfmProviderImport();
            frm.Show(ParentForm);
        }

        public virtual void SaveLayout(string name)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Layout"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Layout");
            }
            try
            {
                gbList.SaveLayoutToXml(Application.StartupPath + "\\Layout\\" + name + ".xml");
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void GbListCustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
        private void GbListRowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var ex = new Perfect.Common.RowClickEventArgs(e.RowHandle, e.Column.ColumnHandle);
            ItemSelectd(ex);
            SetMenu(ex);
            SetSearch(ex);
        }
        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));
            SetMenu(null);

        }
        private void GbListKeyDown(object sender, KeyEventArgs e)
        {
            UcListListKeyDown(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                if (gbList.RowCount == 0) return;
                Delete();
                SetMenu(null);
            }

        }
        private void GbListDoubleClick(object sender, EventArgs e)
        {
            var ex = new Perfect.Common.RowClickEventArgs(gbList.FocusedRowHandle, "Customer_ID");
            if (!_search)
            {
                if (gbList.RowCount == 0) return;
                Change();
            }
            else
            {
                SetSearch(ex);
            }
        }
        private void UcListListKeyDown(object sender, KeyEventArgs key)
        {
            
            if (key.KeyCode == Keys.F2)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            if (key.KeyCode == Keys.Control | key.KeyCode == Keys.E)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            if (key.KeyCode == Keys.Enter)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            if (key.KeyCode == Keys.F5)
            {
                ReLoad();
                return;
            }
            if (key.KeyCode == Keys.Control | key.KeyCode == Keys.N)
            {
                Add();
                return;
            }
            if (key.KeyCode == Keys.Control | key.KeyCode == Keys.T)
            {
                Add();
                return;
            }
        }

        private void DoShowMenu(GridHitInfo hi)
        {
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                GridViewMenu menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }
        private void GbListLayout(object sender, EventArgs e)
        {
            SaveLayout();
        }

        protected override void Clear()
        {
            gbList.SelectAll();
            Delete();
        }


        protected override void History()
        {
            object arg = gbList.GetFocusedRowCellValue("Customer_ID");
            if (arg == null) return;
            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(arg.ToString(), "");
            xfmHistory.ShowDialog(this);
        }

        protected override void Copy()
        {
            gbList.CopyToClipboard();
        }
    }
}

