using System;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary.Department.usercontrol
{
    public partial class XucDepartmentAdd : xucBaseAdd
    {
        public XucDepartmentAdd()
        {
            InitializeComponent();
        }

        public delegate void SuccessEventHander(object sender, DEPARTMENT item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(DEPARTMENT item)
        {
            if (Success != null) Success(this, item);
        }

        protected override void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
            //Thứ tự
            
        }

        public void SetData(DEPARTMENT item)
        {
            txtID.Text = item.Department_ID;
            SysLog.Insert("Quản Lý Bộ Phận", "Xem", txtID.Text);
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.Department_Name;
            txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
        }

        protected override string uc_Save()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiDepartment") != "OK") return "";
            if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Quản Lý Bộ Phận", "Thêm", txtID.Text);
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            var cls = new DEPARTMENT(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            string result = cls.Insert();
            if (result == "OK") RaiseSuccessEventHander(cls);
            Cursor.Current = Cursors.Default;
            DoHide();
            if (result != "OK")
            {
               XtraMessageBox.Show(result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
            }
            return result;

        }

        protected override string uc_Update()
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiDepartment") != "OK") return "";
            if (!MyRule.AllowEdit)
            {
                MyRule.Notify();
                return "";
            }
            SysLog.Insert("Quản Lý Bộ Phận", "Cập Nhật", txtID.Text);
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            var cls = new DEPARTMENT(txtID.Text, txtNAME.Text, txtDescription.Text, chxUse.Checked);
            string result = cls.Update();
            if (result == "OK") RaiseSuccessEventHander(cls);
            if (result != "OK")
            {
                XtraMessageBox.Show( result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DoHide();
            return result;
        }

        protected override string uc_Change()
        {
            string result = string.Empty;
            return result;
        }

        protected override string uc_Delete()
        {
            var cls = new DEPARTMENT {Department_ID = txtID.Text};
            string result = cls.Delete();
            if (result == "OK") RaiseSuccessEventHander(cls);
            return result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {            
            var txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                var department = new DEPARTMENT();
                if (m_Status == Actions.Add)
                {
                    if (department.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
                        txt.Focus();
                    }

                }
            }
        }

        protected override void txtID_EditValueChanged(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (m_Status == Actions.Add)
            {
                var department = new DEPARTMENT();
                if (department.Exist(txt.Text))
                {
                    Err.SetError(txt, "Mã đã tồn tại.");
                    txt.Focus();
                }
            }

        }

        #endregion

        public void Clear()
        {
            txtID.Text = "";
            txtNAME.Text = "";
            txtDescription.Text = "";
        }

        public override void Add()
        {
            base.Add();
            var department=new DEPARTMENT();
            txtID.Text = department.NewID();
            txtNAME.Focus();
        }
    }
}

