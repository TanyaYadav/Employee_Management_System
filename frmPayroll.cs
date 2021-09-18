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
    public partial class frmPayroll : Form
    {
        Payroll payroll = new Payroll();
       
        public frmPayroll()
        {
            InitializeComponent();
            dgvPayroll.DataSource = payroll.GetPayroll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                payroll.Emp_ID = Convert.ToInt32(txtEmp_ID.Text.Trim());
                payroll.Salary_ID = Convert.ToInt32(txtSal_ID.Text.Trim());
                payroll.Leaves = Convert.ToInt32(txtLeaves.Text.Trim());
                payroll.Date = txtDate.Text.Trim();
                payroll.Remark = txtReport.Text.Trim();
                
                

                var success = payroll.InsertPayroll(payroll);
                dgvPayroll.DataSource = payroll.GetPayroll();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("Payroll has been added successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again......");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Employee Id or Salary Id don't match with previous data. For new data first create one");
            }
            catch (FormatException fx)
            {
                MessageBox.Show("Data mustn't be empty and Inputs should be in correct format.\nEmp. ID, Salary Id and leaves should be in numbers");
            }

        }
        private void ClearControls()
        {
            txtPay_ID.Text = "";
            txtEmp_ID.Text = "";
            txtSal_ID.Text = "";
            txtLeaves.Text = "";
            txtDate.Text = "";
            txtReport.Text = "";
            txtAmount.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                payroll.Payroll_Id = Convert.ToInt32(txtPay_ID.Text.Trim());
                payroll.Emp_ID = Convert.ToInt32(txtEmp_ID.Text.Trim());
                payroll.Salary_ID = Convert.ToInt32(txtSal_ID.Text.Trim());
                payroll.Leaves = Convert.ToInt32(txtLeaves.Text.Trim());
                payroll.Date = txtDate.Text.Trim();
                payroll.Remark = txtReport.Text.Trim();
                payroll.Total_Amount = float.Parse(txtAmount.Text.Trim());

                var success = payroll.UpdatePayroll(payroll);
                dgvPayroll.DataSource = payroll.GetPayroll();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("Payroll has been updated successfully!");
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error occured. Please try again......");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Employee Id or Salary Id don't match with previous data. For new data first create one");
            }
            catch (FormatException fx)
            {
                MessageBox.Show("Data mustn't be empty and Inputs should be in correct format.\n Emp. ID , Salary ID and Leaves should be in number");
            }
        }

        private void dgvPayroll_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            txtPay_ID.Text = dgvPayroll.Rows[index].Cells[0].Value.ToString();
            txtEmp_ID.Text = dgvPayroll.Rows[index].Cells[1].Value.ToString();
            txtSal_ID.Text = dgvPayroll.Rows[index].Cells[2].Value.ToString();
            txtLeaves.Text = dgvPayroll.Rows[index].Cells[3].Value.ToString();
            txtDate.Text = dgvPayroll.Rows[index].Cells[4].Value.ToString();
            txtReport.Text= dgvPayroll.Rows[index].Cells[5].Value.ToString();
            txtAmount.Text = dgvPayroll.Rows[index].Cells[6].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
           
        }

        private void frmPayroll_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
