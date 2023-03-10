using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Dictionary.Provider.Debt;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Utils.System2;
using Perfect.Data.Helper;
using Perfect.Security;

namespace Perfect.Sale.Core.INITS.Provider.UI
{
    public partial class XucProviderDebtInit : xucBase
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

        public XucProviderDebtInit()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            CustomerInit();
            Init();
        }
        
        public void Init()
        {
            #region query
            /*
            SqlHelper mysql = new SqlHelper();
            mysql.CommandType = CommandType.Text;
            string query = @"SELECT Customer_ID,
       CustomerName,
       CustomerAddress,
       a.Customer_Group_ID,
       cg.Customer_Group_Name,
       CASE 
            WHEN a.[Description] IS NULL THEN ''
            ELSE a.[Description]
       END AS [Description],
       RefDate,
       CASE 
            WHEN ID IS NULL THEN '00000000-0000-0000-0000-000000000000'
            ELSE ID
       END AS ID,
       CASE 
            WHEN RefID IS NULL THEN ''
            ELSE RefID
       END AS RefID,
       Amount
FROM   (
           SELECT ID,
                  RefID,
                  a.RefDate,
                  Customer_ID,
                  c.CustomerName,
                  c.CustomerAddress,
                  c.Customer_Group_ID,
                  a.[Description],
                  Amount
           FROM   (
                      SELECT RefOrgNo AS ID,
                             RefID,
                             a.RefDate,
                             CustomerID,
                             a.[Description],
                             Amount
                      FROM   DEBT a
                      WHERE  RefType = 32
                             AND RefStatus = 0
                  ) A
                  FULL OUTER JOIN PROVIDER c
                       ON  A.CustomerID = c.Customer_ID
       ) A
       INNER JOIN CUSTOMER_GROUP cg
            ON  A.Customer_Group_ID = cg.Customer_Group_ID
WHERE  cg.Customer_Group_ID = @Customer_Group_ID
       OR  1 = CASE 
                    WHEN @Customer_Group_ID = 'All' THEN 1
                    ELSE 0
               END";

            string[] myParams = { "@Customer_Group_ID" };
            object[] myValues = { Convert.ToString(txtCustomer.EditValue) };
            DataTable dt = mysql.ExecuteDataTable(query, myParams, myValues);
            dsProviderDebtInit.ProviderDebtGetListInit.Clear();
            dsProviderDebtInit.ProviderDebtGetListInit.Merge(dt);
            */
            #endregion

            dsProviderDebtInit.ProviderDebtGetListInit.Rows.Clear();
            providerDebtGetListInitTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            providerDebtGetListInitTableAdapter.Fill(dsProviderDebtInit.ProviderDebtGetListInit, txtCustomer.EditValue.ToString());
        }

        public void CustomerInit()
        {
            var customerGroup=new CUSTOMER_GROUP();
            dsCustomerGroup.CUSTOMER_GROUP.Clear();
            dsCustomerGroup.CUSTOMER_GROUP.Merge(customerGroup.GetAll());
            txtCustomer.EditValue = @"All";
        }


        private void BtnSearchClick(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            Init();
            btnSearch.Enabled = true;
        }

        private void LuuClick(object sender, EventArgs e)
        {
            //SYS_USER_RULE SYS = new SYS_USER_RULE();

            //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInitCustomer") != "OK") return;
            //if (!SYS_USER_RULE.AllowAdd | !SYS_USER_RULE.AllowEdit | !SYS_USER_RULE.AllowDelete)
            //{
            //    XtraMessageBox.Show("Người dùng hiện tại không có quyền sửa dụng chứng năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            /////////////////////////
            // if (!MyRule.IsAdd("bbiSaleInit")) return;
            
            Luu.Enabled = false;

            //SALE cls = new SALE();
            var providerDebt = new PROVIDER_DEBT();

            var dt = dsProviderDebtInit.ProviderDebtGetListInit;

            Bar.Properties.Maximum = dt.Rows.Count;
            Bar.Position = 0;

            var mysql = new SqlHelper();

            string result = mysql.Start();

            if (result != "OK")
            {
                DoHide();
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }
            string id;
            string refID = "NDK-" + string.Format("{0:ddMMyyyy}", DateTime.Now);
            double amount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    amount = Convert.ToDouble(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]);
                    refID = dt.Rows[i]["RefID"].ToString();
                }

                if (dt.Rows[i].RowState == DataRowState.Added)
                {
                    if (refID == "")
                    {
                        refID = "NDK-" + dt.Rows[i]["CustomerID"];
                        //refID = "CNNPP" + string.Format("{0:ddMMyyyy}", DateTime.Now);
                        if (amount != 0)
                        {
                            if (!providerDebt.Insert(
                                     mysql.Transaction,
                                     Guid.NewGuid().ToString(),
                                     refID,
                                     DateTime.Now,
                                     "",
                                     32,
                                     1,
                                     "11111111-1111-1111-1111-111111111111",
                                     dt.Rows[i]["CustomerID"].ToString(),
                                     "",
                                     "",
                                     "VND",
                                     1,
                                     "CN",
                                     DateTime.Now.AddMonths(1),
                                     0,
                                     0,
                                     Convert.ToDecimal(dt.Rows[i]["Amount"]),
                                     0,
                                     Convert.ToDecimal(dt.Rows[i]["Amount"]),
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
                                     "(Số Dư Đầu Kỳ)",
                                     0,
                                     true)
                                )
                            {
                                return;
                            }


                        }
                    }
                }
                else if (dt.Rows[i].RowState == DataRowState.Modified)
                {
                    var ma = dt.Rows[i]["RefID"].ToString();

                    if (providerDebt.Delete(mysql.Transaction,ma))
                    {
                        refID = "NDK-" + dt.Rows[i]["CustomerID"];
                        if (amount!=0)
                        {
                            providerDebt.Update(
                                mysql.Transaction,
                                Guid.NewGuid().ToString(),
                                refID,
                                DateTime.Now,
                                "",
                                32,
                                1,
                                "11111111-1111-1111-1111-111111111111",
                                dt.Rows[i]["CustomerID"].ToString(),
                                "",
                                "",
                                "VND",
                                1,
                                "CN",
                                DateTime.Now.AddMonths(1),
                                0,
                                0,
                                Convert.ToDecimal(dt.Rows[i]["Amount"]),
                                0,
                                Convert.ToDecimal(dt.Rows[i]["Amount"]),
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
                                "(Số Dư Đầu Kỳ)",
                                0,
                                true);
                        }
                    }
                }
                else if (dt.Rows[i].RowState == DataRowState.Deleted)
                {
                    id = dt.Rows[i]["ID",DataRowVersion.Original].ToString();
                    if (!providerDebt.Delete(mysql.Transaction, id)) return;
                }

                Bar.Position += 1;
            }

            if (result=="OK")
            {
                mysql.Commit();
            }

            Luu.Enabled = true;
            VnMessageBox.Info("Dữ liệu cập nhật thành công");
            Init();
            Bar.Position = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close();
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

        private void txtCustomerName_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        public void UpdateCustomer(PROVIDER item)
        {

        }

        public void Add(PROVIDER item)
        {
            dsProviderDebtInit.ProviderDebtGetListInit.AddProviderDebtGetListInitRow(
                "",
                item.CustomerName,
                "",
                0,
                DateTime.Now,
                "",
                item.CustomerAddress,
                Guid.NewGuid(),
                item.Customer_ID,
                item.Customer_Group_ID
                
                );
        }

        private void BtnImportClick(object sender, EventArgs e)
        {
            //var import = new XfmProviderDebtImport();
            //import.ShowDialog();


            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Microsoft Excel WorkSheet 97-2003 (*.xls)|*.xls";
            OFD.InitialDirectory = Application.StartupPath;
            OFD.Title = "Chọn file excel";
            if (OFD.ShowDialog() != DialogResult.OK) return;
            ExcelDataReader excelDataReader = new ExcelDataReader(OFD.FileName);
            string ERROR = "";
            excelDataReader.ExcelReaderComplete += (obj, dtImport) =>
            {
                int count = 1;
                dsProviderDebtInit.ProviderDebtGetListInit.Clear();
                foreach (DataRow dr in dtImport.Rows)
                {
                    SetWaitDialogCaption(string.Format("Đang nạp dữ liệu: {0}/{1}", count, dtImport.Rows.Count));

                    string ProviderID = Convert.ToString(dr["Mã Nhà Phân Phối"]);
                    PROVIDER prd = new PROVIDER();
                    string result = prd.Get(ProviderID);

                    if (result != "OK")
                    {
                        DisplayError(string.Format("Dòng {0}: Mã nhà cung cấp '{1}' không tồn tại!", count, ProviderID));
                        continue;
                    }
                    CUSTOMER_GROUP cg = new CUSTOMER_GROUP();
                    cg.Get(prd.Customer_Group_ID);

                    try
                    {
                        dsProviderDebtInit.ProviderDebtGetListInit.Rows.Add(
                            "",
                            prd.CustomerName,
                            Convert.ToString(dr["Ghi Chú"]),
                            Convert.ToDecimal(dr["Công Nợ"] ?? 0),
                            DateTime.Now,
                            cg.Customer_Group_Name,
                            prd.CustomerAddress,
                            Guid.Empty,
                            ProviderID,
                            prd.Customer_Group_ID);
                        dsProviderDebtInit.ProviderDebtGetListInit.Rows[count - 1].AcceptChanges();
                        dsProviderDebtInit.ProviderDebtGetListInit.Rows[count - 1].SetModified();
                    }
                    catch (Exception myExc)
                    {
                        DisplayError(myExc.Message);
                    }
                    count++;
                }
                DoHide();

                gcList.Refresh();
            };

            excelDataReader.ExcelReaderError += (obj, Message) =>
            {
                ERROR += Message + "\n";
            };
            excelDataReader.ExcelReadByADO(OFD.FileName, "Sheet");
            if (ERROR != "")
                MessageBox.Show(ERROR);
        }

        private void DisplayError(string err)
        {
            XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}