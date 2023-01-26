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
using Perfect.Utils.System2;

namespace Perfect.Dictionary
{
    public partial class xfmUnitAdd : DevExpress.XtraEditors.XtraForm
    {
        public delegate void AddedEventHander(object sender, UNIT Item);

        public delegate void UpdatedEventHander(object sender, UNIT Item);        

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(UNIT Item)
        {
            if (Added != null)
            {
                Added(this, Item);
            }
        }

        public void RaiseUpdatedEventHander(UNIT Item)
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
            ucAdd.Success +=new xucUnitAdd.SuccessEventHander(ucAdd_Success);
        }

        private void ucAdd_Success(object sender, UNIT Item)
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

        public xfmUnitAdd()
        {
            InitializeComponent();
        }

        public xfmUnitAdd(Actions Action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
            ucAdd.Add();
           // UNIT cls = new UNIT();
           // ucAdd.SetData(cls.NewID());
            Text = "Thêm " + Text;

        }

        public xfmUnitAdd(Actions Action, UNIT Item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
            if (Action == Actions.Update)
            {
                ucAdd.SetData(Item);
                Text = "Cập Nhật " + Text;
            }
            else if (Action == Actions.Delete)
            {
                ucAdd.SetData(Item.Unit_ID);
            }         
        }   
        
    }
}