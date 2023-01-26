namespace Perfect.Dictionary.CustomerGroup
{
    public partial class XfmCustomerGroups : DevExpress.XtraEditors.XtraForm
    {
        public XfmCustomerGroups()
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