using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Inventory.Core.Inventory.Inventory;

namespace Perfect.Inventory
{
    public partial class xfmInventorySummary : XtraForm
    {
        private xucInventorySummary _xucInventorySummary = new xucInventorySummary();
        public xfmInventorySummary()
        {
            InitializeComponent();
            _xucInventorySummary.Dock = DockStyle.Fill;
            Controls.Add(_xucInventorySummary);
            _xucInventorySummary.Reload();
            
        }
    }
}