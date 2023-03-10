using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Data.Helper;
using Perfect.Dictionary.CustomerGroup;
using Perfect.Dictionary.Provider.DS.dsPROVIDERTableAdapters;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Dictionary
{
    public partial class xucProviderQuickAdd : xucBaseXAdd
    {
        public xucProviderQuickAdd()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            SetSize();
        }

        void SetSize()
        {
            if (ParentForm != null)
            {
                this.Dock = DockStyle.Fill;
                ParentForm.Size = new Size(Width + 130, Height);
            }
        }


        private bool Simple = true;

        public delegate void SuccessEventHander(object sender, PROVIDER Item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(PROVIDER Item)
        {
            if (Success != null) Success(this, Item);
        }

        public void Init()
        {
            Text = SysOption.Language == "VN" ? "Nhà Cung Cấp" : "Provider";
            SetWaitDialogCaption("Đang nạp danh sách khách hàng...");

            var adapter = new PROVIDERALLTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            SetValue(adapter.GetData());
            SetWaitDialogCaption("Đang nạp danh sách khu vực...");

            cUSTOMER_GROUPTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMER_GROUPTableAdapter.Fill(dsCustomerArea.CUSTOMER_GROUP);

            //txtGroup.EditValue = "MD";
            
            DoHide();
            txtID.Focus();
        }

        public void SetData(string ID)
        {
            txtID.Text=ID;
            txtNAME.Focus();
        }


        public void SetData(PROVIDER item)
        {
            txtID.Text = item.Customer_ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.CustomerName;
            txtArea.EditValue = item.Customer_Group_ID;
           // txtBarcode.Text = item.Barcode;
            txtCONTACT.Text = item.Contact;
            txtEmail.Text = item.Email;
            txtFAX.Text = item.Fax;
            txtMobile.Text = item.Mobile;
            txtPosition.Text = item.Position;
            txtTAX.Text = item.Tax;
            txtTEL.Text = item.Tel;
            txtWebsite.Text = item.Website;
            txtAddress.Text = item.CustomerAddress;
            // txtDescription.Text = item.Description;
            txtBankNumber.Text = item.BankAccount;
            txtBankName.Text = item.BankName;
            chxUse.Checked = item.Active;
            txtCreditLimit.Value = Convert.ToDecimal(item.CreditLimit);
            txtDiscount.Value = Convert.ToDecimal(item.Discount);
            //rpType.SelectedIndex = (int)Microsoft.VisualBasic.Conversion.Val(item.Customer_Type_ID);
            SysLog.Insert("Quản Lý Nhà Phân Phối", "Xem", txtID.Text);
        }

		protected override bool Check()
        {
            if (string.IsNullOrEmpty(txtArea.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn khu vực.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Focus();
                return false;
            }
            return base.Check();
        }
		
        protected override string uc_Save()
        {
            if (!MyRule.IsAdd("bbiProvider")) return "";

            SysLog.Insert("Quản Lý Nhà Phân Phối", "Thêm", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            var cls = new PROVIDER(txtID.Text,
                                   0,
                                   txtNAME.Text,
                                   "0",
                                   txtArea.EditValue.ToString(),
                                   txtAddress.Text,
                                   "",
                                   txtID.Text,
                                   txtTAX.Text,
                                   txtTEL.Text,
                                   txtFAX.Text
                                   , txtEmail.Text,
                                   txtMobile.Text,
                                   txtWebsite.Text,
                                   txtCONTACT.Text,
                                   txtPosition.Text,
                                   "",
                                   "",
                                   "",
                                   "",
                                   "",
                                   "",
                                   txtBankNumber.Text,
                                   txtBankName.Text,
                                   Convert.ToDouble(txtCreditLimit.Value),
                                   Convert.ToDouble(txtDiscount.Value),
                                   "",
                                   chxUse.Checked);
            Result = cls.Insert();
            if (Result == "OK") RaiseSuccessEventHander(cls);

            Cursor.Current = Cursors.Default;
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return Result;
            }
            DoHide();
            return Result;

        }

        protected override string uc_Update()
        {
            if (!MyRule.IsEdit("bbiProvider")) return "";
            
            SysLog.Insert("Quản Lý Nhà Phân Phối", "Cập Nhật", txtID.Text);


            //CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            var cls = new PROVIDER(txtID.Text,
                                   0,
                                   txtNAME.Text,
                                   "0",
                                   txtArea.EditValue.ToString(),
                                   txtAddress.Text,
                                   "",
                                   txtID.Text,
                                   txtTAX.Text,
                                   txtTEL.Text,
                                   txtFAX.Text,
                                   txtEmail.Text,
                                   txtMobile.Text,
                                   txtWebsite.Text,
                                   txtCONTACT.Text,
                                   txtPosition.Text,
                                   "",
                                   "",
                                   "",
                                   "",
                                   "",
                                   "",
                                   txtBankNumber.Text,
                                   txtBankName.Text,
                                   Convert.ToDouble(txtCreditLimit.Value),
                                   Convert.ToDouble(txtDiscount.Value),
                                   "",
                                   chxUse.Checked);
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
            PROVIDER cls = new PROVIDER();
            cls.Customer_ID = txtID.Text;
            Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return Result;
            }
            return Result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                PROVIDER PROVIDER = new PROVIDER();
                if (m_Status == Actions.Add)
                {
                    if (PROVIDER.Exist(txt.Text))
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
                PROVIDER PROVIDER = new PROVIDER();
                if (PROVIDER.Exist(txt.Text))
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
            //txtDescription.Text = "";
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
        }

        public override void Add()
        {
            PROVIDER customer = new PROVIDER();
            txtID.Text = customer.NewID();
            txtID.Properties.ReadOnly = false;
            txtNAME.Focus();
        }

        public void Add(PROVIDER item)
        {
            m_Status = Actions.Add;
            txtID.Text = item.Customer_ID;
            if (item.Exist(item.Customer_ID) | item.Customer_ID == "")
            {
                txtID.Text = item.NewID();
            }
            txtNAME.Text = item.CustomerName;
            txtCONTACT.Text = item.Contact;

            txtEmail.Text = item.Email;
            txtFAX.Text = item.Fax;
            txtMobile.Text = item.Mobile;
            txtPosition.Text = item.Position;
            txtTAX.Text = item.Tax;
            txtTEL.Text = item.Tel;
            txtWebsite.Text = item.Website;
            txtAddress.Text = item.CustomerAddress;
            // txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
        }

        

       

        

        
        

        

       

        
        

        private void txtBankNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtBankName.Focus();
            }
            
        }

        

        private void txtCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtDiscount.Focus();
            }
            
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtCONTACT.Focus();
            }
            
        }

        private void txtCONTACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtPosition.Focus();
            }
            
        }

        private void txtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnSaveNew.Focus();
            }
            
        }

       



        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtArea.Focus();
            }
        }

        private void txtGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtNAME.Focus();
            }
        }

        private void txtNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtAddress.Focus();
            }

        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtTAX.Focus();
            }

        }

        private void txtTAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtFAX.Focus();
            }

        }

        private void txtFAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtTEL.Focus();
            }

        }

        private void txtTEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtMobile.Focus();
            }

        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtEmail.Focus();
            }
        }

        private void btnSaveNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                uc_Save();
            }

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtWebsite.Focus();
            }
        }

        private void txtWebsite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtBankNumber.Focus();
            }
        }

        private void txtBankName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtCreditLimit.Focus();
            }
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                uc_Save();
            }
        }

        private void txtArea_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ((string)e.Button.Tag == "Add")
            {
                var customerGroupAdd = new XfmCustomerGroupAdd(Actions.Add);
                customerGroupAdd.Added += customerGroupAdd_Added;
                customerGroupAdd.ShowDialog();
            }
        }

        void customerGroupAdd_Added(object sender, CUSTOMER_GROUP item)
        {
            cUSTOMER_GROUPTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMER_GROUPTableAdapter.Fill(dsCustomerArea.CUSTOMER_GROUP);
            txtArea.EditValue = item.Customer_Group_ID;
        }

        

        

        

      
    }
}
