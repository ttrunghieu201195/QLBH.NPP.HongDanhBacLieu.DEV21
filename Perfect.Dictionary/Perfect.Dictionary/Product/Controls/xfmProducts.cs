using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Dictionary
{
    public partial class xfmProducts : DevExpress.XtraEditors.XtraForm
    {

        private xucItemA ucList = null;

        public delegate void ItemSelectedEventHander(object sender, PRODUCT item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(PRODUCT item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }

        public xfmProducts()
        {
            InitializeComponent();
            Init();
        }

        public bool IsSeach
        {
            set
            {
                ucList.IsSearch = value;
            }
        }

        public xfmProducts(bool search)
        {
            InitializeComponent();
            Init();
            ucList.IsSearch = search;

        }

        private void Init()
        {
            SysLog.Insert("Quản Lý Hàng Hoá", "Xem");
            Size = new Size(800, 600);
            ucList = new xucItemA();
            ucList.Dock = DockStyle.Fill;
            this.Controls.Add(ucList);
            ucList.ReLoad();
            ucList.CloseClick += new Perfect.Common.ButtonClickEventHander(ucCustomerType_CloseClick);
            ucList.ItemSelected += new xucItemA.ItemSelectedEventHander(ucList_ItemSelected);
            Text = (SysOption.Language == "EN" ? "Product management" : Text);
        }

        void ucList_ItemSelected(object sender, PRODUCT item)
        {
            RaiseItemSelectedEventHander(item);
            
        }

        void ucCustomerType_CloseClick(object sender)
        {
            Close();
        }


    }
}