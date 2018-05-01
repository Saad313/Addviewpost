﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            bool valid;
            bool isvalid;
            bool adminvalid;
            bool adminisvalid;
            localhost.Service1 server = new localhost.Service1();
            server.Login_user(txtusername.Text, txtpassword.Text, out valid, out isvalid);
            server.isadmin(txtusername.Text, txtpassword.Text, out adminvalid, out adminisvalid);
            if (valid)
            {
                MessageBox.Show("Welcome");
                
            }
            else if (adminvalid)
            {
                MessageBox.Show("Welcome Admin");  
            }

            else
            {
                MessageBox.Show("User Not Found");
            }

        }
    }
}
