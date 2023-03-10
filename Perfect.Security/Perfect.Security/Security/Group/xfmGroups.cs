using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Security
{
    public partial class xfmGroups : XtraForm
    {
        public delegate void ItemSelectedEventHander(object sender, SYS_GROUP item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(SYS_GROUP item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        private bool _search=false;
		
		
        public bool IsSearch
        {
            set
            {
                ucList.IsSearch = value;
            }
        }
        public xfmGroups(bool search)
        {
            _search = search;
            InitializeComponent();
            Init();
        }
        public xfmGroups()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            SysLog.Insert("Vai Trò Người Dùng", "Xem");

            ucList.CloseClick += ucList_CloseClick;
            Text = SysOption.Language == "VN" ? Text : "Roles and Permision";
            ucList.Added += ucList_Added;
        }

        void ucList_Added(object sender, SYS_GROUP item)
        {
            //ucPermision.Reload();
        }

        void ucList_CloseClick(object sender)
        {
            Close();
        }
    }
}