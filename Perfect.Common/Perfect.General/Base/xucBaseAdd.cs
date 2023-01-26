using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Common
{

    public partial class xucBaseAdd : xucBase
    {
        public xucBaseAdd()
        {
            InitializeComponent();
            Init();
        }

        protected virtual void MakerInterface()
        {
            //CONTROL_FORMAT.Save("xucBaseAdd");
        }

        protected virtual void SetInterface()
        {
            //DataTable dt = CONTROL_FORMAT.Load("xucBaseAdd");
            //if (dt == null) return;
            //CONTROL_FORMAT.ContainerChangeLanguage(this,ref dt);            
        }

        #region Basic



        public event ButtonClickEventHander CancelClick;
        public event ButtonClickEventHander SaveClick;

        public void RaiseSaveClickEventHander()
        {
            if (SaveClick != null) SaveClick(this);
        }
        public void RaiseCancelClickEventHander()
        {
            if (CancelClick != null) CancelClick(this);
        }

        public bool Number(KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Back | e.KeyChar == '.' | e.KeyChar == '-')
            { return false; }
            if (!char.IsNumber(e.KeyChar))
            { return true; }
            return false;
        }



        #endregion

        protected virtual void Init()
        {

            //Loại khách hàng
            //Nhóm khách hàng
            //Thứ tự
            ReLoad();
        }

        public virtual void SetData(object item)
        {

        }

        public void SetData(string ID)
        {
            txtID.Text = ID;
            txtNAME.Focus();
            Add();
        }

        protected virtual bool Check()
        {
            return true;
        }

        public virtual void Save()
        {
            #region Kiem tra
            if (txtID.ErrorText != string.Empty | txtID.Text == string.Empty)
            {
                XtraMessageBox.Show((txtID.ErrorText.Length == 0 ? "Dữ liệu của ô này không được bỏ trống." : txtID.ErrorText), "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtID.Focus();
                //txtID.ErrorText="Dữ liệu của ô này không được bỏ trống.";
                return;
            }
            if (txtNAME.ErrorText != string.Empty | txtNAME.Text == string.Empty)
            {
                XtraMessageBox.Show((txtNAME.ErrorText.Length == 0 ? "Dữ liệu của ô này không được bỏ trống." : txtNAME.ErrorText), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNAME.Focus();
                return;
            }

            #endregion

            if (!Check()) return;

            if (m_Status == Actions.Add)
            {
                uc_Save();
            }
            else if (m_Status == Actions.Update)
            {
                uc_Update();
            }
            else if (m_Status == Actions.Change)
            {
                uc_Change();
            }
        }

        public virtual void Change()
        {

        }

        public virtual void Delete()
        {
            uc_Delete();
        }

        public virtual void ReLoad()
        {

        }

        protected virtual string uc_Save()
        {
            //string Result = string.Empty;
            //return Result;
            return string.Empty;
        }

        protected virtual string uc_Update()
        {
            //string Result = string.Empty;
            // return Result;
            return string.Empty;
        }

        protected virtual string uc_Change()
        {
            // string Result = string.Empty;
            // return Result;
            return string.Empty;
        }

        protected virtual string uc_Delete()
        {
            // string Result = string.Empty;
            //return Result;
            return string.Empty;

        }


        #region ID

        private void txtID_Leave(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;

            if (m_Status == Actions.None) return;

            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Vui lòng nhập thông tin."+ Text);
               // txt.Focus();
            }
        }

        protected virtual void txtID_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void txtID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        #endregion

        #region NAME

        private void txtNAME_Leave(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (m_Status == Actions.None) return;
            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Vui lòng nhập thông tin." + Text);
               // txt.Focus();
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                if (!string.IsNullOrEmpty(txtNAME.Text))
                {
                    txtID.Text = GenerateCode(txtNAME.Text);
                }
            }
        }

        private void txtNAME_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (m_Status == Actions.None) return;
            if (txt.ErrorText != string.Empty)
            {
                Err.SetError(txt, string.Empty);
            }
        }

        #endregion

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            m_CloseOrNew = CloseOrNew.Close;
            Save();
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            this.RaiseCancelClickEventHander();
        }

        protected virtual void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            btnSave_Click(btnSave, e);
        }

        protected virtual void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {
            btnCancel_Click(btnCancel, e);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            m_CloseOrNew = CloseOrNew.New;
            txtID.Properties.ReadOnly = false;
            Save();
            m_Status = Actions.Add;
            txtID.Focus();
            Add();
            
            
        }

        public virtual void Add()
        {
            
        }
    }

}
