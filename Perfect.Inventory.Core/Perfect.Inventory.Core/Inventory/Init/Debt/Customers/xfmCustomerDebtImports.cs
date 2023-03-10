using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using Perfect.ERP;
using Perfect.Security;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;

namespace Perfect.Inventory.Core.Inventory.Init.Debt
{
    public partial class XfmCustomerDebtImports : XtraForm
    {
        private bool _check;

        public delegate void ItemCheckingEventHander(
            object sender, int position, string errorText, int number, string description);

        public event ItemCheckingEventHander ItemChecking;

        private void RaiseItemCheckingEventHander(int position, string errorText, int number, string description)
        {
            if (ItemChecking != null) ItemChecking(this, position, errorText, number, description);
        }

        public delegate void ItemCheckedEventHander(object sender);

        public event ItemCheckedEventHander ItemChecked;

        private void RaiseItemCheckedEventHander()
        {
            if (ItemChecked != null) ItemChecked(this);
        }


        public XfmCustomerDebtImports()
        {
            _check = false;
            InitializeComponent();
            ItemChecking += XfmItemImportItemChecking;
            ItemChecked += XfmItemImportItemChecked;
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
                lcCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                wpFinish.AllowNext = true;
                wpFinish.AllowBack = true;
                wpFinish.AllowCancel = true;
                _finish = true;
                BarFinish.Position = 0;
                lcBarFinish.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
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
            //this.Enabled = false;
            var excelDataReader = new ExcelDataReader(txtPath.Text);
            excelDataReader.ExcelReaderComplete += ExcelDataReader_ExcelReaderComplete;
            excelDataReader.ExcelReaderError += ExcelDataReader_ExcelReaderError;
            excelDataReader.ExcelReaderProcess += ExcelDataReader_ExcelReaderProcess;
            excelDataReader.BusyStarted += ExcelDataReader_BusyStarted;
            excelDataReader.BusyFinish += ExcelDataReader_BusyFinish;

            var thread = new Thread(() => excelDataReader.ExcelReadByAdo(txtPath.Text, lsSheet.SelectedItem.ToString()));
            thread.Start();
        }

        private void ExcelDataReader_BusyFinish(object sender)
        {
            if (Bar2.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.BusyFinishEventHander(ExcelDataReader_BusyFinish);
                Invoke(myRestore, new[] {sender});
            }
            else
            {
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lcBar2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void ExcelDataReader_BusyStarted(object sender)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.BusyStartedEventHander(ExcelDataReader_BusyStarted);
                Invoke(myRestore, new[] {sender});
            }
            else
            {
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lcBar2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void ExcelDataReader_ExcelReaderProcess(object sender, int position)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.ExcelReaderProcessEventHander(ExcelDataReader_ExcelReaderProcess);
                Invoke(myRestore, new[] {sender, position});
            }
            else
            {
                Bar.Position = position;
            }
        }

        private void ExcelDataReader_ExcelReaderError(object sender, string message)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.ExcelReaderErrorEventHander(ExcelDataReader_ExcelReaderError);
                Invoke(myRestore, new[] {sender, message});
            }
            else
            {
                //btnBrowse.Enabled = true;
                //  this.Enabled = true;
                XtraMessageBox.Show("Error:\n\t" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcelDataReader_ExcelReaderComplete(object sender, DataTable dt)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.ExcelReaderCompleteEventHander(ExcelDataReader_ExcelReaderComplete);
                Invoke(myRestore, new[] {sender, dt});
            }
            else
            {
                dsImports.COLUMNS.Clear();
                dsImports.COLUMNS.AddCOLUMNSRow("<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                "<Không Chọn>", "<Không Chọn>");


                rpColumns.Items.Clear();
                rpColumns.Items.Add("<Không Chọn>");
                // rpColumns.Items.Add("<Tự Động>");
                if (dt != null)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        rpColumns.Items.Add(dt.Columns[i].Caption);

                        switch (dt.Columns[i].Caption)
                        {
                            case "ProductId":
                                dsImports.COLUMNS.Rows[0]["Product_ID"] = dt.Columns[i].Caption;
                                break;
                            case "ProductName":
                                dsImports.COLUMNS.Rows[0]["Product_Name"] = dt.Columns[i].Caption;
                                break;
                            case "Unit":
                                dsImports.COLUMNS.Rows[0]["Unit"] = dt.Columns[i].Caption;
                                break;
                            case "Quantity":
                                dsImports.COLUMNS.Rows[0]["Quantity"] = dt.Columns[i].Caption;
                                break;
                            case "UnitPrice":
                                dsImports.COLUMNS.Rows[0]["UnitPrice"] = dt.Columns[i].Caption;
                                break;
                            case "Amount":
                                dsImports.COLUMNS.Rows[0]["Amount"] = dt.Columns[i].Caption;
                                break;
                                //case "CreatedDate":
                                //    dsImports.COLUMNS.Rows[0]["Created"] = dt.Columns[i].Caption;
                                //    break;
                                //case "ProductGroup":
                                //    dsImports.COLUMNS.Rows[0]["ProductGroup_ID"] = dt.Columns[i].Caption;
                                //    break;
                            case "StockName":
                                dsImports.COLUMNS.Rows[0]["Stock_ID"] = dt.Columns[i].Caption;
                                break;
                        }
                    }
                    gcList.DataSource = dt;
                    gbList.Columns["Chọn"].ColVIndex = 0;
                    gbList.Columns["Error"].Visible = false;
                    gbList.Columns["ErrorText"].Visible = false;
                }
                // btnBrowse.Enabled = true;
                //Product_Init(gbList);                              
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void WcImportSelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            if (e.Page == wpinput)
            {
                //lblMessage.Text = "Chọn tập tin nguồn";
            }
            else if (e.Page == wpBrowse)
            {
                //  lblMessage.Text = "Danh sách dữ liệu trước nhập khẩu.";

                var fi = new FileInfo(txtPath.Text);
                if (!fi.Exists | lsSheet.SelectedItem == null)
                {
                    wcImport.SelectedPage = wpinput;
                }

                //wpBrowse.Text = "Excel Path: " + OpenFileDialog.FileName;
                ReadData();
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else if (e.Page == wpCelMerge)
            {
                //   lblMessage.Text = "Ghép trường dữ liệu.";
                //  MessageBox.Show("OK");
            }
            else if (e.Page == wpCheck)
            {
                if (_check) return;

                var error = false;

                var temp = gbColMerge.GetCellDisplayText(rowProduct_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    error = true;
                    gbColMerge.SetRowError(rowProduct_ID.Properties, "Vui lòng ghép trường cho mã hàng hoá");
                }

                temp = gbColMerge.GetCellDisplayText(rowProduct_Name, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowProduct_Name.Properties, "Vui lòng ghép trường cho tên hàng hoá");
                    error = true;
                }

                temp = gbColMerge.GetCellDisplayText(rowUnit, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowUnit.Properties, "Vui lòng ghép trường cho đơn vị tính");
                    error = true;
                }

                temp = gbColMerge.GetCellDisplayText(rowStock_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowStock_ID.Properties, "Vui lòng ghép trường cho kho hàng");
                    error = true;
                }


                temp = gbColMerge.GetCellDisplayText(rowQuantity, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowQuantity.Properties, "Vui lòng ghép trường cho số lượng");
                    error = true;
                }

                if (error)
                {
                    XtraMessageBox.Show("Vui lòng ghép trường", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    _check = false;
                    return;
                }

                lblTotal.Text = @"Tổng cộng: " + gbList.RowCount;
                _fail = 0;
                _success = 0;
                wpCheck.AllowNext = false;
                wpCheck.AllowBack = false;
                lcCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                var thread = new Thread(ExecuteCheck);
                thread.Start();
            }
            else if (e.Page == wpFinish)
            {
                // lblMessage.Text = "Nhập dữ liệu.";
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

                lcBarFinish.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                dsError.ERROR.Rows.Clear();
                var thread = new Thread(Execute);
                thread.Start();
            }
            else
            {
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lcBar2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private int _fail;
        private int _success;
        private int _warning;


        private void Execute()
        {
            var dt = (DataTable) gcList.DataSource;

            if (dt != null)
            {
                var product = new PRODUCT();
                var unit = new UNIT();
                var stock = new STOCK();

                var mySql = new SqlHelper();

                object ob;

                int compare = 0;
                if (chxStock.Checked)
                {
                    compare = 1;
                }
                if (chxQty.Checked)
                {
                    compare = 2;
                }
                if (chxAmt.Checked)
                {
                    compare = 3;
                }

                var temp = mySql.Start();

                if (temp != "OK")
                {
                    mySql.RollBack();
                    RaiseItemCheckingEventHander(0, temp, 1, temp);
                }


                var cls = new STOCK_INWARD();
                string id;
                var result = "";

                if (cls.GetInit(mySql.Transaction) == "OK")
                {
                    id = cls.ID;
                }
                else
                {
                    id = cls.CreateKey("ĐK");

                    if (!cls.Insert(
                        mySql.Transaction,
                        id,
                        DateTime.Now,
                        "",
                        0,
                        "11111111-1111-1111-1111-111111111111",
                        "",
                        DateTime.Now,
                        DateTime.Now,
                        id,
                        "",
                        MyLogin.UserId,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "Đầu kỳ",
                        0,
                        SysOption.Currency,
                        1,
                        0,
                        0,
                        0,
                        0,
                        DateTime.Now,
                        0,
                        0,
                        0,
                        0,
                        false,
                        "(Nhập Số Dư Ban Đầu)",
                        0,
                        MyLogin.UserId,
                        true))
                    {
                        result = mySql.Result;
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(-1, result, 1, temp);
                        return;
                    }

                    var transaction = new TRANS_REF
                        (Guid.NewGuid().ToString(),
                         id,
                         "",
                         0,
                         DateTime.Now,
                         "", // txtCustomerName.EditValue.ToString(),
                         "",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "Đầu Kỳ",
                         SysOption.Currency,
                         1,
                         0,
                         0,
                         0,
                         0,
                         false,
                         0,
                         "(Đầu Kỳ)",
                         MyLogin.UserId,
                         true);
                    if (!transaction.Insert(mySql.Transaction))
                    {
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(-1, result, 1, temp);
                        return;
                    }
                }

                var detail = new STOCK_INWARD_DETAIL();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;
                    if (Convert.ToInt32(dt.Rows[i]["Error"] == DBNull.Value ? 0 : dt.Rows[i]["Error"]) == 1) continue;

                    detail.Inward_ID = id;
                    detail.RefType = cls.RefType;
                    detail.Vat = 0;
                    detail.ID = Guid.NewGuid().ToString();
                    detail.UnitConvert = 1;

                    temp = gbColMerge.GetCellDisplayText(rowStock_ID, 0);
                    //neu khong hang dc chon
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];

                        temp = ob == DBNull.Value ? "" : ob.ToString();

                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Kho hàng chưa xác định.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        if (stock.GetByName(mySql.Transaction, temp) != "OK")
                        {
                            RaiseItemCheckingEventHander(i, "Kho hàng không tồn tại.", 2, temp);
                            mySql.RollBack();
                            return;
                        }
                        detail.Stock_ID = stock.Stock_ID;
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Kho hàng chưa xác định.", 1, temp);
                        mySql.RollBack();
                        return;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowProduct_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];

                        temp = ob == DBNull.Value ? "" : ob.ToString();

                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Mã Hàng Hoá chưa biết.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        if (product.Get(mySql.Transaction, temp) != "OK")
                        {
                            RaiseItemCheckingEventHander(i, "Hàng hoá không tồn tại.", 1, temp);
                            mySql.RollBack();
                            return;
                        }

                        detail.Product_ID = product.Product_ID;
                        detail.ProductName = product.Product_Name;
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Mã Hàng hoá chưa xác định.", 1, temp);
                        mySql.RollBack();
                        return;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowUnit, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (temp.Trim() == "")
                        {
                            mySql.RollBack();
                            RaiseItemCheckingEventHander(i, "Đơn vị chưa xác định.", 1, temp);
                            return;
                        }

                        if (unit.GetByName(mySql.Transaction, temp) != "OK")
                        {
                            RaiseItemCheckingEventHander(i, "Đơn vị không tồn tại.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        detail.Unit = unit.Unit_ID;
                    }
                    else
                    {
                        detail.Unit = product.Unit;
                        detail.UnitConvert = 1;
                    }

                    temp = gbColMerge.GetCellDisplayText(rowQuantity, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!MyLib.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Số lượng không phải là số.", 1, temp);
                            detail.Quantity = 0;
                            continue;
                        }
                        detail.Quantity = Convert.ToDecimal(temp);
                        //if (detail.Quantity<=0)
                        //{
                        //    RaiseItemCheckingEventHander(i, "Bỏ qua số lượng bằng 0.", 3, temp);
                        //    detail.Quantity = 0;
                        //    continue;
                        //}
                    }


                    temp = gbColMerge.GetCellDisplayText(rowUnitPrice, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!MyLib.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Số lượng không phải là số.", 3, temp);
                            detail.UnitPrice = 0;
                        }
                        else
                        {
                            detail.UnitPrice = Convert.ToDecimal(temp);
                        }
                    }


                    temp = gbColMerge.GetCellDisplayText(rowAmount, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!MyLib.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Thành tiền không phải là số.", 3, temp);
                            detail.Amount = 0;
                        }
                        else
                        {
                            detail.Amount = Convert.ToDecimal(temp);
                        }
                    }


                    //temp = gbColMerge.GetCellDisplayText(rowLimit, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsDate(temp))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Hạn sử dụng không đúng.", 2, temp);
                    //        detail.Limit = MyLogin.LoginDate.AddDays(product.ExpiryValue);
                    //    }
                    //    else
                    //    {
                    //        detail.Limit = Convert.ToDateTime(temp);
                    //    }
                    //}

                    //temp = gbColMerge.GetCellDisplayText(rowBatch, 0);

                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                    //    detail.Batch = temp;
                    //}

                    detail.Charge = 0;
                    detail.Discount = 0;
                    detail.RefType = 0;
                    detail.UnitConvert = 1;
                    detail.Vat = 0;


                    var exist = detail.Exist(mySql.Transaction, detail.Stock_ID, detail.Product_ID, "",
                                             detail.Quantity, detail.Amount, compare);


                    if (rgOption.SelectedIndex == 0)
                    {
                        if (exist == false)
                        {
                            if (detail.Insert(mySql.Transaction))
                            {
                                temp = mySql.Result;
                                RaiseItemCheckingEventHander(i, temp, 0,
                                                             "Hàng hoá " + product.Product_Name + " đã được thêm");
                            }
                            else
                            {
                                temp = mySql.Result;
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, temp, 1, "Không thực hiện được");
                                return;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (exist)
                        {
                            if (detail.Update(mySql.Transaction))
                            {
                                temp = mySql.Result;
                                RaiseItemCheckingEventHander(i, temp, 0,
                                                             "Hàng hoá " + product.Product_Name + " đã được thêm");
                            }
                            else
                            {
                                temp = mySql.Result;
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, temp, 1, "Không thực hiện được");
                                return;
                            }
                        }
                        else
                        {
                            if (detail.Insert(mySql.Transaction))
                            {
                                temp = mySql.Result;
                                RaiseItemCheckingEventHander(i, temp, 0,
                                                             "Hàng hoá " + product.Product_Name + " đã được thêm");
                            }
                            else
                            {
                                temp = mySql.Result;
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, temp, 1, "Không thực hiện được");
                                return;
                            }
                        }
                    }


                    //switch (rgOption.SelectedIndex)
                    //{
                    //    case 0:
                    //        if (exist == false)
                    //        {
                    //            if (detail.Insert(mySql.Transaction))
                    //            {
                    //                //mySql.Commit();
                    //                temp = mySql.Result;
                    //                RaiseItemCheckingEventHander(i, temp, 0, "Hàng hoá " + product.Product_Name + " đã được thêm");
                    //            }
                    //            else
                    //            {
                    //                temp = mySql.Result;
                    //                mySql.RollBack();
                    //                RaiseItemCheckingEventHander(i, temp, 1, "Không thực hiện được");
                    //                return;
                    //            }
                    //        }else
                    //        {
                    //            temp = mySql.Result;
                    //            mySql.RollBack();
                    //            RaiseItemCheckingEventHander(i, temp, 1, "Không thực hiện được");
                    //            return;
                    //        }
                    //        break;
                    //    case 1:
                    //        if (exist)
                    //        {
                    //            if (detail.Update(mySql.Transaction))
                    //            {
                    //                //mySql.Commit();
                    //                temp = mySql.Result;
                    //                RaiseItemCheckingEventHander(i, temp, 0, "Hàng hoá " + product.Product_Name + " đã được thêm");
                    //            }
                    //            else
                    //            {
                    //                temp = mySql.Result;
                    //                mySql.RollBack();
                    //                RaiseItemCheckingEventHander(i, temp, 1, "Không thực hiện được");
                    //                return;
                    //            }
                    //        }
                    //        else
                    //        {
                    //            if (detail.Insert(mySql.Transaction))
                    //            {
                    //                //mySql.Commit();
                    //                temp = mySql.Result;
                    //                RaiseItemCheckingEventHander(i, temp, 0, "Hàng hoá " + product.Product_Name + " đã được thêm");
                    //            }
                    //            else
                    //            {
                    //                temp = mySql.Result;
                    //                mySql.RollBack();
                    //                RaiseItemCheckingEventHander(i, temp, 1, "Không thực hiện được");
                    //                return;
                    //            }
                    //        }
                    //        break;
                    //    default:
                    //        if (exist)
                    //        {
                    //            temp = mySql.Result;
                    //            mySql.RollBack();
                    //            RaiseItemCheckingEventHander(i, temp, 1, "Hàng này đã tồn tại.");
                    //            return;
                    //        }
                    //        break;
                    //}
                }
                mySql.CommandType = CommandType.Text;
                double amount = mySql.ExecuteScalar2(mySql.Transaction,
                                                     "select sum(amount) from STOCK_INWARD_DETAIL where Inward_ID='" +
                                                     id +
                                                     "'", 0);

                mySql.CommandType = CommandType.Text;
                temp = mySql.ExecuteNonQuery(mySql.Transaction,
                                             "update STOCK_INWARD set Amount=" + amount + " where ID='" + id + "'");
                if (temp != "OK")
                {
                    mySql.RollBack();
                    RaiseItemCheckingEventHander(0, temp, 1, "Không tính tổng thàng tiền được");
                    return;
                }
                mySql.Commit();
                RaiseItemCheckedEventHander();
            }
        }

        private void ExecuteCheck()
        {
            var dt = (DataTable) gcList.DataSource;

            if (dt != null)
            {
                var product = new PRODUCT();
                var stock = new STOCK();
                string temp;
                object ob;
                _finish = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;


                    temp = gbColMerge.GetCellDisplayText(rowProduct_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];

                        temp = ob == DBNull.Value ? "" : ob.ToString();

                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Mã Hàng Hoá chưa biết.", 1, temp);
                            continue;
                        }

                        if (!product.Exist(temp))
                        {
                            RaiseItemCheckingEventHander(i, "Hàng Hoá không tồn tại.", 1, temp);
                            continue;
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Mã Hàng Hoá chưa chọn.", 1, temp);
                        continue;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowStock_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Kho hàng chưa biết.", 2, temp);
                            continue;
                        }
                        if (!stock.ExistByName(temp))
                        {
                            RaiseItemCheckingEventHander(i, "Kho hàng không tồn tại.", 2, temp);
                            continue;
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Kho hàng chưa biết.", 1, temp);
                        continue;
                    }


                    // RaiseItemCheckingEventHander(i,result);
                }

                RaiseItemCheckedEventHander();
            }
            //return false;
        }


        private bool _finish = true;

        private void WcImportFinishClick(object sender, CancelEventArgs e)
        {
            if (!_finish) return;
            Close();
        }


        private void LsSheetSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsSheet.SelectedIndex == -1) return;
            wpinput.AllowNext = true;
        }

        private void GbListCustomDrawRowIndicator(object sender,
                                                  DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
            var i = 0;
            //Bar.Properties.Maximum = dt.Rows.Count;

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

            for (var i = 0; i < dt.Columns.Count; i++)
            {
                rpColumns.Items.Add(dt.Columns[i].Caption);

                switch (dt.Columns[i].Caption)
                {
                    case "ProductId":
                        dsImports.COLUMNS.Rows[0]["Product_ID"] = dt.Columns[i].Caption;
                        break;
                    case "ProductName":
                        dsImports.COLUMNS.Rows[0]["Product_Name"] = dt.Columns[i].Caption;
                        break;
                    case "Unit":
                        dsImports.COLUMNS.Rows[0]["Unit"] = dt.Columns[i].Caption;
                        break;
                    case "Quantity":
                        dsImports.COLUMNS.Rows[0]["Quantity"] = dt.Columns[i].Caption;
                        break;
                    case "UnitPrice":
                        dsImports.COLUMNS.Rows[0]["UnitPrice"] = dt.Columns[i].Caption;
                        break;
                    case "Amount":
                        dsImports.COLUMNS.Rows[0]["Amount"] = dt.Columns[i].Caption;
                        break;
                        //case "CreatedDate":
                        //    dsImports.COLUMNS.Rows[0]["Created"] = dt.Columns[i].Caption;
                        //    break;
                        //case "ProductGroup":
                        //    dsImports.COLUMNS.Rows[0]["ProductGroup_ID"] = dt.Columns[i].Caption;
                        //    break;
                    case "StockName":
                        dsImports.COLUMNS.Rows[0]["Stock_ID"] = dt.Columns[i].Caption;
                        break;
                }
            }
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            for (int i = 0; i < dsImports.COLUMNS.Columns.Count; i++)
            {
                dsImports.COLUMNS.Rows[0][i] = "<Không Chọn>";
            }
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
                                     {
                                         Filter = @"Map file (*.map)|*.map|All File(*.*)|*.*"
                                     };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsImports.COLUMNS.WriteXml(saveFileDialog.FileName);
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
            var openFileDialog = new OpenFileDialog
                                     {
                                         Filter = @"Map file (*.map)|*.map|All File(*.*)|*.*"
                                     };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsImports.COLUMNS.Rows.Clear();
                    dsImports.COLUMNS.ReadXml(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Lỗi:\n\tKhông mở được sơ đồ ghép.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
            }
        }

        private void GbColMergeCellValueChanged(object sender,
                                                DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            if (e.Row == rowStock_ID)
            {
                gbColMerge.SetRowError(rowStock_ID.Properties, null);
            }
            else if (e.Row == rowProduct_ID)
            {
                gbColMerge.SetRowError(rowProduct_ID.Properties, null);
            }
            else if (e.Row == rowProduct_Name)
            {
                gbColMerge.SetRowError(rowProduct_Name.Properties, null);
            }
            else if (e.Row == rowUnit)
            {
                gbColMerge.SetRowError(rowUnit.Properties, null);
            }
            else if (e.Row == rowQuantity)
            {
                gbColMerge.SetRowError(rowQuantity.Properties, null);
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

        private void TxtPathPropertiesButtonClick(object sender,
                                                  DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            wpinput.AllowNext = false;
            Cursor.Current = Cursors.WaitCursor;
            var openFileDialog = new OpenFileDialog
                                     {
                                         Filter = @"Microsoft Excel File(*.xls)|*.xls|All File(*.*)|*.*"
                                     };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lsSheet.Items.Clear();
                txtPath.Text = openFileDialog.FileName;
                var excelDataReader = new ExcelDataReader(openFileDialog.FileName);
                var dt = excelDataReader.GetExcelSheetNames(openFileDialog.FileName);

                if (dt != null)
                {
                    string temp;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        temp = (dt.Rows[i]["TABLE_NAME"] ?? "") as string;
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

        private void ChxStockClick(object sender, EventArgs e)
        {
            chxAmt.Enabled = chxStock.Checked;
        }

        private void ChxQtyClick(object sender, EventArgs e)
        {
            chxAmt.Enabled = chxQty.Checked;
        }
    }
}