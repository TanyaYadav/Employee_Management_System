
namespace EmployeeManagementSystem
{
    partial class MainPortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarySettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.departmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobDepartmentToolStripMenuItem,
            this.jobRoleToolStripMenuItem,
            this.employeeToolStripMenuItem1});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // jobDepartmentToolStripMenuItem
            // 
            this.jobDepartmentToolStripMenuItem.Name = "jobDepartmentToolStripMenuItem";
            this.jobDepartmentToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.jobDepartmentToolStripMenuItem.Text = "Job Department";
            this.jobDepartmentToolStripMenuItem.Click += new System.EventHandler(this.jobDepartmentToolStripMenuItem_Click);
            // 
            // jobRoleToolStripMenuItem
            // 
            this.jobRoleToolStripMenuItem.Name = "jobRoleToolStripMenuItem";
            this.jobRoleToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.jobRoleToolStripMenuItem.Text = "Job Role";
            this.jobRoleToolStripMenuItem.Click += new System.EventHandler(this.jobRoleToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(208, 26);
            this.employeeToolStripMenuItem1.Text = "Employee Details";
            this.employeeToolStripMenuItem1.Click += new System.EventHandler(this.employeeToolStripMenuItem1_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentDetailsToolStripMenuItem,
            this.qualificationDetailsToolStripMenuItem,
            this.salarySettingToolStripMenuItem,
            this.salaryDetailsToolStripMenuItem,
            this.payrollDetailsToolStripMenuItem});
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // departmentDetailsToolStripMenuItem
            // 
            this.departmentDetailsToolStripMenuItem.Name = "departmentDetailsToolStripMenuItem";
            this.departmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.departmentDetailsToolStripMenuItem.Text = "Department Details";
            this.departmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.departmentDetailsToolStripMenuItem_Click);
            // 
            // qualificationDetailsToolStripMenuItem
            // 
            this.qualificationDetailsToolStripMenuItem.Name = "qualificationDetailsToolStripMenuItem";
            this.qualificationDetailsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.qualificationDetailsToolStripMenuItem.Text = "Qualification Details";
            this.qualificationDetailsToolStripMenuItem.Click += new System.EventHandler(this.qualificationDetailsToolStripMenuItem_Click);
            // 
            // salaryDetailsToolStripMenuItem
            // 
            this.salaryDetailsToolStripMenuItem.Name = "salaryDetailsToolStripMenuItem";
            this.salaryDetailsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.salaryDetailsToolStripMenuItem.Text = "Salary Details";
            this.salaryDetailsToolStripMenuItem.Click += new System.EventHandler(this.salaryDetailsToolStripMenuItem_Click);
            // 
            // payrollDetailsToolStripMenuItem
            // 
            this.payrollDetailsToolStripMenuItem.Name = "payrollDetailsToolStripMenuItem";
            this.payrollDetailsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.payrollDetailsToolStripMenuItem.Text = "Payroll Details";
            this.payrollDetailsToolStripMenuItem.Click += new System.EventHandler(this.payrollDetailsToolStripMenuItem_Click);
            // 
            // salarySettingToolStripMenuItem
            // 
            this.salarySettingToolStripMenuItem.Name = "salarySettingToolStripMenuItem";
            this.salarySettingToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.salarySettingToolStripMenuItem.Text = "Salary Setting";
            this.salarySettingToolStripMenuItem.Click += new System.EventHandler(this.salarySettingToolStripMenuItem_Click);
            // 
            // MainPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 806);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPortal";
            this.Text = "MainPortal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPortal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salarySettingToolStripMenuItem;
    }
}



