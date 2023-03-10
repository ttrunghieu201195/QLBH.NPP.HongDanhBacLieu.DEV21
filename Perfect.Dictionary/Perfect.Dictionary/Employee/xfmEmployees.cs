using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Dictionary.Employee.usercontrol.Standard;
using Perfect.ERP;

namespace Perfect.Dictionary
{
    public partial class xfmEmployees : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemSelectedEventHander(object sender, EMPLOYEE item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(EMPLOYEE item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        public xfmEmployees()
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

        public xfmEmployees(bool search)
        {
            InitializeComponent();
            ucList.IsSearch = search;
            Init();
        }

        private void Init()
        {
            SysLog.Insert("Quản Lý Nhân Viên", "Xem");
            ucList.ReLoad();
            ucList.CloseClick += new Perfect.Common.ButtonClickEventHander(ucCustomerType_CloseClick);
            ucList.ItemSelected += new XucEmployee.ItemSelectedEventHander(ucList_ItemSelected);
            Text = (SysOption.Language=="EN"?"Employee management": Text );
        }

        void ucList_ItemSelected(object sender,EMPLOYEE  item)
        {
            RaiseItemSelectedEventHander(item);
            
        }

        void ucCustomerType_CloseClick(object sender)
        {
            Close();
        }
    }
}