using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Common
{
	public partial class ProgressForm : DevExpress.XtraEditors.XtraForm {

        public ProgressForm(UserControl parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                Left = parent.Left + (parent.Width - Width) / 2;
                Top = parent.Top + (parent.Height - Height) / 2;
            }
            this.Height = progressBarControl1.Height + progressBarControl1.Top * 2 + 4;
        }

        public ProgressForm()
        {
            InitializeComponent();           
        }

		public ProgressForm(Form parent) {
			InitializeComponent();
			if(parent != null) {
				Left = parent.Left + (parent.Width - Width) / 2;
				Top = parent.Top + (parent.Height - Height) / 2;
			}
			this.Height = progressBarControl1.Height + progressBarControl1.Top * 2 + 4;
		}

		public void SetProgressValue(int position) {
			progressBarControl1.Position = position;
			this.Update();
		}
	}
}
