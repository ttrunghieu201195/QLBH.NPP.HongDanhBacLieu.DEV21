using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Security.Security.Login
{
    
    public partial class xfmIsAdmin : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdmin = false;

        public xfmIsAdmin()
        {
            InitializeComponent();
            isAdmin = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string restult = MyLogin.CheckAccount(txtUserID.Text, txtPassword.Text);
            if (restult == "OK")
            {
                XtraMessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!\nVui lòng kiểm tra lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdmin = true;
            Close();
        }
    }
}