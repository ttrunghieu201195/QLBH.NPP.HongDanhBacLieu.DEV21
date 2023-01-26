using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Sale.Core.REICEIPT.DS;
using Perfect.Sale.Core.REICEIPT.Report;
using Perfect.Utils.Lib;
using System.Data;
using DevExpress.XtraReports.UI;

namespace Perfect.Sale.Core.REICEIPT
{
    public partial class XfmPhieuThu : XtraForm
    {
        private string _id = "";

        public XfmPhieuThu()
        {
            InitializeComponent();
            txtDate.DateTime = MyLogin.LoginDate;
        }

        private Guid _debtIDs;
        private Guid _purchaseIDs;
        private string _stockOutwardID;
        private string _address;

        public void SetData(CUSTOMER_RECEIPT receipt)
        {

            string sql = "SELECT crd.ReceiptID, \n"
           + "       crd.Amount, \n"
           + "       crd.Debit, \n"
           + "       crd.Payment, \n"
           + "       d.RefDate \n"
           + "FROM   CUSTOMER_RECEIPT_DETAIL crd \n"
           + "       LEFT OUTER JOIN DEBT d \n"
           + "            ON  crd.RefOrgNo = d.ID \n"
           + "WHERE  crd.ReceiptID = @ReceiptID";

            string[] myPara = {"@ReceiptID"};
            object[] myValue = { receipt.ID };

            DataTable dtReceiptDetail = new DataTable();
            SqlHelper mySql = new SqlHelper();

            mySql.CommandType = CommandType.Text;
            dtReceiptDetail = mySql.ExecuteDataTable(sql, myPara, myValue);

            if (dtReceiptDetail.Rows.Count == 0)
            {
                txtTotalAmount.EditValue = 0;
                txtPaid.EditValue = 0;
                txtDebt.EditValue = 0;
                txtPaying.EditValue = 0;
            }
            else
            {
                txtTotalAmount.EditValue = dtReceiptDetail.Rows[0]["Amount"];
                txtDebt.EditValue = dtReceiptDetail.Rows[0]["Debit"];
                txtPaying.EditValue = dtReceiptDetail.Rows[0]["Payment"];
                txtRefDate.EditValue = dtReceiptDetail.Rows[0]["RefDate"];
            }
            txtID.Text = receipt.RefID;
            txtCustomerID.EditValue = receipt.CustomerID;
            txtSaleOrg.EditValue = receipt.RefOrgNo;
            
            txtDate.EditValue = receipt.RefDate;

            txtID.Properties.ReadOnly = true;
            txtCustomerID.Properties.ReadOnly = true;
            txtSaleOrg.Properties.ReadOnly = true;
            txtDate.Properties.ReadOnly = true;

            txtTotalAmount.Properties.ReadOnly = true;
            txtPaid.Properties.ReadOnly = true;
            txtDebt.Properties.ReadOnly = true;
            txtPaying.Properties.ReadOnly = true;

            txtReason.Properties.ReadOnly = true;
            txtEmpID.Properties.ReadOnly = true;

            btnSave.Visible = false;

        }

        public void SetData(string address, string customerID, string chungTu ,DateTime ngay, decimal soTien, decimal daTra, decimal conLai, Guid debtID, Guid purchaseID)
        {
            Add();
            txtCustomerID.EditValue = customerID;
            txtSaleOrg.EditValue = chungTu;
            txtTotalAmount.Value = soTien;
            txtPaid.Value = daTra;
            txtDebt.Value = conLai;
            txtPaying.Value = conLai;
            txtRefDate.DateTime = ngay;
            
            _debtIDs = debtID;
            _purchaseIDs = purchaseID;
            _address = address;
            _stockOutwardID = chungTu;
        }

        public void Add()
        {
            var cls = new TRANS_REF();
            txtID.Text = cls.NewID("PT_" + MyLogin.Account + "_");
            txtID.Properties.ReadOnly = true;
        }

        private void XfmPhieuChiLoad(object sender, EventArgs e)
        {
            PhieuThuInit();
            EmpInit();
            CustomerInit();
        }

        private void PhieuThuInit()
        {
            phieuThuTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            phieuThuTableAdapter.Fill(dsPhieuThu.PhieuThu);
        }

        private void EmpInit()
        {
            eMPLOYEETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            eMPLOYEETableAdapter.Fill(dsPhieuThu.EMPLOYEE);
            if (dsPhieuThu.EMPLOYEE.Rows.Count > 0)
            {
                if (txtEmpID.Text == "") txtEmpID.EditValue = MyLogin.EmployeeID == "" ? Convert.ToString(dsPhieuThu.EMPLOYEE.Rows[0]["Employee_ID"]) : MyLogin.EmployeeID;
            }
        }


        private void CustomerInit()
        {
            cUSTOMERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMERTableAdapter.Fill(dsCustomer.CUSTOMER);
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

            SysLog.Insert("Phiếu Thu", "Thêm", txtID.Text);
            var mySql = new SqlHelper();
            string result = mySql.Start();
            if (result != "OK")
            {
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }
            _id = Guid.NewGuid().ToString();
            var providerPayment = new CUSTOMER_RECEIPT(
               _id,
               txtID.Text,
               txtDate.DateTime,
               txtSaleOrg.Text.Trim(),
               41, //Phiếu Thu
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
               txtPaying.Value,
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

            result = UpdateSale(mySql);
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
            var cls = new CUSTOMER_RECEIPT_DETAIL();

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
                        txtCustomerID.Text,
                        0))
            {
                
                sql.RollBack();
                return "Không lưu được!";
            }
            return result;
        }

        private string UpdateSale(SqlHelper sql)
        {
            string result = "OK";
            var cls = new CUSTOMER_RECEIPT_DETAIL();

            if (!cls.UpdateSaleTable(sql.Transaction, _stockOutwardID))
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
            var dsReportPt = new dsReport_PT();
            dsReportPt.CUSTOMER_RECEIPT.AddCUSTOMER_RECEIPTRow(
                "",
                txtSaleOrg.Text,
                txtRefDate.DateTime,
                txtCustomerID.Text,
                "",
                "",
                "",
                txtPaying.Value,
                Guid.Empty
                );
         
            string numberText =  MyLib.ToText(Math.Round(Convert.ToDouble(txtPaying.Value)));
            var rpt = new RptReceiptInvoice2011(dsReportPt.CUSTOMER_RECEIPT, "PHIẾU THU", txtID.Text, numberText, _address, txtSaleOrg.Text, txtEmpID.Text, txtReason.Text);
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