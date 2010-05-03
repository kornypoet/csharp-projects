namespace Asg04
{
    partial class MainForm
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
            this.NameDateStrip = new System.Windows.Forms.StatusStrip();
            this.lblNameStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailSearch = new System.Windows.Forms.TextBox();
            this.btnEmailSearch = new System.Windows.Forms.Button();
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkActiveCustomerBox = new System.Windows.Forms.CheckBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lstCustomerAccounts = new System.Windows.Forms.ListBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.grpAccountInformation = new System.Windows.Forms.GroupBox();
            this.lblAcountDeposit = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtAccountDeposit = new System.Windows.Forms.TextBox();
            this.checkSavings = new System.Windows.Forms.CheckBox();
            this.checkChecking = new System.Windows.Forms.CheckBox();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.btnCancelAccount = new System.Windows.Forms.Button();
            this.NameDateStrip.SuspendLayout();
            this.grpCustomerInformation.SuspendLayout();
            this.grpAccountInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameDateStrip
            // 
            this.NameDateStrip.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameDateStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNameStatus,
            this.lblDateStatus});
            this.NameDateStrip.Location = new System.Drawing.Point(0, 440);
            this.NameDateStrip.Name = "NameDateStrip";
            this.NameDateStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.NameDateStrip.Size = new System.Drawing.Size(671, 22);
            this.NameDateStrip.TabIndex = 0;
            this.NameDateStrip.Text = "statusStrip1";
            // 
            // lblNameStatus
            // 
            this.lblNameStatus.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameStatus.Name = "lblNameStatus";
            this.lblNameStatus.Size = new System.Drawing.Size(616, 17);
            this.lblNameStatus.Spring = true;
            this.lblNameStatus.Text = "Name";
            this.lblNameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateStatus
            // 
            this.lblDateStatus.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStatus.Name = "lblDateStatus";
            this.lblDateStatus.Size = new System.Drawing.Size(36, 17);
            this.lblDateStatus.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Search";
            // 
            // txtEmailSearch
            // 
            this.txtEmailSearch.Location = new System.Drawing.Point(160, 12);
            this.txtEmailSearch.Name = "txtEmailSearch";
            this.txtEmailSearch.Size = new System.Drawing.Size(275, 23);
            this.txtEmailSearch.TabIndex = 2;
            // 
            // btnEmailSearch
            // 
            this.btnEmailSearch.Location = new System.Drawing.Point(472, 9);
            this.btnEmailSearch.Name = "btnEmailSearch";
            this.btnEmailSearch.Size = new System.Drawing.Size(75, 29);
            this.btnEmailSearch.TabIndex = 3;
            this.btnEmailSearch.Text = "Search";
            this.btnEmailSearch.UseVisualStyleBackColor = true;
            this.btnEmailSearch.Click += new System.EventHandler(this.btnEmailSearch_Click);
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.txtEmailAddress);
            this.grpCustomerInformation.Controls.Add(this.txtTelephone);
            this.grpCustomerInformation.Controls.Add(this.txtZipCode);
            this.grpCustomerInformation.Controls.Add(this.txtState);
            this.grpCustomerInformation.Controls.Add(this.label9);
            this.grpCustomerInformation.Controls.Add(this.label8);
            this.grpCustomerInformation.Controls.Add(this.label7);
            this.grpCustomerInformation.Controls.Add(this.label6);
            this.grpCustomerInformation.Controls.Add(this.checkActiveCustomerBox);
            this.grpCustomerInformation.Controls.Add(this.txtCity);
            this.grpCustomerInformation.Controls.Add(this.txtAddress);
            this.grpCustomerInformation.Controls.Add(this.txtLastName);
            this.grpCustomerInformation.Controls.Add(this.txtFirstName);
            this.grpCustomerInformation.Controls.Add(this.label5);
            this.grpCustomerInformation.Controls.Add(this.label4);
            this.grpCustomerInformation.Controls.Add(this.label3);
            this.grpCustomerInformation.Controls.Add(this.label2);
            this.grpCustomerInformation.Enabled = false;
            this.grpCustomerInformation.Location = new System.Drawing.Point(15, 41);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(532, 231);
            this.grpCustomerInformation.TabIndex = 4;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(379, 63);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(147, 23);
            this.txtEmailAddress.TabIndex = 11;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(379, 33);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(147, 23);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(96, 183);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(147, 23);
            this.txtZipCode.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(96, 153);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(147, 23);
            this.txtState.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telephone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "State";
            // 
            // checkActiveCustomerBox
            // 
            this.checkActiveCustomerBox.AutoSize = true;
            this.checkActiveCustomerBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkActiveCustomerBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkActiveCustomerBox.Location = new System.Drawing.Point(276, 95);
            this.checkActiveCustomerBox.Name = "checkActiveCustomerBox";
            this.checkActiveCustomerBox.Size = new System.Drawing.Size(126, 20);
            this.checkActiveCustomerBox.TabIndex = 8;
            this.checkActiveCustomerBox.TabStop = false;
            this.checkActiveCustomerBox.Text = "Active Customer";
            this.checkActiveCustomerBox.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(96, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(147, 23);
            this.txtCity.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 93);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 23);
            this.txtAddress.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(96, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(147, 23);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(96, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(147, 23);
            this.txtFirstName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Enabled = false;
            this.btnDeleteAccount.Location = new System.Drawing.Point(248, 93);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteAccount.TabIndex = 21;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Enabled = false;
            this.btnEditAccount.Location = new System.Drawing.Point(248, 57);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(75, 29);
            this.btnEditAccount.TabIndex = 20;
            this.btnEditAccount.Text = "Edit";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(248, 22);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 29);
            this.btnAddAccount.TabIndex = 19;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lstCustomerAccounts
            // 
            this.lstCustomerAccounts.FormattingEnabled = true;
            this.lstCustomerAccounts.ItemHeight = 16;
            this.lstCustomerAccounts.Location = new System.Drawing.Point(14, 22);
            this.lstCustomerAccounts.Name = "lstCustomerAccounts";
            this.lstCustomerAccounts.Size = new System.Drawing.Size(228, 100);
            this.lstCustomerAccounts.TabIndex = 17;
            this.lstCustomerAccounts.SelectedValueChanged += new System.EventHandler(this.lstCustomerAccounts_SelectedValueChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(572, 71);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Enabled = false;
            this.btnSaveCustomer.Location = new System.Drawing.Point(572, 200);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnSaveCustomer.TabIndex = 12;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(572, 157);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(572, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Enabled = false;
            this.btnEditCustomer.Location = new System.Drawing.Point(572, 114);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnEditCustomer.TabIndex = 9;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchResult.Location = new System.Drawing.Point(569, 15);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(0, 16);
            this.lblSearchResult.TabIndex = 10;
            // 
            // grpAccountInformation
            // 
            this.grpAccountInformation.Controls.Add(this.btnCancelAccount);
            this.grpAccountInformation.Controls.Add(this.btnSaveAccount);
            this.grpAccountInformation.Controls.Add(this.lblAcountDeposit);
            this.grpAccountInformation.Controls.Add(this.lblAccountType);
            this.grpAccountInformation.Controls.Add(this.txtAccountDeposit);
            this.grpAccountInformation.Controls.Add(this.checkSavings);
            this.grpAccountInformation.Controls.Add(this.checkChecking);
            this.grpAccountInformation.Controls.Add(this.btnEditAccount);
            this.grpAccountInformation.Controls.Add(this.btnDeleteAccount);
            this.grpAccountInformation.Controls.Add(this.lstCustomerAccounts);
            this.grpAccountInformation.Controls.Add(this.btnAddAccount);
            this.grpAccountInformation.Enabled = false;
            this.grpAccountInformation.Location = new System.Drawing.Point(16, 289);
            this.grpAccountInformation.Name = "grpAccountInformation";
            this.grpAccountInformation.Size = new System.Drawing.Size(631, 137);
            this.grpAccountInformation.TabIndex = 22;
            this.grpAccountInformation.TabStop = false;
            this.grpAccountInformation.Text = "Account Information";
            // 
            // lblAcountDeposit
            // 
            this.lblAcountDeposit.AutoSize = true;
            this.lblAcountDeposit.Location = new System.Drawing.Point(340, 63);
            this.lblAcountDeposit.Name = "lblAcountDeposit";
            this.lblAcountDeposit.Size = new System.Drawing.Size(86, 16);
            this.lblAcountDeposit.TabIndex = 26;
            this.lblAcountDeposit.Text = "Deposit Amt:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(340, 28);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(93, 16);
            this.lblAccountType.TabIndex = 25;
            this.lblAccountType.Text = "Account Type:";
            // 
            // txtAccountDeposit
            // 
            this.txtAccountDeposit.Enabled = false;
            this.txtAccountDeposit.Location = new System.Drawing.Point(442, 60);
            this.txtAccountDeposit.Name = "txtAccountDeposit";
            this.txtAccountDeposit.Size = new System.Drawing.Size(83, 23);
            this.txtAccountDeposit.TabIndex = 24;
            // 
            // checkSavings
            // 
            this.checkSavings.AutoSize = true;
            this.checkSavings.Enabled = false;
            this.checkSavings.Location = new System.Drawing.Point(551, 27);
            this.checkSavings.Name = "checkSavings";
            this.checkSavings.Size = new System.Drawing.Size(74, 20);
            this.checkSavings.TabIndex = 23;
            this.checkSavings.Text = "Savings";
            this.checkSavings.UseVisualStyleBackColor = true;
            this.checkSavings.CheckedChanged += new System.EventHandler(this.checkSavings_CheckedChanged);
            // 
            // checkChecking
            // 
            this.checkChecking.AutoSize = true;
            this.checkChecking.Checked = true;
            this.checkChecking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkChecking.Enabled = false;
            this.checkChecking.Location = new System.Drawing.Point(442, 27);
            this.checkChecking.Name = "checkChecking";
            this.checkChecking.Size = new System.Drawing.Size(83, 20);
            this.checkChecking.TabIndex = 22;
            this.checkChecking.Text = "Checking";
            this.checkChecking.UseVisualStyleBackColor = true;
            this.checkChecking.CheckedChanged += new System.EventHandler(this.checkChecking_CheckedChanged);
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Enabled = false;
            this.btnSaveAccount.Location = new System.Drawing.Point(551, 57);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(75, 29);
            this.btnSaveAccount.TabIndex = 27;
            this.btnSaveAccount.Text = "Save";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Enabled = false;
            this.btnCancelAccount.Location = new System.Drawing.Point(551, 93);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(75, 29);
            this.btnCancelAccount.TabIndex = 28;
            this.btnCancelAccount.Text = "Cancel";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            this.btnCancelAccount.Click += new System.EventHandler(this.btnCancelAccount_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 462);
            this.Controls.Add(this.grpAccountInformation);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.grpCustomerInformation);
            this.Controls.Add(this.btnEmailSearch);
            this.Controls.Add(this.txtEmailSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameDateStrip);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Maintenence";
            this.NameDateStrip.ResumeLayout(false);
            this.NameDateStrip.PerformLayout();
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpAccountInformation.ResumeLayout(false);
            this.grpAccountInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip NameDateStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblNameStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblDateStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailSearch;
        private System.Windows.Forms.Button btnEmailSearch;
        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkActiveCustomerBox;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ListBox lstCustomerAccounts;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.GroupBox grpAccountInformation;
        private System.Windows.Forms.TextBox txtAccountDeposit;
        private System.Windows.Forms.CheckBox checkSavings;
        private System.Windows.Forms.CheckBox checkChecking;
        private System.Windows.Forms.Label lblAcountDeposit;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnCancelAccount;
        private System.Windows.Forms.Button btnSaveAccount;
    }
}

