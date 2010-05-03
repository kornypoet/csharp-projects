using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asg03
{
    public partial class LoginScreen : Form
    {
        int loginAttempts = 0;
        public BankUser bankUser = null;

        public LoginScreen()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bankUser = DatabaseService.RetrieveUser(textBox1.Text, maskedTextBox1.Text);
                DialogResult = DialogResult.OK;                
                this.Close();
            }
            catch
            {
                while (loginAttempts < 2)
                {
                    MessageBox.Show("Login unsuccessful!", "Warning!");
                    loginAttempts++;
                    return;
                }
                MessageBox.Show("Too many login attempts!", "Warning!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }  
    }
}
