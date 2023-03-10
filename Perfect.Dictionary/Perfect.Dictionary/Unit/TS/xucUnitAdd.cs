using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Utils.System2;
using Perfect.Data.Helper;

namespace Perfect.Dictionary
{
    public partial class xucUnitAdd : Perfect.Common.xucBaseAdd
    {
        public xucUnitAdd()
        {
            InitializeComponent();
           // SetInterface();
           // DataTable dt = CONTROL_FORMAT.Load(Name);
           // CONTROL_FORMAT.ContainerChangeLanguage(gcInfo, ref dt);
            
        }

        public override void Add()
        {
            m_Status = Actions.Add;
            txtID.Text = SqlHelper.GenCode("UNIT", "Unit_ID", "DV");
            txtID.Properties.ReadOnly = false;
        }

        public delegate void SuccessEventHander(object sender, UNIT Item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(UNIT Item)
        {
            if (Success != null) Success(this, Item);
        }

        protected override void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
            //Thứ tự
        }

        public void SetData(UNIT item)
        {
            txtID.Text = item.Unit_ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.Unit_Name;
            txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
            SysLog.Insert("Quản Lý Đơn Vị Tính", "Xem", txtID.Text);
        }

        protected override string uc_Save()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return "";
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Đơn Vị Tính", "Thêm", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            UNIT cls = new UNIT(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            Result = cls.Insert();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            Cursor.Current = Cursors.Default;
            DoHide();
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;

        }

        protected override string uc_Update()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return "";
            if (!MyRule.AllowEdit)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Đơn Vị Tính", "Cập Nhật", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            UNIT cls = new UNIT(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            Result = cls.Update();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            DoHide();
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            UNIT cls = new UNIT();
            cls.Unit_ID = txtID.Text;
            Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            return Result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                UNIT UNIT = new UNIT();
                if (m_Status == Actions.Add)
                {
                    if (UNIT.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
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
                UNIT UNIT = new UNIT();
                if (UNIT.Exist(txt.Text))
                {
                    Err.SetError(txt, "Mã đã tồn tại.");
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

