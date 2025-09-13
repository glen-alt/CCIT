using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            if(txtRequestorName.Text == "" || txtEmailAddress.Text == "" || txtLocalNumber.Text == "" || cmbSection.Text == "" || txtEmpID.Text == "")
            {
                MessageBox.Show("Incomplete/Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
                cmbSection.Text = "";
            }
            else
            {
                MessageBox.Show("Insert to DB", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "Select * from [tblEmployeeData] where [RequestorName] = '" + txtRequestorName.Text + "' ";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
            if (dtg_addrequestor == true)
            {
                MessageBox.Show("This account " + txtRequestorName.Text + "already exist.", "Not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
            }
            else
            {
                string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName],[RequestorEmail],[Section], [LocalNumber]) values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
