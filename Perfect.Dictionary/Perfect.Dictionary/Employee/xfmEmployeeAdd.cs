using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Dictionary.Employee
{
    public partial class XfmEmployeeAdd : DevExpress.XtraEditors.XtraForm
    {
        public XfmEmployeeAdd()
        {
            InitializeComponent();
            Init();
        }

        public delegate void AddedEventHander(object sender, EMPLOYEE item);

        public delegate void UpdatedEventHander(object sender, EMPLOYEE item);        

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(EMPLOYEE item)
        {
            if (Added != null)
            {
                Added(this, item);
            }
        }

        public void RaiseUpdatedEventHander(EMPLOYEE item)
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
                    MessageBox.Show(@"You are stupid");
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
            Text = (SysOption.Language == "EN" ? "Employee" : Text);
        }

        private void UcAddSuccess(object sender, EMPLOYEE item)
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

        

        public XfmEmployeeAdd(Actions action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
            //ucAdd.Resize += new EventHandler(ucAdd_Resize);
            var cls = new EMPLOYEE();
            ucAdd.SetData(cls.NewID());
            Text = (SysOption.Language == "EN" ? "New " : "Thêm ") + Text;

        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public XfmEmployeeAdd(EMPLOYEE item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = Actions.Add;
            //ucAdd.Resize += new EventHandler(ucAdd_Resize);
            ucAdd.Add(item);
            Text = @"Thêm " + Text;

        }

        public XfmEmployeeAdd(Actions action, EMPLOYEE item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
          //  ucAdd.Resize += new EventHandler(ucAdd_Resize);
            if (action == Actions.Update)
            {
                ucAdd.SetData(item);
                Text = (SysOption.Language == "EN" ? "Edit " : "Cập Nhật ") + Text;
            }
            //else if (Action == Actions.Delete)
            //{
            //    ucAdd.SetData(Item.Customer_Group_ID);
            //}         
        }   
    }
}