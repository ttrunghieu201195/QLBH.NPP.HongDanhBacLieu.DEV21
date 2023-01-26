using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Perfect.Common.UI
{
    public partial class xucDateTimeSelectEdit : DevExpress.XtraEditors.ComboBoxEdit
    {
        public delegate void DataTimeChangedEventHander(object  sender,DateTime Begin, DateTime To);

        public event DataTimeChangedEventHander DataTimeChanged;

        private void RaiseDataTimeChangedEventHander(DateTime Begin, DateTime To)
        {
            if (DataTimeChanged!=null)
            DataTimeChanged(this, Begin, To);
        }

        private DateTime _begin;
        private DateTime _to;


        public xucDateTimeSelectEdit()
        {
            InitializeComponent();
            base.ForeColor = Color.DarkGray;
            base.Text = _defaultText;
            base.ForeColor = Color.DarkGray;
            Properties.Items.Clear();
            Properties.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Quý này",
            "Năm nay",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
        }

        void SetDateTime(string text)
        {
           if (text=="Hôm nay")
           {
               
               From = DateTime.Now;
               To = DateTime.Now;
           }
           else if (text=="Tuần này")
           {
               int _day = (int)DateTime.Now.DayOfWeek;
               To = DateTime.Now.AddDays(_day == 0 ? 0 : 7 - _day);
               From = To.AddDays(-6);
               //From=DateAndTime.DateAdd(DateInterval.Day,-DateAndTime.Weekday(DateTime.Now, FirstDayOfWeek.Monday),DateTime.Now);
               //To=DateAndTime.DateAdd(DateInterval.Day,DateAndTime.Weekday(DateTime.Now, FirstDayOfWeek.Monday),DateTime.Now);
           }
           else if (text=="Tháng này")
           {
               From=new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
               To = From.AddMonths(1).AddDays(-1);
           }
           else if (text=="Quý này")
           {
               if (DateTime.Now.Month>=1 & DateTime.Now.Month<=3)
               {
                   From = new DateTime(DateTime.Now.Year, 1, 1);
                   To = From.AddMonths(3).AddDays(-1);
               }
               else if (DateTime.Now.Month>=4 & DateTime.Now.Month<=6)
               {
                   From = new DateTime(DateTime.Now.Year, 4, 1);
                   To = From.AddMonths(3).AddDays(-1);
               }
                else if (DateTime.Now.Month>=7 & DateTime.Now.Month<=9)
               {
                   From = new DateTime(DateTime.Now.Year, 7, 1);
                   To = From.AddMonths(3).AddDays(-1);
               }
                else
                {
                    From = new DateTime(DateTime.Now.Year, 10, 1);
                   To = From.AddMonths(3).AddDays(-1);
                }

           }
           else if (text=="Năm nay")
           {
               From=new DateTime(DateTime.Now.Year,1,1);
               To = From.AddMonths(12).AddDays(-1);
           }
           else if (text=="Tháng 1")
           {
               From=new DateTime(DateTime.Now.Year,1,1);
               To = From.AddMonths(1).AddDays(-1);
           }
           else if (text=="Tháng 2")
           {
               From=new DateTime(DateTime.Now.Year,2,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 3")
           {
               From=new DateTime(DateTime.Now.Year,3,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 4")
           {
               From=new DateTime(DateTime.Now.Year,4,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 5")
           {
               From=new DateTime(DateTime.Now.Year,5,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 6")
           {
               From=new DateTime(DateTime.Now.Year,6,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 7")
           {
               From=new DateTime(DateTime.Now.Year,7,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 8")
           {
               From=new DateTime(DateTime.Now.Year,8,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 9")
           {
               From=new DateTime(DateTime.Now.Year,9,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 10")
           {
               From=new DateTime(DateTime.Now.Year,10,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 11")
           {
               From=new DateTime(DateTime.Now.Year,11,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Tháng 12")
           {
               From=new DateTime(DateTime.Now.Year,12,1);
               To = From.AddMonths(1).AddDays(-1);
           }
            else if (text=="Quý 1")
           {
               From=new DateTime(DateTime.Now.Year,1,1);
               To = From.AddMonths(3).AddDays(-1);
           }
             else if (text=="Quý 2")
           {
               From=new DateTime(DateTime.Now.Year,4,1);
               To = From.AddMonths(3).AddDays(-1);
           }
           else if (text == "Quý 3")
           {
               From = new DateTime(DateTime.Now.Year, 7, 1);
               To = From.AddMonths(3).AddDays(-1);
           }
           else if (text == "Quý 4")
           {
               From = new DateTime(DateTime.Now.Year, 10, 1);
               To = From.AddMonths(3).AddDays(-1);
           }
           else
           {
               From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
               To = From.AddMonths(1).AddDays(-1);
           }
            
            RaiseDataTimeChangedEventHander(_begin,_to);
        }

        public override int SelectedIndex
        {
            get
            {
                SetDateTime(base.Text);
                return base.SelectedIndex;
            }
            set
            {
                base.SelectedIndex = value;
                SetDateTime(base.Text);
            }
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
            set
            {
                _defaultText = value;
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

        public DateTime From
        {
            get { return _begin; }
            set { _begin = value; }
        }

        public DateTime To
        {
            get { return _to; }
            set { _to = value; }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
