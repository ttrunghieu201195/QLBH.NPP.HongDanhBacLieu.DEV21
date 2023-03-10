using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Utils.Lib;
using System.Drawing;

namespace Perfect.Security
{
    public partial class xucUserAdd : xucBaseAdd
    {
        public xucUserAdd()
        {
            InitializeComponent();
            Init();
            Emp_Init();
        }

        public delegate void SuccessEventHander(object sender, SYS_USER Item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(SYS_USER Item)
        {
            if (Success != null) Success(this, Item);
        }

        private void Emp_Init()
        {
            sYS_USER_GetEmpListTableAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            sYS_USER_GetEmpListTableAdapter.Fill(dsEmpList.SYS_USER_GetEmpList);
        }

        protected void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
            SYS_GROUPAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            SYS_GROUPAdapter.Fill(dsGroup.SYS_GROUP);
            cbxGroup.EditValue = "admin";
            
        }

        public void SetData(SYS_USER item)
        {
            SysLog.Insert("Quản Lý Người Dùng", "Xem", item.UserID);

            txtID.Text = item.UserID;
            if (m_Status == Actions.Update)
            {
                txtID.Properties.ReadOnly = true;
                txtNAME.Properties.ReadOnly = true;
                if (MyLogin.AccountName == "admin")
                {
                    txtEmp.Properties.ReadOnly = false;
                }
                else
                {
                    txtEmp.Properties.ReadOnly = true;
                }
            }
            txtNAME.Text = item.UserName;
            txtDescription.Text = item.Description;
            txtPassword.Text = "<Ẩn>";
            txtRepassword.Text = "<Ẩn>";
            cbxGroup.EditValue = item.Group_ID;
            txtEmp.EditValue = item.PartID;
            chxUse.Checked = item.Active;
        }

        protected override string uc_Save()
        {


            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return "";
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return "";
            }
           
            SysLog.Insert("Quản Lý Người Dùng", "Thêm",txtID.Text );

            CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            var cls = new SYS_USER();

            
            
            cls = new SYS_USER(
                    cls.NewID(), 
                    txtNAME.Text, 
                    txtPassword.Text, 
                    cbxGroup.EditValue.ToString(),
                     txtEmp.Text, 
                    txtEmp.EditValue.ToString(), 
                    chxUse.Checked);

            Result = cls.Insert();
            if (Result == "OK") RaiseSuccessEventHander(cls);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiPermission") != "OK") return "";
            if (!MyRule.AllowEdit)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Người Dùng", "Cập Nhật", txtID.Text);

            CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;

            var cls = new SYS_USER(
                            txtID.Text, 
                            txtNAME.Text, 
                            txtPassword.Text, 
                            cbxGroup.EditValue.ToString(), 
                            txtEmp.Text,
                            txtEmp.EditValue.ToString(),
                            chxUse.Checked);
            if (txtPassword.Text == "<Ẩn>")
            {
                Result = cls.UpdateNopass();
            }
            else
            {
                Result = cls.Update();
            }
            
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
            var cls = new SYS_USER();
            cls.UserID = txtID.Text;
            Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            return Result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            //TextEdit txt = (TextEdit)sender;
            //if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            //{
            //    SYS_USER SYS_USER = new SYS_USER();
            //    if (m_Status == Actions.Add)
            //    {
            //        if (SYS_USER.Exist(txt.Text))
            //        {
            //            Err.SetError(txt, "Mã đã tồn tại.");
            //            txt.Focus();
            //        }

            //    }
            //}
        }

        protected override void txtID_EditValueChanged(object sender, EventArgs e)
        {
            //TextEdit txt = (TextEdit)sender;
            //if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            //if (m_Status == Actions.Add)
            //{
            //    SYS_USER SYS_USER = new SYS_USER();
            //    if (SYS_USER.Exist(txt.Text))
            //    {
            //        Err.SetError(txt, "Mã đã tồn tại.");
            //        txt.Focus();
            //    }
            //}

        }

        #endregion

        public void Clear()
        {
            txtID.Text = "";
            txtNAME.Text = "";
            txtDescription.Text = "";
            txtPassword.Text = "";
            txtRepassword.Text = "";
        }
        

        protected override bool Check()
        {
            if (string.IsNullOrEmpty(txtEmp.Text) || txtEmp.EditValue == null)
            {
                XtraMessageBox.Show("Lỗi:\n\tNhân viên chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxGroup.EditValue == null)
            {
                XtraMessageBox.Show("Lỗi:\n\tNhóm người dùng chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.Compare(txtPassword.Text,txtRepassword.Text)!=0)
            {
                XtraMessageBox.Show("Lỗi:\n\tXác nhận mật khẩu chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRepassword.Focus();
                return false;
            }


            return true;
        }

        private void txtNAME_EditValueChanged(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;

            if (m_Status == Actions.None) return;

            if (m_Status == Actions.Add)
            {
                txtID.Text = MyLib.RejectMarks(txtNAME.Text);
            }

            if (txt.ErrorText != string.Empty)
            {
                Err.SetError(txt, string.Empty);
            }
            

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "<Ẩn>")
            {
                txtPassword.Text = "";
                txtRepassword.Text = "";
            }
        }

        private void txtRepassword_Click(object sender, EventArgs e)
        {
            if (txtRepassword.Text == "<Ẩn>")
            {
                txtRepassword.Text = "";
            }
        }

        private void cbxGroup_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag != null)
                if (e.Button.Tag.ToString()=="Add")
                {
                    var xfmGroupAdd=new XfmGroupAdd(Actions.Add);
                    xfmGroupAdd.Added += xfmGroupAdd_Added;
                    xfmGroupAdd.ShowDialog(this.ParentForm);
                }
        }

        void xfmGroupAdd_Added(object sender, SYS_GROUP Item)
        {
            dsGroup.SYS_GROUP.AddSYS_GROUPRow(Item.Group_ID, Item.Group_Name, Item.Group_NameEn, Item.Description,
                                              Item.Active);
            cbxGroup.EditValue = Item.Group_ID;
        }

        private void txtEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxGroup.EditValue != null)
            {
                txtDescription.Text = txtEmp.Text;
            }
            else
            {
                XtraMessageBox.Show("Thông Báo", "Chưa chọn Nhân viên.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxGroup.Properties.Appearance.BackColor = Color.Red;
                cbxGroup.Focus();
                return;
            }
            
            
        }
    }
}
