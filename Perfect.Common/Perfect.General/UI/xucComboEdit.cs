using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Perfect.Common
{
    public partial class xucComboEdit : DevExpress.XtraEditors.ComboBoxEdit
    {
        public xucComboEdit()
        {
            InitializeComponent();
            base.ForeColor = Color.DarkGray;
            base.Text= _defaultText;
            base.ForeColor = Color.DarkGray;
        }

        protected override void OnTextChanged(EventArgs e)
        {
           if (base.Text.Length == 0)
            {
                base.Text = _defaultText;
                base.ForeColor = Color.DarkGray;
            }
            else
            {
                base.ForeColor = Color.Black;
            }
        }
        
        protected override void OnLeave(EventArgs e)
        {
            if (base.Text.Length == 0)
            {
                base.Text = _defaultText;
                base.ForeColor = Color.DarkGray;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (base.Text == _defaultText)
            {
                base.Text = "";
            }
            base.ForeColor = Color.Black;
        }

        private string _defaultText;

        public string DefaultText
        {
            get { return _defaultText; }
            set { _defaultText=value;
            base.Text = _defaultText;
                base.Properties.NullText = _defaultText;
                base.Properties.NullValuePrompt = _defaultText;
            }
        }

        public override sealed string Text
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
