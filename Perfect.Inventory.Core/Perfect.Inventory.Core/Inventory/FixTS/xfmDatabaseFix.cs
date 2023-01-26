using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Inventory.Core.Inventory.Adjustment;
using Perfect.Inventory.Core.Inventory.Inward;
using Perfect.Inventory.Core.Inventory.Outward;
using Perfect.Inventory.Core.Inventory.Transfer;
using Perfect.Inventory.Core.Inventory.Adjustment.Class;
using Perfect.Inventory.Core.Inventory.Adjustment02;
using Perfect.Inventory.Core.Inventory.Adjustment02.DS;

namespace Perfect.Data.Core
{
    public partial class xfmDatabaseFix : XtraForm
    {

        #region Delegate

        public event ErrorEventHander Error;
        public delegate void ErrorEventHander(object sender, string message);
        private void RaiseErrorEventHander(string message)
        {
            if (Error != null) Error(this, message);
        }

        public delegate void CompleteEventHander(object sender);

        public event CompleteEventHander Complete;

        private void RaiseCompleteEventHander()
        {
            if (Complete != null) Complete(this);
        }

        public delegate void PercentEventHander(object sender, int percent);

        public event PercentEventHander Percent;

        private void RaisePercentEventHander(int percent)
        {
            if (Percent != null) Percent(this, percent);
        }

        public event PercentEventHander Processed;

        private void RaiseProcessedEventHander(int percent)
        {
            PercentEventHander processed = Processed;
            if (processed != null) processed(this, percent);
        }

        public delegate void TitleChangedEventHander(object sender, string message);

        public event TitleChangedEventHander TitleChanged;

        private void RaiseTitleChangedEventHander(string message)
        {
            if (TitleChanged != null) TitleChanged(this, message);
        }


        public delegate void ExecutingEventHander(object sender);

        public event ExecutingEventHander Executing;

        private void RaiseExecutingEventHander()
        {
            if (Executing != null) Executing(this);
        }

        public delegate void ExecutedEventHander(object sender);

        public event ExecutedEventHander Executed;

        private void RaiseExecutedEventHander()
        {
            if (Executed != null) Executed(this);
        }


        public event TitleChangedEventHander TextChanged;

        private void RaiseTextChangedEventHander(string message)
        {
            TitleChangedEventHander changed = TextChanged;
            if (changed != null) changed(this, message);
        }

        public delegate void ClosedEventHander(object sender);

        public event ClosedEventHander closed;

        private void RaiseClosedEventHander()
        {
            ClosedEventHander hander = closed;
            if (hander != null) hander(this);
        }

        #endregion

        private bool _cancel = true;
        private bool _exit = true;

        public xfmDatabaseFix()
        {
            InitializeComponent();
            Error += XfmDatabaseFixError;
            Complete += XfmDatabaseFixComplete;
            Percent += XfmDatabaseFixPercent;
            TitleChanged += XfmDatabaseFixTitleChanged;
            Processed += XfmDatabaseFixProcessed;
            TextChanged += XfmDatabaseFixTextChanged;
            closed += XfmDatabaseFixClosed;
        }

        void XfmDatabaseFixClosed(object sender)
        {
            if (Bar.InvokeRequired)
            {
                ClosedEventHander myRestore = XfmDatabaseFixClosed;
                Invoke(myRestore, new[] { sender});
            }
            else
            {
                Close();
            }
        }

        void XfmDatabaseFixTextChanged(object sender, string message)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new TitleChangedEventHander(XfmDatabaseFixTextChanged);
                Invoke(myRestore, new[] { sender, message });
            }
            else
            {
                lblTitle.Text = message;
                LResult.Items.Add(message);
            }
        }

        void XfmDatabaseFixProcessed(object sender, int percent)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new PercentEventHander(XfmDatabaseFixProcessed);
                Invoke(myRestore, new[] { sender, percent });
            }
            else
            {
                Bar.Position = percent;
            }
        }

        void XfmDatabaseFixTitleChanged(object sender, string message)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new TitleChangedEventHander(XfmDatabaseFixTitleChanged);
                Invoke(myRestore, new[] { sender, message });
            }
            else
            {
                lblMessage.Text = message;
                LResult.Items.Insert(0,message);
            }

        }

        void XfmDatabaseFixPercent(object sender, int percent)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new PercentEventHander(XfmDatabaseFixPercent);
                Invoke(myRestore, new[] { sender, percent });
            }
            else
            {
                BarSub.Position = percent;
            }
        }

        void XfmDatabaseFixComplete(object sender)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new CompleteEventHander(XfmDatabaseFixComplete);
                Invoke(myRestore, new[] { sender });
            }
            else
            {
                BarSub.Position = 0;
                Bar.Position = 0;
                btnStart.Enabled = true;
                btnClose.Enabled = true;
                XtraMessageBox.Show(this, "Sửa Chữa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RaiseExecutedEventHander();
            }
        }

        void XfmDatabaseFixError(object sender, string message)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ErrorEventHander(XfmDatabaseFixError);
                Invoke(myRestore, new[] { sender, message });
            }
            else
            {
                btnStart.Enabled = true;
                btnClose.Enabled = true;
                XtraMessageBox.Show(this, message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RaiseExecutedEventHander();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Bar.Position = 0;
            BarSub.Position = 0;
            btnStart.Enabled = false;
           // btnClose.Enabled = false;
            RaiseExecutingEventHander();
            var thread = new Thread(Execute);
            thread.Start();
            //Execute();
        }

        void Execute()
        {
            var dt = new DataTable();

            string result = string.Empty;
            var sqlHelper = new SqlHelper();
            sqlHelper.CommandType = CommandType.Text;

            dt = sqlHelper.ExecuteDataTable("select * from [TRANS_REF] Order by convert(datetime, convert(varchar(10),RefDate, 101), 101) ASC,Sorted ASC");
            RaiseProcessedEventHander(1 / 100);

            result = sqlHelper.Start();

            if (result != "OK")
            {
                RaiseErrorEventHander(result);
                sqlHelper.RollBack();
                return;
            }


            sqlHelper.CommandType = CommandType.Text;
            result = sqlHelper.ExecuteNonQuery(sqlHelper.Transaction, "delete  from INVENTORY_DETAIL");
            RaiseProcessedEventHander(2 / 100);
            if (result != "OK")
            {
                sqlHelper.RollBack();
                RaiseErrorEventHander(result);
                return;
            }


            sqlHelper.CommandType = CommandType.Text;
            result = sqlHelper.ExecuteNonQuery(sqlHelper.Transaction, "delete  from INVENTORY");
            RaiseProcessedEventHander(3 / 100);
            if (result != "OK")
            {
                sqlHelper.RollBack();
                RaiseErrorEventHander(result);
                return;
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] myPara = { string.Format("@{0}", TRANS_REFFields.RefID) };
                object[] myValue = { dt.Rows[i][TRANS_REFFields.RefID.ToString()] };

                //Bar.Position = i/dt.Rows.Count*100;

                int reftype = Convert.ToInt32(dt.Rows[i][TRANS_REFFields.RefType.ToString()]);
                string id = dt.Rows[i][TRANS_REFFields.RefID.ToString()].ToString();

                double percent = ((double)i + 3) / (dt.Rows.Count + 3) * 100;
                RaiseProcessedEventHander((int)percent);
                RaiseTextChangedEventHander("Chứng từ: " + id + "  (" + (i + 1) + "/" + dt.Rows.Count + ")" + string.Format(" {0:##,##0.##} %", percent));
                if (reftype == 0)
                {
                    result = Fix_Init(sqlHelper, id);
                }
                else if (reftype == 1)
                {
                    result = Fix_Inward(sqlHelper, id);
                }
                else if (reftype== 2 | reftype == 6)
                {
                    result = Fix_Outward(sqlHelper, id);
                }
                else if (reftype == 5)
                {
                    result = Fix_Adjust(sqlHelper, id);
                }
                else if (reftype == 7 | reftype == 8 | reftype==9)
                {
                    result = Fix_Transfer(sqlHelper, id);
                }

                if (result != "OK")
                {
                    RaiseErrorEventHander(result);
                    sqlHelper.RollBack();
                    return;
                }
                
                if (cancel)
                {
                    RaiseErrorEventHander("Hủy bởi người dùng.");
                    sqlHelper.RollBack();
                    //break;
                    _exit = true;
                   RaiseClosedEventHander();
                    return;
                }

            }

            if (result == "OK")
            {

                sqlHelper.Commit();
                RaiseProcessedEventHander(100);
                RaiseCompleteEventHander();
                //XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        string Fix_Init(SqlHelper mysql, string id)
        {
            var stockInwardDetail = new STOCK_INWARD_DETAIL();
            var dt = new dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable();
            dt.Merge(stockInwardDetail.GetList_ByInward_ID(mysql.Transaction,id));
            string result = "OK";
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!stockInwardDetail.Update
                                (
                                mysql.Transaction,
                                dt.Rows[i]["ID"].ToString(),
                                id,
                                dt.Rows[i]["Product_ID"].ToString(),
                                dt.Rows[i]["ProductName"].ToString(),
                                0,
                                dt.Rows[i]["Stock_ID"].ToString(),
                                dt.Rows[i]["Unit"].ToString(),
                                dt.Rows[i]["UnitConvert"] == DBNull.Value ? 1 : Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                                dt.Rows[i]["Vat"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Vat"]),
                                dt.Rows[i]["VatAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["VatAmount"]),
                                dt.Rows[i]["CurrentQty"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["CurrentQty"]),
                                dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                                Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                                Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                                Convert.ToDecimal(dt.Rows[i]["QtyConvert"]),
                                dt.Rows[i]["DiscountRate"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["DiscountRate"]),
                                dt.Rows[i]["Discount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Discount"]),
                                dt.Rows[i]["Charge"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Charge"]),
                                Convert.ToDateTime(dt.Rows[i]["Limit"]),
                                dt.Rows[i]["Width"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Width"]),
                                dt.Rows[i]["Height"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Height"]),
                                dt.Rows[i]["Orgin"] == DBNull.Value ? "" : dt.Rows[i]["Orgin"].ToString(),
                                dt.Rows[i]["Size"] == DBNull.Value ? "" : dt.Rows[i]["Size"].ToString(),
                                dt.Rows[i]["Color"] == DBNull.Value ? "" : dt.Rows[i]["Color"].ToString(),
                                dt.Rows[i]["Batch"] == DBNull.Value ? "" : dt.Rows[i]["Batch"].ToString(),
                                dt.Rows[i]["Serial"] == DBNull.Value ? "" : dt.Rows[i]["Serial"].ToString(),
                                dt.Rows[i]["ChassyNo"] == DBNull.Value ? "" : dt.Rows[i]["ChassyNo"].ToString(),
                                dt.Rows[i]["IME"] == DBNull.Value ? "" : dt.Rows[i]["IME"].ToString(),
                                dt.Rows[i]["StoreID"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["StoreID"]),
                                dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"].ToString(),
                                dt.Rows[i]["Sorted"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["Sorted"]),
                                true))
                    {
                        result = mysql.Result;
                        mysql.RollBack();
                        RaiseErrorEventHander(result);
                        return result;
                    }
                    double percent = (double)i / dt.Rows.Count * 100;
                    RaisePercentEventHander((int)percent);
                    RaiseTitleChangedEventHander(">> " + dt.Rows[i]["Product_ID"] + "  (" + (i + 1) + "/" + dt.Rows.Count + ")" + string.Format(" {0:##,##0.##} %", percent));

                }
            }

            return result;
        }

        string Fix_Inward(SqlHelper mysql, string id)
        {
            var stockInwardDetail = new STOCK_INWARD_DETAIL();
            var dt = new dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable();
            dt.Merge(stockInwardDetail.GetList_ByInward_ID(mysql.Transaction,id));
            string result = "OK";
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (!stockInwardDetail.Update
                                (
                                mysql.Transaction,
                                dt.Rows[i]["ID"].ToString(),
                                id,
                                dt.Rows[i]["Product_ID"].ToString(),
                                dt.Rows[i]["ProductName"].ToString(),
                                1,
                                dt.Rows[i]["Stock_ID"].ToString(),
                                dt.Rows[i]["Unit"].ToString(),
                                dt.Rows[i]["UnitConvert"] == DBNull.Value ? 1 : Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                                dt.Rows[i]["Vat"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Vat"]),
                                dt.Rows[i]["VatAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["VatAmount"]),
                                dt.Rows[i]["CurrentQty"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["CurrentQty"]),
                                dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                                Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                                Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                                Convert.ToDecimal(dt.Rows[i]["QtyConvert"]),
                                dt.Rows[i]["DiscountRate"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["DiscountRate"]),
                                dt.Rows[i]["Discount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Discount"]),
                                dt.Rows[i]["Charge"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Charge"]),
                                Convert.ToDateTime(dt.Rows[i]["Limit"]),
                                dt.Rows[i]["Width"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Width"]),
                                dt.Rows[i]["Height"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Height"]),
                                dt.Rows[i]["Orgin"] == DBNull.Value ? "" : dt.Rows[i]["Orgin"].ToString(),
                                dt.Rows[i]["Size"] == DBNull.Value ? "" : dt.Rows[i]["Size"].ToString(),
                                dt.Rows[i]["Color"] == DBNull.Value ? "" : dt.Rows[i]["Color"].ToString(),
                                dt.Rows[i]["Batch"] == DBNull.Value ? "" : dt.Rows[i]["Batch"].ToString(),
                                dt.Rows[i]["Serial"] == DBNull.Value ? "" : dt.Rows[i]["Serial"].ToString(),
                                dt.Rows[i]["ChassyNo"] == DBNull.Value ? "" : dt.Rows[i]["ChassyNo"].ToString(),
                                dt.Rows[i]["IME"] == DBNull.Value ? "" : dt.Rows[i]["IME"].ToString(),
                                dt.Rows[i]["StoreID"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["StoreID"]),
                                dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"].ToString(),
                                dt.Rows[i]["Sorted"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["Sorted"]),
                                true))
                    {
                        result = mysql.Result;
                        mysql.RollBack();
                        RaiseErrorEventHander(result);
                        return result;
                    }
                    double percent = i / (double)dt.Rows.Count * 100;
                    RaisePercentEventHander((int)percent);
                    RaiseTitleChangedEventHander(">> " + dt.Rows[i]["Product_ID"] + "  (" + (i + 1) + "/" + dt.Rows.Count + ")" + string.Format(" {0:##,##0.##} %", percent));

                }
            }

            return result;
        }

        string Fix_Outward(SqlHelper mysql, string id)
        {
            var outwardDetail=new STOCK_OUTWARD_DETAIL();
            var dt=new dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAILDataTable();
            dt.Merge(outwardDetail.GetList_ByOutward_ID(mysql.Transaction,id));
            string result = "OK";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!outwardDetail.Update(
                        mysql.Transaction,
                        dt.Rows[i]["ID"].ToString(),
                        id,
                        dt.Rows[i]["Stock_ID"].ToString(),
                        Convert.ToInt32(dt.Rows[i]["RefType"]),
                        dt.Rows[i]["Product_ID"].ToString(),
                        dt.Rows[i]["ProductName"].ToString(),
                        dt.Rows[i]["Vat"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Vat"]),
                        dt.Rows[i]["VatAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["VatAmount"]),
                        dt.Rows[i]["Unit"].ToString(),
                        dt.Rows[i]["UnitConvert"] == DBNull.Value ? 1 : Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                        dt.Rows[i]["CurrentQty"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["CurrentQty"]),
                        dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                        dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                        dt.Rows[i]["Amount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Amount"]),
                        dt.Rows[i]["QtyConvert"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["QtyConvert"]),
                        dt.Rows[i]["DiscountRate"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["DiscountRate"]),
                        dt.Rows[i]["Discount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Discount"]),
                        dt.Rows[i]["Charge"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Charge"]),
                        dt.Rows[i]["Cost"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Cost"]),
                        dt.Rows[i]["Profit"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Profit"]),
                        dt.Rows[i]["Batch"].ToString(),
                        dt.Rows[i]["Serial"].ToString(),
                        dt.Rows[i]["ChassyNo"] == DBNull.Value ? "" : dt.Rows[i]["ChassyNo"].ToString(),
                        dt.Rows[i]["IME"] == DBNull.Value ? "" : dt.Rows[i]["IME"].ToString(),
                        dt.Rows[i]["Width"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Width"]),
                        dt.Rows[i]["Height"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Height"]),
                        dt.Rows[i]["Orgin"] == DBNull.Value ? "" : dt.Rows[i]["Orgin"].ToString(),
                        dt.Rows[i]["Size"] == DBNull.Value ? "" : dt.Rows[i]["Size"].ToString(),
                        dt.Rows[i]["StoreID"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["StoreID"]),
                        dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"].ToString(),
                        dt.Rows[i]["Sorted"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["Sorted"]),
                        true
                        ))
                {
                    result = mysql.Result;
                    mysql.RollBack();
                    RaiseErrorEventHander(result);
                    return result;
                }

                double percent = i / (double)dt.Rows.Count * 100;
                RaisePercentEventHander((int)percent);
                RaiseTitleChangedEventHander(">> " + dt.Rows[i]["Product_ID"] + "  (" + (i + 1) + "/" + dt.Rows.Count + ")" + string.Format(" {0:##,##0.##} %", percent));

            }

            return result;
        }

        string Fix_Adjust(SqlHelper mysql, string id)
        {
            var cls = new ADJUSTMENT_DETAIL();
            var dt=new dsAdjustment.ADJUSTMENT_DETAILDataTable();
            dt.Merge(cls.GetList_ByAdjustment_ID(mysql.Transaction, id));
            string result = "OK";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!cls.Delete(mysql.Transaction, dt.Rows[i]["ID"].ToString()))
                {
                    mysql.RollBack();
                    RaiseErrorEventHander(result);
                    return result;
                }
                if (!cls.Insert(
                            mysql.Transaction,
                            dt.Rows[i]["ID"].ToString(),
                            id,
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["ProductName"].ToString(),
                            dt.Rows[i]["Stock_ID"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            dt.Rows[i]["UnitConvert"] == DBNull.Value ? 1 : Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                            dt.Rows[i]["Width"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Width"]),
                            dt.Rows[i]["Height"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Height"]),
                            dt.Rows[i]["Orgin"] == DBNull.Value ? "" : dt.Rows[i]["Orgin"].ToString(),
                            dt.Rows[i]["CurrentQty"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["CurrentQty"]),
                            dt.Rows[i]["NewQty"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["NewQty"]),
                            dt.Rows[i]["QtyDiff"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["QtyDiff"]),
                            dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            dt.Rows[i]["Amount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            dt.Rows[i]["QtyConvert"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["QtyConvert"]),
                            dt.Rows[i]["StoreID"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["StoreID"]),
                            dt.Rows[i]["Batch"] == DBNull.Value ? "" : dt.Rows[i]["Batch"].ToString(),
                            dt.Rows[i]["Serial"] == DBNull.Value ? "" : dt.Rows[i]["Serial"].ToString(),
                            dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"].ToString(),
                            dt.Rows[i]["Sorted"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["Sorted"])
                            ))
                {
                    mysql.RollBack();
                    RaiseErrorEventHander(result);
                    return result;
                }

                double percent = i / dt.Rows.Count * 100;
                RaisePercentEventHander((int)percent);
                RaiseTitleChangedEventHander(">> " + dt.Rows[i]["Product_ID"] + "  (" + (i + 1) + "/" + dt.Rows.Count + ")" + string.Format(" {0:##,##0.##} %", percent));

            }

            return result;
        }

        string Fix_Transfer(SqlHelper mysql, string id)
        {
            var cls = new STOCK_TRANSFER_DETAIL();
            var dt=new dsSTOCK_TRANSFER_DETAIL.STOCK_TRANSFER_DETAILDataTable();
            dt.Merge(cls.GetList_ByTransferID(mysql.Transaction, id));
            string result = "OK";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!cls.Update(
                            mysql.Transaction,
                            dt.Rows[i]["ID"].ToString(),
                            id,
                            Convert.ToInt32(dt.Rows[i]["RefType"]),
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["Product_Name"].ToString(),
                            dt.Rows[i]["OutStock"].ToString(),
                            dt.Rows[i]["InStock"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            dt.Rows[i]["UnitConvert"] == DBNull.Value ? 1 : Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                            dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                            dt.Rows[i]["Amount"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            dt.Rows[i]["QtyConvert"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[i]["QtyConvert"]),
                            dt.Rows[i]["StoreID"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["StoreID"]),
                            dt.Rows[i]["Batch"] == DBNull.Value ? "" : dt.Rows[i]["Batch"].ToString(),
                            dt.Rows[i]["Serial"] == DBNull.Value ? "" : dt.Rows[i]["Serial"].ToString(),
                            dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"].ToString(),
                            dt.Rows[i]["Sorted"] == DBNull.Value ? 0 : Convert.ToInt64(dt.Rows[i]["Sorted"])
                            ))
                {
                    result = mysql.Result;
                    mysql.RollBack();
                    RaiseErrorEventHander(result);
                    return result;
                }

                double percent = i / dt.Rows.Count * 100;
                RaisePercentEventHander((int)percent);
                RaiseTitleChangedEventHander(">> " + dt.Rows[i]["Product_ID"] + "  (" + (i + 1) + "/" + dt.Rows.Count + ")" + string.Format(" {0:##,##0.##} %", percent));

            }

            return result;
        }

        private bool cancel;

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!btnStart.Enabled)
            {
                if (
                    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.No) return;
                cancel = true;
                _exit = false;
            }
            else
            {
                Close();
            }

        }

        private void Bar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private const int CpNocloseButton = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CpNocloseButton;
                return myCp;
            }
        }

        private void xfmDatabaseFix_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exit)
            {
                e.Cancel = true;
                return;
            }
            RaiseExecutedEventHander();
        }
    }
}
