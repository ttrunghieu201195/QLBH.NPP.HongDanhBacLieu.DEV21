using System;
using System.Windows.Forms;
using System.IO;
namespace Perfect.Inventory.Core.Inventory.Import
{
    public partial class XfrmExcel : DevExpress.XtraEditors.XtraForm
    {
        public XfrmExcel()
        {
            InitializeComponent();
        }
        private void Ghifile( string excelfile)
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
            var workbookPath = Application.StartupPath + excelfile;
            if (dialogSave.ShowDialog(this) == DialogResult.OK)
            {
                try
                   
                { 
                    string filename = dialogSave.FileName;
                    string copyfile = workbookPath ;
                    File.Copy(copyfile, filename);
                }
                catch { MessageBox.Show(@" Không thực hiện được"); }
            }
            dialogSave.Dispose();

            //Process.Start();

        }
        private void LabelControl1Click(object sender, EventArgs e)
        {//tồn kho
            Ghifile(@"\ImportFile\SDDK.xls");
        }
        private void LabelControl5Click(object sender, EventArgs e)
        {//khach hang
            Ghifile(@"\ImportFile\khachhang.xls");
        }
        private void LabelControl4Click(object sender, EventArgs e)
        {//hang hoa
            Ghifile(@"\ImportFile\hanghoa.xls");
        }
        private void LabelControl3Click(object sender, EventArgs e)
        {//kho hang
            Ghifile(@"\ImportFile\kho.xls");
        }
        private void LabelControl2Click(object sender, EventArgs e)
        {//nhom hang
            Ghifile(@"\ImportFile\nhomhang.xls");
        }
        private void LabelControl6Click(object sender, EventArgs e)
        {
            Ghifile(@"\ImportFile\nhaphanphoi.xls");
        }
        private void LabelControl7Click(object sender, EventArgs e)
        {
            Ghifile(@"\ImportFile\khuvuc.xls");
        }

        private void LabelControl8Click(object sender, EventArgs e)
        {
            Ghifile(@"\ImportFile\donvi.xls");
        }

        private void LabelControl9Click(object sender, EventArgs e)
        {
            Ghifile(@"\ImportFile\CongNoKH.xls");
        }

        private void LabelControl10Click(object sender, EventArgs e)
        {
            Ghifile(@"\ImportFile\CongNoNCC.xls");
        }
    }
}