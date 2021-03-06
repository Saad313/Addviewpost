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
    public partial class PendingPostUser : Form
    {
        public PendingPostUser()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            bool postidspecified = true;
            if(e.ColumnIndex == 0)
            {
                localhost.Post post = server.getpost(e.RowIndex, postidspecified);
                PostDetails pd = new PostDetails();
                pd.setTitle(post.Title);
                pd.setCategory(post.Category);
                pd.setdescription(post.Description);
                pd.Show();
            }
        }

        public void showPending()
        {
            localhost.Service1 server = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = server.getLogPendingPosts();
            dataGridView1.DataSource = bs;

        }

        private void Admin_Approval_Load(object sender, EventArgs e)
        {
            showPending();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            this.Hide();
            R.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPost apo = new AddPost();
            this.Hide();
            apo.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
