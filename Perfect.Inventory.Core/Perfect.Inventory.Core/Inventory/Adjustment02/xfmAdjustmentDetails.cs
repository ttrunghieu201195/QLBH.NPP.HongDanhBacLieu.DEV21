using DevExpress.XtraEditors;
using Perfect.Data.Helper;
using Perfect.Common.Base;
using Perfect.Common;

namespace Perfect.Inventory.Core.Inventory.Adjustment
{
    public partial class XfmAdjustmentDetails : XtraForm
    {
        public XfmAdjustmentDetails()
        {
            InitializeComponent();
        }
        public XfmAdjustmentDetails(string adjustId)
        {
            InitializeComponent();
            InitData(adjustId);

        }

        private void InitData(string adjiustId)
        {
            adjustmentGetByTableAdapter1.Connection.ConnectionString = SqlHelper.ConnectString;
            adjustmentGetByTableAdapter1.ClearBeforeFill = true;
            adjustmentGetByTableAdapter1.Fill(dsAdjustmentMana1.AdjustmentGetBy, adjiustId);
        }

        private void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            var xucBase = new xucBase();
            xucBase.Export(gbList);
        }
    }
}