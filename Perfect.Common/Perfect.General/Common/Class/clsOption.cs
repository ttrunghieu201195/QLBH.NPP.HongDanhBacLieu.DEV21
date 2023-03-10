using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Globalization;
using DevExpress.Utils;
using Perfect.Common.Base;


namespace Perfect.Common
{
    public enum EnumRefType
    {
        
        StockInit = 0,
        StockInward = 1,
        StockOutward = 2,
        StockBuild = 3,
        StockAssembly = 4,
        Adjustment = 5,
        OutwardPacket = 6,
        TransferPack1 = 7,
        TransferPack2 = 8,
        StockTransfer = 9,
        SaleCafeBar=10,

        SaleNormal = 21,
        Buy=23,
        NhapBaoBi = 44,
        NhapTaiChe = 45,
        XuatBaoBi = 46,
        XuatTaiChe = 47,
        SalesOrder = 48
        


        
    }

    public enum Column
    {
        None = 0,
        Quantity = 1,
        Price = 2,
        Amount = 3,
        ID = 4,
        Lock = 5
    }

    public enum ListType
    {
        General = 0,
        Detail = 1,
        Merrial=2
    }

    public enum Actions
    {
        Add = 0,
        Update = 1,
        Change = 2,
        Delete = 3,
        AddNew=4,
        None=5
    }

    public enum CloseOrNew
    { 
        None=0,
        New=1,
        Close=2
    }

    public enum VoucherType
    { 
        InvoiceInward=1,
        InvoiceOutward=2,
        Voucher=3,
        Inward=11,
        Outward=21,
        Receipts=3,
        Payments=4
    }

    
    public class clsOption
    {
        
        public class Regional
        {
            private static bool m_IsQuestion = true;
            private static string m_DecimalSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            private static bool m_IsMsgBoxResult = true;
            private static string m_DigitGroupSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            private static int m_Decimals = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
            private static string m_DateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            private static string m_FormatDate = "dd/MM/yyyy";
            private static FormatType m_DateFormatType = FormatType.Custom;
            private static string m_FormatNumber = "##,##0.###";
            public static string FormatNumber
            {
                get
                {
                    
                    string Result = "##,##0.";
                    for (int i = 0; i < m_Decimals; i++)
                    {
                        Result += "#";
                    }
                    m_FormatNumber = Result;
                    return Result;
                }
                set { m_FormatNumber = value; }
            }
            public static string StringFormat
            {
                get
                {
                    return "{0:" + FormatNumber + "}";
                }

            }
            public static FormatType DateFormatType
            {
                get { return m_DateFormatType; }
                set { m_DateFormatType = value; }
            }
            public static string FormatDate
            {
                get
                {
                    if (m_DateFormatType == FormatType.DMY)
                    {
                        m_FormatDate = FormatType.DMY.ToString().Replace("/", m_DateSaparator);
                        return m_FormatDate;
                    }
                    else if (m_DateFormatType == FormatType.MDY)
                    {
                        m_FormatDate = FormatType.MDY.ToString().Replace("/", m_DateSaparator);
                        return m_FormatDate;
                    }
                    else if (m_DateFormatType == FormatType.YMD)
                    {
                        m_FormatDate = FormatType.YMD.ToString().Replace("/", m_DateSaparator);
                        return m_FormatDate;
                    }
                    else
                    {
                        return m_FormatDate;
                    }

                }
                set
                {
                    m_DateFormatType = FormatType.Custom;
                    m_FormatDate = value;
                }
            }
            public static string DateSaparator
            {
                get { return m_DateSaparator; }
                set { m_DateSaparator = value; }
            }
            public static int Decimals
            {
                get { return m_Decimals; }
                set { m_Decimals = value; }
            }
            public static string DigitGroupSymbol
            {
                get { return m_DigitGroupSymbol; }
                set { m_DigitGroupSymbol = value; }
            }
            public static string DecimalSymbol
            {
                get { return m_DecimalSymbol; }
                set { m_DecimalSymbol = value; }
            }
            public static bool IsQuestion
            {
                get { return m_IsQuestion; }
                set { m_IsQuestion = value; }
            }
            public static bool IsMsgBoxResult
            {
                get { return m_IsMsgBoxResult; }
                set { m_IsMsgBoxResult = value; }
            }
        }

        public enum FormatType
        {
            DMY = 1,
            MDY = 2,
            YMD = 3,
            Custom = 0
        }        

        public class Number
        {
            private static string m_DecimalSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            private static string m_DigitGroupSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            private static int m_Decimals = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
            private static string m_FrefixSymbol = "";
            private static string m_SuffixSymbol = "";
            private static string m_FormatNumber = "##,##0.###";
            public static string Format
            {
                get
                {
                    string Result = "##,##0." ;
                    for (int i = 0; i < m_Decimals; i++)
                    {
                        Result += "#";
                    }
                    m_FormatNumber = m_FrefixSymbol + Result + m_SuffixSymbol;
                    return m_FormatNumber;
                }
                set { m_FormatNumber = value; }
            }
            public static string FormatString
            {
                get
                {
                    return "{0:" + Format + "}";
                }

            }

            public static string PercentFormatString
            {
                get
                {
                    return "{0:" + Format + "} %";
                }

            }  
                  
            public static int Decimals
            {
                get { return m_Decimals; }
                set { m_Decimals = value; }
            }
            public static string DigitGroupSymbol
            {
                get { return m_DigitGroupSymbol; }
                set { m_DigitGroupSymbol = value; }
            }
            public static string DecimalSymbol
            {
                get { return m_DecimalSymbol; }
                set { m_DecimalSymbol = value; }
            }
            public static string FrefixSymbol
            {
                get { return m_FrefixSymbol; }
                set { m_FrefixSymbol = value; }
            }
            public static string SuffixSymbol
            {
                get { return m_SuffixSymbol; }
                set { m_SuffixSymbol = value; }
            }
        }

        public class DateTime
        {

            private static string m_DateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            private static string m_FormatDate = "dd/MM/yyyy";
            private static int m_DayLength = 2;
            private static int m_MonthLength = 2;
            private static int m_YearLength = 4;
            private static FormatType m_DateFormatType = FormatType.Custom;                     
            public static FormatType FormatType
            {
                get { return m_DateFormatType; }
                set { m_DateFormatType = value; }
            }
            private static string GetDay(bool DateSaparator)
            {
                string Result = "";
                for (int i = 0; i < m_DayLength; i++)
                {
                    Result += "d";
                }
                if (DateSaparator) Result += m_DateSaparator;
                return Result;
            }
            private static string GetMonth(bool DateSaparator)
            {
                string Result = "";
                for (int i = 0; i < m_MonthLength; i++)
                {
                    Result += "M";
                }
                if (DateSaparator) Result += m_DateSaparator;
                return Result;
            }
            private static string GetYear(bool DateSaparator)
            {
                string Result = "";
                for (int i = 0; i < m_YearLength; i++)
                {
                    Result += "y";
                }
                if (DateSaparator) Result += m_DateSaparator;
                return Result;
            }
            public static string Format
            {

                get
                {
                    string Day;
                    string Month;
                    string Year;
                    if (m_DateFormatType == FormatType.DMY)
                    {
                        Day= GetDay(true);  
                        Month=GetMonth(true);
                        Year=GetYear(false);
                        m_FormatDate = Day.Length == 1 ? "" : Day + (Month.Length == 1 ? "" : Month) + Year;
                        if (m_FormatDate.Trim() == string.Empty) m_FormatDate = "dd/MM/yyyy";                            
                        return m_FormatDate;
                    }
                    else if (m_DateFormatType == FormatType.MDY)
                    {
                        Day = GetDay(true);
                        Month = GetMonth(true);
                        Year = GetYear(false);
                        m_FormatDate = Month.Length == 1 ? "" : Month + (Day.Length == 1 ? "" : Day) + Year;
                        if (m_FormatDate.Trim() == string.Empty) m_FormatDate = "MM/dd/yyyy";
                       
                        return m_FormatDate;
                    }
                    else if (m_DateFormatType == FormatType.YMD)
                    {
                        Day = GetDay(false);
                        Month = GetMonth(true);
                        Year = GetYear(true);
                        m_FormatDate = Year.Length == 1 ? "" : Year + (Month.Length == 1 ? "" : Month) + Day;
                        if (m_FormatDate.Trim()== string.Empty) m_FormatDate = "yyyy/MM/dd";                       
                        return m_FormatDate;
                    }
                    else
                    {
                        return m_FormatDate;
                    }

                }
                set
                {
                    m_DateFormatType = FormatType.Custom;
                    m_FormatDate = value;
                }
            }
            public static string FormatString
            {
                get { return "{0:" + Format + "}"; }
            }
            public static string Saparator
            {
                get { return m_DateSaparator; }
                set { m_DateSaparator = value; }
            }
            public static int DayLength
            {
                get { return m_DayLength; }
                set { m_DayLength = value; }
            }
            public static int MonthLength
            {
                get { return m_MonthLength; }
                set { m_MonthLength = value; }
            }
            public static int YearLength
            {
                get { return m_YearLength; }
                set { m_YearLength = value; }
            }        
        }

        public class System2
        {
            private static bool m_IsQuestion = true;
            private static bool m_IsMsgBoxResult = true;
            private static bool m_IsMsgBoxError = true;
            public static bool IsQuestion
            {
                get { return m_IsQuestion; }
                set { m_IsQuestion = value; }
            }
            public static bool IsMsgBoxResult
            {
                get { return m_IsMsgBoxResult; }
                set { m_IsMsgBoxResult = value; }
            }
            public static bool IsMsgBoxError
            {
                get { return m_IsMsgBoxError; }
                set { m_IsMsgBoxError = value; }
            }
        }

        public class Parameter
        {
            static string m_Manager = "Giám đốc";
            public static string Manager
            {
                get { return m_Manager; }
                set { m_Manager = value; }
            } 

        }

        private static DevExpress.Utils.WaitDialogForm dlg = null;

        
        public static void CreateWaitDialog()
        {
            if (dlg==null)
                dlg = new DevExpress.Utils.WaitDialogForm("Đang nạp dữ liệu ...", "Vui lòng đợi trong giây lát...");
        }

        public static void SetWaitDialogCaption(string fCaption)
        {
            if (dlg != null)
                dlg.Caption = fCaption;
            else
            {
                dlg = new DevExpress.Utils.WaitDialogForm(fCaption, "Vui lòng đợi trong giây lát...");
            }
        }

        public static void DoHide()
        {
            // this.VisibleChanged += new EventHandler(OnVisibleChanged);
            if (dlg != null)
            {
                dlg.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(dlg_FormClosing);
                dlg.Close();
            }
        }

        static void dlg_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            dlg = null;
        }
        ~clsOption()
        {
            if (dlg != null)
            {
                dlg.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(dlg_FormClosing);
                dlg.Close();
            }
        }



    }

    public class Options
    {
        public static int TypeSoft { get; set; }
        private static XProgressForm _progressForm = new XProgressForm();
        public static XProgressForm FormProcess
        {
            get { return _progressForm; }
            set { _progressForm = value; }
        }
        public class Regional
        {
            

            private static bool _mIsQuestion = true;
            private static string _mDecimalSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            private static bool _mIsMsgBoxResult = true;
            private static string _mDigitGroupSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            private static int _mDecimals = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
            private static string _mDateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            private static string _mFormatDate = "dd/MM/yyyy";
            private static FormatType _mDateFormatType = FormatType.Custom;
            private static string _mFormatNumber = "##,##0.###";
            private static int _mNumberDecimalDigits = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;

            public static string FormatNumber
            {
                get
                {
                    string Result = "##,##0.";
                    for (int i = 0; i < _mDecimals; i++)
                    {
                        Result += "#";
                    }
                    _mFormatNumber = Result;
                    return Result;
                }
                set { _mFormatNumber = value; }
            }
            public static string StringFormat
            {
                get
                {
                    return "{0:" + FormatNumber + "}";
                }

            }
            public static FormatType DateFormatType
            {
                get { return _mDateFormatType; }
                set { _mDateFormatType = value; }
            }
            public static string FormatDate
            {
                get
                {
                    if (_mDateFormatType == FormatType.Dmy)
                    {
                        _mFormatDate = FormatType.Dmy.ToString().Replace("/", _mDateSaparator);
                        return _mFormatDate;
                    }
                    else if (_mDateFormatType == FormatType.Mdy)
                    {
                        _mFormatDate = FormatType.Mdy.ToString().Replace("/", _mDateSaparator);
                        return _mFormatDate;
                    }
                    else if (_mDateFormatType == FormatType.Ymd)
                    {
                        _mFormatDate = FormatType.Ymd.ToString().Replace("/", _mDateSaparator);
                        return _mFormatDate;
                    }
                    else
                    {
                        return _mFormatDate;
                    }

                }
                set
                {
                    _mDateFormatType = FormatType.Custom;
                    _mFormatDate = value;
                }
            }
            public static string DateSaparator
            {
                get { return _mDateSaparator; }
                set { _mDateSaparator = value; }
            }
            public static int Decimals
            {
                get { return _mDecimals; }
                set { _mDecimals = value; }
            }
            public static string DigitGroupSymbol
            {
                get { return _mDigitGroupSymbol; }
                set { _mDigitGroupSymbol = value; }
            }
            public static string DecimalSymbol
            {
                get { return _mDecimalSymbol; }
                set { _mDecimalSymbol = value; }
            }
            public static bool IsQuestion
            {
                get { return _mIsQuestion; }
                set { _mIsQuestion = value; }
            }
            public static bool IsMsgBoxResult
            {
                get { return _mIsMsgBoxResult; }
                set { _mIsMsgBoxResult = value; }
            }

            public static int NumberDecimalDigits
            {
                get { return _mNumberDecimalDigits; }
                set { _mNumberDecimalDigits = value; }
            }

           
        }

        public enum FormatType
        {
            Dmy = 1,
            Mdy = 2,
            Ymd = 3,
            Custom = 0
        }        

        public class Number
        {
            private static string _mDecimalSymbol = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            private static string _mDigitGroupSymbol = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator;
            private static int _mDecimals = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalDigits;
            private static string _mFrefixSymbol = "";
            private static string _mSuffixSymbol = "";
            private static string _mFormatNumber = "##,##0.###";
            private static bool _mAutoRound = true;

            public static string Format
            {
                get
                {
                    string Result = "##,##0." ;
                    for (int i = 0; i < _mDecimals; i++)
                    {
                        Result += _mAutoRound?"#":"0";
                    }
                    _mFormatNumber = _mFrefixSymbol + Result + _mSuffixSymbol;
                    return _mFormatNumber;
                }
                set { _mFormatNumber = value; }
            }

            

            public static string FormatString
            {
                get
                {
                    return "{0:" + Format + "}";
                }

            }                                    
            public static int Decimals
            {
                get { return _mDecimals; }
                set { _mDecimals = value; }
            }
            public static string DigitGroupSymbol
            {
                get { return _mDigitGroupSymbol; }
                set { _mDigitGroupSymbol = value; }
            }
            public static string DecimalSymbol
            {
                get { return _mDecimalSymbol; }
                set { _mDecimalSymbol = value; }
            }
            public static string FrefixSymbol
            {
                get { return _mFrefixSymbol; }
                set { _mFrefixSymbol = value; }
            }
            public static string SuffixSymbol
            {
                get { return _mSuffixSymbol; }
                set { _mSuffixSymbol = value; }
            }

            public static bool AutoRound
            {
                get { return _mAutoRound; }
                set { _mAutoRound = value; }
            }
        }

        public class DateTime
        {

            private static string m_DateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            private static string m_FormatDate = "dd/MM/yyyy";
            private static int m_DayLength = 2;
            private static int m_MonthLength = 2;
            private static int m_YearLength = 4;
            private static FormatType m_DateFormatType = FormatType.Custom;                     
            public static FormatType FormatType
            {
                get { return m_DateFormatType; }
                set { m_DateFormatType = value; }
            }
            private static string GetDay(bool dateSaparator)
            {
                string result = "";
                for (int i = 0; i < m_DayLength; i++)
                {
                    result += "d";
                }
                if (dateSaparator) result += m_DateSaparator;
                return result;
            }
            private static string GetMonth(bool dateSaparator)
            {
                string result = "";
                for (int i = 0; i < m_MonthLength; i++)
                {
                    result += "M";
                }
                if (dateSaparator) result += m_DateSaparator;
                return result;
            }
            private static string GetYear(bool dateSaparator)
            {
                string result = "";
                for (int i = 0; i < m_YearLength; i++)
                {
                    result += "y";
                }
                if (dateSaparator) result += m_DateSaparator;
                return result;
            }
            public static string Format
            {

                get
                {
                    string day;
                    string month;
                    string year;
                    if (m_DateFormatType == FormatType.Dmy)
                    {
                        day= GetDay(true);  
                        month=GetMonth(true);
                        year=GetYear(false);
                        m_FormatDate = day.Length == 1 ? "" : day + (month.Length == 1 ? "" : month) + year;
                        if (m_FormatDate.Trim() == string.Empty) m_FormatDate = "dd/MM/yyyy";                            
                        return m_FormatDate;
                    }
                    else if (m_DateFormatType == FormatType.Mdy)
                    {
                        day = GetDay(true);
                        month = GetMonth(true);
                        year = GetYear(false);
                        m_FormatDate = month.Length == 1 ? "" : month + (day.Length == 1 ? "" : day) + year;
                        if (m_FormatDate.Trim() == string.Empty) m_FormatDate = "MM/dd/yyyy";
                       
                        return m_FormatDate;
                    }
                    else if (m_DateFormatType == FormatType.Ymd)
                    {
                        day = GetDay(false);
                        month = GetMonth(true);
                        year = GetYear(true);
                        m_FormatDate = year.Length == 1 ? "" : year + (month.Length == 1 ? "" : month) + day;
                        if (m_FormatDate.Trim()== string.Empty) m_FormatDate = "yyyy/MM/dd";                       
                        return m_FormatDate;
                    }
                    else
                    {
                        return m_FormatDate;
                    }

                }
                set
                {
                    m_DateFormatType = FormatType.Custom;
                    m_FormatDate = value;
                }
            }
            public static string FormatString
            {
                get { return "{0:" + Format + "}"; }
            }
            public static string Saparator
            {
                get { return m_DateSaparator; }
                set { m_DateSaparator = value; }
            }
            public static int DayLength
            {
                get { return m_DayLength; }
                set { m_DayLength = value; }
            }
            public static int MonthLength
            {
                get { return m_MonthLength; }
                set { m_MonthLength = value; }
            }
            public static int YearLength
            {
                get { return m_YearLength; }
                set { m_YearLength = value; }
            }        
        }

        public class System2
        {
            private static bool m_IsQuestion = true;
            private static bool m_IsMsgBoxResult = true;
            private static bool m_IsMsgBoxError = true;
            public static bool IsQuestion
            {
                get { return m_IsQuestion; }
                set { m_IsQuestion = value; }
            }
            public static bool IsMsgBoxResult
            {
                get { return m_IsMsgBoxResult; }
                set { m_IsMsgBoxResult = value; }
            }
            public static bool IsMsgBoxError
            {
                get { return m_IsMsgBoxError; }
                set { m_IsMsgBoxError = value; }
            }
        }

        public class Parameter
        {
            static string m_Manager = "Giám đốc";
            public static string Manager
            {
                get { return m_Manager; }
                set { m_Manager = value; }
            } 

        }

        private static DevExpress.Utils.WaitDialogForm m_Dlg = null;
        private static string m_FTitle = "Vui lòng đợi trong giây lát...";
        private static string m_Caption = "Đang nạp dữ liệu ...";

        static Options()
        {
            SoftId = "QLK";
            TypeSoft = 0;
        }

        public static string SoftId { get; set; }

        
        public static string Caption
        {
            get { return m_Caption; }
            set { m_Caption = value; }
        }

        public static string Title
        {
            get { return m_FTitle; }
            set { m_FTitle = value; }
        }

        public static void CreateWaitDialog()
        {
            CreateWaitDialog(Caption);
        }

        public static void CreateWaitDialog(string fCaption)
        {
            CreateWaitDialog(fCaption, Title);
        }

        public static void CreateWaitDialog(string fCaption,string fTitle)
        {
            Title = fTitle;
            if (m_Dlg == null)
                m_Dlg = new DevExpress.Utils.WaitDialogForm(fCaption,fTitle);
            m_Dlg.AllowFormSkin = true;
        }

        public static void SetWaitDialogCaption()
        {
            SetWaitDialogCaption(Caption);
        }

        public static void SetWaitDialogCaption(string fCaption)
        {
            Caption = fCaption;
            if (m_Dlg != null)
            {
                m_Dlg.Visible = true;
                m_Dlg.Caption = fCaption;
            }
            else
            {
                CreateWaitDialog();
            }
        }

        public static void Show(string fCaption)
        {
            SetWaitDialogCaption(fCaption);
        }

        public static void Show()
        {
            SetWaitDialogCaption();
        }
        
        public static void CloseDialog()
        {
            // this.VisibleChanged += new EventHandler(OnVisibleChanged);
            if (m_Dlg != null)
            {
                m_Dlg.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(dlg_FormClosing);
                m_Dlg.Close();
            }
        }

        public static void HideDialog()
        {
            // this.VisibleChanged += new EventHandler(OnVisibleChanged);
            if (m_Dlg != null)
            {
                m_Dlg.Hide();
            }
        }

        public static void Close()
        {
            CloseDialog();
        }

        static void dlg_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            m_Dlg = null;
        }

        ~Options()
        {
            if (m_Dlg != null)
            {
                m_Dlg.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(dlg_FormClosing);
                m_Dlg.Close();
            }
        }

       

    }

    public class RowClickEventArgs
    {
        private int m_RowIndex;
        public int RowIndex
        {
            get { return m_RowIndex; }
            set { m_RowIndex = value; }
        }
        private int m_ColumnIndex;
        public int ColumnIndex
        {
            get { return m_ColumnIndex; }
            set { m_ColumnIndex = value; }
        }
        private string m_FieldName;
        public string FieldName
        {
            get { return m_FieldName; }
            set { m_FieldName = value; }
        }
        public RowClickEventArgs(int RowIndex, int ColumnIndex, string FieldName)
        {
            m_RowIndex = RowIndex;
            m_ColumnIndex = ColumnIndex;
            m_FieldName = FieldName;
        }
        public RowClickEventArgs(int RowIndex, int ColumnIndex)
        {
            m_RowIndex = RowIndex;
            m_ColumnIndex = ColumnIndex;
            m_FieldName = "";
        }
        public RowClickEventArgs(int rowIndex, string fieldName)
        {
            m_RowIndex = rowIndex;
            m_ColumnIndex = -1;
            m_FieldName = fieldName;
        }
        public RowClickEventArgs()
        {
            m_RowIndex = -1;
            m_ColumnIndex = -1;
            m_FieldName = "";
        }
        public void Reset()
        {
            m_RowIndex = -1;
            m_ColumnIndex = -1;
            m_FieldName = "";
        }
        public void Set(int RowIndex, int ColumnIndex, string FieldName)
        {
            m_RowIndex = RowIndex;
            m_ColumnIndex = ColumnIndex;
            m_FieldName = FieldName;
        }
    }
  
    #region Deletegate
    public delegate void RowClickEventHander(object sender, RowClickEventArgs e);
    //public delegate void RowDoubleClickEventHander(object sender, RowClickEventArgs e);
    public delegate void ButtonClickEventHander(object sender);    
    public delegate void DeletedEventHander(object sender, RowClickEventArgs e);
    public delegate void ListKeyDownEventHander(object sender, System.Windows.Forms.KeyEventArgs key, RowClickEventArgs e);
    
    #endregion

    #region

    public class MyParamaters
    {
        private static string m_UiLanguage = "VN";
        private static string m_ReportLanguage = "VN";
        private static string m_ReportLocalization = "vi-VN";
        private static string m_Localization = "vi-VN";
        private static string m_OsName = "";

        static MyParamaters()
        {
            IsSetHomePage = true;
        }


        public static string UiLanguage
        {
            get { return m_UiLanguage; }
            set { m_UiLanguage = value; }
        }

        public static string ReportLanguage
        {
            get { return m_ReportLanguage; }
            set { m_ReportLanguage = value; }
        }

        public static string ReportLocalization
        {
            get { return m_ReportLocalization; }
            set { m_ReportLocalization = value; }
        }

        public static string Localization
        {
            get { return m_Localization; }
            set { m_Localization = value; }
        }

        public static bool IsCreateShortcut { get; set; }

        public static bool IsAutoUpdate { get; set; }

        public static string OsName
        {
            get { return m_OsName; }
            set { m_OsName = value; }
        }

        public static bool IsDefault { get; set; }

        public static bool IsClearData { get; set; }

        public static bool IsClearHistory { get; set; }

        public static bool IsShowError { get; set; }

        public static bool IsResetLayout { get; set; }

        public static bool IsSetHomePage { get; set; }

        public static bool IsSimple { get; set; }

        public static bool IsShowWarning { get; set; }

        public static bool IsPacket { get; set; }

        private static bool m_isClassic=false;
        public static bool IsClassic
        {
            get { return m_isClassic; }
            set { m_isClassic = value; }
        }

        public static bool Offline { get; set; }

        public static bool IsSale { get; set; }

        public static bool IsBarCafe { get; set; }

        public static bool IsItemStock { get; set; }
    }
    
    #endregion
}
