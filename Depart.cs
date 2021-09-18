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
    public partial class Depart : Form
    {
        Depart2 department = new Depart2();
        public Depart()
        {
            InitializeComponent();
        }

        private void Depart_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            department.Dept_Name = txtName.Text.Trim();
            var success = department.InsertDepartment(department);
            dgb_depart.DataSource = department.GetDepartment();
            if (success)
            {
                ClearControls();
                MessageBox.Show("Department has been added successfully!");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again......");
            }
        }
        public void ClearControls()
        {
            txtName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            department.Dept_Name = txtName.Text.Trim();
            var success = department.UpdateDepartment(department);
            dgb_depart.DataSource = department.GetDepartment();
            if (success)
            {
                ClearControls();
                MessageBox.Show("Department has been Update successfully!");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again......");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            department.Dept_Id = Convert.ToInt32(txtID.Text.Trim());
            var success = department.DeleteDepartment(department);
            dgb_depart.DataSource = department.GetDepartment();
            if (success)
            {
                ClearControls();
                MessageBox.Show("Department has been deleted successfully!");
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

        private void dgb_depart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgb_depart_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            txtID.Text = dgb_depart.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgb_depart.Rows[index].Cells[1].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void Depart_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
