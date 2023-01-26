using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Inventory.Core.Inventory.Inventory;

namespace Perfect.Inventory
{
    public partial class xfmInventoryOrders : DevExpress.XtraEditors.XtraForm
    {
        public xfmInventoryOrders()
        {
            InitializeComponent();
            if (CODE.TypeSoft==302)
            {
                var ucList = new xucInventoryOrdersBFC();
                ucList.Dock = DockStyle.Fill;
                Controls.Add(ucList);
            }
            else
            {
                var ucList = new xucInventoryOrders();
                ucList.Dock = DockStyle.Fill;
                Controls.Add(ucList);   
            }
            

        }
    }
}