using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Utils.System2;
using Perfect.Dictionary;


namespace Perfect.Common
{
    public partial class xucCarAdd : xucBaseAdd
    {
        public xucCarAdd()
        {
            InitializeComponent();
            SetInterface();
            

            //DataTable dt = CONTROL_FORMAT.Load(Name);
           // CONTROL_FORMAT.ContainerChangeLanguage(gcInfo,ref dt);           

        }

        public delegate void SuccessEventHander(object sender, CAR Item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(CAR Item)
        {
            if (Success != null) Success(this, Item);
        }

        protected override void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
           // txtExchange.Text = "";
            //Thứ tự
        }

        public void SetData(CAR item)
        {
            txtID.Text = item.ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            
            txtNAME.Text = item.CarNumber;
            txtOwner.Text = item.Owner;
            txtPhone.Text = item.Phone;
            txtCarSize.Text = item.CarSize;
            txtCarVolume.Value =Convert.ToInt32(item.CarVolume);
            txtSchedule.Text = item.Schedule;
            txtNotes.Text = item.Notes;

        }

        protected override string uc_Save()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiCAR") != "OK") return "";
            //if (!MyRule.AllowAdd)
            //{
            //    MyRule.Notify();
            //    return "";
            //}

            ////CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            CAR cls = new CAR(
                txtID.Text, 
                txtNAME.Text.Trim(),
                txtOwner.Text.Trim(),
                txtPhone.Text.Trim(),
                txtCarSize.Text.Trim(),
                Convert.ToInt32(txtCarVolume.Value),
                txtSchedule.Text.Trim(),
                txtNotes.Text.Trim());

            Result = cls.Insert();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return Result;
            }
            Cursor.Current = Cursors.Default;
            DoHide();
            return Result;

        }

        protected override string uc_Update()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiCAR") != "OK") return "";
            //if (!MyRule.AllowEdit)
            //{
            //    MyRule.Notify();
            //    return "";
            //}

            ////CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            CAR cls = new CAR(txtID.Text,
                txtNAME.Text.Trim(),
                txtOwner.Text.Trim(),
                txtPhone.Text.Trim(),
                txtCarSize.Text.Trim(),
                Convert.ToInt32(txtCarVolume.Value),
                txtSchedule.Text.Trim(),
                txtNotes.Text.Trim());
            Result = cls.Update();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return Result;
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
            CAR cls = new CAR();
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
                CAR CAR = new CAR();
                if (m_Status == Actions.Add)
                {
                    if (CAR.Exist(txt.Text))
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
                CAR CAR = new CAR();
                if (CAR.Exist(txt.Text))
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
            txtOwner.Text= ""; 
            txtPhone.Text= ""; 
            txtCarSize.Text= ""; 
            txtCarVolume.Value = 0;
            txtSchedule.Text = "";
            txtNotes.Text = ""; 
        }

        private void lblExchange_Click(object sender, EventArgs e)
        {

        }

        private void chxUse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtExchange_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void popupContainerEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
