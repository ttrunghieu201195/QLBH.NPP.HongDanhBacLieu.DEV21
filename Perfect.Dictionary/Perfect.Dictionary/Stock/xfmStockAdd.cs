using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Utils.System2;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Dictionary
{
    public partial class xfmStockAdd : DevExpress.XtraEditors.XtraForm
    {
        public delegate void AddedEventHander(object sender, STOCK Item);

        public delegate void UpdatedEventHander(object sender, STOCK Item);        

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(STOCK Item)
        {
            if (Added != null)
            {
                Added(this, Item);
            }
        }

        public void RaiseUpdatedEventHander(STOCK Item)
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
            ucAdd.Success +=new  xucStockAdd.SuccessEventHander(ucAdd_Success);
            Text = SysOption.Language == "VN" ? Text : "Stock";
        }

        private void ucAdd_Success(object sender, STOCK Item)
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

        public xfmStockAdd()
        {
            InitializeComponent();
        }

        public xfmStockAdd(Actions Action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
            STOCK cls = new STOCK();
            ucAdd.SetData(cls.NewID());
            Text = (SysOption.Language != "VN" ? "New" : "Thêm ") + Text;
           

        }

        public xfmStockAdd(Actions Action, STOCK Item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
            if (Action == Actions.Update)
            {
                ucAdd.SetData(Item);
                Text = (SysOption.Language != "VN" ? "Edit" : "Cập Nhật ") + Text;
                
            }
            //else if (Action == Actions.Delete)
            //{
            //    ucAdd.SetData(Item.STOCK_ID);
            //}         
        }   

    }
}