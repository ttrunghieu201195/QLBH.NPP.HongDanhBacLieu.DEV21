using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Utils.App;
using Perfect.Utils.Lib;
using Perfect.Utils.Net;
using Perfect.Utils.Security2;

namespace Perfect.Net.Info.Forms
{
    public partial class XfmCompany : XtraForm
    {
        #region Contructor

        private const string SNhapTen = "Xin quý khách vui lòng nhập thông tin họ tên.";
        private const string SDiaChi = "Xin quý khách vui lòng nhập thông tin địa chỉ.";
        private const string SDienThoai = "Xin quý khách vui lòng nhập thông tin điện thoại.";
        private const string SEmail = "Xin quý khách vui lòng nhập thông tin email.";
        private const string SContent = "Xin quý khách vui lòng nhập nội dung phản hồi.";
        private const string SSuccessful = "Cập nhật thành công.\n\nCảm ơn quý khách đã sử dụng phần mềm của chúng tôi.";

        private readonly int _action;
        private bool _exit;

        public XfmCompany()
        {
            InitializeComponent();
            txtGene.SelectedIndex = 1;

            if (MyInfo.Get(MyEncryption.Encrypt("ERP01", "123654", true)) == "OK")
            {
                txtCompany.Text = CODE.CompanyName;
                txtAddress.Text = CODE.Address;
            }
            else
            {
                txtCompany.Text = MyInfo.Company;
                txtAddress.Text = MyInfo.Address;
            }

            txtCompany.Properties.ReadOnly = true;
            txtAddress.Properties.ReadOnly = true;
            txtPhoneNumber.Text = MyInfo.Tel;
            txtFaxNumber.Text = MyInfo.Fax;
            txtWebsite.Text = MyInfo.WebSite;
            txtEmail.Text = MyInfo.Email;
            txtTaxNumber.Text = MyInfo.Tax;
            txtLicenceNumber.Text = MyInfo.Licence;
            picLogo.Image = MyInfo.Photo;

            lciBranch.Visibility = LayoutVisibility.Never;
            Size = new Size(512, 380);

            if (MyInfo.GetSysOption("Negative") == "OK")
            {
                chkNegative.Checked = Convert.ToBoolean(MyInfo.OptionValue);
            }
           
        }

        public XfmCompany(bool exit, int action, string connection)
        {
            _exit = exit;
            _action = action;
            InitializeComponent();
            txtGene.SelectedIndex = 1;
            btnCancel.Enabled = false;


            lciContact.Visibility = LayoutVisibility.Always;
            lciMemo.Visibility = LayoutVisibility.Always;
            lciContactGene.Visibility = LayoutVisibility.Always;
            btnSend.Text = @"Cập Nhật";
            Size = new Size(520, 567);
            if (_action == 2)
            {
                _exit = false;
                btnCancel.Enabled = true;
            }
        }

        public XfmCompany(bool exit, int action)
        {
            _exit = exit;
            _action = action;
            InitializeComponent();
            txtGene.SelectedIndex = 1;
            btnCancel.Enabled = false;

            if (MyInfo.Get(MyEncryption.Encrypt("ERP01", "123654", true)) == "OK")
            {
                txtCompany.Text = CODE.CompanyName;
                txtAddress.Text = CODE.Address;
            }
            else
            {
                txtCompany.Text = MyInfo.Company;
                txtAddress.Text = MyInfo.Address;
            }
            txtCompany.Properties.ReadOnly = true;
            txtAddress.Properties.ReadOnly = true;
            
            //txtCompany.Properties.ReadOnly = txtCompany.Text == "" ? false : true;
            //txtAddress.Properties.ReadOnly = txtAddress.Text == "" ? false : true;
            txtPhoneNumber.Text = MyInfo.Tel;
            txtFaxNumber.Text = MyInfo.Fax;
            txtWebsite.Text = MyInfo.WebSite;
            txtEmail.Text = MyInfo.Email;
            txtTaxNumber.Text = MyInfo.Tax;
            txtLicenceNumber.Text = MyInfo.Licence;
            picLogo.Image = MyInfo.Photo;

            lciContact.Visibility = LayoutVisibility.Always;
            lciMemo.Visibility = LayoutVisibility.Always;
            lciContactGene.Visibility = LayoutVisibility.Always;
            btnSend.Text = @"Cập Nhật";
            Size = new Size(520, 567);
            if (_action == 2)
            {
                _exit = false;
                btnCancel.Enabled = true;
            }
        }

        private void Notify(string message)
        {
            XtraMessageBox.Show(this, message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Infomation(string message)
        {
            XtraMessageBox.Show(this, message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Event

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
             

            if (txtCompany.Text == string.Empty)
            {
                Notify("Xin quý khách vui lòng nhập thông tin công ty.");
                txtCompany.ErrorText = "Not empty";
                Err.SetIconAlignment(txtCompany, ErrorIconAlignment.MiddleRight);
                txtCompany.Focus();
                return;
            }

            if (_action == 1 | _action == 2)
            {
                if (txtAddress.Text == "")
                {
                    Notify(SDiaChi);
                    txtAddress.Focus();
                    return;
                }
                if (txtPhoneNumber.Text == "")
                {
                    Notify(SDienThoai);
                    txtPhoneNumber.Focus();
                    return;
                }
                if ((txtEmail.Text == "") | (MyLib.IsValidEmailAddress(txtEmail.Text) == false))
                {
                    Notify(SEmail);
                    txtEmail.Focus();
                    return;
                }
                if (cbxIndustry.Text.Trim() == "")
                {
                    Notify("Xin quý khách vui lòng nhập thông tin ngành nghề kinh doanh.");
                    cbxIndustry.Focus();
                    return;
                }

                if (txtContact.Text == "")
                {
                    Notify(SNhapTen);
                    txtContact.Focus();
                    return;
                }

                if (mmeContent.Text == "")
                {
                    Notify(SContent);
                    mmeContent.Focus();
                    return;
                }
            }

            UpdateSysOption();


            var mysql = new SqlHelper();
            if (mysql.Start() != "OK")
            {
                XtraMessageBox.Show(this, "Lỗi:\n\t" + mysql.Result, "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                return;
            }

            if (!MyInfo.Delete(mysql.Transaction, MyEncryption.Encrypt("ERP01", "123654", true)))
            {
                XtraMessageBox.Show(this, "Lỗi:\n\t" + mysql.Result, "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                mysql.RollBack();
                return;
            }

            byte[] vImage;
            if (picLogo.Image != null)
            {
                var ms = new MemoryStream();
                picLogo.Image.Save(ms, picLogo.Image.RawFormat);
                vImage = ms.GetBuffer();
                ms.Close();
            }
            else
            {
                vImage = new byte[2];
            }

            bool ketqua =

            MyInfo.Insert(mysql.Transaction,
                        MyEncryption.Encrypt("ERP01", "123654", true),
                        MyEncryption.Encrypt(txtCompany.Text, "123654", true),
                        txtAddress.Text,
                        txtPhoneNumber.Text,
                        txtFaxNumber.Text,
                        txtWebsite.Text.Trim(),
                        txtEmail.Text,
                        txtTaxNumber.Text,
                        txtLicenceNumber.Text,
                        vImage);

            if (!ketqua)
            {
                XtraMessageBox.Show(this, "Lỗi:\n\t" + mysql.Result, "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                mysql.RollBack();
                return;
            }

            Options.SetWaitDialogCaption("Đang lưu thông tin công ty...");
            Options.Show();
            Options.HideDialog();

            if (mysql.Commit() != "OK")
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thông tin. Vui lòng thử lại!", "Lỗi");
                return;
            }
            //}
            MyInfo.Get(MyEncryption.Encrypt("ERP01", "123654", true));
            try
            {
                var newThread = new System.Threading.Thread(() =>
                    Perfect.Service.Class.CUSTOMER_SOFT.Insert(txtCompany.Text,
                        txtAddress.Text,
                        txtPhoneNumber.Text,
                        txtPhoneNumber.Text,
                        txtFaxNumber.Text,
                        txtWebsite.Text,
                        txtEmail.Text,
                        txtTaxNumber.Text,
                        txtLicenceNumber.Text,
                        Convert.ToBoolean(txtGene.SelectedIndex),
                        txtContact.Text,
                        mmeContent.Text,
                        MyAssembly.AssemblyProduct,
                        MyAssembly.AssemblyVersion));
                newThread.Start();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_action == 1 | _action == 2)
            {
                btnSend.Enabled = false;

                string subject = MyAssembly.AssemblyTitle.Replace("Phần Mềm", "") + ", Khách hàng " + txtContact.Text +
                                 ", " + txtEmail.Text;
                const string xuongDong = "<br/>";
                string content = "\tThông Tin Khách Hàng" + xuongDong;
                content += "|**************************************************************************" + xuongDong;
                content += "|\tFrom: " + MyAssembly.AssemblyTitle + xuongDong;
                content += "|\tHọ tên:     " + txtContact.Text + xuongDong;
                if (txtCompany.Text.Trim().Length > 0)
                content += "|\tCông ty:    " + txtCompany.Text + xuongDong;
                content += "|\tĐịa chỉ:    " + txtAddress.Text + xuongDong;
                content += "|\tĐiện thoại: " + txtPhoneNumber.Text + xuongDong;
                content += "|\tEmail:      " + txtEmail.Text + xuongDong;
                content += "|**************************************************************************" + xuongDong +
                           xuongDong;
                content += "\tNội dung:" + xuongDong + xuongDong;
                content += mmeContent.Text;

                var smail = new SendMail();
                bool webmaster = smail.Send2(txtEmail.Text, txtContact.Text, "webmaster@perfect.com.vn", "119900293", subject, content,
                                 MyAssembly.AssemblyTitle);
                if (webmaster)
                {
                    Infomation(SSuccessful);
                    Close();
                }
                btnSend.Enabled = false;
            }

            if (_action == 0)
            {
                XtraMessageBox.Show("Dữ liệu đã được lưu!", "Hoàn Tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                Close();
            }
            if (!_exit) return;

            _exit = false;
            Close();
        }


        private void XfmCompanyFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _exit;
        }

        #endregion

        private void txtTaxNumber_EditValueChanged(object sender, EventArgs e)
        {
            txtLicenceNumber.Text = txtTaxNumber.Text;
        }

        private void chkNegative_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNegative_Leave(object sender, EventArgs e)
        {

        }

        private void chkNegative_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateSysOption()
        {
            var mysql = new SqlHelper();
            if (mysql.Start() != "OK")
            {
                XtraMessageBox.Show(this, "Lỗi:\n\t" + mysql.Result, "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                return;
            }
            bool ketqua =

            MyInfo.UpdateSysOption(
                        mysql.Transaction,
                        "Negative",
                        chkNegative.Checked
                        );

            if (!ketqua)
            {
                Options.HideDialog();
                XtraMessageBox.Show(this, "Lỗi:\n\t" + mysql.Result, "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                mysql.RollBack();
                return;
            }

            Options.SetWaitDialogCaption("Đang lưu thông tin ...");
            Options.Show();
            Options.HideDialog();

            if (mysql.Commit() != "OK")
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thông tin. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}