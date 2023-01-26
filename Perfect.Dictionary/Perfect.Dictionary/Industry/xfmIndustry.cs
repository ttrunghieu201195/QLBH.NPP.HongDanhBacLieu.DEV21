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
    public partial class xfmIndustry : DevExpress.XtraEditors.XtraForm
    {
        //private XucCustomer ucList = new XucCustomer();

        public delegate void ItemSelectedEventHander(object sender, INDUSTRY item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(INDUSTRY item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        private bool _search=false;

        public xfmIndustry()
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
        public xfmIndustry(bool search)
        {
            _search = search;
            InitializeComponent();
            Init();
        }
        private void Init()
        { 
            ucList.Dock = DockStyle.Fill;
            this.Controls.Add(ucList);
            ucList.IsSearch = _search;
            ucList.ReLoad();
            ucList.CloseClick += new Perfect.Common.ButtonClickEventHander(ucList_CloseClick);
           // ucList.ItemSelected += new xucUnit.ItemSelectedEventHander(ucList_ItemSelected);
        }

        void ucList_ItemSelected(object sender, INDUSTRY item)
        {
            RaiseItemSelectedEventHander(item);
           
        }
        void ucList_CloseClick(object sender)
        {
            Close();
        }
    }
}