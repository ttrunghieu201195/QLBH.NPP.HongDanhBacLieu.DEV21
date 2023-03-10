using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Dictionary.Department
{
    public partial class XfmDepartmentAdd : DevExpress.XtraEditors.XtraForm
    {
        public delegate void AddedEventHander(object sender, DEPARTMENT item);

        public delegate void UpdatedEventHander(object sender, DEPARTMENT item);

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(DEPARTMENT item)
        {
            if (Added != null)
            {
                Added(this, item);
            }
        }

        public void RaiseUpdatedEventHander(DEPARTMENT item)
        {
            if (Updated != null)
            {
                Updated(this, item);
            }
        }

        public RowClickEventArgs m_RowClickEventArgs;

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

                case Keys.Control | Keys.Shift | Keys.S:
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
            ucAdd.Success += UcAddSuccess;
            Text =(SysOption.Language=="EN"?"Department": Text);
        }

        private void UcAddSuccess(object sender, DEPARTMENT item)
        {
            if (ucAdd.Status == Actions.Add)
            {
                this.RaiseAddedEventHander(item);
            }
            else if (ucAdd.Status == Actions.Update)
            {
                this.RaiseUpdatedEventHander(item);
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

        public XfmDepartmentAdd()
        {
            InitializeComponent();
        }

        public XfmDepartmentAdd(Actions action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
            var cls = new DEPARTMENT();
            ucAdd.SetData(cls.NewID());
            Text = (SysOption.Language=="EN"?"New ": "Thêm ") + Text;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public XfmDepartmentAdd(Actions action, DEPARTMENT item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
            if (action == Actions.Update)
            {
                ucAdd.SetData(item);
                Text = (SysOption.Language=="EN"?"Edit ": "Cập Nhật ") + Text;

            }
            else if (action == Actions.Delete)
            {
                ucAdd.SetData(item.Department_ID);
            }

        }
    }
}