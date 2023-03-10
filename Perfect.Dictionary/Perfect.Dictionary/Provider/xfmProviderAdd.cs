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
    public partial class xfmProviderAdd : DevExpress.XtraEditors.XtraForm
    {
        public xfmProviderAdd()
        {
            InitializeComponent();
            Init();
        }


        public delegate void AddedEventHander(object sender, PROVIDER Item);

        public delegate void UpdatedEventHander(object sender, PROVIDER Item);

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(PROVIDER Item)
        {
            if (Added != null)
            {
                Added(this, Item);
            }
        }

        public void RaiseUpdatedEventHander(PROVIDER Item)
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
                //case Keys.Alt | Keys.D:
                //    MessageBox.Show("You are stupid");
                //    return true;

                // some more cases...                    
                case Keys.Control | Keys.S:
                    ucAdd.IsClose = CloseOrNew.Close;
                    ucAdd.Save();
                    return true;

                case Keys.Control | Keys.Shift | Keys.S:
                    ucAdd.IsClose = CloseOrNew.New;
                    ucAdd.Save();
                    ucAdd.Add();
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
            ucAdd.Dock = DockStyle.Fill;
            ucAdd.CancelClick += new ButtonClickEventHander(ucAdd_CancelClick);                       
            ucAdd.Success +=new xucProviderQuickAdd.SuccessEventHander(ucAdd_Success);
          
        }

        private void ucAdd_Success(object sender, PROVIDER Item)
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
                Hide();
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



        public xfmProviderAdd(Actions Action)
        {
            InitializeComponent();
            Init();
            Add();

        }

        public xfmProviderAdd(PROVIDER Item)
        {
            InitializeComponent();
            Init();
            Change(Actions.Add, Item);        
        }
        public xfmProviderAdd(Actions Action, PROVIDER Item)
        {
            InitializeComponent();
            Init();
            Change(Action, Item);
        }

        public void Add()
        {
            ucAdd.Status = Actions.Add;
            //ucAdd.Resize += new EventHandler(ucAdd_Resize);
            //PRODUCT cls = new PRODUCT();
            ucAdd.Add();
            Text = "Thêm Nhà Cung Cấp";
        }

        public void Change(Actions Action, PROVIDER Item)
        {
            ucAdd.Status = Action;
            //  ucAdd.Resize += new EventHandler(ucAdd_Resize);
            if (Action == Actions.Update)
            {
                ucAdd.SetData(Item);

                Text = "Cập Nhật Nhà Phân Phối";
            }
            else
            {
                Text = "Thêm Nhà Phân Phối";
                ucAdd.Status = Action;
                Add();
            }
        }

        public void Change(PROVIDER Item)
        {
            Change(Actions.Update, Item);
        }

       }
}