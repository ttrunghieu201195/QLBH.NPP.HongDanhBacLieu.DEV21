using System;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Dictionary.Customer
{
    public partial class xfmCustomerAdd : DevExpress.XtraEditors.XtraForm
    {
        public xfmCustomerAdd()
        {
            InitializeComponent();
            Init();
        }

        void ucAdd_Resize(object sender, EventArgs e)
        {
            //Height = ucAdd.Height + 32;
        }

        public delegate void AddedEventHander(object sender, CUSTOMER Item);

        public delegate void UpdatedEventHander(object sender, CUSTOMER Item);        

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(CUSTOMER Item)
        {
            if (Added != null)
            {
                Added(this, Item);
            }
        }

        public void RaiseUpdatedEventHander(CUSTOMER Item)
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

                case Keys.Control | Keys.Shift| Keys.S:
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
            ucAdd.Success +=new xucCustomerQuickAdd.SuccessEventHander(ucAdd_Success);
            
        }

        private void ucAdd_Success(object sender, CUSTOMER Item)
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
           // Hide();
        }

        public void Delete()
        {
            ucAdd.Delete();
        }

        

        public xfmCustomerAdd(Actions action)
        {
            InitializeComponent();
            Init();
            Add();

        }

        public xfmCustomerAdd(CUSTOMER Item)
        {
            InitializeComponent();
            Init();
            Change(Actions.Add, Item);        
        }

        public xfmCustomerAdd(Actions action, CUSTOMER item)
        {
            InitializeComponent();
            Init();
            Change(action, item);
        }

        public void Add()
        {
            ucAdd.Status = Actions.Add;
            //ucAdd.Resize += new EventHandler(ucAdd_Resize);
            //PRODUCT cls = new PRODUCT();
            ucAdd.Add();
            Text = @"Thêm Khách Hàng";
        }

        public void Change(Actions action, CUSTOMER item)
        {
            ucAdd.Status = action;
            if (action == Actions.Update)
            {
                ucAdd.SetData(item);

                Text = @"Cập Nhật Khách Hàng";
            }
            else
            {
                Text = @"Thêm Khách Hàng";
                Add();
            }
        }

        public void Change(CUSTOMER Item)
        {
            Change(Actions.Update, Item);
        }

       }
}