using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using System.Threading;

namespace Perfect.Inventory.Core.Inventory.CarryForward
{
    public partial class xfmCarryForward : DevExpress.XtraEditors.XtraForm
    {
        public delegate void TextProcessingArg(string _text);
        public delegate void PercentProcessArg(decimal _percent);
        public delegate void CompleteWorkEventArg(bool _complete);

        private bool CanClose = true;
        public xfmCarryForward()
        {
            InitializeComponent();
            this.Text = "Kết Chuyển";

            IntroText();
            InitEvent();
            txtDateBegin.DateTime = DateTime.Now.AddDays(DateTime.Now.Day * -1);
            PageProgress.AllowBack = false;
            PageProgress.AllowCancel = false;
            PageProgress.AllowNext = false;
        }

        private void RaiseTextProcessing(string newText)
        {
            if (txtProcess.InvokeRequired)
            {
                TextProcessingArg update = new TextProcessingArg(RaiseTextProcessing);
                txtProcess.Invoke(update, new object[] { newText });
            }
            else
                txtProcess.Text += newText + Environment.NewLine;
        }

        private void RaisePercentProcessing(decimal _percent)
        {
            if (barProcess.InvokeRequired)
            {
                PercentProcessArg update = new PercentProcessArg(RaisePercentProcessing);
                barProcess.Invoke(update, new object[] { _percent });
            }
            else
                barProcess.EditValue = _percent;
        }

        public void RaiseCompleteWork(bool _com)
        {
            if (PageProgress.InvokeRequired)
            {
                CompleteWorkEventArg update = new CompleteWorkEventArg(RaiseCompleteWork);
                PageProgress.Invoke(update, new object[] { _com });
            }
            else
                PageProgress.AllowNext = _com;
        }

        private void IntroText()
        {
            wz_CarryForward.CancelText = "Hủy bỏ";
            wz_CarryForward.NextText = "Tiếp theo";
            wz_CarryForward.FinishText = "Hoàn thành";
            wz_CarryForward.PreviousText = "Quay lại";

            PageWelcome.Text = "Kết chuyển số dư đầu kỳ";
            PageWelcome.IntroductionText = @"Tiện ích này sẽ giúp bạn chuyển hết số dư & công nợ trong kỳ sang kỳ mới";
            PageWelcome.ProceedText = "Nhấn [Tiếp theo]...";

            PageSetTime.Text = @"Chọn mốc thời gian";
            PageSetTime.DescriptionText = @"Bạn hãy chọn mốc thời gian cụ thể để thực hiện việc kết chuyển sang kỳ. Mốc thời gian được tính từ ngày chọn trở về trước, dữ liệu mới nhập vào sẽ được tính từ ngày kế tiếp của mốc thời gian";

            PageBeforeExecute.Text = "Bắt đầu kết chuyển";
            PageBeforeExecute.DescriptionText = @"Dữ liệu của bạn sẽ được kết chuyển ngay bây giờ.";

            PageProgress.Text = "Tiến trình thực hiện";
            PageProgress.DescriptionText = @"Dữ liệu đang được kết chuyển. Bạn đợi chút!";

            PageFinish.Text = "Hoàn Tất";
            PageFinish.FinishText = "Bạn đã hoàn thành việc kết chuyển số dư đầu kỳ";
            PageFinish.ProceedText = "Nhấn [Hoàn thành] để kết thúc";

            txtCaution.Text = @"Lưu ý: sau khi kết chuyển, toàn bộ các phiếu giao dịch của kỳ trước (nhập hàng/xuất hàng/chuyển kho/nhập đầu kỳ/công nợ) sẽ mất hết và sẽ được chuyển cho kỳ sau." + Environment.NewLine
                + @"Nếu bạn cần xem lại dữ liệu cũ, hãy tiến hành sao lưu lại.";
        }

        private void InitEvent()
        {
            this.FormClosing += (s, e) =>
            {
                e.Cancel = !CanClose;
            };
            wz_CarryForward.CancelClick += (s, e) =>
            {
                CanClose = true;
                Close();
            };
            wz_CarryForward.FinishClick += (s, e) =>
            {
                CanClose = true;
                Close();
            };
            txtProcess.TextChanged += (s, e) =>
            {
                txtProcess.SelectionStart = txtProcess.Text.Length;
                txtProcess.ScrollToCaret();
                txtProcess.Refresh();
            };
        }

        private void wz_CarryForward_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            if (e.Page == PageProgress)
            {
                CanClose = false;

                RaiseTextProcessing("Đang chuyển dữ liệu...");
                CARRY_FORWARD cr = new CARRY_FORWARD();
                DataTable dtInventoryCurrent = cr.GetCurrentInventory(txtDateBegin.DateTime);
                DataTable dtDebtP = cr.GetCurrentListDebt(1, txtDateBegin.DateTime);// provider debt
                DataTable dtDebtC = cr.GetCurrentListDebt(2, txtDateBegin.DateTime);// customer debt
                cr.ExecuteDelete(txtDateBegin.DateTime);

                Thread myThr = new Thread(() =>
                {
                    DoWork(dtInventoryCurrent, dtDebtP, dtDebtC);
                });
                myThr.Start();
                return;
            }
            if (e.Page == PageFinish)
            {
                PageFinish.AllowBack = false;
                PageFinish.AllowCancel = false;
            }
        }

        private void DoWork(DataTable dtInventoryCurrent, DataTable dtDebtP, DataTable dtDebtC)
        {
            decimal TotalAmount = 0;
            foreach (DataRow dr in dtInventoryCurrent.Rows)
                TotalAmount += Convert.ToDecimal(dr["TotalIOAmount"]);

            var mySql = new Perfect.Data.Helper.SqlHelper();
            string result = mySql.Start();
            if (result != "OK")
            {
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RaiseTextProcessing("");
            RaiseTextProcessing("Đang chuyển công nợ khách hàng...");
            //debt init customer
            foreach (DataRow dr in dtDebtC.Rows)
            {
                var customerDebt = new CUSTOMER_DEBT_INVENTORY();
                string refIdC = "NDK" + Convert.ToString(dr["CustomerID"]);
                decimal Amount = Convert.ToDecimal(dr["DebtAmount"]);
                RaiseTextProcessing("Khách hàng: " + Convert.ToString(dr["CustomerID"]) + " - Số tiền: " + Amount.ToString("##,##0.##"));

                if (!customerDebt.Update(
                    mySql.Transaction,
                    Guid.NewGuid().ToString(),
                    refIdC,
                    DateTime.Now,
                    "",
                    31,
                    0,
                    "11111111-1111-1111-1111-111111111111",
                    Convert.ToString(dr["CustomerID"]),
                    "",
                    "",
                    SysOption.Currency,
                    1,
                    "CN",
                    DateTime.Now.AddMonths(1),
                    0,
                    0,
                    Amount,
                    0,
                    0,
                    Amount,
                    0,
                    0,
                    0,
                    0,
                    false,
                    true,
                    MyLogin.Account,
                    DateTime.Now,
                    MyLogin.UserId,
                    DateTime.Now,
                    MyLogin.UserId,
                    "(Công Nợ Đầu Kỳ)",
                    0,
                    true))
                {
                    mySql.RollBack();
                    result = "Có lỗi xảy ra trong quá trình chuyển đổi. Không thể cập nhập công nợ";
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            RaiseTextProcessing("*******************************");
            RaiseTextProcessing("Đang chuyển công nợ nhà cung cấp...");
            //debt init provider
            foreach (DataRow dr in dtDebtP.Rows)
            {
                var providerdebt = new PROVIDER_DEBT_INVENTORY();
                string refIdP = "NDK-" + Convert.ToString(dr["CustomerID"]);
                decimal Amount = Convert.ToDecimal(dr["DebtAmount"]);
                RaiseTextProcessing("Nhà cung cấp: " + Convert.ToString(dr["CustomerID"]) + " - Số tiền: " + Amount.ToString("##,##0.##"));

                if (!providerdebt.Update(
                    mySql.Transaction,
                    Guid.NewGuid().ToString(),
                    refIdP,
                    DateTime.Now,
                    "",
                    32,
                    1,
                    "11111111-1111-1111-1111-111111111111",
                    Convert.ToString(dr["CustomerID"]),
                    "",
                    "",
                    "VND",
                    1,
                    "CN",
                    DateTime.Now.AddMonths(1),
                    0,
                    0,
                    Amount,
                    0,
                    Amount,
                    0,
                    0,
                    0,
                    0,
                    0,
                    false,
                    true,
                    MyLogin.Account,
                    DateTime.Now,
                    MyLogin.UserId,
                    DateTime.Now,
                    MyLogin.UserId,
                    "(Công Nợ Đầu Kỳ)",
                    0,
                    true))
                {
                    result = "Có lỗi xảy ra trong quá trình chuyển đổi. Không thể cập nhập công nợ";
                    mySql.RollBack();
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            RaiseTextProcessing("*******************************");
            RaiseTextProcessing("Đang chuyển số dư tồn kho...");
            STOCK_INWARD si = new STOCK_INWARD();
            string Init_ID = si.CreateKey(mySql.Transaction, "DK");

            STOCK_INWARD cls = new STOCK_INWARD(
               Init_ID,
               DateTime.Now,
               "",
               0,
               "11111111-1111-1111-1111-111111111111",
               "",
               DateTime.Now,
               DateTime.Now,
               Init_ID,
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               MyLogin.EmployeeID,//"",
               "Nhập Kho",
               0,
               "VND",
               1,
               0,
               0,
               TotalAmount,//TotalAmount
               0,
               DateTime.Now,
               0,
               0,
               0,
               0,
               false,
               "Kết chuyển đầu kỳ",
               0,
               MyLogin.UserId,
               true);
            if (!cls.Insert(mySql.Transaction))
            {
                result = mySql.Result;
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            result = DetailSave(mySql, dtInventoryCurrent, Init_ID);
            RaiseTextProcessing("Xong!");
            RaiseCompleteWork(true);
            if (result != "OK")
            {
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            mySql.Commit();
         }

        private string DetailSave(Perfect.Data.Helper.SqlHelper sql, DataTable InventoryDetail, string ID)
        {
            decimal count = 0;
            foreach (DataRow dr in InventoryDetail.Rows)
            {
                count++;
                RaisePercentProcessing(count / InventoryDetail.Rows.Count * 100);
                RaiseTextProcessing(string.Format("Kho hàng {0} - hàng hóa: {1} - số lượng: {2}", dr["Stock_Name"], dr["ProductName"], Convert.ToDecimal(dr["TotalIOQuantity"]).ToString("##,##0.##")));
                STOCK_INWARD_DETAIL cls = new STOCK_INWARD_DETAIL();
                if (!cls.Insert(
                    sql.Transaction,
                    Guid.NewGuid().ToString(),
                    ID,
                    Convert.ToString(dr["ProductID"]),
                    Convert.ToString(dr["ProductName"]),
                    0,
                    Convert.ToString(dr["StockID"]),
                    Convert.ToString(dr["Unit"]),
                    1,
                    0,
                    0,
                    0,
                    Convert.ToDecimal(dr["TotalIOQuantity"]),
                    Convert.ToDecimal(dr["AVGPrice"]),
                    Convert.ToDecimal(dr["TotalIOAmount"]),
                    Convert.ToDecimal(dr["TotalIOQuantity"]),
                    0,
                    0,
                    0,
                    DateTime.Now,
                    0,
                    0,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    0,
                    "",
                    0,
                    true))
                {
                    return "Có lỗi xảy ra trong quá trình lưu thông tin";
                }
            }
            return "OK";
        }
    }
}