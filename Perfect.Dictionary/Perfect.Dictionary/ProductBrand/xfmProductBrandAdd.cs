using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Dictionary.CustomerGroup
{
    public partial class xfmProductBrandAdd : XtraForm
    {
        #region Delegates

        public delegate void AddedEventHander(object sender, PRODUCT_BRAND item);

        public delegate void UpdatedEventHander(object sender, PRODUCT_BRAND item);

        #endregion

        public RowClickEventArgs MRowClickEventArgs;

        public xfmProductBrandAdd()
        {
            InitializeComponent();
        }

        public xfmProductBrandAdd(Actions action)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
            // PRODUCT_BRAND cls = new PRODUCT_BRAND();
            // ucAdd.SetData(cls.NewID());
            ucAdd.Add();
            Text = @"Thêm " + Text;
        }

        public xfmProductBrandAdd(Actions action, PRODUCT_BRAND item)
        {
            InitializeComponent();
            Init();
            ucAdd.Status = action;
            if (action == Actions.Update)
            {
                ucAdd.SetData(item);
                Text = @"Cập Nhật " + Text;
            }
            //else if (Action == Actions.Delete)
            //{
            //    ucAdd.SetData(Item.Customer_Group_ID);
            //}         
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        public void RaiseAddedEventHander(PRODUCT_BRAND item)
        {
            if (Added != null)
            {
                Added(this, item);
            }
        }

        public void RaiseUpdatedEventHander(PRODUCT_BRAND item)
        {
            if (Updated != null)
            {
                Updated(this, item);
            }
        }


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
        }

        private void UcAddSuccess(object sender, PRODUCT_BRAND item)
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
    }
}