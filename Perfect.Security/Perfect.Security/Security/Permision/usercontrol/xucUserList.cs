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
    public partial class xucUserList : xucBase
    {
        public xucUserList()
        {
            InitializeComponent();
        }

        public void SetData(string ID)
        {
            SYS_USER SYS_USER = new SYS_USER();
            gcList.DataSource = SYS_USER.GetList(ID);
            List_Init(gbList);           
        }

        protected void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "UserID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Tên đăng nhập";
                        dt.Columns[i].Width = 90;
                        break;
                    case "UserName":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Họ và tên";
                        dt.Columns[i].Width = 180;
                        break;
                    case "Description":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Caption = "Nhóm";
                        dt.Columns[i].Width = 180;
                        break;

                    case "Active":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = "Kích hoạt";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }
    }
}
