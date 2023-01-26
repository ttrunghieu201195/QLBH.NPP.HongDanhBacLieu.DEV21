using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Utils.System2;
using DevExpress.XtraGrid.Views.Base;

namespace Perfect.Common
{

    public partial class xucBaseList : xucBase
    {
        BaseView exportView;

        string _Title = "";

        public string Title
        {
            set { _Title = value; }
        }

        public xucBaseList()
        {
            InitializeComponent();
            Init();
        }

        public event ButtonClickEventHander ExportClick;
        public event ButtonClickEventHander AddClick;
        public event ButtonClickEventHander EditClick;
        public event ButtonClickEventHander ChangeClick;
        public event ButtonClickEventHander RefreshClick;
        public event ButtonClickEventHander PrintClick;
        public event ButtonClickEventHander CloseClick;
        public event RowClickEventHander RowClick;
        public event RowClickEventHander RowDoubleClick;
        public event ListKeyDownEventHander ListKeyDown;

        private void RaiseAddClickEventHander()
        {
            if (AddClick != null)
            {
                AddClick(this);
            }
        }

        private void RaiseEditClickEventHander()
        {
            if (EditClick != null)
            {
                EditClick(this);
            }
        }

        private void RaiseChangeClickEventHander()
        {
            if (ChangeClick != null)
            {
                ChangeClick(this);
            }
        }

        private void RaiseRefreshClickEventHander()
        {
            if (RefreshClick != null)
            {
                RefreshClick(this);
            }
        }

        private void RaisePrintClickEventHander()
        {
            if (PrintClick != null)
            {
                PrintClick(this);
            }
        }

        private void RaiseCloseClickEventHander()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }

        private void RaiseListKeyDownEventHander(KeyEventArgs key, RowClickEventArgs e)
        {
            if (ListKeyDown != null)
            {
                ListKeyDown(this, key, e);
            }
        }

        private void RaiseRowClickEventHander(RowClickEventArgs e)
        {
            if (RowClick != null)
            {
                RowClick(this, e);
            }
        }

        private void RaiseRowDoubleClickEventHander(RowClickEventArgs e)
        {
            if (RowDoubleClick != null)
            {
                RowDoubleClick(this, e);
            }
        }

        private void RaiseExportClickEventHander()
        {
            if (ExportClick != null)
            {
                ExportClick(this);
            }
        }

        protected virtual void Init()
        {
            ReLoad();
        }

        protected virtual void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            MessageBox.Show("asd");
        }

        protected virtual void AddRow(object Item)
        {

            MessageBox.Show("asd");

        }

        protected virtual void UpdateRow(object Item, RowClickEventArgs e)
        {
            MessageBox.Show("asd");
        }

        //protected virtual void RemoveRow(RowClickEventArgs e)
        //{
        //    DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
        //    //view.UpdateCurrentRow(); 
        //    int[] temp = view.GetSelectedRows();

        //    for (int i = temp.Length - 1; i >= 0; i--)
        //    {
        //        MessageBox.Show(GetCellValue(temp[i], 0).ToString());
        //        //view.DeleteRow();// DeleteRow(temp[i]);
        //    }

        //    if (e.RowIndex > gbList.RowCount)
        //    {
        //        VnMessageBox.Error("Vui lòng chọn dữ liệu cần xoá", "Xoá Khách hàng");
        //        return;
        //    }
        //    gbList.DeleteRow(e.RowIndex);
        //}

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
            //if (Result == null | e.RowIndex > gbList.RowCount) VnMessageBox.Error("Không thể lấy thông tin.", "Thông báo");
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

        public virtual void ReLoad()
        {

        }

        protected virtual void gbList_Click(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
            {
                DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
                RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                this.RaiseRowClickEventHander(ex);
            }
            else
            {
                VnMessageBox.Error("Lưới đang sử đụng không đúng.");
            }
        }

        protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
            {
                DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
                RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                this.RaiseRowDoubleClickEventHander(ex);
            }
            else
            {
                VnMessageBox.Error("Lưới đang sử đụng không đúng.");
            }
        }

        protected virtual void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
            {
                DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
                RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                this.RaiseRowClickEventHander(ex);
                RaiseListKeyDownEventHander(e, ex);
                if (e.KeyCode == Keys.Delete)
                {
                    Delete();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    gbList_DoubleClick(gbList, e);
                }
            }
            else
            {
                VnMessageBox.Error("Lưới đang sử đụng không đúng.");
            }
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            this.RaiseAddClickEventHander();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            this.RaiseEditClickEventHander();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            this.RaisePrintClickEventHander();
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            this.RaiseRefreshClickEventHander();
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {

        }

        protected virtual void Delete()
        {
            
        }
       
    }
}

