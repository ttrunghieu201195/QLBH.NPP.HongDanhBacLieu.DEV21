namespace Perfect.Dictionary.DelieveryRoute
{
    public partial class XfmDelieveryRoute : DevExpress.XtraEditors.XtraForm
    {
        public XfmDelieveryRoute()
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