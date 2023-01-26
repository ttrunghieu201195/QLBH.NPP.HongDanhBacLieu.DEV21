using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;

namespace Perfect.Dictionary
{
    public partial class xucProductBrandAdd : xucBaseAdd
    {
        public xucProductBrandAdd()
        {
            InitializeComponent();
        }

        public delegate void SuccessEventHander(object sender, PRODUCT_BRAND item);

        public event SuccessEventHander Success;

        private void RaiseSuccessEventHander(PRODUCT_BRAND item)
        {
            if (Success != null) Success(this, item);
        }

        public override void Add()
        {
            m_Status = Actions.Add;
            txtID.Properties.ReadOnly = false;
            txtID.Text = SqlHelper.GenCode("PRODUCT_BRAND", "ID", "TH");
        }

        protected override void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
            //Thứ tự
        }

        public void SetData(PRODUCT_BRAND item)
        {
            txtID.Text = item.ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.Name;
            txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
        }

        protected override string uc_Save()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            var Result = string.Empty;
            var cls = new PRODUCT_BRAND(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            Result = cls.Insert();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            Cursor.Current = Cursors.Default;
            DoHide();
            return Result;

        }

        protected override string uc_Update()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            var result = string.Empty;
            var cls = new PRODUCT_BRAND(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            result = cls.Update();
            if (result == "OK") RaiseSuccessEventHander(cls);
            DoHide();
            return result;
        }

        protected override string uc_Change()
        {
            string result = string.Empty;
            return result;
        }

        protected override string uc_Delete()
        {
            var result = string.Empty;
            var cls = new PRODUCT_BRAND {ID = txtID.Text};
            result = cls.Delete();
            if (result == "OK") RaiseSuccessEventHander(cls);
            return result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                var customerGroup = new PRODUCT_BRAND();
                if (m_Status == Actions.Add)
                {
                    if (customerGroup.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
                        txt.Focus();
                    }

                }
            }
        }

        protected override void txtID_EditValueChanged(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (m_Status == Actions.Add)
            {
                var customerGroup = new PRODUCT_BRAND();
                if (customerGroup.Exist(txt.Text))
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNAME.Focus();
            }
        }

        private void txtNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                chxUse.Focus();
            }
        }

        private void chxUse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSaveNew.Focus();
            }
        }

        private void btnSaveNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                uc_Save();

            }
        }

        
       

    }
}
