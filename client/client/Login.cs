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
                MessageBox.Show("Welcome User");
                AddPost adpost = new AddPost();
                this.Hide();
                adpost.Show();
                
            }
            else if (adminvalid)
            {
                MessageBox.Show("Welcome Admin");
                PendingPostsAdmin adpage = new PendingPostsAdmin();
                this.Hide();
                adpage.Show();
            }

            else
            {
                MessageBox.Show("User Not Found");
            }

        }

        private void lblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration R = new Registration();
            this.Hide();
            R.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Are On LOGIN");
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            this.Hide();
            R.Show();
        }
    }
}
