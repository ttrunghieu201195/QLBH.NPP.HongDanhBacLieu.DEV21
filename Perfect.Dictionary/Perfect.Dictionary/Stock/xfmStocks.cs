using Perfect.Dictionary.Stock.usercontrol;
using Perfect.ERP;

namespace Perfect.Dictionary.Stock
{
    public partial class XfmStocks : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemSelectedEventHander(object sender, STOCK item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(STOCK item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        private bool _search;

        public XfmStocks()
        {
            InitializeComponent();
            Init();
        }

        public bool IsSearch
        {
            set
            {
                ucList.IsSearch = value;
            }
        }

        public XfmStocks(bool search)
        {
            _search = search;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SysLog.Insert("Quản Lý Danh Mục Kho", "Xem");
            ucList.IsSearch = _search;
            ucList.ReLoad();
            ucList.CloseClick += UcListCloseClick;
            ucList.ItemSelected += UcListItemSelected;
            Text = SysOption.Language == "VN" ? Text : "Stock";
        }

        void UcListItemSelected(object sender, STOCK item)
        {
            RaiseItemSelectedEventHander(item);
        }

        void UcListCloseClick(object sender)
        {
            Close();
        }

       
    }
}