using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using Perfect.ERP;
using Perfect.Common;
using DevExpress.XtraEditors;
using System.Drawing;
using System;

namespace Perfect.Dictionary.Unit.TS
{
    public partial class xucNotes : xucBaseBasic
    {
        public xucNotes()
        {
            InitializeComponent();
            
        }
         
        public override void ReLoad()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new NOTES();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);

            gbList.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(gbList_RowCellStyle);
            //ReadLayout("xucUnit");
            SetWaitDialogCaption("Nạp quyền sử dụng...");
            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowPrint) ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowExport) ucToolBar.bbiExport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowAdd) ucToolBar.bbiAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowDelete) ucToolBar.bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //MyRule.Get(MyLogin.RoleId, "bbiUnit");
            //if (!MyRule.AllowEdit) ucToolBar.bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiEditUnitConvret.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;


            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        void gbList_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        { 
            if (e.Column.FieldName == "Description")
            {
                string colorName = Convert.ToString(gbList.GetRowCellValue(e.RowHandle, "Description"));
                e.Appearance.BackColor = Color.FromName(colorName);
            }
        }
         
        protected override void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "ID":
                        {
                            dt.Columns[i].OptionsColumn.ReadOnly = true;
                            //dt.Columns[i].OptionsColumn.AllowEdit = false;
                            dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                            dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                            //dt.Columns[i].OptionsColumn.FixedWidth = true;
                            dt.Columns[i].Caption = @"Mã";
                            //dt.Columns[i].Width = 60;
                        }
                        break;
                    case "Name":
                        {
                            dt.Columns[i].OptionsColumn.ReadOnly = true;
                            //dt.Columns[i].OptionsColumn.AllowEdit = false;
                            dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                            dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                            //dt.Columns[i].OptionsColumn.FixedWidth = true;
                             dt.Columns[i].Caption = @"Tên";
                            //dt.Columns[i].Width = 120;
                        }
                        break;
                    case "Description":
                        {
                            dt.Columns[i].OptionsColumn.ReadOnly = true;
                            //dt.Columns[i].OptionsColumn.AllowEdit = false;
                            dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                            dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                            dt.Columns[i].AppearanceCell.ForeColor = Color.White;
                            dt.Columns[i].Caption = @"Màu sắc";
                            //dt.Columns[i].Width = 120;
                            
                        }
                        break;
                    case "Active":
                        {
                            dt.Columns[i].OptionsColumn.ReadOnly = true;
                            //dt.Columns[i].OptionsColumn.AllowEdit = false;
                            dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                            dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                            //dt.Columns[i].OptionsColumn.FixedWidth = true;
                             dt.Columns[i].Caption = @"Còn Quản Lý";
                            //dt.Columns[i].Width = 80;
                        }
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }


             

            gbList.BestFitColumns();
            gbList.FormatConditions[0].Column = gbList.Columns["ActiveInt"];
        }

        private void AddRow(NOTES item)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            view.AddNewRow();
            int currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "ID", item.ID);
            view.SetRowCellValue(currentRow, "Name", item.Name);
            view.SetRowCellValue(currentRow, "Description", item.Description);
            view.UpdateCurrentRow();
        }

        private void UpdateRow(NOTES item, RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "ID", item.ID);
            view.SetRowCellValue(currentRow, "Name", item.Name);
            view.SetRowCellValue(currentRow, "Description", item.Description);
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

            var frm = new xfmNotesAdd(Actions.Add);
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        private void FrmAdded(object sender, NOTES e)
        {
            //AddRow(e);
            ReLoad();
        }

        public override void Change()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return;
            //if (!MyRule.AllowAccess)
            //{
            //    MyRule.Notify();
            //    return;
            //}
            var unit = new NOTES();
            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "ID");
            if (arg == null) return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (unit.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DoHide();

            var frm = new xfmNotesAdd(Actions.Update, unit);
            frm.Updated += FrmUpdated;
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        private void FrmUpdated(object sender, NOTES item)
        {
            //UpdateRow(item, m_RowClickEventArgs);
            ReLoad();
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
                if (
                    XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No) return;
            }

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            string result;
            bool deleted = false;

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            //Delete many rows
            int[] selectedRows = view.GetSelectedRows();
            var cls = new NOTES();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                 object arg = GetCellValue(selectedRows[i - 1], "ID");

                if (arg == null) continue;  

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
            var view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView) sender;
            if (view != null)
            {
                var ex = new RowClickEventArgs(view.FocusedRowHandle,
                                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;
                object arg = GetCellValue(ex.RowIndex, "ID");

                DisableMenu(false);
                if (arg == null)
                {
                    DisableMenu(true);
                    return;
                }
            }
        }

        public override void SaveLayout(string name)
        {
            //base.SaveLayout("xucUnit");
        }

        public override void Import()
        {
            //if (CODE.TypeSoft < 2)
            //{
            //    CODE.Notify();
            //    return;
            //}

            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return;
            //if (!MyRule.AllowImport)
            //{
            //    MyRule.Notify();
            //    return;
            //}

            //var frm = new xfmUnitImport();
            //frm.Show(ParentForm);
        }
    }
}