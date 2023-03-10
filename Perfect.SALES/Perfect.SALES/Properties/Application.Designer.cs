//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//      QUAN LY BAN HANG
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



//INSTANT C# NOTE: Formerly VB.NET project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Perfect.Common;
using Perfect.Data;
using Perfect.Data.Core;
using Perfect.Data.Extra.Class;
using Perfect.Data.Helper;
using Perfect.Dictionary.Barcode;
using Perfect.Dictionary.Product;
using Perfect.ERP;
using Perfect.Inventory.DS;
using Perfect.Service;
using Perfect.Utils.App;
using Perfect.Utils.Lib;
using Perfect.Utils.Utils.Shell;


namespace Perfect.Inventory
{
	namespace My
	{
        
		//NOTE: This file is auto-generated; do not modify it directly.  To make changes,
		// or if you encounter build errors in this file, go to the Project Designer
		// (go to Project Properties or double-click the My Project node in
		// Solution Explorer), and make changes on the Application tab.
		//
		internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{

			[global::System.Diagnostics.DebuggerStepThroughAttribute()]
			public MyApplication() : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
			{
				this.IsSingleInstance = true;
				this.EnableVisualStyles = true;
				this.SaveMySettingsOnExit = true;
				this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
                
			}

			[global::System.Diagnostics.DebuggerStepThroughAttribute()]
			protected override void OnCreateMainForm()
			{
                this.MainForm = new global::Perfect.Inventory.FrmMain();
			}

			private static MyApplication MyApp;
			internal static MyApplication Application
			{
				get
				{
					return MyApp;
				}
			}

            public static EnumSotfType SotfType { get; set; }

			[STAThread]
			static void Main(string[] args)
			{
               // PerfectSolutions.Security.frmLogin frm = new PerfectSolutions.Security.frmLogin();               
                //frm.Show();
                
                Options.FormProcess.SetProgressValue(1,"Đang khởi động phần mềm...");
              
#if DEBUG
			    SqlHelper.HideError = false;
#else
                SqlHelper.HideError = true;
#endif


                System.Threading.Thread.CurrentThread.CurrentCulture=new CultureInfo("vi-VN");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

                
                
                Options.FormProcess.SetProgressValue(5, "Đang nạp giao diện...");
                DevExpress.UserSkins.BonusSkins.Register();
                DevExpress.UserSkins.OfficeSkins.Register();
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Blue";

                Options.FormProcess.SetProgressValue(15, "Đang thiết lập tham số chương trình...");
                string mypara = global::My.Settings.Default.Paramater;
			    MyParamaters.UiLanguage = global::My.Settings.Default.UiLanguage;
			    MyParamaters.ReportLanguage = global::My.Settings.Default.ReportLanguage;
			    MyParamaters.ReportLocalization = global::My.Settings.Default.ReportLocalization;
			    MyParamaters.Localization = global::My.Settings.Default.Localization;

                MyParamaters.IsAutoUpdate = mypara.IndexOf("NoAutoUpdate") != -1 ? false : true;
                MyParamaters.IsClearData = mypara.IndexOf("ClearData") != -1 ? true : false;
                MyParamaters.IsClearHistory = mypara.IndexOf("ClearHistory") != -1 ? true : false;
                MyParamaters.IsCreateShortcut = mypara.IndexOf("CreateShortcut") != -1 ? true : false;
                MyParamaters.IsDefault = mypara.IndexOf("Default") != -1 ? true : false;
                MyParamaters.IsResetLayout = mypara.IndexOf("ResetLayout") != -1 ? true : false;
                MyParamaters.IsSetHomePage = mypara.IndexOf("SetHomePage") != -1 ? true : false;
                MyParamaters.IsShowError = mypara.IndexOf("ShowError") != -1 ? true : false;

                if (args.Length>0)
                {
                   mypara = string.Join("/", args);
                   MyParamaters.IsAutoUpdate = mypara.IndexOf("NoAutoUpdate") != -1 ? false : true;
                   MyParamaters.IsClearData = mypara.IndexOf("ClearData") != -1 ? true : false;
                   MyParamaters.IsClearHistory = mypara.IndexOf("ClearHistory") != -1 ? true : false;
                   MyParamaters.IsCreateShortcut = mypara.IndexOf("CreateShortcut") != -1 ? true : false;
                   MyParamaters.IsDefault = mypara.IndexOf("Default") != -1 ? true : false;
                   MyParamaters.IsResetLayout = mypara.IndexOf("ResetLayout") != -1 ? true : false;
                   MyParamaters.IsSetHomePage = mypara.IndexOf("SetHomePage") != -1 ? true : false;
                   MyParamaters.IsShowError = mypara.IndexOf("ShowError") != -1 ? true : false;
                   MyParamaters.IsSimple = mypara.IndexOf("Simple") != -1 ? true : false;
                   MyParamaters.IsPacket = mypara.IndexOf("Packet") != -1 ? true : false;
                   MyParamaters.IsClassic = mypara.IndexOf("Classic") != -1 ? true : false;
                   MyParamaters.IsSale = mypara.IndexOf("Sale") != -1 ? true : false;
                   MyParamaters.IsBarCafe = mypara.IndexOf("BarCafe") != -1 ? true : false;
                }

			  
                Options.FormProcess.SetProgressValue(20, "Đang thiết lập shortcut cho phần mềm...");

                if (args.Length == 0)
                {
                    Shell32.Create();
                }

                Options.FormProcess.SetProgressValue(25, "Đang tìm dữ liệu...");
                Options.FormProcess.Hide();
			    MyLogon myLogon=new MyLogon();
                myLogon.FirstRun();
                MyApp = new MyApplication();
                MyApp.Run(args);    
                
			    
			}

		}
	}
} //end of root namespace