using Perfect.Sale.Core.INITS.Customer.UI;

namespace Perfect.Sale.Core
{
    public partial class xfmCustomerDebtInit : DevExpress.XtraEditors.XtraForm
    {
        public xfmCustomerDebtInit()
        {
            InitializeComponent();
            ucDebt.Init();
            ucDebt.CloseClick += ucDebt_CloseClick;
        }

        void ucDebt_CloseClick(object sender)
        {
            Close();
        }
    }
}