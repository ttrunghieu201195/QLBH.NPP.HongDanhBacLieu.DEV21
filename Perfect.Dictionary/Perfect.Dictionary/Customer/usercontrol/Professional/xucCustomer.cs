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

namespace Perfect.Dictionary.Customer.usercontrol.Professional
{
    public partial class XucCustomer : xucBaseBasicB
    {

        public delegate void ItemSelectedEventHander(object sender, CUSTOMER item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(CUSTOMER item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }

        
        public XucCustomer()
        {
            InitializeComponent();
            
            Init();
            ucToolBar.bm.SetPopupContextMenu(gcList, ucToolBar.pm);
            
        }

        void Init()
        {
            SetWaitDialogCaption("Đang nạp cấu hình...");
            SetWaitDialogCaption("Nạp quyền sử dụng...");
            ucToolBar.bbiImport.Visibility = BarItemVisibility.Always;
            MyRule.Check("bbiCustomer");

            //ucToolBar.bbiPrint.Visibility = MyRule.Printed;
            ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;

            ucToolBar.bbiExport.Visibility = MyRule.Exported;
            ucToolBar.bbiAdd.Visibility = MyRule.Added;
            ucToolBar.bbiDelete.Visibility = MyRule.Deleted;
            ucToolBar.bbiEdit.Visibility = MyRule.Edited;
            ucToolBar.bbiEditUnitConvret.Visibility = BarItemVisibility.Never;
            ucToolBar.bbiHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            RibbonBar.Add.Visibility = MyRule.Added;
            RibbonBar.Change.Visibility = MyRule.Edited;
            RibbonBar.Delete.Visibility = MyRule.Deleted;
            RibbonBar.Print.Visibility = MyRule.Printed;
            RibbonBar.Export.Visibility = MyRule.Exported;
            RibbonBar.Import.Visibility = MyRule.Imported;
            RibbonBar.Add.Visibility = BarItemVisibility.Always;
            RibbonBar.PHome = true;
            RibbonBar.GCommand = true;
            RibbonBar.Save.Visibility = BarItemVisibility.Always;

            DoHide();
        }

        public override void ReLoad()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            cUSTOMERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMERTableAdapter.Fill(dsCUSTOMER.CUSTOMER);
             gbList.ClearColumnsFilter();
            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }
        
        public void AddRow(CUSTOMER item)
        {

            
            int currentRow;
            gbList.AddNewRow();
            currentRow = gbList.FocusedRowHandle;

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

        public void UpdateRow(CUSTOMER item, RowClickEventArgs e)
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

        private xfmCustomerAdd _itemAdd;

        protected override void Add()
        {
            if (!MyRule.IsAdd("bbiCustomer")) return;
         
          
            if (_itemAdd == null)
            {
                _itemAdd=new xfmCustomerAdd();
                _itemAdd.Added += ItemAddAdded;
                _itemAdd.Updated += ItemAddUpdated;
                _itemAdd.FormClosing += ItemAddFormClosing;
            }
            _itemAdd.Add();
          
            _itemAdd.ShowDialog();
        }

        void ItemAddUpdated(object sender, CUSTOMER item)
        {
            ReLoad();
        }
        void ItemAddAdded(object sender, CUSTOMER item)
        {
            ReLoad();
        }

        void ItemAddFormClosing(object sender, FormClosingEventArgs e)
        {
           
            _itemAdd = null;
        }
		
        public override void Change()
        {
            if (!MyRule.IsAccess("bbiCustomer")) return;
           var customer = new CUSTOMER();
            object arg = gbList.GetFocusedRowCellValue("Customer_ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            if (customer.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            DoHide();
         
			
            if (_itemAdd == null)
            {
                _itemAdd = new xfmCustomerAdd();
                _itemAdd.Added += ItemAddAdded;
                _itemAdd.Updated += ItemAddUpdated;
                _itemAdd.FormClosing += ItemAddFormClosing;
            }
            _itemAdd.Change(customer);
            if (!_itemAdd.Visible) _itemAdd.Show(this);
        }

        public override void Mirror()
        {
            var customer = new CUSTOMER();
            object arg = gbList.GetFocusedRowCellValue("Customer_ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            if (customer.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            DoHide();
     	
            if (_itemAdd == null)
            {
                _itemAdd = new xfmCustomerAdd();
                _itemAdd.Added += ItemAddAdded;
                _itemAdd.Updated += ItemAddUpdated;
                _itemAdd.FormClosing += ItemAddFormClosing;
            }
            _itemAdd.Change(customer);
            if (!_itemAdd.Visible) _itemAdd.Show(this);
        }

       

        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiCustomer")) return;
            
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;
            SetWaitDialogCaption("Đang xóa...");

            string result;
            bool Deleted;
            Deleted = false;

            //Delete many rows
            int[] selectedRows = gbList.GetSelectedRows();
            var cls = new CUSTOMER();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                Deleted = true;
                object arg = gbList.GetRowCellValue(selectedRows[i - 1], "Customer_ID");
                if (arg == null) continue;
                SysLog.Insert("Quản Lý Khách Hàng", "Xoá", arg.ToString());
                result = cls.Delete(arg.ToString());
                if (result == "OK")
                {
                    gbList.DeleteRow(selectedRows[i - 1]);
                }
                else
                {
                    if (result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa
" + result, @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

            DoHide();

            //Delete one row
            if (!Deleted)
            {
                if (dsCUSTOMER.CUSTOMER.Rows.Count==0) return;
                object arg = gbList.GetFocusedRowCellValue("Customer_ID");
                if (arg == null) return;
                SysLog.Insert("Quản Lý Khách Hàng", "Xoá", arg.ToString());
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
                        MessageBox.Show(@"Thông tin không được xóa
" + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                DoHide();
            }
        }

        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiCustomer")) return;
            SysLog.Insert("Quản Lý Khách Hàng", "In dữ liệu");
            base.Print();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiCustomer")) return false;
            SysLog.Insert("Quản Lý Khách Hàng", "Xuất dữ liệu");
            return base.ExportPermision();
        }

        public override void Import()
        {
            if (!MyRule.IsImport("bbiCustomer")) return;
            var frm = new xfmCustomersImport();
            frm.Show(ParentForm);
        }

        public override void SetSearch(RowClickEventArgs e)
        {
            if (!_search) return;
            var customer = new CUSTOMER();
            object arg = gbList.GetFocusedRowCellValue("Customer_ID");
            if (arg == null) return;

            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            if (customer.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DoHide();
            RaiseItemSelectedEventHander(customer);
        }

        protected override void SetMenu(RowClickEventArgs e)
        {
            object arg = gbList.GetFocusedRowCellValue("Customer_ID");
            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }
            base.SetMenu(e);
        }

        private void SaveLayout()
        {
            SaveLayout("XucCustomer");
        }

        protected virtual void SaveLayout(string name)
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
        private void gbList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var ex = new RowClickEventArgs(e.RowHandle, e.Column.ColumnHandle);
            ItemSelectd(ex);
            SetMenu(ex);
            SetSearch(ex);
        }
        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));
            SetMenu(null);
           
        }
        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            UcListListKeyDown(e);
            if (e.KeyCode == Keys.Delete)
            {
                if (gbList.RowCount == 0) return;
                Delete();
                SetMenu(null);
            }
            
        }
        private void gbList_DoubleClick(object sender, EventArgs e)
        {
            var ex = new RowClickEventArgs(gbList.FocusedRowHandle, "Customer_ID");
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
        private void UcListListKeyDown(KeyEventArgs key)
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
        private void gbList_Layout(object sender, EventArgs e)
        {
            SaveLayout();
        }

        protected override void Clear()
        {
            gbList.SelectAll();
            Delete();
            //base.Clear();
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