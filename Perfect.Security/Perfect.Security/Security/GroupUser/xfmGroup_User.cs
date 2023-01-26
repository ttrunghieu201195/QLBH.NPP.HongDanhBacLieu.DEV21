using System;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Security.Security.GroupUser.usercontrol;

namespace Perfect.Security.Security.GroupUser
{
    public partial class xfmGroup_User : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemSelectedEventHander(object sender, SYS_GROUP item);

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(SYS_GROUP item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }
        public xfmGroup_User()
        {
            InitializeComponent();
        }

        private void XfmGroupUserLoad(object sender, EventArgs e)
        {
            var xucgroupuser = new XucGroupUser();
            panelControl1.Controls.Add(xucgroupuser);
            xucgroupuser.Dock = DockStyle.Fill;
            xucgroupuser.Show();
        }
        XucGroupUser _xucgroupuser;
        public void Init()
        {
            _xucgroupuser = new XucGroupUser();
            _xucgroupuser.Added += xucgroupuser_added;
        }
        public void close()
        {
            var x = new xfmGroup_User();
            x.Close();
        }
        public void xucgroupuser_added(object sender, SYS_GROUP item)
        {

        }
    }
}