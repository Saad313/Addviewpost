﻿namespace client
{
    partial class AddPost
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
            this.lblposttitle = new System.Windows.Forms.Label();
            this.lblpostcategory = new System.Windows.Forms.Label();
            this.lblpostdescription = new System.Windows.Forms.Label();
            this.lblapprovalrequest = new System.Windows.Forms.LinkLabel();
            this.cmdaddpost = new System.Windows.Forms.Button();
            this.txtposttitle = new System.Windows.Forms.TextBox();
            this.txtpostcategory = new System.Windows.Forms.TextBox();
            this.txtpostdescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblposttitle
            // 
            this.lblposttitle.AutoSize = true;
            this.lblposttitle.Location = new System.Drawing.Point(60, 45);
            this.lblposttitle.Name = "lblposttitle";
            this.lblposttitle.Size = new System.Drawing.Size(51, 13);
            this.lblposttitle.TabIndex = 0;
            this.lblposttitle.Text = "Post Title";
            // 
            // lblpostcategory
            // 
            this.lblpostcategory.AutoSize = true;
            this.lblpostcategory.Location = new System.Drawing.Point(60, 96);
            this.lblpostcategory.Name = "lblpostcategory";
            this.lblpostcategory.Size = new System.Drawing.Size(73, 13);
            this.lblpostcategory.TabIndex = 1;
            this.lblpostcategory.Text = "Post Category";
            // 
            // lblpostdescription
            // 
            this.lblpostdescription.AutoSize = true;
            this.lblpostdescription.Location = new System.Drawing.Point(60, 154);
            this.lblpostdescription.Name = "lblpostdescription";
            this.lblpostdescription.Size = new System.Drawing.Size(84, 13);
            this.lblpostdescription.TabIndex = 2;
            this.lblpostdescription.Text = "Post Description";
            // 
            // lblapprovalrequest
            // 
            this.lblapprovalrequest.AutoSize = true;
            this.lblapprovalrequest.Location = new System.Drawing.Point(60, 255);
            this.lblapprovalrequest.Name = "lblapprovalrequest";
            this.lblapprovalrequest.Size = new System.Drawing.Size(50, 13);
            this.lblapprovalrequest.TabIndex = 3;
            this.lblapprovalrequest.TabStop = true;
            this.lblapprovalrequest.Text = "See Post";
            this.lblapprovalrequest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblapprovalrequest_LinkClicked);
            // 
            // cmdaddpost
            // 
            this.cmdaddpost.Location = new System.Drawing.Point(235, 255);
            this.cmdaddpost.Name = "cmdaddpost";
            this.cmdaddpost.Size = new System.Drawing.Size(75, 23);
            this.cmdaddpost.TabIndex = 4;
            this.cmdaddpost.Text = "Add Post";
            this.cmdaddpost.UseVisualStyleBackColor = true;
            this.cmdaddpost.Click += new System.EventHandler(this.cmdaddpost_Click);
            // 
            // txtposttitle
            // 
            this.txtposttitle.Location = new System.Drawing.Point(168, 45);
            this.txtposttitle.Name = "txtposttitle";
            this.txtposttitle.Size = new System.Drawing.Size(100, 20);
            this.txtposttitle.TabIndex = 5;
            // 
            // txtpostcategory
            // 
            this.txtpostcategory.Location = new System.Drawing.Point(168, 96);
            this.txtpostcategory.Name = "txtpostcategory";
            this.txtpostcategory.Size = new System.Drawing.Size(100, 20);
            this.txtpostcategory.TabIndex = 6;
            // 
            // txtpostdescription
            // 
            this.txtpostdescription.Location = new System.Drawing.Point(168, 154);
            this.txtpostdescription.Multiline = true;
            this.txtpostdescription.Name = "txtpostdescription";
            this.txtpostdescription.Size = new System.Drawing.Size(142, 82);
            this.txtpostdescription.TabIndex = 7;
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.txtpostdescription);
            this.Controls.Add(this.txtpostcategory);
            this.Controls.Add(this.txtposttitle);
            this.Controls.Add(this.cmdaddpost);
            this.Controls.Add(this.lblapprovalrequest);
            this.Controls.Add(this.lblpostdescription);
            this.Controls.Add(this.lblpostcategory);
            this.Controls.Add(this.lblposttitle);
            this.Name = "AddPost";
            this.Text = "AddPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblposttitle;
        private System.Windows.Forms.Label lblpostcategory;
        private System.Windows.Forms.Label lblpostdescription;
        private System.Windows.Forms.LinkLabel lblapprovalrequest;
        private System.Windows.Forms.Button cmdaddpost;
        private System.Windows.Forms.TextBox txtposttitle;
        private System.Windows.Forms.TextBox txtpostcategory;
        private System.Windows.Forms.TextBox txtpostdescription;
    }
}