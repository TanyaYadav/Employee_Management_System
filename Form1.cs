using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmEmployee : Form
    {
        Employee employee = new Employee();
        public frmEmployee()
        {
            InitializeComponent();
            dgvDetails.DataSource = employee.GetEmployees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                employee.Dept_ID = Convert.ToInt32(txtDeptID.Text.Trim());
                employee.Job_Role_ID = Convert.ToInt32(txtJobRoleID.Text.Trim());

                employee.Emp_FName = txtfname.Text.Trim();
                employee.Emp_LName = txtlname.Text.Trim();
                employee.Emp_Age = Convert.ToInt32(txtAge.Text.Trim());
                employee.Emp_Contact = txtContact.Text.Trim();
                employee.Emp_Gender = cmbGender.SelectedItem.ToString();
                employee.Emp_email = txtEmail.Text.Trim();
                var success = employee.InsertEmployee(employee);
                dgvDetails.DataSource = employee.GetEmployees();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("Employee has been added successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again......");
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show("Job Role Id or Dept. ID don't match with previous data so create new one.... ");
            }

            catch (FormatException fx)
            {
                MessageBox.Show("Data mustn't be empty and Inputs should be in correct format.\nEmp.Age should be in numbers");
            }
        }
        private void ClearControls()
        {
            txtID.Text = "";
            txtDeptID.Text = "";
            txtJobRoleID.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtAge.Text = "";
            txtContact.Text = "";
            cmbGender.SelectedIndex = -1;
            txtEmail.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try{
                employee.Emp_ID = Convert.ToInt32(txtID.Text.Trim());
                employee.Dept_ID = Convert.ToInt32(txtDeptID.Text.Trim());
                employee.Job_Role_ID = Convert.ToInt32(txtJobRoleID.Text.Trim());
                
                employee.Emp_FName = txtfname.Text.Trim();
                employee.Emp_LName = txtlname.Text.Trim();
                employee.Emp_Age = Convert.ToInt32(txtAge.Text.Trim());
                employee.Emp_Contact = txtContact.Text.Trim();
                employee.Emp_Gender = cmbGender.SelectedItem.ToString();
                employee.Emp_email = txtEmail.Text.Trim();
                var success = employee.UpdateEmployee(employee);
                dgvDetails.DataSource = employee.GetEmployees();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("Employee has been Update successfully!");
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again......");
                } 
            }
            catch (FormatException fx)
            {
                MessageBox.Show("Data mustn't be empty and Inputs should be in correct format.\nEmp.Age should be in numbers");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            employee.Emp_ID = Convert.ToInt32(txtID.Text.Trim());
            var success = employee.DeleteEmployee(employee);
            dgvDetails.DataSource = employee.GetEmployees();
            if (success)
            {
                ClearControls();
                MessageBox.Show("Employee has been Deleted successfully!");
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again......");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var index = e.RowIndex;
            txtID.Text = dgvDetails.Rows[index].Cells[0].Value.ToString();
            txtJobRoleID.Text= dgvDetails.Rows[index].Cells[1].Value.ToString();
            txtDeptID.Text = dgvDetails.Rows[index].Cells[2].Value.ToString();
            txtfname.Text = dgvDetails.Rows[index].Cells[3].Value.ToString();
            txtlname.Text = dgvDetails.Rows[index].Cells[4].Value.ToString();
            txtAge.Text = dgvDetails.Rows[index].Cells[5].Value.ToString();
            txtContact.Text = dgvDetails.Rows[index].Cells[6].Value.ToString();
            cmbGender.Text = dgvDetails.Rows[index].Cells[7].Value.ToString();
            txtEmail.Text = dgvDetails.Rows[index].Cells[8].Value.ToString();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
