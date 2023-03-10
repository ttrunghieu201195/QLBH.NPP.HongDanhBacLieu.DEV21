using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Dictionary.ProductGroup.usercontrol
{
    public partial class XucProductGroup : xucBaseBasic
    {
 	public delegate void ItemSelectedEventHander(object sender,PRODUCT_GROUP  item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(PRODUCT_GROUP item)
        {
            if (ItemSelected != null) ItemSelected(this,item);
        }
        public XucProductGroup()
        {
            InitializeComponent();
            ucToolBar.bbiImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            ucToolBar.SetInterface();
        }

        public override void ReLoad()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new PRODUCT_GROUP();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);
            //ReadLayout("xucProductGroup");
            SetWaitDialogCaption("Nạp quyền sử dụng...");
            //MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            //if (!MyRule.AllowPrint) ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowExport) ucToolBar.bbiExport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowAdd) ucToolBar.bbiAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowDelete) ucToolBar.bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            MyRule.Get(MyLogin.RoleId, "bbiItemGroup");
            if (!MyRule.AllowEdit) ucToolBar.bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiEditUnitConvret.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        protected override void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "ProductGroup_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = @"Mã";
                        dt.Columns[i].Width = 60;
                        break;
                    case "ProductGroup_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = @"Tên";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Description":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        //dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = @"Ghi chú";
                        dt.Columns[i].Width = 150;
                        break;

                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
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
            gbList.FormatConditions[0].Column = gbList.Columns["ActiveInt"];
        }

        private void AddRow(PRODUCT_GROUP item)
        {

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            view.AddNewRow();
            int currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "ProductGroup_ID", item.ProductGroup_ID);
            view.SetRowCellValue(currentRow, "ProductGroup_Name", item.ProductGroup_Name);
            view.SetRowCellValue(currentRow, "Description", item.Description);
            view.UpdateCurrentRow();

        }

        private void UpdateRow(PRODUCT_GROUP item, RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "ProductGroup_ID", item.ProductGroup_ID);
            view.SetRowCellValue(currentRow, "ProductGroup_Name", item.ProductGroup_Name);
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

            var frm = new XfmProductGroupAdd(Actions.Add);
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        void FrmAdded(object sender, PRODUCT_GROUP e)
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

            var productGroup = new PRODUCT_GROUP();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "ProductGroup_ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (productGroup.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            DoHide();

            var frm = new XfmProductGroupAdd(Actions.Update, productGroup);
            frm.Updated += FrmUpdated;
            frm.Added+=FrmAdded;
            frm.ShowDialog();
        }

        void FrmUpdated(object sender, PRODUCT_GROUP item)
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
            string result;
            bool deleted = false;
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            int[] selectedRows = view.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                if (clsOption.System2.IsQuestion)
                {
                    if (
                        XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.No) return;
                }
            }

            SetWaitDialogCaption("Đang xóa...");
            var cls = new PRODUCT_GROUP();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                object arg = GetCellValue(selectedRows[i - 1], "ProductGroup_ID");

                if (arg == null) continue;

                if (arg.ToString().ToLower() == "md")
                {
                    XtraMessageBox.Show("Đây là nhóm hàng mặc định không được xoá.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                SysLog.Insert("Quản Lý Nhóm Hàng Hoá", "Xoá", arg.ToString());

                result = cls.Delete(arg.ToString());

                if (result == "OK")
                {
                    view.DeleteRow(selectedRows[i - 1]);
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
            if (!deleted)
            {
                if (view.DataSource == null) return;
                var ex = new RowClickEventArgs(view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;
                object arg = GetCellValue(ex.RowIndex, "ProductGroup_ID");
                if (arg == null) return;
                if (arg.ToString().ToLower() == "md")
                {
                    XtraMessageBox.Show("Đây là nhóm hàng mặc định không được xoá.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SysLog.Insert("Quản Lý Nhóm Hàng Hoá", "Xoá", arg.ToString());
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
                        MessageBox.Show(@"Thông tin không được xóa" + result, @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            return base.ExportPermision();
        }

        public override void SetSearch(RowClickEventArgs e)
        {
            if (!_search) return;
            var customer = new PRODUCT_GROUP();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "ProductGroup_ID");
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
        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClickEventArgs = ex;
            object arg = GetCellValue(ex.RowIndex, "ProductGroup_ID");

            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }

        }

        public override void Import()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return;
            if (!MyRule.AllowImport)
            {
                MyRule.Notify();
                return;
            }

            var frm = new xfmProductGroupImport();
            frm.Show(ParentForm);
        }
    }
}

