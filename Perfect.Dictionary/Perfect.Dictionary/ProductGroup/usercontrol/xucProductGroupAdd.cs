using System;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary.ProductGroup.usercontrol
{
    public partial class XucProductGroupAdd : xucBaseAdd
    {
        public XucProductGroupAdd()
        {
            InitializeComponent();
            //SetInterface();
          //  DataTable dt = CONTROL_FORMAT.Load(Name);
           // CONTROL_FORMAT.ContainerChangeLanguage(gcInfo, ref dt);            
            
        }

        public delegate void SuccessEventHander(object sender, PRODUCT_GROUP item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(PRODUCT_GROUP item)
        {
            if (Success != null) Success(this, item);
        }

        protected override void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
            //Thứ tự
        }

        public void SetData(PRODUCT_GROUP item)
        {
            txtID.Text = item.ProductGroup_ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.ProductGroup_Name;
            txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
            SysLog.Insert("Quản Lý Nhóm Hàng Hoá", "Xem",txtID.Text);
        }

        protected override string uc_Save()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return "";
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Nhóm Hàng Hoá", "Thêm", txtID.Text);
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            var cls = new PRODUCT_GROUP(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            string result = cls.Insert();
            if (result == "OK") RaiseSuccessEventHander(cls);
            Cursor.Current = Cursors.Default;
            DoHide();
            if (result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;

        }

        protected override string uc_Update()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiItemGroup") != "OK") return "";
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Nhóm Hàng Hoá", "Cập Nhật", txtID.Text);
                      
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            var cls = new PRODUCT_GROUP(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            string result = cls.Update();
            if (result == "OK") RaiseSuccessEventHander(cls);
            DoHide();
            if (result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        protected override string uc_Change()
        {
            string result = string.Empty;
            return result;
        }

        protected override string uc_Delete()
        {
            var cls = new PRODUCT_GROUP {ProductGroup_ID = txtID.Text};
            string result = cls.Delete();
            if (result == "OK") RaiseSuccessEventHander(cls);
            return result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                var productGroup = new PRODUCT_GROUP();
                if (m_Status == Actions.Add)
                {
                    if (productGroup.Exist(txt.Text))
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
                var productGroup = new PRODUCT_GROUP();
                if (productGroup.Exist(txt.Text))
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


        public override void Add()
        {
            base.Add();
            var productGroup=new PRODUCT_GROUP();
            txtID.Text = productGroup.NewID();
            txtNAME.Focus();
        }

        private void TxtIDKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtNAME.Focus();
            }
        }

        private void TxtNameKeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == (char) Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void TxtDescriptionKeyPress(object sender, KeyPressEventArgs e)
        {
            
                    if (e.KeyChar == (char) Keys.Enter)
            {
                chxUse.Focus();
            }
        }

        private void ChxUseKeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void BtnSaveNewKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                uc_Save();
            }
        }

    }
}

