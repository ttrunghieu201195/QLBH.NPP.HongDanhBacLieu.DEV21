using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Utils.App;


namespace Perfect.Net.Info
{
    public partial class xfmAboutContact : DevExpress.XtraEditors.XtraForm
    {
        public xfmAboutContact()
        {
            InitializeComponent();
            Description.Text =CODE.Contact;
            //lblAddress.Text =  CODE.Company;
            lblCompany.Text = CODE.CompanyName;
            lblAddress.Text =CODE.Address;
            lblTrial.Text =CODE.SoftInfo;


            lblProduct.Text = MyAssembly.AssemblyTitle;
            lblVersion.Text = "Phiên bản: " + MyAssembly.AssemblyVersion;
        }

        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:sales@perfect.com.vn");
        }

        private void lblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.perfect.com.vn");
        }
    }
}