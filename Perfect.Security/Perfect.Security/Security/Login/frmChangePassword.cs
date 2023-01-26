using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.ERP
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
            SysLog.Insert("Thay Đổi Mật Khẩu", "Xem");
            Text = (SysOption.Language == "VN" ? Text : "Change password");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        int solanDangNhap = 0;
        private void btLuu_Click(object sender, EventArgs e)
        {
            // solanDangNhap++;
            //MyLogin clsDN = new MyLogin();
            SysLog.Insert("Thay Đổi Mật Khẩu", "Cập Nhật", MyLogin.UserId);

            string pw = MyLogin.CreatePassword(MyLogin.Account, txtMatKhauCu.Text);

            var clsUser = new SYS_USER();
            clsUser.GetUserName(MyLogin.Account);

            if (pw.CompareTo(clsUser.Password) != 0)
            {
                XtraMessageBox.Show("Bạn nhập mật khẩu hiện tại không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMatKhauCu.Text = "";
                txtMatKhauCu.Focus();                
                solanDangNhap++;
                if (solanDangNhap >= 3)
                {
                    XtraMessageBox.Show("Bạn đã nhập sai quá số lần cho phép!\n\nPhần mềm sẽ tự động tắt!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    Application.ExitThread();
                }
                return;
            }
            else
                if (txtMatKhauMoi.Text.CompareTo(txtLapLaiMatKhauMoi.Text) != 0)
                {
                    XtraMessageBox.Show("Mật khẩu nhập lại không giống nhau! Xin vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauMoi.Text = "";
                    txtLapLaiMatKhauMoi.Text = "";
                    txtMatKhauMoi.Focus();
                    solanDangNhap++;
                    if (solanDangNhap >= 3)
                    {
                        XtraMessageBox.Show("Bạn đã nhập sai quá số lần cho phép!\n\nPhần mềm sẽ tự động tắt!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        Environment.Exit(0);
                    }
                    return;
                }
                else
                {
                    ///pw = clsDN.CreatePassword(MyLogin.UserName, txtMatKhauMoi.Text);


                    if (clsUser.Update(clsUser.UserID, clsUser.UserName, txtLapLaiMatKhauMoi.Text,clsUser.Group_ID ,"","", true) == "OK")
                    {
                        XtraMessageBox.Show("Bạn đã thay đổi mật khẩu thành công!", "Hoàn Thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa thay đổi được mật khẩu mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtMatKhauMoi.Focus();
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtLapLaiMatKhauMoi.Focus();
        }

        private void txtLapLaiMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btLuu_Click(sender, e);
        }


        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    if (keyData == Keys.Escape)
        //    {
        //        Close();
        //        return true;
        //    }
        //    return false;
        //}



        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                
                case Keys.Escape :
                    if (ParentForm != null) ParentForm.Close();
                    return true;

                case Keys.F10:
                    if (ParentForm != null) ParentForm.Close();
                    return true;
            }
            return false;
        }

    }
}