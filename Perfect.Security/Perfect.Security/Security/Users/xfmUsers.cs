using Perfect.ERP;

namespace Perfect.Security
{
    public partial class xfmUsers : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemSelectedEventHander(object sender, SYS_USER item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(SYS_USER item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        private bool _search=false;
        public xfmUsers()
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
        public xfmUsers(bool search)
        {
            _search = search;
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            
			SysLog.Insert("Quản Lý Người Dùng", "Xem");
            ucList.ReLoad();
            ucList.CloseClick += ucList_CloseClick;

            Text = SysOption.Language == "VN" ? Text : "User management";

        }

        void ucList_CloseClick(object sender)
        {
            Close();
        }
    }
}