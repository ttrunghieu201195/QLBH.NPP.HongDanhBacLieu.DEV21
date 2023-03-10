using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using Perfect.Common;
using Perfect.ERP;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary
{
    public partial class xucCurrency : xucBaseBasic
    {
        public delegate void ItemSelectedEventHander(object sender, CURRENCY item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(CURRENCY item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        public xucCurrency()
        {
            InitializeComponent();
            ucToolBar.SetInterface();
            ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiEditUnitConvret.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        public override void ReLoad()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            var cls = new CURRENCY();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);

            SetWaitDialogCaption("Nạp quyền sử dụng...");
           ReadLayout("xucCurrency");
            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        protected override void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "Currency_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Mã";
                        dt.Columns[i].Width = 60;
                        break;
                    case "CurrencyName":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Tên";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Exchange":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = @"Tỷ giá quy đổi";
                        dt.Columns[i].Width = 150;
                        break;

                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
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
            gbList.FormatConditions[0].Column = gbList.Columns["ActiveInt"];
        }

        public void AddRow(CURRENCY item)
        {

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = view.FocusedRowHandle;
            view.AddNewRow();
            currentRow = view.FocusedRowHandle;

            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "Currency_ID", item.Currency_ID);
            view.SetRowCellValue(currentRow, "CurrencyName", item.CurrencyName);
            view.SetRowCellValue(currentRow, "Exchange", item.Exchange);
            view.UpdateCurrentRow();

        }

        public void UpdateRow(CURRENCY item, RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            int currentRow = e.RowIndex;
            view.SetRowCellValue(currentRow, "Active", item.Active);
            view.SetRowCellValue(currentRow, "Currency_ID", item.Currency_ID);
            view.SetRowCellValue(currentRow, "CurrencyName", item.CurrencyName);
            view.SetRowCellValue(currentRow, "Exchange", item.Exchange);
            view.UpdateCurrentRow();
        }

        protected override void Add()
        {
            var frm = new xfmCurrencyAdd(Actions.Add);
            frm.Added += FrmAdded;
            frm.ShowDialog();
        }

        void FrmAdded(object sender, CURRENCY e)
        {
            ReLoad();
            //AddRow(e);
        }

        public override void Change()
        {
            
            var currency = new CURRENCY();

            object arg = GetCellValue(m_RowClickEventArgs.RowIndex, "Currency_ID");

            if (arg == null) return;

            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (currency.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            };

            DoHide();

            var frm = new xfmCurrencyAdd(Actions.Update, currency);
            frm.Updated += FrmUpdated;
            frm.Added+=FrmAdded;
            frm.ShowDialog();
        }

        void FrmUpdated(object sender, CURRENCY item)
        {
            //UpdateRow(item, m_RowClickEventArgs);
            ReLoad();
        }

        public override void Delete()
        {
           string result;
            bool deleted = false;

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;

            //Delete many rows
            int[] selectedRows = view.GetSelectedRows();
            var cls = new CURRENCY();

            if (selectedRows.Length>0)
            {
                if (clsOption.System2.IsQuestion)
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                }

            }

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
                object arg = GetCellValue(selectedRows[i - 1], "Currency_ID");

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
                        MessageBox.Show("Thông tin không được xóa\n" + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

            DoHide();

            if (!deleted)
            {
                if (view.DataSource == null) return;
        

                var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                m_RowClickEventArgs = ex;

                object arg = GetCellValue(ex.RowIndex, "Currency_ID");
                if (arg == null) return;

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
                        MessageBox.Show("Thông tin không được xóa\n" + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                DoHide();
            }
        }

        //protected override void Print()
        //{
        //    //if (MyRule.Get(MyLogin.RoleId, "bbiCurrency") != "OK") return;
        //    //if (!MyRule.AllowPrint)
        //    //{
        //    //    MyRule.Notify();
        //    //    return;
        //    //}
        //    base.Print();
        //}

        //protected override bool ExportPermision()
        //{
        //    //if (MyRule.Get(MyLogin.RoleId, "bbiCurrency") != "OK") return false;
        //    //if (!MyRule.AllowExport)
        //    //{
        //    //    MyRule.Notify();
        //    //    return false;
        //    //}
        //    return base.ExportPermision();
        //}
   
        protected override void SetMenu(RowClickEventArgs e)
        {
            object arg = GetCellValue(e.RowIndex, "Currency_ID");

            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }
            base.SetMenu(e);
        }

        public override void SaveLayout(string name)
        {
            base.SaveLayout("xucCurrency");
        }
		
	}
}

