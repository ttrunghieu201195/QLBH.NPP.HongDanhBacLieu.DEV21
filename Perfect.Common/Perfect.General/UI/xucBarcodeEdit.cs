using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using Perfect.Utils.UI.BarcodeLib;

namespace Perfect.Common.UI
{
    //[ToolboxItem(true),
    // DefaultProperty("Text"),
    // DefaultEvent("TextChanged"),
    // ToolboxBitmap(typeof(resfinder), "Perfect.Common.Images.XRBarCode.bmp")]
    // //ToolboxBitmap(typeof(Icon), "Perfect.Common.UI.Barcode.ico")]
    public partial class xucBarcodeEdit : DevExpress.XtraEditors.PictureEdit
    {
        public xucBarcodeEdit()
        {
            Barcode = new BarcodeEdit("Barcode",BarCodeStyles.CODE128);
            InitializeComponent();
            //Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            
            this.Controls.Add(btnPrint);
            Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        public xucBarcodeEdit(IContainer icContainer)
        {
            Barcode = new BarcodeEdit("Barcode",BarCodeStyles.CODE128);
            this.components = icContainer;
            InitializeComponent();
            this.Controls.Add(btnPrint);
            Barcode.Styles = BarCodeStyles.CODE128;
            Barcode.Text = Name;
            Barcode.Title = Name;
            Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            //btnPrint.Visible = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            //this.Controls.Clear();
            //btnPrint.Visible = false;
        }


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Barcode.Text = Text;
            Update();
        }
        

        public string Title
        {
            get
            {
                return Barcode.Title;
            }
            set
            {
                Barcode.Title = value;
                Update();
            }
        }

        public Font TitleFont
        {
            get
            {
                return Barcode.Font;
            }
            set
            {
                Barcode.Font = value;
                Update();
            }
        }

        public Font TextFont
        {
            get
            {
                return Barcode.TextFont;
            }
            set
            {
                Barcode.TextFont = value;
                Update();
            }
        }

        public ImageFormat ImageFormat
        {
            get
            {
                return Barcode.ImageFormat;
            }
            set
            {
                Barcode.ImageFormat = value;
               // Update();
            }
        }

        public BarCodeStyles Styles
        {
            get
            {
                return Barcode.Styles;
            }
            set
            {
                Barcode.Styles = value;
                Update();
            }
        }

        internal void SetText(string text)
        {
            Barcode.Text = text;
        }

        public string XML
        {
            get
            {
                return Barcode.XML;
            }
        }

        public double EncodingTime
        {
            get
            {
                return Barcode.EncodingTime;
            }
            set
            {
                Barcode.EncodingTime = value;
                Update();
            }
        }

        public bool ShowText
        {
            get
            {
                return Barcode.ShowText;
            }
            set
            {
                Barcode.ShowText = value;
                Update();
            }
        }

        public new Color BackColor
        {
            get
            {
                return Barcode.BackColor;
            }
            set
            {
                Barcode.BackColor = value;
                Update();
            }
        }

        public new Color ForeColor
        {
            get
            {
                return Barcode.ForeColor;
            }
            set
            {
                Barcode.ForeColor = value;
                Update();
            }
        }

        public Image EncodedImage
        {
            get
            {
                return Barcode.EncodedImage;
            }
           
        }

        public string EncodedValue
        {
            get
            {
                return Barcode.EncodedValue;
            }
            
        }

        public string FormattedData
        {
            get
            {
                return Barcode.FormattedData;
            }
        }
        
        public string Value
        {
            get
            {
                return Barcode.Text;
            }
            set
            {
                Barcode.Text = value;
                Update();
            }
        }

        public BarcodeEdit Barcode { get; private set; }

        public string CAMCode
        {
            get { return Barcode.CAM_Code;}
           
        }

        public bool Active { get; set; }

        public Size BarcodeSize
        {
            get { return new Size(Barcode.Width,Barcode.Height); }
            set {
                    Barcode.Width = value.Width;
                    Barcode.Height = value.Height;
                }
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);
            Barcode.Width = Width;
            Barcode.Height = Height;
            Update();
            
        }

        public new void Update()
        {
            if (Active)
            {
                Image = Barcode.Encode(Barcode.Styles, Barcode.Text);
            }
        }
    }
    
}

internal class resfinder
{
    // Trick from Bob Powell
}