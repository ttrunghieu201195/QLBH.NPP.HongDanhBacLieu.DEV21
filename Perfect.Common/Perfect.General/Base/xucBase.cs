using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars;

namespace Perfect.Common
{

    public delegate void RibbonChangedEventHander(object sender,RibbonChangedEventArgs e);
    public delegate void SaveChangedEventHander(object sender, SaveChangedEventArgs e);
    public delegate void SaveChangingEventHander(object sender, SaveChangingEventArgs e);

    public delegate void SaveCompleteEventHander(object sender,SaveCompleteEventArgs e);
    
    public class xucBase : DevExpress.XtraEditors.XtraUserControl
    {
        public event RibbonChangedEventHander RibbonChanged;
        protected void RaiseRibbonChanged(RibbonChangedEventArgs e)
        {
            RibbonChangedEventHander changed = RibbonChanged;
            if (changed != null) changed(this, e);
        }

        public event SaveChangedEventHander SaveChanged;

        protected void RaiseSaveChanged(SaveChangedEventArgs e)
        {
            SaveChangedEventHander changed = SaveChanged;
            if (changed != null) changed(this, e);
        }

        public event SaveChangingEventHander SaveChanging;

        protected void RaiseSaveChanging(SaveChangingEventArgs e)
        {
            SaveChangingEventHander changing = SaveChanging;
            if (changing != null) changing(this, e);
        }

        public event SaveCompleteEventHander SaveComplete;

        protected void RaiseSaveComplete(SaveCompleteEventArgs e)
        {
            SaveCompleteEventHander complete = SaveComplete;
            if (complete != null) complete(this, e);
        }


        private DevExpress.Utils.WaitDialogForm dlg = null;

        protected ProgressForm progressForm = null;

        protected Actions m_Status = new Actions();

        private System.ComponentModel.IContainer components;

        protected DevExpress.XtraBars.Alerter.AlertControl alc;

        protected CloseOrNew m_CloseOrNew = new CloseOrNew();

        protected MenuButton m_Menu;

        private bool m_isSave = false;
        [DisplayName("Save")]
        [Category("Config")]
        [Description("Là thuộc tính thể trạng thái của dữ liệu hiện tại có được lưu hay chưa.")]
        public bool NotSave
        {
            get { return m_isSave; }
            set { m_isSave = value; }
        }
        
        public enum TypeAdd
        {
            None = 0,
            Single = 1,
            Replace = 2,
            Add = 3,
            Duplicate = 4
        }


        public enum ColumnKeyPress
        {
            None = 0,
            Quantity = 1,
            UnitPrice = 2,
            Amount = 3,
            Discount = 4,
            Vat = 5,
            Unit = 6
        }
        [DisplayName("Status")]
        [Category("Config")]
        [Description("Là thuộc tính thể trạng thái của dữ liệu.")]

        public Actions Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }
        [DisplayName("Close")]
        [Category("Config")]
        public CloseOrNew IsClose
        {
            get { return m_CloseOrNew; }
            set { m_CloseOrNew = value; }
        }

        //public BaseView ExportView
        //{
        //    get { return _exportView; }
        //    set { _exportView = value; }
        //}
        [DisplayName("Title")]
        [Category("Config")]
        [Description("Là thuộc tính tiêu đề khi in ra.")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [PropertyTab(typeof(MenuButton))]
        [DisplayName("Bar")]
        [Category("Config")]
      
        public MenuButton RibbonBar
        {
            get { return m_Menu; }
            set { m_Menu = value; }
        }

        public delegate void SuccessEventHander(object sender, Object Item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(Object Item)
        {
            if (Success != null) Success(this, Item);
        }

        public xucBase()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            alc = new AlertControl();
            alc.AllowHtmlText = true;
            m_Status = Actions.None;
            m_CloseOrNew = CloseOrNew.None;
            m_Menu=new MenuButton();

        }

        public void CreateWaitDialog()
        {
            //if (dlg==null)
            dlg = new DevExpress.Utils.WaitDialogForm("Đang nạp dữ liệu...","Vui lòng đợi trong giây lát...");
            //dlg.Opacity = 0.5;
        }

        public void SetWaitDialogCaption(string fCaption)
        {
            if (dlg != null)
                dlg.Caption = fCaption;
            else
            {
                CreateWaitDialog();
                if (dlg != null) dlg.Caption = fCaption;
            }
        }

        public void SetWaitDialogCaption(string fCaption,string fTitle)
        {
            if (dlg != null)
                {
                    DoHide();
                    dlg = new DevExpress.Utils.WaitDialogForm(fCaption,fTitle);
                    //dlg.Opacity = 0.5;
                }
            else
            {
                dlg = new DevExpress.Utils.WaitDialogForm(fCaption, fTitle);
               // dlg.Opacity = 0.5;
            }
        }

        protected bool start = true;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.VisibleChanged += new EventHandler(OnVisibleChanged);
            if (dlg != null) dlg.Close();
        }

        protected virtual void OnSwitchStyle() { }
        //protected virtual void OnVisibleChanged(object sender, EventArgs e)
        //{

        //}
        protected virtual void DoShow() { }

        protected virtual void DoHide()
        {
            base.OnLoad(EventArgs.Empty);
            // this.VisibleChanged += new EventHandler(OnVisibleChanged);
            if (dlg != null)
            {
                dlg.FormClosing += new FormClosingEventHandler(dlg_FormClosing);
                dlg.Close();
            }
        }

        void dlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            dlg.Dispose();
            dlg = null;
        }

        public virtual void Clear()
        {

        }

        public virtual void Delete()
        {

        }

        public string GenerateCode(string studentName)
        {
            string code = "";
            string[] words = studentName.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    code += word.Substring(0, 1);
                }
            }
            return code;
        }


        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption)
        {
            FormatColumns(item, column, pos, width, caption, true);
        }

        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption,bool visible)
        {
            FormatColumns(item, column, pos, width, caption,null,visible);
        }
        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption, RepositoryItem repositoryItem)
        {
            FormatColumns(item, column, pos, width, caption, repositoryItem, true);
        }
        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption,RepositoryItem repositoryItem, bool visible)
        {
            GridColumn col12 = item.View.Columns.AddField(column);
            col12.VisibleIndex = pos;
            col12.Caption = caption;
            col12.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            col12.Visible = visible;
            col12.ColumnEdit = repositoryItem;
            col12.Width = width;
            
            
        }



        public object GetCellValue(RowClickEventArgs e, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view)
        {
            object Result = null;
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
        
        public object GetCellValue(RowClickEventArgs e, DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            object Result = null;

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

        public object GetCellValue(int Rowindex, DevExpress.XtraGrid.Columns.GridColumn ColIndex, DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            return GetCellValue(new RowClickEventArgs(Rowindex, ColIndex.ColumnHandle, ColIndex.FieldName), view);
        }

        public object GetCellValue(int Rowindex,int ColIndex, DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            return GetCellValue(new RowClickEventArgs(Rowindex, ColIndex), view);
        }

        public object GetCellValue(int Rowindex, string FieldName, DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            return GetCellValue(new RowClickEventArgs(Rowindex, FieldName), view);
        }

        public object GetCellValue(int RowIndex, int ColumIndex, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex), view);
            return Result;
        }

        public object GetCellValue(int RowIndex, string FieldName, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName), view);
            return Result;
        }


        private string _title = "";
        protected BaseView _exportView;

        public virtual void Export(BaseView view, string title)
        {
            Title = title;
            Export(view);
        }

        protected virtual bool ExportPermision()
        {
            return true;
        }

        public virtual void Export(BaseView view)
        {
            _exportView = view;
            Export();
        }
        
        public void Export()
        {
            if (!ExportPermision()) return;
            SaveFileDialog sDlg = new SaveFileDialog();
            sDlg.Filter = "Microsoft Excel 97-2003(*.xls)|*.xls|Microsoft Excel 2007(*.xlsx)|*.xlsx|PDF(*.pdf)|*.pdf|Rich Text Format(*.rtf)|*.rtf|Webpage (*.htm)|*.htm";
            sDlg.FilterIndex = 0;
            sDlg.ShowDialog();
            if (sDlg.FileName != null)
            {
                try
                {
                    //btnExports.Enabled = false;
                    
                    if (sDlg.FilterIndex == 1)
                    {
                        ExportToEx(sDlg.FileName, "xls");
                    }
                    else if (sDlg.FilterIndex == 2)
                    {
                        ExportToEx(sDlg.FileName, "xlsx");
                    }
                    else if (sDlg.FilterIndex == 3)
                    {
                        ExportToEx(sDlg.FileName, "pdf");
                    }
                    else if (sDlg.FilterIndex == 4)
                    {
                        ExportToEx(sDlg.FileName, "rtf");
                    }
                    else if (sDlg.FilterIndex == 5)
                    {
                        ExportToEx(sDlg.FileName, "htm");
                    }
                    //VnMessageBox.Info("Kết xuất thành công.");
                    if (File.Exists(sDlg.FileName))
                    {
                        if (XtraMessageBox.Show("Bạn muốn mở tài liệu này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                        Process.Start(sDlg.FileName);
                    }

                }
                catch (System.Exception ex)
                {
                    //VnMessageBox.Error(ex.Message);
                    EndExport();
                }
                //btnExports.Enabled = true;
            }
        }

        protected virtual void StartExport()
        {
            //if (this != null) MenuForm.Update();
            progressForm = new ProgressForm(this);
            progressForm.Show();
            progressForm.Refresh();
        }

        private void ExportToEx(String filename, string ext)
        {
            StartExport();
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            
            if (_exportView == null)
            {
               EndExport();
               XtraMessageBox.Show("Đối tượng kết xuất chưa xác định");
               return;
            }

            DevExpress.XtraPrinting.IPrintingSystem ps = new PrintingSystem();
            ps.AfterChange += new DevExpress.XtraPrinting.ChangeEventHandler(Export_ProgressEx);
            if (ext == "rtf") _exportView.ExportToRtf(filename);
            if (ext == "pdf") _exportView.ExportToPdf(filename);
            if (ext == "mht") _exportView.ExportToMht(filename);
            if (ext == "htm") _exportView.ExportToHtml(filename,new HtmlExportOptions("utf-8"));
            if (ext == "txt") _exportView.ExportToText(filename,new TextExportOptions(" ",Encoding.Unicode));
            if (ext == "xls")
            {
                _exportView.ExportToXls(filename,new XlsExportOptions(TextExportMode.Value,true));
            }
#pragma warning disable 618,612
            if (ext == "xlsOld")
            {
                _exportView.ExportToExcelOld(filename);
            }
            
#pragma warning restore 618,612
            if (ext == "xlsx")
            {
                _exportView.ExportToXlsx(filename,new XlsxExportOptions(TextExportMode.Value,true));
            }
            ps.AfterChange -= new DevExpress.XtraPrinting.ChangeEventHandler(Export_ProgressEx);
            Cursor.Current = currentCursor;
            EndExport();
           
        }

        protected virtual void EndExport()
        {
            if (progressForm != null) progressForm.Dispose();
            progressForm = null;
        }

        protected virtual void Export_ProgressEx(object sender, DevExpress.XtraPrinting.ChangeEventArgs e)
        {
            if (e.EventName == DevExpress.XtraPrinting.SR.ProgressPositionChanged)
            {
                int pos = (int)e.ValueOf(DevExpress.XtraPrinting.SR.ProgressPosition);
                progressForm.SetProgressValue(pos);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.alc = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.SuspendLayout();
            // 
            // alc
            // 
            this.alc.AllowHtmlText = true;
            // 
            // xucBase
            // 
            this.Name = "xucBase";
            this.ResumeLayout(false);

        }

        public void DoShowMenu(GridHitInfo hi, DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            GridViewMenu menu;
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                menu = new GridViewColumnButtonMenu(view);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }
    }

    public class GridViewColumnButtonMenu : GridViewMenu
    {
        public GridViewColumnButtonMenu(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view) { }
        protected override void CreateItems()
        {
            Items.Clear();
            DXSubMenuItem columnsItem = new DXSubMenuItem("Danh Sách Các Cột");
            columnsItem.Image = GridMenuImages.Column.Images[5];
            Items.Add(columnsItem);
            //MessageBox.Show(GridMenuImages.Column.Images.Count.ToString());
            Items.Add(CreateMenuItem("Tuỳ Chọn Cột", GridMenuImages.Column.Images[4], "Customization", true));
            Items.Add(CreateMenuItem("Co Giãn Cột", GridMenuImages.Column.Images[6], "BestFit", true));
            // Items.Add(CreateMenuItem("Bộ Lọc", GridMenuImages.Column.Images[7], "Filter", true, true));
            //Items.Add(CreateMenuCheckItem("Chọn Hết",false, null, "SelectAll", true, true));
            //Items.Add(CreateMenuItem("Bỏ Chọn", null, "UnSelectAll", true, false));

            foreach (GridColumn column in View.Columns)
            {
                if (column.OptionsColumn.ShowInCustomizationForm)
                    columnsItem.Items.Add(CreateMenuCheckItem(column.GetTextCaption(), column.VisibleIndex >= 0, null, column, true));
            }
        }
        protected override void OnMenuItemClick(object sender, EventArgs e)
        {
            if (RaiseClickEvent(sender, null)) return;
            DXMenuItem item = sender as DXMenuItem;
            if (item.Tag == null) return;
            if (item.Tag is GridColumn)
            {
                GridColumn column = item.Tag as GridColumn;
                column.VisibleIndex = column.VisibleIndex >= 0 ? -1 : View.VisibleColumns.Count;
            }
            else if (item.Tag.ToString() == "Customization")
            {
                View.ColumnsCustomization();
            }
            else if (item.Tag.ToString() == "BestFit")
            {
                View.BestFitColumns();
            }
            else if (item.Tag.ToString() == "Filter")
            {
                
            }
            else if (item.Tag.ToString() == "SelectAll")
            {
                View.SelectAll();
            }
            else if (item.Tag.ToString() == "UnSelectAll")
            {
                View.ClearSelection();
            }
        }
    }
    [Designer("Bar")]
    public class MenuButton
    {
        public bool PHome { get; set; }
        public bool GCommand { get; set; }
        private ItemCommand _add;
        private ItemCommand _change;
        private ItemCommand _save;
        private ItemCommand _saveAndNew;
        private ItemCommand _saveAndClose;
        private ItemCommand _cancel;
        private ItemCommand _delete;
        private ItemCommand _refresh;
        private ItemCommand _undo;

        [DisplayName("Add")]
        [Category("Bar")]
        public ItemCommand Add
        {
            get { return _add; }
            set { _add = value; }
        }

        [DisplayName("Change")]
        [Category("Bar")]
        public ItemCommand Change
        {
            get { return _change; }
            set { _change = value; }
        }

        
        public ItemCommand Save
        {
            get { return _save; }
            set { _save = value; }
        }

        
        public ItemCommand SaveAndNew
        {
            get { return _saveAndNew; }
            set { _saveAndNew = value; }
        }

        
        public ItemCommand SaveAndClose
        {
            get { return _saveAndClose; }
            set { _saveAndClose = value; }
        }

        
        public ItemCommand Cancel
        {
            get { return _cancel; }
            set { _cancel = value; }
        }

        
        public ItemCommand Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        
        public ItemCommand Refresh
        {
            get { return _refresh; }
            set { _refresh = value; }
        }

        
        public ItemCommand Undo
        {
            get { return _undo; }
            set { _undo = value; }
        }

        private ItemCommand _redo;
        public ItemCommand Redo
        {
            get { return _redo; }
            set { _redo = value; }
        }

        public bool GRecords { get; set; }
        private ItemCommand _previous;
        public ItemCommand Previous
        {
            get { return _previous; }
            set { _previous = value; }
        }

        private ItemCommand _next;
        public ItemCommand Next
        {
            get { return _next; }
            set { _next = value; }
        }

        private ItemCommand _find;
        public ItemCommand Find
        {
            get { return _find; }
            set { _find = value; }
        }

        private ItemCommand _view;
        public ItemCommand View
        {
            get { return _view; }
            set { _view = value; }
        }

        public bool GVaildation { get; set; }
        private ItemCommand _vaildate;
        public ItemCommand Vaildate
        {
            get { return _vaildate; }
            set { _vaildate = value; }
        }

        private ItemCommand _search;
        public ItemCommand Search
        {
            get { return _search; }
            set { _search = value; }
        }

        private ItemCommand _filter;
        public ItemCommand Filter
        {
            get { return _filter; }
            set { _filter = value; }
        }

        private ItemCommand _searchText;
        public ItemCommand SearchText
        {
            get { return _searchText; }
            set { _searchText = value; }
        }

        public bool GSearchBar { get; set; }
        private ItemCommand _filterStock;
        public ItemCommand FilterStock
        {
            get { return _filterStock; }
            set { _filterStock = value; }
        }

        private ItemCommand _filterCustomer;
        public ItemCommand FilterCustomer
        {
            get { return _filterCustomer; }
            set { _filterCustomer = value; }
        }

        private ItemCommand _go;
        public ItemCommand Go
        {
            get { return _go; }
            set { _go = value; }
        }

        public bool GClose { get; set; }
        private ItemCommand _close;
        public ItemCommand Close
        {
            get { return _close; }
            set { _close = value; }
        }

        public bool PTool { get; set; }
        public bool GPrint { get; set; }
        private ItemCommand _pageSetup;
        public ItemCommand PageSetup
        {
            get { return _pageSetup; }
            set { _pageSetup = value; }
        }

        private ItemCommand _print;
        public ItemCommand Print
        {
            get { return _print; }
            set { _print = value; }
        }

        private ItemCommand _printPreview;
        public ItemCommand PrintPreview
        {
            get { return _printPreview; }
            set { _printPreview = value; }
        }

        public bool GExport { get; set; }
        private ItemCommand _export;
        public ItemCommand Export
        {
            get { return _export; }
            set { _export = value; }
        }

        private ItemCommand _import;
        public ItemCommand Import
        {
            get { return _import; }
            set { _import = value; }
        }

        public bool GOption { get; set; }
        private ItemCommand _custom;
        public ItemCommand Custom
        {
            get { return _custom; }
            set { _custom = value; }
        }

        public bool GSettings { get; set; }
        private ItemCommand _task;
        public ItemCommand Task
        {
            get { return _task; }
            set { _task = value; }
        }

        public MenuButton()
        {
            _task = new ItemCommand();
            _custom = new ItemCommand();
            _import = new ItemCommand();
            _export = new ItemCommand();
            _printPreview = new ItemCommand();
            _print = new ItemCommand();
            _pageSetup = new ItemCommand();
            _close = new ItemCommand();
            _go = new ItemCommand();
            _filterCustomer = new ItemCommand();
            _filterStock = new ItemCommand();
            _searchText = new ItemCommand();
            _filter = new ItemCommand();
            _search = new ItemCommand();
            _vaildate = new ItemCommand();
            _view = new ItemCommand();
            _find = new ItemCommand();
            _next = new ItemCommand();
            _previous = new ItemCommand();
            _redo = new ItemCommand();
            _undo = new ItemCommand();
            _refresh = new ItemCommand();
            _delete = new ItemCommand();
            _cancel = new ItemCommand();
            _saveAndClose = new ItemCommand();
            _saveAndNew = new ItemCommand();
            _save = new ItemCommand();
            _change = new ItemCommand();
            _add = new ItemCommand();
        }

       
    }

    public class ItemCommand
    {
        private string m_caption="";
        private bool m_enable=false;
        private BarItemVisibility m_visibility=BarItemVisibility.Never;

        public BarItemVisibility Visibility
        {
            get { return m_visibility; }
            set { m_visibility = value; }
        }

        public string Caption
        {
            get { return m_caption; }
            set { m_caption = value; }
        }

        public bool Enable
        {
            get { return m_enable; }
            set { m_enable = value; }
        }
    }

    public enum EnumCommand
    {
        Added,
        Changed,
        Deleted,
        Cancel,
        Undo,
        Redo,
        Save,
        SaveAndNew,
        SaveAndClose,
        Find,
        Search,
        Go,
        Back,
        Next,
        History,
        ShowDetail,
        Refresh,
        Show,
        Validate,
        Filter,
        SearchText,
        Close,
        PageSetup,
        Print,
        Preview,
        Report,
        Design,
        Import,
        Export,
        Custom,
        Task
    }

    public class SaveChangedEventArgs:EventArgs
    {
        private bool m_notsave;

        public bool NotSave
        {
            get { return m_notsave; }
        }
    }

    public class RibbonChangedEventArgs:EventArgs
    {
        private MenuButton m_ribbon;

        public RibbonChangedEventArgs(MenuButton mRibbon)
        {
            m_ribbon = mRibbon;
        }

        public MenuButton Ribbon
        {
            get { return m_ribbon; }
        }
    }

    public class SaveChangingEventArgs:EventArgs
    {
        private string m_caption;
        private int m_percent;

        public string Status
        {
            get { return m_caption; }
        }

        public int Percent
        {
            get { return m_percent; }
        }
    }
    public class SaveCompleteEventArgs:EventArgs
    {
        
    }
}
