using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Security
{
    public partial class xucGroupList : xucBase
    {
        public delegate void SendIDEventHander(object sender, string ID);
        
        public event SendIDEventHander SendID;

        private void RaiseSendIDEventHander(string ID)
        {
            if (SendID != null) SendID(this,ID);
        }

        public xucGroupList()
        {
            InitializeComponent();
            //ReLoad();
           // btnView.Text = SYS_OPTION.Language == "VN" ? btnView.Text : "Refresh";
        }

        protected object GetCellValue(RowClickEventArgs e)
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
            // if (Result == null | e.RowIndex > gbList.RowCount) XtraMessageBox.Show("Không thể lấy thông tin.", "Thông báo");
            return Result;
        }

        protected object GetCellValue(int RowIndex, int ColumIndex)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex));
            return Result;
        }

        protected object GetCellValue(int RowIndex, string FieldName)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName));
            return Result;
        }      

        public void ReLoad()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SYS_GROUP cls = new SYS_GROUP();
            gcList.DataSource = cls.GetList();
            SetWaitDialogCaption("Đang nạp cấu hình...");
            List_Init(gbList);
            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        private void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
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
                        if (SysOption.Language == "VN")
                        {
                            dt.Columns[i].Caption = "Mã";
                        }
                        else
                        {
                            dt.Columns[i].Caption = "Role_Id";
                        }
                                             
                        dt.Columns[i].Width = 90;
                        break;
                    case "Group_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN")
                        {
                            dt.Columns[i].Caption = "Vai trò";
                        }
                        else
                        {
                            dt.Columns[i].Caption = "Role_Name";
                        }
                        dt.Columns[i].Width = 180;
                        break;
                    //case "Description":
                    //    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    //    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    //    dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    //    dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    //    dt.Columns[i].OptionsColumn.FixedWidth = true;
                    //    dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    //    dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                    //    dt.Columns[i].Caption = "Nhóm";
                    //    dt.Columns[i].Width = 180;
                    //    break;

                    //case "Active":
                    //    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    //    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    //    dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    //    dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    //    dt.Columns[i].OptionsColumn.FixedWidth = true;
                    //    dt.Columns[i].Caption = "Kích hoạt";
                    //    dt.Columns[i].Width = 80;
                    //    break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        private void gbList_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            object Arg = GetCellValue(ex.RowIndex, "Group_ID");
            if (Arg != null)
            {
                RaiseSendIDEventHander(Arg.ToString());
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}
