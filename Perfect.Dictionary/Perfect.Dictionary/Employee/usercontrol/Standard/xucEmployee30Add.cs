using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.Dictionary.Department;
using Perfect.Dictionary.Employee;
using Perfect.Dictionary.Employee.DS.dsDEPARTMENTTableAdapters;
using Perfect.Dictionary.Employee.DS.dsEMPLOYEETableAdapters;
using Perfect.ERP;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using System.Data;
using System.Collections;

namespace Perfect.Dictionary
{
    public partial class xucEmployee30Add : xucBaseAdd26
    {
        public xucEmployee30Add()
        {
            InitializeComponent();
            Init();
        }

        //public static void FillCheckedComboBoxEdit<T>(
        //    CheckedComboBoxEdit checkedComboBoxEdit, 
        //    IEnumerable<T> varlist, 
        //    string valueMember, string displayMember)
        //{

        //    var list = varlist.ToList();

        //    checkedComboBoxEdit.Properties.DataSource = list;
        //    checkedComboBoxEdit.Properties.ValueMember = valueMember;
        //    checkedComboBoxEdit.Properties.DisplayMember = displayMember;

        //    checkedComboBoxEdit.Properties.NullText = @"";
        //    checkedComboBoxEdit.Properties.NullValuePrompt = title;
        //    checkedComboBoxEdit.Properties.NullValuePromptShowForEmptyValue = true;

        //    checkedComboBoxEdit.Properties.TextEditStyle = TextEditStyles.Standard;


        //}

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            SetSize();
        }

        void SetSize()
        {
            if (ParentForm != null)
            {
                Dock = DockStyle.Fill;
                ParentForm.Size = new Size(lgMain.Width + 10, lgMain.Height + 64);
            }
        }

        public delegate void SuccessEventHander(object sender, EMPLOYEE item);

        public event SuccessEventHander Success;

        public void RaiseSuccessEventHander(EMPLOYEE item)
        {
            if (Success != null) Success(this, item);
        }

        public void Init()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Khởi tạo giao diện...");
            //Loại khách hàng
            SetWaitDialogCaption("Nạp danh sách loại khách hàng...");
            DepartmentInit();
            //Cach nay rat do nen phuong phap doi pho
            SetWaitDialogCaption("Nạp số thứ tự khách hàng...");
            EmployeeInit();
            RegionInit();
            DoHide();
        }

        private void RegionInit()
        {
            var cls = new EMPLOYEE(); 
            chkRegion.Properties.DataSource = cls.GetRegionList();
            chkRegion.Properties.ValueMember = "GroupID";
            chkRegion.Properties.DisplayMember = "GroupName";

            chkRegion.Properties.NullText = @"";
            chkRegion.Properties.NullValuePrompt = "";
            chkRegion.Properties.NullValuePromptShowForEmptyValue = true;

            chkRegion.Properties.TextEditStyle = TextEditStyles.Standard;
        }

        

        public void DepartmentInit()
        {
            var departmentTableAdapter = new DEPARTMENTTableAdapter
                                             {
                                                 Connection = {ConnectionString = Data.Helper.SqlHelper.ConnectString}
                                             };
            departmentTableAdapter.Fill(dsDEPARTMENT.DEPARTMENT);

            if (dsDEPARTMENT.DEPARTMENT.Rows.Count > 0) cbxDepartment.EditValue = dsDEPARTMENT.DEPARTMENT.Rows[0]["Department_ID"];


            pRODUCT_GROUPTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCT_GROUPTableAdapter.Fill(dsDEPARTMENT.PRODUCT_GROUP);
        }

        public void EmployeeInit()
        {
            var employeeTableAdapter = new EMPLOYEETableAdapter
                                           {
                                               Connection = {ConnectionString = Data.Helper.SqlHelper.ConnectString}
                                           };
            employeeTableAdapter.Fill(dsEMPLOYEE.EMPLOYEE);
            //if (dsEMPLOYEE.EMPLOYEE.Rows.Count > 0) cbxLeader.EditValue = dsEMPLOYEE.EMPLOYEE.Rows[0]["Employee_ID"];
        }



        public void SetData(EMPLOYEE item)
        {
            txtID.Text = item.Employee_ID;
            SysLog.Insert("Quản Lý Nhân Viên", "Xem", txtID.Text);
            if (m_Status == Actions.Update) txtID.Properties.ReadOnly = true;
            txtNAME.Text = item.Employee_Name;
            
            txtAddress.Text = item.Address;
            txtEmail.Text = item.Email;
            txtMobile.Text = item.Mobile;
            txtTEL.Text = item.O_Tel;

            txtProductGroup.EditValue = item.Team_ID;
            txtProductGroup2.EditValue = item.PersonalTax_ID;

            cbxDepartment.EditValue = item.Department_ID;
            cbxLeader.EditValue = item.Manager_ID;

            chxUse.Checked = item.Active;

            chkRegion.Properties.Items.Clear();

            var cls = new EMPLOYEE();
            foreach (string value in ConvertDataTableToArrayList(cls.GetRegionList()))
            {
                chkRegion.Properties.Items.Add(value, CheckState.Unchecked, true);
                chkRegion.Properties.SeparatorChar = ',';

                chkRegion.SetEditValue(GetRegionListByEmp(item.Employee_ID));
            }
             
        }

        public string GetRegionListByEmp(string EmployeeID)
        {
            string[] myPara = { "@EmployeeID" };
            object[] myValue = { EmployeeID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.StoredProcedure;
            return mySql.ExecuteScalar("sp_GetRegionListByEmp", myPara, myValue).ToString();
        }
         
        public ArrayList ConvertDataTableToArrayList(DataTable dtTable)
        { 
            ArrayList myArrayList = new ArrayList();
            for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= dtTable.Columns.Count - 1; j++)
                {
                    myArrayList.Add(dtTable.Rows[i][j].ToString());
                }
            }
            return myArrayList;
        }
         
        private bool CheckExistData(string EmployeeID)
        {
            bool result = false;
            EMPLOYEE_REGION cls = new EMPLOYEE_REGION();
            if (cls.ExistEmployee(EmployeeID))
            {
                result = true;
            }
            return result;
        }

        private void SaveRegionList()
        {
            if (CheckExistData(txtID.Text))
            {
                // Xoá theo nhân viên

                EMPLOYEE_REGION cls = new EMPLOYEE_REGION();
                if (cls.DeleteByEmp(txtID.Text) != "OK")
                {
                    XtraMessageBox.Show("Có lỗi xảy ra");
                    return;
                }
            }
            
            int count = chkRegion.Properties.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (chkRegion.Properties.Items[i].CheckState != CheckState.Checked) continue;

                //EMPLOYEE_REGION cls = new EMPLOYEE_REGION();
                //if (cls.Exist(txtID.Text.Trim(),
                //    chkRegion.Properties.Items[i].Value.ToString())) continue;

                var empRegion = new EMPLOYEE_REGION
                (
                    txtID.Text.Trim(),
                    chkRegion.Properties.Items[i].Value.ToString(),
                    chkRegion.Properties.Items[i].Description.ToString()
                );

                empRegion.Insert();
                
            } 
            
        }

        protected override string uc_Save()
        {
            if (!MyRule.IsAdd("bbiEmployee")) return "";

            SysLog.Insert("Quản Lý Nhân Viên", "Thêm", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            string result = string.Empty;

            var cls = new EMPLOYEE(
                txtID.Text, 
                MyLib.Get_FirstName(txtNAME.Text),
                MyLib.Get_LastName(txtNAME.Text),
                txtNAME.Text,
                "", 
                true,
                txtAddress.Text,
                "",
                "",
                txtTEL.Text,
                txtMobile.Text,
                "", 
                txtEmail.Text,
                DateTime.Now, 
                0,
                "",
                "", 
                "", 
                cbxDepartment.EditValue == null ? "" : cbxDepartment.EditValue.ToString(),
                (txtProductGroup.EditValue ?? "").ToString(),
                (txtProductGroup2.EditValue ?? "").ToString(),
                "",
                "",
                cbxLeader.EditValue == null ? "" : cbxLeader.EditValue.ToString(),
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                true,
                txtProductGroup.Text,
                DateTime.Now,
                txtProductGroup2.Text,
                DateTime.Now,
                MyLogin.UserId,
                chkRegion.Text,
                0,
                chxUse.Checked);

            if (cls.Insert())
            {
                SaveRegionList();
                RaiseSuccessEventHander(cls);
            }                
            else
            {
                XtraMessageBox.Show(result,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                DoHide();
                return result;
            }

            Cursor.Current = Cursors.Default;
            DoHide();
            return result;

        }

        protected override string uc_Update()
        {
            if (!MyRule.IsEdit("bbiEmployee")) return "";

            SysLog.Insert("Quản Lý Nhân Viên", "Cập Nhật", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            string result = string.Empty;
            var cls = new EMPLOYEE(
                txtID.Text,
                MyLib.Get_FirstName(txtNAME.Text),
                MyLib.Get_LastName(txtNAME.Text),
                txtNAME.Text,
                "",
                true,
                txtAddress.Text,
                "",
                "",
                txtTEL.Text,
                txtMobile.Text,
                "",
                txtEmail.Text,
                DateTime.Now,
                0,
                txtPosition.Text,
                "",
                "",
                cbxDepartment.EditValue == null ? "" : cbxDepartment.EditValue.ToString(),
                (txtProductGroup.EditValue ?? "").ToString(),
                (txtProductGroup2.EditValue ?? "").ToString(),
                "",
                "",
                cbxLeader.EditValue == null ? "" : cbxLeader.EditValue.ToString(),
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                true,
                txtProductGroup.Text,
                DateTime.Now,
                txtProductGroup2.Text,
                DateTime.Now,
                MyLogin.UserId,
                chkRegion.Text,
                0,
                chxUse.Checked);

            
            if (cls.Update())
            {
                SaveRegionList();
                RaiseSuccessEventHander(cls);
            }                
            else
            {
                XtraMessageBox.Show( result,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                DoHide();
                return result;
            }
            DoHide();
            return result;
        }

        protected override string uc_Change()
        {
            string Result = string.Empty;
            return Result;
        }

        protected override string uc_Delete()
        {
            string result = string.Empty;
            //EMPLOYEE cls = new EMPLOYEE();
            //cls.Employee_ID = txtID.Text;
            //Result = cls.Delete();
            //if (Result == "OK") RaiseSuccessEventHander(cls);
            return result;
        }

        #region ID

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit)sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                var employee = new EMPLOYEE();
                if (m_Status == Actions.Add)
                {
                    if (employee.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
                        txt.Focus();
                    }

                }
            }
        }

        protected override void txtID_EditValueChanged(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (m_Status == Actions.Add)
            {
                var employee = new EMPLOYEE();
                if (employee.Exist(txt.Text))
                {
                    Err.SetError(txt, "Mã đã tồn tại.");
                    txt.Focus();
                }
            }

        }

        #endregion

        public void Clear()
        {
            txtID.Text = "";
            txtNAME.Text = "";
            //txtDescription.Text = "";
        }

        public override void Add()
        {
            var customer=new EMPLOYEE();
            txtID.Text = customer.NewID();
            txtNAME.Focus();
        }

        public void Add(EMPLOYEE item)
        {
            m_Status = Actions.Add;
            txtID.Text = item.Employee_ID;
            if (item.Exist(item.Employee_ID) | item.Employee_ID == "")
            {
                txtID.Text = item.NewID();
            }
            txtNAME.Text = item.Employee_Name;
            
            // txtDescription.Text = item.Description;
            chxUse.Checked = item.Active;
        }

        private void cbxDepartment_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Tag.ToString()=="Add")
            {
                var xfmDepartmentAdd=new XfmDepartmentAdd(Actions.Add);
                xfmDepartmentAdd.Added += xfmDepartmentAdd_Added;
                xfmDepartmentAdd.Show(this);
            }
        }

        void xfmDepartmentAdd_Added(object sender, DEPARTMENT item)
        {
            DepartmentInit();
            cbxDepartment.EditValue = item.Department_ID;
        }

        private void cbxLeader_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString()=="Add")
            {
                var xfmEmployeeAdd=new XfmEmployeeAdd(Actions.Add);
                xfmEmployeeAdd.Added += xfmEmployeeAdd_Added;
                xfmEmployeeAdd.Show(this);
            }
        }

        void xfmEmployeeAdd_Added(object sender, EMPLOYEE item)
        {
            EmployeeInit();
            cbxLeader.EditValue = item.Employee_ID;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
