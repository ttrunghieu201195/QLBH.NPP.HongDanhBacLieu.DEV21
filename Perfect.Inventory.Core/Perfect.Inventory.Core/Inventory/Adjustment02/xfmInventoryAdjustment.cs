using System.Windows.Forms;

namespace Perfect.Inventory.Core.Inventory.Adjustment
{
    public partial class XfmInventoryAdjustment : DevExpress.XtraEditors.XtraForm
    {
        public XfmInventoryAdjustment()
        {
            InitializeComponent();
            var uc=new XucInventoryAdjustment {Dock = DockStyle.Fill};
            Controls.Add(uc);
        }
    }
}