using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Data;
using Perfect.Data.Extra.Class;
using Perfect.ERP;
using Perfect.Data.Helper;
using System.Collections.Specialized;
using Perfect.Utils.App;

namespace Perfect.Core
{
    public partial class xfmLocks : XtraForm
    {
        public delegate void PercentEventHander(object sender, int percent);

        public event PercentEventHander Percent;

        private void RaisePercentEventHander(int percent)
        {
            if (Percent != null) Percent(this, percent);
           
        }


        public delegate void PositionEventHander(object sender, int percent);

        public event PositionEventHander Position;

        private void RaisePositionEventHander(int percent)
        {
            if (Position != null) Position(this, percent);
        }


        public delegate void TextChangedEventHander(object sender, string message);

        public event TextChangedEventHander TextChanged;

        private void RaiseTextChangedEventHander(string message)
        {
            if (TextChanged != null) TextChanged(this, message);
        }


        public event TextChangedEventHander ItemText;

        void RaiseItemTextEventHander(string message)
        {
            TextChangedEventHander hander = ItemText;
            if (hander != null) hander(this, message);
        }

        public event TextChangedEventHander Complete;

        private void RaiseComplete(string message)
        {
            TextChangedEventHander complete = Complete;
            if (complete != null) complete(this, message);
        }

        public event TextChangedEventHander Fail;

        private void RaiseFailEventHander(string message)
        {
            TextChangedEventHander hander = Fail;
            if (hander != null) hander(this, message);
        }


        private string connectString = "";
        private bool cancel = false;

        public xfmLocks()
        {
            InitializeComponent();
            string drive = DataController.DataMaker.GetLastDrive();
            txtPath.Text= drive + "\\Database\\Perfect Software\\" + MyAssembly.AssemblyTradeMark;

            Percent += new PercentEventHander(xfmLocks_Percent);
            Position += new PositionEventHander(xfmLocks_Position);
            TextChanged += new TextChangedEventHander(xfmLocks_TextChanged);
            ItemText += new TextChangedEventHander(xfmLocks_ItemText);
            Complete += new TextChangedEventHander(xfmLocks_Complete);
            Fail += new TextChangedEventHander(xfmLocks_Fail);
        }

        void xfmLocks_Fail(object sender, string message)
        {
            if (this.Bar.InvokeRequired)
            {
                TextChangedEventHander myRestore = new TextChangedEventHander(this.xfmLocks_Fail);
                this.Invoke(myRestore, new object[] { sender, message });
            }
            else
            {
                // Bar.Position = percent;
                //lResult.Items.Insert(0, message);
                XtraMessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Bar.Position = 0;
                Bar2.Position = 0;
                //wc.SelectedPage = wpFinish;
            }
        }

        void xfmLocks_Complete(object sender, string message)
        {
            //throw new NotImplementedException();
            if (this.Bar.InvokeRequired)
            {
                TextChangedEventHander myRestore = new TextChangedEventHander(this.xfmLocks_Complete);
                this.Invoke(myRestore, new object[] { sender, message });
            }
            else
            {
                // Bar.Position = percent;
                //lResult.Items.Insert(0, message);
                Bar.Position = 0;
                Bar2.Position = 0;
                wc.SelectedPage = wpFinish;
            }
        }

        void xfmLocks_ItemText(object sender, string message)
        {
            if (this.Bar.InvokeRequired)
            {
                TextChangedEventHander myRestore = new TextChangedEventHander(this.xfmLocks_ItemText);
                this.Invoke(myRestore, new object[] { sender, message });
            }
            else
            {
                // Bar.Position = percent;
                lResult.Items.Insert(0, message);
            }
        }

        void xfmLocks_TextChanged(object sender, string message)
        {
            //throw new NotImplementedException();
            if (this.Bar.InvokeRequired)
            {
                TextChangedEventHander myRestore = new TextChangedEventHander(this.xfmLocks_TextChanged);
                this.Invoke(myRestore, new object[] { sender, message });
            }
            else
            {
                // Bar.Position = percent;
                lResult.Items.Insert(0, message);
            }
        }

        void xfmLocks_Position(object sender, int percent)
        {
            if (this.Bar.InvokeRequired)
            {
                PositionEventHander myRestore = new PositionEventHander(this.xfmLocks_Position);
                this.Invoke(myRestore, new object[] { sender, percent });
            }
            else
            {
                Bar.Position = percent;
            }
        }

        void xfmLocks_Percent(object sender, int percent)
        {
            //throw new NotImplementedException();
            if (this.Bar.InvokeRequired)
            {
                PercentEventHander myRestore = new PercentEventHander(this.xfmLocks_Percent);
                this.Invoke(myRestore, new object[] { sender, percent });
            }
            else
            {
                Bar2.Position = percent;
            }
        }

        private void cbxServer_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                if (cbxServer.Properties.Items.Count != 0) return;
                Cursor.Current = Cursors.WaitCursor;
                cbxServer.Enabled = false;
                DataController dataController = new DataController();
                DataTable dt = dataController.GetServer();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cbxServer.Properties.Items.Add(dt.Rows[i][0]);
                        }
                    }
                }

                if (cbxServer.Properties.Items.Count > 0) cbxServer.SelectedIndex = 0;
                cbxServer.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtPath_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void txtPath_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void rdgAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool disable = rdgAuthentication.SelectedIndex == 0;
            DisableSQLServerAuthentication(disable);
        }

        void DisableSQLServerAuthentication(bool disable)
        {
            teLogin.Enabled = !disable;
            tePassword.Enabled = !disable;
        }

        bool IsConnecttion(string server, string database, string user, string pass)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlHelper sqlHelper = new SqlHelper(server, database, user, pass, rdgAuthentication.SelectedIndex == 0 ? true : false);
            connectString = sqlHelper.RebuildConnectionString();
            if (!sqlHelper.Check())
            {
                XtraMessageBox.Show( sqlHelper.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
                return false;
            }
            Cursor.Current = Cursors.Default;
            return true;
        }

        private void wc_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            //MessageBox.Show(e.Page.Name);
            if (e.Page == wpServer)
            {
                wpLocks.AllowBack = false;
                wpLocks.AllowNext = false;
                if (!chxCreated.Checked)
                {
                    if (cbxDatabase.Text == "")
                    {
                        XtraMessageBox.Show("Cở Sở Dữ Liệu chưa xác định.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        wc.SelectedPage = wpOptions;
                        return;
                    }

                    if (IsConnecttion(cbxServer.Text, cbxDatabase.Text, teLogin.Text, tePassword.Text))
                    {
                        //MyLogon myLogon = new MyLogon();
                        //myLogon.x(cbxServer.Text, rdgAuthentication.SelectedIndex, teLogin.Text, tePassword.Text, cbxDatabase.Text);
                        //wcFirstRun.SelectedPage = wpComplete;
                        wc.SelectedPage = wpServer;
                        Thread thread = new Thread(new ThreadStart(Execute));
                        thread.Start();
                        return;
                    }
                    else
                    {
                        wc.SelectedPage = wpOptions;
                        return;
                    }

                }
                else
                {
                    Auto();
                }
                // wc.
            }
        }

        void Auto()
        {
            wc.SelectedPage = wpOptions;
            wpServer.AllowBack = false;
            wpServer.AllowNext = false;
            wpServer.AllowCancel = false;
            BarCreated.Visible = true;
            MyLogon myLogon = new MyLogon();
            myLogon.Fail += new MyLogon.FailEventHander(myLogon_Fail);
            myLogon.Error += new MyLogon.ErrorEventHander(myLogon_Error);
            myLogon.Finish += new MyLogon.FinishEventHander(myLogon_Finish);
            myLogon.First += new MyLogon.FirstEventHander(myLogon_First);
            bool authen = rdgAuthentication.SelectedIndex == 0 ? true : false;

            Thread newThread = new Thread(
                () => myLogon.Execute(cbxServer.Text, txtDatabase.Text, teLogin.Text, tePassword.Text, authen,
                                      txtPath.Text));
            newThread.Start();

        }

        void myLogon_First(object sender, string connectString,string database)
        {
            //throw new NotImplementedException();
            if (this.InvokeRequired)
            {
                MyLogon.FirstEventHander myfunc = new MyLogon.FirstEventHander(myLogon_First);
                this.Invoke(myfunc, new object[] { sender, connectString,"" });
            }
            else
            {
                //XtraMessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // wcFirstRun.SelectedPage = wpCreate;
                wc.SelectedPage = wpLocks;
                wpServer.AllowBack = true;
                wpServer.AllowCancel = true;
                wpServer.AllowNext = true;
                BarCreated.Visible = false;
                //autoCreate.Active = false;
                // _exit = false;
                if (!Directory.Exists(Application.StartupPath + "\\Layout"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Layout");
                }

                if (!Directory.Exists(Application.StartupPath + "\\Data"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Data");
                }

                //SqlHelper.ConnectString = connectString;
                //xfmCompany xfmCompany = new xfmCompany(true, 1);
                //xfmCompany.ShowDialog(this);
                //Close();
                chxCreated.Checked = false;
                cbxDatabase.Text = txtDatabase.Text;

                Thread thread = new Thread(new ThreadStart(Execute));
                thread.Start();
            }
        }

        void myLogon_Finish(object sender, string connecstring)
        {
            //throw new NotImplementedException();
            if (this.InvokeRequired)
            {
                MyLogon.FinishEventHander myfunc = new MyLogon.FinishEventHander(myLogon_Error);
                this.Invoke(myfunc, new object[] { sender, connecstring });
            }
        }

        void myLogon_Error(object sender, string message)
        {
            //throw new NotImplementedException();
            if (this.InvokeRequired)
            {
                MyLogon.ErrorEventHander myfunc = new MyLogon.ErrorEventHander(myLogon_Error);
                this.Invoke(myfunc, new object[] { sender, message });
            }
            else
            {
                XtraMessageBox.Show("Không thể tạo được cơ sở dữ liệu\nChi tiết:\n\t" + message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                wc.SelectedPage = wpOptions;
            }
        }

        void myLogon_Fail(object sender)
        {
            if (this.InvokeRequired)
            {
                MyLogon.FailEventHander myfunc = new MyLogon.FailEventHander(myLogon_Fail);
                this.Invoke(myfunc, new object[] { sender });
            }
            else
            {
                //XtraMessageBox.Show(
                //        "Không thể tạo được cơ sở dữ liệu tự động!\nĐể phần mềm hoạt động cần thiết lập cơ sở dữ liệu!\nBạn muốn xem Video hướng dẫn hay thử lại với một cách khác.\nNếu chọn Yes để xem, chọn No để kết thúc ứng dụng.",
                //        "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        void Execute()
        {
            SqlHelper OldSql = new SqlHelper();
            SqlHelper NewSql = new SqlHelper(connectString);

            OldSql.Error += new SqlHelper.ErrorEventHander(sqlHelper_Error);
            NewSql.Error += new SqlHelper.ErrorEventHander(sqlHelper_Error);

            string _new = NewSql.Start();
            string _old = OldSql.Start();

            if (_new != "OK")
            {
               // XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }

            if (_old != "OK")
            {
                //XtraMessageBox.Show(_old, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }

            RaisePositionEventHander(1);
            if (chxDelete.Checked)
            {
                RaiseTextChangedEventHander("** Đang xóa dữ liệu cũ **");
                _new = DataDelete(NewSql);
                if (_new != "OK")
                {
                   // XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NewSql.RollBack();
                    OldSql.RollBack();
                    cancel = false;
                    RaiseFailEventHander(_new);
                    return;
                }
            }

            RaisePositionEventHander(4);
            RaiseTextChangedEventHander("** Đang sao chép danh mục khu vực **");

            _new = CustomerGroupCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }

            RaisePositionEventHander(5);
            RaiseTextChangedEventHander("** Đang sao chép danh mục khách hàng **");
            _new = CustomerCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(10);
            RaiseTextChangedEventHander("** Đang sao chép danh mục nhà phân phối **");
            _new = ProviderCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(15);
            RaiseTextChangedEventHander("** Đang sao chép danh mục đơn vị **");
            _new = UnitCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(20);
            RaiseTextChangedEventHander("** Đang sao chép danh mục nhóm hàng hóa **");
            _new = ProductGroupCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(25);
            RaiseTextChangedEventHander("** Đang sao chép danh mục kho hàng **");
            _new = StockCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(30);
            RaiseTextChangedEventHander("** Đang sao chép danh mục hàng hóa **");
            _new = ProductCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(35);
            RaiseTextChangedEventHander("** Đang sao chép danh mục đơn vị quy đổi **");
            _new = ProductUnitCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(40);
            RaiseTextChangedEventHander("** Đang sao chép danh mục bộ phận **");
            _new = DepartmentCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }

            RaisePositionEventHander(45);
            RaiseTextChangedEventHander("** Đang sao chép danh mục nhân viên **");
            _new = EmployeeCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            RaisePositionEventHander(50);
            RaiseTextChangedEventHander("** Đang sao chép danh mục cấu tạo **");
            _new = ProductBuildCopy(OldSql, NewSql);
            if (_new != "OK")
            {
                //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewSql.RollBack();
                OldSql.RollBack();
                cancel = false;
                RaiseFailEventHander(_new);
                return;
            }
            //if (chxOnly.Checked)
            //{
            //    RaisePositionEventHander(55);
            //    RaiseTextChangedEventHander("** Đang sao chép chứng từ nhập kho **");
            //    InwardCopy();
            //    RaisePositionEventHander(60);
            //    RaiseTextChangedEventHander("** Đang sao chép chi tiết chứng từ nhập kho **");
            //    InwardDetailCopy();
            //    RaisePositionEventHander(65);
            //    RaiseTextChangedEventHander("** Đang sao chép chứng từ xuất kho **");
            //    OutwardCopy();
            //    RaisePositionEventHander(70);
            //    RaiseTextChangedEventHander("** Đang sao chép chi tiết chứng từ nhập kho **");
            //    OutwardDetailCopy();
            //    RaisePositionEventHander(75);
            //    RaiseTextChangedEventHander("** Đang sao chép chứng từ chuyển kho **");
            //    TransferCopy();
            //    RaisePositionEventHander(80);
            //    RaiseTextChangedEventHander("** Đang sao chép chi tiết chứng từ chuyển kho **");
            //    TransferDetailCopy();
            //    RaisePositionEventHander(85);
            //    RaiseTextChangedEventHander("** Đang sao chép chứng từ kiểm kê **");
            //    AdjustCopy();
            //    RaisePositionEventHander(90);
            //    RaiseTextChangedEventHander("** Đang sao chép chi tiết chứng từ kiểm kê **");
            //    AdjustDetailCopy();
            //    RaisePositionEventHander(95);
            //    RaiseTextChangedEventHander("** Đang sao chép sổ chứng từ **");
            //    TransRefCopy();
            //}
            if (chxLocks.Checked)
            {
                RaisePositionEventHander(50);
                RaiseTextChangedEventHander("** Đang kết chuyển số dư đầu kỳ **");
                _new = InitStockCopy(OldSql, NewSql);
                if (_new != "OK")
                {
                    //XtraMessageBox.Show(_new, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NewSql.RollBack();
                    OldSql.RollBack();
                    cancel = false;
                    RaiseFailEventHander(_new);
                    return;
                }
            }

            RaisePositionEventHander(100);
            RaiseTextChangedEventHander("** Hoàn tất **");
            NewSql.Commit();
            OldSql.Commit();
            cancel = false;
            RaiseComplete("Hoan Thanh");
        }


        string DataDelete(SqlHelper mysql)
        {
            if (cancel)
            {
                //if (
                //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                //    System.Windows.Forms.DialogResult.No)
                mysql.RollBack();
                    return "Hủy bởi người sử dụng.";
            }

            StringCollection sqls = new StringCollection();
            sqls.Add("delete  from STOCK_INWARD");
            sqls.Add("delete  from STOCK_INWARD_DETAIL");
            sqls.Add("delete  from STOCK_OUTWARD");
            sqls.Add("delete  from STOCK_OUTWARD_DETAIL");
            sqls.Add("delete  from STOCK_TRANSFER");
            sqls.Add("delete  from STOCK_TRANSFER_DETAIL");
            sqls.Add("delete  from STOCK_BUILD");
            sqls.Add("delete  from STOCK_BUILD_DETAIL");
            sqls.Add("delete  from ADJUSTMENT");
            sqls.Add("delete  from ADJUSTMENT_DETAIL");
            sqls.Add("delete  from INVENTORY_DETAIL");
            sqls.Add("delete  from INVENTORY");
            sqls.Add("DELETE FROM [PRODUCT_BUILD]");
            sqls.Add("DELETE FROM PRODUCT_UNIT");
            sqls.Add("DELETE FROM PRODUCT");
            sqls.Add("DELETE FROM [PRODUCT_GROUP]");
            sqls.Add("delete from UNIT");
            sqls.Add("delete from UNITCONVERT");
            sqls.Add("DELETE FROM EMPLOYEE");
            sqls.Add("DELETE FROM DEPARTMENT");
            sqls.Add("delete from STOCK");
            sqls.Add("delete from PROVIDER");
            sqls.Add("delete from CUSTOMER");
            sqls.Add("DELETE FROM CUSTOMER_GROUP");
            sqls.Add("DELETE FROM TRANS_REF");
            return mysql.ExecuteNonQuery(mysql.Transaction, CommandType.Text, sqls);
        }


        string ProductBuildCopy(SqlHelper OldSql, SqlHelper NewSql)
        {
            string result = "OK";
            OldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = OldSql.ExecuteDataTable(OldSql.Transaction, "Select * From [PRODUCT_BUILD]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                        return "Hủy bởi người sử dụng.";
                }

                string[] myPara = { 
                                    "@ProductID",
		                            "@BuildID",
		                            "@Quantity",
		                            "@Price",
		                            "@Amount" 
                                  };
                object[] myvalue = {
                                       dt.Rows[i]["ProductID"], 
                                       dt.Rows[i]["BuildID"],
                                       dt.Rows[i]["Quantity"],
                                       dt.Rows[i]["Price"],
                                       dt.Rows[i]["Amount"]
                                   };

                NewSql.CommandType = CommandType.Text;
                result =
                    NewSql.ExecuteNonQuery(NewSql.Transaction,
                        "INSERT INTO [PRODUCT_BUILD] (ProductID,BuildID,Quantity,Price,Amount)VALUES (@ProductID,@BuildID,@Quantity,@Price,@Amount)", myPara, myvalue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["ProductID"] + "-->" + dt.Rows[i]["BuildID"]);
                if (result != "OK")
                {
                    OldSql.RollBack();
                    NewSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string InitStockCopy(SqlHelper OldSql, SqlHelper NewSql)
        {
            string result = "OK";
            OldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = OldSql.ExecuteDataTable(OldSql.Transaction, "Select * From [INVENTORY] where Quantity>0");

            string _id = "DK" + string.Format("{0:ddMMyyyy}", DateTime.Now);
            if (dt.Rows.Count > 0)
            {
                STOCK_INWARD cls = new STOCK_INWARD();

                if (!cls.Insert(
                    NewSql.Transaction,
                    _id,
                    DateTime.Now,
                    "",
                    0,
                    "", "", DateTime.Now, DateTime.Now,
                    _id,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "Đầu Kỳ",
                    "",
                    "",
                    "",
                    0,
                    SysOption.Currency,
                    1,
                    0,
                    0,0,
                    0,DateTime.Now,0,0,
                    0,
                    0,
                    false,
                     "(Số Dư Đầu Kỳ)",
                     0,
                     MyLogin.UserId,
                     true))
                {
                    result = NewSql.Result;
                    NewSql.RollBack();
                    OldSql.RollBack();
                    //XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Luu.Enabled = true;
                    return result;
                }
            }

            STOCK_INWARD_DETAIL detail = new STOCK_INWARD_DETAIL();
            PRODUCT product = new PRODUCT();
            string proid = "";
            decimal qty = 0;
            decimal amt = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                        return "Hủy bởi người sử dụng.";
                }

                proid = dt.Rows[i]["Product_ID"].ToString();
                if (product.Get(proid) != "OK")
                {
                    result = NewSql.Result;
                    //DoHide();
                    NewSql.RollBack();
                    return result;
                }

                qty = Convert.ToDecimal(dt.Rows[i]["Quantity"]);
                amt = Convert.ToDecimal(dt.Rows[i]["Amount"]);
                if (!detail.Insert
                                (
                                NewSql.Transaction,
                                Guid.NewGuid().ToString(),
                                _id,
                                proid,
                                product.Product_Name,
                                0,
                                dt.Rows[i]["Stock_ID"].ToString(),
                                //0,
                                //0,
                                //0,
                                //0,
                                product.Unit,
                                1,
                                0,
                                0,
                                0,
                                qty,
                                amt / qty,
                                amt,
                                qty,0,
                                0,
                                0,
                                Convert.ToDateTime(dt.Rows[i]["Limit"] == DBNull.Value ? DateTime.Now : dt.Rows[i]["Limit"]),
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
                                "(Số Dư Đầu Kỳ)",
                                0,
                                true))
                {
                    //XtraMessageBox.Show("Lỗi:\n\t" + result, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    result = NewSql.Result;
                    //DoHide();
                    NewSql.RollBack();
                    return result;
                }

                RaiseItemTextEventHander(">>" + dt.Rows[i]["Product_ID"] + "-->");
                if (result != "OK")
                {
                    OldSql.RollBack();
                    NewSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string CustomerCopy(SqlHelper OldSql, SqlHelper NewSql)
        {
            string result = "OK";
            OldSql.CommandType = CommandType.Text;
            DataTable dt = OldSql.ExecuteDataTable(OldSql.Transaction, "Select * From CUSTOMER");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                        return "Hủy bởi người sử dụng.";
                }

                string sql = "INSERT INTO [CUSTOMER] (";
                sql += "Customer_ID,";
                sql += "OrderID,";
                sql += "CustomerName,";
                sql += "Customer_Type_ID,";
                sql += "Customer_Group_ID,";
                sql += "CustomerAddress,";
                sql += "Birthday,";
                sql += "Barcode,";
                sql += "Tax,";
                sql += "Tel,";
                sql += "Fax,";
                sql += "Email,";
                sql += "Mobile,";
                sql += "Website,";
                sql += "Contact,";
                sql += "Position,";
                sql += "NickYM,";
                sql += "NickSky,";
                sql += "Area,";
                sql += "District,";
                sql += "Contry,";
                sql += "City,";
                sql += "BankAccount,";
                sql += "BankName,";
                sql += "CreditLimit,";
                sql += "Discount,";
                sql += "IsDebt,";
                sql += "IsDebtDetail,";
                sql += "IsProvider,";
                sql += "Description,";
                sql += "Active";
                sql += ")";
                sql += "VALUES (";
                sql += "@Customer_ID,";
                sql += "@OrderID,";
                sql += "@CustomerName,";
                sql += "@Customer_Type_ID,";
                sql += "@Customer_Group_ID,";
                sql += "@CustomerAddress,";
                sql += "@Birthday,";
                sql += "@Barcode,";
                sql += "@Tax,";
                sql += "@Tel,";
                sql += "@Fax,";
                sql += "@Email,";
                sql += "@Mobile,";
                sql += "@Website,";
                sql += "@Contact,";
                sql += "@Position,";
                sql += "@NickYM,";
                sql += "@NickSky,";
                sql += "@Area,";
                sql += "@District,";
                sql += "@Contry,";
                sql += "@City,";
                sql += "@BankAccount,";
                sql += "@BankName,";
                sql += "@CreditLimit,";
                sql += "@Discount,";
                sql += "@IsDebt,";
                sql += "@IsDebtDetail,";
                sql += "@IsProvider,";
                sql += "@Description,";
                sql += "@Active)";

                string[] myPara = 
                {
                    "@Customer_ID",
                    "@OrderID",
                    "@CustomerName",
                    "@Customer_Type_ID",
                    "@Customer_Group_ID",
                    "@CustomerAddress",
                    "@Birthday",
                    "@Barcode",
                    "@Tax",
                    "@Tel",
                    "@Fax",
                    "@Email",
                    "@Mobile",
                    "@Website",
                    "@Contact",
                    "@Position",
                    "@NickYM",
                    "@NickSky",
                    "@Area",
                    "@District",
                    "@Contry",
                    "@City",
                    "@BankAccount",
                    "@BankName",
                    "@CreditLimit",
                    "@Discount",
                    "@IsDebt",
                    "@IsDebtDetail",
                    "@IsProvider",
                    "@Description",
                    "@Active"
                };

                object[] myValue = 
                {
                    dt.Rows[i]["Customer_ID"],
                    dt.Rows[i]["OrderID"],
                    dt.Rows[i]["CustomerName"],
                    dt.Rows[i]["Customer_Type_ID"],
                    dt.Rows[i]["Customer_Group_ID"],
                    dt.Rows[i]["CustomerAddress"],
                    dt.Rows[i]["Birthday"],
                    dt.Rows[i]["Barcode"],
                    dt.Rows[i]["Tax"],
                    dt.Rows[i]["Tel"],
                    dt.Rows[i]["Fax"],
                    dt.Rows[i]["Email"],
                    dt.Rows[i]["Mobile"],
                    dt.Rows[i]["Website"],
                    dt.Rows[i]["Contact"],
                    dt.Rows[i]["Position"],
                    dt.Rows[i]["NickYM"],
                    dt.Rows[i]["NickSky"],
                    dt.Rows[i]["Area"],
                    dt.Rows[i]["District"],
                    dt.Rows[i]["Contry"],
                    dt.Rows[i]["City"],
                    dt.Rows[i]["BankAccount"],
                    dt.Rows[i]["BankName"],
                    dt.Rows[i]["CreditLimit"],
                    dt.Rows[i]["Discount"],
                    true,
                    true,
                    true,
                    dt.Rows[i]["Description"],
                    dt.Rows[i]["Active"]
                };

                NewSql.CommandType = CommandType.Text;
                result = NewSql.ExecuteNonQuery(NewSql.Transaction, sql, myPara, myValue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["CustomerName"]);
                if (result != "OK")
                {
                    OldSql.RollBack();
                    NewSql.RollBack();
                    return result;
                }

                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));

            }
            //wpLocks.AllowBack = true;
            // wpLocks.AllowNext = true;
            //wc.SelectedPage = wpFinish;
            // wpFinish.Text = "Thử nghiệm...";
            return "OK";
        }

        string ProductCopy(SqlHelper oldSql, SqlHelper newSql)
        {
            string result = "OK";
            oldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = oldSql.ExecuteDataTable(oldSql.Transaction, "select * from [PRODUCT]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }
                string sql = "INSERT INTO [PRODUCT] (";
                sql += "Product_ID,";
                sql += "Product_Name,";
                sql += "Product_NameEN,";
                sql += "Product_Type_ID,";
                sql += "Manufacturer_ID,";
                sql += "Model_ID,";
                sql += "Product_Group_ID,";
                sql += "Provider_ID,";
                sql += "Origin,";
                sql += "Barcode,";
                sql += "Unit,";
                sql += "UnitConvert,";
                sql += "UnitRate,";
                sql += "Org_Price,";
                sql += "Sale_Price,";
                sql += "Retail_Price,";
                sql += "Quantity,";
                sql += "CurrentCost,";
                sql += "AverageCost,";
                sql += "Warranty,";
                sql += "VAT_ID,";
                sql += "ImportTax_ID,";
                sql += "ExportTax_ID,";
                sql += "LuxuryTax_ID,";
                sql += "Customer_ID,";
                sql += "Customer_Name,";
                sql += "CostMethod,";
                sql += "MinStock,";
                sql += "MaxStock,";
                sql += "Discount,";
                sql += "Commission,";
                sql += "Description,";
                sql += "Color,";
                sql += "Expiry,";
                sql += "LimitOrders,";
                sql += "ExpiryValue,";
                sql += "Batch,";
                sql += "Depth,";
                sql += "Height,";
                sql += "Width,";
                sql += "Thickness,";
                sql += "Size,";
                // sql += "Photo,";
                sql += "Currency_ID,";
                sql += "ExchangeRate,";
                sql += "Stock_ID,";
                sql += "UserID,";
                sql += "Serial,";
                sql += "Active";
                sql += ")";
                sql += "VALUES (";
                sql += "@Product_ID,";
                sql += "@Product_Name,";
                sql += "@Product_NameEN,";
                sql += "@Product_Type_ID,";
                sql += "@Manufacturer_ID,";
                sql += "@Model_ID,";
                sql += "@Product_Group_ID,";
                sql += "@Provider_ID,";
                sql += "@Origin,";
                sql += "@Barcode,";
                sql += "@Unit,";
                sql += "@UnitConvert,";
                sql += "@UnitRate,";
                sql += "@Org_Price,";
                sql += "@Sale_Price,";
                sql += "@Retail_Price,";
                sql += "@Quantity,";
                sql += "@CurrentCost,";
                sql += "@AverageCost,";
                sql += "@Warranty,";
                sql += "@VAT_ID,";
                sql += "@ImportTax_ID,";
                sql += "@ExportTax_ID,";
                sql += "@LuxuryTax_ID,";
                sql += "@Customer_ID,";
                sql += "@Customer_Name,";
                sql += "@CostMethod,";
                sql += "@MinStock,";
                sql += "@MaxStock,";
                sql += "@Discount,";
                sql += "@Commission,";
                sql += "@Description,";
                sql += "@Color,";
                sql += "@Expiry,";
                sql += "@LimitOrders,";
                sql += "@ExpiryValue,";
                sql += "@Batch,";
                sql += "@Depth,";
                sql += "@Height,";
                sql += "@Width,";
                sql += "@Thickness,";
                sql += "@Size,";
                //sql += "@Photo,";
                sql += "@Currency_ID,";
                sql += "@ExchangeRate,";
                sql += "@Stock_ID,";
                sql += "@UserID,";
                sql += "@Serial,";
                sql += "@Active)";

                string[] myPara =
                    {
                        "@Product_ID",
                        "@Product_Name",
                        "@Product_NameEN",
                        "@Product_Type_ID",
                        "@Manufacturer_ID",
                        "@Model_ID",
                        "@Product_Group_ID",
                        "@Provider_ID",
                        "@Origin",
                        "@Barcode",
                        "@Unit",
                        "@UnitConvert",
                        "@UnitRate",
                        "@Org_Price",
                        "@Sale_Price",
                        "@Retail_Price",
                        "@Quantity",
                        "@CurrentCost",
                        "@AverageCost",
                        "@Warranty",
                        "@VAT_ID",
                        "@ImportTax_ID",
                        "@ExportTax_ID",
                        "@LuxuryTax_ID",
                        "@Customer_ID",
                        "@Customer_Name",
                        "@CostMethod",
                        "@MinStock",
                        "@MaxStock",
                        "@Discount",
                        "@Commission",
                        "@Description",
                        "@Color",
                        "@Expiry",
                        "@LimitOrders",
                        "@ExpiryValue",
                        "@Batch",
                        "@Depth",
                        "@Height",
                        "@Width",
                        "@Thickness",
                        "@Size",
                       // "@Photo",
                        "@Currency_ID",
                        "@ExchangeRate",
                        "@Stock_ID",
                        "@UserID",
                        "@Serial",
                        "@Active"};
                object[] myvalue =
                    {
                         dt.Rows[i]["Product_ID"],
                         dt.Rows[i]["Product_Name"],
                         dt.Rows[i]["Product_NameEN"],
                         dt.Rows[i]["Product_Type_ID"],
                         dt.Rows[i]["Manufacturer_ID"],
                         dt.Rows[i]["Model_ID"],
                         dt.Rows[i]["Product_Group_ID"],
                         dt.Rows[i]["Provider_ID"],
                         dt.Rows[i]["Origin"],
                         dt.Rows[i]["Barcode"],
                         dt.Rows[i]["Unit"],
                         dt.Rows[i]["UnitConvert"],
                         dt.Rows[i]["UnitRate"],
                         dt.Rows[i]["Org_Price"],
                         dt.Rows[i]["Sale_Price"],
                         dt.Rows[i]["Retail_Price"],
                         dt.Rows[i]["Quantity"],
                         dt.Rows[i]["CurrentCost"],
                         dt.Rows[i]["AverageCost"],
                         dt.Rows[i]["Warranty"],
                         dt.Rows[i]["VAT_ID"],
                         dt.Rows[i]["ImportTax_ID"],
                         dt.Rows[i]["ExportTax_ID"],
                         dt.Rows[i]["LuxuryTax_ID"],
                         dt.Rows[i]["Customer_ID"],
                         dt.Rows[i]["Customer_Name"],
                         dt.Rows[i]["CostMethod"],
                         dt.Rows[i]["MinStock"],
                         dt.Rows[i]["MaxStock"],
                         dt.Rows[i]["Discount"],
                         dt.Rows[i]["Commission"],
                         dt.Rows[i]["Description"],
                         dt.Rows[i]["Color"],
                         dt.Rows[i]["Expiry"],
                         dt.Rows[i]["LimitOrders"],
                         dt.Rows[i]["ExpiryValue"],
                         dt.Rows[i]["Batch"],
                         dt.Rows[i]["Depth"],
                         dt.Rows[i]["Height"],
                         dt.Rows[i]["Width"],
                         dt.Rows[i]["Thickness"],
                         dt.Rows[i]["Size"],
                        // dt.Rows[i]["Photo"],
                         dt.Rows[i]["Currency_ID"],
                         dt.Rows[i]["ExchangeRate"],
                         dt.Rows[i]["Stock_ID"],
                         dt.Rows[i]["UserID"],
                         dt.Rows[i]["Serial"],
                         dt.Rows[i]["Active"],
                    };

                newSql.CommandType = CommandType.Text;
                result =
                    newSql.ExecuteNonQuery(newSql.Transaction, sql, myPara, myvalue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["Product_Name"]);
                if (result != "OK")
                {
                    oldSql.RollBack();
                    newSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        void sqlHelper_Error(object sender, SqlHelperException e)
        {
            //throw new NotImplementedException();
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        string CustomerGroupCopy(SqlHelper oldSql, SqlHelper newSql)
        {
            string result = "OK";
            oldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = oldSql.ExecuteDataTable(oldSql.Transaction, "select * from CUSTOMER_GROUP");
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }
                string[] myPara = { "@Customer_Group_ID", "@Customer_Group_Name", "@Description", "@Active" };
                object[] myvalue = { dt.Rows[i]["Customer_Group_ID"], dt.Rows[i]["Customer_Group_Name"], dt.Rows[i]["Description"], dt.Rows[i]["Active"] };

                newSql.CommandType = CommandType.Text;
                result =
                    newSql.ExecuteNonQuery(newSql.Transaction,
                        "INSERT INTO [CUSTOMER_GROUP] (Customer_Group_ID,Customer_Group_Name,Description,Active)VALUES (@Customer_Group_ID,@Customer_Group_Name,@Description,@Active)", myPara, myvalue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["Customer_Group_Name"]);
                if (result != "OK")
                {
                    oldSql.RollBack();
                    newSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string ProviderCopy(SqlHelper OldSql, SqlHelper NewSql)
        {
            string result = "OK";
            OldSql.CommandType = CommandType.Text;
            DataTable dt = OldSql.ExecuteDataTable(OldSql.Transaction, "Select * From PROVIDER");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }

                string sql = "INSERT INTO [PROVIDER] (";
                sql += "Customer_ID,";
                sql += "OrderID,";
                sql += "CustomerName,";
                sql += "Customer_Type_ID,";
                sql += "Customer_Group_ID,";
                sql += "CustomerAddress,";
                sql += "Birthday,";
                sql += "Barcode,";
                sql += "Tax,";
                sql += "Tel,";
                sql += "Fax,";
                sql += "Email,";
                sql += "Mobile,";
                sql += "Website,";
                sql += "Contact,";
                sql += "Position,";
                sql += "NickYM,";
                sql += "NickSky,";
                sql += "Area,";
                sql += "District,";
                sql += "Contry,";
                sql += "City,";
                sql += "BankAccount,";
                sql += "BankName,";
                sql += "CreditLimit,";
                sql += "Discount,";
                sql += "IsDebt,";
                sql += "IsDebtDetail,";
                sql += "IsProvider,";
                sql += "Description,";
                sql += "Active";
                sql += ")";
                sql += "VALUES (";
                sql += "@Customer_ID,";
                sql += "@OrderID,";
                sql += "@CustomerName,";
                sql += "@Customer_Type_ID,";
                sql += "@Customer_Group_ID,";
                sql += "@CustomerAddress,";
                sql += "@Birthday,";
                sql += "@Barcode,";
                sql += "@Tax,";
                sql += "@Tel,";
                sql += "@Fax,";
                sql += "@Email,";
                sql += "@Mobile,";
                sql += "@Website,";
                sql += "@Contact,";
                sql += "@Position,";
                sql += "@NickYM,";
                sql += "@NickSky,";
                sql += "@Area,";
                sql += "@District,";
                sql += "@Contry,";
                sql += "@City,";
                sql += "@BankAccount,";
                sql += "@BankName,";
                sql += "@CreditLimit,";
                sql += "@Discount,";
                sql += "@IsDebt,";
                sql += "@IsDebtDetail,";
                sql += "@IsProvider,";
                sql += "@Description,";
                sql += "@Active)";

                string[] myPara = 
                {
                    "@Customer_ID",
                    "@OrderID",
                    "@CustomerName",
                    "@Customer_Type_ID",
                    "@Customer_Group_ID",
                    "@CustomerAddress",
                    "@Birthday",
                    "@Barcode",
                    "@Tax",
                    "@Tel",
                    "@Fax",
                    "@Email",
                    "@Mobile",
                    "@Website",
                    "@Contact",
                    "@Position",
                    "@NickYM",
                    "@NickSky",
                    "@Area",
                    "@District",
                    "@Contry",
                    "@City",
                    "@BankAccount",
                    "@BankName",
                    "@CreditLimit",
                    "@Discount",
                    "@IsDebt",
                    "@IsDebtDetail",
                    "@IsProvider",
                    "@Description",
                    "@Active"
                };

                object[] myValue = 
                {
                    dt.Rows[i]["Customer_ID"],
                    dt.Rows[i]["OrderID"],
                    dt.Rows[i]["CustomerName"],
                    dt.Rows[i]["Customer_Type_ID"],
                    dt.Rows[i]["Customer_Group_ID"],
                    dt.Rows[i]["CustomerAddress"],
                    dt.Rows[i]["Birthday"],
                    dt.Rows[i]["Barcode"],
                    dt.Rows[i]["Tax"],
                    dt.Rows[i]["Tel"],
                    dt.Rows[i]["Fax"],
                    dt.Rows[i]["Email"],
                    dt.Rows[i]["Mobile"],
                    dt.Rows[i]["Website"],
                    dt.Rows[i]["Contact"],
                    dt.Rows[i]["Position"],
                    dt.Rows[i]["NickYM"],
                    dt.Rows[i]["NickSky"],
                    dt.Rows[i]["Area"],
                    dt.Rows[i]["District"],
                    dt.Rows[i]["Contry"],
                    dt.Rows[i]["City"],
                    dt.Rows[i]["BankAccount"],
                    dt.Rows[i]["BankName"],
                    dt.Rows[i]["CreditLimit"],
                    dt.Rows[i]["Discount"],
                    true,
                    true,
                    true,
                    dt.Rows[i]["Description"],
                    dt.Rows[i]["Active"]
                };

                NewSql.CommandType = CommandType.Text;
                result = NewSql.ExecuteNonQuery(NewSql.Transaction, sql, myPara, myValue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["CustomerName"]);
                if (result != "OK")
                {
                    OldSql.RollBack();
                    NewSql.RollBack();
                    return result;
                }

                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));

            }
            //wpLocks.AllowBack = true;
            // wpLocks.AllowNext = true;
            //wc.SelectedPage = wpFinish;
            // wpFinish.Text = "Thử nghiệm...";
            return "OK";
        }

        string DepartmentCopy(SqlHelper OldSql, SqlHelper NewSql)
        {
            string result = "OK";
            OldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = OldSql.ExecuteDataTable(OldSql.Transaction, "Select * From [DEPARTMENT]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }

                string[] myPara = { "@Department_ID", "@Department_Name", "@Description", "@Active" };
                object[] myvalue = { dt.Rows[i]["Department_ID"], dt.Rows[i]["Department_Name"], dt.Rows[i]["Description"], dt.Rows[i]["Active"] };

                NewSql.CommandType = CommandType.Text;
                result =
                    NewSql.ExecuteNonQuery(NewSql.Transaction,
                        "INSERT INTO [DEPARTMENT] (Department_ID,Department_Name,Description,Active)VALUES (@Department_ID,@Department_Name,@Description,@Active)", myPara, myvalue);
                RaiseItemTextEventHander(">>" + dt.Rows[i]["Department_Name"]);
                if (result != "OK")
                {
                    OldSql.RollBack();
                    NewSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string EmployeeCopy(SqlHelper OldSql, SqlHelper NewSql)
        {
            string result = "OK";
            OldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = OldSql.ExecuteDataTable(OldSql.Transaction, "Select * From [EMPLOYEE]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }
                string sql = "INSERT INTO [EMPLOYEE] (";
                sql += "Employee_ID,";
                sql += "FirtName,";
                sql += "LastName,";
                sql += "Employee_Name,";
                sql += "Alias,";
                sql += "Sex,";
                sql += "Address,";
                sql += "Country_ID,";
                sql += "H_Tel,";
                sql += "O_Tel,";
                sql += "Mobile,";
                sql += "Fax,";
                sql += "Email,";
                sql += "Birthday,";
                sql += "Married,";
                sql += "Position_ID,";
                sql += "JobTitle_ID,";
                sql += "Branch_ID,";
                sql += "Department_ID,";
                sql += "Team_ID,";
                sql += "PersonalTax_ID,";
                sql += "City_ID,";
                sql += "District_ID,";
                sql += "Manager_ID,";
                sql += "EmployeeType,";
                sql += "BasicSalary,";
                sql += "Advance,";
                sql += "AdvanceOther,";
                sql += "Commission,";
                sql += "Discount,";
                sql += "ProfitRate,";
                sql += "IsPublic,";
                sql += "CreatedBy,";
                sql += "CreatedDate,";
                sql += "ModifiedBy,";
                sql += "ModifiedDate,";
                sql += "OwnerID,";
                sql += "Description,";
                sql += "Sorted,";
                sql += "Active";
                sql += ")";
                sql += "VALUES (";
                sql += "@Employee_ID,";
                sql += "@FirtName,";
                sql += "@LastName,";
                sql += "@Employee_Name,";
                sql += "@Alias,";
                sql += "@Sex,";
                sql += "@Address,";
                sql += "@Country_ID,";
                sql += "@H_Tel,";
                sql += "@O_Tel,";
                sql += "@Mobile,";
                sql += "@Fax,";
                sql += "@Email,";
                sql += "@Birthday,";
                sql += "@Married,";
                sql += "@Position_ID,";
                sql += "@JobTitle_ID,";
                sql += "@Branch_ID,";
                sql += "@Department_ID,";
                sql += "@Team_ID,";
                sql += "@PersonalTax_ID,";
                sql += "@City_ID,";
                sql += "@District_ID,";
                sql += "@Manager_ID,";
                sql += "@EmployeeType,";
                sql += "@BasicSalary,";
                sql += "@Advance,";
                sql += "@AdvanceOther,";
                sql += "@Commission,";
                sql += "@Discount,";
                sql += "@ProfitRate,";
                sql += "@IsPublic,";
                sql += "@CreatedBy,";
                sql += "@CreatedDate,";
                sql += "@ModifiedBy,";
                sql += "@ModifiedDate,";
                sql += "@OwnerID,";
                sql += "@Description,";
                sql += "@Sorted,";
                sql += "@Active)";

                string[] myPara = 
                {
                    "@Employee_ID",
			        "@FirtName",
			        "@LastName",
			        "@Employee_Name",
			        "@Alias",
			        "@Sex",
			        "@Address",
			        "@Country_ID",
			        "@H_Tel",
			        "@O_Tel",
			        "@Mobile",
			        "@Fax",
			        "@Email",
			        "@Birthday",
			        "@Married",
			        "@Position_ID",
			        "@JobTitle_ID",
			        "@Branch_ID",
			        "@Department_ID",
			        "@Team_ID",
			        "@PersonalTax_ID",
			        "@City_ID",
			        "@District_ID",
			        "@Manager_ID",
			        "@EmployeeType",
			        "@BasicSalary",
			        "@Advance",
			        "@AdvanceOther",
			        "@Commission",
			        "@Discount",
			        "@ProfitRate",
			        "@IsPublic",
			        "@CreatedBy",
			        "@CreatedDate",
			        "@ModifiedBy",
			        "@ModifiedDate",
			        "@OwnerID",
			        "@Description",
			        "@Sorted",
			        "@Active"
                };

                object[] myvalue = 
                {
                    dt.Rows[i]["Employee_ID"],
			        dt.Rows[i]["FirtName"],
			        dt.Rows[i]["LastName"],
			        dt.Rows[i]["Employee_Name"],
			        dt.Rows[i]["Alias"],
			        dt.Rows[i]["Sex"],
			        dt.Rows[i]["Address"],
			        dt.Rows[i]["Country_ID"],
			        dt.Rows[i]["H_Tel"],
			        dt.Rows[i]["O_Tel"],
			        dt.Rows[i]["Mobile"],
			        dt.Rows[i]["Fax"],
			        dt.Rows[i]["Email"],
			        dt.Rows[i]["Birthday"],
			        dt.Rows[i]["Married"],
			        dt.Rows[i]["Position_ID"],
			        dt.Rows[i]["JobTitle_ID"],
			        dt.Rows[i]["Branch_ID"],
			        dt.Rows[i]["Department_ID"],
			        dt.Rows[i]["Team_ID"],
			        dt.Rows[i]["PersonalTax_ID"],
			        dt.Rows[i]["City_ID"],
			        dt.Rows[i]["District_ID"],
			        dt.Rows[i]["Manager_ID"],
			        dt.Rows[i]["EmployeeType"],
			        dt.Rows[i]["BasicSalary"],
			        dt.Rows[i]["Advance"],
			        dt.Rows[i]["AdvanceOther"],
			        dt.Rows[i]["Commission"],
			        dt.Rows[i]["Discount"],
			        dt.Rows[i]["ProfitRate"],
			        dt.Rows[i]["IsPublic"],
			        dt.Rows[i]["CreatedBy"],
			        dt.Rows[i]["CreatedDate"],
			        dt.Rows[i]["ModifiedBy"],
			        dt.Rows[i]["ModifiedDate"],
			        dt.Rows[i]["OwnerID"],
			        dt.Rows[i]["Description"],
			        dt.Rows[i]["Sorted"],
			        dt.Rows[i]["Active"]                 
                };

                NewSql.CommandType = CommandType.Text;
                result =
                    NewSql.ExecuteNonQuery(NewSql.Transaction, sql, myPara, myvalue);
                RaiseItemTextEventHander(">>" + dt.Rows[i]["Employee_Name"]);
                if (result != "OK")
                {
                    OldSql.RollBack();
                    NewSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string StockCopy(SqlHelper oldSql, SqlHelper newSql)
        {
            string result = "OK";
            oldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = oldSql.ExecuteDataTable(oldSql.Transaction, "Select * From [STOCK]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }

                string[] myPara = {   "@Stock_ID",
                                      "@Stock_Name",
                                      "@Contact",
                                      "@Address",
                                      "@Email",
                                      "@Telephone",
                                      "@Fax",
                                      "@Mobi",
                                      "@Manager",
                                      "@Description",
                                      "@Active"};

                object[] myvalue = { dt.Rows[i]["Stock_ID"],
                                     dt.Rows[i]["Stock_Name"],
                                     dt.Rows[i]["Contact"],
                                     dt.Rows[i]["Address"], 
                                     dt.Rows[i]["Email"], 
                                     dt.Rows[i]["Telephone"], 
                                     dt.Rows[i]["Fax"], 
                                     dt.Rows[i]["Mobi"], 
                                     dt.Rows[i]["Manager"], 
                                     dt.Rows[i]["Description"], 
                                     dt.Rows[i]["Active"] };

                newSql.CommandType = CommandType.Text;
                result =
                    newSql.ExecuteNonQuery(newSql.Transaction,
                        "INSERT INTO [STOCK] (Stock_ID,Stock_Name,Contact,Address,Email,Telephone,Fax,Mobi,Manager,Description,Active)VALUES (@Stock_ID,@Stock_Name,@Contact,@Address,@Email,@Telephone,@Fax,@Mobi,@Manager,@Description,@Active)", myPara, myvalue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["Stock_Name"]);
                if (result != "OK")
                {
                    oldSql.RollBack();
                    newSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string ProductGroupCopy(SqlHelper oldSql, SqlHelper newSql)
        {
            string result = "OK";
            oldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = oldSql.ExecuteDataTable(oldSql.Transaction, "Select * From [PRODUCT_GROUP]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }
                string[] myPara = { "@ProductGroup_ID", "@ProductGroup_Name", "@Description", "@IsMain", "@Active" };
                object[] myvalue = { dt.Rows[i]["ProductGroup_ID"], dt.Rows[i]["ProductGroup_Name"], dt.Rows[i]["Description"], dt.Rows[i]["IsMain"], dt.Rows[i]["Active"] };

                newSql.CommandType = CommandType.Text;
                result =
                    newSql.ExecuteNonQuery(newSql.Transaction,
                        "INSERT INTO [PRODUCT_GROUP] (ProductGroup_ID,ProductGroup_Name,Description,IsMain,Active)VALUES (@ProductGroup_ID,@ProductGroup_Name,@Description,@IsMain,@Active)", myPara, myvalue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["ProductGroup_Name"]);
                if (result != "OK")
                {
                    oldSql.RollBack();
                    newSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string UnitCopy(SqlHelper oldSql, SqlHelper newSql)
        {
            string result = "OK";
            oldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = oldSql.ExecuteDataTable(oldSql.Transaction, "select * from UNIT");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }
                string[] myPara = { "@Unit_ID", "@Unit_Name", "@Description", "@Active" };
                object[] myvalue = { dt.Rows[i]["Unit_ID"], dt.Rows[i]["Unit_Name"], dt.Rows[i]["Description"], dt.Rows[i]["Active"] };

                newSql.CommandType = CommandType.Text;
                result =
                    newSql.ExecuteNonQuery(newSql.Transaction,
                        "INSERT INTO [UNIT] (Unit_ID,Unit_Name,Description,Active)VALUES (@Unit_ID,@Unit_Name,@Description,@Active)", myPara, myvalue);

                RaiseItemTextEventHander(">>" + dt.Rows[i]["Unit_Name"]);
                if (result != "OK")
                {
                    oldSql.RollBack();
                    newSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        string ProductUnitCopy(SqlHelper oldSql, SqlHelper newSql)
        {
            string result = "OK";
            oldSql.CommandType = CommandType.Text;
            //newSql.AutoCommand = false;
            DataTable dt = oldSql.ExecuteDataTable(oldSql.Transaction, "select * from [PRODUCT_UNIT]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cancel)
                {
                    //if (
                    //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                    //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    //    System.Windows.Forms.DialogResult.No)
                    return "Hủy bởi người sử dụng.";
                }
                
                string[] myPara = { "@Product_ID", "@Unit_ID", "@UnitConvert_ID", "@UnitConvert", "@Sorted" };
                object[] myvalue = { dt.Rows[i]["Product_ID"], dt.Rows[i]["Unit_ID"], dt.Rows[i]["UnitConvert_ID"], dt.Rows[i]["UnitConvert"], dt.Rows[i]["Sorted"] };

                newSql.CommandType = CommandType.Text;
                result =
                    newSql.ExecuteNonQuery(newSql.Transaction,
                        "INSERT INTO [PRODUCT_UNIT] (Product_ID,Unit_ID,UnitConvert_ID,UnitConvert,Sorted)VALUES (@Product_ID,@Unit_ID,@UnitConvert_ID,@UnitConvert,@Sorted)", myPara, myvalue);
                RaiseItemTextEventHander(">>" + dt.Rows[i]["UnitConvert_ID"] + "-->" + dt.Rows[i]["Unit_ID"]);
                if (result != "OK")
                {
                    oldSql.RollBack();
                    newSql.RollBack();
                    return result;
                }
                RaisePercentEventHander((int)((double)i / (double)dt.Rows.Count * 100));
            }
            return "OK";
        }

        void InwardCopy()
        { }

        void InwardDetailCopy()
        { }

        void OutwardCopy()
        { }

        void OutwardDetailCopy()
        { }

        void TransferCopy()
        { }

        void TransferDetailCopy()
        { }

        void AdjustCopy()
        { }

        void AdjustDetailCopy()
        {
        }

        void TransRefCopy()
        { }



        private void wpServer_Click(object sender, EventArgs e)
        {

        }

        private void cbxDatabase_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                if (cbxDatabase.Properties.Items.Count != 0) return;
                Cursor.Current = Cursors.WaitCursor;
                if (!IsConnecttion(cbxServer.Text, "master", teLogin.Text, tePassword.Text))
                {
                    //XtraMessageBox.Show("Không kết nối được đến máy chủ!", "Thông Báo", MessageBoxButtons.OK,
                    //                    MessageBoxIcon.Warning);
                    cbxDatabase.Enabled = true;
                    Cursor.Current = Cursors.Default;
                    rdgAuthentication.Focus();
                    return;
                }
                cbxDatabase.Enabled = false;
                DataController dataController = new DataController();
                DataTable dt;
                if (rdgAuthentication.SelectedIndex == 0)
                {
                    dt = dataController.GetDatabase(cbxServer.Text);
                }
                else
                {
                    dt = dataController.GetDatabase(cbxServer.Text, teLogin.Text, tePassword.Text);
                }
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cbxDatabase.Properties.Items.Add(dt.Rows[i][1]);
                        }
                    }
                }
                if (cbxDatabase.Properties.Items.Count > 0) cbxDatabase.SelectedIndex = 0;
                cbxDatabase.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void chxCreated_CheckedChanged(object sender, EventArgs e)
        {
            cbxDatabase.Enabled = !chxCreated.Checked;
            chxDelete.Enabled = !chxCreated.Checked;
            plCreated.Enabled = chxCreated.Checked;
        }

        private void chxOnly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chxOnly_Click(object sender, EventArgs e)
        {
            chxLocks.Checked = chxOnly.Checked;
        }

        private void chxLocks_Click(object sender, EventArgs e)
        {
            chxOnly.Checked = chxLocks.Checked;
        }

        private void wc_CancelClick(object sender, CancelEventArgs e)
        {

            if (wc.SelectedPage == wpLocks)
            {
                //Thread.CurrentThread.
                //if (
                //    XtraMessageBox.Show("Bạn có chắc chắn hủy bỏ công việc này không?", "Thông Báo",
                //                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                //    System.Windows.Forms.DialogResult.No) return;
                cancel = true;
            }

        }

        private void cbxDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlHelper myHelper=new SqlHelper();
            myHelper.Extract();
            if (cbxDatabase.Text==myHelper.Database & cbxServer.Text==myHelper.Server)
            {
                cbxDatabase.Text = "";
                XtraMessageBox.Show("Đây là cơ sở dữ liệu nguồn, vui lòng chọn lại cở sở dữ liệu khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDatabase_EditValueChanged(object sender, EventArgs e)
        {
            if (txtDatabase.Text=="")
            {
                XtraMessageBox.Show("Tên cơ sở dữ liệu không được bỏ trống, vui lòng chọn lại cở sở dữ liệu khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
