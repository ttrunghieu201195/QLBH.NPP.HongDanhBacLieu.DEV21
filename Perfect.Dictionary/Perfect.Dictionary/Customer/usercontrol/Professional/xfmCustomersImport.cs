using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using Perfect.ERP;
using Perfect.Security;
using Perfect.Utils.Lib;
using Perfect.Common;
using Perfect.Data.Helper;


namespace Perfect.Dictionary
{
    public partial class xfmCustomersImport : DevExpress.XtraEditors.XtraForm
    {

        bool Check = false;
        public delegate void ItemCheckingEventHander(object sender, int position, string errorText, int number, string description);

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


        public xfmCustomersImport()
        {
            InitializeComponent();
            //btnBrowse.Visible = true;
            //lcBar.Visibility = true;

            //btnCheck.Visible = true;
            ItemChecking += new ItemCheckingEventHander(xfmItemImport_ItemChecking);
            ItemChecked += new ItemCheckedEventHander(xfmItemImport_ItemChecked);
        }



        void xfmItemImport_ItemChecked(object sender)
        {
            if (this.BarCheck.InvokeRequired)
            {
                ItemCheckedEventHander myRestore = new ItemCheckedEventHander(this.xfmItemImport_ItemChecked);
                this.Invoke(myRestore, new object[] { sender });
            }
            else
            {
                Check = true;
                wpCheck.AllowNext = true;
                wpCheck.AllowBack = true;
                BarCheck.Position = 0;
                lcCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                wpFinish.AllowNext = true;
                wpFinish.AllowBack = true;
                wpFinish.AllowCancel = true;
                finish = true;
                BarFinish.Position = 0;
                lcBarFinish.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        void xfmItemImport_ItemChecking(object sender, int position, string errorText, int number, string description)
        {
            if (this.BarCheck.InvokeRequired)
            {
                ItemCheckingEventHander myRestore = new ItemCheckingEventHander(this.xfmItemImport_ItemChecking);
                this.Invoke(myRestore, new object[] { sender, position, errorText, number, description });
            }
            else
            {
                BarCheck.Position = (int)((double)position / (double)gbList.RowCount * 100);
                BarFinish.Position = BarCheck.Position;



                if (errorText == "OK")
                {
                    success++;
                    gbList.SetRowCellValue(position, "Error", 0);
                    gbList.UpdateCurrentRow();
                }
                else
                {
                    finish = true;
                    if (number == 1)
                    {
                        fail++;
                    }
                    else
                    {
                        warning++;
                    }

                    dsError.ERROR.AddERRORRow(errorText, "Dòng bị lỗi thứ " + position, description, number);
                    gbList.SetRowCellValue(position, "Error", number);
                    gbList.UpdateCurrentRow();
                }
                lblSuccess.Text = "Thành Công: " + success;
                lblFail.Text = "Thất Bại: " + fail;
                lblWarning.Text = "Cảnh Báo: " + warning;
                lblSuccess1.Text = "Thành Công: " + success;
                lblFail1.Text = "Thất Bại: " + fail;
            }
        }



        void ReadData()
        {

            //this.Enabled = false;
            ExcelDataReader ExcelDataReader = new ExcelDataReader(txtPath.Text);
            ExcelDataReader.ExcelReaderComplete += new ExcelDataReader.ExcelReaderCompleteEventHander(ExcelDataReader_ExcelReaderComplete);
            ExcelDataReader.ExcelReaderError += new ExcelDataReader.ExcelReaderErrorEventHander(ExcelDataReader_ExcelReaderError);
            ExcelDataReader.ExcelReaderProcess += new ExcelDataReader.ExcelReaderProcessEventHander(ExcelDataReader_ExcelReaderProcess);
            ExcelDataReader.BusyStarted += new ExcelDataReader.BusyStartedEventHander(ExcelDataReader_BusyStarted);
            ExcelDataReader.BusyFinish += new ExcelDataReader.BusyFinishEventHander(ExcelDataReader_BusyFinish);

            Thread Thread = new Thread(delegate() { ExcelDataReader.ExcelReadByADO(txtPath.Text, lsSheet.SelectedItem.ToString()); });
            Thread.Start();

        }

        void ExcelDataReader_BusyFinish(object sender)
        {
            if (this.Bar2.InvokeRequired)
            {
                ExcelDataReader.BusyFinishEventHander myRestore = new ExcelDataReader.BusyFinishEventHander(this.ExcelDataReader_BusyFinish);
                this.Invoke(myRestore, new object[] { sender });
            }
            else
            {
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lcBar2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        void ExcelDataReader_BusyStarted(object sender)
        {
            if (this.Bar.InvokeRequired)
            {
                ExcelDataReader.BusyStartedEventHander myRestore = new ExcelDataReader.BusyStartedEventHander(this.ExcelDataReader_BusyStarted);
                this.Invoke(myRestore, new object[] { sender });
            }
            else
            {
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lcBar2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        void ExcelDataReader_ExcelReaderProcess(object sender, int Position)
        {
            if (this.Bar.InvokeRequired)
            {
                ExcelDataReader.ExcelReaderProcessEventHander myRestore = new ExcelDataReader.ExcelReaderProcessEventHander(this.ExcelDataReader_ExcelReaderProcess);
                this.Invoke(myRestore, new object[] { sender, Position });
            }
            else
            {
                Bar.Position = Position;
            }
        }

        void ExcelDataReader_ExcelReaderError(object sender, string Message)
        {
            if (this.Bar.InvokeRequired)
            {
                ExcelDataReader.ExcelReaderErrorEventHander myRestore = new ExcelDataReader.ExcelReaderErrorEventHander(this.ExcelDataReader_ExcelReaderError);
                this.Invoke(myRestore, new object[] { sender, Message });
            }
            else
            {
                //btnBrowse.Enabled = true;
                //  this.Enabled = true;
                XtraMessageBox.Show("Lỗi:\n\t" + Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        void ExcelDataReader_ExcelReaderComplete(object sender, DataTable dt)
        {
            if (this.Bar.InvokeRequired)
            {
                ExcelDataReader.ExcelReaderCompleteEventHander myRestore = new ExcelDataReader.ExcelReaderCompleteEventHander(this.ExcelDataReader_ExcelReaderComplete);
                this.Invoke(myRestore, new object[] { sender, dt });
            }
            else
            {
               // FileStream stream = File.Open(txtPath.Text, FileMode.Open, FileAccess.Read);

               // //1. Reading from a binary Excel file ('97-2003 format; *.xls)
               // IExcelDataReader excelReader2 = ExcelReaderFactory.CreateBinaryReader(stream);
               // //...
               // //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
               //// IExcelDataReader excelReader2 = ExcelReaderFactory.CreateOpenXmlReader(stream);
               // //...
               // //3. DataSet - The result of each spreadsheet will be created in the result.Tables
               // // DataSet result = excelReader2.AsDataSet();
               // //...
               // //4. DataSet - Create column names from first row
               // excelReader2.IsFirstRowAsColumnNames = true;
               // DataSet result = excelReader2.AsDataSet();
               // gcList.DataSource = result.Tables[lsSheet.SelectedItem.ToString()].DefaultView;

               // //6. Free resources (IExcelDataReader is IDisposable)
               // excelReader2.Close();


                dsCustomersImports.CUSTOMER.Clear();
                dsCustomersImports.CUSTOMER.AddCUSTOMERRow("<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                           "<Không Chọn>");


                rpColumns.Items.Clear();
                rpColumns.Items.Add("<Không Chọn>");
                // rpColumns.Items.Add("<Tự Động>");
                if (dt != null)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        rpColumns.Items.Add(dt.Columns[i].Caption);

                        string temp = dt.Columns[i].Caption.ToLower();

                        if (dt.Columns[i].Caption.ToLower().IndexOf("mã khách hàng") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Customer_ID"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("tên khách hàng") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["CustomerName"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("địa chỉ") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["CustomerAddress"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("điện thoại") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Tel"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("chức vụ") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Position"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "fax")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Fax"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("thuế") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Tax"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "mobile")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Mobile"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "di động")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Mobile"] = dt.Columns[i].Caption;
                        }

                        else if (dt.Columns[i].Caption.ToLower() == "email")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Email"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "website")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Website"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "ghi chú")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Description"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "diễn giải")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Description"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("tài khoản") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["BankAccount"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("ngân hàng") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["BankName"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("hạn nợ") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["CreditLimit"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("khuyễn mãi") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Discount"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("chiết khấu") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Discount"] = dt.Columns[i].Caption;
                        }

                        else if (dt.Columns[i].Caption.ToLower().IndexOf("sky") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["NickSky"] = dt.Columns[i].Caption;
                        }

                        else if (dt.Columns[i].Caption.ToLower().IndexOf("ym") != -1)
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["NickYM"] = dt.Columns[i].Caption;
                        }

                        else if (dt.Columns[i].Caption.ToLower() == "barcode")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Barcode"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "kích hoạt")
                        {
                            dsCustomersImports.CUSTOMER.Rows[0]["Active"] = dt.Columns[i].Caption;
                        }
                    }
                    gcList.DataSource = dt;
                    gbList.Columns["Chọn"].VisibleIndex = 0;
                    gbList.Columns["Error"].Visible = false;
                    gbList.Columns["ErrorText"].Visible = false;

                }
                // btnBrowse.Enabled = true;
                //Product_Init(gbList);                              
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
        }
        

        private void wcImport_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            if (e.Page == wpinput)
            {
                //lblMessage.Text = "Chọn tập tin nguồn";
            }
            else if (e.Page == wpBrowse)
            {
                // lblMessage.Text = "Danh sách dữ liệu trước nhập khẩu.";

                FileInfo fi = new FileInfo(txtPath.Text);
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
                //lblMessage.Text = "Ghép trường dữ liệu.";
                //  MessageBox.Show("OK");
            }
            else if (e.Page == wpCheck)
            {
                //lblMessage.Text = "Kiểm tra dữ liệu.";
                if (Check) return;

                bool error = false;
                string temp;

                temp = gbColMerge.GetCellDisplayText(rowCustomer_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    //XtraMessageBox.Show("Vui lòng ghép trường cho nhóm hàng", "Thông báo", MessageBoxButtons.OK,
                    //                  MessageBoxIcon.Warning);
                    wcImport.SelectedPage = wpCelMerge;
                    error = true;
                    gbColMerge.SetRowError(rowCustomer_ID.Properties, "Vui lòng ghép trường cho mã khách hàng");
                    //return;
                }

                temp = gbColMerge.GetCellDisplayText(rowCustomerName, 0);
                if (temp == "<Không Chọn>")
                {
                    //XtraMessageBox.Show("Vui lòng ghép trường cho nhóm hàng", "Thông báo", MessageBoxButtons.OK,
                    //                  MessageBoxIcon.Warning);
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowCustomerName.Properties, "Vui lòng ghép trường cho tên khách hàng");
                    error = true;
                    //return;
                }


                if (error)
                {
                    XtraMessageBox.Show("Vui lòng ghép trường", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;

                }

                lblTotal.Text = "Tổng cộng: " + gbList.RowCount;
                fail = 0;
                success = 0;
                wpCheck.AllowNext = false;
                wpCheck.AllowBack = false;
                lcCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                Thread thread = new Thread(new ThreadStart(ExecuteCheck));
                thread.Start();

            }
            else if (e.Page == wpFinish)
            {
                //lblMessage.Text = "Nhập dữ liệu.";
                Check = true;
                lblTotal.Text = "Tổng cộng: " + gbList.RowCount;
                lblTotal1.Text = "Tổng cộng: " + gbList.RowCount;
                fail = 0;
                success = 0;
                warning = 0;
                wpFinish.AllowNext = false;
                wpFinish.AllowBack = false;
                wpFinish.AllowCancel = false;
                finish = false;

                lcBarFinish.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                dsError.ERROR.Rows.Clear();
                Thread thread = new Thread(new ThreadStart(Execute));
                thread.Start();

            }
            else
            {
                lcBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lcBar2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private int fail = 0;
        private int success = 0;
        private int warning = 0;


        void Execute()
        {
            string result = "";
            DataTable dt = (DataTable)gcList.DataSource;

            if (dt != null)
            {
                CUSTOMER customer = new CUSTOMER();
                SqlHelper mySql = new SqlHelper();
                string temp;
                object ob;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;

                    if (Convert.ToInt32(dt.Rows[i]["Error"] == DBNull.Value ? 0 : dt.Rows[i]["Error"]) == 1) continue;

                    bool _exist = false;
                    result = mySql.Start();
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
                            if (rgOption.SelectedIndex == 0)
                            {
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {

                                if (customer.Get(mySql.Transaction, temp) == "OK")
                                {
                                    temp = customer.Customer_ID;
                                    _exist = true;
                                }


                            }
                            else
                            {
                                //if (customer.Exist(mySql.Transaction, temp))
                                {
                                    RaiseItemCheckingEventHander(i, "Khách Hàng đã tồn tại.", 1, temp);
                                    mySql.RollBack();
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Khách Hàng chưa xác định.", 1, temp);
                        mySql.RollBack();
                        continue;
                    }

                    if (temp == "")
                    {
                        RaiseItemCheckingEventHander(i, "Khách Hàng chưa xác định.", 1, temp);
                        mySql.RollBack();
                        continue;
                    }

                    customer.Customer_ID = temp;

                    temp = gbColMerge.GetCellDisplayText(rowCustomerName, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.CustomerName = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Khách Hàng chưa rõ tên.", 1, temp);
                        mySql.RollBack();
                        continue;
                    }

                    //temp = gbColMerge.GetCellDisplayText(rowActive, 0);

                    customer.Active = true; //Convert.ToBoolean((temp == "<Không Chọn>" | temp=="Checked")
                    //          ? true
                    //          : dt.Rows[i][gbColMerge.GetCellDisplayText(rowActive, 0)]);


                    temp = gbColMerge.GetCellDisplayText(rowContact, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Contact = ob == DBNull.Value ? "" : ob.ToString();
                    }


                    temp = gbColMerge.GetCellDisplayText(rowPosition, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Position = ob == DBNull.Value ? "" : ob.ToString();

                    }

                    temp = gbColMerge.GetCellDisplayText(rowCustomerAddress, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.CustomerAddress = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowTel, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Tel = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowFax, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Fax = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowTax, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Tax = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowMobile, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Mobile = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = gbColMerge.GetCellDisplayText(rowEmail, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Email = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowWebsite, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Website = ob == DBNull.Value ? "" : ob.ToString();

                    }

                    temp = gbColMerge.GetCellDisplayText(rowDescription, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Description = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowBarcode, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Barcode = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowBankAccount, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.BankAccount = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowBankName, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.BankName = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowCreditLimit, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.CreditLimit = Microsoft.VisualBasic.Conversion.Val(ob);
                    }

                    temp = gbColMerge.GetCellDisplayText(rowDiscount, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Discount = Microsoft.VisualBasic.Conversion.Val(ob);
                    }

                    temp = gbColMerge.GetCellDisplayText(rowNickYM, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.NickYM = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = gbColMerge.GetCellDisplayText(rowNickSky, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.NickSky = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = gbColMerge.GetCellDisplayText(rowCustomer_Group_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.BankAccount = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    else
                    {
                        customer.Customer_Group_ID = "MD";
                    }


                    if (_exist)
                    {
                        result = customer.Update(mySql.Transaction);
                    }
                    else
                    {
                        result = customer.Insert(mySql.Transaction);
                    }
                    if (result == "OK")
                    {
                        mySql.Commit();
                        RaiseItemCheckingEventHander(i, result, 0, "Khách Hàng " + customer.CustomerName + " đã được thêm");
                    }
                    else
                    {
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(i, result, 1, "Không thực hiện được");
                    }

                }

                //mySql.RollBack();
                //RaiseItemCheckingEventHander(0, "");
                RaiseItemCheckedEventHander();
            }
            //return false;
        }

        void ExecuteCheck()
        {
            string result = "";
            DataTable dt = (DataTable)gcList.DataSource;

            if (dt != null)
            {
                CUSTOMER product = new CUSTOMER();
                string temp;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ////temp = gbColMerge.GetCellDisplayText(rowCustomer_ID, 0);
                    ////if (temp != "<Không Chọn>")
                    ////{
                    ////    temp = dt.Rows[i][gbColMerge.GetCellDisplayText(rowCustomer_ID, 0)].
                    ////        ToString();
                    ////    PROVIDER provider = new PROVIDER();
                    ////    if (provider.GetByName(temp) == "OK")
                    ////    {
                    ////        product.Customer_ID = provider.Customer_ID;
                    ////    }
                    ////}
                    //if (CODE.TypeSoft < 2)
                    //{
                    //    if (i > 10)
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Hãy Mua Bản Thu Phí.", 5,
                    //                                     "Số Lượng vượt quá mức dành cho bản miễn phí.");
                    //        continue;
                    //    }
                    //}

                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;



                    object ob = dt.Rows[i][gbColMerge.GetCellDisplayText(rowCustomer_ID, 0)];
                    temp = ob == DBNull.Value ? "" : ob.ToString();
                    if (product.Exist(temp))
                    {
                        RaiseItemCheckingEventHander(i, "Khách Hàng đã tồn tại.", 2, temp);
                        continue;
                    }

                    ob = dt.Rows[i][gbColMerge.GetCellDisplayText(rowCustomerName, 0)];
                    temp = ob == DBNull.Value ? "" : ob.ToString();
                    if (temp.Trim() == "")
                    {
                        RaiseItemCheckingEventHander(i, "Khách hàng này không có tên.", 1, temp);
                    }


                    //RaiseItemCheckingEventHander(i, result);

                }

                RaiseItemCheckedEventHander();

            }
            //return false;
        }

        private void wcImport_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {

            //if (e.Page == wpBrowse)
            //{

            //    if (!Check)
            //    {
            //        XtraMessageBox.Show("Error:\n\tPlease check data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        wcImport.SetPreviousPage();
            //        return;
            //    }

            //    #region Product
            //    PRODUCT PRO = new PRODUCT();
            //    string Result = "";

            //    lcBar.Visibility = true;
            //    int row = 0;
            //    while (row < gbList.RowCount)
            //    {
            //        Bar.Position += row / gbList.RowCount;


            //        Result = PRO.Insert
            //            (gbList.GetRowCellValue(row, gbList.Columns["Product_ID"]).ToString(), //ID
            //            gbList.GetRowCellValue(row, gbList.Columns["Product_Name"]).ToString(), //Name
            //            0, //Type
            //            0,
            //            "HH", //Group
            //            "",
            //            gbList.GetRowCellValue(row, gbList.Columns["Origin"]).ToString(), //Origin
            //            gbList.GetRowCellValue(row, gbList.Columns["Barcode"]).ToString(), //Barcode                            
            //            gbList.GetRowCellValue(row, gbList.Columns["Unit"]).ToString(),
            //            gbList.GetRowCellValue(row, gbList.Columns["Unit"]).ToString(),
            //            1.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0, //warranty
            //           -1, //Vat_ID
            //            0,
            //            0,
            //            0,
            //            "",
            //            "",
            //            0,
            //            Convert.ToDouble(gbList.GetRowCellValue(row, gbList.Columns["MinStock"])),//min
            //            Convert.ToDouble(gbList.GetRowCellValue(row, gbList.Columns["MaxStock"])),//max
            //            0,
            //            0,
            //            "",
            //            "",
            //            false,
            //            0,
            //            0,
            //            false, //Convert.ToBoolean(gbList.GetRowCellValue(row, gbList.Columns[12])),
            //            0,
            //            0,
            //            0,
            //            0,
            //            gbList.GetRowCellValue(row, gbList.Columns["Size"]).ToString(),
            //            MyLogin.UserId,
            //            true
            //           );

            //        if (Result == "OK")
            //        {
            //            gbList.DeleteRow(row);
            //            continue;
            //        }


            //        row++;
            //    }
            //    #endregion


            //    lcBar.Visibility = false;
            //}
        }

        //private void btnCheck_Click(object sender, EventArgs e)
        //{
        //    Check = true;
        //    lcBar.Visibility = true;

        //    #region Check Product
        //    for (int i = 0; i < gbList.RowCount; i++)
        //    {
        //        Bar.Position = (i / gbList.RowCount * 100);

        //        object Arg = gbList.GetRowCellValue(i, gbList.Columns["Product_Name"]);
        //        if (Arg == null)
        //        {
        //            gbList.DeleteRow(i);
        //            continue;
        //        }
        //        else if (Arg.ToString() == "")
        //        {
        //            gbList.DeleteRow(i);
        //        }

        //        Arg = gbList.GetRowCellValue(i, gbList.Columns["Product_ID"]);
        //        if (Arg == null)
        //        {
        //            gbList.DeleteRow(i);
        //            continue;
        //        }
        //        else if (Arg.ToString() == "")
        //        {
        //            gbList.DeleteRow(i);
        //        }




        //    }
        //    #endregion

        //    lcBar.Visibility = false;
        //}

        private void xfmItemImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFormatChose.PRODUCT' table. You can move, or remove it, as needed.
            // this.pRODUCTTableAdapter.Fill(this.dsFormatChose.PRODUCT);
            //// TODO: This line of code loads data into the 'dsProduct.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.dsProduct.PRODUCT);
            //// TODO: This line of code loads data into the 'dsProductGroup.PRODUCT_GROUP' table. You can move, or remove it, as needed.
            //this.pRODUCT_GROUPTableAdapter.Fill(this.dsProductGroup.PRODUCT_GROUP);

        }

        private bool finish = true;

        private void wcImport_FinishClick(object sender, CancelEventArgs e)
        {
            if (!finish) return;
            Close();
        }

        private bool cancel = false;

        private void wcImport_CancelClick(object sender, CancelEventArgs e)
        {
            //Close();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //  btnOpen.Enabled = false;
            wpinput.AllowNext = false;
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Microsoft Excel File(*.xls)|*.xls|All File(*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                lsSheet.Items.Clear();
                txtPath.Text = OpenFileDialog.FileName;
                ExcelDataReader ExcelDataReader = new ExcelDataReader(OpenFileDialog.FileName);
                DataTable dt = ExcelDataReader.GetExcelSheetNames(OpenFileDialog.FileName);

                if (dt != null)
                {
                    string temp;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        temp = (dt.Rows[i]["TABLE_NAME"] ?? "") as string;
                        if (temp != "")
                        {
                            temp = temp.Substring(0, temp.Length - 1);
                            lsSheet.Items.Add(temp);
                        }
                    }
                }

            }
            // btnOpen.Enabled = true;
        }

        private void lsSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsSheet.SelectedIndex == -1) return;
            wpinput.AllowNext = true;
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void chxAll_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            //Bar.Properties.Maximum = dt.Rows.Count;

            while (i < gbList.RowCount)
            {
                gbList.SetRowCellValue(i, "Chọn", chxAll.Checked);
                gbList.SetRowCellValue(i, "Error", 0);
                i++;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)gcList.DataSource;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                rpColumns.Items.Add(dt.Columns[i].Caption);

                string temp = dt.Columns[i].Caption.ToLower();

                if (dt.Columns[i].Caption.ToLower().IndexOf("mã khách hàng") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Customer_ID"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("tên khách hàng") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["CustomerName"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("địa chỉ") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["CustomerAddress"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("điện thoại") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Tel"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("chức vụ") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Position"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "fax")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Fax"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("thuế") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Tax"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "mobile")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Mobile"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "di động")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Mobile"] = dt.Columns[i].Caption;
                }

                else if (dt.Columns[i].Caption.ToLower() == "email")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Email"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "website")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Website"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "ghi chú")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Description"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "diễn giải")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Description"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("tài khoản") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["BankAccount"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("ngân hàng") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["BankName"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("hạn nợ") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["CreditLimit"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("khuyễn mãi") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Discount"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("chiết khấu") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Discount"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("sky") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["NickSky"] = dt.Columns[i].Caption;
                }

                else if (dt.Columns[i].Caption.ToLower().IndexOf("ym") != -1)
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["NickYM"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "barcode")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Barcode"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "kích hoạt")
                {
                    dsCustomersImports.CUSTOMER.Rows[0]["Active"] = dt.Columns[i].Caption;
                }

            }
            // gcList.DataSource = dt;
            // gbList.Columns["Chọn"].ColVIndex = 0;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsCustomersImports.CUSTOMER.Columns.Count; i++)
            {
                dsCustomersImports.CUSTOMER.Rows[0][i] = "<Không Chọn>";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "Map file (*.map)|*.map|All File(*.*)|*.*";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsCustomersImports.CUSTOMER.WriteXml(SaveFileDialog.FileName);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Lỗi:\n\tKhông lưu được sơ đồ ghép.", "Thông báo", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                }
            }
        }

        private void btnOpenMerge_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Map file (*.map)|*.map|All File(*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsCustomersImports.CUSTOMER.Rows.Clear();
                    dsCustomersImports.CUSTOMER.ReadXml(OpenFileDialog.FileName);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Lỗi:\n\tKhông mở được sơ đồ ghép.", "Thông báo", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                }
            }
        }

        private void gbColMerge_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            if (e.Row == rowCustomer_ID)
            {
                gbColMerge.SetRowError(rowCustomer_ID.Properties, null);
            }
            else if (e.Row == rowCustomerName)
            {
                gbColMerge.SetRowError(rowCustomerName.Properties, null);
            }
            else
            {
                gbColMerge.ClearRowErrors();
            }
        }

        private void xfmItemImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !finish;
        }

        private void txtPath_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            wpinput.AllowNext = false;
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Microsoft Excel File(*.xls)|*.xls|All File(*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                lsSheet.Items.Clear();
                txtPath.Text = OpenFileDialog.FileName;
                ExcelDataReader ExcelDataReader = new ExcelDataReader(OpenFileDialog.FileName);
                DataTable dt = ExcelDataReader.GetExcelSheetNames(OpenFileDialog.FileName);

                if (dt != null)
                {
                    string temp;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        temp = (dt.Rows[i]["TABLE_NAME"] ?? "") as string;
                        if (temp != "")
                        {
                            temp = temp.Substring(0, temp.Length - 1);
                            lsSheet.Items.Add(temp);
                        }
                    }
                }

            }


           

            Cursor.Current = Cursors.Default;
        }

        private void txtPath_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}