using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraWizard;
using Microsoft.VisualBasic;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Security;

namespace Perfect.Dictionary
{
    public partial class xfmItemImport : XtraForm
    {
        #region Delegates

        public delegate void ItemCheckedEventHander(object sender);

        public delegate void ItemCheckingEventHander(
            object sender, int position, string errorText, int number, string description);

        #endregion

        private bool cancel = false;
        private bool Check = false;
        private int fail = 0;
        private bool finish = true;
        private int success = 0;
        private int warning = 0;

        public xfmItemImport()
        {
            InitializeComponent();
            //btnBrowse.Visible = true;
            //lcBar.Visibility = true;

            //btnCheck.Visible = true;
            ItemChecking += new ItemCheckingEventHander(xfmItemImport_ItemChecking);
            ItemChecked += new ItemCheckedEventHander(xfmItemImport_ItemChecked);
        }

        public event ItemCheckingEventHander ItemChecking;

        private void RaiseItemCheckingEventHander(int position, string errorText, int number, string description)
        {
            if (ItemChecking != null) ItemChecking(this, position, errorText, number, description);
        }

        public event ItemCheckedEventHander ItemChecked;

        private void RaiseItemCheckedEventHander()
        {
            if (ItemChecked != null) ItemChecked(this);
        }


        private void xfmItemImport_ItemChecked(object sender)
        {
            if (BarCheck.InvokeRequired)
            {
                var myRestore = new ItemCheckedEventHander(xfmItemImport_ItemChecked);
                Invoke(myRestore, new object[] { sender });
            }
            else
            {
                Check = true;
                wpCheck.AllowNext = true;
                wpCheck.AllowBack = true;
                BarCheck.Position = 0;
                lcCheck.Visibility = LayoutVisibility.Never;

                wpFinish.AllowNext = true;
                wpFinish.AllowBack = true;
                wpFinish.AllowCancel = true;
                finish = true;
                BarFinish.Position = 0;
                lcBarFinish.Visibility = LayoutVisibility.Never;
            }
        }

        private void xfmItemImport_ItemChecking(object sender, int position, string errorText, int number,
                                                string description)
        {
            if (BarCheck.InvokeRequired)
            {
                var myRestore = new ItemCheckingEventHander(xfmItemImport_ItemChecking);
                Invoke(myRestore, new object[] { sender, position, errorText, number, description });
            }
            else
            {
                BarCheck.Position = (int)((double)position / (double)gbList.RowCount * 100);
                BarFinish.Position = BarCheck.Position;


                if (errorText == "OK")
                {
                    success++;
                    gbList.SetRowCellValue(position, "Error", 0);
                    gbList.UpdateCurrentRow();
                }
                else
                {
                    finish = true;
                    if (number == 1)
                    {
                        fail++;
                    }
                    else
                    {
                        warning++;
                    }

                    dsError.ERROR.AddERRORRow(errorText, "Dòng bị lỗi thứ " + position, description, number);
                    gbList.SetRowCellValue(position, "Error", number);
                    gbList.UpdateCurrentRow();
                }
                lblSuccess.Text = "Thành Công: " + success;
                lblFail.Text = "Thất Bại: " + fail;
                lblWarning.Text = "Cảnh Báo: " + warning;
                lblSuccess1.Text = "Thành Công: " + success;
                lblFail1.Text = "Thất Bại: " + fail;
            }
        }

        private void ReadData()
        {
            //this.Enabled = false;
            var ExcelDataReader = new ExcelDataReader(txtPath.Text);
            ExcelDataReader.ExcelReaderComplete +=
                new ExcelDataReader.ExcelReaderCompleteEventHander(ExcelDataReader_ExcelReaderComplete);
            ExcelDataReader.ExcelReaderError +=
                new ExcelDataReader.ExcelReaderErrorEventHander(ExcelDataReader_ExcelReaderError);
            ExcelDataReader.ExcelReaderProcess +=
                new ExcelDataReader.ExcelReaderProcessEventHander(ExcelDataReader_ExcelReaderProcess);
            ExcelDataReader.BusyStarted += new ExcelDataReader.BusyStartedEventHander(ExcelDataReader_BusyStarted);
            ExcelDataReader.BusyFinish += new ExcelDataReader.BusyFinishEventHander(ExcelDataReader_BusyFinish);

            var Thread =
                new Thread(delegate() { ExcelDataReader.ExcelReadByADO(txtPath.Text, lsSheet.SelectedItem.ToString()); });
            Thread.Start();
        }

        private void ExcelDataReader_BusyFinish(object sender)
        {
            if (Bar2.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.BusyFinishEventHander(ExcelDataReader_BusyFinish);
                Invoke(myRestore, new object[] { sender });
            }
            else
            {
                lcBar.Visibility = LayoutVisibility.Always;
                lcBar2.Visibility = LayoutVisibility.Never;
            }
        }

        private void ExcelDataReader_BusyStarted(object sender)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.BusyStartedEventHander(ExcelDataReader_BusyStarted);
                Invoke(myRestore, new object[] { sender });
            }
            else
            {
                lcBar.Visibility = LayoutVisibility.Never;
                lcBar2.Visibility = LayoutVisibility.Always;
            }
        }

        private void ExcelDataReader_ExcelReaderProcess(object sender, int Position)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.ExcelReaderProcessEventHander(ExcelDataReader_ExcelReaderProcess);
                Invoke(myRestore, new object[] { sender, Position });
            }
            else
            {
                Bar.Position = Position;
            }
        }

        private void ExcelDataReader_ExcelReaderError(object sender, string Message)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.ExcelReaderErrorEventHander(ExcelDataReader_ExcelReaderError);
                Invoke(myRestore, new object[] { sender, Message });
            }
            else
            {
                //btnBrowse.Enabled = true;
                //  this.Enabled = true;
                XtraMessageBox.Show("Lỗi:\n\t" + Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExcelDataReader_ExcelReaderComplete(object sender, DataTable dt)
        {
            if (Bar.InvokeRequired)
            {
                var myRestore = new ExcelDataReader.ExcelReaderCompleteEventHander(ExcelDataReader_ExcelReaderComplete);
                Invoke(myRestore, new object[] { sender, dt });
            }
            else
            {
                dsFormatChose.PRODUCT.Clear();
                dsFormatChose.PRODUCT.AddPRODUCTRow("<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>",
                                                    "<Không Chọn>", "<Không Chọn>", "<Không Chọn>");
                //dsFormatChose.Columns.Rows.Clear();
                //dsFormatChose.Columns.AddColumnsRow("-1", "<Không Chọn>");
                rpColumns.Items.Clear();
                rpColumns.Items.Add("<Không Chọn>");
                // rpColumns.Items.Add("<Tự Động>");
                if (dt != null)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        rpColumns.Items.Add(dt.Columns[i].Caption);

                        string temp = dt.Columns[i].Caption.ToLower();

                        if (dt.Columns[i].Caption.ToLower().IndexOf("mã") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Product_ID"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("tên") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Product_Name"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("tính chất") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Product_Type_ID"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("nhóm") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Product_Group_ID"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("kho") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Provider_ID"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "nhà sản xuất")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Manufacturer_ID"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "barcode")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Barcode"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "giá bán")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Sale_Price"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("xuất xứ") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Origin"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "kích thước")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Size"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "giá bán lẻ")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Retail_Price"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "giá hiện tại")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["CurrentCost"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "giá bình quân")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["AverageCost"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "bảo hành")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Warranty"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "thuế gtgt")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["VAT_ID"] = dt.Columns[i].Caption;
                        }
                        //else if (dt.Columns[i].Caption.ToLower() == "nhà phân phối")
                        //{
                        //    dsFormatChose.PRODUCT.Rows[0]["Customer_ID"] = dt.Columns[i].Caption;
                        //}
                        //else if (dt.Columns[i].Caption.ToLower() == "NPP")
                        //{
                        //    dsFormatChose.PRODUCT.Rows[0]["Customer_Name"] = dt.Columns[i].Caption;
                        //}

                        else if (dt.Columns[i].Caption.ToLower().IndexOf("tối thiểu") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["MinStock"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("tối đa") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["MaxStock"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "chiết khấu")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Discount"] = dt.Columns[i].Caption;
                        }

                        else if (dt.Columns[i].Caption.ToLower() == "màu")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Color"] = dt.Columns[i].Caption;
                        }

                        else if (dt.Columns[i].Caption.ToLower().IndexOf("tiêu hao") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["LimitOrders"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower().IndexOf("hsd") != -1)
                        {
                            dsFormatChose.PRODUCT.Rows[0]["ExpiryValue"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "đơn vị tính")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Unit_Name"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "đơn vị")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Unit"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "đơn vị quy đổi")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["UnitConvert"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "tỷ lệ quy đổi")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["UnitRate"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "số lượng")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Quantity"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "giá vốn")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Org_Price"] = dt.Columns[i].Caption;
                        }
                        else if (dt.Columns[i].Caption.ToLower() == "diễn giải")
                        {
                            dsFormatChose.PRODUCT.Rows[0]["Description"] = dt.Columns[i].Caption;
                        }
                    }
                    gcList.DataSource = dt;
                    gbList.Columns["Chọn"].ColVIndex = 0;
                    gbList.Columns["Error"].Visible = false;
                    gbList.Columns["ErrorText"].Visible = false;
                }
                // btnBrowse.Enabled = true;
                //Product_Init(gbList);                              
                lcBar.Visibility = LayoutVisibility.Never;
            }
        }

        protected void List_Init(AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].VisibleIndex)
                {
                    case 0:
                        dt.Columns[i].OptionsColumn.ReadOnly = false;
                        dt.Columns[i].OptionsColumn.AllowEdit = true;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Width = 50;
                        break;
                    case 1:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Width = 80;
                        break;
                    case 2:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        dt.Columns[i].Width = 80;
                        break;

                    case 3:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Width = 150;
                        break;
                    case 4:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Width = 80;
                        break;

                    case 5:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        dt.Columns[i].Width = 80;
                        break;
                    case 6:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        dt.Columns[i].Width = 80;
                        break;
                    case 7:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Width = 80;
                        break;
                    case 8:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;

                        dt.Columns[i].Width = 80;
                        break;
                    case 9:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;
                        dt.Columns[i].Width = 80;
                        break;
                    case 10:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Width = 80;
                        break;

                    default:
                        // dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        protected void Product_Init(AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].VisibleIndex)
                {
                    case 0:
                        dt.Columns[i].OptionsColumn.ReadOnly = false;
                        dt.Columns[i].OptionsColumn.AllowEdit = true;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Width = 50;
                        break;
                    case 1:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Width = 80;
                        break;
                    case 2:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Width = 150;
                        break;

                    case 3:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Width = 60;
                        break;
                    case 4:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Width = 80;
                        break;

                    case 5:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;


                        dt.Columns[i].Width = 80;
                        break;
                    case 6:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;


                        dt.Columns[i].Width = 80;
                        break;
                    case 7:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Width = 80;
                        break;
                    case 8:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        dt.Columns[i].Width = 80;
                        break;
                    case 9:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Width = 80;
                        break;
                    case 10:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Width = 80;
                        break;
                    case 11:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Width = 80;
                        break;
                    case 12:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Width = 80;
                        break;
                    case 13:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                        dt.Columns[i].Width = 80;
                        break;
                    case 14:
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Width = 80;
                        break;

                    default:
                        // dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        private void wcImport_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            if (e.Page == wpinput)
            {
                //lblMessage.Text = "Chọn tập tin nguồn";
            }
            else if (e.Page == wpBrowse)
            {
                //lblMessage.Text = "Danh sách dữ liệu trước nhập khẩu.";

                var fi = new FileInfo(txtPath.Text);
                if (!fi.Exists | lsSheet.SelectedItem == null)
                {
                    wcImport.SelectedPage = wpinput;
                }

                //wpBrowse.Text = "Excel Path: " + OpenFileDialog.FileName;
                ReadData();
                lcBar.Visibility = LayoutVisibility.Always;
            }
            else if (e.Page == wpCelMerge)
            {
                // lblMessage.Text = "Ghép trường dữ liệu.";
                //  MessageBox.Show("OK");
            }
            else if (e.Page == wpCheck)
            {
                // lblMessage.Text = "Kiểm tra dữ liệu.";
                if (Check) return;

                bool error = false;
                string temp;

                temp = gbColMerge.GetCellDisplayText(rowProduct_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    //XtraMessageBox.Show("Vui lòng ghép trường cho nhóm hàng", "Thông báo", MessageBoxButtons.OK,
                    //                  MessageBoxIcon.Warning);
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowProduct_ID.Properties, "Vui lòng ghép trường cho mã hàng hoá");
                    //return;
                }

                temp = gbColMerge.GetCellDisplayText(rowProduct_Name, 0);
                if (temp == "<Không Chọn>")
                {
                    //XtraMessageBox.Show("Vui lòng ghép trường cho nhóm hàng", "Thông báo", MessageBoxButtons.OK,
                    //                  MessageBoxIcon.Warning);
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowProduct_Name.Properties, "Vui lòng ghép trường cho tên hàng hoá");
                    //return;
                }


                temp = gbColMerge.GetCellDisplayText(rowProduct_Group_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    //XtraMessageBox.Show("Vui lòng ghép trường cho nhóm hàng", "Thông báo", MessageBoxButtons.OK,
                    //                  MessageBoxIcon.Warning);
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowProduct_Group_ID.Properties, "Vui lòng ghép trường cho nhóm hàng");
                    // return;
                }

                temp = gbColMerge.GetCellDisplayText(rowUnit, 0);
                if (temp == "<Không Chọn>")
                {
                    //XtraMessageBox.Show("Vui lòng ghép trường cho đơn vị", "Thông báo", MessageBoxButtons.OK,
                    //                  MessageBoxIcon.Warning);
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowUnit.Properties, "Vui lòng ghép trường cho đơn vị");
                    //return;
                }

                temp = gbColMerge.GetCellDisplayText(rowProvider_ID, 0);
                if (temp == "<Không Chọn>")
                {
                    wcImport.SelectedPage = wpCelMerge;
                    gbColMerge.SetRowError(rowProvider_ID.Properties, "Vui lòng ghép trường cho kho hàng");
                    // return;
                }

                if (error)
                {
                    XtraMessageBox.Show("Vui lòng ghép trường", "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                    ;
                }

                lblTotal.Text = "Tổng cộng: " + gbList.RowCount;
                fail = 0;
                success = 0;
                wpCheck.AllowNext = false;
                wpCheck.AllowBack = false;
                lcCheck.Visibility = LayoutVisibility.Always;

                var thread = new Thread(new ThreadStart(ExecuteCheck));
                thread.Start();
            }
            else if (e.Page == wpFinish)
            {
                // lblMessage.Text = "Nhập dữ liệu.";
                Check = true;
                lblTotal.Text = "Tổng cộng: " + gbList.RowCount;
                lblTotal1.Text = "Tổng cộng: " + gbList.RowCount;
                fail = 0;
                success = 0;
                warning = 0;
                wpFinish.AllowNext = false;
                wpFinish.AllowBack = false;
                wpFinish.AllowCancel = false;
                finish = false;

                lcBarFinish.Visibility = LayoutVisibility.Always;
                dsError.ERROR.Rows.Clear();
                var thread = new Thread(new ThreadStart(Execute));
                thread.Start();
            }
            else
            {
                lcBar.Visibility = LayoutVisibility.Never;
                lcBar2.Visibility = LayoutVisibility.Never;
            }
        }


        private void Execute()
        {
            string result = "";
            finish = false;
            var dt = (DataTable)gcList.DataSource;

            if (dt != null)
            {
                var product = new PRODUCT();
                var mySql = new SqlHelper();
                string temp;
                object ob;

                string stockname = "";
                string groupname = "";
                string unitname = "";
                string typename = "";


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;
                    if (Convert.ToInt32(dt.Rows[i]["Error"] == DBNull.Value ? 0 : dt.Rows[i]["Error"]) == 1) continue;
                    bool productExist = false;
                    result = mySql.Start();
                    if (result != "OK")
                    {
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(i, result, 1, result);
                    }

                    temp = gbColMerge.GetCellDisplayText(rowProduct_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];

                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (product.Exist(mySql.Transaction, temp))
                        {
                            //RaiseItemCheckingEventHander(i, "Bỏ qua hàng hóa này.", 2, temp);
                            //mySql.Commit();
                            //continue;
                            if (rgOption.SelectedIndex == 0)
                            {
                                //if (product.Exist(mySql.Transaction, temp))

                                RaiseItemCheckingEventHander(i, "Bỏ qua hàng hóa này.", 2, temp);
                                mySql.Commit();
                                continue;
                            }
                            else if (rgOption.SelectedIndex == 1)
                            {
                                //if (product.Exist(mySql.Transaction, temp))

                                if (product.Get(mySql.Transaction, temp) == "OK")
                                {
                                    productExist = true;
                                }
                            }
                            else
                            {
                                //if (product.Exist(mySql.Transaction, temp))

                                //if (product.Delete(mySql.Transaction, temp) != "OK")

                                RaiseItemCheckingEventHander(i, "Hàng hóa này đã tồn tại.", 1, temp);
                                mySql.RollBack();
                                return;
                            }
                        }


                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Mã Hàng hoá chưa xác định.", 1, temp);
                            mySql.RollBack();
                            return;
                        }

                        product.Product_ID = temp;
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Mã Hàng hoá chưa xác định.", 1, temp);
                        mySql.RollBack();
                        return;
                    }

                    temp = gbColMerge.GetCellDisplayText(rowProduct_Name, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];

                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (product.ExistByName(mySql.Transaction, temp))
                        {
                            //RaiseItemCheckingEventHander(i, "Bỏ qua hàng hóa này.", 2, temp);
                            //mySql.Commit();
                            //continue;
                            if (rgOption.SelectedIndex == 0)
                            {
                                //if (product.ExistByName(mySql.Transaction, temp))

                                RaiseItemCheckingEventHander(i, "Bỏ qua hàng hóa này.", 2, temp);
                                mySql.Commit();
                                continue;
                            }
                            else if (rgOption.SelectedIndex == 1)
                            {
                                //if (product.ExistByName(mySql.Transaction, temp))

                                if (product.Get(mySql.Transaction, temp) == "OK")
                                {
                                    productExist = true;
                                }
                            }
                            else
                            {
                                //if (product.ExistByName(mySql.Transaction, temp))

                                //if (product.Delete(mySql.Transaction, temp) != "OK")

                                RaiseItemCheckingEventHander(i, "Hàng hóa này đã tồn tại.", 1, temp);
                                mySql.RollBack();
                                return;
                            }
                        }



                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Tên Hàng hoá chưa xác định.", 1, temp);
                            mySql.RollBack();
                            return;
                        }
                        product.Product_Name = temp;
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Tên Hàng hoá chưa xác định.", 1, temp);
                        mySql.RollBack();
                        return;
                    }

                    temp = gbColMerge.GetCellDisplayText(rowCustomer_ID, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();

                        var provider = new PROVIDER();
                        if (provider.GetByName(mySql.Transaction, temp) == "OK")
                        {
                            product.Customer_ID = provider.Customer_ID;
                        }
                    }


                    temp = gbColMerge.GetCellDisplayText(rowProduct_Group_ID, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (temp.Trim() == "")
                        {
                            if (groupname != "")
                            {
                                temp = groupname;
                                product.Product_Group_ID = groupname;
                            }
                            else
                            {
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, "Nhóm hàng hoá chưa xác định.", 1, temp);
                                return;
                            }

                        }
                        else
                        {
                            var productGroup = new PRODUCT_GROUP();

                            if (productGroup.GetByName(mySql.Transaction, temp) != "OK")
                            {
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, "Không thể tạo nhóm hàng hoá", 1, temp);
                                return;
                            }
                            
                            product.Product_Group_ID = productGroup.ProductGroup_ID;
                            groupname = product.Product_Group_ID;
                        }


                    }
                    else
                    {
                        var productGroup = new PRODUCT_GROUP();

                        if (!productGroup.Exist(mySql.Transaction, "MD"))
                        {
                            mySql.RollBack();
                            RaiseItemCheckingEventHander(i, "Nhóm hàng hoá chưa xác định.", 1, temp);
                            return;
                        }

                        product.Product_Group_ID = "MD";
                        groupname = "MD";
                    }


                    temp = gbColMerge.GetCellDisplayText(rowProduct_Type_ID, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();

                        switch (temp)
                        {
                            case "Hàng Hoá":
                                product.Product_Type_ID = 0;
                                break;
                            case "Dịch Vụ":
                                product.Product_Type_ID = 1;
                                break;
                            case "Nguyên Liệu":
                                product.Product_Type_ID = 2;
                                break;
                            case "Bán Thành Phẩm":
                                product.Product_Type_ID = 3;
                                break;
                            case "Thành Phẩm":
                                product.Product_Type_ID = 4;
                                break;
                            case "Sản Phẩm Lắp Ráp":
                                product.Product_Type_ID = 5;
                                break;
                            case "Chiết Khấu":
                                product.Product_Type_ID = 6;
                                break;
                            default:
                                product.Product_Type_ID = 0;
                                break;
                        }
                        ;
                    }
                    else
                    {
                        product.Product_Type_ID = 0;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowProvider_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        if (temp.Trim() == "")
                        {
                            if (stockname == "")
                            {
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, "Kho hàng hoá chưa xác định.", 1, temp);
                                return;
                            }
                            product.Provider_ID = stockname;
                        }
                        else
                        {
                            var stock = new STOCK();
                            if (stock.GetByName(mySql.Transaction, temp) != "OK")
                            {
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, "Không thể tạo kho hàng hoá", 1, temp);
                                return;
                            }
                           
                            product.Provider_ID = stock.Stock_ID;
                            stockname = product.Provider_ID;

                        }
                    }
                    else
                    {
                        //RaiseItemCheckingEventHander(i, "Cột Kho Hàng hoá chưa xác định.", 1, temp);
                        //mySql.RollBack();
                        //continue;
                        var stock = new STOCK();
                        if (!stock.Exist(mySql.Transaction, "MD"))
                        {
                            mySql.RollBack();
                            RaiseItemCheckingEventHander(i, "Kho hàng hoá chưa xác định.", 1, temp);
                            return;
                        }
                        product.Provider_ID = "MD";
                        stockname = "MD";
                    }


                    temp = gbColMerge.GetCellDisplayText(rowUnit, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (temp.Trim() == "")
                        {
                            if (unitname=="")
                            {
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, "Đơn vị chưa xác định.", 1, temp);
                                return;
                            }
                            product.Unit = unitname;
                        }
                        else
                        {
                            var unit = new UNIT();
                            if (unit.GetByName(mySql.Transaction, temp) != "OK")
                            {
                                mySql.RollBack();
                                RaiseItemCheckingEventHander(i, "Không thể tạo đơn vị tính", 1, temp);
                                return;
                            }
                            
                            product.Unit = unit.Unit_ID;
                            unitname = unit.Unit_ID;
                        }
                        
                    }
                    else
                    {
                        var unit = new UNIT();
                        if (!unit.Exist(mySql.Transaction, "kg"))
                        {
                            mySql.RollBack();
                            RaiseItemCheckingEventHander(i, "Đơn vị chưa xác định.", 1, temp);
                            return;
                        }
                        product.Unit = "kg";
                        unitname = "kg";
                    }


                    temp = gbColMerge.GetCellDisplayText(rowUnitConvert, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();

                        if (temp.Trim() != "")
                        {
                            var unit = new UNIT();
                            if (unit.GetByName(mySql.Transaction, temp) == "OK")
                            {
                                product.UnitConvert = unit.Unit_ID;
                            }
                            else
                            {
                                //result = unit.Insert(mySql.Transaction, MyLib.RejectMarks(temp), temp, "", true);
                                //product.UnitConvert = unit.Unit_ID;

                                //if (result != "OK")
                                {
                                    mySql.RollBack();
                                    RaiseItemCheckingEventHander(i, "Không thể tạo đơn vị tính", 1, temp);
                                    return;
                                }
                            }
                        }
                    }

                    product.Quantity = 0;


                    //temp = gbColMerge.GetCellDisplayText(rowRetail_Price, 0);

                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Giá vốn không phải là số.", 3, temp);
                    //        product.Retail_Price = 0;
                    //    }
                    //    else
                    //    {
                    //        product.Retail_Price = Convert.ToDouble(temp);    
                    //    }

                    //}


                    temp = gbColMerge.GetCellDisplayText(rowSale_Price, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Giá bán không phải là số.", 3, temp);
                            product.Sale_Price = 0;
                        }
                        else
                        {
                            product.Sale_Price = Convert.ToDouble(temp);
                        }
                    }

                    temp = gbColMerge.GetCellDisplayText(rowSize, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        product.Size = temp;
                    }

                    ////temp = gbColMerge.GetCellDisplayText(rowThickness, 0);
                    ////if (temp != "<Không Chọn>")
                    ////{
                    ////    ob = dt.Rows[i][temp];
                    ////    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    ////    if (!Information.IsNumeric(ob))
                    ////    {
                    ////        RaiseItemCheckingEventHander(i, "Độ dày không phải là số.", 3, temp);
                    ////        product.Thickness = 0;
                    ////    }
                    ////    else
                    ////    {
                    ////        product.Thickness = Convert.ToDouble(temp);
                    ////    }
                    ////}

                    //temp = gbColMerge.GetCellDisplayText(rowDepth, 0);

                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Độ sâu không phải là số.", 3, temp);
                    //        product.Depth = 0;
                    //    }
                    //    else
                    //    {
                    //        product.Depth = Convert.ToDouble(temp);
                    //    }
                    //}

                    temp = gbColMerge.GetCellDisplayText(rowDescription, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        product.Description = temp;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowDiscount, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Chiết khấu không phải là số.", 3, temp);
                            product.Discount = 0;
                        }
                        else
                        {
                            product.Discount = Convert.ToDouble(temp);
                        }
                    }


                    //temp = gbColMerge.GetCellDisplayText(rowExpiry, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                    //    product.Expiry = temp == "0" ? false : true;

                    //}


                    temp = gbColMerge.GetCellDisplayText(rowExpiryValue, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Định mức hạn sử dụng không phải là số.", 3, temp);
                            product.ExpiryValue = 0;
                        }
                        else
                        {
                            product.ExpiryValue = Convert.ToDouble(temp);
                        }
                    }

                    //temp = gbColMerge.GetCellDisplayText(rowExportTax_ID, 0);

                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Thuế suất xuất khẩu không phải là số.", 3, temp);
                    //        product.ExportTax_ID = 0;
                    //    }
                    //    else
                    //    {
                    //        product.ExportTax_ID = Convert.ToDouble(temp);
                    //    }
                    //}

                    //temp = gbColMerge.GetCellDisplayText(rowHeight, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Độ cao không phải là số.", 3, temp);
                    //        product.Height = 0;
                    //    }
                    //    else
                    //    {
                    //        product.Height = Convert.ToDouble(temp);
                    //    }
                    //}


                    //temp = gbColMerge.GetCellDisplayText(rowImportTax_ID, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Thuế nhập khẩu không phải là số.", 3, temp);
                    //        product.ImportTax_ID = 0;
                    //    }
                    //    else
                    //    {
                    //        product.ImportTax_ID = Convert.ToDouble(temp);
                    //    }
                    //}


                    //temp = gbColMerge.GetCellDisplayText(rowLimitOrders, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Tỷ lệ tiêu hao không phải là số.", 3, temp);
                    //        product.LimitOrders = 0;
                    //    }
                    //    else
                    //    {
                    //        product.LimitOrders = Convert.ToDouble(temp);
                    //    }
                    //}


                    //temp = gbColMerge.GetCellDisplayText(rowLuxuryTax_ID, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Thuế tiêu thụ đặc biệt không phải là số.", 3, temp);
                    //        product.LuxuryTax_ID = 0;
                    //    }
                    //    else
                    //    {
                    //        product.LuxuryTax_ID = Convert.ToDouble(temp);
                    //    }
                    //}

                    //temp = gbColMerge.GetCellDisplayText(rowManufacturer_ID, 0);


                    temp = gbColMerge.GetCellDisplayText(rowMaxStock, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Định mức tồn kho tối đa không phải là số.", 3, temp);
                            product.MaxStock = 0;
                        }
                        else
                        {
                            product.MaxStock = Convert.ToDouble(temp);
                        }
                    }


                    temp = gbColMerge.GetCellDisplayText(rowMinStock, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Định mức tồn kho tối thiểu không phải là số.", 3, temp);
                            product.MinStock = 0;
                        }
                        else
                        {
                            product.MinStock = Convert.ToDouble(temp);
                        }
                    }


                    temp = gbColMerge.GetCellDisplayText(rowOrg_Price, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Giá vốn không phải là số.", 3, temp);
                            product.Org_Price = 0;
                        }
                        else
                        {
                            product.Org_Price = Convert.ToDouble(temp);
                        }
                    }

                    temp = gbColMerge.GetCellDisplayText(rowOrigin, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        product.Origin = temp;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowUnitRate, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Tỷ lệ quy đổi đơn vị không phải là số.", 3, temp);
                            product.Org_Price = 1;
                        }
                        else
                        {
                            product.Org_Price = Convert.ToDouble(temp);
                        }
                    }

                    //temp = gbColMerge.GetCellDisplayText(rowUserID, 0);

                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                    //    product.UserID = temp==""?MyLogin.UserId:temp;
                    //}


                    temp = gbColMerge.GetCellDisplayText(rowVAT_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        switch (temp)
                        {
                            case "Không thuế":
                                product.VAT_ID = 0;
                                break;
                            case "0%":
                                product.VAT_ID = 1;
                                break;
                            case "5%":
                                product.VAT_ID = 2;
                                break;
                            case "10%":
                                product.VAT_ID = 3;
                                break;
                            case "10%x50%":
                                product.VAT_ID = 4;
                                break;
                            default:
                                product.VAT_ID = 0;
                                break;
                        }
                        ;
                    }

                    temp = gbColMerge.GetCellDisplayText(rowWarranty, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                        if (!Information.IsNumeric(ob))
                        {
                            RaiseItemCheckingEventHander(i, "Định mức bảo hành không phải là số.", 3, temp);
                            product.Warranty = 0;
                        }
                        else
                        {
                            product.Warranty = Convert.ToInt32(temp);
                        }
                    }


                    //temp = gbColMerge.GetCellDisplayText(rowWidth, 0);

                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Độ rộng không phải là số.", 3, temp);
                    //        product.Width = 0;
                    //    }
                    //    else
                    //    {
                    //        product.Width = Convert.ToDouble(temp);
                    //    }
                    //}


                    //temp = gbColMerge.GetCellDisplayText(rowActive, 0);


                    product.Active = true;

                    product.AverageCost = 0;


                    temp = gbColMerge.GetCellDisplayText(rowBarcode, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        product.Barcode = temp;
                    }


                    //temp = gbColMerge.GetCellDisplayText(rowBatch, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();
                    //    product.Batch = temp == "1" ? SYS_OPTION.Batch : false;
                    //}

                    temp = gbColMerge.GetCellDisplayText(rowColor, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString().Trim();
                        product.Color = temp;
                    }
                    //temp = gbColMerge.GetCellDisplayText(rowCommission, 0);
                    //if (temp != "<Không Chọn>")
                    //{
                    //    ob = dt.Rows[i][temp];
                    //    temp = ob == DBNull.Value ? "0" : ob.ToString().Trim();

                    //    if (!Information.IsNumeric(ob))
                    //    {
                    //        RaiseItemCheckingEventHander(i, "Tỷ lệ huê hồng không phải là số.", 3, temp);
                    //        product.Commission = 0;
                    //    }
                    //    else
                    //    {
                    //        product.Commission = Convert.ToDouble(temp);
                    //    }
                    //}
                    if (productExist)
                    {
                        result = product.Update(mySql.Transaction);
                    }
                    else
                    {
                        result = product.Insert(mySql.Transaction);
                    }
                    if (result == "OK")
                    {
                        mySql.Commit();
                        RaiseItemCheckingEventHander(i, result, 0, "Hàng hoá " + product.Product_Name + " đã được thêm");
                    }
                    else
                    {
                        mySql.RollBack();
                        RaiseItemCheckingEventHander(i, result, 1, "Không thực hiện được");
                    }
                }

                //mySql.RollBack();
                //RaiseItemCheckingEventHander(0, "");
                RaiseItemCheckedEventHander();
            }
            //return false;
        }

        private void ExecuteCheck()
        {
            string result = "";
            var dt = (DataTable)gcList.DataSource;

            if (dt != null)
            {
                var product = new PRODUCT();
                string temp;
                object ob;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i]["Chọn"])) continue;

                    temp = gbColMerge.GetCellDisplayText(rowProduct_ID, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];

                        temp = ob == DBNull.Value ? "" : ob.ToString();

                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Mã hàng hóa chưa biết.", 1, temp);
                            continue;
                        }

                        if (product.Exist(temp))
                        {
                            RaiseItemCheckingEventHander(i, "Hàng hoá đã tồn tại.", 2, temp);
                            continue;
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Mã hàng hóa chưa chọn.", 1, temp);
                        continue;
                    }

                    temp = gbColMerge.GetCellDisplayText(rowProduct_Name, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Tên hàng bị trống.", 1, temp);
                            continue;
                        }

                        if (product.ExistByName(temp))
                        {
                            RaiseItemCheckingEventHander(i, "Hàng hoá đã tồn tại.", 1, temp);
                            continue;
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Tên hàng hóa chưa chọn.", 1, temp);
                        continue;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowProduct_Group_ID, 0);

                    if (temp != "<Không Chọn>")
                    {
                        var productGroup = new PRODUCT_GROUP();

                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Nhóm hàng bị trống.", 2, temp);
                            continue;
                        }
                        result = productGroup.GetByName(temp);
                        if (result != "OK")
                        {
                            RaiseItemCheckingEventHander(i, "Nhóm Hàng hoá không tồn tại.", 2, temp);
                            continue;
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột nhóm hàng hóa chưa chọn.", 2, temp);
                        continue;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowProvider_ID, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Kho Hàng hoá chưa biết.", 3, temp);
                            continue;
                        }

                        var stock = new STOCK();
                        result = stock.GetByName(temp);
                        if (result != "OK")
                        {
                            RaiseItemCheckingEventHander(i, "Kho Hàng hoá không tồn tại.", 3, temp);
                            continue;
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Kho hàng hóa chưa chọn.", 2, temp);
                        continue;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowUnit, 0);

                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() == "")
                        {
                            RaiseItemCheckingEventHander(i, "Đơn vị tính chưa biết.", 3, temp);
                            continue;
                        }
                        var unit = new UNIT();

                        if (unit.GetByName(temp) != "OK")
                        {
                            RaiseItemCheckingEventHander(i, "Đơn vị tính không tồn tại.", 4, temp);
                            continue;
                        }
                    }
                    else
                    {
                        RaiseItemCheckingEventHander(i, "Cột Đơn vị tính chưa chọn.", 2, temp);
                        continue;
                    }


                    temp = gbColMerge.GetCellDisplayText(rowUnitConvert, 0);
                    if (temp != "<Không Chọn>")
                    {
                        ob = dt.Rows[i][temp];
                        temp = ob == DBNull.Value ? "" : ob.ToString();
                        if (temp.Trim() != "")
                        {
                            var unit = new UNIT();
                            if (unit.GetByName(temp) == "OK")
                            {
                                RaiseItemCheckingEventHander(i, "Đơn vị quy đổi không tồn tại.", 5, temp);
                                continue;
                            }
                        }
                    }

                    //RaiseItemCheckingEventHander(i, result);
                }

                RaiseItemCheckedEventHander();
            }
            //return false;
        }

        private void wcImport_NextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            //if (e.Page == wpBrowse)
            //{

            //    if (!Check)
            //    {
            //        XtraMessageBox.Show("Error:\n\tPlease check data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        wcImport.SetPreviousPage();
            //        return;
            //    }

            //    #region Product
            //    PRODUCT PRO = new PRODUCT();
            //    string Result = "";

            //    lcBar.Visibility = true;
            //    int row = 0;
            //    while (row < gbList.RowCount)
            //    {
            //        Bar.Position += row / gbList.RowCount;


            //        Result = PRO.Insert
            //            (gbList.GetRowCellValue(row, gbList.Columns["Product_ID"]).ToString(), //ID
            //            gbList.GetRowCellValue(row, gbList.Columns["Product_Name"]).ToString(), //Name
            //            0, //Type
            //            0,
            //            "HH", //Group
            //            "",
            //            gbList.GetRowCellValue(row, gbList.Columns["Origin"]).ToString(), //Origin
            //            gbList.GetRowCellValue(row, gbList.Columns["Barcode"]).ToString(), //Barcode                            
            //            gbList.GetRowCellValue(row, gbList.Columns["Unit"]).ToString(),
            //            gbList.GetRowCellValue(row, gbList.Columns["Unit"]).ToString(),
            //            1.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0.0,
            //            0, //warranty
            //           -1, //Vat_ID
            //            0,
            //            0,
            //            0,
            //            "",
            //            "",
            //            0,
            //            Convert.ToDouble(gbList.GetRowCellValue(row, gbList.Columns["MinStock"])),//min
            //            Convert.ToDouble(gbList.GetRowCellValue(row, gbList.Columns["MaxStock"])),//max
            //            0,
            //            0,
            //            "",
            //            "",
            //            false,
            //            0,
            //            0,
            //            false, //Convert.ToBoolean(gbList.GetRowCellValue(row, gbList.Columns[12])),
            //            0,
            //            0,
            //            0,
            //            0,
            //            gbList.GetRowCellValue(row, gbList.Columns["Size"]).ToString(),
            //            MyLogin.UserId,
            //            true
            //           );

            //        if (Result == "OK")
            //        {
            //            gbList.DeleteRow(row);
            //            continue;
            //        }


            //        row++;
            //    }
            //    #endregion


            //    lcBar.Visibility = false;
            //}
        }

        //private void btnCheck_Click(object sender, EventArgs e)
        //{
        //    Check = true;
        //    lcBar.Visibility = true;

        //    #region Check Product
        //    for (int i = 0; i < gbList.RowCount; i++)
        //    {
        //        Bar.Position = (i / gbList.RowCount * 100);

        //        object Arg = gbList.GetRowCellValue(i, gbList.Columns["Product_Name"]);
        //        if (Arg == null)
        //        {
        //            gbList.DeleteRow(i);
        //            continue;
        //        }
        //        else if (Arg.ToString() == "")
        //        {
        //            gbList.DeleteRow(i);
        //        }

        //        Arg = gbList.GetRowCellValue(i, gbList.Columns["Product_ID"]);
        //        if (Arg == null)
        //        {
        //            gbList.DeleteRow(i);
        //            continue;
        //        }
        //        else if (Arg.ToString() == "")
        //        {
        //            gbList.DeleteRow(i);
        //        }


        //    }
        //    #endregion

        //    lcBar.Visibility = false;
        //}

        private void xfmItemImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFormatChose.PRODUCT' table. You can move, or remove it, as needed.
            // this.pRODUCTTableAdapter.Fill(this.dsFormatChose.PRODUCT);
            //// TODO: This line of code loads data into the 'dsProduct.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.dsProduct.PRODUCT);
            //// TODO: This line of code loads data into the 'dsProductGroup.PRODUCT_GROUP' table. You can move, or remove it, as needed.
            //this.pRODUCT_GROUPTableAdapter.Fill(this.dsProductGroup.PRODUCT_GROUP);
        }

        private void wcImport_FinishClick(object sender, CancelEventArgs e)
        {
            if (!finish) return;
            Close();
        }

        private void wcImport_CancelClick(object sender, CancelEventArgs e)
        {
            //Close();
        }

        /*
                private void btnOpen_Click(object sender, EventArgs e)
                {
                   // btnOpen.Enabled = false;
                    wpinput.AllowNext = false;
                    OpenFileDialog OpenFileDialog = new OpenFileDialog();
                    OpenFileDialog.Filter = "Microsoft Excel File(*.xls)|*.xls|All File(*.*)|*.*";
                    if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        lsSheet.Items.Clear();
                        txtPath.Text = OpenFileDialog.FileName;
                        ExcelDataReader ExcelDataReader = new ExcelDataReader(OpenFileDialog.FileName);
                        DataTable dt=ExcelDataReader.GetExcelSheetNames(OpenFileDialog.FileName);

                        if (dt != null)
                        {
                            string temp;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                temp = (dt.Rows[i]["TABLE_NAME"]?? "") as string;
                                if (temp != "")
                                {
                                    temp = temp.Substring(0, temp.Length - 1);
                                    lsSheet.Items.Add(temp);
                                }
                            }
                        }

                    }
                    //btnOpen.Enabled = true;
                }
        */

        private void lsSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsSheet.SelectedIndex == -1) return;
            wpinput.AllowNext = true;
        }

        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void chxAll_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            //Bar.Properties.Maximum = dt.Rows.Count;

            while (i < gbList.RowCount)
            {
                gbList.SetRowCellValue(i, "Chọn", chxAll.Checked);
                gbList.SetRowCellValue(i, "Error", 0);
                i++;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            var dt = (DataTable)gcList.DataSource;

            rpColumns.Items.Clear();
            rpColumns.Items.Add("<Không Chọn>");

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                rpColumns.Items.Add(dt.Columns[i].Caption);

                string temp = dt.Columns[i].Caption.ToLower();

                if (dt.Columns[i].Caption.ToLower().IndexOf("mã") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["Product_ID"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("tên") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["Product_Name"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("tính chất") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["Product_Type_ID"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("nhóm") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["Product_Group_ID"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("kho") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["Provider_ID"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "nhà sản xuất")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Manufacturer_ID"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "barcode")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Barcode"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "giá bán")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Sale_Price"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("xuất xứ") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["Origin"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "kích thước")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Size"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "giá bán lẻ")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Retail_Price"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "giá hiện tại")
                {
                    dsFormatChose.PRODUCT.Rows[0]["CurrentCost"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "giá bình quân")
                {
                    dsFormatChose.PRODUCT.Rows[0]["AverageCost"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "bảo hành")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Warranty"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "thuế gtgt")
                {
                    dsFormatChose.PRODUCT.Rows[0]["VAT_ID"] = dt.Columns[i].Caption;
                }
                //else if (dt.Columns[i].Caption.ToLower() == "nhà phân phối")
                //{
                //    dsFormatChose.PRODUCT.Rows[0]["Customer_ID"] = dt.Columns[i].Caption;
                //}
                //else if (dt.Columns[i].Caption.ToLower() == "NPP")
                //{
                //    dsFormatChose.PRODUCT.Rows[0]["Customer_Name"] = dt.Columns[i].Caption;
                //}

                else if (dt.Columns[i].Caption.ToLower().IndexOf("tối thiểu") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["MinStock"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("tối đa") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["MaxStock"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "chiết khấu")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Discount"] = dt.Columns[i].Caption;
                }

                else if (dt.Columns[i].Caption.ToLower() == "màu")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Color"] = dt.Columns[i].Caption;
                }

                else if (dt.Columns[i].Caption.ToLower().IndexOf("tiêu hao") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["LimitOrders"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower().IndexOf("hsd") != -1)
                {
                    dsFormatChose.PRODUCT.Rows[0]["ExpiryValue"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "đơn vị tính")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Unit_Name"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "đơn vị")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Unit"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "đơn vị quy đổi")
                {
                    dsFormatChose.PRODUCT.Rows[0]["UnitConvert"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "tỷ lệ quy đổi")
                {
                    dsFormatChose.PRODUCT.Rows[0]["UnitRate"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "số lượng")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Quantity"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "giá vốn")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Org_Price"] = dt.Columns[i].Caption;
                }
                else if (dt.Columns[i].Caption.ToLower() == "diễn giải")
                {
                    dsFormatChose.PRODUCT.Rows[0]["Description"] = dt.Columns[i].Caption;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsFormatChose.PRODUCT.Columns.Count; i++)
            {
                dsFormatChose.PRODUCT.Rows[0][i] = "<Không Chọn>";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "Map file (*.map)|*.map|All File(*.*)|*.*";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsFormatChose.PRODUCT.WriteXml(SaveFileDialog.FileName);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Lỗi:\n\tKhông lưu được sơ đồ ghép.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnOpenMerge_Click(object sender, EventArgs e)
        {
            var OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Map file (*.map)|*.map|All File(*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsFormatChose.PRODUCT.Rows.Clear();
                    dsFormatChose.PRODUCT.ReadXml(OpenFileDialog.FileName);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Lỗi:\n\tKhông mở được sơ đồ ghép.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
            }
        }

        private void gbColMerge_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Row == rowProduct_Group_ID)
            {
                gbColMerge.SetRowError(rowProduct_Group_ID.Properties, null);
            }
            else if (e.Row == rowUnit)
            {
                gbColMerge.SetRowError(rowUnit.Properties, null);
            }
            else if (e.Row == rowProvider_ID)
            {
                gbColMerge.SetRowError(rowProvider_ID.Properties, null);
            }
            else if (e.Row == rowProduct_ID)
            {
                gbColMerge.SetRowError(rowProduct_ID.Properties, null);
            }
            else if (e.Row == rowProduct_Name)
            {
                gbColMerge.SetRowError(rowProduct_Name.Properties, null);
            }
            else if (e.Row == rowUnitConvert)
            {
                gbColMerge.SetRowError(rowUnitConvert.Properties, null);
            }
            else
            {
                gbColMerge.ClearRowErrors();
            }
        }

        private void xfmItemImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !finish;
        }

        private void txtPath_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            wpinput.AllowNext = false;
            var OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Microsoft Excel File(*.xls)|*.xls|All File(*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                lsSheet.Items.Clear();
                txtPath.Text = OpenFileDialog.FileName;
                var ExcelDataReader = new ExcelDataReader(OpenFileDialog.FileName);
                DataTable dt = ExcelDataReader.GetExcelSheetNames(OpenFileDialog.FileName);

                if (dt != null)
                {
                    string temp;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        temp = (dt.Rows[i]["TABLE_NAME"] ?? "") as string;
                        if (temp != "")
                        {
                            temp = temp.Substring(0, temp.Length - 1);
                            lsSheet.Items.Add(temp);
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}