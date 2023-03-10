using Perfect.ERP;

namespace Perfect.Dictionary.Department
{
    public partial class XfmDepartments : DevExpress.XtraEditors.XtraForm
    {

        public delegate void ItemSelectedEventHander(object sender, DEPARTMENT item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(DEPARTMENT item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }

        public bool IsSearch
        {
            set
            {
                ucList.IsSearch = value;
            }
        }
        public XfmDepartments(bool search)
        {
            InitializeComponent();
            Init();
        }

        public XfmDepartments()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SysLog.Insert("Quản Lý Bộ Phận", "Xem");
            ucList.CloseClick += UcListCloseClick;
            Text = (SysOption.Language == "EN" ? "Department" : Text);
        }

        void UcListCloseClick(object sender)
        {
            Close();
        }
    }
}