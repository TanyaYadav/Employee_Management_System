
namespace EmployeeManagementSystem
{
    partial class frmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSal_Id = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtempId = new System.Windows.Forms.TextBox();
            this.dgvSalDetails = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTDS = new System.Windows.Forms.TextBox();
            this.txtBonus2 = new System.Windows.Forms.TextBox();
            this.txtOA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emp. ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basicsalary";
            // 
            // txtSal_Id
            // 
            this.txtSal_Id.Enabled = false;
            this.txtSal_Id.Location = new System.Drawing.Point(183, 143);
            this.txtSal_Id.Name = "txtSal_Id";
            this.txtSal_Id.Size = new System.Drawing.Size(166, 22);
            this.txtSal_Id.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(183, 267);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(166, 22);
            this.txtAmount.TabIndex = 8;
            // 
            // txtempId
            // 
            this.txtempId.Location = new System.Drawing.Point(183, 205);
            this.txtempId.Name = "txtempId";
            this.txtempId.Size = new System.Drawing.Size(166, 22);
            this.txtempId.TabIndex = 0;
            // 
            // dgvSalDetails
            // 
            this.dgvSalDetails.AllowUserToAddRows = false;
            this.dgvSalDetails.AllowUserToDeleteRows = false;
            this.dgvSalDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalDetails.Location = new System.Drawing.Point(403, 143);
            this.dgvSalDetails.Name = "dgvSalDetails";
            this.dgvSalDetails.ReadOnly = true;
            this.dgvSalDetails.RowHeadersWidth = 51;
            this.dgvSalDetails.RowTemplate.Height = 24;
            this.dgvSalDetails.Size = new System.Drawing.Size(752, 540);
            this.dgvSalDetails.TabIndex = 10;
            this.dgvSalDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSalDetails_RowHeaderMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(131, 690);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(267, 690);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(403, 689);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(539, 689);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTDS
            // 
            this.txtTDS.Location = new System.Drawing.Point(183, 551);
            this.txtTDS.Name = "txtTDS";
            this.txtTDS.Size = new System.Drawing.Size(166, 22);
            this.txtTDS.TabIndex = 17;
            // 
            // txtBonus2
            // 
            this.txtBonus2.Enabled = false;
            this.txtBonus2.Location = new System.Drawing.Point(183, 499);
            this.txtBonus2.Name = "txtBonus2";
            this.txtBonus2.Size = new System.Drawing.Size(166, 22);
            this.txtBonus2.TabIndex = 18;
            // 
            // txtOA
            // 
            this.txtOA.Location = new System.Drawing.Point(183, 437);
            this.txtOA.Name = "txtOA";
            this.txtOA.Size = new System.Drawing.Size(166, 22);
            this.txtOA.TabIndex = 19;
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(183, 379);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(166, 22);
            this.txtDA.TabIndex = 20;
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(183, 327);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(166, 22);
            this.txtHRA.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bonus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "OtherAllow.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "DA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "HRA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "PF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "TDS";
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(183, 599);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(166, 22);
            this.txtPF.TabIndex = 28;
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1180, 748);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtOA);
            this.Controls.Add(this.txtBonus2);
            this.Controls.Add(this.txtTDS);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSalDetails);
            this.Controls.Add(this.txtempId);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtSal_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalary";
            this.Text = "Salary Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalary_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSal_Id;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtempId;
        private System.Windows.Forms.DataGridView dgvSalDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTDS;
        private System.Windows.Forms.TextBox txtBonus2;
        private System.Windows.Forms.TextBox txtOA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPF;
    }
}