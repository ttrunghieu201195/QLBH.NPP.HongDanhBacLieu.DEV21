using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;
using Perfect.Dictionary;
using Perfect.Dictionary.UI;
using Perfect.Dictionary.UI.UBarcode;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Transfer.dsSTOCK_TRANSFER_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Data.Helper;
using DevExpress.XtraGrid;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Sale.Transfer
{
    public partial class xucPacketA : xucBaseB
    {
        Column m_Column = new Column();
        public EnumRefType Part { get { return m_part; } set { m_part = value; } }
        public EnumRefType m_part = new EnumRefType();

        public enum Column
        {
            None = 0,
            Quantity = 1,
            Price = 2,
            Amount = 3,
            ID = 4,
            Lock = 5,
            ImportTax_ID = 6,
            ExportTax_ID = 7,
            LuxuryTax_ID = 8,
            Vat_ID = 9,
            ChargeTransport = 10,
            ChargeDelivery = 11,
            Discount = 12,
            Vat = 13,
            Stock_ID = 14,
            Name = 15,
            OutStock = 16,
            InStock = 17,
            Unit = 18
        }

        public xucPacketA(EnumRefType Type)
        {
            InitializeComponent();
            //btnSimple.Visible = true;
            //dtCreated.DateTime = MyLogin.LoginDate;
            DisableControl(false);
            m_Status = Actions.None;
            // m_part = PerfectPart.TransferPack1;
            dtCreated.DateTime = MyLogin.LoginDate;
            this.m_part = Type;
            Init();
            colBatch.Visible = SysOption.Batch;

        }

        public void LoadDefaultProduct(EnumRefType type)
        {
            this.m_part = type;
            Product_Init();
        }

        public void SetDefaultStock(string OutStock, string InStock)
        {
           
        }

        public void Customer_Init()
        {
            eMPLOYEETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            eMPLOYEETableAdapter.Fill(dsEmployee.EMPLOYEE);
        }

        public void SetEmployee(EMPLOYEE item)
        {
            txtEmployeeName.EditValue = item.Employee_ID;
        }

        public void Stock_Init()
        {
            var adapter = new STOCKTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            adapter.ClearBeforeFill = true;
            adapter.Fill(dsSTOCK.STOCK);

            DataRow dr = dsSTOCK.STOCK.NewSTOCKRow();
            dr["Stock_ID"] = "All";
            dr["Stock_Name"] = "(Mặc định)";
            dr["ActiveInt"] = 1;
            dsSTOCK.STOCK.Rows.InsertAt(dr, 0);

        }

        public void SetStock(STOCK Item)
        {
            //dsSTOCK.STOCK.AddSTOCKRow(Item.Stock_Name, Item.Stock_ID);
            Stock_Init();
        }

        public void Product_Init()
        {
            var adapter = new PRODUCTByTypeTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            if (m_part == EnumRefType.TransferPack1)
            {
                adapter.Fill(dsPRODUCT.PRODUCTByType, 3);
            }
            else
            {
                adapter.Fill(dsPRODUCT.PRODUCTByType, 4);
            }
        }

        public void Unit_Init()
        {
            UNITTableAdapter adapter = new UNITTableAdapter();
            adapter.Connection.ConnectionString = SqlHelper.ConnectString;
            adapter.ClearBeforeFill = true;
            adapter.Fill(dsUnit.UNIT);
        }

       public  void Updated()
        {
            Cursor.Current = Cursors.WaitCursor;
           // SetWaitDialogCaption("Nạp danh sách khách hàng...");
            Customer_Init();
            //SetWaitDialogCaption("Nạp danh sách kho hàng...");
            Stock_Init();
           // SetWaitDialogCaption("Nạp danh sách hàng hoá...");
            Product_Init();
           // SetWaitDialogCaption("Nạp danh sách đơn vị...");
            Unit_Init();
            //SetWaitDialogCaption("Nạp cấu hình....");
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        protected void Init()
        {
            //CreateWaitDialog();

            Updated();


            SetWaitDialogCaption("Nạp cấu hình....");
            FormatColumns(rpgProduct, "Product_ID", 0, 100, "Mã Hàng");
            FormatColumns(rpgProduct, "Product_Name", 1, 200, "Hàng Hoá");
            FormatColumns(rpgProduct, "Quantity", 2, 200, "Số Lượng", rpVal);
            FormatColumns(rpgProduct, "Org_Price", 3, 200, "Giá Vốn", rpVal);
            FormatColumns(rpgProduct, "Amount", 4, 200, "Thành Tiền", rpVal);

            FormatColumns(rpUnit, "Unit_ID", 1, 100, "Mã");
            FormatColumns(rpUnit, "Unit_Name", 0, 200, "Đơn Vị");

            FormatColumns(rpProductName, "Product_ID", 1, 100, "Mã Hàng");
            FormatColumns(rpProductName, "Product_Name", 0, 200, "Hàng Hoá");
            FormatColumns(rpProductName, "Quantity", 2, 200, "Số Lượng", rpVal);
            FormatColumns(rpProductName, "Org_Price", 3, 200, "Giá Vốn", rpVal);
            FormatColumns(rpProductName, "Amount", 4, 200, "Thành Tiền", rpVal);


            FormatColumns(rpToStock, "Stock_ID", 1, 100, "Mã");
            FormatColumns(rpToStock, "Stock_Name", 0, 200, "Kho Hàng");

            FormatColumns(rpgStock, "Stock_ID", 1, 100, "Mã");
            FormatColumns(rpgStock, "Stock_Name", 0, 200, "Kho Hàng");

            dtCreated.DateTime = DateTime.Now;
            SetWaitDialogCaption("Nạp cấu hình giao diện....");
            ReadLayout();
            SetWaitDialogCaption("Nạp dữ liệu cũ....");
            RestoreHistory();

            ucBarcode.ItemSelected += new XucBaseBarcode.ItemSelectedEventHander(ucBarcode_ItemSelected);
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);

            DisableControl(true);
            Add();
            

            if (dsSTOCK.STOCK.Rows.Count<3)
            {
               
                    XtraMessageBox.Show("Chức năng chuyển kho phải thực hiện trên hai kho.Vui lòng tạo thêm kho để thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                
            }
            if (CODE.TypeSoft < 400 & CODE.TypeSoft != 0)
            {
                //colUnit.OptionsColumn.AllowEdit = false;
                colUnit.OptionsColumn.ReadOnly = true;
            }
            _exportView = gbList;
            SetWaitDialogCaption("Nạp hoàn thành....");
            DoHide();

            //barManager1.SetPopupContextMenu(gcList, popupMenu1);
            //sTOCK_OUTWARD_DETAILTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL);
        }

        void ucBarcode_ItemSelected(object sender, Barcode item)
        {
            
            if (m_Status == Actions.None) return;

            if (item.Action == TypeAdd.Duplicate)
            {

                //dsTransfer.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                //    0,
                //    item.Item.Product_Type_ID,
                //    "",
                //    txtID.Text,
                //    item.Item.Product_ID,
                //    item.Item.Product_ID,
                //    item.Item.Product_Name,
                //    "All",
                //    item.Item.Provider_ID,
                //    item.Item.Unit,
                //    1,
                //    Convert.ToDecimal(item.Price),
                //    Convert.ToDecimal(item.Quantity),
                //    Convert.ToDecimal(item.Amount),
                //    "",
                //    "",
                //    txtDescription.Text,
                //    0,
                //    9,
                //    0,
                //    0,
                //    Guid.NewGuid(),
                //    "",0,0,0,0
                //    );

            }
            else if (item.Action == TypeAdd.Add)
            {
                //DataRow[] foundRows = dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Select("Product_ID='" + item.Item.Product_ID+"'");
                //if (foundRows==null)
                //{
                //    //MessageBox.Show("Oh");

                //}

                Inventory.Transfer.dsSTOCK_TRANSFER_DETAIL.STOCK_TRANSFER_DETAILDataTable dt = dsTransfer.STOCK_TRANSFER_DETAIL;


                bool Add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
                    Add = true;
                    double qty = Convert.ToDouble(dt.Rows[i]["Quantity"] ?? 0) + item.Quantity; ;
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

                if (!Add)
                {
                   // dsTransfer.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                   //0,
                   // item.Item.Product_Type_ID,
                   // "",
                   // txtID.Text,
                   // item.Item.Product_ID,
                   // item.Item.Product_ID,
                   // item.Item.Product_Name,
                   // "All",
                   // item.Item.Provider_ID,
                   // item.Item.Unit,
                   // 1,
                   // Convert.ToDecimal(item.Price),
                   // Convert.ToDecimal(item.Quantity),
                   // Convert.ToDecimal(item.Amount),
                   // "",
                   // "",
                   // txtDescription.Text,
                   // 0,
                   // 9,
                   // 0,
                   // 0,
                   // Guid.NewGuid(),
                   // "",0,0,0,0
                   // );
                }
            }
            else if (item.Action == TypeAdd.Replace)
            {
                Inventory.Transfer.dsSTOCK_TRANSFER_DETAIL.STOCK_TRANSFER_DETAILDataTable dt = dsTransfer.STOCK_TRANSFER_DETAIL;
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
                   // dsTransfer.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                   //0,
                   // item.Item.Product_Type_ID,
                   // "",
                   // txtID.Text,
                   // item.Item.Product_ID,
                   // item.Item.Product_ID,
                   // item.Item.Product_Name,
                   // "All",
                   // item.Item.Provider_ID,
                   // item.Item.Unit,
                   // 1,
                   // Convert.ToDecimal(item.Price),
                   // Convert.ToDecimal(item.Quantity),
                   // Convert.ToDecimal(item.Amount),
                   // "",
                   // "",
                   // txtDescription.Text,
                   // 0,
                   // 9,
                   // 0,
                   // 0,
                   // Guid.NewGuid(),
                   // "",0,0,0,0
                   // );
                }
            }
            else if (item.Action == TypeAdd.Single)
            {
                Inventory.Transfer.dsSTOCK_TRANSFER_DETAIL.STOCK_TRANSFER_DETAILDataTable dt = dsTransfer.STOCK_TRANSFER_DETAIL;
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
                   // dsTransfer.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
                   //0,
                   // item.Item.Product_Type_ID,
                   // "",
                   // txtID.Text,
                   // item.Item.Product_ID,
                   // item.Item.Product_ID,
                   // item.Item.Product_Name,
                   // "All",
                   //item.Item.Provider_ID,
                   // item.Item.Unit,
                   // 1,
                   // Convert.ToDecimal(item.Price),
                   // Convert.ToDecimal(item.Quantity),
                   // Convert.ToDecimal(item.Amount),
                   // "",
                   // "",
                   // txtDescription.Text,
                   // 0,
                   // 9,
                   // 0,
                   // 0,
                   // Guid.NewGuid(),
                   // "",0,0,0,0
                   // );
                }
            }
        }

        protected bool DetailCheck()
        {
            if (gbList.RowCount - 1 == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                DoHide();
                return false;
            }

            int j = 0;

            Inventory.Transfer.dsSTOCK_TRANSFER_DETAIL.STOCK_TRANSFER_DETAILDataTable dt =
                dsTransfer.STOCK_TRANSFER_DETAIL;

            PRODUCT_BUILD build = new PRODUCT_BUILD();

            string text;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState == DataRowState.Deleted) continue;

                j++;

                text = gbList.GetDisplayTextByColumnValue(colProduct_ID, dt.Rows[i]["Product_ID"].ToString());
                if (text.Trim() == "")
                {
                    DoHide();
                    dt.Rows[i]["Error"] = -1;
                    dt.Rows[i]["ErrorText"] = "Chưa chọn mặt hàng.\n\tDòng số: " + (j);
                    XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    //dt.Rows.RemoveAt(i);

                    return false;
                }

                if (m_part == EnumRefType.TransferPack1)
                {
                    if (Convert.ToInt32(dt.Rows[i]["Product_Type_ID"]) == 3)
                    {
                        if (build.GetList(dt.Rows[i]["Product_ID"].ToString()).Rows.Count == 0)
                        {
                            DoHide();
                            dt.Rows[i]["Error"] = -1;
                            dt.Rows[i]["ErrorText"] = "Cấu tạo của " + dt.Rows[i]["Product_Name"] +
                                                      " không có. \n\tDòng số" + (j);
                            XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    if (Convert.ToInt32(dt.Rows[i]["Product_Type_ID"]) == 4)
                    {
                        if (build.GetList(dt.Rows[i]["Product_ID"].ToString()).Rows.Count == 0)
                        {
                            DoHide();
                            dt.Rows[i]["Error"] = -1;
                            dt.Rows[i]["ErrorText"] = "Cấu tạo của " + dt.Rows[i]["Product_Name"] +
                                                      " không có. \n\tDòng số" + (j);
                            XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }


                text = gbList.GetDisplayTextByColumnValue(colInStock, dt.Rows[i]["InStock"].ToString());
                if (text.Trim() == "")
                {
                    DoHide();
                    dt.Rows[i]["Error"] = -1;
                    dt.Rows[i]["ErrorText"] = "Kho đến bị rỗng.\n\tDòng số: " + (j);
                    XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                    //dt.Rows.RemoveAt(i);
                    return false;
                }

                text = gbList.GetDisplayTextByColumnValue(colOutStock, dt.Rows[i]["OutStock"].ToString());
                if (text.Trim() == "")
                {
                    DoHide();
                    dt.Rows[i]["Error"] = -1;
                    dt.Rows[i]["ErrorText"] = "Từ kho bị rỗng.\n\tDòng số: " + (j);
                    XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                    //dt.Rows.RemoveAt(i);
                    return false;
                }


                if (dt.Rows[i]["InStock"] == null | dt.Rows[i]["InStock"] == DBNull.Value)
                {
                    DoHide();
                    dt.Rows[i]["Error"] = -1;
                    dt.Rows[i]["ErrorText"] = "Kho đến bị rỗng.\n\tDòng số: " + (j);
                    XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    return false;
                }
                if (dt.Rows[i]["OutStock"] == null | dt.Rows[i]["OutStock"] == DBNull.Value)
                {
                    DoHide();
                    dt.Rows[i]["Error"] = -1;
                    dt.Rows[i]["ErrorText"] = "Từ kho bị rỗng.\n\tDòng số: " + (j);
                    XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                    return false;
                }
                if (dt.Rows[i]["InStock"].ToString() == dt.Rows[i]["OutStock"].ToString())
                {

                    if (m_part == EnumRefType.TransferPack1)
                    {
                        int type = Convert.ToInt32(dt.Rows[i]["Product_Type_ID"]);
                        if (type != 3)
                        {
                            DoHide();
                            dt.Rows[i]["Error"] = -1;
                            dt.Rows[i]["ErrorText"] = "Kho đến và kho đi trùng nhau.\n\tDòng số: " + (j);
                            XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dt.Rows[i]["Product_Type_ID"]) != 4)
                        {
                            DoHide();
                            dt.Rows[i]["Error"] = -1;
                            dt.Rows[i]["ErrorText"] = "Kho đến và kho đi trùng nhau.\n\tDòng số: " + (j);
                            XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                if (dt.Rows[i]["Product_ID"] == null | dt.Rows[i]["Product_ID"] == DBNull.Value)
                {
                    DoHide();
                    dt.Rows[i]["Error"] = -1;
                    dt.Rows[i]["ErrorText"] = "Chưa chọn mặt hàng.\n\tDòng số: " + (j);
                    XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Thông Báo", MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
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


                if (Convert.ToInt32(dt.Rows[i]["Error"]) == -1)
                {
                    DoHide();
                    XtraMessageBox.Show(dt.Rows[i]["ErrorText"].ToString(), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }

        string DetailSave(SqlHelper mySql)
        {
            string result = "OK";

            STOCK_TRANSFER_DETAIL cls = new STOCK_TRANSFER_DETAIL();

            Inventory.Transfer.dsSTOCK_TRANSFER_DETAIL.STOCK_TRANSFER_DETAILDataTable dt = dsTransfer.STOCK_TRANSFER_DETAIL;

            int row = 0;
            string ID = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    row++;
                    ID = dt.Rows[i]["ID"].ToString();
                    //MessageBox.Show(dsTransfer.STOCK_TRANSFER_DETAIL_GetList.Rows[i]["Product_ID"].ToString());

                }

                if (dr.RowState == DataRowState.Added)
                {

                    if (!cls.Insert(
                            mySql.Transaction,
                            Guid.NewGuid().ToString(),
                            txtID.Text,
                           (int)m_part,
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["Product_Name"].ToString(),
                            dt.Rows[i]["OutStock"].ToString(),
                            dt.Rows[i]["InStock"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                            Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                            Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            0,
                            0,
                            dt.Rows[i]["Batch"].ToString(),
                            "",
                            txtEmployeeName.Text,
                            0
                            ))
                    {
                        // XtraMessageBox.Show("Lỗi:\n\t" + result);
                        result = mySql.Result;
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, result);
                        mySql.RollBack();
                        return result;
                    }
                }
                else if (dr.RowState == DataRowState.Modified)
                {
                    if (!cls.Update(
                            mySql.Transaction,
                            ID,
                            txtID.Text,
                            (int)m_part,
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["Product_Name"].ToString(),
                            dt.Rows[i]["OutStock"].ToString(),
                            dt.Rows[i]["InStock"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                            Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                            Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            0,
                            0,
                            dt.Rows[i]["Batch"].ToString(),
                            "",
                            txtEmployeeName.Text,
                            0
                            )
                            )
                    {
                        // XtraMessageBox.Show("Lỗi:\n\t" + result);
                        result = mySql.Result;
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, result);
                        mySql.RollBack();
                        return result;
                    }

                }
                else if (dr.RowState == DataRowState.Modified)
                {

                    if (!cls.Delete(mySql.Transaction, dt.Rows[i]["ID", DataRowVersion.Original].ToString()))
                    {
                        //XtraMessageBox.Show("Lỗi:\n\t" + result);
                        result = mySql.Result;
                        mySql.RollBack();
                        DoHide();
                        //XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colQuantity, result);
                        return result;
                    }
                }

            }

            return result;
        }

        public override string uc_Save()
        {


            if (!MyRule.IsAdd("bbiPacket")) return "";


            if (!DetailCheck()) return "";

           // CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            if (CODE.TypeSoft == 1)
            {
                if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 2000)
                {
                    //alc.Show("")
                    Thread.Sleep(10000);
                }
                else
                {
                    if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 3000)
                    {
                        //alc.Show("")
                        Thread.Sleep(15000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 4000)
                    {
                        //alc.Show("")
                        Thread.Sleep(30000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 5000)
                    {
                        //alc.Show("")
                        Thread.Sleep(60000);
                    }
                }
            }

            SqlHelper mySql = new SqlHelper();

            string result = mySql.Start();
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return result;
            }

            STOCK_TRANSFER cls = new STOCK_TRANSFER(
                txtID.Text,
                dtCreated.DateTime,
                "",
               (int)m_part,
                "All",
                txtEmployeeName.EditValue.ToString(),
                "All",
                txtEmployeeName.EditValue.ToString(),
                "",
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                true,
                MyLogin.UserId,
                false,
                0,
                txtDescription.Text,
                true
                );



            if (!cls.Insert(mySql.Transaction))
            {
                //XtraMessageBox.Show("Lỗi:\n\t" + result);
                result = mySql.Result;
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return result;
            }

            
            //Luu chi tiết thành phẩm
            result = DetailSave(mySql);
            if (result != "OK")
            {
                // XtraMessageBox.Show("Lỗi:\n\t" + result);
                mySql.RollBack();
                DoHide();
                //XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return result;
            }

            mySql.Commit();
            Cancel();
            DoHide();
            SetData(txtID.Text);
            return result;
        }

        public override string uc_Change()
        {

            if (!MyRule.IsEdit("bbiPacket")) return "";

            if (!DetailCheck()) return "";

            SetWaitDialogCaption("Đang lưu dữ liệu...");

            if (CODE.TypeSoft == 1)
            {
                if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 2000)
                {
                    //alc.Show("")
                    Thread.Sleep(10000);
                }
                else
                {
                    if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 3000)
                    {
                        //alc.Show("")
                        Thread.Sleep(15000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 4000)
                    {
                        //alc.Show("")
                        Thread.Sleep(30000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 5000)
                    {
                        //alc.Show("")
                        Thread.Sleep(60000);
                    }
                }
            }

            var sql = new SqlHelper();
            string result = sql.Start();
            if (result != "OK")
            {
                DoHide();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }


            STOCK_TRANSFER cls = new STOCK_TRANSFER(
                txtID.Text,
                dtCreated.DateTime,
                "",
                (int)m_part,
                "All",
                txtEmployeeName.EditValue.ToString(),
                "All",
                txtEmployeeName.EditValue.ToString(),
                "",
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                true,
                MyLogin.UserId,
                false,
                0,
                txtDescription.Text,
                true
                );

            if (!cls.Update(sql.Transaction))
            {
                DoHide();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sql.RollBack();
                return result;
            }

           result = DetailSave(sql);
            if (result != "OK")
            {
                DoHide();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sql.RollBack();
                return result;
            }

            if (result == "OK")
            {
                DoHide();
                sql.Commit();
                Cancel();
                SetData(txtID.Text);
            }

            return result;
        }

        double GetVat(string vat)
        {
            if (vat == "0%")
                return 0;
            else if (vat == "5%")
                return 0.05;
            else if (vat == "10%")
                return 0.1;
            return -1;
        }

        private void gbList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gbList.ClearColumnErrors();
           
            if (m_Column == Column.Lock) return;
            gbList.UpdateCurrentRow();

            if (m_Column == Column.None)
            {
                switch (e.Column.FieldName)
                {
                    case "Quantity":
                        m_Column = Column.Quantity;
                        break;
                    case "Product_ID":
                        m_Column = Column.ID;
                        break;
                    case "UnitPrice":
                        m_Column = Column.Price;
                        break;
                    case "Amount":
                        m_Column = Column.Amount;
                        break;
                    case "Stock_ID":
                        m_Column = Column.Stock_ID;
                        break;
                    case "OutStock":
                        m_Column = Column.OutStock;
                        break;
                    case "InStock":
                        m_Column = Column.InStock;
                        break;
                    case "ItemID":
                        m_Column = Column.Name;
                        break;
                    case "Unit":
                        m_Column = Column.Unit;
                        break;
                    default:
                        m_Column = Column.Lock;
                        SetColor(e.RowHandle);
                        m_Column = Column.None;
                        break;
                }
            }

            switch (m_Column)
            {
                case Column.None:
                    return;
                case Column.Quantity:
                    {
                        object UnitPrice = gbList.GetRowCellValue(e.RowHandle, "UnitPrice");
                        m_Column = Column.Lock;
                        SetColor(e.RowHandle);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", Convert.ToDouble(e.Value) * Convert.ToDouble(UnitPrice == DBNull.Value ? 0 : UnitPrice));
                        m_Column = Column.None;
                        break;

                    }
                case Column.Price:
                    {
                        object Qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        m_Column = Column.Lock;
                        SetColor(e.RowHandle);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", Convert.ToDouble(e.Value) * Convert.ToDouble(Qty == DBNull.Value ? 0 : Qty));
                        m_Column = Column.None;
                        break;
                    }
                case Column.Amount:
                    {
                        double UnitPrice = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        double Qty = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Quantity"));

                        m_Column = Column.Lock;
                        SetColor(e.RowHandle);
                        if (Qty == 0)
                        {
                            if (UnitPrice != 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", Convert.ToDouble(e.Value) / UnitPrice);
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

                        m_Column = Column.None;
                        break;
                    }
                case Column.OutStock:
                    m_Column = Column.Lock;
                    SetColor(e.RowHandle);
                    m_Column = Column.None;
                    break;
                case Column.InStock:
                    m_Column = Column.Lock;
                    SetColor(e.RowHandle);
                    m_Column = Column.None;
                    break;
                case Column.ID:
                    gbList.SetColumnError(colProduct_ID, null);
                    m_Column = Column.Lock;
                    SetColor(e.RowHandle);
                    if (e.Value != null)
                    {
                        //if (e.RowHandle == gbList.RowCount | e.RowHandle < 0)
                        //{
                        //    gbList.AddNewRow();
                        //    gbList.UpdateCurrentRow();
                        //}

                        ProductAdd(e.Value.ToString());

                        //MessageBox.Show(gbList.GetRowCellValue(e.RowHandle, "Error").ToString());
                    }
                    else
                    {
                        gbList.SetColumnError(colProduct_ID, "Vui lòng chọn hàng hoá.");
                    }
                    m_Column = Column.None;
                    break;
                case Column.Name:
                    gbList.SetColumnError(colItemID, null);
                    m_Column = Column.Lock;
                    SetColor(e.RowHandle);

                    if (e.Value != null)
                    {
                        gbList.SetRowCellValue(e.RowHandle, "Error", 0);
                        //if (e.RowHandle == gbList.RowCount | e.RowHandle < 0)
                        //{
                        //    gbList.AddNewRow();
                        //    gbList.UpdateCurrentRow();
                        //}
                        ProductAdd(e.Value.ToString());
                    }
                    else
                    {
                        gbList.SetColumnError(colItemID, "Vui lòng chọn hàng hoá.");
                    }
                    m_Column = Column.None;
                    break;
                case Column.Unit:
                    {
                        m_Column = Column.Lock;
                        SetColor(e.RowHandle);
                        gbList.SetColumnError(colUnit, null);
                        object product_id = gbList.GetRowCellValue(e.RowHandle, "Product_ID") == DBNull.Value
                                                ? ""
                                                : gbList.GetRowCellValue(e.RowHandle, "Product_ID");

                        PRODUCT product = new PRODUCT();

                        if (product.Get(product_id.ToString()) == "OK")
                        {
                            if (e.Value != null)
                            {
                                PRODUCT_UNIT unitconvert = new PRODUCT_UNIT();
                                decimal convert = unitconvert.GetConvert(product.Product_ID, product.Unit, e.Value.ToString());
                                if (convert == 0)
                                {
                                    gbList.SetRowCellValue(e.RowHandle, "Unit", null);
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", 1);
                                    gbList.SetColumnError(colUnit, "Hàng hoá này không có đơn vị quy đổi này!");
                                }
                                else
                                {
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", convert);
                                }
                            }
                        }
                        m_Column = Column.None;
                    }
                    break;
            }

            m_Column = Column.None;
            SaveHistory();
            SaveHistory(string.Format("{0:yyyyMMddhhmmss}_", DateTime.Now) + txtID.Text);
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
        }



        private void gbList_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


        }

        private void ProductAdd(string ID)
        {
            PRODUCT pro = new PRODUCT();

            if (pro.Get(ID) == "OK")
            {
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_Type_ID"], pro.Product_Type_ID);

                SetColor(gbList.FocusedRowHandle);
                //UNIT unit = new UNIT();
                //unit.Get(pro.Unit);
                //Unit_Init(pro.Product_ID);
                if (pro.Product_Type_ID == 3 | pro.Product_Type_ID == 4 | pro.Product_Type_ID == 5)
                {
                    PRODUCT_BUILD productBuild = new PRODUCT_BUILD();

                    DataTable dt = productBuild.GetList(pro.Product_ID);


                    if (dt.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Cấu tạo của " + pro.Product_Name + " không có", "Lỗi",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        gbList.SetFocusedRowCellValue(gbList.Columns["Error"], -1);
                        gbList.SetFocusedRowCellValue(gbList.Columns["ErrorText"], "Cấu tạo của '" + pro.Product_Name + "' không có " + gbList.FocusedRowHandle);

                    }
                }



                gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], pro.Product_Name);
                gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Org_Price);
                gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                gbList.SetFocusedRowCellValue(gbList.Columns["OutStock"], "All");
                gbList.SetFocusedRowCellValue(gbList.Columns["InStock"], pro.Provider_ID);
                
                //gbList.SetRowCellValue(gbList.FocusedRowHandle, "STT", gbList.FocusedRowHandle + 1);
                //return;
                if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                //gbList.Columns["Quantity"].View.Focus();

                //gbList.UpdateCurrentRow();
            }
        }


        public void ProductAdd(PRODUCT item)
        {

            //dsTransfer.STOCK_TRANSFER_DETAIL.AddSTOCK_TRANSFER_DETAILRow(
            //        0,
            //        item.Product_Type_ID,
            //        "",
            //        txtID.Text,
            //        item.Product_ID,
            //        item.Product_ID,
            //        item.Product_Name,
            //        "All",
            //        item.Provider_ID,
            //        item.Unit,
            //        1,
            //        Convert.ToDecimal(item.Org_Price),
            //        Convert.ToDecimal(item.Quantity),
            //        Convert.ToDecimal(item.Org_Price),
            //        "",
            //        "",
            //        txtDescription.Text,
            //        0,
            //        9,
            //        0,
            //        0,
            //        Guid.NewGuid(),
            //        "",0,0,0,0
            //        );
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                //if (gbList.RowCount == 1)
                //{
                //    m_Column = Column.Lock;
                //    //object Arg = gbList.GetFocusedValue();
                //    //ProductAdd(Arg == DBNull.Value ? "" : Arg.ToString());
                //    m_Column = Column.None;
                //    return;
                //}

                //gbList.DeleteRow(gbList.FocusedRowHandle);
                if (gbList.FocusedColumn == colQuantity)
                {
                    m_Column = Column.Lock;
                    //    //object Arg = gbList.GetFocusedValue();
                    //    //ProductAdd(Arg == DBNull.Value ? "" : Arg.ToString());

                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colQuantity, 0);
                    m_Column = Column.None;
                    //    return;
                }
                else if (gbList.FocusedColumn == colUnitPrice)
                {
                    m_Column = Column.Lock;
                    //    //object Arg = gbList.GetFocusedValue();
                    //    //ProductAdd(Arg == DBNull.Value ? "" : Arg.ToString());

                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colUnitPrice, 0);
                    m_Column = Column.None;
                    //    return;
                }
                else if (gbList.FocusedColumn == colAmount)
                {
                    m_Column = Column.Lock;
                    //    //object Arg = gbList.GetFocusedValue();
                    //    //ProductAdd(Arg == DBNull.Value ? "" : Arg.ToString());

                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colAmount, 0);
                    m_Column = Column.None;
                    //    return;
                }
                else
                {
                    DeleteSelected();
                }

                //Total();
                //SetIndex();
            }
            //ucList_ListKeyDown(sender, e);
            base.ProcessDialogKey(e.KeyData);

        }

        public override void DisableControl(bool disable)
        {
            //Bar.Bar.bbiAdd.Enabled = !disable;
            Bar.Bar.bbiCancel.Enabled = disable;
            Bar.Bar.bbiSave.Enabled = disable;
            Bar.Bar.bbiSaveNew.Enabled = disable;
            Bar.Bar.bbiSaveM.Enabled = disable;
            gcList.Enabled = disable;

        }

        public override void Clear()
        {
            gbList.SelectAll();
            gbList.DeleteSelectedRows();
        }

        public override void Add()
        {
            if (!MyRule.IsAdd("bbiPacket")) return;

            TRANS_REF cls = new TRANS_REF();
            m_Status = Actions.Add;
            DisableControl(true);
            if (m_part == EnumRefType.TransferPack1)
            {
                txtID.Text = cls.NewID("BTP");
            }
            else
            {
                txtID.Text = cls.NewID("TP");
            }
            txtID.Properties.ReadOnly = false;
            Updated();
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;

        }

        private void rpgProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Search")
            {
                xfmProducts xfmProducts = new xfmProducts(true);
                xfmProducts.ItemSelected += new xfmProducts.ItemSelectedEventHander(xfmProducts_ItemSelected);
                xfmProducts.ShowDialog();
            }
            else if (e.Button.Tag.ToString() == "Add")
            {
                xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Add);
                xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
                xfmItemAdd.ShowDialog();
            }
            // this.Enabled = true;
        }

        void xfmItemAdd_Added(object sender, PRODUCT Item)
        {
            Product_Init();
            gbList.AddNewRow();
            gbList.UpdateCurrentRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", Item.Product_ID);

        }

        void xfmProducts_ItemSelected(object sender, PRODUCT item)
        {
            Product_Init();
            gbList.AddNewRow();
            gbList.UpdateCurrentRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", item.Product_ID);
            // gbList.SetFocusedValue(item.Product_ID);
        }

        public override bool Check()
        {

            //if (cbxCurrency.SelectedValue == null)
            //{
            //    XtraMessageBox.Show("Vui lòng chọn loại tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return false;
            //}

            if (txtEmployeeName.EditValue == null | txtEmployeeName.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtEmployeeName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtEmployeeID.Focus();
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

            if (dsTransfer.STOCK_TRANSFER_DETAIL.Rows.Count == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;

        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (m_Status == Actions.Add)
            {
               TRANS_REF transRef = new TRANS_REF();
                if (transRef.Exist(txt.Text))
                {
                    Err.SetError(txt, "Mã đã tồn tại.");
                    txt.Focus();
                }
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;

            if (m_Status == Actions.None) return;

            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
                // txt.Focus();
            }
            else
            {
                TRANS_REF transRef = new TRANS_REF();
                if (m_Status == Actions.Add)
                {
                    if (transRef.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
                        // txt.Focus();
                    }
                }

            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                TRANS_REF transRef = new TRANS_REF();
                if (m_Status == Actions.Add)
                {
                    if (transRef.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
                        txt.Focus();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        SetData(txt.Text);
                    }
                }

            }
        }

        public void SetData(string table)
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            STOCK_TRANSFER cls = new STOCK_TRANSFER();
            if (cls.Get(table))
            {
                m_Status = Actions.Change;
                DisableControl(true);
                txtEmployeeID.EditValue = cls.Sender_ID;
                txtID.Text = cls.ID;
                dtCreated.DateTime = cls.RefDate;
                txtID.Properties.ReadOnly = true;
                txtDescription.Text = cls.Description;

                STOCK_TRANSFER_DETAILTableAdapter adapter = new STOCK_TRANSFER_DETAILTableAdapter();
                adapter.Connection.ConnectionString = SqlHelper.ConnectString;
                adapter.Fill(dsTransfer.STOCK_TRANSFER_DETAIL, txtID.Text);

                PRODUCT product = new PRODUCT();

                for (int i = 0; i < dsTransfer.STOCK_TRANSFER_DETAIL.Rows.Count; i++)
                {
                    product.Get(dsTransfer.STOCK_TRANSFER_DETAIL.Rows[i]["Product_ID"].ToString());

                    dsTransfer.STOCK_TRANSFER_DETAIL.Rows[i]["Product_Type_ID"] = product.Product_Type_ID;
                    dsTransfer.STOCK_TRANSFER_DETAIL.Rows[i]["Error"] = product.Product_Type_ID;
                    dsTransfer.STOCK_TRANSFER_DETAIL.Rows[i]["Product_Name"] = product.Product_Name;
                }
                Updated();
            }

            DoHide();
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
            Cursor.Current = Cursors.Default;

        }

        public void Print(bool preview)
        {

            if (!MyRule.IsPrint("bbiPacket")) return;


            rptStockTransfer rpt = new rptStockTransfer(dsTransfer, "RD0000023", "Phiếu Đóng Gói", Strings.Format(dtCreated.DateTime, "dd/MM/yyyy"));
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

        public void LockStock(bool temp)
        {
            for (int i = 0; i < gbList.Columns.Count; i++)
            {
                gbList.Columns["OutStock"].OptionsColumn.AllowEdit = !temp;
                gbList.Columns["OutStock"].OptionsColumn.ReadOnly = temp;
            }
        }

        public void SetStock()
        {
            for (int i = 0; i < gbList.RowCount; i++)
            {
                if (gbList.GetRowCellValue(i, "OutStock") == DBNull.Value)
                {
                    XtraMessageBox.Show("Kho không đúng.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                STOCK stock = new STOCK();
                stock.Get(gbList.GetRowCellValue(i, "OutStock").ToString());
                gbList.SetRowCellValue(i, "Stock_Name", stock.Stock_Name);
            }
        }

        //void ucList_ListKeyDown(object sender, KeyEventArgs key)
        //{
        //    if (key.KeyCode == Keys.F2)
        //    {
        //        Save();
        //        return;
        //    }
        //    else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.S)
        //    {
        //        Save();
        //        return;
        //    }
        //    else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.W)
        //    {
        //        Save();
        //        return;
        //    }
        //    else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.Shift | key.KeyCode == Keys.S)
        //    {
        //        btnSaveNew_Click(btnSaveNew, EventArgs.Empty);
        //        return;
        //    }
        //    else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.Shift | key.KeyCode == Keys.W)
        //    {
        //        btnSaveNew_Click(btnSaveNew, EventArgs.Empty);
        //        return;
        //    }
        //    else if (key.KeyCode == Keys.Shift | key.KeyCode == Keys.F2)
        //    {
        //        btnSaveNew_Click(btnSaveNew, EventArgs.Empty);
        //        return;
        //    }
        //    else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.P)
        //    {
        //        btnPrint_Click(btnPrint, EventArgs.Empty);
        //        return;
        //    }
        //    else if (key.KeyCode == Keys.Escape)
        //    {
        //        btnCancle_Click(btnCancle, EventArgs.Empty);
        //        return;
        //    }

        //}

        private void txtCustomerName_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void txtEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
            if (txtEmployeeName.EditValue == null) return;
            EMPLOYEE cus = new EMPLOYEE();
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
                EMPLOYEE cus = new EMPLOYEE();
                if (cus.Get(txtEmployeeID.Text))
                {
                    txtEmployeeName.EditValue = cus.Employee_ID;
                }
            }
        }

        public void SaveLayout()
        {
            SaveLayout(Application.StartupPath + "\\Layout\\xucTransOut" + m_part + ".xml");
        }

        public void ReadLayout()
        {
            ReadLayout(Application.StartupPath + "\\Layout\\xucTransOut" + m_part + ".xml");
        }

        public override void ReadLayout(string name)
        {
            FileInfo fileInfo = new FileInfo(name);
            if (fileInfo.Exists)
            {
                gbList.RestoreLayoutFromXml(fileInfo.FullName);
            }
        }

        public override void SaveLayout(string name)
        {
            try
            {
                gbList.SaveLayoutToXml(name);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SaveHistory()
        {
            SaveToFile(Application.StartupPath + "\\Data\\STOCK_TRANSFER_PACK" + m_part + ".xml");
        }

        public void SaveHistory(string name)
        {
            SaveToFile(Application.StartupPath + "\\Data\\" + name + ".old");
        }

        public void RestoreHistory()
        {
            ReadFromFile(Application.StartupPath + "\\Data\\STOCK_TRANSFER_PACK" + m_part + ".xml");

        }

        public override void SaveToFile(string name)
        {
            try
            {
                dsTransfer.STOCK_TRANSFER.Rows.Clear();

                /*
                 string FromStock_ID, 
                        string ToStock_ID, 
                        bool IsBarcode, 
                        bool IsPrint, 
                        string ID, 
                        System.DateTime RefDate, 
                        int RefType, 
                        decimal Amount, 
                        string Description, 
                        bool Active, 
                        string Employee_Name, 
                        string Employee_ID, 
                        string ReceiverName, 
                        string Receiver_ID, 
                        string Sender_ID, 
                        string SenderName
                 */

                dsTransfer.STOCK_TRANSFER.AddSTOCK_TRANSFERRow(
                    "",
                    "",
                    chxIsPrint.Checked,
                    chxBarcode.Checked,
                    txtID.Text,
                    dtCreated.DateTime,
                    9,
                    Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                    txtDescription.Text,
                    true,
                    txtEmployeeName.Text,
                    txtEmployeeName.EditValue == null ? "" : txtEmployeeName.EditValue.ToString(),
                    "",
                    "",
                    "",
                    ""
                    );


                dsTransfer.WriteXml(name);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void ReadFromFile(string name)
        {
            try
            {
                var fileInfo = new FileInfo(name);
                if (fileInfo.Exists)
                {
                    dsTransfer.STOCK_TRANSFER.Rows.Clear();
                    dsTransfer.STOCK_TRANSFER_DETAIL.Rows.Clear();

                    dsTransfer.ReadXml(fileInfo.FullName);
                    if (dsTransfer.STOCK_TRANSFER.Rows.Count > 0)
                    {
                        txtEmployeeName.EditValue =
                        dsTransfer.STOCK_TRANSFER.Rows[0]["Employee_ID"].ToString();
                        chxIsPrint.Checked = Convert.ToBoolean(dsTransfer.STOCK_TRANSFER.Rows[0]["IsPrint"]);
                        chxBarcode.Checked = Convert.ToBoolean(dsTransfer.STOCK_TRANSFER.Rows[0]["IsBarcode"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //S XtraMessageBox.Show("Lỗi:\n\t" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gbList_Layout(object sender, EventArgs e)
        {
            SaveLayout();
        }

        #region Popup

        public override void DeleteSelected()
        {
            //gbList.DeleteSelectedRows();
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
            xfmProducts xfmProducts = new xfmProducts(true);
            xfmProducts.ItemSelected += new xfmProducts.ItemSelectedEventHander(xfmProducts_ItemSelected);
            xfmProducts.ShowDialog();
            // this.Enabled = true;
        }

        public override void ProductDetail()
        {
            object Arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());
            xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }


        public override void RestoreTemp()
        {
            RestoreHistory();
        }

        public override void SaveTemp()
        {
            SaveHistory();
        }

        public override void Inventory()
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());

            Perfect.Inventory.xfmInventoryDetail xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(product.Product_ID, "");
            xfmInventoryDetail.ShowDialog(this);
        }

        public override void History()
        {
            object Arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (Arg == null) return;
            xfmHistory xfmHistory = new xfmHistory();
            xfmHistory.SetData(Arg.ToString(), "");
            xfmHistory.ShowDialog(this);
        }

        #endregion

        public void DoShowMenu(GridHitInfo hi)
        {
            GridViewMenu menu;
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Column)
                {
                    //MessageBox.Show("Ad");

                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                    Bar.Bar.bm.HideToolBarsPopup();
                    Bar.Bar.pm.HidePopup();

                }
                if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.ColumnButton)
                {
                    //MessageBox.Show("Ad");

                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                    Bar.Bar.bm.HideToolBarsPopup();
                    Bar.Bar.pm.HidePopup();
                    DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Row)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                    // MessageBox.Show("BB");
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.RowCell)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                    // MessageBox.Show("BB");
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.EmptyRow)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                    // MessageBox.Show("BB");
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

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
            Bar.Bar.bbiProduct.Enabled = true;
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
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

        private void chxBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (chxBarcode.Checked)
            {
                lcBarcode.Visibility = LayoutVisibility.Always;
            }
            else
            {
                lcBarcode.Visibility = LayoutVisibility.Never;
            }
        }

        public void SetColor(int i)
        {
            object Product_Type = gbList.GetRowCellValue(i, "Product_Type_ID");

            gbList.SetRowCellValue(i, "Error", Product_Type == DBNull.Value ? 0 : Convert.ToInt32(Product_Type));
        }

        private void rpgProduct_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        protected override void Refresh()
        {
            Updated();
            DoHide();
            base.Refresh();
        }

        private void txtEmployeeID_EditValueChanged(object sender, EventArgs e)
        {
            txtEmployeeName.EditValue = txtEmployeeID.EditValue;
        }

    }
}