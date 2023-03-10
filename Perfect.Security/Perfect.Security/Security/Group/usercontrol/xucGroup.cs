using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Security
{

    public partial class xucGroup : xucBaseBasic
    {
        public delegate void AddedEventHander(object sender,SYS_GROUP item);
        
        public event AddedEventHander Added;
        
        private void RaiseAddedEventHander(SYS_GROUP item )
	      {
		      if (Added !=null) Added(this,item);
	      }
    
        public xucGroup()
        {
            InitializeComponent();
            ucToolBar.SetInterface();
            ucToolBar.bbiPermision.Visibility = BarItemVisibility.Always;
           // bbiPermision.Visibility = BarItemVisibility.Always;
           // bbiPermision.Enabled = false;
            ucToolBar.bbiPermision.Enabled = false;            
        }
        public override void ReLoad()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new SYS_GROUP();
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
                    case "Group_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = SysOption.Language == "VN" ? "Mã" : "Role_Id";
                        dt.Columns[i].Width = 90;
                        break;
                    case "Group_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = SysOption.Language == "VN" ? "Vai trò" : "Role_Name";
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

        public void AddRow(SYS_GROUP Item)
        {

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow;
            currentRow = view.FocusedRowHandle;
            view.AddNewRow();
            currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.SetRowCellValue(currentRow, "Group_ID", Item.Group_ID);
            view.SetRowCellValue(currentRow, "Group_Name", Item.Group_Name);
            view.SetRowCellValue(currentRow, "Description", Item.Description);
            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.UpdateCurrentRow();

        }

        public void UpdateRow(SYS_GROUP Item, RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.SetRowCellValue(currentRow, "Group_ID", Item.Group_ID);
            view.SetRowCellValue(currentRow, "Group_Name", Item.Group_Name);
            view.SetRowCellValue(currentRow, "Description", Item.Description);
            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.UpdateCurrentRow();
        }

        protected override void Add()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return;
            }

            var frm = new XfmGroupAdd(Actions.Add);
            frm.Added += frm_Added;
            frm.ShowDialog();
        }

        void frm_Added(object sender, SYS_GROUP e)
        {
            AddRow(e);
            RaiseAddedEventHander(e);
        }

        public override void Change()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowAccess)
            {
                MyRule.Notify();
                return;
            }

            var sysGroup = new SYS_GROUP();

            object Arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Group_ID");

            if (Arg == null) return;

            CreateWaitDialog();
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (sysGroup.Get(Arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };

            DoHide();

            var frm = new XfmGroupAdd(Actions.Update, sysGroup);
            frm.Updated += frm_Updated;
            frm.ShowDialog();
        }

        void frm_Updated(object sender, SYS_GROUP Item)
        {
            UpdateRow(Item, m_RowClickEventArgs);
        }

        public override void Delete()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowDelete)
            {
                MyRule.Notify();
                return;
            }

            if (clsOption.System2.IsQuestion)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            }

            CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            string Result;
            bool Deleted = false;

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            //Delete many rows
            int[] selectedRows = view.GetSelectedRows();
            var cls = new SYS_GROUP();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                Deleted = true;
                // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
                object arg = GetCellValue(selectedRows[i - 1], "Group_ID");

                if (arg == null) continue;

                SysLog.Insert("Vai Trò Người Dùng", "Xoá", arg.ToString());
                if (arg.ToString().ToLower() == "admin")
                {
                    XtraMessageBox.Show("Nhóm người dùng không này không được xoá.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                Result = cls.Delete(arg.ToString());

                if (Result == "OK")
                {
                    view.DeleteRow(selectedRows[i - 1]);
                }
                else
                {
                    if (Result != "OK")
                    {
                        MessageBox.Show("Thông tin không được xóa\n" + Result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            DoHide();

            //Delete one row
            if (!Deleted)
            {
                if (view.DataSource == null) return;

                //GetRow will Deleted          

                var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;

                //Get Object 
                object arg = null;
                arg = GetCellValue(ex.RowIndex, "Group_ID");
                if (arg == null) return;

                SysLog.Insert("Vai Trò Người Dùng", "Xoá", arg.ToString());

                if (arg.ToString().ToLower() == "admin")
                {
                    XtraMessageBox.Show("Nhóm người dùng không này không được xoá.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CreateWaitDialog();
                SetWaitDialogCaption("Đang xóa...");

                Result = cls.Delete(arg.ToString());

                if (Result == "OK")
                {
                    view.DeleteRow(ex.RowIndex);
                }
                else
                {
                    if (Result != "OK")
                    {
                        MessageBox.Show("Thông tin không được xóa\n" + Result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MyRule.Notify();
                return;
            }
            base.Print();
        }

        protected override bool ExportPermision()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return false;
            if (!MyRule.AllowExport)
            {
                MyRule.Notify();
                return false;
            }
            return true;
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClickEventArgs = ex;
            object arg = GetCellValue(ex.RowIndex, "Group_ID");

            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }
        }

        public override void Permision()
        {
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Group_ID");
            if (arg == null) return;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            var sysGroup = new SYS_GROUP();    
            if (sysGroup.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            DoHide();
            var xfmPermision = new xfmPermision();
            xfmPermision.SetData(arg.ToString());
            xfmPermision.ShowDialog();
            

        }

        protected override void bbiPermision_ItemClick(object sender, ItemClickEventArgs e)
        {
            Permision();
        }
    }
}
