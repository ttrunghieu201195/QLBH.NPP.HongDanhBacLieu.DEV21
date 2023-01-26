using System;
using DevExpress.XtraEditors;

namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    public partial class XfmOptionPrint : XtraForm
    {

        public string Option;
        public XfmOptionPrint()
        {
            InitializeComponent();
        }

        public delegate void OptionSelectEvenHandler(object o, string option);

        public event OptionSelectEvenHandler OptionSelect;

        public void OnOptionSelect(string option)
        {
            OptionSelectEvenHandler handler = OptionSelect;
            if (handler != null) handler(this, option);
        }

        private void BtPrintClick(object sender, EventArgs e)
        {
            Option = radioOption.SelectedIndex.ToString();
            Close();
        }
    }
}