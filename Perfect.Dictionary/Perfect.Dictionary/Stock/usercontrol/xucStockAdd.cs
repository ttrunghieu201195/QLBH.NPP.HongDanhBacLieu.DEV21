using System;
using System.Windows.Forms;
using Perfect.Common;
using Perfect.ERP;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary
{
    public partial class xucStockAdd : xucBaseAdd
    {
        public xucStockAdd()
        {
            InitializeComponent();
            EmplInit();
        }

        private void EmplInit()
        {
            eMPLOYEETableAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            eMPLOYEETableAdapter.Fill(dsEMPLOYEE.EMPLOYEE);
        }

        public delegate void SuccessEventHander(object sender, STOCK item);

        public event SuccessEventHander Success;

        private void RaiseSuccessEventHander(STOCK item)
        {
            if (Success != null) Success(this, item);
        }

        protected override void Init()
        {
            
            //Loại khách hàng
            //Nhóm khách hàng
            //Thứ tự
        }

        public void SetData(STOCK item)
        {
            txtID.Text = item.Stock_ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.Stock_Name;
            txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
            txtAddress.Text = item.Address;
            txtCONTACT.Text = item.Contact;
            txtEmail.Text = item.Email;
            txtFAX.Text = item.Fax;
            txtTEL.Text = item.Telephone;
            txtMobile.Text = item.Mobi;
            txtManager.EditValue = item.Manager;

            SysLog.Insert("Quản Lý Danh Mục Kho", "Xem",txtID.Text);
        }

        protected override string uc_Save()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return "";
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Danh Mục Kho", "Thêm", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            var Result = string.Empty;
            var cls = new STOCK(txtID.Text, txtNAME.Text,txtCONTACT.Text,txtAddress.Text,txtEmail.Text,txtTEL.Text,txtFAX.Text,txtMobile.Text,(txtManager.EditValue??"") as string,txtDescription.Text,chxUse.Checked);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiStock") != "OK") return "";
            if (!MyRule.AllowEdit)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Danh Mục Kho", "Cập Nhật", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            STOCK cls = new STOCK(txtID.Text, txtNAME.Text, txtCONTACT.Text, txtAddress.Text, txtEmail.Text, txtTEL.Text, txtFAX.Text, txtMobile.Text, (txtManager.EditValue??"") as string, txtDescription.Text, chxUse.Checked);
            Result = cls.Update();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            DoHide();
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var Result = string.Empty;
            var cls = new STOCK();
            cls.Stock_ID = txtID.Text;
            Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            return Result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                var stock = new STOCK();
                if (m_Status == Actions.Add)
                {
                    if (stock.Exist(txt.Text))
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
                var stock = new STOCK();
                if (stock.Exist(txt.Text))
                {
                    Err.SetError(txt, "Mã đã tồn tại.");
                    txt.Focus();
                }
            }

        }

        #endregion

        public new void Clear()
        {
            txtID.Text = "";
            txtNAME.Text = "";
            txtDescription.Text = "";
        }

        public override void Add()
        {
            base.Add();
            var cls=new STOCK();
            txtID.Text = cls.NewID();
            txtNAME.Focus();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtNAME.Focus();
            }
        }

        private void txtNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtCONTACT.Focus();
            }
            
        }

        private void txtCONTACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtAddress.Focus();
            }
            
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtTEL.Focus();
            }
            
        }

        private void txtTEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtMobile.Focus();
            }
            
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtFAX.Focus();
            }
            
        }

        private void txtFAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtEmail.Focus();
            }
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtManager.Focus();
            }
            
        }

        private void txtManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                txtDescription.Focus();
            }
            
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                btnSaveNew.Focus();
            }
            
        }

        private void btnSaveNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            uc_Save();
        }
    }
}

