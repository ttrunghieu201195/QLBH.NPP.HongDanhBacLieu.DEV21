using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;
using Perfect.Dictionary;
using Perfect.Dictionary.Employee;
using Perfect.Dictionary.UI;
using Perfect.Dictionary.UI.UBarcode;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Transfer.dsEmployeeTableAdapters;
using Perfect.Inventory.Core.Inventory.Transfer.dsSTOCK_TRANSFER_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Data.Helper;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    public partial class XucTranferA : xucBaseB
    {
        Column _mColumn;

        public enum Column
        {
            None = 0,
            Quantity = 1,
            Price = 2,
            Amount = 3,
            ID = 4,
            Lock = 5,
            StockID = 14,
            Name = 15,
            OutStock = 16,
            InStock = 17,
			Unit=18
  	
        }

        private EnumRefType _part;
        public XucTranferA()
        {
            InitializeComponent();
            Init();
            
            dtCreated.DateTime = MyLogin.LoginDate;
                   _mColumn = Column.None;
            colBatch.Visible = SysOption.Batch;
        }
		
		 public EnumRefType Part
        {
            get { return _part; }
            set { _part = value; }
        }


        public void Employee_Init()
        {
            var adapter=new EMPLOYEETableAdapter
                            {
                                Connection = {ConnectionString = SqlHelper.ConnectString}
                            };
            adapter.Fill(dsEmployee.EMPLOYEE);

            if (dsEmployee.EMPLOYEE.Rows.Count > 0)
            {
                txtEmployeeSender.EditValue = MyLogin.EmployeeID == "" ? Convert.ToString(dsEmployee.EMPLOYEE.Rows[0]["Employee_ID"]) : MyLogin.EmployeeID;
            }
        }

        public void SetEmployee(EMPLOYEE item)
        {
            dsEmployee.EMPLOYEE.AddEMPLOYEERow(item.Employee_Name, item.Employee_ID);
        }

        public void Stock_Init()
        {
            var adapter = new STOCKTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsSTOCK.STOCK);
            rpgStock.View.ActiveFilterString = "ActiveInt = 1";
            rpToStock.View.ActiveFilterString = "ActiveInt = 1";
        }

        public void SetStock(STOCK item)
        {
            Stock_Init();
            //dsSTOCK.STOCK.AddSTOCKRow(item.Stock_Name, item.Stock_ID);
        }

        public void Product_Init()
        {
            var adapter = new PRODUCTTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.FillBy(dsPRODUCT.PRODUCT);
            rpgProduct.View.ActiveFilterString = "ActiveInt = 1";
            rpProductName.View.ActiveFilterString = "ActiveInt = 1";
        }

        public void Unit_Init()
        {
            var adapter = new UNITTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsUnit.UNIT);
        }

       public void Updated()
        {
            Employee_Init();
            Stock_Init();
            Product_Init();
            Unit_Init();
        }

        void Init()
        {
			Cursor.Current = Cursors.WaitCursor;
            Updated();

            SetWaitDialogCaption("Nạp cấu hình....");
            FormatColumns(rpUnit, "Unit_ID", 1, 100, "Mã");
            FormatColumns(rpUnit, "Unit_Name", 0, 200, "Đơn Vị");

            //FormatColumns(rpgStock, "Stock_ID", 1, 100, "Mã Kho");
            //FormatColumns(rpgStock, "Stock_Name", 0, 200, "Kho Hàng");
           
            dtCreated.DateTime = DateTime.Now;

            ucBarcode = new XucBaseBarcode(3);
            lcBarcode.Control = ucBarcode;
            lcBarcode.TextVisible = false;
            ucBarcode.ItemSelected += UcBarcodeItemSelected;
            Add();
            
            if (dsSTOCK.STOCK.Rows.Count<2)
            
                {
                    XtraMessageBox.Show("Chức năng chuyển kho phải thực hiện trên hai kho.Vui lòng tạo thêm kho để thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                    DoHide();
                }
            

            //if (CODE.TypeSoft < 400 & CODE.TypeSoft != 0)
            //{
            //    colUnit.OptionsColumn.ReadOnly = true;
            //}
			_mColumn = Column.None;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            

            _exportView = gbList;

            SetWaitDialogCaption("Nạp hoàn thành....");
            DoHide();
			Cursor.Current = Cursors.Default;
        }


        void UcBarcodeItemSelected(object sender, Barcode item)
        {
            if (m_Status == Actions.None) return;

            if (item.Action == TypeAdd.Duplicate)
            {
                dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                    0,
                    item.Item.Product_Type_ID,
                    "",
                    item.Item.Product_ID,
                    item.Item.Product_ID,
                    item.Item.Product_Name,
                    item.Item.Provider_ID,
                    item.Item.Provider_ID,
                    item.Item.Unit,
                    1,
                    Convert.ToDecimal(item.Price),
                    Convert.ToDecimal(item.Quantity),
                    Convert.ToDecimal(item.Amount),
                    "",
                    "",
                    txtDescription.Text,
                    0,
                    txtID.Text,
                    9,
                    0,
                    0,
                    Guid.NewGuid(),
                    "",
                    "",
                    ""
                    );
            }
            else if (item.Action == TypeAdd.Add)
            {
                
                var dt = dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL;

                bool add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
                    add = true;
                    double qty = Convert.ToDouble(dt.Rows[i]["Quantity"] ?? 0) + item.Quantity; 
                    double uni = Convert.ToDouble(dt.Rows[i]["UnitPrice"] ?? 0);
                    dt.Rows[i]["Quantity"] = qty;
                    if (uni == 0)
                    {
                        dt.Rows[i]["UnitPrice"] = item.Price;
                        uni = item.Price;
                    }
                    dt.Rows[i]["Amount"] = uni * qty;
                    break;
                }

                if (!add)
                {
                    dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                     0,
                    item.Item.Product_Type_ID,
                    "",
                    item.Item.Product_ID,
                    item.Item.Product_ID,
                    item.Item.Product_Name,
                    item.Item.Provider_ID,
                    item.Item.Provider_ID,
                    item.Item.Unit,
                    1,
                    Convert.ToDecimal(item.Price),
                    Convert.ToDecimal(item.Quantity),
                    Convert.ToDecimal(item.Amount),
                    "",
                    "",
                    txtDescription.Text,
                    0,
                    txtID.Text,
                    9,
                    0,
                    0,
                    Guid.NewGuid(),
                    "",
                    "",
                    ""
                    );
                }
            }
            else if (item.Action == TypeAdd.Replace)
            {
                var dt = dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL;
                bool Add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
                    Add = true;
                    dt.Rows[i]["Quantity"] = item.Quantity;
                    dt.Rows[i]["UnitPrice"] = item.Price;
                    dt.Rows[i]["Amount"] = item.Amount;
                    break;
                }

                if (!Add)
                {
                    dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                     0,
                    item.Item.Product_Type_ID,
                    "",
                    item.Item.Product_ID,
                    item.Item.Product_ID,
                    item.Item.Product_Name,
                    item.Item.Provider_ID,
                    item.Item.Provider_ID,
                    item.Item.Unit,
                    1,
                    Convert.ToDecimal(item.Price),
                    Convert.ToDecimal(item.Quantity),
                    Convert.ToDecimal(item.Amount),
                    "",
                    "",
                    txtDescription.Text,
                    0,
                    txtID.Text,
                    9,
                    0,
                    0,
                    Guid.NewGuid(),
                    "",
                    "",
                    ""
                    );
                }
            }
            else if (item.Action == TypeAdd.Single)
            {
                var dt = dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL;
                bool Add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;

                    alc.Show(ParentForm, "Thông Báo", "Hàng Hoá này đã tồn tại trong danh sách.");
                    gbList.MoveBy(i);
                    Add = true;
                    break;
                }
                if (!Add)
                {
                    dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                        0,
                        item.Item.Product_Type_ID,
                        "",
                        item.Item.Product_ID,
                        item.Item.Product_ID,
                        item.Item.Product_Name,
                        item.Item.Provider_ID,
                        item.Item.Provider_ID,
                        item.Item.Unit,
                        1,
                        Convert.ToDecimal(item.Price),
                        Convert.ToDecimal(item.Quantity),
                        Convert.ToDecimal(item.Amount),
                        "",
                        "",
                        txtDescription.Text,
                        0,
                        txtID.Text,
                        9,
                        0,
                        0,
                        Guid.NewGuid(),
                        "",
                        "",
                        ""
                        );
                }
            }
        }

       private void txtCustomerName_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() =="Search")
            {
                var xfmEmployees = new xfmEmployees(true);
                xfmEmployees.ItemSelected += XfmEmployeesItemSelected;
                xfmEmployees.ShowDialog();
            }
            else if (e.Button.Tag.ToString() =="Add")
            {
                var customer = new EMPLOYEE(txtEmployeeID.Text, "", "", txtEmployeeName.Text, "", true, "", "", "",
                                                 "", "", "", "", DateTime.Now, 0, "", "", "", "", "", "", "", "","", 0,0,0,0,0,0,0,true,"",
                                                 DateTime.Now,"",DateTime.Now,"","",0,true);

                var xfmEmployeeAdd = new XfmEmployeeAdd(customer);
                xfmEmployeeAdd.Added += XfmEmployeeAddAdded;
                xfmEmployeeAdd.ShowDialog();
                
            }
        }

        void XfmEmployeeAddAdded(object sender, EMPLOYEE item)
        {
            Employee_Init();
            txtEmployeeName.EditValue = item.Employee_ID;
        }

        void XfmEmployeesItemSelected(object sender, EMPLOYEE item)
        {
            txtEmployeeName.EditValue = item.Employee_ID;
        }

        private void txtEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmployeeName.EditValue == null) return;
            var cus = new EMPLOYEE();
            if (cus.Get(txtEmployeeName.EditValue.ToString()))
            {
                txtEmployeeID.Text = cus.Employee_ID;
            }
        }

        private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmployeeID.Text == "") return;
                var cus = new EMPLOYEE();
                if (cus.Get(txtEmployeeID.Text))
                {
                    txtEmployeeName.EditValue = cus.Employee_ID;
                }
            }
        }

        private void rpgProduct_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Search")
            {
                var xfmProducts = new xfmProducts(true);
                xfmProducts.ItemSelected += XfmProductsItemSelected;
                xfmProducts.ShowDialog();
            }
            else if (e.Button.Tag.ToString() =="Add")
            {
                var xfmItemAdd = new xfmItemAdd(Actions.Add);
                xfmItemAdd.Added += XfmItemAddAdded;
                xfmItemAdd.ShowDialog();
            }
        }

        void XfmItemAddAdded(object sender, PRODUCT item)
        {
            Product_Init();
            gbList.AddNewRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", item.Product_ID);
        }

        void XfmProductsItemSelected(object sender, PRODUCT item)
        {
            Product_Init();
            gbList.AddNewRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", item.Product_ID);
          
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
            var cls = new TRANS_REF();
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty)
            {
                txt.ErrorText = "";
                Err.SetError(txt, null);
            }
            if (m_Status == Actions.Add)
            {
                if (cls.Exist(txtID.Text))
                {
                    Err.SetError(txtID, "Mã phiếu đã tồn tại.");
                    txtID.Focus();
                }
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;
            
            if (m_Status == Actions.None) return;

            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
            }
            else
            {
                var transRef = new TRANS_REF();
                if (m_Status == Actions.Add)
                {
                    if (!transRef.Exist(txt.Text)) return;
                    Err.SetError(txt, "Mã đã tồn tại.");
                }
                else
                {
                    SetData(txtID.Text);
                }
            }
        }

        protected void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty)
            {
                txt.ErrorText = "";
                Err.SetError(txt, null);
            }
            if (e.KeyCode == Keys.Enter)
            {

                //if (!(e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)) return;
                var transRef = new TRANS_REF();

                if (m_Status == Actions.Add)
                {
                    if (!transRef.Exist(txt.Text)) return;
                    Err.SetError(txt, "Mã đã tồn tại.");
                    txt.Focus();
                }
                else
                {
                    SetData(txtID.Text);
                }
            }
        }

        private void ProductAdd(string id)
        {
            var pro = new PRODUCT();

            if (pro.Get(id) == "OK")
            {
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], pro.Product_Name);
                gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Org_Price);
                gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                gbList.SetFocusedRowCellValue(gbList.Columns["OutStock"], pro.Provider_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["InStock"], pro.Provider_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], "");
                if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                Total();
            }
        }

        public void ProductAdd(PRODUCT item)
        {
            dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                    0,
                    item.Product_Type_ID,
                    "",
                    item.Product_ID,
                    item.Product_ID,
                    item.Product_Name,
                    item.Provider_ID,
                    item.Provider_ID,
                    item.Unit,
                    1,
                    Convert.ToDecimal(item.Org_Price),
                    Convert.ToDecimal(item.Quantity),
                    Convert.ToDecimal(item.Org_Price),
                    "",
                    "",
                    txtDescription.Text,
                    0,
                    txtID.Text,
                    9,
                    0,
                    0,
                    Guid.NewGuid(),
                    "",
                    "",
                    ""
                    );

        }

        
        private void Total()
        {
            double Amount = 0.0;

            for (int i = 0; i < gbList.RowCount; i++)
            {
                Amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));

            }
       }

        public override void Clear()
        {
            dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.Rows.Clear();
        }
        
        public override void Add()
        {

            if (!MyRule.IsAdd("bbiTransfer")) return;
            
            var cls = new TRANS_REF();
            txtID.Text = cls.NewID("CK_" + MyLogin.Account + "_");
            txtID.Properties.ReadOnly = false;
            txtDescription.Text = "";
            dtCreated.EditValue = DateTime.Now;
            DisableControl(true);
            Updated();
            m_Status = Actions.Add;
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
        }

        public override bool Check()
        {
            if (dtCreated.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtCreated.Focus();
                return false;
            }

            if (txtEmployeeName.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeName.Focus();
                return false;
            }

            if (txtEmployeeSender.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeSender.Focus();
                return false;
            }
            if (txtID.Text == string.Empty)
            {
                txtID.Focus();
                Err.SetError(txtID, "Mã phiếu không được rỗng");
                return false;
            }

            if (txtID.ErrorText != string.Empty)
            {
                txtID.Focus();
                Err.SetError(txtID, "Mã phiếu đã tồn tại");
                return false;
            }

            if (dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.Rows.Count == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        public override void DisableControl(bool disable)
        {
            gcList.Enabled = disable;
            Bar.Bar.bbiCancel.Enabled = disable;
            Bar.Bar.bbiSave.Enabled = disable;
            Bar.Bar.bbiSaveNew.Enabled = disable;
            Bar.Bar.bbiSaveM.Enabled = disable;
        }

        private bool DetailCheck()
        {
            if (gbList.RowCount - 1 == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var dt = dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL;

            string text;
            int j = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                j++;
                text = gbList.GetDisplayTextByColumnValue(colProduct_ID, dt.Rows[i]["Product_ID"].ToString());
                if (text.Trim() == "")
                {
                    XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                    return false;
                }

                text = gbList.GetDisplayTextByColumnValue(colInStock, dt.Rows[i]["InStock"].ToString());
                if (text.Trim() == "")
                {
                    XtraMessageBox.Show("Kho đến bị rỗng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colInStock, "Kho đến bị rỗng");
                    return false;
                }

                text = gbList.GetDisplayTextByColumnValue(colOutStock, dt.Rows[i]["OutStock"].ToString());
                if (text.Trim() == "")
                {
                    XtraMessageBox.Show("Từ kho bị rỗng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colOutStock, "Từ kho bị rỗng");
                    return false;
                }

                if (dt.Rows[i]["InStock"] == null | dt.Rows[i]["InStock"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Kho đến bị rỗng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colInStock, "Kho đến bị rỗng");
                    return false;
                }
                if (dt.Rows[i]["OutStock"] == null | dt.Rows[i]["OutStock"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Từ kho bị rỗng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colOutStock, "Từ kho bị rỗng");
                    return false;
                }
                if (dt.Rows[i]["InStock"].ToString() == dt.Rows[i]["OutStock"].ToString())
                {
                    XtraMessageBox.Show("Kho đến và kho đi trùng nhau.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colInStock, "Kho đến và kho đi trùng nhau");
                    gbList.SetColumnError(colOutStock, "Kho đến và kho đi trùng nhau");
                    return false;
                }
                if (dt.Rows[i]["Product_ID"] == null | dt.Rows[i]["Product_ID"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                    return false;
                }
				
				 if (dt.Rows[i]["Unit"] == null | dt.Rows[i]["Unit"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Đơn vị tính không đúng.\n\tDòng số: " + (j), "Cảnh Báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colUnit, "Đơn vị tính không đúng");
                    return false;
                }
               
            }
            return true;
        }

        public override string uc_Save()
        {
            if (!MyRule.IsAdd("bbiTransfer")) 
            {
                MyRule.Notify();
                return ""; 
            }

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();
            
            SysLog.Insert("Phiếu Chuyển Kho", "Thêm",txtID.Text);

            if (!DetailCheck()) return "";

            if (CODE.TypeSoft == 0 || CODE.TypeSoft == 1)
            {
                if (INVENTORY_DETAIL.Count > INVENTORY_DETAIL.LimitRecord)
                {
                    CODE.Notify();
                    return "Phần mềm bị giới hạn dữ liệu, vui lòng đăng ký phiên bản thu phí.";
                }
            }

            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            STOCK_TRANSFER cls = new STOCK_TRANSFER();
            if (cls.Get(txtID.Text))
            {
                if (XtraMessageBox.Show("Mã phiếu đã tồn tại. Bạn có muốn tạo mã mới không!?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return "";
                txtID.Text = cls.NewID("CK_" + MyLogin.Account + "_");
                return "";
            }
            var mySql = new SqlHelper();

            string result = mySql.Start();
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show( result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }


            cls = new STOCK_TRANSFER(
                txtID.Text,
                dtCreated.DateTime,
                "",
                9,
                "All",
                Convert.ToString(txtEmployeeSender.EditValue),
                "All",
                Convert.ToString(txtEmployeeName.EditValue),
                "",
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                true,
                MyLogin.UserId,
                false,
                  0,
                txtDescription.Text,
                true
                );
            
            
            //var cls = new Perfect.ERP.Transfer.STOCK_TRANSFER(
            //    txtID.Text, //ID
            //    dtCreated.DateTime, //RefDate
            //    "", //Ref_OrgNo
            //    9, //RefType
            //    "", //Department_ID
            //    txtEmployeeSender.EditValue.ToString(), //Employee_ID
            //    "", //FromStock_ID
            //    txtEmployeeName.EditValue.ToString(), //Sender_ID
            //    "", //ToStock_ID
            //    "", //Receiver_ID
            //    "", //Branch_ID
            //    "", //Contract_ID
            //    "", //Currency_ID
            //    0, //ExchangeRate
            //    "", //Barcode
            //    Convert.ToDecimal(colAmount.SummaryItem.SummaryValue), //Amount
            //    true, //IsReview
            //    MyLogin.UserId, //User_ID
            //    false, //IsClose
            //      0, //Sorted
            //    txtDescription.Text, //Description
            //    true //Active
            //    );
           


            if (!cls.Insert(mySql.Transaction))
            {
                result = mySql.Result;
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show( result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return result;
            }

            
            result = DetailSave(mySql);
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                return result;
            }

            mySql.Commit();
           
            if (chxIsPrint.Checked) Print(false);
            Cursor.Current = Cursors.Default;
            DoHide();
            Cancel();
            SetData(txtID.Text);
            return result;
        }
        
        private string DetailSave(SqlHelper mySql)
        {
            string result = "OK";

            var cls = new STOCK_TRANSFER_DETAIL();
            var pro = new PRODUCT();

            var dt = dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL;

            int row = 0;
            string id = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    row++;
                   
                    if (dt.Rows[i]["Product_ID"] == null | dt.Rows[i]["Product_ID"] == DBNull.Value)
                    {
                        DoHide();
                        mySql.RollBack();
                        XtraMessageBox.Show("Danh sách mặt hàng không đúng.", "Thông báo", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, "Danh sách mặt hàng không đúng");
                        return "Danh sách mặt hàng không đúng.";
                    }

                    pro.Product_ID = dt.Rows[i]["Product_ID"].ToString();
                    pro.Provider_ID = dt.Rows[i]["OutStock"].ToString();
                    double qty = Convert.ToDouble(dt.Rows[i]["Quantity"]);


                    if (pro.GetByStockAll(mySql.Transaction, pro.Product_ID, pro.Provider_ID) == "OK")
                    {
                        double qtyOld = dt.Rows[i].RowState == DataRowState.Modified ||
                                        dt.Rows[i].RowState == DataRowState.Unchanged
                                            ? Convert.ToDouble(dt.Rows[i]["Quantity", DataRowVersion.Original])
                                            : 0;

                        double cal = qty - (qtyOld + pro.Quantity);


                        if (pro.Product_Type_ID != 1)
                        {
                            if (cal > 0)
                            {
                                DoHide();
                                if (XtraMessageBox.Show("Mặt Hàng " + pro.Product_Name.ToUpper() +
                                                        " đã xuất quá số lượng tồn.\nSố lượng tồn hiện tại là: " +
                                                        pro.Quantity +
                                                        " \nNếu công việc thực hiện sẽ dẫn đến tồn kho bị âm.\nBạn chắc chắn muốn thực hiện công việc này không ?",
                                                        "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                                    DialogResult.No)
                                {
                                    mySql.RollBack();
                                    return "Không thể lưu thông tin phiếu này.";
                                }

                                #region old condition
                                if (SysOption.Negative)
                                {
                                    DoHide();
                                    if (XtraMessageBox.Show("Mặt Hàng " + pro.Product_Name.ToUpper() +
                                                            " đã xuất quá số lượng tồn.\nSố lượng tồn hiện tại là: " +
                                                            pro.Quantity +
                                                            " \nNếu công việc thực hiện sẽ dẫn đến tồn kho bị âm.\nBạn chắc chắn muốn thực hiện công việc này không ?",
                                                            "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                                        DialogResult.No)
                                    {
                                        mySql.RollBack();
                                        return "Không thể lưu thông tin phiếu này.";
                                    }
                                }
                                else
                                {
                                    DoHide();
                                    mySql.RollBack();
                                    XtraMessageBox.Show(
                                        "Mặt hàng này đã xuất vượt quá số lượng tồn.\n\tDòng thứ : " + row,
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    gbList.FocusedRowHandle = row;
                                    gbList.SetColumnError(colQuantity, "Mặt hàng này đã xuất vượt quá số lượng tồn");
                                    return "Không thể lưu thông tin phiếu này.";
                                }
                                #endregion
                            }

                            else if (Math.Abs(cal) < pro.MinStock)
                            {
                                DoHide();
                                if (XtraMessageBox.Show(string.Format("Mặt hàng {0} đã xuất quá số lượng tồn tối thiểu là {1}.\nSố lượng tồn: {2}\nSố lượng xuất: {3}\n Số lượng còn lại: {4}",
                                    pro.Product_Name.ToUpper(),
                                    pro.MinStock.ToString("##,##0.##"),
                                    pro.Quantity.ToString("##,##0.##"),
                                    qty.ToString("##,##0.##"),
                                    Math.Abs(cal).ToString("##,##0.##")
                                    ), "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                {
                                    mySql.RollBack();
                                    return "Không thể lưu thông tin phiếu này.";
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        dt.Rows[i]["Error"] = 1;
                        DoHide();
                        mySql.RollBack();
                        XtraMessageBox.Show(
                            "Không kiểm tra được tồn kho của mặt hàng này.\n\tDòng lỗi: " + (row), "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colQuantity, "Không kiểm tra được tồn kho của mặt hàng này");
                        return "Không kiểm tra được tồn kho của mặt hàng này";
                    }


                    id = dt.Rows[i]["ID"].ToString();

                }

                if (dr.RowState == DataRowState.Added)
                {
                    
                    if (!cls.Insert(
                            mySql.Transaction,
                            Guid.NewGuid().ToString(),
                            txtID.Text,
                            9,
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["Product_Name"].ToString(),
                            dt.Rows[i]["OutStock"].ToString(),
                            dt.Rows[i]["InStock"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            Convert.ToDecimal(dt.Rows[i]["UnitConvert"] == DBNull.Value ? 0 : dt.Rows[i]["UnitConvert"]),
                            Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                            Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            0,
                            0,
                            dt.Rows[i]["Batch"].ToString(),
                            "",
                            Convert.ToString(dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"]),
                            0
                            ))
                    {
                        result = mySql.Result;
                        DoHide();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, result);
                        mySql.RollBack();
                        return "Mặt hàng này sẽ không được lưu!";
                    }
                }
                else if (dr.RowState == DataRowState.Modified)
                {
                    if (!cls.Update(
                            mySql.Transaction,
                            id,
                            txtID.Text,
                            9,
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["Product_Name"].ToString(),
                            dt.Rows[i]["OutStock"].ToString(),
                            dt.Rows[i]["InStock"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            Convert.ToDecimal(dt.Rows[i]["UnitConvert"] == DBNull.Value ? 0 : dt.Rows[i]["UnitConvert"]),
                            Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                            Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            0,
                            0,
                            dt.Rows[i]["Batch"].ToString(),
                            "",
                            Convert.ToString(dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"]),
                            0
                            )
                            )
                    {
                        DoHide();
                        result = mySql.Result;
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, result);
                        mySql.RollBack();
                        return "Mặt hàng này sẽ không được lưu!";
                    }
                }
                else if (dr.RowState == DataRowState.Deleted)
                {
                    
                    if (!cls.Delete(mySql.Transaction, dt.Rows[i]["ID", DataRowVersion.Original].ToString()))
                    {
                        DoHide();
                        result = mySql.Result;
                        mySql.RollBack();
                        DoHide();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colQuantity, result);
                        return "Mặt hàng này sẽ không được lưu!";
                    }
                }
                

            }
            return result;
        }

        public override void SetData(string id)
        {
         
            var stockTransfer = new STOCK_TRANSFER();
            if (!stockTransfer.Get(id))
            {
                XtraMessageBox.Show("Không tìm thấy thông tin phiếu này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Updated();

            m_Status = Actions.Update;
            txtID.Text = stockTransfer.ID;

            if (m_Status == Actions.Update)
            {
                txtID.Properties.ReadOnly = true;
            }
            dtCreated.DateTime = stockTransfer.RefDate;
            txtEmployeeSender.EditValue = stockTransfer.Sender_ID;
            txtEmployeeName.EditValue = stockTransfer.Receiver_ID;
            txtDescription.Text = stockTransfer.Description;

            tRASFER_DETAILTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            tRASFER_DETAILTableAdapter.ClearBeforeFill = true;
            tRASFER_DETAILTableAdapter.Fill(dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL, txtID.Text);

            
            DisableControl(true);
              
			NotSave=false;
			Bar.Bar.bbiSaveM.Enabled = false;
        }

        public override string uc_Update()
        {
            if (!MyRule.IsEdit("bbiTransfer")) 
            {
                MyRule.Notify();
                return ""; 
            }

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();

            SysLog.Insert("Phiếu Chuyển Kho", "Cập Nhật", txtID.Text);

            if (!DetailCheck()) return "";

            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            if (CODE.TypeSoft == 1 || CODE.TypeSoft == 0)
            {
                if (INVENTORY_DETAIL.Count > INVENTORY_DETAIL.LimitRecord)
                {
                    CODE.Notify();
                    return "Phần mềm bị giới hạn dữ liệu, vui lòng đăng ký phiên bản thu phí.";
                }
            }

            var mySql = new SqlHelper();
            string result = mySql.Start();

            var cls = new STOCK_TRANSFER(
                txtID.Text,
                dtCreated.DateTime,
                "",
                9,
                "All",
                Convert.ToString(txtEmployeeSender.EditValue),
                "All",
                Convert.ToString(txtEmployeeName.EditValue),
                "",
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                true,
                MyLogin.UserId,
                false,
                  0,
                txtDescription.Text,
                true
                );

            //var cls = new Perfect.ERP.Transfer.STOCK_TRANSFER(
            //    txtID.Text, //ID
            //    dtCreated.DateTime, //RefDate
            //    "", //Ref_OrgNo
            //    9, //RefType
            //    "", //Department_ID
            //    txtEmployeeSender.EditValue.ToString(), //Employee_ID
            //    "", //FromStock_ID
            //    txtEmployeeName.EditValue.ToString(), //Sender_ID
            //    "", //ToStock_ID
            //    "", //Receiver_ID
            //    "", //Branch_ID
            //    "", //Contract_ID
            //    "", //Currency_ID
            //    0, //ExchangeRate
            //    "", //Barcode
            //    Convert.ToDecimal(colAmount.SummaryItem.SummaryValue), //Amount
            //    true, //IsReview
            //    MyLogin.UserId, //User_ID
            //    false, //IsClose
            //      0, //Sorted
            //    txtDescription.Text, //Description
            //    true //Active
            //    );


            

            if (! cls.Update(mySql.Transaction))
            {
                 result = mySql.Result;
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show( result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return result;
            }
           
            result = DetailSave(mySql);
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                 return result;
            }

            mySql.Commit();
           
            if (chxIsPrint.Checked) Print(false);
            
            DoHide();
            Cancel();
            SetData(txtID.Text);
            Cursor.Current = Cursors.Default;
            return result;
        }

        public void Print(bool preview)
        {
            if (!MyRule.IsPrint("bbiTransfer")) 
            {
                MyRule.Notify();
                return; 
            }

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();

            SysLog.Insert("Phiếu Chuyển Kho", "In", txtID.Text);
            
            dsTRANSFER_DETAIL.STOCK_TRANSFER.Rows.Clear();
            /**/

            dsTRANSFER_DETAIL.STOCK_TRANSFER.AddSTOCK_TRANSFERRow(
                txtID.Text,
                dtCreated.DateTime,
                9,
                "",
                "",
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                txtDescription.Text,                
                true,
                txtEmployeeName.Text,
                txtEmployeeName.EditValue == null ? "" : txtEmployeeName.EditValue.ToString(),
                txtEmployeeSender.EditValue == null ? "" : txtEmployeeSender.EditValue.ToString(),
                txtEmployeeSender.Text
                );

            foreach (DataRow dtSale in dsTRANSFER_DETAIL.STOCK_TRANSFER_DETAIL.Rows)
            {
                foreach (DataRow dtUnit in dsUnit.UNIT.Rows)
                {
                    if (dtSale["Unit"].ToString() == dtUnit["Unit_ID"].ToString())
                    {
                        dtSale["Unit_Name"] = dtUnit["Unit_Name"].ToString();
                        break;
                    }
                }
                foreach (DataRow drStock in dsSTOCK.STOCK.Rows)
                {
                    if (dtSale["InStock"].ToString() == drStock["Stock_ID"].ToString())
                    {
                        dtSale["InStockName"] = drStock["Stock_Name"].ToString();
                        break;
                    }
                }
                foreach (DataRow drStock in dsSTOCK.STOCK.Rows)
                {
                    if (dtSale["OutStock"].ToString() == drStock["Stock_ID"].ToString())
                    {
                        dtSale["OutStockName"] = drStock["Stock_Name"].ToString();
                        break;
                    }
                }
            }

            var rpt = new rptStockTransfer(dsTRANSFER_DETAIL, "RD0000023", "Phiếu Chuyển Kho",Strings.Format(dtCreated.DateTime, "dd/MM/yyyy"));
            if (preview)
            {
                rpt.ShowPreview();
                return;
            }
            rpt.PrintDialog();
        }
        
		public override void Print()
        {
            Print(true);
        }

        public override void DeleteSelected()
        {
            if (gbList.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Bạn có chắc là xóa tất cả dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                gbList.DeleteSelectedRows();
            }
            else
            {
                gbList.DeleteRow(gbList.FocusedRowHandle);
            }
            gbList.UpdateCurrentRow();
        }
        public override void SelectAll()
        {
            gbList.SelectAll();
        }

        public override void DeleteAll()
        {
            if (XtraMessageBox.Show("Bạn có chắc là xóa tất cả dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            gbList.SelectAll();
            gbList.DeleteSelectedRows();
            Clear();
        }

        public override void Search()
        {
            var xfmProducts = new xfmProducts(true);
            xfmProducts.ItemSelected += XfmProductsItemSelected;
            xfmProducts.ShowDialog();
        }

        public override void ProductDetail()
        {
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            object Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            var product = new PRODUCT();
            product.Get(Arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }

        public void SaveLayout()
        {
            //SaveLayout(Application.StartupPath + "\\Layout\\xucTranfers.xml");
        }

        public override void SaveLayout(string name)
        {
            //try
            //{
            //    gbList.SaveLayoutToXml(name);
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi:\n\t" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        public override void Inventory()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;
            var xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(arg.ToString(), "");
            xfmInventoryDetail.ShowDialog(this);
        }

        public override void History()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;
            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(arg.ToString(), "");
            xfmHistory.ShowDialog(this);
        }

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }

        #region Grid

        private void gbList_Layout(object sender, EventArgs e)
        {
            SaveLayout();
        }

        private void gbList_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {

                double quantity = 0.0;
                double Amount = 0.0;

                for (int i = 0; i < gbList.RowCount; i++)
                {
                    Amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                    quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = Amount / quantity;
                e.TotalValueReady = true;
            }
        }

        private void gbList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            
            gbList.ClearColumnErrors();
            if (_mColumn == Column.Lock) return;
            gbList.UpdateCurrentRow();

            if (_mColumn == Column.None) 
            {
                switch (e.Column.FieldName)
                {
                    case "Quantity":
                        _mColumn = Column.Quantity;
                        break;
                    case "Product_ID":
                        _mColumn = Column.ID;
                        break;
                    case "UnitPrice":
                        _mColumn = Column.Price;
                        break;
                    case "Amount":
                        _mColumn = Column.Amount;
                        break;
                    case "Stock_ID":
                        _mColumn = Column.StockID;
                        break;
                    case "OutStock":
                        _mColumn = Column.OutStock;
                        break;
                    case "InStock":
                        _mColumn = Column.InStock;
                        break;
                    case "ItemID":
                        _mColumn = Column.Name;
                        break;
                    case "Unit":
                        _mColumn = Column.Unit;
                        break;
               
                }
            }


            switch (_mColumn)
            {
                case Column.None:
                    return;
               
                case Column.Quantity:
                    {
                        object UnitPrice = gbList.GetRowCellValue(e.RowHandle, "UnitPrice");
                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Amount", Convert.ToDouble(e.Value) * Convert.ToDouble(UnitPrice == DBNull.Value ? 0 : UnitPrice));
                        _mColumn = Column.None;
                        Total();
                        break;

                    }
                case Column.Price:
                    {
                        object qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Amount", Convert.ToDouble(e.Value) * Convert.ToDouble(qty == DBNull.Value ? 0 : qty));
                        _mColumn = Column.None;
                        Total();
                         break; ;
                    }
                case Column.Amount:
                    {
                        double UnitPrice = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        double Qty = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Quantity"));

                        _mColumn = Column.Lock;
                        if (Qty == 0)
                        {
                            if (UnitPrice != 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", Convert.ToDouble(e.Value) / UnitPrice);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", 1);
                                gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Convert.ToDouble(e.Value));
                            }
                        }
                        else
                        {
                            if (UnitPrice == 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Convert.ToDouble(e.Value) / Qty);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", Convert.ToDouble(e.Value) / UnitPrice);
                            }
                        }
                        Total();
                     _mColumn = Column.None;
                        break; ;
                    }
                case Column.OutStock:
                    {
                        gbList.SetColumnError(colOutStock, null);
                        _mColumn = Column.Lock;
                        object Arg = gbList.GetRowCellValue(e.RowHandle, "InStock");
                        if (Arg != null)
                        {
                            if (Arg == e.Value)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "OutStock", null);
                                gbList.SetColumnError(colOutStock, "Trùng Kho");
                            }
                        }
                        _mColumn = Column.None;
                    }
                    break;
                case Column.InStock:
                    {
                        gbList.SetColumnError(colInStock, null);
                        _mColumn = Column.Lock;
                        object arg = gbList.GetRowCellValue(e.RowHandle, "OutStock");
                        if (arg != null)
                        {
                            if (arg == e.Value)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "InStock", null);
                                gbList.SetColumnError(colInStock, "Trùng Kho");
                            }
                        }
                        _mColumn = Column.None;
                    }
                    break;
                case Column.ID:
                    gbList.SetColumnError(colProduct_ID, null);
                    _mColumn = Column.Lock;
                    gbList.SetRowCellValue(gbList.FocusedRowHandle, "STT", DBNull.Value);
                    if (e.Value != null)
                    {
                        ProductAdd(e.Value.ToString());
                    }
                    else
                    {
                        gbList.SetColumnError(colProduct_ID, "Vui lòng chọn hàng hoá.");
                    }
                    _mColumn = Column.None;
                    break;
                case Column.Name:
                    gbList.SetColumnError(colItemID, null);
                    _mColumn = Column.Lock;
                    gbList.SetRowCellValue(gbList.FocusedRowHandle, "STT", DBNull.Value);
                    if (e.Value != null)
                    {
                       ProductAdd(e.Value.ToString());
                    }
                    else
                    {
                        gbList.SetColumnError(colItemID, "Vui lòng chọn hàng hoá.");
                    }
                    _mColumn = Column.None;
                    break;
                case Column.Unit:
                    {
                        _mColumn = Column.Lock;
                        gbList.SetColumnError(colUnit, null);
                        object productID = gbList.GetRowCellValue(e.RowHandle, "Product_ID") == DBNull.Value
                                                ? ""
                                                : gbList.GetRowCellValue(e.RowHandle, "Product_ID");

                        var product = new PRODUCT();
                        object qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        if (product.Get(productID.ToString()) == "OK")
                        {
                            if (e.Value != null)
                            {
                                var unitconvert = new PRODUCT_UNIT();
                                decimal convert = unitconvert.GetConvert(product.Product_ID, product.Unit, e.Value.ToString());
                                decimal price = Convert.ToDecimal(product.Org_Price) * convert;
                                decimal amount = price * Convert.ToDecimal(qty);
                                if (convert == 0)
                                {
                                    gbList.SetRowCellValue(e.RowHandle, "Unit", null);
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", 1);
                                    gbList.SetRowCellValue(e.RowHandle, "Description", null);
                                    gbList.SetColumnError(colUnit, "Hàng hoá này không có đơn vị quy đổi này!");
                                }
                                else
                                {
                                    var unit1 = new UNIT();
                                    unit1.Get(product.Unit);
                                    string unitPro = unit1.Unit_Name.ToString();
                                    var unit2 = new UNIT();
                                    unit2.Get(e.Value.ToString());
                                    string unitConver = unit2.Unit_Name.ToString();
                                    var tenQC = convert.ToString(convert + " " + unitPro + "/" + unitConver);
                                    if (e.Value.ToString() != product.Unit)
                                    {
                                        gbList.SetRowCellValue(e.RowHandle, "Description", tenQC);

                                    }
                                    else
                                    {
                                        gbList.SetRowCellValue(e.RowHandle, "Description", null);
                                    }
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", convert);
                                    gbList.SetRowCellValue(e.RowHandle, "UnitPrice", price);
                                    gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                                }
                            }
                        }
                        _mColumn = Column.None;
                    }
                    break;
            }
            Total();
            _mColumn = Column.None;
			NotSave=true;
			Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void gbList_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            
        }
        

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Column)
                {
                  
                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                    Bar.Bar.bm.HideToolBarsPopup();
                    Bar.Bar.pm.HidePopup();

                }
                if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.ColumnButton)
                {
               Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                    Bar.Bar.bm.HideToolBarsPopup();
                    Bar.Bar.pm.HidePopup();
                    DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Row)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                 }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.RowCell)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                    
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.EmptyRow)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                   
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.RowFooter)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                }
            }

            if (e.Button == MouseButtons.Left)
                DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));

            DisableMenu(false);
            if (gbList.RowCount - 1 == 0)
            {
                DisableMenu(true);
                return;
            }

            var view = gbList;
            if (view != null)
            {
                var ex = new RowClickEventArgs(false ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

                object Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

                if (Arg == null)
                {
                    Bar.Bar.bbiProduct.Enabled = false;
                    return;
                }
            }
            Bar.Bar.bbiProduct.Enabled = true;
        }

        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e == null) throw new ArgumentNullException("e");
            if (e.RowHandle == GridControl.InvalidRowHandle)
            {
                e.Handled = true;
                e.Painter.DrawObject(e.Info);

                Rectangle r = e.Bounds;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 165, 165, 0)), r);
                r.Height--;
                r.Width--;
                e.Graphics.DrawRectangle(Pens.Blue, r);
            }

            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                 if (gbList.FocusedColumn == colQuantity)
                {
                    _mColumn = Column.Lock;
                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colQuantity, 0);
                    _mColumn = Column.None;
                }
                else if (gbList.FocusedColumn == colUnitPrice)
                {
                    _mColumn = Column.Lock;
                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colUnitPrice, 0);
                    _mColumn = Column.None;
                 }
                else if (gbList.FocusedColumn == colAmount)
                {
                    _mColumn = Column.Lock;
                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colAmount, 0);
                    _mColumn = Column.None;
                }
                else
                {
                    DeleteSelected();
                }
      }

            base.ProcessDialogKey(e.KeyData);
        }

        #endregion

        void DoShowMenu(GridHitInfo hi)
        {
            GridViewMenu menu;
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }

        private void chxBarcode_CheckedChanged(object sender, EventArgs e)
        {
            lcBarcode.Visibility = chxBarcode.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void txtEmployeeName_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void rpgProduct_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void rpProductName_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void rpStocks_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void rpToStock_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void rpUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }
		
		private void rpgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessDialogKey(e.KeyData);
        }

        private void rpgProduct_DoubleClick(object sender, EventArgs e)
        {
            ProductDetail();
        }

        protected override void Refresh()
        {
            Updated();
            base.Refresh();
        }

        private void txtEmployeeID_EditValueChanged(object sender, EventArgs e)
        {
            txtEmployeeName.EditValue = txtEmployeeID.EditValue;
        }
    }
}
