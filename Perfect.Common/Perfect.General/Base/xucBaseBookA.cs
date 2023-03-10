using System;
using System.Windows.Forms;
using Perfect.ERP;


namespace Perfect.Common
{
    public partial class xucBaseBookA : Perfect.Common.xucBase
    {
        public delegate void SendIDEventHander(object sender, string ID);

        public event SendIDEventHander SendID;

        public event ButtonClickEventHander ListExpand;

        public event ButtonClickEventHander CloseExpand;

        public delegate void ExpandedEventHander(object sender);

        public event ExpandedEventHander Expanded;
        private void RaiseExpandedEventHander()
        {
            if (Expanded != null) Expanded(this);
        }

        protected void RaiseListExpand()
        {
            if (ListExpand != null) ListExpand(this);
        }
        protected void RaiseCloseExpand()
        {
            if (CloseExpand != null) CloseExpand(this);
        }
        protected void RaiseSendIDEventHander(string ID)
        {
            if (SendID != null) SendID(this,ID);
        }
        bool Expand = false;
        public xucBaseBookA()
        {
            InitializeComponent();
            btnBook.Text = SYS_OPTION.Language == "EN" ? "List" : btnBook.Text;
            btnDelete.Text =SYS_OPTION.Language=="EN"? "Delete": btnDelete.Text;
            btnEdit.Text =SYS_OPTION.Language=="EN"? "Edit": btnEdit.Text; 
            btnSearch.Text =SYS_OPTION.Language=="EN"? "Search": btnSearch.Text;
            lblID.Text = SYS_OPTION.Language == "EN" ? "ID" : lblID.Text;
            bm.SetPopupContextMenu(this,pm);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(btnSearch, e);
            }
        }

        public virtual void Search(){}


        protected virtual void btnSearch_Click(object sender, EventArgs e)
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            btnSearch.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            Search();
            DoHide();
            btnSearch.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        public virtual void AdvanceSearch() { }

        protected virtual void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            btnAdvanceSearch.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            AdvanceSearch();

            DoHide();
            btnAdvanceSearch.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        public virtual void Edit() { }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            btnEdit.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            Edit();

            DoHide();
            btnEdit.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        public virtual void Delete() { }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            btnDelete.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            Delete();

            DoHide();
            btnDelete.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(btnEdit, e);
        }

        protected virtual void gcList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEdit_Click(btnEdit, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(btnDelete, e);
            }
        }

        public object GetCellValue(RowClickEventArgs e)
        {
            object Result = null;
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            DevExpress.XtraGrid.Columns.GridColumn Col = new DevExpress.XtraGrid.Columns.GridColumn();

            if (e.ColumnIndex != -1)
            {
                Col = view.Columns[e.ColumnIndex];

            }
            else
            {
                Col = view.Columns[e.FieldName];
            }
            Result = view.GetRowCellValue(e.RowIndex, Col);
            // if (Result == null | e.RowIndex > gbList.RowCount) VnMessageBox.Error("Không thể lấy thông tin.", "Thông báo");
            return Result;
        }

        public object GetCellValue(int RowIndex, int ColumIndex)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex));
            return Result;
        }

        public object GetCellValue(int RowIndex, string FieldName)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName));
            return Result;
        }

        protected virtual void btnBook_Click(object sender, EventArgs e)
        {
            //RaiseListExpand();
            //if (!Expand)
            //{
            //    RaiseExpandedEventHander();

            //    Expand = true;
            //    btnBook.Text = "Thu nhỏ bảng kê....";
            //    return;
            //}
            //RaiseCloseExpand();
            //btnBook.Text = "Mở rộng bảng kê....";
            //Expand = false;
            RaiseExpandedEventHander();
        }

        protected virtual void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEdit_Click(btnEdit, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(btnDelete, e);
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSearch_Click(sender,e);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDelete_Click(sender,e);
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnEdit_Click(sender,e);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _exportView = gbList;
            Export();
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }
    }
}
