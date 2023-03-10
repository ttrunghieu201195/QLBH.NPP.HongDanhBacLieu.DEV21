using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Dictionary.Stock.usercontrol
{
    public partial class XucStock : xucBaseBasic
    {
        public delegate void ItemSelectedEventHander(object sender, STOCK item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(STOCK item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }

        public XucStock()
        {
            InitializeComponent();
            ucToolBar.bbiImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            ucToolBar.SetInterface();
        }

        public override void ReLoad()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new STOCK();
            DataTable dataTable = cls.GetList();

            gcList.DataSource = dataTable;
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);
            SetWaitDialogCaption("Nạp quyền sử dụng...");
            //MyRule.Get(MyLogin.RoleId, "bbiStock");
            //if (!MyRule.AllowPrint) ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiStock");
            if (!MyRule.AllowExport) ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiStock");
            if (!MyRule.AllowAdd) ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiStock");
            if (!MyRule.AllowDelete) ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiStock");
            if (!MyRule.AllowEdit) ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;

            ucToolBar.bbiHistory.Visibility = BarItemVisibility.Never;
            ucToolBar.bbiEditUnitConvret.Visibility = BarItemVisibility.Never;

            gbList.BeginUpdate();
            gbList.BestFitColumns();
            gbList.EndUpdate();


            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        protected override void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
         
            if (dt.Columns.Count > 5)
            {
                gbList.OptionsView.ColumnAutoWidth = false;
            }
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "Stock_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Mã";
                        dt.Columns[i].Width = 60;
                        break;
                    case "Stock_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Tên";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Mobi":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Ký hiệu";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Address":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Địa Chỉ";
                        dt.Columns[i].Visible = true;
                        dt.Columns[i].Width = 180;
                        break;
                    case "Contact":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Liên Hệ";
                        dt.Columns[i].Visible = true;
                        dt.Columns[i].Width = 180;
                        break;
                    case "Manager":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Mã";
                        dt.Columns[i].Visible = false;
                        dt.Columns[i].Width = 180;
                        break;
                    case "EmpName":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Quản Lý";
                        dt.Columns[i].Visible = true;
                        dt.Columns[i].Width = 180;
                        break;
                    case "Telephone":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Điện Thoại";
                        dt.Columns[i].Visible = true;
                        dt.Columns[i].Width = 180;
                        break;
                    case "Description":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Ghi chú";
                        dt.Columns[i].Width = 150;
                        break;
                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Còn Quản Lý";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
            gbList.BestFitColumns();
            gbList.FormatConditions[0].Column = gbList.Columns["ActiveInt"];
        }

        private void AddRow(STOCK item)
        {
            var cls = new STOCK();
            DataTable dataTable = cls.GetList();
            gcList.DataSource = dataTable;
            List_Init(gbList);
            ReadLayout("xucStock");
        }

        private void UpdateRow(STOCK item, RowClickEventArgs e)
        {
            var cls = new STOCK();
            DataTable dataTable = cls.GetList();
            gcList.DataSource = dataTable;
            List_Init(gbList);
            ReadLayout("xucStock");

        }

        protected override void Add()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return;
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return;
            }

            var frm = new xfmStockAdd(Actions.Add);
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        private void FrmAdded(object sender, STOCK e)
        {
            //AddRow(e);
            ReLoad();
        }

        public override void Change()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return;
            if (!MyRule.AllowAccess)
            {
                MyRule.Notify();
                return;
            }

            var stock = new STOCK();

            var arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Stock_ID");

            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            if (stock.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ;

            DoHide();

            var frm = new xfmStockAdd(Actions.Update, stock);
            frm.Updated += FrmUpdated;
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        private void FrmUpdated(object sender, STOCK item)
        {
            //UpdateRow(item, m_RowClickEventArgs);
            ReLoad();
        }

        public override void Delete()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return;
            if (!MyRule.AllowDelete)
            {
                MyRule.Notify();
                return;
            }

            string result;
            var deleted = false;

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            //Delete many rows
            var selectedRows = view.GetSelectedRows();
            var cls = new STOCK();
            if (selectedRows.Length > 0)
            {
                if (clsOption.System2.IsQuestion)
                {
                    if (
                        XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.No) return;
                }
            }
            SetWaitDialogCaption("Đang xóa...");
            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                var arg = GetCellValue(selectedRows[i - 1], "Stock_ID");
                              
                SysLog.Insert("Quản Lý Danh Mục Kho", "Xoá", arg.ToString());
                result = cls.Delete(arg.ToString());

                if (result == "OK")
                {
                    view.DeleteRow(selectedRows[i - 1]);
                }
                else
                {
                    if (result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa" + result, @"Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                    }
                }
            }

            DoHide();

            //Delete one row
            if (!deleted)
            {
                if (view.DataSource == null) return;

                //GetRow will Deleted          

                var ex = new RowClickEventArgs(view.FocusedRowHandle,
                                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;

                //Get Object 
                object arg = GetCellValue(ex.RowIndex, "Stock_ID");
                if (arg == null) return;
                SysLog.Insert("Quản Lý Danh Mục Kho", "Xoá", arg.ToString());
                SetWaitDialogCaption("Đang xóa...");
                result = cls.Delete(arg.ToString());
                if (result == "OK")
                {
                    view.DeleteRow(ex.RowIndex);
                }
                else
                {
                    if (result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa" + result, @"Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                    }
                }
                DoHide();
            }
        }

        protected override void Print()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }

            SysLog.Insert("Quản Lý Danh Mục Kho", "In");

            base.Print();
        }

        protected override bool ExportPermision()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return false;
            if (!MyRule.AllowExport)
            {
                MyRule.Notify();
                return false;
            }

            SysLog.Insert("Quản Lý Danh Mục Kho", "Xuất");

            return base.ExportPermision();
        }

        public override void SetSearch(RowClickEventArgs e)
        {
            if (!_search) return;

            var stock = new STOCK();

            var arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Stock_ID");

            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (stock.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DoHide();

            RaiseItemSelectedEventHander(stock);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView) sender;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClickEventArgs = ex;
            var arg = GetCellValue(ex.RowIndex, "Stock_ID");

            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }
        }

      
        public override void Import()
        {
            if (CODE.TypeSoft < 2)
            {
                CODE.Notify();
                return;
            }

            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return;
            if (!MyRule.AllowImport)
            {
                MyRule.Notify();
                return;
            }

            var frm = new xfmStocksImport();
            frm.Show(ParentForm);
        }
    }
}