namespace Perfect.Security
{
    public partial class xfmPermision : DevExpress.XtraEditors.XtraForm
    {
        public xfmPermision()
        {
            InitializeComponent();
        }

        public void SetData(string Group_ID)
        {
            this.Text = "Phần Quyền (" + Group_ID + ")";
            ucList.SetData(Group_ID);
        }
    }
}