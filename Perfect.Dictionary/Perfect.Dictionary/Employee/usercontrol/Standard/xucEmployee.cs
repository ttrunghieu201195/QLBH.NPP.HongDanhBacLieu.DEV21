using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using Perfect.ERP;
using Perfect.Common;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary.Employee.usercontrol.Standard
{
    public partial class XucEmployee : xucBaseBasic
    {
 	public delegate void ItemSelectedEventHander(object sender,EMPLOYEE  item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(EMPLOYEE item)
        {
            if (ItemSelected != null) ItemSelected(this,item);
        }
        public XucEmployee()
        {
            InitializeComponent();
            ucToolBar.SetInterface();
        }

        public override void ReLoad()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new EMPLOYEE();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);
            SetWaitDialogCaption("Nạp quyền sử dụng...");

            //MyRule.Get(MyLogin.RoleId, "bbiEmployee");
            //if (!MyRule.AllowPrint) ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiEmployee");
            if (!MyRule.AllowExport) ucToolBar.bbiExport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiEmployee");
            if (!MyRule.AllowAdd) ucToolBar.bbiAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiEmployee");
            if (!MyRule.AllowDelete) ucToolBar.bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiEmployee");
            if (!MyRule.AllowEdit) ucToolBar.bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiEditUnitConvret.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            gbList.ClearColumnsFilter();
            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        protected override void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "Employee_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Mã";
                        dt.Columns[i].Width = 60;
                        break;
                    case "Employee_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Tên";
                        dt.Columns[i].Width = 180;
                        break;

                    
                    //case "Address":
                    //    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    //    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    //    dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    //    dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                    //    dt.Columns[i].OptionsColumn.FixedWidth = true;
                    //    dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                    //    if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Địa chỉ";
                    //    dt.Columns[i].Width = 180;
                    //    break;
                    case "O_Tel":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Điện thoại";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Mobile":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Di động";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Email":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Email";
                        dt.Columns[i].Width = 80;
                        break;
                    case "CreatedBy":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Nhóm hàng chính";
                        dt.Columns[i].Width = 100;
                        break;

                    case "ModifiedBy":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Nhóm hàng phụ";
                        dt.Columns[i].Width = 100;
                        break;
                    case "Description":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Khu vực quản lý";
                        dt.Columns[i].Width = 250;
                        break;

                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
            gbList.FormatConditions[0].Column = gbList.Columns["ActiveInt"];
        }

        public void AddRow(EMPLOYEE item)
        {

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            view.AddNewRow();
            int currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "Employee_ID", item.Employee_ID);
            view.SetRowCellValue(currentRow, "Employee_Name", item.Employee_Name);
            view.SetRowCellValue(currentRow, "Address", item.Address);
            view.SetRowCellValue(currentRow, "O_Tel", item.O_Tel);
            view.SetRowCellValue(currentRow, "Email", item.Email);
            view.SetRowCellValue(currentRow, "Mobile", item.Mobile);
            view.SetRowCellValue(currentRow, "Description", item.Description);
            view.SetRowCellValue(currentRow, "Manager_ID", item.Manager_ID);

            view.UpdateCurrentRow();
        }

        public void UpdateRow(EMPLOYEE item, RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "Employee_ID", item.Employee_ID);
            view.SetRowCellValue(currentRow, "Employee_Name", item.Employee_Name);
            view.SetRowCellValue(currentRow, "Address", item.Address);
            view.SetRowCellValue(currentRow, "O_Tel", item.O_Tel);
            view.SetRowCellValue(currentRow, "Email", item.Email);
            view.SetRowCellValue(currentRow, "Mobile", item.Mobile);
            view.SetRowCellValue(currentRow, "Description", item.Description);
            view.UpdateCurrentRow();
        }

        protected override void Add()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiEmployee") != "OK") return;
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return;
            }

            var frm = new XfmEmployeeAdd(Actions.Add);
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        void FrmAdded(object sender, EMPLOYEE e)
        {
            //AddRow(e);
            ReLoad();
        }

        public override void Change()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiEmployee") != "OK") return;
            if (!MyRule.AllowAccess)
            {
                MyRule.Notify();
                return;
            }
            var employee = new EMPLOYEE();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Employee_ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (!employee.Get(arg.ToString()))
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DoHide();
            var frm = new XfmEmployeeAdd(Actions.Update, employee);
            frm.Updated += FrmUpdated;
            frm.Added+=FrmAdded;
            frm.ShowDialog();
        }

        void FrmUpdated(object sender, EMPLOYEE item)
        {
            //UpdateRow(item, m_RowClickEventArgs);
            ReLoad();
        }

        public override void Delete()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiEmployee") != "OK") return;
            if (!MyRule.AllowDelete)
            {
                MyRule.Notify();
                return;
            }

            if (clsOption.System2.IsQuestion)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;
            }


            //CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            bool deleted = false;

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int[] selectedRows = view.GetSelectedRows();
            var cls = new EMPLOYEE();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                object arg = GetCellValue(selectedRows[i - 1], "Employee_ID");
                if (arg == null) continue;
                SysLog.Insert("Quản Lý Nhân Viên", "Xoá", arg.ToString());
                if (cls.Delete(arg.ToString()))
                {
                    view.DeleteRow(selectedRows[i - 1]);
                }
            }

            DoHide();
            if (!deleted)
            {
                if (view.DataSource == null) return;
                var ex = new RowClickEventArgs(view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;

                object arg = GetCellValue(ex.RowIndex, "Employee_ID");
                if (arg == null) return;
                SysLog.Insert("Quản Lý Nhân Viên", "Xoá", arg.ToString());
                SetWaitDialogCaption("Đang xóa...");
                if (cls.Delete(arg.ToString()))
                {
                    view.DeleteRow(ex.RowIndex);
                }
                DoHide();
            }
        }

        protected override void Print()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiEmployee") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }

            base.Print();
        }

        protected override bool ExportPermision()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiEmployee") != "OK") return false;
            if (!MyRule.AllowDelete)
            {
                MyRule.Notify();
                return false;
            }
            return base.ExportPermision();
        }

        public override void SetSearch(RowClickEventArgs e)
        {
            if (!_search) return;

            var customer = new EMPLOYEE();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Employee_ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (!customer.Get(arg.ToString()))
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DoHide();

            RaiseItemSelectedEventHander(customer);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClickEventArgs = ex;
            object arg = GetCellValue(ex.RowIndex, "Employee_ID");

            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }

        }
    }
}

