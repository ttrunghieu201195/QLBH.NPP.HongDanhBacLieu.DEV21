using System;

namespace Perfect.Security
{
    public partial class xucPermisionInGroup : DevExpress.XtraEditors.XtraUserControl
    {
        public xucPermisionInGroup()
        {
            InitializeComponent();
            ucList.SendID += ucList_SendID;
        }

        void ucList_SendID(object sender, string ID)
        {
            ucMain.SetData(ID);
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        public void Reload()
        {
            ucList.ReLoad();
        }
        
    }
}
