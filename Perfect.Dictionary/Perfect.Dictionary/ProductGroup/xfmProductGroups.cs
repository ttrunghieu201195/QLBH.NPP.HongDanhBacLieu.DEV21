using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Dictionary.ProductGroup.usercontrol;
using Perfect.ERP;

namespace Perfect.Dictionary
{
    public partial class xfmProductGroups : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemSelectedEventHander(object sender, PRODUCT_GROUP item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(PRODUCT_GROUP item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        public xfmProductGroups()
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
        public xfmProductGroups(bool search)
        {
            InitializeComponent();
            ucList.IsSearch = search;
            Init();
        }
        private void Init()
        {
            SysLog.Insert("Quản Lý Nhóm Hàng Hoá", "Xem");
            ucList.ReLoad();
            ucList.CloseClick += new Perfect.Common.ButtonClickEventHander(ucList_CloseClick);
            ucList.ItemSelected += new XucProductGroup.ItemSelectedEventHander(ucList_ItemSelected);
            Text = SysOption.Language == "VN" ? Text : "Product group";
        }

        void ucList_ItemSelected(object sender,PRODUCT_GROUP  item)
        {
            RaiseItemSelectedEventHander(item);
            
        }
        void ucList_CloseClick(object sender)
        {
            Close();
        }
    }
}