using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;
using DevExpress.XtraEditors;
using Perfect.Utils.System2;
using System.ComponentModel;
using System.Reflection;

namespace Perfect.Dictionary
{
    public partial class xucUnit : Perfect.Common.xucBaseBasic
    {
        public xucUnit()
        {
            InitializeComponent();
            //ucToolBar.bbiImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //ucToolBar.SetInterface();
            //MessageBox.Show(EnumUtils.stringValueOf(UNIT.Fields.Unit_ID));
        }

        public override void ReLoad()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            UNIT cls = new UNIT();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);
            ReadLayout("xucUnit");
            SetWaitDialogCaption("Nạp quyền sử dụng...");
            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowPrint) ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowExport) ucToolBar.bbiExport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowAdd) ucToolBar.bbiAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowDelete) ucToolBar.bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowEdit) ucToolBar.bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {

        }

        protected override void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            
            for (int i = 0; i < dt.Columns.Count; i++)
            {

                if (dt.Columns[i].FieldName == EnumUtils.stringValueOf(UNIT.Fields.Unit_ID))
                {
                    // case (EnumUtils.stringValueOf(UNIT.Fields.Unit_ID)):
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                    if (SYS_OPTION.Language == "VN") dt.Columns[i].Caption = "Mã";
                    dt.Columns[i].Width = 60;
                }
                else if (dt.Columns[i].FieldName == "Unit_Name")
                {
                    // case EnumUtils.stringValueOf (UNIT.Fields.Unit_Name):
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                    if (SYS_OPTION.Language == "VN") dt.Columns[i].Caption = "Tên";
                    dt.Columns[i].Width = 180;
                }
                else if (dt.Columns[i].FieldName == "Description")
                {
                    // case EnumUtils.stringValueOf (UNIT.Fields.Description):
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                    if (SYS_OPTION.Language == "VN") dt.Columns[i].Caption = "Ghi chú";
                    dt.Columns[i].Width = 150;
                }
                //else if (dt.Columns[i].FieldName == "Active")
                //{
                //    // case EnumUtils.stringValueOf (UNIT.Fields.Active):
                //    dt.Columns[i].OptionsColumn.ReadOnly = true;
                //    dt.Columns[i].OptionsColumn.AllowEdit = false;
                //    dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    
                //    dt.Columns[i].OptionsColumn.FixedWidth = true;
                //    if (SYS_OPTION.Language == "VN") dt.Columns[i].Caption = "Kích hoạt";
                //    dt.Columns[i].Width = 80;
                //}
                else
                {
                    dt.Columns[i].Visible = false;
                }
            }
        }

        public void AddRow(UNIT Item)
        {

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow;
            currentRow = view.FocusedRowHandle;
            view.AddNewRow();
            currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.SetRowCellValue(currentRow, "Unit_ID", Item.Unit_ID);
            view.SetRowCellValue(currentRow, "Unit_Name", Item.Unit_Name);
            view.SetRowCellValue(currentRow, "Description", Item.Description);
            view.UpdateCurrentRow();

        }

        public void UpdateRow(UNIT Item, RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", Item.Active);
            view.SetRowCellValue(currentRow, "Unit_ID", Item.Unit_ID);
            view.SetRowCellValue(currentRow, "Unit_Name", Item.Unit_Name);
            view.SetRowCellValue(currentRow, "Description", Item.Description);
            view.UpdateCurrentRow();
        }

        protected override void Add()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return;
            //if (!MyRule.AllowAdd)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            xfmUnitAdd frm = new xfmUnitAdd(Actions.Add);
            frm.Added += new xfmUnitAdd.AddedEventHander(frm_Added);
            frm.ShowDialog();
        }

        void frm_Added(object sender, UNIT e)
        {
            AddRow(e);
        }

        public override void Change()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return;
            //if (!MyRule.AllowAccess)
            //{
            //    MyRule.Notify();
            //    return;
            //}


            UNIT UNIT = new UNIT();

            object Arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Unit_ID");

            if (Arg == null) return;

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (UNIT.Get(Arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            };

            DoHide();

            xfmUnitAdd frm = new xfmUnitAdd(Actions.Update, UNIT);
            frm.Updated += new xfmUnitAdd.UpdatedEventHander(frm_Updated);
            frm.Added+=new xfmUnitAdd.AddedEventHander(frm_Added);
            frm.ShowDialog();
        }

        void frm_Updated(object sender, UNIT Item)
        {
            UpdateRow(Item, m_RowClickEventArgs);
        }

        public override void Delete()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return;
            //if (!MyRule.AllowDelete)
            //{
            //    MyRule.Notify();
            //    return;
            //}


            if (clsOption.System2.IsQuestion)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;
            }

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            string Result = "";
            bool Deleted = false;

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            //Delete many rows
            int[] SelectedRows = view.GetSelectedRows();
            UNIT cls = new UNIT();

            for (int i = SelectedRows.Length; i > 0; i--)
            {
                Deleted = true;
                // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
                object Arg = GetCellValue(SelectedRows[i - 1], "Unit_ID");

                if (Arg == null) continue;

                if (Arg.ToString().ToLower() == "kg")
                {
                    XtraMessageBox.Show("Đây là đơn vị mặc định không được xoá.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                SYS_LOG.Insert("Quản Lý Đơn Vị Tính", "Xoá", Arg.ToString());

                Result = cls.Delete(Arg.ToString());

                if (Result == "OK")
                {
                    view.DeleteRow(SelectedRows[i - 1]);
                }
                else
                {
                    if (Result != "OK")
                    {
                        MessageBox.Show("Thông tin không được xóa\n" + Result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

            DoHide();

            //Delete one row
            if (!Deleted)
            {
                if (view.DataSource == null) return;

                //GetRow will Deleted          

                RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;

                //Get Object 
                object Arg = null;
                Arg = GetCellValue(ex.RowIndex, "Unit_ID");
                if (Arg == null) return;

                if (Arg.ToString().ToLower() == "kg")
                {
                    XtraMessageBox.Show("Đây là đơn vị mặc định không được xoá.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SYS_LOG.Insert("Quản Lý Đơn Vị Tính", "Xoá", Arg.ToString());

                //CreateWaitDialog();
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
                        MessageBox.Show("Thông tin không được xóa\n" + Result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                DoHide();
            }
        }

        protected override void Print()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return;
            //if (!MyRule.AllowPrint)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            base.Print();
        }

        protected override bool ExportPermision()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return false;
            //if (!MyRule.AllowExport)
            //{
            //    MyRule.Notify();
            //    return false;
            //}
            _exportView = gbList;
            return base.ExportPermision();
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClickEventArgs = ex;
            object Arg = GetCellValue(ex.RowIndex, "Unit_ID");

            DisableMenu(false);
            if (Arg == null)
            {
                DisableMenu(true);
                return;
            }

        }

        public override void SaveLayout(string name)
        {
            base.SaveLayout("xucUnit");
        }

        public override void Import()
        {
            if (CODE.TypeSoft < 2)
            {
                CODE.Notify();
                return;
            }

            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return;
            //if (!MyRule.AllowImport)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            xfmUnitImport frm = new xfmUnitImport();
            frm.Show(ParentForm);
        }
    }
}

