using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;

namespace Perfect.Inventory.Core.Inventory.Init.Debt.Customers
{
    public partial class XucCustomerDebtInit : xucBase
    {

        public delegate void CloseClickEventHander(object sender);
        public event CloseClickEventHander CloseClick;
        public void RaiseCloseClickEventHander()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    if (ParentForm != null) ParentForm.Close();
                    return true;
            }
            return false;
        }

        public XucCustomerDebtInit()
        {
            InitializeComponent();
            Reload();
        }


        private void Reload()
        {
            CustomerInit();
            Init();
        }

        private void Init()
        {
            btnSearch.Enabled = false;
            dsDebtInit.CUSTOMER_DEBT_GetListInit.Rows.Clear();
            var customerDebt = new CustomerDebt();
            dsDebtInit.CUSTOMER_DEBT_GetListInit.Merge(customerDebt.GetListInit(txtCustomerGroup.EditValue.ToString()));
            btnSearch.Enabled = true;

        }

        private void CustomerInit()
        {
            var customerGroup = new CUSTOMER_GROUP();
            dsDebtInit.CUSTOMER_GROUP.Clear();
            dsDebtInit.CUSTOMER_GROUP.Merge(customerGroup.GetAll());
            txtCustomerGroup.EditValue = @"All";
        }


        private void BtnSearchClick(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            Init();
            btnSearch.Enabled = true;
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            Luu.Enabled = false;
            var customerDebt = new CustomerDebt();
            dsDebtInit.CUSTOMER_DEBT_GetListInitDataTable dt = dsDebtInit.CUSTOMER_DEBT_GetListInit;

            Bar.Properties.Maximum = dt.Rows.Count;
            Bar.Position = 0;

            var mysql = new SqlHelper();
            string result = mysql.Start();
            if (result != "OK")
            {
                DoHide();
                mysql.RollBack();
                Luu.Enabled = true;
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ID;
            string refId = "NPT" + string.Format("{0:ddMMyyyy}", DateTime.Now);
            double amount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    amount = Convert.ToDouble(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]);
                    refId = dt.Rows[i]["RefID"].ToString();
                }

                if (dt.Rows[i].RowState == DataRowState.Added)
                {
                    if (refId == "")
                    {
                        refId = "NDK" + dt.Rows[i]["Customer_ID"];
                        if (amount != 0)
                        {
                            if (!customerDebt.Insert(
                                     mysql.Transaction,
                                     Guid.NewGuid().ToString(),
                                     refId,
                                     DateTime.Now,
                                     "",
                                     31,
                                     0,
                                     "11111111-1111-1111-1111-111111111111",
                                     dt.Rows[i]["Customer_ID"].ToString(),
                                     "",
                                     "",
                                     SysOption.Currency,
                                     1,
                                     "CN",
                                     DateTime.Now.AddMonths(1),
                                     0,
                                     0,
                                     Convert.ToDecimal(dt.Rows[i]["Amount"]),
                                     0,
                                     0,
                                     Convert.ToDecimal(dt.Rows[i]["Amount"]),
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
                                     "(Số Dư Đầu Kỳ)",
                                     0,
                                     true)
                                )
                            {
                                DoHide();
                                mysql.RollBack();
                                Luu.Enabled = true;
                                return;
                            }
                        }
                    }
                }
                else if (dt.Rows[i].RowState == DataRowState.Modified)
                {
                    var ma = dt.Rows[i]["RefID"].ToString();
                    if (customerDebt.Delete(mysql.Transaction, ma, ""))
                    {
                        refId = "NDK" + dt.Rows[i]["Customer_ID"];
                        if (amount != 0)
                        {
                            if (!customerDebt.Update(
                                     mysql.Transaction,
                                     Guid.NewGuid().ToString(),
                                     refId,
                                     DateTime.Now,
                                     "",
                                     31,
                                     0,
                                     "11111111-1111-1111-1111-111111111111",
                                     dt.Rows[i]["Customer_ID"].ToString(),
                                     "",
                                     "",
                                     SysOption.Currency,
                                     1,
                                     "CN",
                                     DateTime.Now.AddMonths(1),
                                     0,
                                     0,
                                     Convert.ToDecimal(dt.Rows[i]["Amount"]),
                                     0,
                                     0,
                                     Convert.ToDecimal(dt.Rows[i]["Amount"]),
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
                                     "(Số Dư Đầu Kỳ)",
                                     0,
                                     true))
                            {
                                DoHide();
                                mysql.RollBack();
                                Luu.Enabled = true;
                                return;
                            }
                        }
                    }
                    else
                    {
                        DoHide();
                        mysql.RollBack();
                        Luu.Enabled = true;
                        return;
                    }

                }
                else if (dt.Rows[i].RowState == DataRowState.Deleted)
                {
                    ID = dt.Rows[i]["ID", DataRowVersion.Original].ToString();
                    if (!customerDebt.Delete(mysql.Transaction, ID))
                    {
                        DoHide();
                        mysql.RollBack();
                        Luu.Enabled = true;
                        return;
                    }
                }

                Bar.Position += 1;
            }


            mysql.Commit();
            Luu.Enabled = true;
            Init();
            Bar.Position = 0;
            XtraMessageBox.Show("Dữ liệu đã cập xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            //RaiseCloseClickEventHander();
            if (ParentForm != null) ParentForm.Close();
        }

        private void GbListCustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

       

        private void TxtCustomerNamePropertiesButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        public void UpdateCustomer(CUSTOMER item)
        {
            
        }

        public void Add(CUSTOMER item)
        {
            //dsDEBT.CUSTOMER_DEBT_GetListInit.AddCUSTOMER_DEBT_GetListInitRow(
            //    item.Customer_ID,
            //    item.CustomerName,
            //    item.CustomerAddress,
            //    item.Customer_Group_ID,
            //    "",
            //    "",
            //    DateTime.Now,
            //    Guid.NewGuid(),
            //    "",
            //    0
            //    );
        }

        private void TxtCustomerGroupCloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            txtCustomerGroup.Properties.View.ClearColumnsFilter();
        }

        private void BtnImportsClick(object sender, EventArgs e)
        {

        }
    }
}