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
    public partial class JobRole : Form
    {
        JobClass job = new JobClass();
        public JobRole()
        {
            InitializeComponent();
            dgb_depart10.DataSource = job.GetJobRole();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
               
                job.Job_Role_name = txtName.Text.Trim();
                
                var success = job.InsertJobRole(job);
                dgb_depart10.DataSource = job.GetJobRole();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("Job Role has been added successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again......");
                }
        }
        private void ClearControls()
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           job.Job_Role_ID = Convert.ToInt32(txtID.Text.Trim());
           job.Job_Role_name = txtName.Text.Trim();

            var success = job.UpdateJobRole(job);
            dgb_depart10.DataSource = job.GetJobRole();
            if (success)
            {
                ClearControls();
                MessageBox.Show("Job Role has been Update successfully!");
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again......");
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            job.Job_Role_ID = Convert.ToInt32(txtID.Text.Trim());
            var success = job.DeleteJobRole(job);
            dgb_depart10.DataSource = job.GetJobRole();
            if (success)
            {
                ClearControls();
                MessageBox.Show("Job Role has been Deleted successfully!");
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

        private void dgb_depart10_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            txtID.Text = dgb_depart10.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgb_depart10.Rows[index].Cells[1].Value.ToString();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void JobRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
