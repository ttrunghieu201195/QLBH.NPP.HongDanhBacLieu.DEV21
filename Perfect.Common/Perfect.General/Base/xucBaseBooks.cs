using System;
using System.Windows.Forms;
using Perfect.ERP;
using DevExpress.XtraGrid.Views.Base;


namespace Perfect.Common
{
    public partial class xucBaseBooks : Perfect.Common.xucBase
    {

        #region Member
        string m_Title = "";

        BaseView m_ExportView;

        bool m_Expand = false;

        public string m_Type = "General";
        
        #endregion
        
        #region Function
        
        public object GetCellValue(int RowIndex, string FieldName)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName));
            return Result;
        }

        public object GetCellValue(int RowIndex, int ColumIndex)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex));
            return Result;
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

        #endregion
        
        #region Constructor

        public xucBaseBooks()
        {
            InitializeComponent();
            btnBook.Text = SYS_OPTION.Language == "EN" ? "List" : btnBook.Text;
            btnDelete.Text =SYS_OPTION.Language=="EN"? "Delete": btnDelete.Text;
            btnEdit.Text =SYS_OPTION.Language=="EN"? "Edit": btnEdit.Text; 
            btnSearch.Text =SYS_OPTION.Language=="EN"? "Search": btnSearch.Text;
            lblID.Text = SYS_OPTION.Language == "EN" ? "ID" : lblID.Text;
            //plDetail.Visible = false;
        }

        #endregion

        #region EventHander

        protected virtual void Export_ProgressEx(object sender, DevExpress.XtraPrinting.ChangeEventArgs e)
        {
            if (e.EventName == DevExpress.XtraPrinting.SR.ProgressPositionChanged)
            {
                int pos = (int)e.ValueOf(DevExpress.XtraPrinting.SR.ProgressPosition);
                progressForm.SetProgressValue(pos);
            }
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

        protected virtual void btnBook_Click(object sender, EventArgs e)
        {
            RaiseListExpand();
            if (!m_Expand)
            {
                RaiseExpandedEventHander();
                m_Expand = true;
                btnBook.Text = "Thu nhỏ bảng kê....";
                plDetail.Visible = true;
                return;
            }
            RaiseCloseExpand();
            btnBook.Text = "Mở rộng bảng kê....";
            plDetail.Visible = false;
            m_Expand = false;
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

        protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(btnEdit, e);
        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnAdvanceSearch_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch_Click(btnSearch, e);
        }

        #endregion

        #region Delegate

        protected void RaiseSendIDEventHander(string ID)
        {
            if (SendID != null) SendID(this,ID);
        }

        protected void RaiseCloseExpand()
        {
            if (CloseExpand != null) CloseExpand(this);
        }

        protected void RaiseListExpand()
        {
            if (ListExpand != null) ListExpand(this);
        }

        private void RaiseExpandedEventHander()
        {
            if (Expanded != null) Expanded(this);
        }

        public event ExpandedEventHander Expanded;

        public delegate void ExpandedEventHander(object sender);

        public event ButtonClickEventHander CloseExpand;

        public event ButtonClickEventHander ListExpand;

        public event SendIDEventHander SendID;
        public delegate void SendIDEventHander(object sender, string ID);
        #endregion

        #region Property

        public BaseView ExportView
        {
            get
            {
                return m_ExportView;
            }
            set
            {
                m_ExportView = value;
            }
        }

        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }
        #endregion

       

        public virtual void Reload()
        {

        }

        protected virtual void gbList_Click(object sender, EventArgs e)
        {

        }

        private void btView_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            Export(gbList);
        }

        private void btPrint_Click(object sender, EventArgs e)
        {

        }

        private void chxDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (chxDetail.Checked)
            {
                m_Type = "Detail";
            }
            else
            {
                m_Type = "General";
            }
        }

    }
}
