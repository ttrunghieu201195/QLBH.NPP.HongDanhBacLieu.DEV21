using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Perfect.Common
{
    public partial class xucLookEdit : DevExpress.XtraEditors.GridLookUpEdit
    {
        public xucLookEdit()
        {
            InitializeComponent();
            base.Text=_defaultText;
            base.ForeColor = Color.DarkGray;
        }

        protected override void OnLeave(EventArgs e)
        {
            if (base.Text == "")
            {
                base.Text = _defaultText;
                base.ForeColor = Color.DarkGray;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (base.Text != _defaultText)
            {
                base.Text = "";
                base.ForeColor = Color.Black;
            }
        }

        private string _defaultText;

        public string DefaultText
        {
            get { return _defaultText; }
            set
            {
                _defaultText = value;
                base.Text = _defaultText;
                base.Properties.NullText = _defaultText;
                base.Properties.NullValuePrompt = _defaultText;
            }
        }

        public override string Text
        {
            set
            {
                if (value != _defaultText)
                {
                    base.Text = value;
                }
            }

            get
            {
                return base.Text == _defaultText ? "" : base.Text;
            }

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
