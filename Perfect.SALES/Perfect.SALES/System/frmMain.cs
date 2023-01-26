using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic.CompilerServices;
using Perfect.Common;
using Perfect.Common.Common.Class;
using Perfect.Core;
using Perfect.Data.Core;
using Perfect.Data.Extra.Class;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.Dictionary.Barcode;
using Perfect.Dictionary.Customer;
using Perfect.Dictionary.CustomerGroup;
using Perfect.Dictionary.DelieveryRoute;
using Perfect.Dictionary.Department;
using Perfect.Dictionary.Stock;
using Perfect.ERP;
using Perfect.Inventory.Core.AccessWebsite;
using Perfect.Inventory.Core.Inventory.Init;
using Perfect.Inventory.Core.Inventory.Inventory;
using Perfect.Inventory.Core.Inventory.Inventory.Revenue;
using Perfect.Inventory.Core.Inventory.Inward.SALE;
using Perfect.Inventory.Core.Inventory.Outward.Sale;
using Perfect.Inventory.Core.Inventory.Report;
using Perfect.Inventory.Core.Inventory.Transfer.SALE;
using Perfect.Inventory.Report;
using Perfect.Logonui.Forms;
using Perfect.Net.Info;
using Perfect.Net.Info.Forms;
using Perfect.Sale.Core.INITS;
using Perfect.Security;
using Perfect.Security.Security;
using Perfect.Security.Security.GroupUser;
using Perfect.Security.Security.Permision;
using Perfect.Security.Security.Permision.dsPermisionTableAdapters;
using Perfect.Service.Forms;
using Perfect.Utils.App;
using Perfect.Utils.Security2;
using Perfect.Inventory.My;
using Perfect.Sale.Core.PAYMENT;
using Perfect.Sale.Core.REICEIPT;
using Perfect.Sale.Core.Report;
using System.Xml;
using CUSTOMER = Perfect.Service.Class.CUSTOMER;
using Perfect.Inventory.Core.Inventory.CarryForward;
using Perfect.Inventory.Core.Inventory.Adjustment;

namespace Perfect.Inventory
{
    public partial class FrmMain : RibbonForm
    {
        #region Variable

        #endregion

        #region Contructor

        public FrmMain()
        {
            MyApplication.SotfType = EnumSotfType.Professional;
            var frmLoginOld = new XfmLoginClassic();
            frmLoginOld.LoginSuccess += FrmLoginSuccess;
            frmLoginOld.ShowDialog(this);

        }

        #endregion

        #region Event

        private XfmInventoryAdjustment _inventoryAdjustment;
        private XfmCustomerGroups _xfmCustomerGroups;
        private XfmDelieveryRoute _xfmDelieveryRoute;

        private void BbiAdjustmentItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiAdjustment.Enabled = false;
            Execute("_inventoryAdjustment", "");
            bbiAdjustment.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiBackupItemClick(object sender, ItemClickEventArgs e)
        {
            var xfm = new xfmBackupDatabase();
            xfm.ShowDialog();
        }

        private void BbiChangepasswordItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void BbiCloseItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Unload();
                Application.Exit();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex);
            }
        }

        private void BbiContractItemClick(object sender, ItemClickEventArgs e)
        {
            var xfmCompany = new XfmCompany(true, 2);
            xfmCompany.ShowDialog(this);
        }

        private void BbiCurrencyItemClick(object sender, ItemClickEventArgs e)
        {
            Execute("xfmCurrencys", "");
        }

       

        private void BbiCustomerGroupItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiCustomer.Enabled = false;
            Execute("_xfmCustomerGroups", "");
            bbiCustomer.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiDepartmentItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiDepartment.Enabled = false;
            Execute("xfmDepartments", "");
            bbiDepartment.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiEmployeeItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiEmployee.Enabled = false;
            Execute("xfmEmployees", "");
            bbiEmployee.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiFixItemClick(object sender, ItemClickEventArgs e)
        {
            var xfmDatabaseFix = new xfmDatabaseFix();
            xfmDatabaseFix.Executing += XfmDatabaseFixExecuting;
            xfmDatabaseFix.Executed += XfmDatabaseFixExecuted;
            xfmDatabaseFix.ShowDialog();
        }

        private void XfmDatabaseFixExecuted(object sender)
        {
            Show();
        }

        private void XfmDatabaseFixExecuting(object sender)
        {
            Hide();
        }

        private void BbiHelpItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start("http://www.perfect.com.vn");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex);
            }
        }

        private void BbiHistoryItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiHistory.Enabled = false;
            Execute("xfmHistory", "");
            bbiHistory.Enabled = true;
            Cursor.Current = Cursors.Default;
        }


        private void BbiInventoryItemClick(object sender, ItemClickEventArgs e)
        {
            bbiInventory.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            Execute("xfmInventoryDetail", "");
            Cursor.Current = Cursors.Default;
            bbiInventory.Enabled = true;
        }


        private void BbiInventorySummaryItemClick(object sender, ItemClickEventArgs e)
        {
            bbiInventorySummary.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            Execute("xfmInventorySummary", "");
            Cursor.Current = Cursors.Default;
            bbiInventorySummary.Enabled = true;
        }

        private void BbiInwardItemClick(object sender, ItemClickEventArgs e)
        {
            bbiInward.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            Execute("xfmInward", "");
            Cursor.Current = Cursors.Default;
            bbiInward.Enabled = true;
        }


        private void BbiItemGroupItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiItemGroup.Enabled = false;
            Execute("xfmProductGroups", "");
            bbiItemGroup.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiLogoutItemClick(object sender, ItemClickEventArgs e)
        {
            SysLog.Insert("Hệ Thống", "Đăng xuất");

            bbiLogout.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            var frmLoginOld = new XfmLoginClassic();
            frmLoginOld.LoginSuccess += FrmLoginSuccess;
            frmLoginOld.ShowDialog(this);
            bbiLogout.Enabled = true;
        }

        private void BbiMaterialItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiMaterial.Enabled = false;
            Execute("xfmProducts", "");
            bbiMaterial.Enabled = true;
            Cursor.Current = Cursors.Default;
        }


        private void BbiOptionItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new XfmCompany();
            frm.ShowDialog();
        }

        private void BbiOutwardItemClick(object sender, ItemClickEventArgs e)
        {
            bbiOutward.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            Execute("xfmOutward", "");
            Cursor.Current = Cursors.Default;
            bbiOutward.Enabled = true;
        }


        private void BbiRegsiterItemClick(object sender, ItemClickEventArgs e)
        {
            SysLog.Insert("Bản Quyền Phần Mềm", "Mở");
            var xfmService = new XfmService();
            xfmService.Success += xfmService_Success;
            xfmService.ShowDialog();
        }

        private void xfmService_Success(object sender, CUSTOMER customer)
        {
            MyInfo.Company_Id = MyEncryption.Encrypt("ERP01", "123654", true);
            MyInfo.Company = MyEncryption.Encrypt(customer.NameCompany, "123654", true);
            MyInfo.Address = customer.Address;
            MyInfo.Tel = customer.Tell;
            MyInfo.Fax = customer.Fax;
            MyInfo.WebSite = customer.Website;
            MyInfo.Email = customer.Email;
            MyInfo.Tax = customer.TaxID;
            MyInfo.Licence = customer.BusinessLicense;
            if (!MyInfo.Update())
            {
                XtraMessageBox.Show("Không thể lưu thông tin đăng ký.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void BbiRestoreItemClick(object sender, ItemClickEventArgs e)
        {
            var xfm = new xfmRestoreDatabase();
            xfm.ShowDialog();
        }

        private void BbiStockItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiStock.Enabled = false;
            Execute("xfmStocks", "");
            bbiStock.Enabled = true;
            Cursor.Current = Cursors.Default;
        }


        private void BbiSupplierItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiProvider.Enabled = false;
            Execute("xfmProviders", "");
            bbiProvider.Enabled = true;
            Cursor.Current = Cursors.Default;
        }


        private void BbiSysLogItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiSysLog.Enabled = false;
            Execute("xfmSysLog", "");
            bbiSysLog.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiTransferItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiTransfer.Enabled = false;
            Execute("xfmTransfer", "");
            bbiTransfer.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiTransOutItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiPacket.Enabled = false;
            Execute("_xfmPacket", "");
            bbiPacket.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiUnitItemClick(object sender, ItemClickEventArgs e)
        {
            Execute("xfmUnits", "");
        }

        private void BbiUpdateItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (
                    XtraMessageBox.Show(
                        "Hiện đã có phiên bản mới.\nQuá trình cập nhật sẽ tắt phần mềm đang sử dụng.\nBạn có muốn cập nhật không?.",
                        "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

          
                Process.Start(Application.StartupPath + "\\OnlineUpdate.exe");
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex);
            }
        }

        private void BbiUsersItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiUsers.Enabled = false;
            Execute("xfmUsers", "");
            bbiUsers.Enabled = true;
            Cursor.Current = Cursors.Default;
        }


        private void BbiWebsiteItemClick(object sender, ItemClickEventArgs e)
        {
            string[] website = {
                                   "Phần mềm", "phần cứng", "tin học", "software", "hardware", "máy tính",
                                   "phần mềm miễn phí", "quản lý kho", "quản lý vận tải", "quản lý bán hàng",
                                   "quản lý nhân sự", "quản lý sản xuất", "kế toán", "quản lý bảo hiểm"
                               };
            var rnd = new Random();
            int i = rnd.Next(13);
            Process.Start("http://www.perfect.com.vn/Introduction/PER_Result.aspx?ID=0&cx=partner-pub-7245889420406559%3A6hfx5lo9967&cof=FORID%3A10&q=" +
                website[i] + "&sa=Ti%CC%80m+ki%C3%AA%CC%81m");
        }


        private void BtnAuthorItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new xfmAbout();
            frm.ShowDialog();
        }

        private void DisableAllFunctionWhenNotLicense()
        {
            rpgDeparment.Visible = false;
            rbpDictionary.Visible = false;
            rbpStock.Visible = false;
            rbpSystem.Visible = false;
        }
        public void SetFormFullscreen()
        {
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void FrmLoginSuccess(object sender)
        {

            //if (GreenFull.GetOsInfo() == @"7")
            //{
            //    WindowState = FormWindowState.Maximized;
            //    Bounds = Screen.PrimaryScreen.Bounds;
            //}
            //else if (GreenFull.GetOsInfo() == @"XP")
            //{
            //    Top = 0;
            //    Bounds = Screen.PrimaryScreen.Bounds;
            //}
            WindowState = FormWindowState.Maximized;
            Bounds = Screen.PrimaryScreen.Bounds;

            InitializeComponent();

            bbiLocks.Visibility = BarItemVisibility.Never;


            AutoScaleMode = AutoScaleMode.Font;
            Options.FormProcess.SetProgressValue(30, "Đang khởi tạo hệ thống...");
            SysOption.LoadBatch();
            SysOption.LoadLimit();
            SysOption.LoadNegative();

            DbInfo.CheckVersion();

            SysLog.Insert("Hệ Thống", "Đăng Nhập");
            Options.FormProcess.SetProgressValue(35, "Đang lấy thông tin hệ thống...");
            MyInfo.GetInfo();

            CODE.CompanyName = MyInfo.Company;
            CODE.Address = MyInfo.Address;

            var code = new CODE();
            Options.FormProcess.SetProgressValue(40, "Đang nạp thông tin hệ thống...");
            code.CheckLicense();
            Options.FormProcess.SetProgressValue(45, "Đang kiểm tra sự hợp lệ..");

            code.Execute();

            var sql = new SqlHelper(SqlHelper.ConnectString);
            sql.Extract();
            Options.FormProcess.SetProgressValue(50, "Đang khởi tạo hệ thống...");

            
            Options.FormProcess.SetProgressValue(65, "Đang thiết lập hệ thống...");
            lblAccounts.Caption = MyLogin.Account + @"  ";

            lblServers.Caption = sql.Server + @"  ";
            lblDatabases.Caption = sql.Database + @"(" + DbInfo.CurrentVersion + @")";

            lblDay.Caption = MyLogin.LoginDate.ToString("dd/MM/yyyy");
            lblVersion.Caption = @"Phiên Bản:" + MyAssembly.AssemblyVersion; // + @" " + MyApplication.SotfType;

            Options.FormProcess.SetProgressValue(70, "Đang kiểm tra dữ liệu...");

            string license = "OK";

            //if (CODE.TypeSoft == 1)
            //{
            //    int pos = sql.Server.IndexOf("\\");
            //    string server = pos != -1 ? sql.Server.Substring(0, pos) : sql.Server;

            //    server = server.ToLower();

            //    if (server != "." & server != "(local)" & server != "(localhost)" &
            //        server != Environment.MachineName.ToLower())
            //    {
            //        Options.Close();
            //        XtraMessageBox.Show(
            //            "Phần mềm đang truy cập cở sở dữ liệu trên máy chủ khác.\nTính năng được hỗ trợ cho phiên bản này (Hoặc vui lòng mua phiên bản thu phí để được hỗ trợ).",
            //            "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        //var xfmDatabaseConfig = new xfmDatabaseConfig();
            //        //xfmDatabaseConfig.Logined += xfmDatabaseConfig_Logined;
            //        //xfmDatabaseConfig.ShowDialog(this);

            //        //XtraMessageBox.Show("Cấu hình mới chưa được thiết lập, Phần mềm sẽ kết thúc tại đây.", "Thông Báo",
            //        //                    MessageBoxButtons.OK,
            //        //                    MessageBoxIcon.Warning);
            //        //Application.Exit();

            //        license = "NOT OK";
            //    }
            //}
            rbcMain.ApplicationCaption = SysOption.Language == "VN"
                                             ? "Phần Mềm Quản Lý Bán Hàng"
                                             : "Perfect Sales Management";


            Pages();

            //bbiInventoryDetailOverLimit.Visibility = BarItemVisibility.Never;

            lblInfo.Caption = "";
            //if (CODE.TypeSoft < 2)
            //{
            //    //lblInfo.Caption = CODE.Message;
            //}
            //if (CODE.TypeSoft == 1)
            //{
            //    // rbpgStockOther.Visible = false;
            //    //bbiTransfer.Visibility = BarItemVisibility.Never;
            //}


            /////////////////////////////////
            ///  HỆ THỐNG
            /// 
          
            //////////////

            if (!MyRule.IsAccess("bbiPermission"))
            {
                bbiPermission.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiChangepassword"))
            {
                bbiChangepassword.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiSysLog"))
            {
                bbiSysLog.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiPermission") && !MyRule.IsAccess("bbiChangepassword") &&
                !MyRule.IsAccess("bbiSysLog"))
            {
                rbpgSecurity.Visible = false;
            }

            if (!MyRule.IsAccess("bbiBackup"))
            {
                bbiBackup.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiRestore"))
            {
                bbiRestore.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiFix"))
            {
                bbiFix.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiLock"))
            {
                bbiLocks.Visibility = BarItemVisibility.Never;
            }

            if (!MyRule.IsAccess("bbiBackup") && !MyRule.IsAccess("bbiRestore") && !MyRule.IsAccess("bbiFix") &&
                !MyRule.IsAccess("bbiLock"))
            {
                rbpgDatabase.Visible = false;
            }
            //////////////////////////////////////
            /// DANH MỤC
            ///
            if (!MyRule.IsAccess("bbiCustomerGroup"))
            {
                bbiCustomerGroup.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiCustomer"))
            {
                bbiCustomer.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiProvider"))
            {
                bbiProvider.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiCustomerGroup") && !MyRule.IsAccess("bbiCustomer") &&
                !MyRule.IsAccess("bbiProvider"))
            {
                rbpgPartner.Visible = false;
            }
            /////////////// 

            if (!MyRule.IsAccess("bbiStock"))
            {
                bbiStock.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiUnit"))
            {
                bbiUnit.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiItemGroup"))
            {
                bbiItemGroup.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiMaterial"))
            {
                bbiMaterial.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiPrintBarcode"))
            {
                bbiPrintBarcode.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiExchangeRate"))
            {
                bbiExchangeRate.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiStock") && !MyRule.IsAccess("bbiUnit") && !MyRule.IsAccess("bbiItemGroup") &&
                !MyRule.IsAccess("bbiMaterial") && !MyRule.IsAccess("bbiPrintBarcode") &&
                !MyRule.IsAccess("bbiExchangeRate"))
            {
                rbpgDicStock.Visible = false;
            }
            ///////////////////////////////////

            if (!MyRule.IsAccess("bbiDepartment"))
            {
                bbiDepartment.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiEmployee"))
            {
                bbiEmployee.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiDepartment") && !MyRule.IsAccess("bbiEmployee"))
            {
                rpgDeparment.Visible = false;
            }
            /////////////////////////////////////
            ////// CHỨC NĂNG////////////////////

            if (!MyRule.IsAccess("bbiPurchase"))
            {
                bbiPurchase.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiSale"))
            {
                bbiSale.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiPurchase") && !MyRule.IsAccess("bbiSale"))
            {
                rbpgSale.Visible = false;
            }

            ///////////////////////////////////////
            if (!MyRule.IsAccess("bbiReciept"))
            {
                bbiReciept.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiPayment"))
            {
                bbiPayment.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiReciept") && !MyRule.IsAccess("bbiPayment"))
            {
                rpgDebt.Visible = false;
            }

            /////////////////////////////////////////
            /// 
           
            if (!MyRule.IsAccess("bbiVoucherManager"))
            {
                bbiVoucherManager.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiInvoice") && !MyRule.IsAccess("bbiVoucherManager"))
            {
                rpgInvoice.Visible = false;
            }

            /////////////////
            /// 
            /// 
            if (!MyRule.IsAccess("bbiTransfer"))
                bbiTransfer.Visibility = BarItemVisibility.Never;

            if (!MyRule.IsAccess("bbiReport"))
            {
                bbiReport.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiReportSale"))
            {
                bbiReportSale.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiExpire"))
            {
                bbiExpire.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiReportSale") && !MyRule.IsAccess("bbiExpire") && !MyRule.IsAccess("bbiReport"))
            {
                rpgReport.Visible = false;
            }
            /////////////////////////////////////

            if (!MyRule.IsAccess("bbiInitInventory"))
            {
                bbiInitInventory.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiHistory"))
            {
                bbiHistory.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiInventorySummary"))
            {
                bbiInventorySummary.Visibility = BarItemVisibility.Never;
            }
            if (!MyRule.IsAccess("bbiInitInventory") && !MyRule.IsAccess("bbiHistory") &&
                !MyRule.IsAccess("bbiInventorySummary"))
            {
                rpgTool.Visible = false;
            }
            bbiChangepassword.Visibility = BarItemVisibility.Always;
            //SetFormFullscreen();
            if (CODE.TypeSoft < 300)
            {
                if (license != "OK")
                {
                    DisableAllFunctionWhenNotLicense();
                }
            }

            Options.FormProcess.SetProgressValue(80, "Đang kiểm tra dữ liệu...");
            Options.FormProcess.SetProgressValue(90, "Đang kiểm tra dữ liệu...");
            Options.FormProcess.SetProgressValue(100, "Hoàn tất");
            Options.FormProcess.Visible = false;
            timer.Enabled = true;

            if (CODE.TypeSoft <= 1)
            {
                URLSoftware();
            }

            
        }

        private void xfmDatabaseConfig_Logined(object sender, string connectString)
        {
            XtraMessageBox.Show("Phần mềm sẽ khởi động lại, để nạp cấu hình mới.", "Thông Báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            Application.Restart();
        }


        private void Unload()
        {
            if (_xfmInward != null) _xfmInward.Close();
            if (_xfmOutward != null) _xfmOutward.Close();
            if (_xfmTransfer != null) _xfmTransfer.Close();
            if (xfmInventoryDetail != null) xfmInventoryDetail.Close();
            if (xfmInventorySummary != null) xfmInventorySummary.Close();
            if (_xfmPacket != null) _xfmPacket.Close();
            if (xfmProducts != null) xfmProducts.Close();
            if (xfmInventoryInit != null) xfmInventoryInit.Close();
            if (xfmUsers != null) xfmUsers.Close();
            if (xfmGroups != null) xfmGroups.Close();
            if (xfmCustomers != null) xfmCustomers.Close();
            if (xfmProviders != null) xfmProviders.Close();
            if (xfmStocks != null) xfmStocks.Close();
            if (xfmProductGroups != null) xfmProductGroups.Close();
            if (xfmEmployees != null) xfmEmployees.Close();
            if (_xfmHistory != null) _xfmHistory.Close();
            if (_xfmSearch != null) _xfmSearch.Close();
            if (xfmSysLog != null) xfmSysLog.Close();
            if (_xfmUnits != null) _xfmUnits.Close();
            if (_xfmDepartments != null) _xfmDepartments.Close();
            if (_xfmManagers != null) _xfmManagers.Close();
            if (_xfmInventoryOrders != null) _xfmInventoryOrders.Close();
            if (_xfmInventoryDetailSummary != null) _xfmInventoryDetailSummary.Close();
            if (xfmSale2 != null) xfmSale2.Close();

            if (_xfmPayment != null) _xfmPayment.Close();
            if (_xfmReiceipt != null) _xfmReiceipt.Close();
            if (_xfmReportExpire != null) _xfmReportExpire.Close();
            if (_xfmSaleAmountReport != null) _xfmSaleAmountReport.Close();
            if (_xfmReports != null) _xfmReports.Close();
            if (_saleInit != null) _saleInit.Close();


            if (tabMdi.Pages.Count > 0)
            {
                tabMdi.Pages.Clear();
            }
            SysLog.Insert("Hệ Thống", "Kết Thúc");
        }

        private void FrmMainFormClosing(object sender, FormClosingEventArgs e)
        {
            Unload();
            Application.Exit();
        }

        private void FrmMainLoad(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Layout\\Theme.xml"))
            {
                Skin.LookAndFeel.SetSkinStyle(LoadTheme());
            }
            foreach (DevExpress.Skins.SkinContainer skin in DevExpress.Skins.SkinManager.Default.Skins)
            {
                BarCheckItem item = rbcMain.Items.CreateCheckItem(skin.SkinName, false);
                item.Tag = skin.SkinName;
                item.ItemClick += OnPaintStyleClick;
                bbSkin.ItemLinks.Add(item);
            }
        }

        private void OnPaintStyleClick(object sender, ItemClickEventArgs e)
        {
            Skin.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString());
            SaveTheme(e.Item.Tag.ToString());
        }

        private static string LoadTheme()
        {
            var document = new XmlDocument();
            document.Load(Application.StartupPath + "\\Layout\\Theme.xml");
            var xmlElement = document.DocumentElement;
            var node = xmlElement.SelectSingleNode("Theme");
            return xmlElement.InnerText;
        }

        private static void SaveTheme(string themeName)
        {
            var textWriter = new XmlTextWriter(Application.StartupPath + "\\Layout\\Theme.xml", null);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Theme", "");
            textWriter.WriteString(themeName);
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        private void FrmOutwardListExpand(object sender)
        {
            Execute("xfmOutwardList", "");
        }


        private void RbcMainLayout(object sender, LayoutEventArgs e)
        {
            // rbsMain.Ribbon.Manager.SaveToXml(Application.StartupPath + "\\Layout\\Ribbon.xml");
        }

        private void TimerTick(object sender, EventArgs e)
        {
            lblTime.Caption = DateTime.Now.ToString("hh:mm:ss");
        }


        private void XfmCustomersFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmCustomers = null;
        }

        private void XfmDepartmentsFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmDepartments = null;
        }

        private void XfmEmployeesFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmEmployees = null;
        }


        private void XfmGroupsFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmGroups = null;
        }


        private void XfmHistoryFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmHistory = null;
        }

        private void XfmInventoryDetailFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmInventoryDetail = null;
        }

        private void XfmInventoryInitFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmInventoryInit = null;
        }

        private void XfmInventorySummaryFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmInventorySummary = null;
        }


        private void XfmOutwardFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmOutward = null;
        }


        private void XfmProductGroupsFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmProductGroups = null;
        }

        private void XfmProductsFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmProducts = null;
        }

        private void XfmProvidersFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmProviders = null;
        }


        private void XfmSaleFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmPacket = null;
        }


        private void XfmSearchFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmSearch = null;
        }

        private void XfmSearchView(string id, string status)
        {
            if (status == "1")
            {
                Execute("xfmInward", "");
            }
            else if (status == "2")
            {
                Execute("xfmOutward", "");
            }
            else
            {
                Execute("xfmTransfer", "");
            }
        }

        private void XfmStocksFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmStocks = null;
        }


        private void XfmSysLogFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmSysLog = null;
        }

        private void XfmTransferFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmTransfer = null;
        }


        private void XfmUnitsFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmUnits = null;
        }

        private void XfmUsersFormClosing(object sender, FormClosingEventArgs e)
        {
            xfmUsers = null;
        }

        #endregion

        #region User MyLibtion

        private void Catelogy(RibbonPageGroupCollection pageId, string pageID)
        {
            var dtPage = new dsPermision.SYS_USER_RULEDataTable();
            var adapter = new SYS_USER_RULETableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dtPage, MyLogin.RoleId, pageID, 1, SysOption.Language);

            for (int i = 0; i < dtPage.Rows.Count; i++)
            {
                for (int j = 0; j < pageId.Count; j++)
                {
                    if (pageId[j].Name == dtPage.Rows[i]["Object_ID"].ToString())
                    {
                        bool active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
                        // pageId[j].Text = dtPage.Rows[i]["Caption"].ToString();
                        pageId[j].Visible = active;
                        if (active)
                        {
                            Items(pageId[j].ItemLinks, pageId[j].Name);
                        }
                    }
                }
            }
            rbpgClose.Visible = true;
        }

        private XfmInward _xfmReportExpire;
        private xfmCurrencys _xfmCurrencys;
        private XfmSaleInit _saleInit;
        private XfmInventoryInit _xfmInventoryInit;
        private xfmInventoryRevenue _xfmInventoryRevenue;
        private XfmPrintBarcode _xfmPrintBarcode;
       
        private XfmPayment _payment;
        private XfmReiceipt _reiceipt;
        private XfmSaleAmountReport _saleAmountReport;
        private xfmGroup_User _xfmGroupUser;
        private XfmReports _xfmReports;
        private xfmUserAdd _xfmUserAdd;
        private XfmOutward _outward;
        private xfmNotes _xfmNotes;
        private xfmProductBrand _xfmProductBrand;
        private xfmCar _xfmCar;
        private xfmIndustry _xfmIndustry;
        private xfmSalesOrder _xfmSalesOrder;

        private void Execute(string id, string @ref)
        {
            switch (id)
            {
                case "_xfmIndustry":
                    if (_xfmIndustry == null)
                    {
                        _xfmIndustry = new xfmIndustry { MdiParent = this };
                        _xfmIndustry.FormClosing += new FormClosingEventHandler(_xfmIndustry_FormClosing);
                        _xfmIndustry.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmIndustry].MdiChild.Activate();
                    }

                    break;
                case "_saleInit":
                    SysLog.Insert("Số Dư Đầu Kỳ", "Tạo");
                    if (_saleInit == null)
                    {
                        _saleInit = new XfmSaleInit {MdiParent = this};
                        _saleInit.FormClosing += _xfmInventoryInit_FormClosing;
                        _saleInit.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_saleInit].MdiChild.Activate();
                    }

                    break;
                case "_outward":
                    SysLog.Insert("Bán Hàng", "Tạo");
                    if (_outward == null)
                    {
                        _outward = new XfmOutward {MdiParent = this};
                        _outward.FormClosing += OutwardFormClosing;
                        _outward.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_outward].MdiChild.Activate();
                    }

                    break;
                case "_xfmSalesOrder":
                    if (_xfmSalesOrder == null)
                    {
                        _xfmSalesOrder = new xfmSalesOrder { MdiParent = this };
                        _xfmSalesOrder.FormClosing += new FormClosingEventHandler(_xfmSalesOrder_FormClosing);
                        _xfmSalesOrder.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmSalesOrder].MdiChild.Activate();
                    }

                    break;
                case "_xfmUserAdd":
                    SysLog.Insert("Thêm tài khoản", "Tạo");
                    if (_xfmUserAdd == null)
                    {
                        _xfmUserAdd = new xfmUserAdd {MdiParent = this};
                        _xfmUserAdd.FormClosing += XfmUserAddFormClosing;
                        _xfmUserAdd.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmUserAdd].MdiChild.Activate();
                    }

                    break;

                case "_xfmReports":
                    SysLog.Insert("Báo Cáo Kho", "Xem");
                    if (_xfmReports == null)
                    {
                        _xfmReports = new XfmReports {MdiParent = this};
                        _xfmReports.FormClosing += XfmReportsFormClosing;
                        _xfmReports.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmReports].MdiChild.Activate();
                    }

                    break;
                case "_xfmGroupUser": 
                    if (_xfmGroupUser == null)
                    {
                        _xfmGroupUser = new xfmGroup_User {MdiParent = this};
                        _xfmGroupUser.FormClosing += XfmGroupUserFormClosing;
                        _xfmGroupUser.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmGroupUser].MdiChild.Activate();
                    }

                    break;
                case "xfmNotes": 
                    if (_xfmNotes == null)
                    {
                        _xfmNotes = new xfmNotes { MdiParent = this };
                        _xfmNotes.FormClosing += new FormClosingEventHandler(_xfmNotes_FormClosing);
                        _xfmNotes.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmNotes].MdiChild.Activate();
                    }

                    break;
                case "_saleAmountReport": 
                    if (_saleAmountReport == null)
                    {
                        _saleAmountReport = new XfmSaleAmountReport {MdiParent = this};
                        _saleAmountReport.FormClosing += SaleAmountReportFormClosing;
                        _saleAmountReport.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_saleAmountReport].MdiChild.Activate();
                    }

                    break;

                

                case "_xfmReportExpire":
                    if (_xfmReportExpire == null)
                    {
                        _xfmReportExpire = new XfmInward {MdiParent = this};
                        _xfmReportExpire.FormClosing += XfmReportExpireFormClosing;
                        _xfmReportExpire.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmReportExpire].MdiChild.Activate();
                    }

                    break;
                case "_reiceipt":
                    if (_reiceipt == null)
                    {
                        _reiceipt = new XfmReiceipt {MdiParent = this};
                        _reiceipt.FormClosing += ReiceiptFormClosing;
                        _reiceipt.Show();
                    }
                    else
                    {
                        _reiceipt.Activate();
                    }

                    break;

                case "_payment":
                    if (_payment == null)
                    {
                        _payment = new XfmPayment {MdiParent = this};
                        _payment.FormClosing += PaymentFormClosing;
                        _payment.Show();
                    }
                    else
                    {
                        _payment.Activate();
                    }
                    break;
               
               
                case "SaleInit":
                    if (_saleInit == null)
                    {
                        _saleInit = new XfmSaleInit {MdiParent = this};
                        _saleInit.FormClosing += SaleInitFormClosing;
                        _saleInit.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_saleInit].MdiChild.Activate();
                    }

                    break;

                case "xfmUsers":
                    if (xfmUsers == null)
                    {
                        xfmUsers = new xfmUsers {MdiParent = this};
                        xfmUsers.FormClosing += XfmUsersFormClosing;
                        xfmUsers.Show();
                    }
                    else
                    {
                        tabMdi.Pages[xfmUsers].MdiChild.Activate();
                    }
                    xfmUsers.IsSearch = false;
                    break;

                case "xfmGroups":
                    SysLog.Insert("Quản Lý Vai Trò", "Xem");
                    if (xfmGroups == null)
                    {
                        xfmGroups = new xfmGroups {MdiParent = this};
                        xfmGroups.FormClosing += XfmGroupsFormClosing;
                        xfmGroups.Show();
                    }
                    else
                    {
                        tabMdi.Pages[xfmGroups].MdiChild.Activate();
                    }
                    xfmGroups.IsSearch = false;
                    break;

                case "xfmSysLog":
                    SysLog.Insert("Nhật Ký Hệ Thống", "Xem");
                    if (xfmSysLog == null)
                    {
                        xfmSysLog = new xfmSysLog {MdiParent = this};
                        xfmSysLog.FormClosing += XfmSysLogFormClosing;
                        xfmSysLog.Show();
                    }
                    else
                    {
                        tabMdi.Pages[xfmSysLog].MdiChild.Activate();
                    }
                    break;
                case "xfmInventoryInit":

                    if (xfmInventoryInit == null)
                    {
                        xfmInventoryInit = new XfmInventoryInit {MdiParent = this};
                        xfmInventoryInit.FormClosing += XfmInventoryInitFormClosing;
                        xfmInventoryInit.Show();
                    }
                    else
                    {
                        xfmInventoryInit.Activate();
                    }
                    break;

                case "xfmCustomers":
                    if (xfmCustomers == null)
                    {
                        xfmCustomers = new XfmCustomers {MdiParent = this};
                        xfmCustomers.FormClosing += XfmCustomersFormClosing;
                        xfmCustomers.Show();
                    }
                    else
                    {
                        xfmCustomers.Activate();
                    }
                    xfmCustomers.IsSearch = false;
                    break;

                case "xfmProviders":
                    if (xfmProviders == null)
                    {
                        xfmProviders = new xfmProviders {MdiParent = this};
                        xfmProviders.Text = "Nhà Cung Cấp";
                        xfmProviders.FormClosing += XfmProvidersFormClosing;
                        xfmProviders.Show();
                    }
                    else
                    {
                        xfmProviders.Activate();
                    }
                    xfmProviders.IsSearch = false;
                    break;

                case "xfmStocks":
                    if (xfmStocks == null)
                    {
                        xfmStocks = new XfmStocks {MdiParent = this};
                        xfmStocks.FormClosing += XfmStocksFormClosing;
                        xfmStocks.Show();
                    }
                    else
                    {
                        tabMdi.Pages[xfmStocks].MdiChild.Activate();
                    }
                    xfmStocks.IsSearch = false;
                    break;

                case "xfmProductGroups":
                    if (xfmProductGroups == null)
                    {
                        xfmProductGroups = new xfmProductGroups {MdiParent = this};
                        xfmProductGroups.FormClosing += XfmProductGroupsFormClosing;
                        xfmProductGroups.Show();
                    }
                    else
                    {
                        tabMdi.Pages[xfmProductGroups].MdiChild.Activate();
                    }
                    xfmProductGroups.IsSearch = false;
                    break;

                case "xfmUnits":
                    if (_xfmUnits == null)
                    {
                        _xfmUnits = new xfmUnits {MdiParent = this};
                        _xfmUnits.FormClosing += XfmUnitsFormClosing;
                        _xfmUnits.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmUnits].MdiChild.Activate();
                    }
                    break;

                case "xfmProducts":
                    if (xfmProducts == null)
                    {
                        xfmProducts = new xfmProducts {MdiParent = this};
                        xfmProducts.FormClosing += XfmProductsFormClosing;
                        xfmProducts.Show();
                    }
                    else
                    {
                        tabMdi.Pages[xfmProducts].MdiChild.Activate();
                    }

                    xfmProducts.IsSeach = false;

                    break;

                case "xfmDepartments":
                    if (_xfmDepartments == null)
                    {
                        _xfmDepartments = new XfmDepartments();
                        _xfmDepartments.FormClosing += XfmDepartmentsFormClosing;
                        _xfmDepartments.MdiParent = this;
                        _xfmDepartments.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmDepartments].MdiChild.Activate();
                    }
                    _xfmDepartments.IsSearch = false;

                    break;
                case "xfmEmployees":
                    if (xfmEmployees == null)
                    {
                        xfmEmployees = new xfmEmployees {MdiParent = this};
                        xfmEmployees.FormClosing += XfmEmployeesFormClosing;
                        xfmEmployees.Show();
                    }
                    else
                    {
                        tabMdi.Pages[xfmEmployees].MdiChild.Activate();
                    }
                    xfmEmployees.IsSearch = false;
                    break;

                case "xfmHistory":
                    if (_xfmHistory == null)
                    {
                        _xfmHistory = new xfmHistory {MdiParent = this};
                        _xfmHistory.FormClosing += XfmHistoryFormClosing;
                        _xfmHistory.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmHistory].MdiChild.Activate();
                    }
                    break;
                case "xfmSearch":
                    if (_xfmSearch == null)
                    {
                        _xfmSearch = new xfmSearch {MdiParent = this};
                        _xfmSearch.View += XfmSearchView;
                        _xfmSearch.FormClosing += XfmSearchFormClosing;
                        _xfmSearch.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmSearch].MdiChild.Activate();
                    }
                    break;

                case "xfmOutward":
                    if (_xfmOutward == null)
                    {
                        _xfmOutward = new XfmOutward {MdiParent = this};
                        _xfmOutward.Expanded += FrmOutwardListExpand;

                        _xfmOutward.FormClosing += XfmOutwardFormClosing;
                        _xfmOutward.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmOutward].MdiChild.Activate();
                    }

                    if (@ref != "")
                    {
                        _xfmOutward.SetData(@ref);
                    }
                    break;

                case "xfmTransfer":
                    if (_xfmTransfer == null)
                    {
                        _xfmTransfer = new XfmTransfer {MdiParent = this};
                        _xfmTransfer.FormClosing += XfmTransferFormClosing;
                        _xfmTransfer.Expanded += XfmTransferExpanded;
                        _xfmTransfer.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmTransfer].MdiChild.Activate();
                    }
                    if (@ref != "")
                    {
                        _xfmTransfer.SetData(@ref);
                    }
                    break;

                case "_xfmPacket":
                    if (_xfmPacket == null)
                    {
                        _xfmPacket = new xfmPacket {MdiParent = this};
                        _xfmPacket.FormClosing += XfmSaleFormClosing;
                        _xfmPacket.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmPacket].MdiChild.Activate();
                    }
                    break;


                case "xfmInventoryDetail":
                    if (xfmInventoryDetail == null)
                    {
                        xfmInventoryDetail = new xfmInventoryDetail {MdiParent = this};
                        xfmInventoryDetail.FormClosing += XfmInventoryDetailFormClosing;
                        xfmInventoryDetail.Show();
                    }
                    else
                    {
                        xfmInventoryDetail.Activate();
                    }
                    break;


                case "xfmInventorySummary":
                    if (xfmInventorySummary == null)
                    {
                        xfmInventorySummary = new xfmInventorySummary {MdiParent = this};
                        xfmInventorySummary.FormClosing += XfmInventorySummaryFormClosing;
                        xfmInventorySummary.Show();
                    }
                    else
                    {
                        xfmInventorySummary.Activate();
                    }
                    break;

                case "xfmInventoryOrders":

                    if (_xfmInventoryOrders == null)
                    {
                        _xfmInventoryOrders = new xfmInventoryOrders {MdiParent = this};
                        _xfmInventoryOrders.FormClosing += XfmInventoryOrdersFormClosing;
                        _xfmInventoryOrders.Show();
                    }
                    else
                    {
                        _xfmInventoryOrders.Activate();
                    }
                    break;

                case "xfmManagers":

                    if (_xfmManagers == null)
                    {
                        _xfmManagers = new xfmManagers {MdiParent = this};
                        _xfmManagers.FormClosing += XfmManagersFormClosing;
                        _xfmManagers.Show();
                    }
                    else
                    {
                        _xfmManagers.Activate();
                    }
                    break;

                case "xfmInventoryDetailSummary":

                    if (_xfmInventoryDetailSummary == null)
                    {
                        _xfmInventoryDetailSummary = new xfmInventoryDetailSummary {MdiParent = this};
                        _xfmInventoryDetailSummary.FormClosing += XfmInventoryDetailSummaryFormClosing;
                        _xfmInventoryDetailSummary.Show();
                    }
                    else
                    {
                        _xfmInventoryDetailSummary.Activate();
                    }
                    break;

                case "XfmPrintBarcode":

                    if (_xfmPrintBarcode == null)
                    {
                        _xfmPrintBarcode = new XfmPrintBarcode {MdiParent = this};
                        _xfmPrintBarcode.FormClosing += XfmPrintBarcodeFormClosing;
                        _xfmPrintBarcode.Show();
                    }
                    else
                    {
                        _xfmPrintBarcode.Activate();
                    }
                    break;

                case "_inventoryAdjustment":

                    if (_inventoryAdjustment == null)
                    {
                        _inventoryAdjustment = new XfmInventoryAdjustment();
                        _inventoryAdjustment.FormClosing += InventoryAdjustmentFormClosing;
                        _inventoryAdjustment.MdiParent = this;
                        _inventoryAdjustment.Show();
                    }
                    else
                    {
                        _inventoryAdjustment.Activate();
                    }
                    break;


                case "_xfmInventoryRevenue":

                    if (_xfmInventoryRevenue == null)
                    {
                        _xfmInventoryRevenue = new xfmInventoryRevenue();
                        _xfmInventoryRevenue.FormClosing += XfmInventoryRevenueFormClosing;
                        _xfmInventoryRevenue.MdiParent = this;
                        _xfmInventoryRevenue.Show();
                    }
                    else
                    {
                        _xfmInventoryRevenue.Activate();
                    }
                    break;

                case "_xfmCustomerGroups":

                    if (_xfmCustomerGroups == null)
                    {
                        _xfmCustomerGroups = new XfmCustomerGroups();
                        _xfmCustomerGroups.FormClosing += XfmCustomerGroupsFormClosing;
                        _xfmCustomerGroups.MdiParent = this;
                        _xfmCustomerGroups.Show();
                    }
                    else
                    {
                        _xfmCustomerGroups.Activate();
                    }
                    break;
                case "_xfmDelieveryRoute":

                    if (_xfmDelieveryRoute == null)
                    {
                        _xfmDelieveryRoute = new XfmDelieveryRoute();
                        _xfmDelieveryRoute.FormClosing += new FormClosingEventHandler(_xfmDelieveryRoute_FormClosing);
                        _xfmDelieveryRoute.MdiParent = this;
                        _xfmDelieveryRoute.Show();
                    }
                    else
                    {
                        _xfmDelieveryRoute.Activate();
                    }
                    break;

                case "_xfmProductBrand":
                    if (_xfmProductBrand == null)
                    {
                        _xfmProductBrand = new xfmProductBrand { MdiParent = this };
                        _xfmProductBrand.FormClosing += new FormClosingEventHandler(_xfmProductBrand_FormClosing);
                        _xfmProductBrand.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmProductBrand].MdiChild.Activate();
                    }
                    break;

                case "_xfmCar":
                    if (_xfmCar == null)
                    {
                        _xfmCar = new xfmCar { MdiParent = this };
                        _xfmCar.FormClosing += new FormClosingEventHandler(_xfmCar_FormClosing);
                        _xfmCar.Show();
                    }
                    else
                    {
                        tabMdi.Pages[_xfmCar].MdiChild.Activate();
                    }
                    break;

            }
        }

        void _xfmSalesOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmSalesOrder = null;
        }

        void _xfmIndustry_FormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmIndustry = null;
        }

        void _xfmCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmCar = null;
        }

        void _xfmProductBrand_FormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmProductBrand = null;
        }

        void _xfmNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmNotes = null;
        }

        void _xfmDelieveryRoute_FormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmDelieveryRoute = null;
        }

        private void _xfmInventoryInit_FormClosing(object sender, FormClosingEventArgs e)
        {
            _saleInit = null;
        }

        private void OutwardFormClosing(object sender, FormClosingEventArgs e)
        {
            _outward = null;
        }

        private void XfmUserAddFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmUserAdd = null;
        }

        private void XfmReportsFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmReports = null;
        }

        private void XfmGroupUserFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmGroupUser = null;
        }


        private void XfmCurrencyFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmCurrencys = null;
        }

        private void SaleAmountReportFormClosing(object sender, FormClosingEventArgs e)
        {
            _saleAmountReport = null;
        }

        private void XfmReportExpireFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmReportExpire = null;
        }


        private void ReiceiptFormClosing(object sender, FormClosingEventArgs e)
        {
            _reiceipt = null;
        }

        private void PaymentFormClosing(object sender, FormClosingEventArgs e)
        {
            _payment = null;
        }

        private void SaleInitFormClosing(object sender, FormClosingEventArgs e)
        {
            _saleInit.Dispose();
            _saleInit = null;
        }


        private void XfmCustomerGroupsFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmCustomerGroups = null;
        }

        private void XfmInventoryRevenueFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmInventoryRevenue = null;
        }

        private void InventoryAdjustmentFormClosing(object sender, FormClosingEventArgs e)
        {
            _inventoryAdjustment = null;
        }

        private void XfmPrintBarcodeFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmPrintBarcode = null;
        }

        private void XfmTransferExpanded(object sender)
        {
            Execute("xfmTransferList", "");
        }

        private void XfmInventoryDetailSummaryFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmInventoryDetailSummary = null;
        }

        private void XfmManagersFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmManagers = null;
        }


        private void Items(RibbonPageGroupItemLinkCollection item, string group)
        {
            var dtPage = new dsPermision.SYS_USER_RULEDataTable();
            var adapter = new SYS_USER_RULETableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dtPage, MyLogin.RoleId, group, 2, SysOption.Language);

            for (int i = 0; i < dtPage.Rows.Count; i++)
            {
                for (int j = 0; j < item.Count; j++)
                {
                    if (item[j].Item.Name == dtPage.Rows[i]["Object_ID"].ToString())
                    {
                        bool active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
                        item[j].Visible = active;
                    }
                }
            }

            bbiExit.Visibility = BarItemVisibility.Always;
        }

        private void Pages()
        {
            var dtPage = new dsPermision.SYS_USER_RULEDataTable();
            var adapter = new SYS_USER_RULETableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };

            adapter.Fill(dtPage, MyLogin.RoleId, "", 0, SysOption.Language);

            for (int i = 0; i < dtPage.Rows.Count; i++)
            {
                for (int j = 0; j < rbcMain.Pages.Count; j++)
                {
                    if (rbcMain.Pages[j].Name == dtPage.Rows[i]["Object_ID"].ToString())
                    {
                        bool active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
                        rbcMain.Pages[j].Visible = active;
                        if (active)
                        {
                            Catelogy(rbcMain.Pages[j].Groups, rbcMain.Pages[j].Name);
                        }
                    }
                }
            }
            rbpSystem.Visible = true;
        }

        #endregion

        #region Delegate

        public delegate void ProcessParametersDelegate(object sender, string[] args);

        #endregion

        private void XfmInventoryOrdersFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmInventoryOrders = null;
        }

        private void BbiManagerItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiVoucherManager.Enabled = false;
            Execute("xfmManagers", "");
            bbiVoucherManager.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void LblAccountItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiVoucherManager.Enabled = false;
            Execute("xfmUsers", "");
            bbiVoucherManager.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void LblServerItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblServer.Enabled = false;
            if (File.Exists(Application.StartupPath + "\\Perfect.Data.exe"))
            {
                Process.Start(Application.StartupPath + "\\Perfect.Data.exe");
            }
            lblServer.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void LblDatabaseItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new xfmDatabaseConfig();
            frm.ShowDialog(this);
        }

        private void BbiPrintBarcodeItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiPrintBarcode.Enabled = false;
            Execute("XfmPrintBarcode", "");
            bbiPrintBarcode.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiInventoryOrderItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiInventoryOrder.Enabled = false;
            Execute("xfmInventoryOrders", "");
            bbiInventoryOrder.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiLockItemClick(object sender, ItemClickEventArgs e)
        {
            //var xfmLocks = new xfmLocks();
            //xfmLocks.ShowDialog(this);
            xfmCarryForward frm = new xfmCarryForward();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void BbiPurchaseItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiExpire.Enabled = false;
            Execute("_xfmReportExpire", "");
            bbiExpire.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiSaleItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiSale.Enabled = false;
            Execute("_outward", "");
            bbiSale.Enabled = true;
            Cursor.Current = Cursors.Default;
        }


        private void BbiCustomerReceiptItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiReciept.Enabled = false;
            Execute("_reiceipt", "");
            bbiReciept.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiCustomerPaymentItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiPayment.Enabled = false;
            Execute("_payment", "");
            bbiPayment.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiSaleInitItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiInitInventory.Enabled = false;
            Execute("_saleInit", "");
            bbiInitInventory.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiReportItemClick(object sender, ItemClickEventArgs e)
        {
        }

        

        private void BarButtonItem1ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiPermission.Enabled = false;
            Execute("xfmTracking", "");
            bbiPermission.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BarButtonItem4ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiPermission.Enabled = false;
            Execute("_xfmGroupUser", "");
            bbiPermission.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiCustomerItemClick1(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiCustomer.Enabled = false;
            Execute("xfmCustomers", "");
            bbiCustomer.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BarButtonItem2ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiPurchaseReturn.Enabled = false;
            Execute("_xfmPurchaseReturn", "");
            bbiPurchaseReturn.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiExpireItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiExpire.Enabled = false;
            Execute("_xfmReportExpire", "");
            bbiExpire.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

       

        private void BbiRateItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiExchangeRate.Enabled = false;
            Execute("xfmNotes", "");
            //Execute("xfmCurrencys", "");
            bbiExchangeRate.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiPurchaseReportItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiReport.Enabled = false;
            Execute("_xfmReports", "");
            bbiReport.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiSaleAmountReportItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiReportSale.Enabled = false;
            Execute("_saleAmountReport", "");
            bbiReportSale.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void BbiDataItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiData.Enabled = false;
            if (File.Exists(Application.StartupPath + "\\Perfect.Data.exe"))
            {
                Process.Start(Application.StartupPath + "\\Perfect.Data.exe");
            }
            bbiData.Enabled = true;
            Cursor.Current = Cursors.Default;
        }


        private void BbSkinPopup(object sender, EventArgs e)
        {
            foreach (BarItemLink link in bbSkin.ItemLinks)
                ((BarCheckItem) link.Item).Checked = link.Item.Caption == Skin.LookAndFeel.ActiveSkinName;
        }

        private void BbiHelpDocItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start(@"http://www.perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("" + exception);
            }
        }

        private void BbiHelpVideoItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start(@"http://www.perfect.com.vn/video-huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("" + exception);
            }
        }

        private void BbiImportDicItemClick(object sender, ItemClickEventArgs e)
        {
            var xfmImport = new Core.Inventory.Import.XfmImport();
            xfmImport.ShowDialog();
        }

        private void BarButtonItem5ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            barButtonItem5.Enabled = false;
            try
            {
                if (File.Exists(Application.StartupPath + @"\Teamviewer\TeamViewer.exe"))
                {
                    Process.Start(Application.StartupPath + @"\Teamviewer\TeamViewer.exe");
                }
                else
                {
                    XtraMessageBox.Show("Không tìm thấy file Team Viewer ", "Thông Báo");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("" + exception);
            }
            barButtonItem5.Enabled = true;
            Cursor.Current = Cursors.Default;
            
        }

        private void URLSoftware()
        {

            
            
            //{
            //    _saleInit = new XfmSaleInit { MdiParent = this };
            //    _saleInit.FormClosing += _xfmInventoryInit_FormClosing;
            //    _saleInit.Show();
            //}
            
            //{
            //    tabMdi.Pages[_saleInit].MdiChild.Activate();
            //}

            Perfect.Inventory.Core.AccessWebsite.xfmAccessWebsite _xfmAccessWebsite = new xfmAccessWebsite { MdiParent = this };
            _xfmAccessWebsite.Show();
            //var frm = new Form();
            //var browser = new WebBrowser { Dock = DockStyle.Fill };
            ////var url = Conversions.ToString(bbiBrowser.EditValue);
            //var url = Conversions.ToString("http://www.google.com.vn");
            //var ds = new DataSet();
            //ds.ReadXml("http://update.fessoft.com/browser.xml");
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    browser.Url = new Uri(dr[0].ToString());
            //}

            //var address = bbiBrowser.EditValue.ToString().IndexOf("www") == -1
            //                      ? Conversions.ToString(Operators.ConcatenateObject("www.", bbiBrowser.EditValue))
            //                      : Conversions.ToString(bbiBrowser.EditValue);

            //browser.Navigate(url);

            //frm.Controls.Add(browser);
            //frm.FormClosed += FrmFormClosed;
            //frm.Text = address;
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void bbiDeliveryStreet_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiDeliveryStreet.Enabled = false;
            Execute("_xfmDelieveryRoute", "");
            bbiDeliveryStreet.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void bbiProductBrand_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiProductBrand.Enabled = false;
            Execute("_xfmProductBrand", "");
            bbiProductBrand.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void bbiCar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiCar.Enabled = false;
            Execute("_xfmCar", "");
            bbiCar.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void bbiIndustry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bbiIndustry.Enabled = false;
            Execute("_xfmIndustry", "");
            bbiIndustry.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void bbiSalesOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //bbiSalesOrder.Enabled = false;
            //Execute("_xfmSalesOrder", "");
            //bbiSalesOrder.Enabled = true;
            //Cursor.Current = Cursors.Default;
        }

        private void rbcMain_Click(object sender, EventArgs e)
        {

        }
    }
}