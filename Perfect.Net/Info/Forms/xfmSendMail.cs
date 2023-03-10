using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Utils.App;
using Perfect.Utils.Lib;
using Perfect.Utils.Net;

namespace Perfect.Net.Info.Forms
{
    public partial class XfmSendMail : XtraForm
    {
        public delegate void SuccessEventHander(object sender, Service.Class.CUSTOMER item);

        public event SuccessEventHander Success;

        private void RaiseSuccessEventHandler(Service.Class.CUSTOMER item)
        {
            if (Success != null) Success(this, item);
        }

        #region Contructor

        private string sNhapTen = "Xin quý khách vui lòng nhập thông tin họ tên.";
        private string sDiaChi = "Xin quý khách vui lòng nhập thông tin địa chỉ.";
        private string sDienThoai = "Xin quý khách vui lòng nhập thông tin điện thoại.";
        private string sEmail = "Xin quý khách vui lòng nhập thông tin email.";
        private string sContent = "Xin quý khách vui lòng nhập nội dung phản hồi.";
        private string sSubject = "Xin quý khách vui lòng nhập tiêu để của yêu cầu.";
        private string sSuccessful = "Cập nhật thành công.\n\nCảm ơn quý khách đã sử dụng phần mềm của chúng tôi.";
        private string sFail = "Cập nhất thất bại";

        private bool _exit = false;
        private int _action = 0;

        private void Notify(string message)
        {
            XtraMessageBox.Show(this, message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Infomation(string message)
        {
            XtraMessageBox.Show(this, message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public XfmSendMail()
        {
            InitializeComponent();
        }

        #endregion

        #region Event

        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    if (keyData == Keys.Escape)
        //    {
        //        Close();
        //        return true;
        //    }
        //    else if (keyData == Keys.F2)
        //    {
        //        btnOK_Click(this, EventArgs.Empty);
        //    }
        //    else if (keyData == Keys.Control | keyData == Keys.S)
        //    {
        //        btnOK_Click(this, EventArgs.Empty);
        //    }
        //    return false;
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text == string.Empty)
            {
                Notify("Xin quý khách vui lòng nhập thông tin công ty.");
                txtCompany.ErrorText = "Not empty";
                Err.SetIconAlignment(txtCompany, ErrorIconAlignment.MiddleRight);
                txtCompany.Focus();
                return;
            }

            if (txtAddress.Text == "")
            {
                Notify(sDiaChi);
                txtAddress.Focus();
                return;
            }

            if (txtPhoneNumber.Text == "")
            {
                Notify(sDienThoai);
                txtPhoneNumber.Focus();
                return;
            }

            if ((txtEmail.Text == "") | (MyLib.IsValidEmailAddress(txtEmail.Text) == false))
            {
                Notify(sEmail);
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
                Notify(sNhapTen);
                txtContact.Focus();
                return;
            }

            if (mmeContent.Text == "")
            {
                Notify(sContent);
                mmeContent.Focus();
                return;
            }

            btnSend.Enabled = false;

            var cus = new Service.Class.CUSTOMER(7, txtCompany.Text, txtAddress.Text, txtPhoneNumber.Text, "",
                                                 txtFaxNumber.Text, txtWebsite.Text, txtEmail.Text, "", "",
                                                 txtContact.Text, mmeContent.Text);
            RaiseSuccessEventHandler(cus);

            string subject = MyAssembly.AssemblyTitle.Replace("Phần Mềm", "") + ", Khách hàng " + txtContact.Text + ", " +
                             txtEmail.Text + ", " + mmeContent.Text;
            //subject = SendMail.Encryption(subject);
            string xuongDong = "<br/>"; //  "\n"  "&#13;"
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
            //content = "Á À Ả Ã Ạ Â Ấ Ầ Ẩ Ẫ Ậ Ă Ắ Ằ Ẳ Ẵ Ặ É È Ẻ Ẽ Ẹ Ê Ế Ề Ể Ễ Ệ Ó Ò Ỏ Õ Ọ Ô Ố Ồ Ổ Ỗ Ộ Ơ Ớ Ờ Ở Ỡ Ợ Ú Ù Ủ Ũ Ụ Ư Ứ Ừ Ử Ữ Ự Í Ì Ỉ Ĩ Ị Ý Ỳ Ỷ Ỹ Ỵ";
            //content = "à á ả ã ạ ă ắ ằ ẳ ẵ ặ â ấ ầ ẩ ẫ ậ è é ẻ ẽ ẹ ê ế ề ể ễ ệ ò ó ỏ õ ọ ô ố ồ ổ ỗ ộ ơ ớ ờ ở ỡ ợ ì í ỉ ĩ ị ỳ ý ỷ ỹ ỵ ù ú ủ ũ ụ ư ứ ừ ử ữ ự đ Đ";
            //content = SendMail.Encryption(content);

            var smail = new SendMail();
            //thongBao(smail.getEmail());
            if (
                (smail.Send2(txtEmail.Text, txtContact.Text, "support@perfect.com.vn", "Support", subject, content,
                             MyAssembly.AssemblyTitle)))
            {
                Infomation(sSuccessful);
                Close();
            }
            //else
            //    Notify(sFail);
            btnSend.Enabled = true;


            if (_exit)
            {
                _exit = false;
                Close();
            }
        }

        private void TxtCompanyEditValueChanged(object sender, EventArgs e)
        {
            if (txtCompany.ErrorText != "") txtCompany.ErrorText = "";
        }


        private void XfmCompanyFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _exit;
        }

        #endregion
    }
}