using System;
using System.Data;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Security;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using Exxcel = Microsoft.Office.Interop.Excel;

namespace Perfect.Inventory.Core.Inventory.Import
{
    public partial class XfmImport : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemCheckingEventHander(
            object sender, int position, string errorText, int number, string description);

        public event ItemCheckingEventHander ItemChecking;
        private string _stock;

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

        public XfmImport()
        {
            InitializeComponent();
            dsImports.COLUMNS.AddCOLUMNSRow("<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                            "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                            "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                            "<Không Chọn>", "<Không Chọn>");
        }

        private void ButtonEdit1PropertiesButtonClick(object sender,
                                                      DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var openfiledialog = new OpenFileDialog
                                         {
                                             Filter = @"Microsoft Excel File(*.xls)|*.xls|All File(*.*)|*.*"
                                         };
                switch (openfiledialog.ShowDialog())
                {
                    case DialogResult.OK:
                        {
                            lbcSheet.Items.Clear();
                            btePath.Text = openfiledialog.FileName;
                            var exceldatareader = new ExcelDataReader(openfiledialog.FileName);
                            var dt = exceldatareader.GetExcelSheetNames(openfiledialog.FileName);
                            if (dt != null)
                            {
                                string temp;
                                for (var i = 0; i < dt.Rows.Count; i++)
                                {
                                    temp = (dt.Rows[i]["TABLE_NAME"] ?? "") as string;
                                    if (temp == "") continue;
                                    if (temp != null) temp = temp.Substring(0, temp.Length - 1);
                                    lbcSheet.Items.Add(temp);
                                }
                            }
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show(@"Không Thực Hiện Được ");
            }
        }

        private static DataTable GetSheetData(string excelFile, string sheetname)
        {
            var srcConnString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile +
                                @";Extended Properties=""Excel 8.0;HDR=YES;""";
            var srcQuery = "Select * from [" + sheetname + "$]";
            var srcConn = new OleDbConnection(srcConnString);
            srcConn.Open();
            var objCmdSelect = new OleDbCommand(srcQuery, srcConn);
            var ds = new DataSet();
            var da = new OleDbDataAdapter(objCmdSelect);
            da.Fill(ds, sheetname);
            srcConn.Close();
            return ds.Tables[0];
        }

        private DataTable _tablesheet;

        private DataTable Gettable()
        {
            try
            {
                _tablesheet = GetSheetData(btePath.Text, lbcSheet.SelectedValue.ToString());
                _tablesheet.Columns.Add("colOption", typeof (Boolean));
            }
            catch
            {
                MessageBox.Show(@"Không Thực Hiện Được");
            }
            return _tablesheet;
        }

        private void LbcSheetSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbcSheet.SelectedIndex == -1) return;
            wzpage_OpenFile.AllowNext = true;
        }

        private void WizardImportSelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            wzpage_MergeColumn.Visible = false;
            if (e.Page == wzpage_MergeColumn)
            {
                if (radioOptionList.SelectedIndex == 7)
                {
                    VGrid();
                    wzpage_Check.AllowNext = false;
                }
                checkEdit1.Visible = false;
            }
            if (e.Page == wzpage_ShowDataExcel)
            {
                gbList.Columns.Clear();
                //if ((radioOptionList.SelectedIndex == 4)||(radioOptionList.SelectedIndex ==6))
                //{
                //    gcList.DataSource = tablecustomer();
                //    createcombobox();
                //}
                //else 
                gcList.DataSource = Gettable();
                checkEdit1.Visible = true;
                if (radioOptionList.SelectedIndex != 7)
                {
                    wzpage_Check.Visible = false;
                }
                if (radioOptionList.SelectedIndex == 6)
                {
                    //cbxProductType.Visible = true;
                    //labelControl5.Visible = true;
                }
                List_Init(gbList);
            }
            if (e.Page == wzpage_Option)
            {
                wzpage_OpenFile.AllowNext = false;
                checkEdit1.Visible = false;
            }
            if (e.Page == wzpage_Check)
            {
                if (radioOptionList.SelectedIndex == 7)
                {
                    Checkdataimport();
                    wzpa_Result.AllowNext = false;
                }
            }
            if (e.Page == wzpage_OpenFile)
            {
                cbxProductType.Visible = false;
                labelControl5.Visible = false;
            }
            if (e.Page == wzpa_Result)
            {
                if (radioOptionList.SelectedIndex == 7)
                    Excecute();
                if (radioOptionList.SelectedIndex == 3)
                    ExecuteProduct_Group();
                if (radioOptionList.SelectedIndex == 4)
                    ExecuteStock();
                if (radioOptionList.SelectedIndex == 5)
                    ExecuteUnit();
                if (radioOptionList.SelectedIndex == 6)
                    ExecuteProduct();
                if (radioOptionList.SelectedIndex == 1)
                    ExecuteCustomer();
                if (radioOptionList.SelectedIndex == 2)
                    ExecuteProvider();
                if (radioOptionList.SelectedIndex == 0)
                    ExecuteArea();
                checkEdit1.Visible = false;
            }
            if (e.Page != wxpage_Complete) return;
            var dt = new DataTable();
            gcList.DataSource = dt;
        }

        private void VGrid()
        {
            var dt = Gettable();
            repositoryItemComboBox1.Properties.Items.Add("<Không Chọn>");
            if (dt == null) return;
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                repositoryItemComboBox1.Properties.Items.Add(dt.Columns[i].Caption);
                if (dt.Columns[i].Caption.ToLower().IndexOf("mã") != -1) //tim thay chu "mã"
                {
                    dsImports.COLUMNS.Rows[0]["Product_ID"] = dt.Columns[i].Caption;
                        //them du lieu vao dong 0 cot Product_Id
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("tên") != -1)
                {
                    dsImports.COLUMNS.Rows[0]["Product_Name"] = dt.Columns[i].Caption;
                }
                else
                    switch (dt.Columns[i].Caption.ToLower())
                    {
                        case "đơn vị":
                            dsImports.COLUMNS.Rows[0]["Unit"] = dt.Columns[i].Caption;
                            break;
                        case "số lượng":
                            dsImports.COLUMNS.Rows[0]["Quantity"] = dt.Columns[i].Caption;
                            break;
                        case "đơn giá":
                            dsImports.COLUMNS.Rows[0]["UnitPrice"] = dt.Columns[i].Caption;
                            break;
                        case "thành tiền":
                            dsImports.COLUMNS.Rows[0]["Amount"] = dt.Columns[i].Caption;
                            break;
                        case "Hạn Sử Dụng":
                            dsImports.COLUMNS.Rows[0]["Limit"] = dt.Columns[i].Caption;
                            break;
                        case "lô":
                            dsImports.COLUMNS.Rows[0]["Batch"] = dt.Columns[i].Caption;
                            break;
                        case "Serial":
                            dsImports.COLUMNS.Rows[0]["Serial"] = dt.Columns[i].Caption;
                            break;
                        case "kho":
                            dsImports.COLUMNS.Rows[0]["Stock_ID"] = dt.Columns[i].Caption;
                            break;
                    }
            }
        }

        private void XfmImportLoad(object sender, EventArgs e)
        {
        }

        private void CheckEdit1CheckedChanged(object sender, EventArgs e)
        {
            var dt = Gettable();
            if (checkEdit1.Checked) //chon tất cả
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["colOption"] = true;
                }
                gcList.DataSource = dt;
            }
            else
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["colOption"] = false;
                }
                gcList.DataSource = dt;
            }
        }

        private void Checkdataimport()
        {
            var dt = (DataTable) gcList.DataSource;
            if (dt == null) return;
            listFail.Items.Clear();
            listwar.Items.Clear();
            var product = new PRODUCT();
            var unit = new UNIT();
            var stock = new STOCK();
            gridControl1.DataSource = gcList.DataSource;
            string temp;
            var errorstock = 0;
            var errorsunit = 0;
            var errorproductId = 0;
            var s = 0;
            var fail = 0;
            try
            {
                #region

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var fai = "";
                    var error = string.Empty;
                    var row = dt.Rows[i];
                    if ((DBNull.Value.Equals(row["colOption"])) || (row["colOption"].ToString() == false.ToString()))
                        continue;
                    temp = vGridControl4.GetCellDisplayText(colProduct_Id, 0);
                    string ob;
                    if (temp != "<Không Chọn>")
                    {
                        gridControl1.DataSource = dt;
                        ob = dt.Rows[i][temp].ToString();
                        if (temp.Trim() == "")
                        {
                            error = " Mã Hàng Hóa Chưa Biết.";
                        }
                        if (!product.Exist(ob))
                        {
                            fail = fail + 1;
                            fai += " Mã Hàng Hóa " + ob + " Không Tồn Tại.";
                        }
                    }
                    else
                    {
                        errorproductId = 1;
                    }
                    temp = vGridControl4.GetCellDisplayText(colStock_Id, 0);
                    if (temp != "<Không Chọn>")
                    {
                        gridControl1.DataSource = dt;
                        ob = dt.Rows[i][temp].ToString();
                        if (temp.Trim() == "")
                        {
                            error += " Tên Kho Chưa Biết .";
                        }
                        if (!stock.ExistByName(ob))
                        {
                            fai += " Tên Kho Không Tồn Tại .";
                            fail = fail + 1;
                        }
                    }
                    else
                    {
                        errorstock = 1;
                    }
                    temp = vGridControl4.GetCellDisplayText(colUnit_Id, 0);
                    if (temp != "<Không Chọn>")
                    {
                        gridControl1.DataSource = dt;
                        ob = dt.Rows[i][temp].ToString();

                        if (temp.Trim() == "")
                        {
                            error += " Tên Đơn Vị Chưa Biết .";
                        }
                        if (!unit.ExistByName(ob))
                        {
                            fai += " Tên Đơn Vị Không Tồn Tại .";
                            fail = fail + 1;
                        }
                    }
                    else
                    {
                        errorsunit = 1;
                    }
                    temp = vGridControl4.GetCellDisplayText(colQuantity, 0);
                    if (temp != "<Không Chọn>")
                    {
                        if (dt.Rows[i][temp].ToString().Trim() == "")
                        {
                            fai += " Chưa Có Số Lượng ";
                        }
                        else
                        {
                            if (!MyLib.IsNumeric(dt.Rows[i][temp]))
                            {
                                fai += " Số Lượng Không Phải Là Số. ";
                                fail = fail + 1;
                            }
                        }
                    }
                    temp = vGridControl4.GetCellDisplayText(colUnitPrice, 0);
                    if (temp != "<Không Chọn>")
                    {
                        if (dt.Rows[i][temp].ToString().Trim() == "")
                        {
                            error += " Chưa Có Đơn Gía. ";
                        }
                        else
                        {
                            if (!MyLib.IsNumeric(dt.Rows[i][temp]))
                            {
                                fai += " Đơn Giá Không Phải Là Số. ";
                                fail = fail + 1;
                            }
                        }
                    }
                    temp = vGridControl4.GetCellDisplayText(colAmount, 0);
                    if (temp != "<Không Chọn>")
                    {
                        if (!MyLib.IsNumeric(dt.Rows[i][temp]))
                        {
                            fai += " Thành Tiền Không Phải Là Số. ";
                            fail = fail + 1;
                        }
                    }
                    temp = vGridControl4.GetCellDisplayText(colLimit, 0);
                    if (temp != "<Không Chọn>")
                    {
                        if (dt.Rows[i][temp].ToString().Trim() == "")
                        {
                            error += " Chưa Có Hạn Sử Dụng. ";
                        }
                        //else
                        //{
                        //    if (!Information.IsDate(temp))
                        //    {
                        //        fai += " Hạn sử dụng không đúng. ";
                        //        fail = fail + 1;
                        //    }
                        //}
                    }
                    if (error != "")
                    {
                        listwar.Items.Add(" Cảnh Báo Tại Dòng Thứ " + i + " : " + error);
                        s = s + 1;
                    }
                    if (fai != "")
                    {
                        listFail.Items.Add("  Dòng Thứ " + i + " : " + fai);
                    }
                } //het for

                #endregion
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            if (errorproductId == 1)
            {
                listFail.Items.Add(" Lổi Chưa Ghép Cột Mã Hàng Hóa ");
                fail = fail + 1;
            }
            if (errorstock == 1)
            {
                listFail.Items.Add(" Lổi Ghưa Ghép Cột Mã Kho ");
                fail = fail + 1;
            }
            if (errorsunit == 1)
            {
                listFail.Items.Add(" Lổi Chưa Ghép Cột Tên Đơn Vị ");

                fail = fail + 1;
            }
            if (errorproductId != 1 && errorstock != 1 && errorsunit != 1)
            {
                wzpage_Check.AllowNext = true;
            }
            xtpageFail.Text = fail + @" Lổi  ";
            xtraTabPage4.Text = s + @" Cảnh Báo  ";

            if (fail == 0)
            {
                wzpage_MergeColumn.AllowNext = true;
            }
            if (fail > 0 || s > 0)
            {
                wzpage_Check.AllowNext = false;
            }
        }

        private void Excecute()
        {
            wzpa_Result.AllowNext = false;
            var dt = (DataTable) gcList.DataSource;
            if (dt == null) return;
            listDes.Items.Clear();
            var product = new PRODUCT();
            var unit = new UNIT();
            var stock = new STOCK();
            var mySql = new SqlHelper();
            object ob;
            var temp = mySql.Start();
            if (temp != "OK")
            {
                mySql.RollBack();
                RaiseItemCheckingEventHander(0, temp, 1, temp);
            }
            var cls = new STOCK_INWARD();
            string id;
            if (cls.GetInit(mySql.Transaction) == "OK")
            {
                id = cls.ID;
            }
            else
            {
                id = "DK" + string.Format("{0:ddMMyyyy}", DateTime.Now);
                if (!cls.Insert(
                    mySql.Transaction,
                    id,
                    DateTime.Now,
                    "",
                    0,
                    Guid.NewGuid().ToString(),
                    "",                    
                    DateTime.Now,
                    DateTime.Now,
                    id,
                    "",
                    "",
                    _stock,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "(Đầu Kỳ)",
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
                    "(Số Dư Đầu Kỳ)",
                    0,
                    MyLogin.UserId,
                    true))
                {
                    var result = mySql.Result;
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
                     _stock,
                     "",
                     "",
                     _stock,
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
                    return;
                }
            }
            var detail = new STOCK_INWARD_DETAIL();
            var s = 0;
            var fail = 0;
            try
            {
                #region

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var err = "";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString() == false.ToString())) continue;
                    detail.Inward_ID = id;
                    detail.RefType = cls.RefType;
                    detail.Vat = 0;
                    detail.ID = Guid.NewGuid().ToString();
                    detail.UnitConvert = 1;
                    temp = vGridControl4.GetCellDisplayText(colStock_Id, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() == "")
                        {
                            if (_stock == "All")
                            {
                                fail += 1;
                                mySql.RollBack();
                                return;
                            }
                            temp = _stock;
                            detail.Stock_ID = _stock;
                        }
                        else
                        {
                            if (stock.GetByName(mySql.Transaction, temp) != "OK")
                            {
                                fail += 1;
                                RaiseItemCheckingEventHander(i, "Kho Hàng Không Tồn Tại.", 2, temp);
                                if (_stock == "All")
                                {
                                    fail += 1;
                                    RaiseItemCheckingEventHander(i, "Kho Hàng Chưa Xác Định.", 1, temp);
                                    mySql.RollBack();
                                    return;
                                }
                                detail.Stock_ID = _stock;
                            }
                            else //nguoc lai xac dinh dc kho hang
                            {
                                _stock = stock.Stock_ID;
                                detail.Stock_ID = stock.Stock_ID;
                            }
                        }
                    }
                    else
                    {
                        if (_stock == "All")
                        {
                            fail += 1;
                            RaiseItemCheckingEventHander(i, "Kho Hàng Chưa Xác Định.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        detail.Stock_ID = _stock;
                    }
                    temp = vGridControl4.GetCellDisplayText(colProduct_Id, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() == "")
                        {
                            fail += 1;
                            RaiseItemCheckingEventHander(i, "Mã Hàng Hoá Chưa Biết.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        if (product.Get(mySql.Transaction, temp) != "OK")
                        {
                            fail += 1;
                            RaiseItemCheckingEventHander(i, "Hàng Hoá Không Tồn Tại.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        detail.Product_ID = product.Product_ID;
                        detail.ProductName = product.Product_Name;
                    }
                    else
                    {
                        fail += 1;
                        RaiseItemCheckingEventHander(i, " Cột Mã Hàng Hoá Chưa Xác Định.", 1, temp);
                        mySql.RollBack();
                        return;
                    }
                    temp = vGridControl4.GetCellDisplayText(colUnit_Id, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (temp.Trim() == "")
                        {
                            mySql.RollBack();
                            fail += 1;
                            RaiseItemCheckingEventHander(i, " Đơn Vị Chưa Xác Định. ", 1, temp);
                            return;
                        }
                        if (unit.GetByName(mySql.Transaction, temp) != "OK")
                        {
                            fail += 1;
                            RaiseItemCheckingEventHander(i, " Đơn Vị Không Tồn Tại. ", 1, temp);
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
                    temp = vGridControl4.GetCellDisplayText(colQuantity, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        if (!MyLib.IsNumeric(ob))
                        {
                            fail += 1;
                            RaiseItemCheckingEventHander(i, " Số Lượng Không Phải Là Số. ", 1, temp);
                            detail.Quantity = 0;
                            continue;
                        }
                        detail.Quantity = Convert.ToDecimal(temp);
                        if (detail.Quantity <= 0)
                        {
                            err = "Bỏ Qua Số Lượng Bằng 0.";
                            RaiseItemCheckingEventHander(i, " Bỏ Qua Số Lượng Bằng 0. ", 3, temp);
                            detail.Quantity = 0;
                            continue;
                        }
                    }
                    temp = vGridControl4.GetCellDisplayText(colUnitPrice, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        if (!MyLib.IsNumeric(ob))
                        {
                            fail += 1;
                            RaiseItemCheckingEventHander(i, "Đơn Giá Không Phải là số.", 3, temp);
                            detail.UnitPrice = 0;
                        }
                        else
                        {
                            detail.UnitPrice = Convert.ToDecimal(temp);
                        }
                    }
                    temp = vGridControl4.GetCellDisplayText(colAmount, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        if (!MyLib.IsNumeric(ob))
                        {
                            fail += 1;
                            RaiseItemCheckingEventHander(i, "Thành Tiền không phải là số.", 3, temp);
                            detail.Amount = 0;
                        }
                        else
                        {
                            detail.Amount = Convert.ToDecimal(temp);
                        }
                    }
                    temp = vGridControl4.GetCellDisplayText(colLimit, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        //if (!Information.(temp))
                        //{
                        //    fail += 1;
                        //    RaiseItemCheckingEventHander(i, "Hạn Sử Dụng không đúng.", 2, temp);
                        //    // mySql.RollBack();
                        //    // continue;
                        //    detail.Limit = MyLogin.LoginDate.AddDays(product.ExpiryValue);
                        //}
                        //else
                        //{
                        try
                        {
                            detail.Limit = Convert.ToDateTime(temp);
                        }
                        catch
                        {
                            err += " Không Đọc Được Ngày";
                        }
                        //}
                    }
                    temp = vGridControl4.GetCellDisplayText(colBatch, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        detail.Batch = temp;
                    }
                    detail.Charge = 0;
                    detail.Discount = 0;
                    detail.RefType = 0;
                    detail.UnitConvert = 1;
                    detail.Vat = 0;
                    const int compare = 0;
                    // MessageBox.Show(detail.Stock_ID.ToString());
                    var exist = detail.Exist(mySql.Transaction, detail.Stock_ID, detail.Product_ID, "",
                                             detail.Quantity, detail.Amount, compare);
                    // var exist = true;
                    if (rgOption.SelectedIndex == 0)
                    {
                        err += "Hàng Hoá " + product.Product_Name + " Đã Tồn Tại. ";
                        if (exist) continue;
                    }
                    else if (rgOption.SelectedIndex == 1)
                    {
                        if (exist)
                        {
                            if (detail.Update(mySql.Transaction))
                            {
                                temp = mySql.Result;
                                s += 1;
                                err += " Hàng Hoá " + product.Product_Name + " Đã Được Thêm";
                                RaiseItemCheckingEventHander(i, temp, 0,
                                                             "Hàng Hoá " + product.Product_Name + " Đã Được Thêm");
                            }
                            else
                            {
                                temp = mySql.Result;
                                mySql.RollBack();
                                err += "Không Thực Hiện Được";
                                RaiseItemCheckingEventHander(i, temp, 1, "Không Thực Hiện Được");
                                return;
                            }
                        }
                        else
                        {
                            if (detail.Insert(mySql.Transaction))
                            {
                                s = s + 1;
                                temp = mySql.Result;
                                err += "Hàng Hoá " + product.Product_Name + " Đã Được Thêm";
                            }
                            else
                            {
                                temp = mySql.Result;
                                mySql.RollBack();
                                err += "Không Thực Hiện Được";
                                RaiseItemCheckingEventHander(i, temp, 1, "Không Thực Hiện Được");
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (exist)
                        {
                            temp = mySql.Result;
                            mySql.RollBack();
                            err += "Hàng Này Đã Tồn Tại.";
                            RaiseItemCheckingEventHander(i, temp, 1, "Hàng này Đã Tồn Tại.");
                            return;
                        }
                    }
                    if (err != "")
                    {
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + err);
                    }
                }

                #endregion
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcsuss.Text = @"Số Dòng Dữ Liệu Được Lưu Thành Công : " + s;
            lbcFail.Text = @"Số Dòng Dữ Liệu Không Được Lưu: " + (dt.Rows.Count - s);
            if (s > 0)
            {
                wzpa_Result.AllowNext = true;
            }
            {
                mySql.Commit();
            }
        }

        private void ExecuteProduct_Group()
        {
            var dt = (DataTable) gcList.DataSource;
            if (dt == null) return;
            var productGroup = new PRODUCT_GROUP();
            var mySql = new SqlHelper();
            object ob;
            var sumsuss = 0;
            var sumfail = dt.Rows.Count;
            string colId;
            string colName;
            listDes.Items.Clear();
            try
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    #region

                    var stringsuss = " ";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString()) == false.ToString()) continue;
                    var exist = false;
                    var result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                    }
                    colId = Getnamecolum("mã");
                    colName = Getnamecolum("tên");
                    if ((colId != "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        ob = dt.Rows[i][colId];
                        colId = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (productGroup.Exist(mySql.Transaction, colId))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Nhóm Hàng [" + colId + "] Đã Tồn Tại." +
                                                  StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (productGroup.Get(mySql.Transaction, colId) == "OK")
                                {
                                    colId = productGroup.ProductGroup_ID;
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Nhóm Hàng [" + colId +
                                                  "]  Đã Tồn Tại." + StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colId.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Nhóm Hàng Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        productGroup.ProductGroup_ID = colId;
                    }
                    else if ((colId == "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        productGroup.ProductGroup_ID = productGroup.NewID();
                    }
                    if (colName != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][colName];
                        colName = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (productGroup.ExistByName(colName))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Nhóm Hàng Hoá  [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (productGroup.GetByName(mySql.Transaction, colName) == "OK")
                                {
                                    colName = productGroup.ProductGroup_Name;
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Nhóm Hàng Hoá  [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colName.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Nhóm Hàng Hoá Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        productGroup.ProductGroup_Name = colName;
                    }
                    else
                    {
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Cột Tên Nhóm Hàng hoá Chưa Xác Định." + StrError);
                        mySql.RollBack();
                        continue;
                    }
                    productGroup.Active = true; //Convert.ToBoolean((temp == "<Không Chọn>" | temp=="Checked")
                    var temp = Getnamecolum("ghi chú");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        productGroup.Description = temp;
                    }
                    result = !exist ? productGroup.Insert(mySql.Transaction) : productGroup.Update(mySql.Transaction);
                    if (result == "OK")
                    {
                        mySql.Commit();
                        stringsuss += "Nhóm Hàng " + productGroup.ProductGroup_Name + " Đã Được Thêm";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss);
                        sumsuss += 1;
                    }
                    else
                    {
                        stringsuss = "Không Thực Hiện Được";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss + StrError);
                        mySql.RollBack();
                        break;
                    }

                    #endregion
                }
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcsuss.Text = @" Số Dòng Dữ Liệu Được Lưu Thành Công : " + sumsuss;
            lbcFail.Text = @" Số Dòng Chưa Được Lưu : " + (sumfail - sumsuss);

            wzpa_Result.AllowNext = true;
            RaiseItemCheckedEventHander();
        }

        private const string StrError = " --------------------<<<Error>>>";

        private void ExecuteUnit()
        {
            var dt = (DataTable) gcList.DataSource;
            if (dt == null) return;
            var mUnit = new UNIT();
            var mySql = new SqlHelper();
            object ob;
            var sumsuss = 0;
            var sumfail = dt.Rows.Count;
            string colId;
            string colName;

            listDes.Items.Clear();
            try
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    #region

                    var stringsuss = " ";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString()) == false.ToString()) continue;
                    var exist = false;
                    var result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                    }
                    colId = Getnamecolum("mã");
                    colName = Getnamecolum("tên");
                    if ((colId != "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        ob = dt.Rows[i][colId];
                        colId = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        //
                        if (mUnit.Exist(colId))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng thứ " + i + " : " + " mã đơn vị [" + colId + "] đã tồn tại." +
                                                  StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                //
                                if (mUnit.Get(mySql.Transaction, colId) == "OK")
                                {
                                    colId = mUnit.Unit_ID; //
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng thứ " + i + " : " + " mã đơn vị [" + colId + "]  đã tồn tại." +
                                                  StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colId.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " mã đơn vị chưa xác định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        mUnit.Unit_ID = colId; //
                    }
                    else if ((colId == "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        mUnit.Unit_ID = mUnit.NewID(); //
                    }

                    #region

                    if (colName != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][colName];
                        colName = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (mUnit.ExistByName(colName)) //
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng thứ " + i + " : " + " tên đơn vị [" + colName + "] đã tồn tại." +
                                                  StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                //them hàm getby name
                                if (mUnit.GetByName(mySql.Transaction, colName) == "OK") //
                                {
                                    colName = mUnit.Unit_Name; //
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng thứ " + i + " : " + " tên đơn vị [" + colName + "] đã tồn tại." +
                                                  StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colName.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " tên đơn vị chưa xác định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        mUnit.Unit_Name = colName;
                    }
                    else
                    {
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + " cột tên đơn vị chưa xác định." + StrError);
                        mySql.RollBack();
                        continue;
                    }

                    #endregion

                    mUnit.Active = true; //
                    var temp = Getnamecolum("ghi chú");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        mUnit.Description = temp;
                    }
                    result = !exist
                                 ? mUnit.Insert(mySql.Transaction)
                                 : mUnit.Update(mySql.Transaction, mUnit.Unit_ID, mUnit.Unit_Name, mUnit.Description,
                                                mUnit.Active);
                    if (result == "OK")
                    {
                        mySql.Commit();
                        stringsuss += " Đơn Vị [" + mUnit.Unit_Name + "] đã được thêm.";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss);
                        sumsuss += 1;
                    }
                    else
                    {
                        stringsuss = "Không Thực Hiện Được";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss + StrError);
                        mySql.RollBack();
                        break;
                    }

                    #endregion
                }
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcsuss.Text = @" Số Dòng Dữ Liệu Được Lưu Thành Công : " + sumsuss;
            lbcFail.Text = @" Số Dòng Chưa Được Lưu : " + (sumfail - sumsuss);

            wzpa_Result.AllowNext = true;
            RaiseItemCheckedEventHander();
        }

        private void ExecuteStock()
        {
            var dt = (DataTable) gcList.DataSource;

            if (dt == null) return;
            var customer = new STOCK();
            var mySql = new SqlHelper();
            string colId;
            string colName;
            object ob;
            var sumsuss = 0;
            var sumfail = dt.Rows.Count;
            listDes.Items.Clear();
            try
            {
                #region

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var stringsuss = " ";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString()) == false.ToString()) continue;
                    var exist = false;
                    var result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                    }
                    colId = Getnamecolum("mã");
                    colName = Getnamecolum("tên kho");
                    if ((colId != "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        #region

                        ob = dt.Rows[i][colId];
                        colId = ob == DBNull.Value ? "" : ob.ToString();
                        if (customer.Exist(mySql.Transaction, colId))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add("  Dòng Thứ " + i + " : " + " Kho Hàng  [" + colId + "]  Đã Tồn Tại." +
                                                  StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (customer.Get(mySql.Transaction, colId) == "OK")
                                {
                                    exist = true;
                                }
                            }
                            else if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add("  Dòng Thứ " + i + " : " + "Kho Hàng  [" + colId + "]  Đã Tồn Tại." +
                                                  StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colId.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Kho Hàng Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        customer.Stock_ID = colId;

                        #endregion
                    }
                    else if ((colId == "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        customer.Stock_ID = customer.NewID();
                    }
                    if (colName != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][colName];
                        colName = ob == DBNull.Value ? "" : ob.ToString();
                        if (customer.ExistByName(mySql.Transaction, colName))
                        {
                            switch (rgOption.SelectedIndex)
                            {
                                case 0:
                                    listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên  Kho Hàng [" + colName +
                                                      "]  Đã Tồn Tại." + StrError);
                                    mySql.Commit();
                                    continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (customer.GetByName(mySql.Transaction, colName) == "OK")
                                {
                                    exist = true;
                                }
                            }
                            else
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên  Kho Hàng [" + colName +
                                                  "]  Đã Tồn Tại." + StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colName.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Kho Hàng Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        customer.Stock_Name = colName;
                    }
                    customer.Active = true;
                    string temp = Getnamecolum("liên");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Contact = temp;
                    }
                    temp = Getnamecolum("quản");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Manager = temp;
                    }
                    temp = Getnamecolum("địa");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Address = temp;
                    }
                    temp = Getnamecolum("điện");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Telephone = temp;
                    }
                    temp = Getnamecolum("fax");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Fax = temp;
                    }
                    temp = Getnamecolum("di");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Mobi = temp;
                    }
                    temp = Getnamecolum("email");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Email = temp;
                    }
                    temp = Getnamecolum("ghi");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        customer.Description = temp;
                    }
                    result = !exist ? customer.Insert(mySql.Transaction) : customer.Update(mySql.Transaction);
                    if (result == "OK")
                    {
                        mySql.Commit();
                        sumsuss += 1;
                        stringsuss += " Kho Hàng [" + customer.Stock_Name + "]" + " Đã Được Thêm";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss);
                    }
                    else
                    {
                        mySql.RollBack();
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Không Thực Hiện Được" + StrError);
                        break;
                    }
                }

                #endregion
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcFail.Text = @" Số Dòng Chưa Được Lưu : " + (sumfail - sumsuss);
            lbcsuss.Text = @" Số Dòng Dữ Liệu Được Lưu Thành Công : " + sumsuss;
            RaiseItemCheckedEventHander();
            wzpa_Result.AllowNext = true;
        }

        private string Getnamecolum(string columname)
        {
            var dt = (DataTable) gcList.DataSource;
            var name = "<Không Chọn>";
            string temp;
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                temp = dt.Columns[i].Caption;
                if (temp.ToLower().IndexOf(columname) == -1) continue;
                name = temp;
                return name;
            }
            return name;
        }

        private DataTable _dt2;

        private void ExecuteProduct()
        {
            //finish = false;
            var dt = (DataTable) gcList.DataSource;
            var dt3 = (DataTable) gcList.DataSource;
            dt3.Columns.Add("column", typeof (Boolean));
            if (dt == null) return;
            var product = new PRODUCT();
            var mySql = new SqlHelper();
            string temp;
            string colId;
            string colName;
            object ob;
            string err = "";
            var stockname = "";
            var groupname = "";
            var unitname = "";
            var sumsuss = 0;
            var sumfail = dt.Rows.Count;
            var arr = new String[sumfail];
            listDes.Items.Clear();
            try
            {
                #region

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var stringsuss = " ";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString()) == false.ToString()) continue;
                    var productExist = false;

                    var result = mySql.Start();

                    if (result != "OK")
                    {
                        mySql.RollBack();
                    }

                    colId = Getnamecolum("mã hàng");
                    colName = Getnamecolum("tên hàng");

                    #region if co ma hang va ten hang

                    if ((colId != "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        #region Bat dau them ma hang hoa do nguoi dung nhap

                        ob = dt.Rows[i][colId];
                        colId = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (product.Exist(mySql.Transaction, colId))
                        {
                            switch (rgOption.SelectedIndex)
                            {
                                case 0:
                                    listDes.Items.Add(" Dòng Thứ " + i + " : " + " Bỏ qua Hàng Hóa [" + colId + "] ");
                                    mySql.Commit();
                                    continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (product.Get(mySql.Transaction, colId) == "OK")
                                {
                                    productExist = true;
                                }
                            }
                            else
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Hàng Hóa [" + colId + "] Đã Tồn Tại." +
                                                  StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colId.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Hàng Hoá Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            return;
                        }
                        product.Product_ID = colId;

                        #endregion Ket thuc them ma hang hoa do nguoi dung nhap
                    }
                        #endregion het if co ma hh , co ten hang hoa

                    else if ((colId == "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        product.Product_ID = product.NewID();
                    }

                    #region

                    //else //Khong co cot ma hang hoa
                    //{
                    //    sumfail += 1;
                    //    listBoxControl2.Items.Add(" Dòng Thứ " + i + " : " + " Cột Mã Hàng Hoá Chưa Xác Định. ");
                    //    mySql.RollBack();
                    //    return;
                    //}
                    //temp = Getnamecolum("tên hàng");

                    #endregion

                    if (colName != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][colName];

                        colName = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (product.ExistByName(mySql.Transaction, colName) && product.Exist(mySql.Transaction, colId))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Bỏ Qua Hàng Hóa  [" + colName + "] Này.");

                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (product.Get(mySql.Transaction, colName) == "OK")
                                {
                                    productExist = true;
                                }
                            }
                            else
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Hàng Hóa [" + colName + "] Đã Tồn Tại." +
                                                  StrError);
                                //mySql.RollBack();
                                //return;
                            }
                        }
                        if (colName.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Hàng Hoá Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            return;
                        }
                        product.Product_Name = colName;
                    }
                    else
                    {
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Cột Tên Hàng Hoá Chưa Xác Định." + StrError);
                        mySql.RollBack();
                        return;
                    }
                    //temp = Getnamecolum("nhà");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString();
                    //    var provider = new PROVIDER();
                    //    if (provider.GetByName(mySql.Transaction, temp) == "OK")
                    //    {
                    //        product.Customer_ID = provider.Customer_ID;
                    //    }
                    //    else
                    //    {
                    //        listBoxControl2.Items.Add(" Dòng Thứ " + i + " : " + " Nhà Phân Phối " + temp + " Không Tồn Tại.");
                    //        mySql.RollBack();
                    //        return;
                    //    }
                    //}
                    temp = Getnamecolum("nhóm");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (temp.Trim() == "")
                        {
                            if (groupname != "")
                            {
                                product.Product_Group_ID = groupname;
                            }
                            else
                            {
                                //mySql.RollBack();
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + "Nhóm Hàng Hoá Chưa Xác Định." + StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        else
                        {
                            var productGroup = new PRODUCT_GROUP();
                            if (productGroup.GetByName(mySql.Transaction, temp) != "OK")
                            {
                                //mySql.RollBack();
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + "Không Thể Tạo Nhóm Hàng Hoá." + StrError);
                                mySql.RollBack();
                                return;
                            }
                            product.Product_Group_ID = productGroup.ProductGroup_ID;
                            groupname = product.Product_Group_ID;
                        }
                    }
                    else
                    {
                        var productGroup = new PRODUCT_GROUP();
                        if (!productGroup.Exist(mySql.Transaction, "MD"))
                        {
                            //mySql.RollBack();
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + "Nhóm Hàng Hoá Chưa Xác Định." + StrError);
                            //return;
                        }
                        product.Product_Group_ID = "MD";
                        groupname = "MD";
                    }
                    //temp = cbxProductType.SelectedText;

                    temp = Getnamecolum("loại hàng");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        switch (temp)
                        {
                            case "Hàng Hoá":
                                product.Product_Type_ID = 0;
                                //MessageBox.Show(temp);
                                break;
                            case "Dịch Vụ":
                                product.Product_Type_ID = 2;
                                //MessageBox.Show(temp);
                                break;
                            case "Công Cụ":
                                product.Product_Type_ID = 1;
                                break;
                            case "Thành Phẩm":
                                product.Product_Type_ID = 4;
                                break;
                            case "Bán Thành Phẩm":
                                product.Product_Type_ID = 3;
                                break;
                            case "Vật Tư":
                                product.Product_Type_ID = 5;
                                break;
                            case "Nguyên Liệu":
                                product.Product_Type_ID = 6;
                                break;
                            case "Sản Phẩm Lắp Ráp":
                                product.Product_Type_ID = 7;
                                break;
                            default:
                                product.Product_Type_ID = 0;
                                break;
                        }
                    }
                    else
                    {
                        product.Product_Type_ID = 0; //MessageBox.Show(temp);
                    }
                    temp = Getnamecolum("kho");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (temp.Trim() == "")
                        {
                            if (stockname == "")
                            {
                                //mySql.RollBack();
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Kho Hàng Hoá Chưa Xác Định." + StrError);
                                mySql.RollBack();
                                return;
                            }
                            product.Provider_ID = stockname;
                        }
                        else
                        {
                            var stock = new STOCK();
                            if (stock.GetByName(mySql.Transaction, temp) != "OK")
                            {
                                //mySql.RollBack();
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Không Thể Tạo Kho Hàng Hoá." + StrError);
                                mySql.RollBack();
                                return;
                            }
                            product.Provider_ID = stock.Stock_ID;
                            stockname = product.Provider_ID;
                        }
                    }
                    else
                    {
                        var stock = new STOCK();
                        if (!stock.Exist(mySql.Transaction, "MD"))
                        {
                            //mySql.RollBack();
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Kho Hàng Hoá Chưa Xác Định." + StrError);
                            //return;
                        }
                        product.Provider_ID = "MD";
                        stockname = "MD";
                    }
                    temp = Getnamecolum("đơn vị");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (temp.Trim() == "")
                        {
                            if (unitname == "")
                            {
                                //mySql.RollBack();
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Đơn Vị Chưa Xác Định." + StrError);
                                mySql.RollBack();
                                return;
                            }
                            product.Unit = unitname;
                        }
                        else
                        {
                            var unit = new UNIT();
                            if (unit.GetByName(mySql.Transaction, temp) != "OK")
                            {
                                //mySql.RollBack();
                                //dt3.Rows.RemoveAt(i);

                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Đơn Vị [" + temp +
                                                  "] Không Tồn Tại Trong Cơ Sở Dữ Liệu." + StrError);
                                mySql.RollBack();
                                return;
                            }
                            product.Unit = unit.Unit_ID;
                            unitname = unit.Unit_ID;
                        }
                    }
                    else
                    {
                        var unit = new UNIT();
                        if (!unit.Exist(mySql.Transaction, "kg"))
                        {
                            //mySql.RollBack();
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Đơn Vị Chưa Xác Định." + StrError);
                            //return;
                        }
                        product.Unit = "kg";
                        unitname = "kg";
                    }
                    //temp = Getnamecolum("vị quy");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                    //    if (temp.Trim() != "")
                    //    {
                    //        var unit = new UNIT();
                    //        if (unit.GetByName(mySql.Transaction, temp) == "OK")
                    //        {
                    //            product.UnitConvert = unit.Unit_ID;
                    //        }
                    //        else
                    //        {
                    //            {
                    //                //mySql.RollBack();
                    //                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Không Thể Tạo Đơn Vị Tính." +
                    //                                  StrError);
                    //                mySql.RollBack();
                    //                return;
                    //            }
                    //        }
                    //    }
                    //}
                    product.Quantity = 0;
                    temp = Getnamecolum("bán");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        if (!Information.IsNumeric(temp))
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Gía Bán Không Phải Là Số." + StrError);
                            product.Sale_Price = 0;
                        }
                        else
                        {
                            product.Sale_Price = Convert.ToDouble(temp);
                        }
                    }
                    //temp = Getnamecolum("kích cở");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                    //    product.Size = temp;
                    //}
                    //temp = Getnamecolum("ghi chú");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                    //    product.Description = temp;
                    //}
                    temp = Getnamecolum("chiết");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        if (!Information.IsNumeric(temp))
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Chiết Khấu Không Phải Là Số." + StrError);
                            //RaiseItemCheckingEventHander(i, " Chiết Khấu Không Phải Là Số.", 3, temp);
                            product.Discount = 0;
                        }
                        else
                        {
                            product.Discount = Convert.ToDouble(temp);
                        }
                    }
                    //temp = Getnamecolum("hạn");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Định Mức Hạn Sử Dụng Không Phải Là Số." +
                    //                          StrError);
                    //        product.ExpiryValue = 0;
                    //    }
                    //    else
                    //    {
                    //        product.ExpiryValue = Convert.ToDouble(temp);
                    //    }
                    //}
                    //temp = Getnamecolum("tối đa");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(temp))
                    //    {
                    //        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Định Mức Tồn Kho Tối Đa Không Phải Là Số" +
                    //                          StrError);
                    //        product.MaxStock = 0;
                    //    }
                    //    else
                    //    {
                    //        product.MaxStock = Convert.ToDouble(temp);
                    //    }
                    //}


                    temp = Getnamecolum("tối thiểu");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(temp))
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Định Mức Tồn Kho Tối Thiểu Không Phải Là Số" +
                                              StrError);
                            product.MinStock = 0;
                        }
                        else
                        {
                            product.MinStock = Convert.ToDouble(temp);
                        }
                    }
                    temp = Getnamecolum("vốn");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        if (!Information.IsNumeric(temp))
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Gía Vốn Không Phải Là Số." + StrError);
                            product.Org_Price = 0;
                        }
                        else
                        {
                            product.Org_Price = Convert.ToDouble(temp);
                        }
                    }
                    temp = Getnamecolum("giá bán lẻ");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                        if (!Information.IsNumeric(temp))
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " giá bán lẻ không phải là số." + StrError);
                            product.Retail_Price = 0;
                        }
                        else
                        {
                            product.Retail_Price = Convert.ToDouble(temp);
                        }
                    }
                    temp = Getnamecolum("xuất");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        product.Origin = temp;
                    }
                    //temp = Getnamecolum("lệ quy");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(temp))
                    //    {
                    //        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tỷ Lệ Quy Đổi Không Phải Là Số." + StrError);

                    //        product.Org_Price = 1;
                    //    }
                    //    else
                    //    {
                    //        product.Org_Price = Convert.ToDouble(temp);
                    //    }
                    //}
                    //temp = Getnamecolum("vat");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                    //    switch (temp)
                    //    {
                    //        case "Không thuế":
                    //            product.VAT_ID = 0;
                    //            break;
                    //        case "0%":
                    //            product.VAT_ID = 1;
                    //            break;
                    //        case "5%":
                    //            product.VAT_ID = 2;
                    //            break;
                    //        case "10%":
                    //            product.VAT_ID = 3;
                    //            break;
                    //        case "10%x50%":
                    //            product.VAT_ID = 4;
                    //            break;
                    //        default:
                    //            product.VAT_ID = 0;
                    //            break;
                    //    }
                    //}
                    //temp = Getnamecolum("bảo");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(temp))
                    //    {
                    //        listDes.Items.Add(" Dòng Thứ " + i + " : " + "Định Mức Bảo Hành Không Phải Là Số." +
                    //                          StrError);
                    //        product.Warranty = 0;
                    //    }
                    //    else
                    //    {
                    //        product.Warranty = Convert.ToInt32(temp);
                    //    }
                    //}
                    product.Active = true;
                    product.AverageCost = 0;
                    temp = Getnamecolum("vạch");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        product.Barcode = temp;
                    }
                    //temp = Getnamecolum("màu");
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                    //    product.Color = temp;
                    //}

                    result = productExist ? product.Update(mySql.Transaction) : product.Insert(mySql.Transaction);

                    if (result == "OK")
                    {
                        arr[i] = "a";
                        mySql.Commit();
                        sumsuss += 1;

                        stringsuss += "Hàng hoá [" + product.Product_Name + "] Đã Được Thêm";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss);
                    }
                    else
                    {
                        dt3.Rows[i]["column"] = true;
                        err = "a";
                        mySql.RollBack();
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + "Không Thực Hiện Được" + StrError);
                    }
                }

                #endregion
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcsuss.Text = @" Số Dòng Dữ Liệu Được Lưu Thành Công : " + sumsuss;
            lbcFail.Text = @" Số Dòng Chưa Được Lưu : " + (sumfail - sumsuss);
            wzpa_Result.AllowNext = true;
            cbxProductType.Visible = false;
            labelControl5.Visible = false;
            if (err == "a")
            {
                var an = MessageBox.Show(@"Xuất Danh Sách Hàng Hoá Chưa Được Lưu Ra File Excel ? ", "",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (an == DialogResult.Yes)
                {
                    XuatFileLoi(dt3, sumfail);
                }
            }
        }

        private void XuatFileLoi(DataTable dt, int n)
        {
            try
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ((DBNull.Value.Equals(dt.Rows[i]["column"])) ||
                            (dt.Rows[i]["column"].ToString()) == false.ToString())
                        {
                            dt.Rows.RemoveAt(i);
                        }
                    }
                }
                dt.Columns.Remove("colOption");
                dt.Columns.Remove("column");
                _dt2 = dt;
                Ghifile();
            }
            catch
            {
                MessageBox.Show(@"Không Thực Hiện Được ");
            }
        }

        private void WzPageResultPrevClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            switch (radioOptionList.SelectedIndex)
            {
                case 6:
                    wzpage_MergeColumn.Visible = true;
                    wzpage_Check.Visible = true;
                    break;
            }
        }

        private void ExecuteCustomer()
        {
            var dt = (DataTable) gcList.DataSource;
            if (dt == null) return;
            var customer = new CUSTOMER();
            var mySql = new SqlHelper();
            object ob;
            var sumsuss = 0;
            var sumfail = dt.Rows.Count;
            listDes.Items.Clear();
            try
            {
                #region

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var stringsuss = " ";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString()) == false.ToString()) continue;
                    var exist = false;
                    var result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                    }
                    var colId = Getnamecolum("mã khách");
                    var colName = Getnamecolum("tên khách");
                    if ((colId != "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        ob = dt.Rows[i][colId];
                        colId = ob == DBNull.Value ? "" : ob.ToString();
                        if (customer.Exist(mySql.Transaction, colId))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + "Mã Khách Hàng  [" + colId +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (customer.Get(mySql.Transaction, colId) == "OK")
                                {
                                    colId = customer.Customer_ID;
                                    exist = true;
                                }
                            }
                            else if (rgOption.SelectedIndex == 2)
                            {
                                {
                                    listDes.Items.Add(" Dòng Thứ " + i + " : " + "Mã Khách Hàng  [" + colId +
                                                      "] Đã Tồn Tại." + StrError);
                                    mySql.RollBack();
                                    return;
                                }
                            }
                        }
                        //else // neu kh khong ton tai
                        //{
                        //    sumfail += 1;
                        //    listBoxControl2.Items.Add(" Dòng Thứ " + i + " : " + "Khách Hàng Chưa Xác Định.");
                        //    mySql.RollBack();
                        //    continue;
                        //}
                        if (colId == "") //neu ma khach hang rong
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + "Mã Khách Hàng Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        customer.Customer_ID = colId;
                    }
                    else if ((colId == "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        customer.Customer_ID = customer.NewID();
                    }
                    if (colName != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][colName];
                        colName = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (customer.ExistByName(colName))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khách Hàng [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (customer.GetByName(mySql.Transaction, colName) == "OK")
                                {
                                    colName = customer.CustomerName;
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khách Hàng [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colName.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khách Hàng Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        customer.CustomerName = colName;
                    }
                    else
                    {
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Cột Tên Nhà Phân Phối Chưa Xác Định." + StrError);
                        mySql.RollBack();
                        continue;
                    }
                    customer.Active = true;


                    string temp = Getnamecolum("liên");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Contact = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("chức");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Position = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("nhóm kh");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        string cusGroup = Convert.ToString(ob);
                        customer.Customer_Type_ID = cusGroup == "0" || cusGroup == "1" ? cusGroup : "1";
                    }
                    temp = Getnamecolum("địa");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.CustomerAddress = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("điện");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Tel = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    //
                    temp = Getnamecolum("khu");
                    if (temp != "<Không Chọn>")
                    {
                        var area = new CUSTOMER_GROUP();
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (temp.Trim() == "")
                        {
                            customer.Customer_Group_ID = "MD";
                        }
                        if (area.GetByName(mySql.Transaction, temp) != "OK")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khu Vực [" + temp + "] Không Tồn Tại" +
                                              StrError);
                            mySql.RollBack();
                            return;
                        }
                        customer.Customer_Group_ID = area.Customer_Group_ID;
                    }
                    else
                    {
                        customer.Customer_Group_ID = "MD";
                    }
                    

                    //
                    temp = Getnamecolum("fax");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Fax = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("thuế");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Tax = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("di động");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Mobile = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("email");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Email = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("website");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Website = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("ghi");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Description = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("vạch");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Barcode = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("khoản");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.BankAccount = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("ngân hàng");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.BankName = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("giới hạn");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.CreditLimit = ob == DBNull.Value ? 0 : Conversion.Val(ob);
                    }

                    temp = Getnamecolum("chiết");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Discount = ob == DBNull.Value ? 0 : Conversion.Val(ob);
                    }

                    temp = Getnamecolum("tuyến");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.NickYM = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("skype");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.NickSky = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    result = exist ? customer.Update(mySql.Transaction) : customer.Insert(mySql.Transaction);
                    if (result == "OK")
                    {
                        mySql.Commit();
                        stringsuss += "Khách Hàng [" + customer.CustomerName + "] Đã Được Thêm";
                        sumsuss += 1;
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss);
                    }
                    else
                    {
                        mySql.RollBack();
                        stringsuss = "Không Thực Hiện Được";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss + StrError);
                        break;
                    }
                }

                #endregion
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcsuss.Text = @" Số Dòng Dữ Liệu Được Lưu Thành Công : " + sumsuss;
            lbcFail.Text = @" Số Dòng Chưa Được Lưu : " + (sumfail - sumsuss);
            wzpa_Result.AllowNext = true;

            RaiseItemCheckedEventHander();
            //return false;
        }

        private void ExecuteProvider()
        {
            var dt = (DataTable) gcList.DataSource;

            if (dt == null) return;
            var customer = new PROVIDER();
            var mySql = new SqlHelper();
            object ob;
            var sumsuss = 0;
            var sumfail = dt.Rows.Count;
            string colId;
            listDes.Items.Clear();
            try
            {
                #region

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var stringsuss = " ";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString()) == false.ToString()) continue;
                    var exist = false;
                    var result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(i, result, 1, result);
                    }
                    colId = Getnamecolum("mã nhà");
                    var colName = Getnamecolum("tên nhà");
                    if ((colId != "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        ob = dt.Rows[i][colId];
                        colId = ob == DBNull.Value ? "" : ob.ToString();
                        if (customer.Exist(mySql.Transaction, colId))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + "Nhà Phân Phối [" + colId +
                                                  "]  Đã Tồn Tại." + StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                {
                                    if (customer.Get(mySql.Transaction, colId) == "OK")
                                    {
                                        colId = customer.Customer_ID;
                                        exist = true;
                                    }
                                }
                            }
                            else
                            {
                                {
                                    listDes.Items.Add(" Dòng Thứ " + i + " : " + "Nhà Phân Phối [" + colId +
                                                      "]  Đã Tồn Tại." + StrError);
                                    mySql.RollBack();
                                    return;
                                }
                            }
                        }

                        #region

                        if (colId.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Nhà Phân Phối Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }

                        #endregion

                        customer.Customer_ID = colId;
                    }
                    else if ((colId == "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        customer.Customer_ID = customer.NewID();
                    }

                    if (colName != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][colName];
                        colName = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (customer.ExistByName(colName))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Nhà Phân Phối [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (customer.GetByName(mySql.Transaction, colName) == "OK")
                                {
                                    colName = customer.CustomerName;
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Nhà Phân Phối [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colName.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Nhà Phân Phối Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        customer.CustomerName = colName;
                    }
                    else
                    {
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Cột Tên Nhà Phân Phối Chưa Xác Định." + StrError);
                        mySql.RollBack();
                        continue;
                    }
                    customer.Active = true;
                    var temp = Getnamecolum("liên hệ");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Contact = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("chức vụ");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Position = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("giới hạn");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.CreditLimit = ob == DBNull.Value ? 0 : Conversion.Val(ob);
                    }
                    temp = Getnamecolum("chiết");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Discount = ob == DBNull.Value ? 0 : Conversion.Val(ob);
                    }
                    temp = Getnamecolum("địa chỉ");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.CustomerAddress = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("điện thoại");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Tel = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("fax");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Fax = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("thuế");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Tax = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("di");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Mobile = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("email");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Email = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("website");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Website = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("ghi");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Description = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("vạch");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.Barcode = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("khoản");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.BankAccount = ob == DBNull.Value ? "" : ob.ToString();
                    }
                    temp = Getnamecolum("ngân hàng");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        customer.BankName = ob == DBNull.Value ? "" : ob.ToString();
                    }

                    temp = Getnamecolum("khu");
                    if (temp != "<Không Chọn>")
                    {
                        var area = new CUSTOMER_GROUP();
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (temp.Trim() == "")
                        {
                            customer.Customer_Group_ID = "MD";
                        }
                        if (area.GetByName(mySql.Transaction, temp) != "OK")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khu Vực [" + temp + "] Không Tồn Tại" +
                                              StrError);
                            mySql.RollBack();
                            return;
                        }
                        customer.Customer_Group_ID = area.Customer_Group_ID;
                    }
                    else
                    {
                        customer.Customer_Group_ID = "MD";
                    }
                    result = exist ? customer.Update(mySql.Transaction) : customer.Insert(mySql.Transaction);
                    if (result == "OK")
                    {
                        mySql.Commit();
                        sumsuss += 1;
                        stringsuss += " Nhà Phân Phối [" + customer.CustomerName + "] Đã Được Thêm";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss);
                    }
                    else
                    {
                        mySql.RollBack();
                        stringsuss = "Không Thực Hiện Được";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss + StrError);
                        break;
                    }
                }

                #endregion
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcsuss.Text = @" Số Dòng Dữ Liệu Được Lưu Thành Công : " + sumsuss;
            lbcFail.Text = @" Số Dòng Chưa Được Lưu : " + (sumfail - sumsuss);
            wzpa_Result.AllowNext = true;
            //RaiseItemCheckedEventHander();
            //return false;
        }

        private void ExecuteArea()
        {
            var dt = (DataTable) gcList.DataSource;
            if (dt == null) return;
            var area = new CUSTOMER_GROUP();
            var mySql = new SqlHelper();
            object ob;
            var sumsuss = 0;
            var sumfail = dt.Rows.Count;
            string colId;
            string colName;
            listDes.Items.Clear();
            try
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    #region

                    var stringsuss = " ";
                    if ((DBNull.Value.Equals(dt.Rows[i]["colOption"])) ||
                        (dt.Rows[i]["colOption"].ToString()) == false.ToString()) continue;
                    var exist = false;
                    var result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                    }
                    colId = Getnamecolum("mã");
                    colName = Getnamecolum("tên");
                    if ((colId != "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        ob = dt.Rows[i][colId];
                        colId = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (area.Exist(colId))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Khu Vực [" + colId + "] Đã Tồn Tại." +
                                                  StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                if (area.Get(mySql.Transaction, colId) == "OK")
                                {
                                    colId = area.Customer_Group_ID;
                                    //colId = productGroup.ProductGroup_ID;
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Khu Vực [" + colId + "]  Đã Tồn Tại." +
                                                  StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colId.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Mã Khu Vực Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        area.Customer_Group_ID = colId;
                    }
                    else if ((colId == "<Không Chọn>") && (colName != "<Không Chọn>"))
                    {
                        area.Customer_Group_ID = area.NewID();
                    }

                    #region

                    if (colName != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][colName];
                        colName = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (area.ExistByName(colName))
                        {
                            if (rgOption.SelectedIndex == 0)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khu Vực  [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.Commit();
                                continue;
                            }
                            if (rgOption.SelectedIndex == 1)
                            {
                                //them hàm getby name
                                if (area.GetByName(mySql.Transaction, colName) == "OK")
                                {
                                    colName = area.Customer_Group_Name;
                                    exist = true;
                                }
                            }
                            if (rgOption.SelectedIndex == 2)
                            {
                                listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khu Vực  [" + colName +
                                                  "] Đã Tồn Tại." + StrError);
                                mySql.RollBack();
                                return;
                            }
                        }
                        if (colName.Trim() == "")
                        {
                            listDes.Items.Add(" Dòng Thứ " + i + " : " + " Tên Khu Vực Chưa Xác Định." + StrError);
                            mySql.RollBack();
                            continue;
                        }
                        area.Customer_Group_Name = colName;
                    }
                    else
                    {
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + " Cột Tên Khu Vực Chưa Xác Định." + StrError);
                        mySql.RollBack();
                        continue;
                    }

                    #endregion

                    area.Active = true;
                    var temp = Getnamecolum("ghi chú");
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        area.Description = temp;
                    }
                    result = !exist
                                 ? area.Insert(mySql.Transaction)
                                 : area.Update(mySql.Transaction, area.Customer_Group_ID, area.Customer_Group_Name,
                                               area.Description, area.Active);
                    if (result == "OK")
                    {
                        mySql.Commit();
                        stringsuss += " Khu Vực [" + area.Customer_Group_Name + "] Đã Được Thêm";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss);
                        sumsuss += 1;
                    }
                    else
                    {
                        stringsuss = "Không Thực Hiện Được";
                        listDes.Items.Add(" Dòng Thứ " + i + " : " + stringsuss + StrError);
                        mySql.RollBack();
                        break;
                    }

                    #endregion
                }
            }
            catch
            {
                MessageBox.Show(@" Không Thực Hiện Được ");
            }
            lbcsuss.Text = @" Số Dòng Dữ Liệu Được Lưu Thành Công : " + sumsuss;
            lbcFail.Text = @" Số Dòng Chưa Được Lưu : " + (sumfail - sumsuss);

            wzpa_Result.AllowNext = true;
            RaiseItemCheckedEventHander();
        }

        private void WzpageOptionClick(object sender, EventArgs e)
        {
        }

        private void LabelControl4Click(object sender, EventArgs e)
        {
            var f = new XfrmExcel();
            f.ShowDialog();
        }

        private static void List_Init(GridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "colOption":
                        dt.Columns[i].OptionsColumn.ReadOnly = false;
                        dt.Columns[i].OptionsColumn.AllowEdit = true;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Caption = @"Chọn";
                        dt.Columns[i].Width = 90;
                        break;
                }
            }
        }

        private void Writefile(string filenew)
        {
            var table = _dt2;
            var appExcel = new Exxcel.Application();
            var wbExcel = appExcel.Workbooks.Add(Type.Missing);
            var wsExcel = (Exxcel.Worksheet) wbExcel.Worksheets[1];

            for (int i = 0; i < table.Columns.Count; i++)
            {
                ((Exxcel.Range) wsExcel.Cells[1, i + 1]).Value2 = table.Columns[i].ColumnName;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    ((Exxcel.Range) wsExcel.Cells[i + 2, j + 1]).Value2 = table.Rows[i][j].ToString();
                }
            }
            //wbExcel.SaveAs(filenew, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Exxcel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            wbExcel.SaveAs(filenew, Exxcel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing,
                           Type.Missing, Exxcel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                           Type.Missing, Type.Missing);
            wbExcel.Close(true, Type.Missing, Type.Missing);
            appExcel.Quit();
        }

        private void Ghifile()
        {
            var dialogSave = new SaveFileDialog
                                 {
                                     DefaultExt = "xls",
                                     Filter = @"Text file (*.xls)|*.xls|All files (*.*)|*.*",
                                     AddExtension = true,
                                     RestoreDirectory = true,
                                     Title = @"Bạn Có Muốn Lưu File Excel",
                                     InitialDirectory = @"C:/"
                                 };
            //Exxcel.Application excelApp = new Exxcel.ApplicationClass();
            //excelApp.Visible = true;
            if (dialogSave.ShowDialog(this) == DialogResult.OK)
            {
                Writefile(dialogSave.FileName);
            }
            dialogSave.Dispose();
        }

        private void RadioOptionListSelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GcListClick(object sender, EventArgs e)
        {
        }
    }
}