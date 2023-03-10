using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Utils.System2;
using Perfect.Dictionary;


namespace Perfect.Common
{
    public partial class xucCurrencyAdd : xucBaseAdd
    {
        public xucCurrencyAdd()
        {
            InitializeComponent();
            SetInterface();
            

            //DataTable dt = CONTROL_FORMAT.Load(Name);
           // CONTROL_FORMAT.ContainerChangeLanguage(gcInfo,ref dt);           

        }

        public delegate void SuccessEventHander(object sender, CURRENCY Item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(CURRENCY Item)
        {
            if (Success != null) Success(this, Item);
        }

        protected override void Init()
        {
            //Loại khách hàng
            //Nhóm khách hàng
           // txtExchange.Text = "";
            //Thứ tự
        }

        public void SetData(CURRENCY item)
        {
            txtID.Text = item.Currency_ID;
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.CurrencyName;
            txtExchange.Value =Convert.ToDecimal(item.Exchange);
            chxUse.Checked = item.Active;
        }

        protected override string uc_Save()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiCurrency") != "OK") return "";
            //if (!MyRule.AllowAdd)
            //{
            //    MyRule.Notify();
            //    return "";
            //}

            ////CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string Result = string.Empty;
            CURRENCY cls = new CURRENCY(txtID.Text, txtNAME.Text,Convert.ToDouble(txtExchange.Value), chxUse.Checked);
            Result = cls.Insert();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return Result;
            }
            Cursor.Current = Cursors.Default;
            DoHide();
            return Result;

        }

        protected override string uc_Update()
        {
            //if (MyRule.Get(MyLogin.RoleId, "bbiCurrency") != "OK") return "";
            //if (!MyRule.AllowEdit)
            //{
            //    MyRule.Notify();
            //    return "";
            //}

            ////CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string Result = string.Empty;
            CURRENCY cls = new CURRENCY(txtID.Text, txtNAME.Text, Convert.ToDouble(txtExchange.Value), chxUse.Checked);
            Result = cls.Update();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            if (Result != "OK")
            {
                XtraMessageBox.Show("Lỗi:\n\t" + Result, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return Result;
            }
            DoHide();
            return Result;
        }

        protected override string uc_Change()
        {
            string Result = string.Empty;
            return Result;
        }

        protected override string uc_Delete()
        {
            string Result = string.Empty;
            CURRENCY cls = new CURRENCY();
            cls.Currency_ID = txtID.Text;
            Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            return Result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                CURRENCY CURRENCY = new CURRENCY();
                if (m_Status == Actions.Add)
                {
                    if (CURRENCY.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
                        txt.Focus();
                    }

                }
            }
        }

        protected override void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (m_Status == Actions.Add)
            {
                CURRENCY CURRENCY = new CURRENCY();
                if (CURRENCY.Exist(txt.Text))
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
            txtExchange.Text = "";
        }
    }
}
