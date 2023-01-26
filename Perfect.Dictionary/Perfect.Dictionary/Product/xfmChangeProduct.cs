using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Dictionary.Product
{
    public partial class xfmChangeProduct : DevExpress.XtraEditors.XtraForm
    {
        public delegate void IdChangedEventHander(object sender, string id);
        public event IdChangedEventHander IdChanged;

        private void RaiseGroupChanged(string id)
        {
            IdChangedEventHander changed = IdChanged;
            if (changed != null) changed(this,id);
        }

        public xfmChangeProduct()
        {
            InitializeComponent();
        }

        public void setData(string id)
        {
            lbCurrentID.Text = id;
            txtNewID.Focus();
        }

       

       

        private void xfmGroupChanged_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PRODUCT cls = new PRODUCT();
            if (txtNewID.Text=="")return;
            if (XtraMessageBox.Show("Bạn có chắc chắn là muốn thực hiện sự thay đổi này hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
            string id = txtNewID.Text; //cbxGroup.EditValue.ToString();
            if (cls.Exist(id))
            {
                XtraMessageBox.Show("Mã hàng hóa này đã tồn tại, không thực hiện thay đổi được.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RaiseGroupChanged(id);
            Close();
        }
    }
}