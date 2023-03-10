using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Utils.System2;

namespace Perfect.Dictionary
{
    public partial class xfmCurrencyAdd : DevExpress.XtraEditors.XtraForm
    {
        public delegate void AddedEventHander(object sender, CURRENCY Item);

        public delegate void UpdatedEventHander(object sender, CURRENCY Item);        

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(CURRENCY Item)
        {
            if (Added != null)
            {
                Added(this, Item);
            }
        }

        public void RaiseUpdatedEventHander(CURRENCY Item)
        {
            if (Updated != null)
            {
                Updated(this, Item);
            }
        }        

        public RowClickEventArgs m_RowClickEventArgs;

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Alt | Keys.D:
                    MessageBox.Show("You are stupid");
                    return true;
                    
                // some more cases...                    
                case Keys.Control | Keys.S:
                    ucAdd.IsClose = CloseOrNew.Close;
                     ucAdd.Save();                    
                    return true;

                case Keys.Control | Keys.Shift| Keys.S:
                    ucAdd.IsClose = CloseOrNew.New;
                    ucAdd.Save();
                    return true;

                case Keys.F2:
                    ucAdd.IsClose = CloseOrNew.Close;
                    ucAdd.Save();                   
                    return true;
                    
                case Keys.Control | Keys.W:
                    ucAdd.IsClose = CloseOrNew.Close;
                    ucAdd.Save();                   
                    return true;
                   
                case Keys.Alt | Keys.X:
                    Close();
                    return true;
                    
                case Keys.Escape:
                    Close();
                    return true;
                    

            }
            return false;
        }

        private void Init()
        {
            ucAdd.CancelClick += new ButtonClickEventHander(ucAdd_CancelClick);                       
            ucAdd.Success +=new xucCurrencyAdd.SuccessEventHander(ucAdd_Success);
            Text = (SysOption.Language == "EN" ? "Currency" : Text);
        }

        private void ucAdd_Success(object sender, CURRENCY Item)
        {
            if (ucAdd.Status == Actions.Add)
            {
                this.RaiseAddedEventHander(Item);
            }
            else if (ucAdd.Status == Actions.Update)
            {
                this.RaiseUpdatedEventHander(Item);
            }

            if (ucAdd.IsClose == CloseOrNew.Close)
            {
                Close();
            }

            ucAdd.Clear();
        }
        
        private void ucAdd_CancelClick(object sender)
        {
            Close();
        }

        public void Delete()
        {
            ucAdd.Delete();
        }

        public xfmCurrencyAdd()
        {
            InitializeComponent();
        }

        public xfmCurrencyAdd(Actions Action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
           // CURRENCY cls = new CURRENCY();
           // ucAdd.SetData(cls.NewID());
            Text = (SysOption.Language == "EN" ? "New " : "Thêm ") + Text;

        }

        public xfmCurrencyAdd(Actions Action, CURRENCY Item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
            if (Action == Actions.Update)
            {
                ucAdd.SetData(Item);
                Text = (SysOption.Language == "EN" ? "Edit ": "Cập Nhật ") + Text;
            }
            else if (Action == Actions.Delete)
            {
                ucAdd.SetData(Item.Currency_ID);
            }         
        }   

    }
}