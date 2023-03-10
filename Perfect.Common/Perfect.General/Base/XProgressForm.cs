using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Common.Base
{
	public partial class XProgressForm : XtraForm {
	    private bool _die;
	    private bool _autoClose;
        public XProgressForm(UserControl parent)
        {
            InitializeComponent();
           
        }

        public XProgressForm()
        {
            InitializeComponent(); 
            
        }

	    private Form _form;
        public XProgressForm(Form parent)
        {
			InitializeComponent();
            _form = parent;
		}

	    public bool AutoClose
	    {
	        get { return _autoClose; }
	        set { _autoClose = value; }
	    }


	    public void SetProgressValue(string message)
        {
            SetProgressValue(progressBarControl1.Position, message);
        }

		public void SetProgressValue(int position) {
		    SetProgressValue(position, lblTitle.Text);
		}

        public void SetProgressValue(int position,string message)
        {
            SetProgressValue(position, message, "Vui lòng đợi trong giây lát");
        }

	    private void SetProgressValue(int position,string message,string caption)
        {

            if (_die) return;
            if (!Visible) if (_form != null) Show(_form); else Show();
            lblMessage.Text = message;
            progressBarControl1.Position = position;
            lblTitle.Text = caption;
          
            Update();
            if (position >= 100) if (AutoClose) Visible = false;
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
        }

        private void lblTitle_Click(object sender, System.EventArgs e)
        {

        }

        private void progressBarControl1_EditValueChanged(object sender, System.EventArgs e)
        {

        }

        private void XProgressForm_Load(object sender, System.EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, System.EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}
