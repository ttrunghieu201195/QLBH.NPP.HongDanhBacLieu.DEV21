using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Dictionary;
using Perfect.Sale.Core.REICEIPT.DS;
using Perfect.Sale.Core.REICEIPT.Report;
using Perfect.Utils.Lib;
using System.Data;

namespace Perfect.Sale.Core.REICEIPT
{
    public partial class xfmPhieuThuTong : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SaveEvenhandler();

        public event SaveEvenhandler Success;

        public xfmPhieuThuTong()
        {
            InitializeComponent();
            Add();
        }

        private void xfmPhieuThuTong_Load(object sender, EventArgs e)
        {

        }

        private void InvokeSuccess()
        {
            SaveEvenhandler evenhandler = Success;
            if (evenhandler != null) evenhandler();
        }

        private void InitData()
        {
            cUSTOMERDEBT_ListTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMERDEBT_ListTableAdapter.ClearBeforeFill = true;
            cUSTOMERDEBT_ListTableAdapter.Fill(dsPhieuThu.CUSTOMERDEBT_List);

            EMPLOYEE e = new EMPLOYEE();
            txtEmployee.Properties.DataSource = e.GetList();
            txtEmployee.EditValue = MyLogin.EmployeeID;
        }

        private void Add()
        {
            InitData();
            var cls = new TRANS_REF();
            txtID.Text = cls.NewID("PTT_" + MyLogin.Account + "_");
            dtCreated.DateTime = DateTime.Now;
            txtTotalPaid.Value = 0;
            txtCustomer.EditValue = null;
            txtDescription.Text = "Phiếu thu tổng";
        }

        private void Total()
        {
            txtTotalDebt.Value = Convert.ToDecimal(colBalance.SummaryItem.SummaryValue);
            txtTotalPaid.Value = Convert.ToDecimal(colBalance.SummaryItem.SummaryValue);
        }

        private void txtCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCustomer.EditValue == null)
            {
                dsPhieuThu.DEBT_ListByCustomer.Rows.Clear();
                gbList.UpdateSummary();
                Total();
                return;
            }

            dEBT_ListByCustomerTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            dEBT_ListByCustomerTableAdapter.ClearBeforeFill = true;
            dEBT_ListByCustomerTableAdapter.Fill(dsPhieuThu.DEBT_ListByCustomer, Convert.ToString(txtCustomer.EditValue));
            gbList.UpdateSummary();
            Total();
            gbList.BestFitColumns();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckSave()) return;
            SaveDebt();
            Add();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Print(bool preview)
        {
        }

        #region Save Debt
        private bool CheckSave()
        {
            if (txtCustomer.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTotalPaid.Value > txtTotalDebt.Value)
            {
                MessageBox.Show("Số tiền trả không được vượt quá số tiền nợ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTotalPaid.Value < 0)
            {
                MessageBox.Show("Số tiền trả không hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (gbList.RowCount == 0 || txtTotalDebt.Value == 0)
            {
                MessageBox.Show(string.Format("Khách hàng {0} hiện không còn nợ", txtCustomer.Text), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SaveDebt()
        {
            SysLog.Insert("Phiếu Thu Tổng", "Thêm", txtID.Text);
            var mySql = new SqlHelper();
            string result = mySql.Start();
            if (result != "OK")
            {
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CUSTOMER c = new CUSTOMER();
            c.Get(Convert.ToString(txtCustomer.EditValue));
            string PhieuThuID = Guid.NewGuid().ToString();
            CUSTOMER_RECEIPT cRec = new CUSTOMER_RECEIPT(
                PhieuThuID,
                txtID.Text,
                dtCreated.DateTime,
                txtID.Text,// ma phieu xuat hang => không cần, ở đây là phiếu tổng
                41,//phieu thu
                0,
                "11111111-1111-1111-1111-111111111111",
                "",
                "VND",
                1,
                "",
                "",
                Convert.ToString(txtCustomer.EditValue),
                txtCustomer.Text,
                c.CustomerAddress,
                c.Tax,
                c.Contact,
                txtTotalDebt.Value,
                0,
                0,
                0,
                false,
                false,
                MyLogin.Account,
                DateTime.Now,
                MyLogin.Account,
                DateTime.Now,
                Convert.ToString(txtEmployee.EditValue),
                txtDescription.Text,
                0,
                true
                );
            if (!cRec.Insert())
            {
                mySql.RollBack();
                return;
            }

            result = DetailSave(mySql, PhieuThuID);
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

        private string DetailSave(SqlHelper sql, string ReceiptID)
        {
            var cls = new CUSTOMER_RECEIPT_DETAIL();
            decimal TotalMoney = txtTotalPaid.Value;//tổng tiền trả cho các phiếu nợ
            for (int i = 0; i < gbList.RowCount; i++)
            {
                gbList.FocusedRowHandle = i;
                gcList.Refresh();
                if (TotalMoney <= 0) break;//nếu hết tiền

                decimal myDebt = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colBalance));// số tiền nợ của phiếu thứ i
                decimal PayAmount = TotalMoney - myDebt > 0 ? myDebt : TotalMoney;// số tiền tra cho phiếu thứ i
                string OutwardID = Convert.ToString(gbList.GetFocusedRowCellValue(colOutwardID));

                string DetailID = Guid.NewGuid().ToString();
                if (!cls.Insert(sql.Transaction,
                    DetailID,
                    ReceiptID,
                    Convert.ToString(gbList.GetFocusedRowCellValue(colID)),// debt id
                    "VND",
                    1,
                    1,
                    Convert.ToDecimal(gbList.GetFocusedRowCellValue(colAmount)),
                    myDebt,
                    PayAmount,
                    0,
                    0,
                    0,
                    0,
                    0,
                    txtCustomer.Text,
                    0))
                {
                    sql.RollBack();
                    return "Không lưu được!";
                }
                TotalMoney -= myDebt;// cập nhật lại tổng tiền

                // cập nhật status phiếu bán hàng
                if (!cls.UpdateSaleTable(sql.Transaction, OutwardID))
                {
                    sql.RollBack();
                    return "Không lưu được!";
                }

                //end of for
            }
            return "OK";
        }


        #endregion
    }
}