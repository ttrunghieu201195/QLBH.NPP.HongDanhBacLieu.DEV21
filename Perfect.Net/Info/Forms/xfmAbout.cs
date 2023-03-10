using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Utils.App;


namespace Perfect.Net.Info
{
    public partial class xfmAbout : XtraForm
    {
        public xfmAbout()
        {
            InitializeComponent();
            Description.Text = CODE.Contact;
            lblCompany.Text = CODE.CompanyName;
            lblAddress.Text = CODE.Address;
            lblTrial.Text = CODE.SoftInfo;
            lblProduct.Text = MyAssembly.AssemblyTitle;
            lblVersion.Text = "Phiên bản: " + MyAssembly.AssemblyVersion;
            lblSoftName.Text = MyAssembly.AssemblyDescription;
        }

        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("mailto:sales@perfect.com.vn");   
            }
            catch (Win32Exception)
            {
                XtraMessageBox.Show("Máy tính chưa cài đặt chương trình quản lý email.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void lblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://www.perfect.com.vn");
            }
            catch (Win32Exception)
            {
                XtraMessageBox.Show("Máy tính chưa cài đặt trình duyệt web.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xfmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}