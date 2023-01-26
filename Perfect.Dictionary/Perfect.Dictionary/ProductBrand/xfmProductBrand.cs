namespace Perfect.Dictionary.CustomerGroup
{
    public partial class xfmProductBrand : DevExpress.XtraEditors.XtraForm
    {
        public xfmProductBrand()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ucList.ReLoad();
            ucList.CloseClick += UcCustomerTypeCloseClick;
        }

        void UcCustomerTypeCloseClick(object sender)
        {
            Close();
        }
    }
}