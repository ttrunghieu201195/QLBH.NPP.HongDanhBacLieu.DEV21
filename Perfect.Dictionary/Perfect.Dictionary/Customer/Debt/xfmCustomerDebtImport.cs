using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraWizard;
using Perfect.Data.Helper;
using Perfect.Dictionary.Customer.usercontrol.Debt;
using Perfect.ERP;
using Perfect.Security;

namespace Perfect.Dictionary.Customer.Debt
{
    public partial class XfmCustomerDebtImport : XtraForm
    {
        #region Delegates

        public delegate void ItemCheckedEventHander(object sender);

        public delegate void ItemCheckingEventHander(
            object sender, int position, string errorText, int number, string description);

        #endregion

        private bool _check;
        private int _fail;
        private bool _finish = true;
        private int _success;
        private int _warning;

        public XfmCustomerDebtImport()
        {
            InitializeComponent();
            ItemChecking += XfmItemImportItemChecking;
            ItemChecked += XfmItemImportItemChecked;
        }

        public event ItemCheckingEventHander ItemChecking;

        private void RaiseItemCheckingEventHander(int position, string errorText, int number, string description)
        {
            if (ItemChecking != null) ItemChecking(this, position, errorText, number, description);
        }

        public event ItemCheckedEventHander ItemChecked;

        private void RaiseItemCheckedEventHander()
        {
            if (ItemChecked != null) ItemChecked(this);
        }


        private void XfmItemImportItemChecked(object sender)
        {
            if (BarCheck.InvokeRequired)
            {
                var myRestore = new ItemCheckedEventHander(XfmItemImportItemChecked);
                Invoke(myRestore, new[] {sender});
            }
            else
            {
                _check = true;
                wpCheck.AllowNext = true;
                wpCheck.AllowBack = true;
                BarCheck.Position = 0;
                lcCheck.Visibility = LayoutVisibility.Never;

                wpFinish.AllowNext = true;
                wpFinish.AllowBack = true;
                wpFinish.AllowCancel = true;
                _finish = true;
                BarFinish.Position = 0;
                lcBarFinish.Visibility = LayoutVisibility.Never;
            }
        }

        private void XfmItemImportItemChecking(object sender, int position, string errorText, int number,
                                               string description)
        {
            if (BarCheck.InvokeRequired)
            {
                ItemCheckingEventHander myRestore = XfmItemImportItemChecking;
                Invoke(myRestore, new[] {sender, position, errorText, number, description});
            }
            else
            {
                BarCheck.Position = (int) (position/(double) gbList.RowCount*100);
                BarFinish.Position = BarCheck.Position;


                if (errorText == "OK")
                {
                    _success++;
                    gbList.SetRowCellValue(position, "Error", 0);
                    gbList.UpdateCurrentRow();
                }
                else
                {
                    _finish = true;
                    if (number == 1)
                    {
                        _fail++;
                    }
                    else
                    {
                        _warning++;
                    }

                    dsError.ERROR.AddERRORRow(errorText, "Dòng bị lỗi thứ " + position, description, number);
                    gbList.SetRowCellValue(position, "Error", number);
                    gbList.UpdateCurrentRow();
                }
                lblSuccess.Text = @"Thành Công: " + _success;
                lblFail.Text = @"Thất Bại: " + _fail;
                lblWarning.Text = @"Cảnh Báo: " + _warning;
                lblSuccess1.Text = @"Thành Công: " + _success;
                lblFail1.Text = @"Thất Bại: " + _fail;
            }
        }


        private void ReadData()
        {
            var excelDataReader = new ExcelDataReader(txtPath.Text);
            excelDataReader.ExcelReaderComplete += ExcelDataReaderExcelReaderComplete;
            excelDataReader.ExcelReaderError += ExcelDataReaderExcelReaderError;
            excelDataReader.ExcelReaderProcess += ExcelDataReaderExcelReaderProcess;
            excelDataReader.BusyStarted += ExcelDataReaderBusyStarted;
            excelDataReader.BusyFinish += ExcelDataReaderBusyFinish;

            var thread = new Thread(() => excelDataReader.ExcelReadByADO(txtPath.Text, lsSheet.SelectedItem.ToString()));
            thread.Start();
        }

        private void ExcelDataReaderBusyFinish(object sender)
        {
            if (Bar2.InvokeRequired)
            {
                ExcelDataReader.BusyFinishEventHander myRestore = ExcelDataReaderBusyFinish;
                Invoke(myRestore, new[] {sender});
            }
            else
            {
                lcBar.Visibility = LayoutVisibility.Always;
                lcBar2.Visibility = LayoutVisibility.Never;
            }
        }

        private void ExcelDataReaderBusyStarted(object sender)
        {
            if (Bar.InvokeRequired)
            {
                ExcelDataReader.BusyStartedEventHander myRestore = ExcelDataReaderBusyStarted;
                Invoke(myRestore, new[] {sender});
            }
            else
            {
                lcBar.Visibility = LayoutVisibility.Never;
                lcBar2.Visibility = LayoutVisibility.Always;
            }
        }

        private void ExcelDataReaderExcelReaderProcess(object sender, int position)
        {
            if (Bar.InvokeRequired)
            {
                ExcelDataReader.ExcelReaderProcessEventHander myRestore = ExcelDataReaderExcelReaderProcess;
                Invoke(myRestore, new[] {sender, position});
            }
            else
            {
                Bar.Position = position;
            }
        }

        private void ExcelDataReaderExcelReaderError(object sender, string message)
        {
            if (Bar.InvokeRequired)
            {
                ExcelDataReader.ExcelReaderErrorEventHander myRestore = ExcelDataReaderExcelReaderError;
                Invoke(myRestore, new[] {sender, message});
            }
            else
            {
                XtraMessageBox.Show("Lỗi:\n\t" + message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExcelDataReaderExcelReaderComplete(object sender, DataTable dt)
        {
            if (Bar.InvokeRequired)
            {
                ExcelDataReader.ExcelReaderCompleteEventHander myRestore = ExcelDataReaderExcelReaderComplete;
                Invoke(myRestore, new[] {sender, dt});
            }
            else
            {
                dsDebtImport.CustomerDebtImport.Clear();
                dsDebtImport.CustomerDebtImport.AddCustomerDebtImportRow(
                    "<Không Chọn>",
                    "<Không Chọn>",
                    "<Không Chọn>");


                rpColumns.Items.Clear();
                rpColumns.Items.Add("<Không Chọn>");
                if (dt != null)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        rpColumns.Items.Add(dt.Columns[i].Caption);

                        if (dt.Columns[i].Caption.ToLower().IndexOf("Khách Hàng") != -1)
                        {
                            dsDebtImport.CustomerDebtImport.Rows[0]["Customer_ID"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("Tiền Nợ") != -1)
                        {
                            dsDebtImport.CustomerDebtImport.Rows[0]["Amount"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("Ghi Chú") != -1)
                        {
                            dsDebtImport.CustomerDebtImport.Rows[0]["Description"] = dt.Columns[i].Caption;
                        }
                    }
                    gcList.DataSource = dt;
                    gbList.Columns["Chọn"].VisibleIndex = 0;
                    gbList.Columns["Error"].Visible = false;
                    gbList.Columns["ErrorText"].Visible = false;
                }

                lcBar.Visibility = LayoutVisibility.Never;
            }
        }


        private void WcImportSelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            if (e.Page == wpinput)
            {
                //lblMessage.Text = "Chọn tập tin nguồn";
            }
            else if (e.Page == wpBrowse)
            {
                // lblMessage.Text = "Danh sách dữ liệu trước nhập khẩu.";

                var fi = new FileInfo(txtPath.Text);
                if (!fi.Exists | lsSheet.SelectedItem == null)
                {
                    wcImport.SelectedPage = wpinput;
                }

                //wpBrowse.Text = "Excel Path: " + OpenFileDialog.FileName;
                ReadData();
                lcBar.Visibility = LayoutVisibility.Always;
            }
            else if (e.Page == wpCelMerge)
            {
                //lblMessage.Text = "Ghép trường dữ liệu.";
                //  MessageBox.Show("OK");
            }
            else if (e.Page == wpCheck)
            {
                if (_check) return;
                bool error = false;

                string temp = gbColMerge.GetCellDisplayText(rowCustomer_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    error = true;
                    gbColMerge.SetRowError(rowCustomer_ID.Properties, "Vui lòng ghép trường cho mã khách hàng");
                }

                temp = gbColMerge.GetCellDisplayText(rowCustomer_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowCustomer_ID.Properties, "Vui lòng ghép trường cho tên khách hàng");
                    error = true;
                }


                if (error)
                {
                    XtraMessageBox.Show("Vui lòng ghép trường", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                }

                lblTotal.Text = @"Tổng cộng: " + gbList.RowCount;
                _fail = 0;
                _success = 0;
                wpCheck.AllowNext = false;
                wpCheck.AllowBack = false;
                lcCheck.Visibility = LayoutVisibility.Always;

                var thread = new Thread(ExecuteCheck);
                thread.Start();
            }
            else if (e.Page == wpFinish)
            {
                _check = true;
                lblTotal.Text = @"Tổng cộng: " + gbList.RowCount;
                lblTotal1.Text = @"Tổng cộng: " + gbList.RowCount;
                _fail = 0;
                _success = 0;
                _warning = 0;
                wpFinish.AllowNext = false;
                wpFinish.AllowBack = false;
                wpFinish.AllowCancel = false;
                _finish = false;

                lcBarFinish.Visibility = LayoutVisibility.Always;
                dsError.ERROR.Rows.Clear();
                var thread = new Thread(Execute);
                thread.Start();
            }
            else
            {
                lcBar.Visibility = LayoutVisibility.Never;
                lcBar2.Visibility = LayoutVisibility.Never;
            }
        }


        private void Execute()
        {
            var dt = (DataTable) gcList.DataSource;
            if (dt != null)
            {
                var customerDebt = new CustomerDebt();
                var customer = new CUSTOMER();
                var mySql = new SqlHelper();
                string temp;
                object ob;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;
                    if (Convert.ToInt32(dt.Rows[i]["Error"] == DBNull.Value ? 0 : dt.Rows[i]["Error"]) == 1) continue;
                    string result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(i, result, 1, result);
                    }

                    temp = gbColMerge.GetCellDisplayText(rowCustomer_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (customer.Exist(mySql.Transaction, temp))
                        {
                            customerDebt.CustomerID = temp;
                        }
                        else
                        {
                            RaiseItemCheckingEventHander(i, "Khách Hàng không tồn tại.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        
                    }
                    
                    string refId = "NDK-" + customerDebt.CustomerID;

                    customerDebt.ID = Guid.NewGuid().ToString();
                    customerDebt.RefID = refId;
                    customerDebt.RefDate = DateTime.Now;
                    customerDebt.RefOrgNo = Guid.NewGuid().ToString();
                    customerDebt.RefType = 31;
                    customerDebt.RefStatus = 0;
                    customerDebt.PaymentMethod = "11111111-1111-1111-1111-111111111111";
                    customerDebt.ProductID = "";
                    customerDebt.ProductName = "";
                    customerDebt.CurrencyID = "VND";
                    customerDebt.ExchangeRate = 1;
                    customerDebt.TermID = "CN";

                    customerDebt.DueDate =  DateTime.Now.AddMonths(1);
			        customerDebt.Quantity =0;
			        customerDebt.ReQuantity=0;
			        customerDebt.Discount = 0;
			        customerDebt.Payment = 0;
			        customerDebt.Balance = 0;
			        customerDebt.FAmount = 0;
                    customerDebt.FPayment = 0;
                    customerDebt.FBalance = 0;
                    customerDebt.FDiscount = 0;
                    customerDebt.IsChanged = false;
                    customerDebt.IsPublic = true;
                    customerDebt.CreatedBy = MyLogin.AccountName;
                    customerDebt.CreatedDate = MyLogin.LoginDate;
			        customerDebt.ModifiedBy = MyLogin.AccountName;
			        customerDebt.ModifiedDate = MyLogin.LoginDate;
                    customerDebt.OwnerID = MyLogin.UserId;
                    customerDebt.Sorted = 0;
                    customerDebt.Active = true;



                    


                    temp = gbColMerge.GetCellDisplayText(rowAmount, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customerDebt.Amount = Convert.ToDecimal(ob);
                        customerDebt.Balance = Convert.ToDecimal(ob);
                    }

                    temp = gbColMerge.GetCellDisplayText(rowDescription, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customerDebt.Description = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    //if (exist) result = customer.Update(mySql.Transaction);
                    //else result = customerDebt.Insert(mySql.Transaction);

                    result = customerDebt.ImportInsert(mySql.Transaction);
                    if (result == "OK")
                    {
                        mySql.Commit();
                        RaiseItemCheckingEventHander(i, result, 0,"Khách Hàng " + customer.CustomerName + " đã được thêm");
                    }
                    else
                    {
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(i, result, 1, "Không thực hiện được");
                    }
                }
                RaiseItemCheckedEventHander();
            }
        }

        private void ExecuteCheck()
        {
            var dt = (DataTable) gcList.DataSource;

            if (dt != null)
            {
                var customer = new CUSTOMER();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;
                    object ob = dt.Rows[i][gbColMerge.GetCellDisplayText(rowCustomer_ID, 0)];
                    string temp = ob == DBNull.Value ? "" : ob.ToString();

                    if (!customer.Exist(temp))
                    {
                        RaiseItemCheckingEventHander(i, "Khách Hàng không tồn tại.", 2, temp);
                        continue;
                    }
                }

                RaiseItemCheckedEventHander();
            }
        }

        private void WcImportNextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
        }

        private void XfmItemImportLoad(object sender, EventArgs e)
        {
        }

        private void WcImportFinishClick(object sender, CancelEventArgs e)
        {
            if (!_finish) return;
            Close();
        }

        private void WcImportCancelClick(object sender, CancelEventArgs e)
        {
            //Close();
        }

        private void LsSheetSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsSheet.SelectedIndex == -1) return;
            wpinput.AllowNext = true;
        }

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void ChxAllCheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            while (i < gbList.RowCount)
            {
                gbList.SetRowCellValue(i, "Chọn", chxAll.Checked);
                gbList.SetRowCellValue(i, "Error", 0);
                i++;
            }
        }

        private void BtnAutoClick(object sender, EventArgs e)
        {
            var dt = (DataTable) gcList.DataSource;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                rpColumns.Items.Add(dt.Columns[i].Caption);

                if (dt.Columns[i].Caption.ToLower().IndexOf("Mã Khách Hàng") != -1)
                {
                    dsDebtImport.CustomerDebtImport.Rows[0]["Customer_ID"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("Tiền Nợ") != -1)
                {
                    dsDebtImport.CustomerDebtImport.Rows[0]["Amount"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("Ghi Chú") != -1)
                {
                    dsDebtImport.CustomerDebtImport.Rows[0]["Description"] = dt.Columns[i].Caption;
                }
            }
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            for (int i = 0; i < dsDebtImport.CustomerDebtImport.Columns.Count; i++)
            {
                dsDebtImport.CustomerDebtImport.Rows[0][i] = "<Không Chọn>";
            }
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog {Filter = @"Map file (*.map)|*.map|All File(*.*)|*.*"};
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsDebtImport.CustomerDebtImport.WriteXml(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Lỗi:\n\tKhông lưu được sơ đồ ghép.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnOpenMergeClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {Filter = @"Map file (*.map)|*.map|All File(*.*)|*.*"};
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsDebtImport.CustomerDebtImport.Rows.Clear();
                    dsDebtImport.CustomerDebtImport.ReadXml(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Lỗi:\n\tKhông mở được sơ đồ ghép.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
            }
        }

        private void GbColMergeCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Row == rowCustomer_ID)
            {
                gbColMerge.SetRowError(rowCustomer_ID.Properties, null);
            }
            else
            {
                gbColMerge.ClearRowErrors();
            }
        }

        private void XfmItemImportFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_finish;
        }

        private void TxtPathPropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            wpinput.AllowNext = false;
            var openFileDialog = new OpenFileDialog {Filter = @"Microsoft Excel File(*.xls)|*.xls|All File(*.*)|*.*"};
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lsSheet.Items.Clear();
                txtPath.Text = openFileDialog.FileName;
                var excelDataReader = new ExcelDataReader(openFileDialog.FileName);
                DataTable dt = excelDataReader.GetExcelSheetNames(openFileDialog.FileName);

                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var temp = (dt.Rows[i]["TABLE_NAME"] ?? "") as string;
                        if (temp != "")
                        {
                            if (temp != null) temp = temp.Substring(0, temp.Length - 1);
                            lsSheet.Items.Add(temp);
                        }
                    }
                }
            }


            Cursor.Current = Cursors.Default;
        }

        private void TxtPathEditValueChanged(object sender, EventArgs e)
        {
        }
    }
}