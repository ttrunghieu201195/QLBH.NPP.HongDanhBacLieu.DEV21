using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Data;
using System.Globalization;
using Perfect.Security.Excel.Core;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;

namespace Perfect.Security
{
    public class ExcelDataReader
    {
        private Stream m_file = null;
        private XlsHeader m_hdr = null;
        private XlsBiffStream m_stream = null;
        private XlsWorkbookGlobals m_globals = null;
        private List<XlsWorksheet> m_sheets = new List<XlsWorksheet>();
        private System.Data.DataSet m_workbookData = null;
        private ushort m_version = 0x0600;
        private Encoding m_encoding = Encoding.Default;
        private string m_FileName = "";

        public delegate void BusyStartedEventHander(object sender);

        public event BusyStartedEventHander BusyStarted;

        private void RaiseBusyStartedEventHander()
        {
            if (BusyStarted != null) BusyStarted(this);
        }

        public delegate void BusyFinishEventHander(object sender);

        public event BusyFinishEventHander BusyFinish;

        private void RaiseBusyFinishEventHander()
        {
            if (BusyFinish != null) BusyFinish(this);
        }

        public delegate void ExcelReaderProcessEventHander(object sender, int Position);

        public event ExcelReaderProcessEventHander ExcelReaderProcess;

        private void RaiseExcelReaderProcessEventHander(int Position)
        {
            if (ExcelReaderProcess != null) ExcelReaderProcess(this, Position);
        }

        public delegate void ExcelReaderErrorEventHander(object sender, string Message);

        public event ExcelReaderErrorEventHander ExcelReaderError;

        public delegate void ExcelReaderCompleteEventHander(object sender, DataTable dt);

        public event ExcelReaderCompleteEventHander ExcelReaderComplete;

        private void RaiseExcelReaderCompleteEventHander(DataTable dt)
        {
            if (ExcelReaderComplete != null) ExcelReaderComplete(this, dt);
        }

        private void RaiseExcelReaderErrorEventHander(string Message)
        {
            if (ExcelReaderError != null) ExcelReaderError(this, Message);
        }

        public ExcelDataReader(string ExcelFile)
        {
            m_FileName = ExcelFile;
        }

        public string FileName
        {
            get { return m_FileName; }
            set { m_FileName = value; }
        }

        public void ExcelReadByAdo(string fileName, string sheetNames)
        {
            RaiseBusyStartedEventHander();

            var connectionString = "Driver={Microsoft Excel Driver (*.xls)};DriverId=790;" + "Dbq=" + fileName + ";";
            var con = new OdbcConnection(connectionString);
            var cmdSelect = new OdbcCommand("SELECT * FROM [" + sheetNames + "$]", con);
            var adapter = new OdbcDataAdapter(cmdSelect);
            var ds = new DataSet();
            try
            {
                con.Open();
                adapter.Fill(ds, sheetNames);
                RaiseBusyFinishEventHander();
                var dt = ds.Tables[0];
                var dc = new DataColumn("Chọn", typeof(bool));
                //dt.Columns.Add("Select", typeof(bool));

                dt.Columns.Add(dc);

                var i = 0;
                //Bar.Properties.Maximum = dt.Rows.Count;
                RaiseExcelReaderProcessEventHander(0);
                while (i < dt.Rows.Count)
                {
                    dt.Rows[i]["Chọn"] = true;
                    if (dt.Rows[i][0] == null)
                    {
                        dt.Rows.RemoveAt(i);
                    }
                    else if (dt.Rows[i][0].ToString() == "")
                    {
                        dt.Rows.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                    RaiseExcelReaderProcessEventHander(i / dt.Rows.Count * 100);
                }

                // dt.Columns.Add(dc);
                dt.Columns.Add("Error", typeof(int));
                dt.Columns.Add("ErrorText", typeof(string));

                RaiseExcelReaderCompleteEventHander(dt);
            }
            catch (Exception err)
            {
                RaiseExcelReaderErrorEventHander(err.Message);
            }
            finally
            {
                con.Close();
            }

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="file">Stream with source data</param>
        public ExcelDataReader(Stream file)
        {

        }

        /// <summary>
        /// DataSet with workbook data, Tables represent Sheets
        /// </summary>
        public System.Data.DataSet WorkbookData
        {
            get { return m_workbookData; }
        }

        /// <summary>
        /// Private method, reads Workbook Globals section
        /// </summary>
        private void ReadWorkbookGlobals()
        {
            m_globals = new XlsWorkbookGlobals();
            m_stream.Seek(0, SeekOrigin.Begin);
            XlsBiffRecord rec = m_stream.Read();
            XlsBiffBOF bof = rec as XlsBiffBOF;
            if (bof == null || bof.Type != BIFFTYPE.WorkbookGlobals)
                throw new InvalidDataException("Oops! Stream has invalid data");
            m_version = bof.Version;
            m_encoding = Encoding.Unicode;
            bool isV8 = (m_version >= 0x600);
            bool sst = false;
            RaiseExcelReaderProcessEventHander(0);

            while ((rec = m_stream.Read()) != null)
            {
                RaiseExcelReaderProcessEventHander(m_stream.Position / m_stream.Size);

                switch (rec.ID)
                {
                    case BIFFRECORDTYPE.INTERFACEHDR:
                        m_globals.InterfaceHdr = (XlsBiffInterfaceHdr)rec;
                        break;
                    case BIFFRECORDTYPE.BOUNDSHEET:
                        XlsBiffBoundSheet sheet = (XlsBiffBoundSheet)rec;
                        if (sheet.Type != XlsBiffBoundSheet.SheetType.Worksheet) break;
                        sheet.IsV8 = isV8;
                        sheet.UseEncoding = m_encoding;
                        m_sheets.Add(new XlsWorksheet(m_globals.Sheets.Count, sheet));
                        m_globals.Sheets.Add(sheet);
                        break;
                    case BIFFRECORDTYPE.MMS:
                        m_globals.MMS = rec;
                        break;
                    case BIFFRECORDTYPE.COUNTRY:
                        m_globals.Country = rec;
                        break;
                    case BIFFRECORDTYPE.CODEPAGE:
                        m_globals.CodePage = (XlsBiffSimpleValueRecord)rec;
                        m_encoding = Encoding.GetEncoding(m_globals.CodePage.Value);
                        break;
                    case BIFFRECORDTYPE.FONT:
                    case BIFFRECORDTYPE.FONT_V34:
                        m_globals.Fonts.Add(rec);
                        break;
                    case BIFFRECORDTYPE.FORMAT:
                    case BIFFRECORDTYPE.FORMAT_V23:
                        m_globals.Formats.Add(rec);
                        break;
                    case BIFFRECORDTYPE.XF:
                    case BIFFRECORDTYPE.XF_V4:
                    case BIFFRECORDTYPE.XF_V3:
                    case BIFFRECORDTYPE.XF_V2:
                        m_globals.ExtendedFormats.Add(rec);
                        break;
                    case BIFFRECORDTYPE.SST:
                        m_globals.SST = (XlsBiffSST)rec;
                        sst = true;
                        break;
                    case BIFFRECORDTYPE.CONTINUE:
                        if (!sst) break;
                        XlsBiffContinue contSST = (XlsBiffContinue)rec;
                        m_globals.SST.Append(contSST);
                        break;
                    case BIFFRECORDTYPE.EXTSST:
                        m_globals.ExtSST = rec;
                        sst = false;
                        break;
                    case BIFFRECORDTYPE.EOF:
                        if (m_globals.SST != null)
                            m_globals.SST.ReadStrings();
                        return;
                    default:
                        continue;
                }
            }
        }

        /// <summary>
        /// private method, reads sheet data
        /// </summary>
        /// <param name="sheet">Sheet object, whose data to read</param>
        /// <returns>True if sheet was read successfully, otherwise False</returns>
        private bool ReadWorksheet(XlsWorksheet sheet)
        {


            m_stream.Seek((int)sheet.DataOffset, SeekOrigin.Begin);
            XlsBiffBOF bof = m_stream.Read() as XlsBiffBOF;
            if (bof == null || bof.Type != BIFFTYPE.Worksheet)
            {
                // RaiseBusyFinishEventHander();
                return false;
            }
            XlsBiffIndex idx = m_stream.Read() as XlsBiffIndex;
            bool isV8 = (m_version >= 0x600);
            if (idx != null)
            {
                idx.IsV8 = isV8;
                DataTable dt = new DataTable(sheet.Name);

                XlsBiffRecord trec;
                XlsBiffDimensions dims = null;
                do
                {
                    trec = m_stream.Read();
                    if (trec.ID == BIFFRECORDTYPE.DIMENSIONS)
                    {
                        dims = (XlsBiffDimensions)trec;
                        break;
                    }
                }
                while (trec.ID != BIFFRECORDTYPE.ROW);
                int maxCol = 256;
                if (dims != null)
                {
                    dims.IsV8 = isV8;
                    maxCol = dims.LastColumn;
                    sheet.Dimensions = dims;
                }
                for (int i = 0; i < maxCol; i++)
                    dt.Columns.Add("Column" + (i + 1).ToString(), typeof(string));
                sheet.Data = dt;
                uint maxRow = idx.LastExistingRow;
                if (idx.LastExistingRow <= idx.FirstExistingRow)
                {
                    // RaiseBusyFinishEventHander();
                    return true;
                }
                dt.BeginLoadData();
                for (int i = 0; i <= maxRow; i++)
                    dt.Rows.Add(dt.NewRow());
                uint[] dbCellAddrs = idx.DbCellAddresses;
                for (int i = 0; i < dbCellAddrs.Length; i++)
                {
                    XlsBiffDbCell dbCell = (XlsBiffDbCell)m_stream.ReadAt((int)dbCellAddrs[i]);
                    XlsBiffRow row = null;
                    int offs = (int)dbCell.RowAddress;
                    do
                    {
                        row = m_stream.ReadAt(offs) as XlsBiffRow;
                        if (row == null) break;
                        offs += row.Size;
                    }
                    while (row != null);
                    while (true)
                    {
                        XlsBiffRecord rec = m_stream.ReadAt(offs);
                        offs += rec.Size;
                        if (rec is XlsBiffDbCell) break;
                        if (rec is XlsBiffEOF) break;
                        XlsBiffBlankCell cell = rec as XlsBiffBlankCell;
                        if (cell == null)
                        {
                            continue;
                        }
                        if (cell.ColumnIndex >= maxCol) continue;
                        if (cell.RowIndex > maxRow) continue;
                        switch (cell.ID)
                        {
                            case BIFFRECORDTYPE.INTEGER:
                            case BIFFRECORDTYPE.INTEGER_OLD:
                                dt.Rows[cell.RowIndex][cell.ColumnIndex] = ((XlsBiffIntegerCell)cell).Value.ToString();
                                break;
                            case BIFFRECORDTYPE.NUMBER:
                            case BIFFRECORDTYPE.NUMBER_OLD:
                                dt.Rows[cell.RowIndex][cell.ColumnIndex] = FormatNumber(((XlsBiffNumberCell)cell).Value);
                                break;
                            case BIFFRECORDTYPE.LABEL:
                            case BIFFRECORDTYPE.LABEL_OLD:
                            case BIFFRECORDTYPE.RSTRING:
                                dt.Rows[cell.RowIndex][cell.ColumnIndex] = ((XlsBiffLabelCell)cell).Value;
                                break;
                            case BIFFRECORDTYPE.LABELSST:
                                {
                                    string tmp = m_globals.SST.GetString(((XlsBiffLabelSSTCell)cell).SSTIndex);
                                    dt.Rows[cell.RowIndex][cell.ColumnIndex] = tmp;
                                }
                                break;
                            case BIFFRECORDTYPE.RK:
                                dt.Rows[cell.RowIndex][cell.ColumnIndex] = FormatNumber(((XlsBiffRKCell)cell).Value);
                                break;
                            case BIFFRECORDTYPE.MULRK:
                                for (ushort j = cell.ColumnIndex; j <= ((XlsBiffMulRKCell)cell).LastColumnIndex; j++)
                                    dt.Rows[cell.RowIndex][j] = FormatNumber(((XlsBiffMulRKCell)cell).GetValue(j));
                                break;
                            case BIFFRECORDTYPE.BLANK:
                            case BIFFRECORDTYPE.BLANK_OLD:
                            case BIFFRECORDTYPE.MULBLANK:
                                // Skip blank cells
                                break;
                            case BIFFRECORDTYPE.FORMULA:
                            case BIFFRECORDTYPE.FORMULA_OLD:
                                ((XlsBiffFormulaCell)cell).UseEncoding = m_encoding;
                                object val = ((XlsBiffFormulaCell)cell).Value;
                                if (val == null)
                                    val = string.Empty;
                                else if (val is FORMULAERROR)
                                    val = "#" + ((FORMULAERROR)val).ToString();
                                else if (val is double)
                                    val = FormatNumber((double)val);
                                dt.Rows[cell.RowIndex][cell.ColumnIndex] = val.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }
                dt.EndLoadData();
            }
            else
            {
                //RaiseBusyFinishEventHander();
                return false;
            }
            //RaiseBusyFinishEventHander();
            return true;
        }

        private string FormatNumber(double x)
        {
            if (Math.Floor(x) == x)
                return Math.Floor(x).ToString();
            else
                return Math.Round(x, 2).ToString(CultureInfo.InvariantCulture);
        }

        public static ExcelDataReader Read(string FileName, System.Windows.Forms.ComboBox cboSheet)
        {
            ExcelDataReader spreadsheet = null;
            try
            {


                FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                spreadsheet = new ExcelDataReader(fs);
                fs.Close();

                cboSheet.Items.Clear();
                cboSheet.DisplayMember = "TableName";
                foreach (DataTable dt in spreadsheet.WorkbookData.Tables)
                    cboSheet.Items.Add(dt);
                if (cboSheet.Items.Count == 0) return null;
                cboSheet.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read file: \n" + ex.Message);
                return null;

            }
            return spreadsheet;
        }


        public void Read(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);

            m_file = fs; // new BufferedStream(file);

            RaiseExcelReaderProcessEventHander(0);
            m_hdr = XlsHeader.ReadHeader(m_file);
            RaiseExcelReaderProcessEventHander(10);
            XlsRootDirectory dir = new XlsRootDirectory(m_hdr);
            RaiseExcelReaderProcessEventHander(20);
            XlsDirectoryEntry workbookEntry = dir.FindEntry("Workbook");
            RaiseExcelReaderProcessEventHander(30);
            if (workbookEntry == null)
                workbookEntry = dir.FindEntry("Book");
            RaiseExcelReaderProcessEventHander(40);
            if (workbookEntry == null)
                throw new FileNotFoundException("Oops! Neither stream 'Workbook' nor 'Book' was found in file");
            RaiseExcelReaderProcessEventHander(60);
            if (workbookEntry.EntryType != STGTY.STGTY_STREAM)
                throw new FormatException("Oops! Workbook directory entry is not a Stream");
            RaiseExcelReaderProcessEventHander(80);
            m_stream = new XlsBiffStream(m_hdr, workbookEntry.StreamFirstSector);
            RaiseExcelReaderProcessEventHander(100);
            ReadWorkbookGlobals();
            GC.Collect();
            RaiseBusyStartedEventHander();
            m_workbookData = new System.Data.DataSet();
            for (int i = 0; i < m_sheets.Count; i++)
                if (ReadWorksheet(m_sheets[i]))
                    m_workbookData.Tables.Add(m_sheets[i].Data);
            RaiseBusyFinishEventHander();
            m_globals.SST = null;
            m_globals = null;
            m_sheets = null;
            m_stream = null;
            m_hdr = null;
            GC.Collect();
        }

        public ExcelDataReader Read()
        {
            ExcelDataReader spreadsheet = null;
            try
            {
                FileStream fs = new FileStream(m_FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                spreadsheet = new ExcelDataReader(fs);
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read file: \n" + ex.Message);
                return null;
            }
            return spreadsheet;
        }

        public void ExcelRead(string FileName)
        {
            RaiseExcelReaderProcessEventHander(0);
            DataTable dt = new DataTable();

            Read(FileName);
            dt = this.m_workbookData.Tables[0];
            dt.Columns.Add("Select", typeof(bool));

            int i = 0;
            //Bar.Properties.Maximum = dt.Rows.Count;
            RaiseExcelReaderProcessEventHander(0);
            while (i < dt.Rows.Count)
            {
                if (dt.Rows[i][0] == null)
                {
                    dt.Rows.RemoveAt(i);
                }
                else if (dt.Rows[i][0].ToString() == "")
                {
                    dt.Rows.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                RaiseExcelReaderProcessEventHander(i / dt.Rows.Count * 100);
            }

            RaiseExcelReaderCompleteEventHander(dt);
        }

        public void ExcelReadByADO(string FileName, string SheetNames)
        {
            RaiseBusyStartedEventHander();

            string ConnectionString = "Driver={Microsoft Excel Driver (*.xls)};DriverId=790;" + "Dbq=" + FileName + ";";
            OdbcConnection Con = new OdbcConnection(ConnectionString);
            OdbcCommand CmdSelect = new OdbcCommand("SELECT * FROM [" + SheetNames + "$]", Con);
            OdbcDataAdapter Adapter = new OdbcDataAdapter(CmdSelect);
            System.Data.DataSet Ds = new System.Data.DataSet();
            try
            {
                Con.Open();
                Adapter.Fill(Ds, SheetNames);
                RaiseBusyFinishEventHander();
                DataTable dt = Ds.Tables[0];
                DataColumn dc = new DataColumn("Chọn", typeof(bool));
                //dt.Columns.Add("Select", typeof(bool));

                dt.Columns.Add(dc);

                int i = 0;
                //Bar.Properties.Maximum = dt.Rows.Count;
                RaiseExcelReaderProcessEventHander(0);
                while (i < dt.Rows.Count)
                {
                    dt.Rows[i]["Chọn"] = true;
                    if (dt.Rows[i][0] == null)
                    {
                        dt.Rows.RemoveAt(i);
                    }
                    else if (dt.Rows[i][0].ToString() == "")
                    {
                        dt.Rows.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                    RaiseExcelReaderProcessEventHander(i / dt.Rows.Count * 100);
                }

               // dt.Columns.Add(dc);
                dt.Columns.Add("Error", typeof(int));
                dt.Columns.Add("ErrorText", typeof(string));

                RaiseExcelReaderCompleteEventHander(dt);
            }
            catch (Exception Err)
            {
                RaiseExcelReaderErrorEventHander(Err.Message);
            }
            finally
            {
                Con.Close();
            }

        }

        public void ExcelRead(string FileName, string SheetNames)
        {
            RaiseBusyStartedEventHander();

            string ConnectionString = "Driver={Microsoft Excel Driver (*.xls)};DriverId=790;" + "Dbq=" + FileName + ";";
            OdbcConnection Con = new OdbcConnection(ConnectionString);
            OdbcCommand CmdSelect = new OdbcCommand("SELECT * FROM [" + SheetNames + "$]", Con);
            OdbcDataAdapter Adapter = new OdbcDataAdapter(CmdSelect);
            System.Data.DataSet Ds = new System.Data.DataSet();
            try
            {
                Con.Open();
                Adapter.Fill(Ds, SheetNames);
                RaiseBusyFinishEventHander();
                DataTable dt = Ds.Tables[0];
                RaiseExcelReaderCompleteEventHander(dt);
            }
            catch (Exception Err)
            {
                RaiseExcelReaderErrorEventHander(Err.Message);
            }
            finally
            {
                Con.Close();
            }

        }

        public void ExcelReadByADO(string FileName)
        {
            ExcelReadByADO(FileName, "Sheet1");
        }

        public DataTable GetExcelSheetNames(string FileName)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                // Connection String. Change the excel file to the file you

                // will search.

                string ConnectionString ="Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ FileName  + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
                // Create connection object by using the preceding connection string.

                objConn = new OleDbConnection(ConnectionString);
                // Open connection with the database.

                objConn.Open();
                // Get the data table containg the schema guid.

                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }

                //string[] excelSheets = new string[dt.Rows.Count];
                //int i = 0;

                //// Add the sheet name to the string array.

                //foreach (DataRow row in dt.Rows)
                //{
                //    excelSheets[i] = row["TABLE_NAME"].ToString();
                //    i++;
                //}

                //// Loop through all of the sheets if you want too...

                //for (int j = 0; j < excelSheets.Length; j++)
                //{
                //    // Query each excel sheet.

                //}

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Clean up.

                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }
    }
}
