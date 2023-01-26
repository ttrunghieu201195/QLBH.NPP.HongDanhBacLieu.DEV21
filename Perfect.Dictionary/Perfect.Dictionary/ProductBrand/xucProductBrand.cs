using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Dictionary.CustomerGroup.usercontrol
{
    public partial class xucProductBrand : xucBaseBasic
    {
        #region Delegates

        public delegate void ItemSelectedEventHander(object sender, PRODUCT_BRAND item);

        #endregion

        public xucProductBrand()
        {
            InitializeComponent();
            
        }

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(PRODUCT_BRAND item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }

        public override void ReLoad()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new PRODUCT_BRAND();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);
            SetWaitDialogCaption("Nạp quyền sử dụng...");
            //MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            //if (!MyRule.AllowPrint) ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowExport) ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowAdd) ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowDelete) ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowEdit) ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            ucToolBar.bbiEditUnitConvret.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        protected override void List_Init(AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = @"Mã số";
                        dt.Columns[i].Width = 60;
                        break;
                    case "Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = @"Tên";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Description":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = @"Ghi chú";
                        dt.Columns[i].Width = 150;
                        break;

                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Còn Quản Lý";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            } 
        }

        public void AddRow(PRODUCT_BRAND item)
        {
            AdvBandedGridView view = gbList;
            view.AddNewRow();
            int currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "ID", item.ID);
            view.SetRowCellValue(currentRow, "Name", item.Name);
            view.SetRowCellValue(currentRow, "Description", item.Description);
            view.UpdateCurrentRow();
        }

        public void UpdateRow(PRODUCT_BRAND item, RowClickEventArgs e)
        {
            AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "ID", item.ID);
            view.SetRowCellValue(currentRow, "Name", item.Name);
            view.SetRowCellValue(currentRow, "Description", item.Description);
            view.UpdateCurrentRow();
        }

        protected override void Add()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return;
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return;
            }
            var frm = new xfmProductBrandAdd(Actions.Add);
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        private void FrmAdded(object sender, PRODUCT_BRAND e)
        {
            //AddRow(e);
            ReLoad();
        }

        public override void Change()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return;
            if (!MyRule.AllowAccess)
            {
                MyRule.Notify();
                return;
            }
            var customerGroup = new PRODUCT_BRAND();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            if (customerGroup.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DoHide();
            var frm = new xfmProductBrandAdd(Actions.Update, customerGroup);
            frm.Updated += FrmUpdated;
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        public override void Mirror()
        {
            var customerGroupcustomer = new PRODUCT_BRAND();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
            if (customerGroupcustomer.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DoHide();
        }

        private void FrmUpdated(object sender, PRODUCT_BRAND item)
        {
            //UpdateRow(item, m_RowClickEventArgs);
            ReLoad();
        }

        public override void Delete()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return;
            if (!MyRule.AllowDelete)
            {
                MyRule.Notify();
                return;
            }

            if (clsOption.System2.IsQuestion)
            {
                if (
                    XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No) return;
            }


            //CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            string result;
            bool deleted = false;
            AdvBandedGridView view = gbList;
            int[] selectedRows = view.GetSelectedRows();
            var cls = new PRODUCT_BRAND();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                object arg = GetCellValue(selectedRows[i - 1], "ID");
                if (arg == null) continue;
                SysLog.Insert("Thương Hiệu", "Xoá", arg.ToString());
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
                object arg = GetCellValue(ex.RowIndex, "ID");
                if (arg == null) return;

                SysLog.Insert("Thương hiệu", "Xoá", arg.ToString());

                //CreateWaitDialog();
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
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }
            SysLog.Insert("Thương Hiệu", "In dữ liệu");
            base.Print();
        }

        protected override bool ExportPermision()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return false;
            if (!MyRule.AllowExport)
            {
                MyRule.Notify();
                return false;
            }

            SysLog.Insert("Thương Hiệu", "Xuất dữ liệu");

            return base.ExportPermision();
        }

        public override void Import()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return;
            if (!MyRule.AllowImport)
            {
                MyRule.Notify();
                return;
            }
            var frm = new xfmCustomersImport();
            frm.Show(ParentForm);
        }

        public override void SetSearch(RowClickEventArgs e)
        {
            if (!_search) return;
            var customerGroup = new PRODUCT_BRAND();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (customerGroup.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DoHide();
            RaiseItemSelectedEventHander(customerGroup);
        }

        protected override void SetMenu(RowClickEventArgs e)
        {
            object arg = GetCellValue(e.RowIndex, "ID");

            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }
            base.SetMenu(e);
        }

        public override void SaveLayout()
        {
            base.SaveLayout("xucProductBrand");
        }
    }
}