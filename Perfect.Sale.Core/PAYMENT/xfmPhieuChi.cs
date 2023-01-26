using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Cash.Cash.Payment.Report;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Utils.Lib;
using Perfect.Sale.Core.PAYMENT.DS;
using System.Data;
using DevExpress.XtraReports.UI;

namespace Perfect.Sale.Core.PAYMENT
{
    public partial class XfmPhieuChi : XtraForm
    {
        private string _id = "";


        public XfmPhieuChi()
        {
            InitializeComponent();
            txtDate.DateTime = MyLogin.LoginDate;
        }

        private Guid _debtIDs;
        private Guid _purchaseIDs;
        private string _address;
        private string _stockInwardID;

        public void SetData(PROVIDER_PAYMENT payment)
        {
            string sql = "SELECT ppd.PaymentID, \n"
           + "       ppd.Amount, \n"
           + "       ppd.Debit, \n"
           + "       ppd.Payment, \n"
           + "       d.RefDate \n"
           + "FROM   PROVIDER_PAYMENT_DETAIL ppd \n"
           + "       LEFT OUTER JOIN DEBT d \n"
           + "            ON  ppd.RefOrgNo = d.ID \n"
           + "WHERE  ppd.PaymentID = @PaymentID";

            string[] myPara = { "@PaymentID" };
            object[] myValue = { payment.ID };

            SqlHelper mySql = new SqlHelper();
            DataTable dtPaymentDetail = new DataTable();

            mySql.CommandType = CommandType.Text;
            dtPaymentDetail = mySql.ExecuteDataTable(sql, myPara, myValue);

            if (dtPaymentDetail.Rows.Count == 0)
            {
                txtTotalAmount.EditValue = 0;
                txtPaid.EditValue = 0;
                txtDebt.EditValue = 0;
                txtPaying.EditValue = 0;
            }
            else
            {
                txtTotalAmount.EditValue = dtPaymentDetail.Rows[0]["Amount"];
                txtDebt.EditValue = dtPaymentDetail.Rows[0]["Debit"];
                txtPaying.EditValue = dtPaymentDetail.Rows[0]["Payment"];
                txtRefDate.EditValue = dtPaymentDetail.Rows[0]["RefDate"];
            
            }

            txtCustomerID.EditValue = payment.CustomerID;
            txtReason.Text = payment.Description;
            txtEmpID.EditValue = payment.OwnerID;
            txtPurchaseOrg.EditValue = payment.RefOrgNo;

            txtEmpID.Properties.ReadOnly = true;
            txtReason.Properties.ReadOnly = true;
            txtDate.Properties.ReadOnly = true;
            txtPaying.Properties.ReadOnly = true;

            btnSave.Visible = false;

        }


        public void SetData(string address, string customerID, string chungTu ,DateTime ngay, decimal soTien, decimal daTra, decimal conLai, Guid debtID, Guid purchaseID)
        {
            txtCustomerID.EditValue = customerID;
            txtPurchaseOrg.EditValue = chungTu;
            txtTotalAmount.Value = soTien;
            txtPaid.Value = daTra;
            txtDebt.Value = conLai;
            txtPaying.Value = conLai;
            txtRefDate.DateTime = ngay;
            
            _debtIDs = debtID;
            _purchaseIDs = purchaseID;
            _address = address;
            _stockInwardID = chungTu;
        }
        public void Add()
        {
            var cls = new PROVIDER_PAYMENT();
            txtID.Text = cls.NewID("PC_" + MyLogin.Account + "_");
            txtID.Properties.ReadOnly = true;
        }

        private void XfmPhieuChiLoad(object sender, EventArgs e)
        {
            Add();
            PhieuChiInit();
            EmpInit();
            ProviderInit();
        }
        private void PhieuChiInit()
        {
            phieuChiTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            phieuChiTableAdapter.Fill(dsPhieuChi.PhieuChi);
        }

        private void EmpInit()
        {
            eMPLOYEETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            eMPLOYEETableAdapter.Fill(dsPhieuChi.EMPLOYEE);
            if (dsPhieuChi.EMPLOYEE.Rows.Count > 0)
            {
                if (txtEmpID.Text == "") txtEmpID.EditValue = MyLogin.EmployeeID == "" ? Convert.ToString(dsPhieuChi.EMPLOYEE.Rows[0]["Employee_ID"]) : MyLogin.EmployeeID;
            }
        }

        private void ProviderInit()
        {
            pROVIDERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROVIDERTableAdapter.Fill(dsProvider.PROVIDER);
        }

        private void BtnCancleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtPayingEditValueChanged(object sender, EventArgs e)
        {
            if (txtPaying.Value > txtDebt.Value || txtPaying.Value < 0)
            {
                XtraMessageBox.Show("Giá trị nhập vào không hợp lệ. \n\n Vui lòng kiểm tra lại", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPaying.Value = 0;
                return;
            }
        }

        public delegate void SaveEvenhandler();

        public event SaveEvenhandler Success;

        private void InvokeSuccess()
        {
            SaveEvenhandler evenhandler = Success;
            if (evenhandler != null) evenhandler();
        }


        private void Save()
        {
            if(txtPaying.Value <= 0 )
            {
                XtraMessageBox.Show("Giá trị nhập vào không hợp lệ. \n\n Vui lòng kiểm tra lại.", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtEmpID.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chon Nhân viên. \n\n Vui lòng kiểm tra lại.", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }




            SysLog.Insert("Phiếu Chi", "Thêm", txtID.Text);
            var mySql = new SqlHelper();
            string result = mySql.Start();
            if (result != "OK")
            {
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }

            _id = Guid.NewGuid().ToString();

            var providerPayment = new PROVIDER_PAYMENT(
                _id,
                txtID.Text,
                txtDate.DateTime,
                txtPurchaseOrg.Text,
                42, // Phiếu chi
                0,
                "11111111-1111-1111-1111-111111111111",
                "",
                "VND",
                1,
                "",
                "",
                txtCustomerID.EditValue.ToString(),
                txtCustomerID.Text,
                _address,
                "",
                "",
                txtPaying.Value, // Tiền trong phiếu chi
                0,
                0,
                0,
                false,
                false,
                MyLogin.Account,
                DateTime.Now,
                MyLogin.Account,
                DateTime.Now,
                txtEmpID.EditValue.ToString(),
                txtReason.Text,
                0,
                true
                );

            if (!providerPayment.Insert(mySql.Transaction))
            {
                mySql.RollBack();
                return;
            }

            result = DetailSave(mySql);
            if (result != "OK")
            {
                mySql.RollBack();
                return;
            }

            result = UpdatePurchase(mySql);
            if (result != "OK")
            {
                mySql.RollBack();
                return;
            }

            mySql.Commit();
            InvokeSuccess();
            if (XtraMessageBox.Show("Lưu dữ liệu thành công. \n\n Bạn có muốn in phiếu này không?", "Thông báo", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Print(false);
            }
        }

        private string DetailSave(SqlHelper sql)
        {
            string result = "OK";
            var cls = new PROVIDER_PAYMENT_DETAIL();

            if (!cls.Insert(
                sql.Transaction,
                Convert.ToString(_debtIDs),
                _id,
                Convert.ToString(_purchaseIDs),
                "VND",
                1,
                1,
                Convert.ToDecimal(txtTotalAmount.Value),
                Convert.ToDecimal(txtDebt.Value),
                Convert.ToDecimal(txtPaying.Value),
                
                0,
                0,
                0,
                0,
                0,
                0,
                txtCustomerID.Text,
                0)
                )
            {
                
                sql.RollBack();
                return "Không lưu được!";
            }
            return result;
        }

        private string UpdatePurchase(SqlHelper sql)
        {
            string result = "OK";
            var cls = new PROVIDER_PAYMENT_DETAIL();

            if (!cls.UpdatePurchaseTable(sql.Transaction, _stockInwardID))
            {

                sql.RollBack();
                return "Không lưu được!";
            }
            return result;
        }


        public void Print(bool preview)
        {
            if (txtPaying.Value <= 0)
            {
                XtraMessageBox.Show("Giá trị nhập vào không hợp lệ. \n\n Vui lòng kiểm tra lại.", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dsReportPc = new dsReport_PC();
            dsReportPc.PROVIDER_PAYMENT.AddPROVIDER_PAYMENTRow(
                "",
                txtPurchaseOrg.Text,
                txtRefDate.DateTime,
                txtCustomerID.Text,
                "",
                "",
                "",
                txtPaying.Value,
                Guid.Empty
                );
            string numberText = MyLib.ToText(Math.Round(Convert.ToDouble(txtPaying.Value)));
            var rpt = new rptPaymentInvoice2011(dsReportPc.PROVIDER_PAYMENT, "PHIẾU CHI", numberText, txtReason.Text, txtEmpID.Text, txtID.Text, _address);
            rpt.ShowPreview();

        }

       private void BtnPrintClick(object sender, EventArgs e)
        {
            SysLog.Insert("Phiếu Chi", "In", txtID.Text);
            Print(false);
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            Save();
        }

       
    }
}