using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;
using DevExpress.XtraBars;



namespace Perfect.Security
{
    public partial class xucUser : xucBaseBasic
    {
        public xucUser()
        {
            InitializeComponent();
            ucToolBar.SetInterface();
        }

        public override void ReLoad()
        {
            
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new SYS_USER();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);
            SetWaitDialogCaption("Nạp quyền sử dụng...");

            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowPrint) ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowExport) ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowAdd) ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowDelete) ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowEdit) ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;

            
            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        protected override void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "UserID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = false;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Mã";
                        dt.Columns[i].Width = 90;
                        dt.Columns[i].Visible = false;
                        break;
                    case "UserName":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Tên đăng nhập";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Role_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Vai trò";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Description":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Diễn giải";
                        dt.Columns[i].Width = 180;
                        break;

                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Kích hoạt";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        public void AddRow(SYS_USER Item)
        {

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow;
            currentRow = view.FocusedRowHandle;
            view.AddNewRow();
            currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.SetRowCellValue(currentRow, "UserID", Item.UserID);
            view.SetRowCellValue(currentRow, "UserName", Item.UserName);
            view.SetRowCellValue(currentRow, "Role_Name", Item.Group_ID);   
            view.SetRowCellValue(currentRow, "Description", Item.Description);
            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.UpdateCurrentRow();

        }

        public void UpdateRow(SYS_USER Item, RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.SetRowCellValue(currentRow, "UserID", Item.UserID);
            view.SetRowCellValue(currentRow, "Role_Name", Item.Group_ID);
            view.SetRowCellValue(currentRow, "UserName", Item.UserName);
            view.SetRowCellValue(currentRow, "Description", Item.Description);
            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.UpdateCurrentRow();
        }

        protected override void Add()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowAdd)
            {
                XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var frm = new xfmUserAdd(Actions.Add);
            frm.Added += frm_Added;
            frm.ShowDialog();
        }

        void frm_Added(object sender, SYS_USER e)
        {
            AddRow(e);
        }

        public override void Change()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowAccess)
            {
                XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            var sysUser = new SYS_USER();

            object Arg = GetCellValue(m_RowClickEventArgs.RowIndex, "UserID");

            if (Arg == null) return;

            CreateWaitDialog();
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (sysUser.Get(Arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };

            DoHide();

            var frm = new xfmUserAdd(Actions.Update, sysUser);
            frm.Updated += frm_Updated;
            frm.ShowDialog();
        }

        void frm_Updated(object sender, SYS_USER Item)
        {
            UpdateRow(Item, m_RowClickEventArgs);
        }

        public override void Delete()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowDelete)
            {
                XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;           

            CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            string Result;
            bool Deleted = false;

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            //Delete many rows
            int[] SelectedRows = view.GetSelectedRows();
            var cls = new SYS_USER();

            for (int i = SelectedRows.Length; i > 0; i--)
            {
                Deleted = true;
                // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
                object Arg = GetCellValue(SelectedRows[i - 1], "UserID");

                if (Arg == null) continue;

                SysLog.Insert("Quản Lý Người Dùng", "Xoá", Arg.ToString());

                if (Arg.ToString() == MyLogin.UserId) 
                    {
                        XtraMessageBox.Show("Không được xóa người dùng đang sử dụng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                if (Arg.ToString() == "admin")
                {
                    XtraMessageBox.Show("Không được xóa người dùng hệ thống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                

                Result = cls.Delete(Arg.ToString());

                if (Result == "OK")
                {
                    view.DeleteRow(SelectedRows[i - 1]);
                }
                else
                {
                    if (Result != "OK")
                    {
                       // MessageBox.Show("Thông tin không được xóa\n" + Result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        XtraMessageBox.Show("Lỗi:\n\t" + Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            DoHide();

            //Delete one row
            if (!Deleted)
            {
                if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
                if (!MyRule.AllowDelete)
                {
                    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (view.DataSource == null) return;

                //GetRow will Deleted          

                var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;

                //Get Object 
                object Arg = null;
                Arg = GetCellValue(ex.RowIndex, "UserID");
                if (Arg == null) return;

                SysLog.Insert("Quản Lý Người Dùng", "Xoá", Arg.ToString());

                if (Arg.ToString() == MyLogin.UserId)
                {

                    XtraMessageBox.Show("Không được xóa người dùng đang sử dụng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Arg.ToString() == "admin")
                {
                    XtraMessageBox.Show("TKhông được xóa người dùng hệ thống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CreateWaitDialog();
                SetWaitDialogCaption("Đang xóa...");

                Result = cls.Delete(Arg.ToString());

                if (Result == "OK")
                {
                    view.DeleteRow(ex.RowIndex);
                }
                else
                {
                    if (Result != "OK")
                    {
                        XtraMessageBox.Show("Lỗi:\n\t" + Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                DoHide();
            }
        }

        protected override void Print()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            base.Print();
        }

        protected override bool ExportPermision()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") == "OK")
            {
                if (!MyRule.AllowExport)
                {
                    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
           return true;
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClickEventArgs = ex;
            object Arg = GetCellValue(ex.RowIndex, "UserID");

            DisableMenu(false);
            if (Arg == null)
            {
                DisableMenu(true);
                return;
            }

        }
    }
}
