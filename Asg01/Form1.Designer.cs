namespace Asg01
{
    partial class Form1
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.lstPersonList = new System.Windows.Forms.ListBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateOfAccount = new System.Windows.Forms.TextBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDateOfAccount = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.grpEditDetails = new System.Windows.Forms.GroupBox();
            this.grpControls.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpEditDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 13);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(94, 41);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.TabStop = false;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 60);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(94, 41);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.TabStop = false;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(106, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 41);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(106, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(6, 107);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(194, 41);
            this.btnCreateReport.TabIndex = 4;
            this.btnCreateReport.TabStop = false;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // lstPersonList
            // 
            this.lstPersonList.FormattingEnabled = true;
            this.lstPersonList.Location = new System.Drawing.Point(12, 13);
            this.lstPersonList.Name = "lstPersonList";
            this.lstPersonList.Size = new System.Drawing.Size(206, 186);
            this.lstPersonList.Sorted = true;
            this.lstPersonList.TabIndex = 5;
            this.lstPersonList.TabStop = false;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnAddEmployee);
            this.grpControls.Controls.Add(this.btnAddCustomer);
            this.grpControls.Controls.Add(this.btnCreateReport);
            this.grpControls.Controls.Add(this.btnEdit);
            this.grpControls.Controls.Add(this.btnDelete);
            this.grpControls.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpControls.Location = new System.Drawing.Point(12, 205);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(206, 156);
            this.grpControls.TabIndex = 6;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpDetails.Controls.Add(this.txtAddress);
            this.grpDetails.Controls.Add(this.label8);
            this.grpDetails.Controls.Add(this.txtEmailAddress);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.dtpDateOfBirth);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(225, 13);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(394, 186);
            this.grpDetails.TabIndex = 7;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.Location = new System.Drawing.Point(133, 143);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(224, 37);
            this.txtAddress.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(133, 81);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(224, 20);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(224, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(224, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDateOfBirth.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpDateOfBirth.CustomFormat = "00/00/0000";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(133, 112);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2009, 12, 12, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.ShowUpDown = true;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(224, 20);
            this.dtpDateOfBirth.TabIndex = 4;
            this.dtpDateOfBirth.Value = new System.DateTime(2009, 5, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtDateOfAccount
            // 
            this.txtDateOfAccount.Location = new System.Drawing.Point(132, 79);
            this.txtDateOfAccount.Name = "txtDateOfAccount";
            this.txtDateOfAccount.ReadOnly = true;
            this.txtDateOfAccount.Size = new System.Drawing.Size(224, 20);
            this.txtDateOfAccount.TabIndex = 19;
            this.txtDateOfAccount.TabStop = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(262, 106);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(94, 41);
            this.btnAddCancel.TabIndex = 7;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(132, 106);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(94, 41);
            this.btnAddSave.TabIndex = 6;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(25, 54);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 14);
            this.lblSalary.TabIndex = 14;
            this.lblSalary.Text = "Salary";
            // 
            // lblDateOfAccount
            // 
            this.lblDateOfAccount.AutoSize = true;
            this.lblDateOfAccount.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfAccount.Location = new System.Drawing.Point(24, 82);
            this.lblDateOfAccount.Name = "lblDateOfAccount";
            this.lblDateOfAccount.Size = new System.Drawing.Size(97, 14);
            this.lblDateOfAccount.TabIndex = 13;
            this.lblDateOfAccount.Text = "Date of Account";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(132, 23);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(224, 20);
            this.txtAmountDue.TabIndex = 12;
            this.txtAmountDue.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount Due";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(132, 51);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(224, 20);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.TabStop = false;
            // 
            // grpEditDetails
            // 
            this.grpEditDetails.Controls.Add(this.txtDateOfAccount);
            this.grpEditDetails.Controls.Add(this.lblSalary);
            this.grpEditDetails.Controls.Add(this.btnAddCancel);
            this.grpEditDetails.Controls.Add(this.txtSalary);
            this.grpEditDetails.Controls.Add(this.label5);
            this.grpEditDetails.Controls.Add(this.txtAmountDue);
            this.grpEditDetails.Controls.Add(this.lblDateOfAccount);
            this.grpEditDetails.Controls.Add(this.btnAddSave);
            this.grpEditDetails.Location = new System.Drawing.Point(225, 205);
            this.grpEditDetails.Name = "grpEditDetails";
            this.grpEditDetails.Size = new System.Drawing.Size(394, 155);
            this.grpEditDetails.TabIndex = 20;
            this.grpEditDetails.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 370);
            this.Controls.Add(this.grpEditDetails);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.lstPersonList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asg01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpControls.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpEditDetails.ResumeLayout(false);
            this.grpEditDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.ListBox lstPersonList;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDateOfAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.TextBox txtDateOfAccount;
        private System.Windows.Forms.GroupBox grpEditDetails;

    }
}

