using Perfect.ERP;

namespace Perfect.Dictionary
{
    public partial class xfmHistory : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InventoryShowEventHander(object sender, PRODUCT item);

        public event InventoryShowEventHander InventoryShow;

        private void RaiseInventoryShowEventHander(PRODUCT item)
        {
            if (InventoryShow != null) InventoryShow(this, item);
        }

        public xfmHistory()
        {
            InitializeComponent();
            ucList.CloseClick += xucHistory_CloseClick;
            ucList.InventoryShow += ucList_InventoryShow;
        }

        void ucList_InventoryShow(object sender, PRODUCT item)
        {
            RaiseInventoryShowEventHander(item);
        }

        void xucHistory_CloseClick(object sender)
        {
            Close();
            
        }

        public void SetData(string product_id,string product_name)
        {
            ucList.SetData(product_id,product_name);
        }
    }
}