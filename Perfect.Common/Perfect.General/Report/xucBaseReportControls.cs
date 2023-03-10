using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace Perfect.Common.Report
{
    public partial class xucBaseReportControls : xucBase
    {
        protected string m_ID;
        protected PrintBarManager fPrintBarManager;
        protected virtual PrintPreviewFormEx PreviewForm
        {
            get { return printingSystem == null ? null : printingSystem.PreviewFormEx; }
        }

        public string ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }


        public xucBaseReportControls()
        {
            InitializeComponent();
            alc.FormLocation = AlertFormLocation.BottomRight;
            printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None);
           // fPrintBarManager = CreatePrintBarManager(printControl);
            if (fPrintBarManager != null) fPrintBarManager.Dispose();
            fPrintBarManager = CreatePrintBarManager(printControl);

            fPrintBarManager.PreviewBar.AddItem(btnPreviewForm).BeginGroup = true;
            fPrintBarManager.PreviewBar.AddItem(bbiDesign).BeginGroup = true;
            CreateReport();
        }

        protected PrintBarManager CreatePrintBarManager(PrintControl pc)
        {
            var printBarManager = new PrintBarManager();
            printBarManager.Form = printControl;
            printBarManager.Initialize(pc);
            printBarManager.MainMenu.Visible = false;
            printBarManager.AllowCustomization = false;
            return printBarManager;
        }

        protected void Init()
        {
            //STOCK a = new STOCK();
            //a.AddCombo(cbxStock);
            //PRODUCT b = new PRODUCT();
            //b.AddComboAll(cbxProduct);

            //btnPreview.Text = (SYS_OPTION.Language == "EN" ? "Preview" : btnPreview.Text);
            //btnPrint.Text = (SYS_OPTION.Language == "EN" ? "Print" : btnPrint.Text);

            //dtFrom.DateTime = MyLogin.LoginDate;
            //dtTo.DateTime = MyLogin.LoginDate;
        }

        //public string Title
        //{
        //    //get { return lblTitle.Text; }
        //    //set { lblTitle.Text = value.ToUpper(); }
        //}

        protected virtual void btnPreview_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnPrint_Click(object sender, EventArgs e)
        {

        }

        public virtual XtraReport Report
        {
            get { return fReport; }
            set
            {
                if (fReport != null)
                    fReport.Dispose();
                    fReport = value;
                    if (fReport == null)
                        return;
                    printingSystem.ClearContent();
                    Invalidate();
                    Update();
                    fileName = Common.Report.Helper.GetReportPath(fReport, "repx");
                    fReport.PrintingSystem = fReport.PrintingSystem; //printingSystem;
                    fReport.CreateDocument(true);
            }
        }


        protected XtraReport fReport;
		protected string fileName = "";
			
		public virtual void Activate() {
            DXDisplayNameAttribute.UseResourceManager = true;
			Report = CreateReport();	
			File.Delete(fileName);
		}

		protected virtual XtraReport CreateReport() {
			return null;
		}

        private void btnPreviewForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PreviewForm.SaveState = false;
           // ShowPreviewForm(PreviewForm, FindForm());
            if (fReport!=null) fReport.ShowPreview();
        }

        private void ShowPreviewForm(PrintPreviewFormEx previewForm, Form parentForm)
        {
            previewForm.StartPosition = FormStartPosition.Manual;
            previewForm.MinimumSize = parentForm.MinimumSize;
            if (parentForm.WindowState == FormWindowState.Normal)
                previewForm.Bounds = parentForm.Bounds;
            previewForm.WindowState = parentForm.WindowState;
            parentForm.Visible = false;
            previewForm.ShowDialog();
            parentForm.Visible = true;
        }

        public virtual void PrintPreview(DateTime from, DateTime to, string stock,string stockname, string product)
        {
            
        }

        public virtual void Print(DateTime from, DateTime to, string stock, string stockname, string product)
        {
            
        }

        private void bbiDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fReport != null) fReport.ShowDesignerDialog();
            
            string saveFileName = er.GetReportPath(fReport, "sav");
            fReport.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding);
            fReport.SaveLayout(saveFileName);
            using (XtraReport newReport = XtraReport.FromFile(saveFileName, true))
            {
                XRDesignFormExBase designForm = new CustomDesignForm();
                designForm.OpenReport(newReport);
                designForm.FileName = fileName;
                ShowDesignerForm(designForm, this.FindForm());
                if (designForm.FileName != fileName && File.Exists(designForm.FileName))
                    File.Copy(designForm.FileName, fileName, true);

                designForm.OpenReport((XtraReport)null);
                designForm.Dispose();
            }
            if (File.Exists(fileName))
            {
                fReport.LoadLayout(fileName);
                File.Delete(fileName);
                fReport.CreateDocument(true);
            }

            ShowParameters();
            File.Delete(saveFileName);
            InitializeControls();
        }

        protected virtual void InitializeControls()
        {
        }

        private void ShowDesignerForm(Form designForm, Form parentForm)
        {
            designForm.MinimumSize = parentForm.MinimumSize;
            if (parentForm.WindowState == FormWindowState.Normal)
                designForm.Bounds = parentForm.Bounds;
            designForm.WindowState = parentForm.WindowState;
            parentForm.Visible = false;
            designForm.ShowDialog();
            parentForm.Visible = true;
        }

        protected void ShowParameters()
        {
            printingSystem.ExecCommand(PrintingSystemCommand.Parameters, new object[] { true });
        }

        public virtual void Action(DateTime from, DateTime to, string stock, string stockname, string product, bool previewer)
        {
            if (previewer)
            {
                PrintPreview(from, to, stock,stockname, product);
                return;
            }
            Print(from, to, stock,stockname,product);
        }
        
    }

    public class Helper
    {
        public const int ICC_USEREX_CLASSES = 0x00000200;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public class INITCOMMONCONTROLSEX
        {
            public int dwSize = 8; //ndirect.DllLib.sizeOf(this);
            public int dwICC;
        }
        [DllImport("comctl32.dll")]
        public static extern bool InitCommonControlsEx(INITCOMMONCONTROLSEX icc);

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string libname);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);

        public static string GetReportPath(XtraReport fReport, string ext)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string repName = fReport.Name;
            if (repName.Length == 0) repName = fReport.GetType().Name;
            string dirName = Path.GetDirectoryName(asm.Location);
            return Path.Combine(dirName, repName + "." + ext);
        }
        public static Image LoadImage(string name)
        {
            Bitmap bmp = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("XtraReportsDemos." + name));
            bmp.MakeTransparent(Color.Magenta);
            return bmp;
        }
        public static void PatchConnections(string startupPath)
        {
            //string ignore = global::XtraReportsDemos.Properties.Settings.Default.nwindConnectionString;
            //ignore = global::XtraReportsDemos.Properties.Settings.Default.countriesDBConnectionString;
            //ignore = global::XtraReportsDemos.Properties.Settings.Default.CarsDBConnectionString;
            //ignore = global::XtraReportsDemos.Properties.Settings.Default.StyleSheetLavenderPath;
            //ignore = global::XtraReportsDemos.Properties.Settings.Default.BiolifeTxtPath;

            //string[] connections = new String[] { "nwindConnectionString", "countriesDBConnectionString", "CarsDBConnectionString" };
            //foreach (string s in connections)
            //    PatchConnection(s, startupPath);
            //string[] pathes = new String[] { "StyleSheetLavenderPath", "BiolifeTxtPath" };
            //foreach (string s in pathes)
            //    PatchPath(s, startupPath);
            MessageBox.Show("Đang phát triển");
        }
        static void PatchPath(string propertyName, string startupPath)
        {
            MessageBox.Show("Đang phát triển");
            //string path = (string)global::XtraReportsDemos.Properties.Settings.Default[propertyName];
            //string fileName = System.IO.Path.GetFileName(path);
            //string newPath = DevExpress.Utils.FilesHelper.FindingFileName(startupPath, "Data\\" + fileName, false);
            //if (System.IO.File.Exists(newPath))
            //    global::XtraReportsDemos.Properties.Settings.Default[propertyName] = newPath;
        }
        static void PatchConnection(string propertyName, string startupPath)
        {
            MessageBox.Show("Đang phát triển");
            //string s = (string)global::XtraReportsDemos.Properties.Settings.Default[propertyName];
            //System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(s, @".*Data Source=(?<dataSource>[^;]*)");
            //System.Text.RegularExpressions.Group matchGroup = m.Groups["dataSource"];
            //if (matchGroup.Success)
            //{
            //    string fileName = System.IO.Path.GetFileName(matchGroup.Value);
            //    string path = DevExpress.Utils.FilesHelper.FindingFileName(startupPath, "Data\\" + fileName, false);
            //    if (File.Exists(path))
            //        global::XtraReportsDemos.Properties.Settings.Default[propertyName] = s.Replace(matchGroup.Value, path);
            //}
        }
    }
    public class ReportNames
    {
        public const string
            PivotGrid = "Pivot Grid",
            MailMerge = "Mail Merge",
            OddEvenStyles = "Products by Categories",
            CrossBands = "Cross Band Controls",
            AnchorVertical = "Vertical Anchoring",
            NorthwindTraders_Products = "Products List",
            NorthwindTraders_Catalog = "Fall Catalog",
            NorthwindTraders_Invoice = "Invoice",
            MasterDetailReport = "Suppliers",
            MultiColumnReport = "Customers",
            IListDatasource = "Fishes",
            CustomDraw = "Population",
            ShrinkGrow = "Employees",
            BarCodes_ProductLabels = "Product Labels",
            BarCodes_BarcodeTypes = "Barcode Types",
            RichText = "Cars",
            Subreports = "Customers List",
            TableReport = "Customer Order",
            TreeView = "Countries",
            Charts = "Prices",
            Shapes = "Shapes",
            SideBySideReports = "Employee Comparison",
            CalculatedFieldsReport = "Calculated Fields",
            FormattingRulesReport = "Conditional Formatting",
            HugeAmountRecords = "100000 Records";
    }
}
