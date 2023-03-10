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
    public partial class xucGroupAdd : xucBaseAdd
    {
        public xucGroupAdd()
        {
            InitializeComponent();
        }
        public delegate void SuccessEventHander(object sender, SYS_GROUP Item);
        public event SuccessEventHander Success;
        public void RaiseSuccessEventHander(SYS_GROUP Item)
        {
            if (Success != null) Success(this, Item);
        }
        protected void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng          
            //Thứ tự
        }

        public void SetData(SYS_GROUP item)
        {
            //txtID.Text = item.Group_ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
          //  txtNAME.Text = item.Group_Name;
            txtDescription.Text = item.Description;           
            chxUse.Checked = item.Active;
           // SYS_LOG.Insert("Vai Trò Người Dùng", "Xem",item.Group_ID);
        }
        public string m_Group_Id;
        public string m_Group_Name;
        protected override string uc_Save()
        {
            if (!MyRule.IsAdd("bbiPermission")) return "";

            SysLog.Insert("Vai Trò Người Dùng", "Thêm", txtID.Text);

            CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            SYS_GROUP cls = new SYS_GROUP(txtID.Text, txtNAME.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            Result = cls.Insert();
            if (Result == "OK")
            {
                RaiseSuccessEventHander(cls);
                m_Group_Id = txtID.Text ;
                m_Group_Name = txtNAME.Text  ;
            }
            else
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return "";

            }
            Cursor.Current = Cursors.Default;
            DoHide();
            return Result;

        }

        protected override string uc_Update()
        {
            if (MyRule.IsEdit("bbiPermission")) return "";

            SysLog.Insert("Vai Trò Người Dùng", "Cập Nhật", txtID.Text);

            CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            SYS_GROUP cls = new SYS_GROUP(txtID.Text, txtNAME.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            Result = cls.Update();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            else
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return "";

            }
            DoHide();
            return Result;
        }

        protected override string uc_Change()
        {
            string Result = string.Empty;
            return Result;
        }

        protected override string uc_Delete()
        {
            string Result = string.Empty;
            SYS_GROUP cls = new SYS_GROUP();
           // cls.Group_ID = txtID.Text;
           // Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            return Result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                SYS_GROUP SYS_GROUP = new SYS_GROUP();
                if (m_Status == Actions.Add)
                {
                   // if (SYS_GROUP.Exist(txt.Text))
                    {
                        Err.SetError(txt, "ID is exist.");
                        txt.Focus();
                    }

                }
            }
        }

        protected override void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (m_Status == Actions.Add)
            {
                SYS_GROUP SYS_GROUP = new SYS_GROUP();
               // if (SYS_GROUP.Exist(txt.Text))
                {
                    Err.SetError(txt, "ID is exist.");
                    txt.Focus();
                }
            }

        }

        #endregion

        public void Clear()
        {
            txtID.Text = "";
            txtNAME.Text = "";
            txtDescription.Text = "";           
        }        
    }
}
