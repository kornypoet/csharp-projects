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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string FirstName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string LastName
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string EmailAddress
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
