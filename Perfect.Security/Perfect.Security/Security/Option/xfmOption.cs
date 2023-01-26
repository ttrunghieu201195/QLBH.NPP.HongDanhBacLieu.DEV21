using System;
using System.Windows.Forms;

namespace Perfect.Security
{
    public partial class xfmOption : DevExpress.XtraEditors.XtraForm
    {
        public xfmOption()
        {
            InitializeComponent();
        }

        private void xfmOption_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dsOption.SYS_OPTION' table. You can move, or remove it, as needed.
            ////this.sYS_OPTIONTableAdapter.Fill(this.dsOption.SYS_OPTION);
            ////SYS_OPTION.WriteXml(Application.StartupPath + "\\Option.xml");
            //if (!System.IO.File.Exists(Application.StartupPath + "\\Option.xml"))
            //{
            //    this.sYS_OPTIONTableAdapter.Fill(this.dsOption.SYS_OPTION);
            //}
            //else
            //{
            //    dsOption.SYS_OPTION.ReadXml(Application.StartupPath + "\\Option.xml");
            //    if ( dsOption.SYS_OPTION.Rows.Count > 3)  
            //    {
            //        cbxLanguage.Text = dsOption.SYS_OPTION.Rows[0][1].ToString();
            //        txtLimit.Text = dsOption.SYS_OPTION.Rows[1][1].ToString();
            //        txtOld.Text = dsOption.SYS_OPTION.Rows[2][1].ToString();
            //    }
                
            //}

        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            //{
            //   dsOption.SYS_OPTION.Rows[0][1]= cbxLanguage.Text;
            //   dsOption.SYS_OPTION.Rows[1][1] = txtLimit.Text;
            //   dsOption.SYS_OPTION.Rows[2][1] = txtOld.Text;

            //    //dsOption.SYS_OPTION.WriteXml(Application.StartupPath + "\\Option.xml");
            //    XtraMessageBox.Show("Data is saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
               // dgvList.BeginEdit(true);
            }
        }

        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex==0)
            {
                //string Val=dgvList[e.ColumnIndex,e.RowIndex].Value.ToString();

                //if (Val!="VN" || Val!="EN" )
                //{
                //   // dgvList[e.ColumnIndex, e.RowIndex].Value = "VN";
                //}
            }
        }
    }
}