using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class SalarySetting : Form
    {
        SalarySet salset = new SalarySet();
        
        public SalarySetting()
        {
            InitializeComponent();
            dgvsalset.DataSource = salset.GetSalarySet();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                salset.Dept_ID = Convert.ToInt32(txtID.Text.Trim());
                salset.JobRoleID = Convert.ToInt32(txtJobRoleID.Text.Trim());
                salset.Bonus = float.Parse(txtBonus.Text.Trim());
                var success = salset.InsertsalarySet(salset);
                dgvsalset.DataSource = salset.GetSalarySet();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("salary Set has been added successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again......");
                }
            }

            catch (FormatException fx)
            {
                MessageBox.Show("Data mustn't be empty and Inputs should be in correct format.\nEmp.Age =>Integer");
            }

        }
        private void ClearControls()
        {
            txtID.Text = "";
            txtJobRoleID.Text = "";
            txtBonus.Text = "";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                salset.Dept_ID = Convert.ToInt32(txtID.Text.Trim());
                salset.JobRoleID = Convert.ToInt32(txtJobRoleID.Text.Trim());
                salset.Bonus = float.Parse(txtBonus.Text.Trim());
                var success = salset.UpdateSalarySet(salset);
                dgvsalset.DataSource = salset.GetSalarySet();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("Salary Set has been Update successfully!");
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
                MessageBox.Show("Data mustn't be empty and Inputs should be in correct format.\nEmp.Age =>Integer");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            salset.Dept_ID = Convert.ToInt32(txtID.Text.Trim());
            salset.JobRoleID = Convert.ToInt32(txtJobRoleID.Text.Trim());
            var success = salset.DeleteSalarySet(salset);
            dgvsalset.DataSource = salset.GetSalarySet();
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

        private void dgvsalset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvsalset_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            txtID.Text = dgvsalset.Rows[index].Cells[0].Value.ToString();
            txtJobRoleID.Text = dgvsalset.Rows[index].Cells[1].Value.ToString();
            txtBonus.Text = dgvsalset.Rows[index].Cells[2].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void SalarySetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
