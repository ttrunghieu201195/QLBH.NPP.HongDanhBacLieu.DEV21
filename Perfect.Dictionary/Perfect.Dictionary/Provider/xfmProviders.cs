using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Dictionary.Provider.usercontrol.Professional;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Dictionary
{
    public partial class xfmProviders : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemSelectedEventHander(object sender, PROVIDER item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(PROVIDER item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        public xfmProviders()
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

        public xfmProviders(bool search)
        {

            InitializeComponent();
            Init();
            ucList.IsSearch = search;
        }
        

        private void Init()
        {
            SysLog.Insert("Quản Lý Nhà Cung Cấp", "Xem");

            ucList.ReLoad();
            ucList.CloseClick += new Perfect.Common.ButtonClickEventHander(ucCustomerType_CloseClick);
            ucList.ItemSelected += new XucProvider.ItemSelectedEventHander(ucList_ItemSelected);
            ucList.SaveChanged += new Perfect.Common.SaveChangedEventHander(ucList_SaveChanged);
            Text = SysOption.Language == "VN" ? "Nhà Cung Cấp" : "Provider";
        }

        void ucList_SaveChanged(object sender, SaveChangedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.NotSave)
            {
                Text = "Nhà Cung Cấp *";
            }
            else
            {
                Text = "Nhà Cung Cấp";
            }
        }

        void ucList_ItemSelected(object sender, PROVIDER item)
        {
            RaiseItemSelectedEventHander(item);
         
        }
        void ucCustomerType_CloseClick(object sender)
        {
            Close();
        }
    }
}