using System.Windows.Forms;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Dictionary
{
    public partial class xfmItemAdd : DevExpress.XtraEditors.XtraForm
    {
        private XucItemAdd ucAdd = new XucItemAdd();
        public xfmItemAdd()
        {
            InitializeComponent();
            Init();

        }

        //void ucAdd_Resize(object sender, EventArgs e)
        //{
        //    Height = ucAdd.Height + 32;
        //}

        public delegate void AddedEventHander(object sender, PRODUCT item);

        public delegate void UpdatedEventHander(object sender, PRODUCT item);

        public event AddedEventHander Added;

        public event UpdatedEventHander Updated;

        private void RaiseAddedEventHander(PRODUCT item)
        {
            if (Added != null)
            {
                Added(this, item);
            }
        }

        private void RaiseUpdatedEventHander(PRODUCT item)
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

            ucAdd = new XucItemAdd {Dock = DockStyle.Fill};
            Controls.Add(ucAdd);
            ucAdd.CancelClick += ucAdd_CancelClick;
            ucAdd.Success += ucAdd_Success;
            

        }

        private void ucAdd_Success(object sender, PRODUCT item)
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
               // Close();
                Hide();
            }

            ucAdd.Clear();
        }

        private void ucAdd_CancelClick(object sender)
        {
            Close();
            //Hide();
        }

        public void Delete()
        {
            ucAdd.Delete();
        }



        public xfmItemAdd(Actions action)
        {
            InitializeComponent();
            Init();
            Add();

        }

        public xfmItemAdd(Actions action, PRODUCT item)
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
            Text = @"Thêm Hàng Hóa, Dịch Vụ";
        }

        private void Change(Actions action, PRODUCT item)
        {
            ucAdd.Status = action;
            //  ucAdd.Resize += new EventHandler(ucAdd_Resize);
            if (action == Actions.Update)
            {
                ucAdd.SetData(item);

                Text = @"Cập Nhật Hàng Hóa, Dịch Vụ";
            }
        }

        public void Change(PRODUCT item)
        {
            Change(Actions.Update, item);
        }

        public void SetGroup(string id)
        {
            ucAdd.SetGroup(id);
        }
    }
}