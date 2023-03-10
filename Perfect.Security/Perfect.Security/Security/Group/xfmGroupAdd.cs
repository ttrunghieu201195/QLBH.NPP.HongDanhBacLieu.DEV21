using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Security
{
    public partial class XfmGroupAdd : XtraForm
    {
        public delegate void AddedEventHander(object sender, SYS_GROUP item);

        public delegate void UpdatedEventHander(object sender, SYS_GROUP item);        

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(SYS_GROUP item)
        {
            if (Added != null)
            {
                Added(this, item);
            }
        }

        public void RaiseUpdatedEventHander(SYS_GROUP item)
        {
            if (Updated != null)
            {
                Updated(this, item);
            }
        }        

        public RowClickEventArgs MRowClickEventArgs;

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
            ucAdd.CancelClick += UcAddCancelClick;                       
            ucAdd.Success +=UcAddSuccess;
            Text = SysOption.Language == "VN" ? Text : "Roles";
        }

        private void UcAddSuccess(object sender, SYS_GROUP item)
        {
            if (ucAdd.Status == Actions.Add)
            {
                RaiseAddedEventHander(item);
            }
            else if (ucAdd.Status == Actions.Update)
            {
                RaiseUpdatedEventHander(item);
            }

            if (ucAdd.IsClose == CloseOrNew.Close)
            {
                Close();
            }

            ucAdd.Clear();
        }
        
        private void UcAddCancelClick(object sender)
        {
            Close();
        }

        public void Delete()
        {
            ucAdd.Delete();
        }

        public XfmGroupAdd()
        {
            InitializeComponent();
        }

        public XfmGroupAdd(Actions action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
            ucAdd.SetData("");
            Text = (SysOption.Language=="EN"?"New ":"Thêm ") + Text;

        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public XfmGroupAdd(Actions action, SYS_GROUP item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
            if (action == Actions.Update)
            {
                ucAdd.SetData(item);
                Text = (SysOption.Language=="EN"?"Edit ":"Cập nhật ") + Text;
            }
            else if (action == Actions.Delete)
            {
                ucAdd.SetData(item.Group_ID);
            }         
        }   


    }
}