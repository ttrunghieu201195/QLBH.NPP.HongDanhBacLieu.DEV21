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
    public partial class xucNotesAdd : Perfect.Common.xucBaseAdd
    {
        public xucNotesAdd()
        {
            InitializeComponent();
           // SetInterface();
           // DataTable dt = CONTROL_FORMAT.Load(Name);
           // CONTROL_FORMAT.ContainerChangeLanguage(gcInfo, ref dt);
            
        }

        public override void Add()
        {
            m_Status = Actions.Add;
            txtID.Text = SqlHelper.GenCode("NOTES", "ID", "GC");
            txtID.Properties.ReadOnly = false;
        }

        public delegate void SuccessEventHander(object sender, NOTES Item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(NOTES Item)
        {
            if (Success != null) Success(this, Item);
        }

        protected override void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
            //Thứ tự
        }

        public void SetData(NOTES item)
        {
            txtID.Text = item.ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.Name;
            txtDescription.Color = Color.FromName(item.Description);
            chxUse.Checked = item.Active; 
        }

        protected override string uc_Save()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return "";
            //if (!MyRule.AllowAdd)
            //{
            //    MyRule.Notify();
            //    return "";
            //}

            //SysLog.Insert("Quản Lý Đơn Vị Tính", "Thêm", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            NOTES cls = new NOTES(txtID.Text, txtNAME.Text, txtDescription.Color.Name.ToString(), chxUse.Checked);
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
            //if (MyRule.Get(MyLogin.RoleId, "bbiUnit") != "OK") return "";
            //if (!MyRule.AllowEdit)
            //{
            //    MyRule.Notify();
            //    return "";
            //}

            //SysLog.Insert("Quản Lý Đơn Vị Tính", "Cập Nhật", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            NOTES cls = new NOTES(txtID.Text, txtNAME.Text, txtDescription.Color.Name.ToString(), chxUse.Checked);
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
            NOTES cls = new NOTES();
            cls.ID = txtID.Text;
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
                NOTES UNIT = new NOTES();
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
                NOTES UNIT = new NOTES();
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

        private void txtDescription_EditValueChanged(object sender, EventArgs e)
        {
            //this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.Red;
            //this.txtDescription.Properties.Appearance.Options.UseBackColor = true0
            //Color color = ColorTranslator.FromHtml(txtDescription.Color.ToString());
            txtDescription.BackColor = txtDescription.Color;
        }

        //private void btnColor_Click(object sender, EventArgs e)
        //{
        //    ColorDialog colorDlg = new ColorDialog();
        //    if (colorDlg.ShowDialog() == DialogResult.OK)
        //    { 
        //        Color color = ColorTranslator.ToHtml(colorDlg.Color.C);
        //        txtDescription.BackColor = ColorTranslator.FromHtml(color);
        //    }
        //}
    }
}

