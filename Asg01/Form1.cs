using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Asg01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variable defining the state of the Person object
        public bool isEmployee;
        
        //Method for clearing out textbox entries
        public void ClearText()
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtEmailAddress.Text = null;
            txtAddress.Text = null;
            txtAmountDue.Text = null;
            txtSalary.Text = null;
            txtDateOfAccount.Text = null;
        }

        //Keeping the controls under control
        private void Form1_Load(object sender, EventArgs e)
        {
            lstPersonList.Enabled = true;
            grpControls.Enabled = true;
            grpDetails.Enabled = false;
            grpDetails.Text = "Details";
            grpEditDetails.Visible = false;
            btnCreateReport.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            if (lstPersonList.Items.Count == 0)
            {
                btnCreateReport.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }           
            dtpDateOfBirth.Value = DateTime.Today;
            lblDateOfAccount.Visible = true;
            txtDateOfAccount.Visible = true;
            lblSalary.Visible = true;
            txtSalary.Visible = true;            
        }

        //Select add Employee settings
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            grpControls.Enabled = false;
            grpDetails.Enabled = true;
            grpDetails.Text = "Employee Details";
            grpEditDetails.Visible = true;            
            lblDateOfAccount.Visible = false;
            txtDateOfAccount.Visible = false;
            lstPersonList.SelectedItem = null;
            lstPersonList.Enabled = false;
            isEmployee = true;           
        }
        //Select add Customer settings
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            grpControls.Enabled = false;
            grpDetails.Enabled = true;
            grpDetails.Text = "Customer Details";
            grpEditDetails.Visible = true;            
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lstPersonList.SelectedItem = null;
            lstPersonList.Enabled = false;
            isEmployee = false;           
        }

        //Make sure fields are filled out
        //Removes an old Person if there is one selected
        //Checks state to know whether Employee or Customer
        private void btnAddSave_Click(object sender, EventArgs e)
        {            
            if (txtFirstName.Text == "" || txtLastName.Text == "")
                MessageBox.Show("You need to fill out the first and last name fields.", 
                    "Warning!");
            else
            {
                Person per = (Person)lstPersonList.SelectedItem;
                lstPersonList.Items.Remove(per);
                if (isEmployee)
                {
                    Employee emp = new Employee();
                    emp.FirstName = txtFirstName.Text;
                    emp.LastName = txtLastName.Text;
                    emp.EmailAddress = txtEmailAddress.Text;
                    emp.DateOfBirth = dtpDateOfBirth.Value;
                    emp.MailingAddress = txtAddress.Text;
                    lstPersonList.Items.Add(emp);
                }
                else
                {
                    Customer cust = new Customer();
                    cust.FirstName = txtFirstName.Text;
                    cust.LastName = txtLastName.Text;
                    cust.EmailAddress = txtEmailAddress.Text;
                    cust.DateOfBirth = dtpDateOfBirth.Value;
                    cust.MailingAddress = txtAddress.Text;
                    lstPersonList.Items.Add(cust);
                }
                ClearText();
                Form1_Load(this, e);
            }
        }        

        //Clear and reload everything
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            Form1_Load(this, e);
        }

        //Removes selected Person after checking
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPersonList.SelectedItem == null)
                return;
            if (MessageBox.Show("Really delete this person?", "Warning!",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            else
            {
                Person per = (Person)lstPersonList.SelectedItem;
                lstPersonList.Items.Remove(per);
            }
        }

        //Makes sure editing is possible
        //Adds Person information to appropriate areas
        //Changes state if necessary
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPersonList.SelectedItem == null)
                return;
            grpControls.Enabled = false;
            grpDetails.Enabled = true;
            grpEditDetails.Visible = true;
            if (lstPersonList.SelectedItem.GetType().ToString() == "Asg01.Employee")
            {
                Employee emp = (Employee)lstPersonList.SelectedItem;
                txtFirstName.Text = emp.FirstName;
                txtLastName.Text = emp.LastName;
                txtEmailAddress.Text = emp.EmailAddress;
                dtpDateOfBirth.Value = emp.DateOfBirth;
                txtAddress.Text = emp.MailingAddress;
                txtAmountDue.Text = emp.AmountDue.ToString("C");
                txtSalary.Text = emp.Salary.ToString("C");
                lblDateOfAccount.Visible = false;
                txtDateOfAccount.Visible = false;
                lstPersonList.Enabled = false;
                isEmployee = true;
            }
            else
            {
                Customer cust = (Customer)lstPersonList.SelectedItem;
                txtFirstName.Text = cust.FirstName;
                txtLastName.Text = cust.LastName;
                txtEmailAddress.Text = cust.EmailAddress;
                dtpDateOfBirth.Value = cust.DateOfBirth;
                txtAddress.Text = cust.MailingAddress;
                txtAmountDue.Text = cust.AmountDue.ToString("C");
                txtDateOfAccount.Text = cust.CreationDate.ToShortDateString();
                txtSalary.Visible = false;
                lblSalary.Visible = false;
                lstPersonList.Enabled = false;
                isEmployee = false;
            }
        }

        //Creates report and closes program if selected
        //Loops through the listbox collection printing Employee or Customer data
        private void btnCreateReport_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Would you like to create report and exit program?", 
                "Warning!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            else
            {
                StreamWriter sw = new StreamWriter("Report.txt");

                for (int x = 0; x < lstPersonList.Items.Count; ++x)
                {
                    if (lstPersonList.Items[x].GetType().ToString() == "Asg01.Employee")
                    {
                        Employee emp = (Employee)lstPersonList.Items[x];
                        sw.WriteLine(emp.FirstName + " " + emp.LastName);
                        sw.WriteLine(emp.MailingAddress);
                        sw.WriteLine("Salary: {0}", emp.Salary.ToString("C"));
                        sw.WriteLine();
                    }
                    else
                    {
                        Customer cust = (Customer)lstPersonList.Items[x];
                        sw.WriteLine(cust.FirstName + " " + cust.LastName);
                        sw.WriteLine(cust.MailingAddress);
                        sw.WriteLine("Amount Due: {0}", cust.AmountDue.ToString("C"));
                        sw.WriteLine();
                    }
                }
                sw.Close();
                this.Close();
            }
        }            
    }
}
