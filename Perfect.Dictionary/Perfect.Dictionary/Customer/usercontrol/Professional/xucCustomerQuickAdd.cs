using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Data.Helper;
using Perfect.Dictionary.Common.DS;
using Perfect.Dictionary.Customer.DS;
using Perfect.Dictionary.Customer.usercontrol.DataSet;
using Perfect.Dictionary.Customer.usercontrol.DataSet.dsCUSTOMERSTableAdapters;
using Perfect.Dictionary.CustomerGroup;
using Perfect.Utils.System2;
using Perfect.Utils.Lib;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Dictionary
{
    public partial class xucCustomerQuickAdd : xucBaseXAdd
    {
        public xucCustomerQuickAdd()
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
                ParentForm.Size = new Size(Width+130, Height + 30);
            }
        }

        private bool Simple = true;

        public delegate void SuccessEventHander(object sender, CUSTOMER Item);        

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(CUSTOMER Item)
        {
            if (Success != null) Success(this, Item);
        }

        private void Init()
        {
            SetWaitDialogCaption("Đang nạp danh sách khách hàng...");
            var adapter = new CUSTOMERTableAdapter
                              {
                                  Connection = {ConnectionString = Data.Helper.SqlHelper.ConnectString}
                              };
            base.SetValue(adapter.GetData());
            SetWaitDialogCaption("Đang nạp danh sách khu vực...");

            eMPLOYEETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            eMPLOYEETableAdapter.Fill(dsEMPLOYEE.EMPLOYEE);

            cUSTOMER_GROUPTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMER_GROUPTableAdapter.Fill(dsCustomerArea.CUSTOMER_GROUP);

            rOUTETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            rOUTETableAdapter.Fill(dsCustomerArea.ROUTE);

            //txtGroup.EditValue = "MD";
            DoHide();
        }       

        

        public void SetData(string ID)
        {
            txtID.Text=ID;
            txtNAME.Focus();
            txtCreditLimit.Value = 0;
            txtDiscount.Value = 0;
        }


        public void SetData(CUSTOMER item)
        {
            txtID.Text = item.Customer_ID;

            SysLog.Insert("Quản Lý Khách Hàng", "Xem", txtID.Text);

            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.CustomerName;                               
            txtCONTACT.Text= item.Contact;

            txtArea.EditValue = item.Customer_Group_ID;
            txtEmail.Text= item.Email;
            txtFAX.Text= item.Fax;
            txtMobile.Text= item.Mobile;           
            txtNickSky.Text = item.NickSky;

            txtRoute.EditValue = item.NickYM;

            txtTAX.Text=item.Tax;
            txtTEL.Text= item.Tel;
            txtWebsite.Text= item.Website;
            txtAddress.Text = item.CustomerAddress;
            txtBanhkNumber.Text = item.BankAccount;
            txtBankName.Text = item.BankName;
            txtCreditLimit.Value = Convert.ToDecimal(item.CreditLimit);
            txtDiscount.Value = Convert.ToDecimal(item.Discount);
            chkIsDebt.Checked = Convert.ToBoolean(item.IsDebt);
            txtDescription.Text = item.Description;
            rpType.SelectedIndex =(int) Microsoft.VisualBasic.Conversion.Val(item.Customer_Type_ID);

            txtEmployee.EditValue = item.Area;
            txtDebtDate.SelectedIndex = Convert.ToInt32(item.OrderID);

            chxUse.Checked = item.Active;
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
            SysLog.Insert("Quản Lý Khách Hàng", "Thêm", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            var cls = new CUSTOMER(txtID.Text, txtDebtDate.SelectedIndex, txtNAME.Text, rpType.SelectedIndex.ToString(),
                                        txtArea.EditValue.ToString(), txtAddress.Text, "", txtID.Text, txtTAX.Text,
                                        txtTEL.Text, txtFAX.Text, txtEmail.Text, txtMobile.Text, txtWebsite.Text,
                                        txtCONTACT.Text, "", (txtRoute.EditValue ?? "").ToString(), txtNickSky.Text,
                                        (txtEmployee.EditValue ?? "").ToString(), txtDebtDate.Text, "", "",
                                        txtBanhkNumber.Text, txtBankName.Text, Convert.ToDouble(txtCreditLimit.Value),
                                        Convert.ToDouble(txtDiscount.Value),chkIsDebt.Checked, txtDescription.Text.Trim(), chxUse.Checked);
            Result = cls.Insert();
            if (Result == "OK") RaiseSuccessEventHander(cls);

            Cursor.Current = Cursors.Default;
            if (Result != "OK")
            {
                XtraMessageBox.Show(Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return Result;
            }
            DoHide();
            return Result;

        }

        protected override string uc_Update()
        {
            SysLog.Insert("Quản Lý Khách Hàng", "Cập Nhật", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            CUSTOMER cls = new CUSTOMER(txtID.Text, txtDebtDate.SelectedIndex, txtNAME.Text, rpType.SelectedIndex.ToString(),
                                        txtArea.EditValue.ToString(), txtAddress.Text, "", txtID.Text, txtTAX.Text,
                                        txtTEL.Text, txtFAX.Text, txtEmail.Text, txtMobile.Text, txtWebsite.Text,
                                        txtCONTACT.Text, "", (txtRoute.EditValue ?? "").ToString(), txtNickSky.Text,
                                        (txtEmployee.EditValue ?? "").ToString(), txtDebtDate.Text,  "", "",
                                        txtBanhkNumber.Text, txtBankName.Text, Convert.ToDouble(txtCreditLimit.Value),
                                        Convert.ToDouble(txtDiscount.Value),chkIsDebt.Checked, txtDescription.Text.Trim(), chxUse.Checked);
            Result = cls.Update();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            if (Result != "OK")
            {
                XtraMessageBox.Show(Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            CUSTOMER cls = new CUSTOMER();
            cls.Customer_ID = txtID.Text;
            Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            if (Result != "OK")
            {
                XtraMessageBox.Show(Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                CUSTOMER CUSTOMER = new CUSTOMER();
                if (m_Status == Actions.Add)
                {
                    if (CUSTOMER.Exist(txt.Text))
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
                CUSTOMER CUSTOMER = new CUSTOMER();
                if (CUSTOMER.Exist(txt.Text))
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

        public override void Add()
        {
            CUSTOMER customer=new CUSTOMER();
            txtID.Text = customer.NewID();
            txtID.Properties.ReadOnly = false;
            m_Status = Actions.Add;
            txtNAME.Focus();
        }

        public void Add(CUSTOMER item)
        {
            m_Status = Actions.Add;
            txtID.Text = item.Customer_ID;
            if (item.Exist(item.Customer_ID) | item.Customer_ID =="")
            {
                txtID.Text = item.NewID();
            }
            txtNAME.Text = item.CustomerName;
            txtCONTACT.Text = item.Contact;
            chkIsDebt.Checked = true;

            txtEmail.Text = item.Email;
            txtFAX.Text = item.Fax;
            txtMobile.Text = item.Mobile;
            txtNickSky.Text = item.Position;
            txtTAX.Text = item.Tax;
            txtTEL.Text = item.Tel;
            txtWebsite.Text = item.Website;
            txtAddress.Text = item.CustomerAddress;
            txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
        }

        private void gcInfo_Paint(object sender, PaintEventArgs e)
        {

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
                this.txtBanhkNumber.Focus();
            }
        }

        private void txtBanhkNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtBankName.Focus();
            }
        }

        private void txtBankName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtCreditLimit.Focus();
            }
        }

        private void txtCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDiscount.Focus();
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
            }
        }

        private void txtNickYM_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtNickSky.Focus();
            }
        }

        private void txtNickSky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnSaveNew.Focus();
            }
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                uc_Save();
               
            }
        }

        private void btnHistory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnSaveNew.Focus();
                //
            }
        }

        private void txtArea_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if((string) e.Button.Tag == "Add")
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
