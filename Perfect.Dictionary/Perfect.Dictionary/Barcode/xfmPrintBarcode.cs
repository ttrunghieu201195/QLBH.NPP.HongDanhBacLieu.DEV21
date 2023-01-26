using System.Windows.Forms;

namespace Perfect.Dictionary.Barcode
{
    public partial class XfmPrintBarcode : DevExpress.XtraEditors.XtraForm
    {
        public XfmPrintBarcode()
        {
            InitializeComponent();
            var uc = new XucPrintBarcode { Dock = DockStyle.Fill };
            Controls.Add(uc);
        }
    }
}