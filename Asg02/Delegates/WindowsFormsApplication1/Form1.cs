using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {        
        CustomerList<Customer> mainList = new CustomerList<Customer>();        
        int currentIndex;
        
        public Form1()
        {
            InitializeComponent();                        
            mainList.Changed += new CustomerList<Customer>.ChangeHandler(ListChanged);                    
        }

        private void ListChanged()
        {
            lblCustomerAmount.Text = mainList.Count.ToString();           
            lblFirstName.Text = "???";
            lblLastName.Text = "???";
            lblEmailAddress.Text = "???";
            currentIndex = -1;
        }
        private void LabelDisplay(Customer c)
        {
            lblFirstName.Text = c.FirstName;
            lblLastName.Text = c.LastName;
            lblEmailAddress.Text = c.EmailAddress;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            if (editor.ShowDialog() == DialogResult.OK)
            {
                Customer c = new Customer();
                c.FirstName = editor.FirstName;
                c.LastName = editor.LastName;
                c.EmailAddress = editor.EmailAddress;
                mainList.Add(c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mainList.Count; i++)
            {
                string searchString = txtSearchBox.Text;
                if (mainList[i].EmailAddress == searchString)
                {
                    currentIndex = i;
                    Customer c = mainList.GetAt(currentIndex);
                    LabelDisplay(c);                    
                    return;
                }
            }
            try
            {
                int searchIndex = Convert.ToInt32(txtSearchBox.Text);
                Customer c = mainList.GetAt(searchIndex);  
                currentIndex = searchIndex;              
                LabelDisplay(c);               
            }            
            catch
            {
                MessageBox.Show("Invalid index or email address.", "Warning!");
                txtSearchBox.Text = null;
                txtSearchBox.Focus();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex < 0)
            {
                MessageBox.Show("No customer is selected.", "Warning!");
                return;
            }
            else
            {
                Form2 editor = new Form2();
                Customer c = mainList.GetAt(currentIndex);
                editor.FirstName = c.FirstName;
                editor.LastName = c.LastName;
                editor.EmailAddress = c.EmailAddress;
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    c.FirstName = editor.FirstName;
                    c.LastName = editor.LastName;
                    c.EmailAddress = editor.EmailAddress;
                    LabelDisplay(c);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentIndex < 0)
            {
                MessageBox.Show("No customer is selected.", "Warning!");
                return;
            }
            else
                if (MessageBox.Show("Really delete customer?", "Warning!",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Customer c = mainList.GetAt(currentIndex);
                    mainList.Remove(c);
                }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainList.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mainList.Load();
            ListChanged();            
        }
    }
}
