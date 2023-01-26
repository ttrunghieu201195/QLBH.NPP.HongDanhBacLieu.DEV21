using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using Perfect.Common;
using Perfect.ERP;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace Perfect.Security.Security.GroupUser.usercontrol
{
    public partial class XucGroupUser : UserControl
    {
        private GridView _cvgroupuser;

        #region delegate group

        public delegate void AddEvenedHander(Object sender, SYS_GROUP item);

        public event AddEvenedHander Added;

        public void RaiseAddedEventHander(SYS_GROUP item)
        {
            if (Added != null) Added(this, item);
        }

        #endregion

        public XucGroupUser()
        {
            InitializeComponent();
            Init();
            Reload();
            //bbiPermision .Visibility = DevExpress .XtraBars .BarItemVisibility.Always ;
            //bbiPermision .Enabled = false ;
        }

        private void Reload()
        {
            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowAdd) bbiAdd.Visibility = BarItemVisibility.Never;
            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowDelete) bbiDelete.Visibility = BarItemVisibility.Never;
            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowEdit) bbiEdit.Visibility = BarItemVisibility.Never;
            MyRule.Get(MyLogin.RoleId, "bbiPermission");
            if (!MyRule.AllowAdd) bbiAddUser.Visibility = BarItemVisibility.Never;
        }

        #region init

        private string m_TreeID = string.Empty;
        private GroupUser.Class.SYS_GROUPUSER _sysGroupuser;
        private SYS_GROUP _sysGroup;

        private void Init()
        {
            sYS_USERTableAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            sYS_USERTableAdapter.Fill(dsGroup_User.SYS_USER);
            treeList1.ExpandAll();
            gbgroupuser.ExpandMasterRow(0);
            bm1.SetPopupContextMenu(this, pm1);
        }

        #endregion

        #region methols 4 event

        private void AddUser()
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

        private void frm_Added(object sender, SYS_USER e)
        {
            //AddRow(e);
        }

        private void AddGroup()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify(); //hien thong bao : ban ko co quyen
                return;
            }
            var frm = new XfmGroupAdd(Actions.Add);
            frm.ShowDialog();
            Init();
        }

        private void Changegroup()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowEdit)
            {
                MyRule.Notify();
                return;
            }
            var sysGroup = new SYS_GROUP();
            object arg = treeList1.FocusedNode.GetValue(colPARENT_ID);
            if (arg == null) return;
            if (sysGroup.Get(arg.ToString()) != "OK")
            {
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var frm = new XfmGroupAdd(Actions.Update, sysGroup);
            frm.ShowDialog();
            Init();
        }

        private void Changeuser()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowEdit)
            {
                XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sysUser = new SYS_USER();
            object arg = treeList1.FocusedNode.GetValue(colID);
            if (arg == null) return;
            if (sysUser.Get(arg.ToString()) != "OK")
            {
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var frm = new xfmUserAdd(Actions.Update, sysUser);
            frm.ShowDialog();
            Init();
        }

        private void frm_Updated(object sender, SYS_GROUP item)
        {
            //xucGroup xucgroup = new xucGroup();
            //xucGroup.UpdateRow(Item, m_RowClickEventArgs); // cập nhật vào lưới
        }

        private void Deleteuser()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            //if (!MyRule.AllowDelete)
            //{
            //    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No) return;

            string Result;
            bool Deleted = false;

            #region xóa nhiều dòng trên lưới

            // DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            //Delete many rows
            //int[] SelectedRows = view.GetSelectedRows();
            //SYS_USER cls = new SYS_USER();

            //for (int i = SelectedRows.Length; i > 0; i--)
            //{
            //    Deleted = true;
            //    // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
            //    object Arg = GetCellValue(SelectedRows[i - 1], "UserID");

            //    if (Arg == null) continue;

            //    SYS_LOG.Insert("Quản Lý Người Dùng", "Xoá", Arg.ToString());

            //    if (Arg.ToString() == MyLogin.UserId)
            //    {
            //        XtraMessageBox.Show("Không được xóa người dùng đang sử dụng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        continue;
            //    }
            //    if (Arg.ToString() == "admin")
            //    {
            //        XtraMessageBox.Show("Không được xóa người dùng hệ thống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        continue;
            //    }


            //    Result = cls.Delete(Arg.ToString());

            //    if (Result == "OK")
            //    {
            //        view.DeleteRow(SelectedRows[i - 1]);
            //    }
            //    else
            //    {
            //        if (Result != "OK")
            //        {
            //            // MessageBox.Show("Thông tin không được xóa\n" + Result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //            XtraMessageBox.Show("Lỗi:\n\t" + Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}

            //DoHide();

            # endregion

            //Delete one row
            if (!Deleted)
            {
                //if (MyRule.Get(MyLogin.RoleId, "bbiUsers") != "OK") return;
                //if (!MyRule.AllowDelete)
                //{
                //    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                if (treeList1.DataSource == null) return;

                //GetRow will Deleted          

                //RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                //m_RowClickEventArgs = ex;

                //Get Object 
                object arg = treeList1.FocusedNode.GetValue(colID);
                if (arg == null) return;

                SysLog.Insert("Quản Lý Người Dùng", "Xoá", arg.ToString());

                if (arg.ToString() == MyLogin.UserId)
                {
                    XtraMessageBox.Show("Không được xóa người dùng đang sử dụng.", "Cảnh Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                }

                if (arg.ToString() == "admin")
                {
                    XtraMessageBox.Show("Không được xóa người dùng hệ thống.", "Cảnh Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                }
                var cls = new SYS_USER();
                Result = cls.Delete(arg.ToString());

                if (Result == "OK")
                {
                    treeList1.DeleteSelectedNodes();
                }
                else
                {
                    if (Result != "OK")
                    {
                        XtraMessageBox.Show("Lỗi:\n\t" + Result, "Thông Báo", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Deletegroup()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return;
            if (!MyRule.AllowDelete)
            {
                MyRule.Notify();
                return;
            }
            string s = treeList1.FocusedNode.GetValue(colDescName).ToString();
            if (clsOption.System2.IsQuestion)
            {
                if (
                    XtraMessageBox.Show("Bạn có muốn xóa nhóm " + s + " này không", "Thông báo", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No) return;
            }
            string Result;
            bool Deleted = false;
            //Delete one row
            if (!Deleted)
            {
                if (treeList1.DataSource == null) return;
                object arg = treeList1.FocusedNode.GetValue(colPARENT_ID);
                if (arg == null) return;
                SysLog.Insert("Vai Trò Người Dùng", "Xoá", arg.ToString());
                if (arg.ToString().ToLower() == "admin")
                {
                    XtraMessageBox.Show("Nhóm người dùng này không được xoá.", "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                }
                _sysGroup = new SYS_GROUP();
                Result = _sysGroup.Delete(arg.ToString());
                if (Result == "OK")
                {
                    treeList1.DeleteSelectedNodes();
                }
                else
                {
                    if (Result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa" + Result, @"Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                    }
                }
            }
        }

        #endregion

        #region grid

        private void ListGroup_Init(GridView dt)
        {
            dt.OptionsSelection.EnableAppearanceFocusedCell = false;
            dt.OptionsSelection.EnableAppearanceFocusedRow = false;
            dt.OptionsDetail.ShowDetailTabs = false;
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
                        dt.Columns[i].Caption = SysOption.Language == "VN" ? @"Mã Nhóm" : "Role_Id";
                        dt.Columns[i].Width = 90;
                        break;
                    case "Group_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = SysOption.Language == "VN" ? @"Vai Trò" : "Role_Name";
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
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Diễn Giải";
                        dt.Columns[i].Width = 180;
                        break;

                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Kích Hoạt";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        private void ListUser_Init(GridView dt)
        {
            dt.OptionsView.ShowAutoFilterRow = true;
            dt.OptionsView.ShowGroupPanel = false;
            dt.OptionsSelection.EnableAppearanceFocusedCell = false;
            dt.OptionsSelection.EnableAppearanceFocusedRow = false;
            //dt.ViewCaption = "Thông Tin Người Dùng";

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
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Mã";
                        dt.Columns[i].Width = 90;
                        dt.Columns[i].Visible = false;
                        break;
                    case "UserName":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Tên Đăng Nhập";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Role_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Vai Trò";
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
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Diễn giải";
                        dt.Columns[i].Width = 180;
                        break;

                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Kích Hoạt";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        public bool checkAcount()
        {
            if (MyLogin.Account == "admin") return true;

            return false;
        }

        private void TreeList1FocusedNodeChanged1(object sender, FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null) return;
            if (e.Node != null && e.Node.Level == 0 || e.Node != null && e.Node.Level == 1)
            {
                #region

                string treeId = Convert.ToString(e.Node.GetValue(colPARENT_ID) ?? "");
                System.Data.DataSet ds;
                ds = new System.Data.DataSet();
                _sysGroup = new SYS_GROUP();
                _sysGroupuser = new Class.SYS_GROUPUSER();
                var tb_group = new DataTable("Groups");
                var tb_user = new DataTable("Users");
                tb_group = _sysGroup.Get_List(treeId);
                tb_user = _sysGroupuser.Get_List2(treeId);
                ds.Tables.Add(tb_group);
                ds.Tables.Add(tb_user);
                DataColumn keycolumn = tb_group.Columns["Group_ID"];
                DataColumn keyforeigncolumn = tb_user.Columns["Group_ID"];
                ds.Relations.Add("GroupUser", keycolumn, keyforeigncolumn);
                gcgroupuser.DataSource = ds.Tables["table1"];
                gcgroupuser.ForceInitialize();
                _cvgroupuser = new GridView(gcgroupuser);
                gcgroupuser.LevelTree.Nodes.Add("GroupUser", _cvgroupuser);
                _cvgroupuser.PopulateColumns(ds.Tables["table2"]);
                gbgroupuser.Columns["Group_NameEn"].VisibleIndex = -1;
                _cvgroupuser.Columns["Group_ID"].VisibleIndex = -1;
                _cvgroupuser.Columns["UserID"].VisibleIndex = -1;
                ListGroup_Init(gbgroupuser);

                #endregion

                #region

                {
                    ListUser_Init(_cvgroupuser);

                    gbgroupuser.ExpandMasterRow(0);
                    var condition1 = new StyleFormatCondition();
                    condition1.Appearance.BackColor = Color.Khaki;
                    condition1.Appearance.Options.UseBackColor = true;
                    condition1.Condition = FormatConditionEnum.Expression;

                    if (e.Node.Level == 1)
                    {
                        string userid = Convert.ToString(e.Node.GetValue(colID) ?? "");
                        condition1.Expression = "[UserID] == " + "'" + userid + "'";
                        _cvgroupuser.FormatConditions.Add(condition1);
                        gbgroupuser.FormatConditions.Clear();
                        _cvgroupuser.OptionsView.EnableAppearanceEvenRow = true;
                    }
                    if (e.Node.Level == 0)
                    {
                        condition1.Expression = "[Group_ID] == " + "'" + treeId + "'";
                        gbgroupuser.FormatConditions.Add(condition1);
                    }
                }

                #endregion

                Permision(treeId);
            }
        }

        private void Permision(string treeid)
        {
            if (treeid == null) return;
            var sysGroup = new SYS_GROUP();
            if (sysGroup.Get(treeid) != "OK")
            {
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ucList = new xucPermision();
            groupControl2.Controls.Clear();
            groupControl2.Controls.Add(ucList);
            ucList.SetData1(treeid, groupControl2, gcgroupuser);
            ucList.Dock = DockStyle.Fill;
            ucList.Show();
        }

        # endregion

        #region event

        private void BbiAddItemClick(object sender, ItemClickEventArgs e)
        {
            AddGroup();
            Init();
            treeList1.Refresh();
        }

        private void BbiEditItemClick(object sender, ItemClickEventArgs e)
        {
            if (treeList1.FocusedNode.Level == 0)
                Changegroup();
            if (treeList1.FocusedNode.Level == 1)
                Changeuser();
        }

        private void BbiDeleteItemClick(object sender, ItemClickEventArgs e)
        {
            if (treeList1.FocusedNode.Level == 1)
            {
                Deleteuser();
            }
            else if (treeList1.FocusedNode.Level == 0)
            {
                Deletegroup();
            }
        }

        private void BbiAddUserItemClick(object sender, ItemClickEventArgs e)
        {
            AddUser();
            Init();
            treeList1.Refresh();
        }

        private void BbiCloseItemClick(object sender, ItemClickEventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        #endregion
    }
}