using System;
using System.Windows.Forms;
using Perfect.Common;
using Perfect.Dictionary.Customer.usercontrol.Professional;
using Perfect.ERP;

namespace Perfect.Dictionary.Customer
{
    public partial class XfmCustomers : DevExpress.XtraEditors.XtraForm
    {

        private XucCustomer ucList = new XucCustomer();

        public delegate void ItemSelectedEventHander(object sender, CUSTOMER item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(CUSTOMER item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }

        public event RibbonChangedEventHander RibbonChanged;
        protected void RaiseRibbonChanged(RibbonChangedEventArgs e)
        {
            RibbonChangedEventHander changed = RibbonChanged;
            if (changed != null) changed(this, e);
        }

        private bool _search;

        public XfmCustomers()
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

        public XfmCustomers(bool search)
        {
            _search = search;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SysLog.Insert("Quản Lý Khách Hàng", "Xem");
            ucList.Dock = DockStyle.Fill;
            Controls.Add(ucList);
            ucList.IsSearch = _search;
            ucList.ReLoad();
            ucList.CloseClick += UcCustomerTypeCloseClick;
            ucList.ItemSelected += UcListItemSelected;
            Text = SysOption.Language == "VN" ? Text : "Customer management";
        }

        void UcListItemSelected(object sender, CUSTOMER item)
        {
            RaiseItemSelectedEventHander(item);
           
        }

        void UcCustomerTypeCloseClick(object sender)
        {
            Close();
        }

        private void XfmCustomersActivated(object sender, EventArgs e)
        {
           // RaiseRibbonChanged(new RibbonChangedEventArgs(ucList.RibbonBar));
        }

        private void XfmCustomersDeactivate(object sender, EventArgs e)
        {
            
        }
    }
}