using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Security
{
    public partial class xfmUserAdd : DevExpress.XtraEditors.XtraForm
    {
        public delegate void AddedEventHander(object sender, SYS_USER Item);

        public delegate void UpdatedEventHander(object sender, SYS_USER Item);        

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(SYS_USER Item)
        {
            if (Added != null)
            {
                Added(this, Item);
            }
        }

        public void RaiseUpdatedEventHander(SYS_USER Item)
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
            ucAdd.CancelClick += ucAdd_CancelClick;                       
            ucAdd.Success +=ucAdd_Success;

            Text = SysOption.Language == "VN" ? Text : "User";

        }

        private void ucAdd_Success(object sender, SYS_USER Item)
        {
            if (ucAdd.Status == Actions.Add)
            {
                RaiseAddedEventHander(Item);
            }
            else if (ucAdd.Status == Actions.Update)
            {
                RaiseUpdatedEventHander(Item);
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

        public xfmUserAdd()
        {
            InitializeComponent();
        }

        public xfmUserAdd(Actions Action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
            var cls = new SYS_USER();
            ucAdd.SetData(cls.NewID());
            Text =(SysOption.Language=="EN"? "New ":"Thêm ") + Text;

        }

        public xfmUserAdd(Actions Action, SYS_USER Item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Action;
            if (Action == Actions.Update)
            {
                ucAdd.SetData(Item);
                Text = (SysOption.Language=="EN"? "Edit ":"Cập nhật ") + Text;
            }
            else if (Action == Actions.Delete)
            {
                ucAdd.SetData(Item.UserID);
            }         
        }   
    }
}