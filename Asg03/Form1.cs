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
    public partial class MainForm : Form
    {
        public BankUser currentUser = null;

        public MainForm()
        {
            InitializeComponent();            
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            statLabel2.Text = DateTime.Now.ToString();
            if ( currentUser != null ) statLabel1.Text = currentUser.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }  
    }
}
