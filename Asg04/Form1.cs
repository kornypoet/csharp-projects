using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asg04
{
    public partial class MainForm : Form
    {
        private enum State
        {
            Viewing,
            Adding,
            Editing,
            AddAccount,
            EditAccount,
            ViewAccount
        };
        private State programState;
        private State ProgramState
        {
            get { return programState; }
            set
            {
                programState = value;
                UpdateForm();                
            }
        }

        public Customer currentCustomer = null;

        public MainForm()
        {
            InitializeComponent();
        }
        public void DisplayCustomer()
        {
            if (currentCustomer != null)
            {
                txtFirstName.Text = currentCustomer.FirstName;
                txtLastName.Text = currentCustomer.LastName;
                txtAddress.Text = currentCustomer.Address;
                txtCity.Text = currentCustomer.City;
                txtState.Text = currentCustomer.State;
                txtZipCode.Text = currentCustomer.ZipCode;
                txtTelephone.Text = currentCustomer.TelephoneNumber;
                txtEmailAddress.Text = currentCustomer.EmailAddress;
                checkActiveCustomerBox.Checked = currentCustomer.IsCustomerActive;                
                DisplayAccounts();
            }
            else
            {
                txtFirstName.Text = null;
                txtLastName.Text = null;
                txtAddress.Text = null;
                txtCity.Text = null;
                txtState.Text = null;
                txtZipCode.Text = null;
                txtTelephone.Text = null;
                txtEmailAddress.Text = null;
                checkActiveCustomerBox.Checked = false;
                DisplayAccounts();
            }
        }
        public void DisplayAccounts()
        {
            lstCustomerAccounts.Items.Clear();            
            if (currentCustomer != null)
            {
                currentCustomer.AccountList.Clear();
                DatabaseService.RetrieveAccounts(currentCustomer);
                foreach (Account acc in currentCustomer.AccountList)
                {
                    lstCustomerAccounts.Items.Add(acc);
                }
            }
        }
        public void UpdateForm()
        {
            if (ProgramState == State.Adding)
            {
                txtEmailSearch.Enabled = false;
                btnAddCustomer.Enabled = false;
                btnEmailSearch.Enabled = false;
                btnEditCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;
                btnSaveCustomer.Enabled = true;
                btnCancel.Enabled = true;
                grpCustomerInformation.Enabled = true;
                grpAccountInformation.Enabled = false;
                lblSearchResult.Text = "Adding!";                
                DisplayCustomer();
            }
            if (ProgramState == State.Viewing)
            {
                txtEmailSearch.Enabled = true;
                btnAddCustomer.Enabled = true;
                btnEmailSearch.Enabled = true;
                btnEditCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;
                btnSaveCustomer.Enabled = false;
                btnCancel.Enabled = false;
                grpCustomerInformation.Enabled = false;
                grpAccountInformation.Enabled = false;
                lblSearchResult.Text = "";
                txtAccountDeposit.Text = null;
                DisplayCustomer();                
            }
            if (ProgramState == State.Editing)
            {
                txtEmailSearch.Enabled = false;
                btnAddCustomer.Enabled = false;
                btnEmailSearch.Enabled = false;
                btnEditCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;
                btnSaveCustomer.Enabled = true;
                btnCancel.Enabled = true;
                grpCustomerInformation.Enabled = true;
                grpAccountInformation.Enabled = true;
                lblSearchResult.Text = "Editing!";                
            }
            if (ProgramState == State.AddAccount)
            {
                btnAddAccount.Enabled = false;                
                lstCustomerAccounts.Enabled = false;
                lstCustomerAccounts.SelectedItem = null;
                checkSavings.Enabled = true;
                checkChecking.Enabled = true;
                txtAccountDeposit.Enabled = true;
                btnCancelAccount.Enabled = true;
                btnSaveAccount.Enabled = true;
                grpCustomerInformation.Enabled = false;
                btnSaveCustomer.Enabled = false;
                btnCancel.Enabled = false;
                txtAccountDeposit.Focus();
            }
            if (ProgramState == State.EditAccount)
            {
                btnAddAccount.Enabled = false;
                btnEditAccount.Enabled = false;
                btnDeleteAccount.Enabled = false;
                lstCustomerAccounts.Enabled = false;                
                checkSavings.Enabled = true;
                checkChecking.Enabled = true;
                txtAccountDeposit.Enabled = true;
                btnCancelAccount.Enabled = true;
                btnSaveAccount.Enabled = true;
                grpCustomerInformation.Enabled = false;
                btnSaveCustomer.Enabled = false;
                btnCancel.Enabled = false;
                txtAccountDeposit.Focus();
            }
            if (ProgramState == State.ViewAccount)
            {
                btnAddAccount.Enabled = true;                
                lstCustomerAccounts.Enabled = true;
                lstCustomerAccounts.SelectedItem = null;
                checkSavings.Enabled = false;
                checkChecking.Enabled = false;
                txtAccountDeposit.Enabled = false;
                btnCancelAccount.Enabled = false;
                btnSaveAccount.Enabled = false;
                grpCustomerInformation.Enabled = true;
                btnSaveCustomer.Enabled = true;
                btnCancel.Enabled = true;
                txtAccountDeposit.Text = null;                
            }
        }

        private void btnEmailSearch_Click(object sender, EventArgs e)
        {
            currentCustomer = DatabaseService.RetrieveCustomer(txtEmailSearch.Text);
            txtEmailSearch.Text = null;
            if (currentCustomer != null)
            {
                lblSearchResult.Text = "Found!";
                btnEditCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                DisplayCustomer();
                txtEmailSearch.Focus();
            }
            else
            {
                lblSearchResult.Text = "No Matches!";
                btnEditCustomer.Enabled = false;
                DisplayCustomer();
                txtEmailSearch.Focus();
            }                       
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Delete Customer?", "Warning!", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                DatabaseService.RemoveCustomer(currentCustomer);
                currentCustomer = null;
                ProgramState = State.Viewing;
            }
            else
                return;            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            currentCustomer = null;            
            ProgramState = State.Adding;
            txtFirstName.Focus();
            checkActiveCustomerBox.Checked = true;
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            ProgramState = State.Editing;
        } 

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            Customer cust;
            if (ProgramState == State.Adding)
                cust = new Customer();
            else
                cust = currentCustomer;
            try
            {
                cust.FirstName = txtFirstName.Text;
                cust.LastName = txtLastName.Text;
                cust.Address = txtAddress.Text;
                cust.City = txtCity.Text;
                cust.State = txtState.Text;
                cust.ZipCode = txtZipCode.Text;
                cust.TelephoneNumber = txtTelephone.Text;
                cust.EmailAddress = txtEmailAddress.Text;
                cust.IsCustomerActive = checkActiveCustomerBox.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
                return;
            }
            if (ProgramState == State.Adding)
                DatabaseService.AddCustomer(cust);
            else
                DatabaseService.EditCustomer(cust);

            currentCustomer = null;            
            ProgramState = State.Viewing; 
            lblSearchResult.Text = "Success!";            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            currentCustomer = null;
            ProgramState = State.Viewing;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Delete Account?", "Warning!", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                Account acc = (Account)lstCustomerAccounts.SelectedItem;
                DatabaseService.RemoveAccount(acc);                
                ProgramState = State.ViewAccount;
                DisplayAccounts();
            }
            else
                return;      
        } 

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            ProgramState = State.AddAccount;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            ProgramState = State.EditAccount;
            Account acc = (Account)lstCustomerAccounts.SelectedItem;
            txtAccountDeposit.Text = acc.AccountBalance.ToString();
            if (acc.AccountType == "Checking")
                checkChecking.Checked = true;
            else
                checkSavings.Checked = true;
        }

        //The timer keeps the status labels updated
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateStatus.Text = DateTime.Now.ToString();
            if (currentCustomer !=null)
            {
                lblNameStatus.Text = string.Format("Customer #{0}: {1}, {2}",
                currentCustomer.CustomerID, currentCustomer.LastName, currentCustomer.FirstName);
            }
            else
            {
                lblNameStatus.Text = "No Customer Selected";
            }
        }

        private void checkChecking_CheckedChanged(object sender, EventArgs e)
        {
            checkSavings.Checked = !checkChecking.Checked;
        }
        private void checkSavings_CheckedChanged(object sender, EventArgs e)
        {
            checkChecking.Checked = !checkSavings.Checked;
        }
        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            ProgramState = State.ViewAccount;
        }
        private void lstCustomerAccounts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstCustomerAccounts.SelectedItem != null)
            {
                btnEditAccount.Enabled = true;
                btnDeleteAccount.Enabled = true;
            }
            else
            {
                btnEditAccount.Enabled = false;
                btnDeleteAccount.Enabled = false;
            }            
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            Account acc;
            if (ProgramState == State.EditAccount)
                acc = (Account)lstCustomerAccounts.SelectedItem;
            else
                acc = new Account();  
            
            try
            {
                acc.AccountBalance = Convert.ToDecimal(txtAccountDeposit.Text);
                acc.IsAccountOpen = true;
                if (checkChecking.Checked)
                {
                    acc.AccountType = "Checking";
                }
                else
                    acc.AccountType = "Savings";                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
                return;
            }
            if (ProgramState == State.EditAccount)
                DatabaseService.EditAccount(acc);
            else
                DatabaseService.AddAccount(acc, currentCustomer);
            DisplayAccounts();
            ProgramState = State.ViewAccount;
        }  
    }
}
